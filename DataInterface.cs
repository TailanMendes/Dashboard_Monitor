using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.IO;

namespace Dashboard_Monitor
{
    public class DataInterface
    {
        public async void getContractData()
        {
            try
            {
                //var web3 = new Web3("https://rinkeby.infura.io/v3/ea9cd517fe4c4782a5f7ee526a578ec5");
                var web3 = new Web3("https://goerli.infura.io/v3/a9990f8e3c9346bf9bfea9becf0ab989");
                //var contractAddress = "0x8398bd7656e8e3ca4Ca8F35445530292368fc1c9";
                var contractAddress = "0xd2b6b56558cfd776b8671580fa298e93b00eca9e";
                var contractHandler = web3.Eth.GetContractHandler(contractAddress);

                /** Function: getMeasure**/
                var getMeasureFunctionReturn = await contractHandler.QueryAsync<GetMeasureFunction, List<string>>();

                storeDataIntoFile(getMeasureFunctionReturn);

                //var message = string.Join(Environment.NewLine, getMeasureFunctionReturn);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void storeDataIntoFile(List<string> getMeasureFunctionReturn)
        {
            string data_path = @"c:\\iaq_data.ms";

            // If file doesnt exists insert all data
            if (!File.Exists(data_path))
            {
                File.AppendAllLines(data_path, getMeasureFunctionReturn);
            }
            else
            {
                StreamReader sr = new StreamReader(data_path);
                var last_line = File.ReadLines(data_path).Last();
                sr.Close();

                UInt32 last_epoch_time = Convert.ToUInt32(getEpochTime(last_line));

                foreach (string s in getMeasureFunctionReturn)
                {
                    UInt32 epoch = Convert.ToUInt32(getEpochTime(s));

                    if (epoch > last_epoch_time)
                    {
                        File.AppendAllText(data_path, s + Environment.NewLine);

                    }

                }
            }

            //File.AppendAllLines(data_path, getMeasureFunctionReturn);                 
        }

        private string getEpochTime(string s)
        {
            string[] subs = s.Split('|');
            string epochtime;

            if (subs.Length == 7)
            {
                epochtime = subs[6];
            } else
            {
                epochtime = subs[2];
            }


            return epochtime;
        }

        public partial class GetMeasureFunction : GetMeasureFunctionBase { }

        [Function("getMeasure", "string[]")]
        public class GetMeasureFunctionBase : FunctionMessage
        {

        }
    }
}

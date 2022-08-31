using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;

namespace Dashboard_Monitor
{
    public partial class frmDashboard : Form
    {
        DataInterface bcInt;

        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            this.bcInt = new DataInterface();

            updateTempChart();

            InitializeTimer();
        }

        private void InitializeTimer()
        {
            // Call this procedure when the application starts.  
            // Set to 5 second.  
            timer1.Interval = 5000;
            timer1.Tick += new EventHandler(DownloadData);


        }

        private void DownloadData(object sender, EventArgs e)
        {
           // this.bcInt.getContractData();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            updateTempChart();
            updateCurrentMeasure();
        }

        private void updateCurrentMeasure()
        {
            string data_path = @"c:\\iaq_data.ms";

            StreamReader sr = new StreamReader(data_path);
            var last_line = File.ReadLines(data_path).Last();

            this.lbTempValue.Text = getTempFromString(last_line) + " °C";

            this.lbHumidityValue.Text = getUmidityFromString(last_line) + "%";

            this.lbCO2Value.Text = getCO2FromString(last_line) + " PPM";

            this.lbTVOCValue.Text = getTVOCFromString(last_line) + " PPM";

            this.lbPM25Value.Text = getPM25FromString(last_line) + " ug/m³";

            this.lbPM10Value.Text = getPM10FromString(last_line) + " ug/m³";

            // Convert Epoch to date time and update label
            this.toolStripSensorReadTime.Text = (DateTimeOffset.FromUnixTimeSeconds(Convert.ToUInt32(getEpochTime(last_line))).ToLocalTime()).ToString();

            sr.Close();
        }

        private void updateTempChart()
        {
            this.chartTemperature.Series[0].Points.Clear();
            this.chartUmidade.Series[0].Points.Clear();
            this.chartCO2.Series[0].Points.Clear();
            this.chartTVOC.Series[0].Points.Clear();
            this.chartPM25.Series[0].Points.Clear();
            this.chartPM25.Series[1].Points.Clear();

            string data_path = @"c:\\iaq_data.ms";

            using (StreamReader reader = new StreamReader(data_path))
            {
                int current_hour = -1;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    double temperature = Convert.ToDouble(getTempFromString(line));
                    double humidity = Convert.ToDouble(getUmidityFromString(line));
                    uint co2 = Convert.ToUInt32(getCO2FromString(line));
                    uint tvoc = Convert.ToUInt32(getTVOCFromString(line));
                    double pm25 = Convert.ToDouble(getPM25FromString(line));
                    double pm10 = Convert.ToDouble(getPM10FromString(line));

                    DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(Convert.ToUInt32(getEpochTime(line))).ToLocalTime();

                    

                    if (dateTimeOffset.Day == 31 & dateTimeOffset.Hour != current_hour)
                    {
                        current_hour = dateTimeOffset.Hour;
                        chartTemperature.Series[0].Points.AddXY(dateTimeOffset.Hour, temperature);
                        chartUmidade.Series[0].Points.AddXY(dateTimeOffset.Hour, humidity);
                        chartCO2.Series[0].Points.AddXY(dateTimeOffset.Hour, co2);
                        chartTVOC.Series[0].Points.AddXY(dateTimeOffset.Hour, tvoc);
                        chartPM25.Series[0].Points.AddXY(dateTimeOffset.Hour, pm25);
                        chartPM25.Series[1].Points.AddXY(dateTimeOffset.Hour, pm10);
                    }
                }
            }
        }

        private string getEpochTime(string s)
        {
            string[] subs = s.Split('|');
            string epochtime;

            if (subs.Length == 7)
            {
                epochtime = subs[6];
            }
            else
            {
                epochtime = subs[2];
            }


            return epochtime;
        }

        private string getTempFromString(String s)
        {
            string[] subs = s.Split('|');
            var sTemp = subs[0];
            return sTemp;
        }

        private string getUmidityFromString(String s)
        {
            string[] subs = s.Split('|');
            var sHum = subs[1];
            return sHum;
        }

        private string getCO2FromString(String s)
        {
            string[] subs = s.Split('|');
            var sCO2 = subs[2];
            return sCO2;
        }

        private string getTVOCFromString(String s)
        {
            string[] subs = s.Split('|');
            var sTVOC = subs[3];
            return sTVOC;
        }

        private string getPM25FromString(String s)
        {
            string[] subs = s.Split('|');
            var sPM25 = subs[4];
            return sPM25;
        }

        private string getPM10FromString(String s)
        {
            string[] subs = s.Split('|');
            var sPM10 = subs[5];
            return sPM10;
        }

        private void chartTemperature_Click(object sender, EventArgs e)
        {

        }
    }
}

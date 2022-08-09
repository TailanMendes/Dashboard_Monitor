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
            // Set to 10 second.  
            timer1.Interval = 10000;
            timer1.Tick += new EventHandler(DownloadData);


        }

        private void DownloadData(object sender, EventArgs e)
        {
            this.bcInt.getContractData();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            updateTempChart();
        }

        private void updateTempChart()
        {
            this.chartTemperature.Series[0].Points.Clear();
            //Series series = this.chartTemperature.Series.Add("Temperature");
            //Series series = this.chartTemperature.Series[0];
            //series.ChartType = SeriesChartType.Area;

            string data_path = @"c:\\iaq_data.ms";

            int serie_count = chartTemperature.Series.Count();
            int count_measures = 0;

            using (StreamReader reader = new StreamReader(data_path))
            {
                int current_hour = -1;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    double temperature = Convert.ToDouble(getTempFromString(line));

                    DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(Convert.ToUInt32(getEpochTime(line)));

                    

                    if (dateTimeOffset.Day == 8 & dateTimeOffset.Hour != current_hour)
                    {
                        current_hour = dateTimeOffset.Hour;
                        //chartTemperature.Series[0].Points.AddXY(dateTimeOffset.Hour, temperature);
                        chartTemperature.Series[0].Points.AddXY(dateTimeOffset.Hour, temperature);
                        count_measures++;
                        

                        //series.Points.AddXY(dateTimeOffset.Hour, temperature);
                    }

                    //series.Points.AddXY(dateTimeOffset.DateTime, temperature);
                }
            }

            /*
            series.Points.AddXY("7", 29);
            series.Points.AddXY("8", 30);
            series.Points.AddXY("9", 31);
            series.Points.AddXY("10", 28);
            series.Points.AddXY("11", 32);
            series.Points.AddXY("12", 33);
            */
        }

        private string getEpochTime(string s)
        {
            string[] subs = s.Split('|');
            var epochtime = subs[2];
            return epochtime;
        }

        private string getTempFromString(String s)
        {
            string[] subs = s.Split('|');
            var sTemp = subs[0];
            return sTemp;
        }

        private void chartTemperature_Click(object sender, EventArgs e)
        {

        }
    }
}

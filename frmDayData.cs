using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Dashboard_Monitor
{
    public partial class frmDayData : Form
    {
        public DateTime date;
        public frmDayData()
        {
            InitializeComponent();
        }

        private void frmDayData_Load(object sender, EventArgs e)
        {
            int count_total = 0;

            double max_temp = -1;
            double min_temp = 50;
            double media_temp = 0;

            double max_humi = -1;
            double min_humi = 100;
            double media_humi = 0;

            uint max_co2 = 0;
            uint min_co2 = 5000;
            double media_co2 = 0;

            double max_tvoc = -1;
            double min_tvoc = 1000;
            double media_tvoc = 0;

            double max_pm25 = -1;
            double min_pm25 = 1000;
            double media_pm25 = 0;

            double max_pm10 = -1;
            double min_pm10 = 10000;
            double media_pm10 = 0;

            this.label1.Text = "RESUMO DO DIA: " + this.date.ToString();

            string data_path = @"c:\\iaq_data.ms";

            using (StreamReader reader = new StreamReader(data_path))
            {
                string line;
                

                while ((line = reader.ReadLine()) != null)
                {
                   
                    DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(Convert.ToUInt32(getEpochTime(line))).ToLocalTime();

                    if ((dateTimeOffset.Day == this.date.Day) && (dateTimeOffset.Month == this.date.Month))
                    {
                        count_total++;

                        double temp = Convert.ToDouble(getTempFromString(line));
                        double humi = Convert.ToDouble(getUmidityFromString(line));
                        uint co2 = Convert.ToUInt32(getCO2FromString(line));
                        double tvoc = getTVOCFromString(line);
                        double pm25 = Convert.ToDouble(getPM25FromString(line));
                        double pm10 = Convert.ToDouble(getPM10FromString(line));

                        max_temp = Math.Max(max_temp, temp);
                        min_temp = Math.Min(min_temp, temp);

                        max_humi = Math.Max(max_humi, humi);
                        min_humi = Math.Min(min_humi, humi);

                        max_co2 = Math.Max(max_co2, co2);
                        min_co2 = Math.Min(min_co2, co2);

                        max_tvoc = Math.Max(max_tvoc, tvoc);
                        min_tvoc = Math.Min(min_tvoc, tvoc);   

                        max_pm25 = Math.Max(max_pm25, pm25);
                        min_pm25 = Math.Min(min_pm25, pm25);

                        max_pm10 = Math.Max(max_pm10, pm10);
                        min_pm10 = Math.Min(min_pm10, pm10);


                        media_temp += temp;
                        media_humi += humi;
                        media_co2 += co2;
                        media_tvoc += tvoc;
                        media_pm25 += pm25;
                        media_pm10 += pm10;
                       
                    }
                }

                if (count_total == 0)
                {
                    MessageBox.Show("Sem dados do dia selecionado!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            media_temp = media_temp / count_total;
            media_humi = media_humi / count_total;
            media_co2 = media_co2 / count_total;
            media_tvoc = media_tvoc / count_total;
            media_pm25 = media_pm25 / count_total;
            media_pm10 = media_pm10 / count_total;

            /** Temperatura **/
            if (media_temp >= 20.0 & media_temp <= 26.0)
            {
                this.dataGridView1.Rows.Add("TEMPERATURA (°C)", max_temp, min_temp, media_temp.ToString("F"), "BOM");
                this.dataGridView1.Rows[0].Cells[4].Style.BackColor = Color.Blue;
            } 
            else if (media_temp >= 26.1 && media_temp <= 29.0)
            {
                this.dataGridView1.Rows.Add("TEMPERATURA (°C)", max_temp, min_temp, media_temp.ToString("F"), "MODERADO");
                this.dataGridView1.Rows[0].Cells[4].Style.BackColor = Color.Green;
            } 
            else if (media_temp >= 29.1 && media_temp <= 39.0)
            {
                this.dataGridView1.Rows.Add("TEMPERATURA (°C)", max_temp, min_temp, media_temp.ToString("F"), "POUCO SALDÁVEL");
                this.dataGridView1.Rows[0].Cells[4].Style.BackColor = Color.Yellow;
            } 
            else if (media_temp > 39.0)
            {
                this.dataGridView1.Rows.Add("TEMPERATURA (°C)", max_temp, min_temp, media_temp.ToString("F"), "PERIGOSO");
                this.dataGridView1.Rows[0].Cells[4].Style.BackColor = Color.Red;
            }

            /** Umidade Relativa  **/
            if (media_humi >= 40.0 & media_humi <= 70.0)
            {
                this.dataGridView1.Rows.Add("UMIDADE (%)", max_humi, min_humi, media_humi.ToString("F"), "BOM");
                this.dataGridView1.Rows[1].Cells[4].Style.BackColor = Color.Blue;
            }
            else if (media_humi >= 70.1 && media_humi <= 80.0)
            {
                this.dataGridView1.Rows.Add("UMIDADE (%)", max_humi, min_humi, media_humi.ToString("F"), "MODERADO");
                this.dataGridView1.Rows[1].Cells[4].Style.BackColor = Color.Green;
            }
            else if (media_humi >= 80.1 && media_humi <= 90.0)
            {
                this.dataGridView1.Rows.Add("UMIDADE (%)", max_humi, min_humi, media_humi.ToString("F"), "POUCO SAUDÁVEL");
                this.dataGridView1.Rows[1].Cells[4].Style.BackColor = Color.Yellow;
            }
            else if (media_humi > 90.0)
            {
                this.dataGridView1.Rows.Add("UMIDADE (%)", max_humi, min_humi, media_humi.ToString("F"), "PERIGOSO");
                this.dataGridView1.Rows[1].Cells[4].Style.BackColor = Color.Red;
            }

            /** CO2 Classificação AQI  **/
            if (media_co2 >= 340.0 & media_co2 <= 600.0)
            {
                this.dataGridView1.Rows.Add("CO2 (PPM)", max_co2, min_co2, media_co2.ToString("F"), "BOM");
                this.dataGridView1.Rows[2].Cells[4].Style.BackColor = Color.Blue;
            }
            else if (media_co2 >= 600.1 && media_co2 <= 1000.0)
            {
                this.dataGridView1.Rows.Add("CO2 (PPM)", max_co2, min_co2, media_co2.ToString("F"), "MODERADO");
                this.dataGridView1.Rows[2].Cells[4].Style.BackColor = Color.Green;
            }
            else if (media_co2 >= 1000.1 && media_co2 <= 1500.0)
            {
                this.dataGridView1.Rows.Add("CO2 (PPM)", max_co2, min_co2, media_co2.ToString("F"), "POUCO SAUDÁVEL");
                this.dataGridView1.Rows[2].Cells[4].Style.BackColor = Color.Yellow;
            }
            else if (media_co2 > 1500.0)
            {
                this.dataGridView1.Rows.Add("CO2 (PPM)", max_co2, min_co2, media_co2.ToString("F"), "PERISOGO");
                this.dataGridView1.Rows[2].Cells[4].Style.BackColor = Color.Red;
            }

            /** TVOC Classificação AQI  **/
            if (media_tvoc >= 0.0 & media_tvoc <= 0.087)
            {
                this.dataGridView1.Rows.Add("TVOC (PPM)", max_tvoc, min_tvoc, Math.Round(media_tvoc, 3), "BOM");
                this.dataGridView1.Rows[3].Cells[4].Style.BackColor = Color.Blue;
            }
            else if (media_tvoc >= 0.088 && media_tvoc <= 0.261)
            {
                this.dataGridView1.Rows.Add("TVOC (PPM)", max_tvoc, min_tvoc, Math.Round(media_tvoc, 3), "MODERADO");
                this.dataGridView1.Rows[3].Cells[4].Style.BackColor = Color.Green;
            }
            else if (media_tvoc >= 0.262 && media_tvoc <= 0.43)
            {
                this.dataGridView1.Rows.Add("TVOC (PPM)", max_tvoc, min_tvoc, Math.Round(media_tvoc, 3), "POUCO SAUDÁVEL");
                this.dataGridView1.Rows[3].Cells[4].Style.BackColor = Color.Yellow;
            }
            else if (media_tvoc > 0.43)
            {
                this.dataGridView1.Rows.Add("TVOC (PPM)", max_tvoc, min_tvoc, Math.Round(media_tvoc, 3), "PERIGOSO");
                this.dataGridView1.Rows[3].Cells[4].Style.BackColor = Color.Red;
            }

            /** PM10 Classificação AQI  **/
            if (media_pm10 >= 0.0 & media_pm10 <= 20.9)
            {
                this.dataGridView1.Rows.Add("PM10 (ug/m³)", max_pm10, min_pm10, media_pm10.ToString("F"), "BOM");
                this.dataGridView1.Rows[4].Cells[4].Style.BackColor = Color.Blue;
            }
            else if (media_pm10 >= 21.0 && media_pm10 <= 150.9)
            {
                this.dataGridView1.Rows.Add("PM10 (ug/m³)", max_pm10, min_pm10, media_pm10.ToString("F"), "MODERADO");
                this.dataGridView1.Rows[4].Cells[4].Style.BackColor = Color.Green;
            }
            else if (media_pm10 >= 151.0 && media_pm10 <= 180.9)
            {
                this.dataGridView1.Rows.Add("PM10 (ug/m³)", max_pm10, min_pm10, media_pm10.ToString("F"), "POUCO SAUDÁVEL");
                this.dataGridView1.Rows[4].Cells[4].Style.BackColor = Color.Yellow;
            }
            else if (media_pm10 > 180.9)
            {
                this.dataGridView1.Rows.Add("PM10 (ug/m³)", max_pm10, min_pm10, media_pm10.ToString("F"), "PERIGOSO");
                this.dataGridView1.Rows[4].Cells[4].Style.BackColor = Color.Red;
            }

            /** PM2.5 Classificação AQI  **/
            if (media_pm25 >= 0.0 & media_pm25 <= 10.1)
            {
                this.dataGridView1.Rows.Add("PM2.5 (ug/m³)", max_pm25, min_pm25, media_pm25.ToString("F"), "BOM");
                this.dataGridView1.Rows[5].Cells[4].Style.BackColor = Color.Blue;
            }
            else if (media_pm25 >= 10.2 && media_pm25 <= 40.1)
            {
                this.dataGridView1.Rows.Add("PM2.5 (ug/m³)", max_pm25, min_pm25, media_pm25.ToString("F"), "MODERADO");
                this.dataGridView1.Rows[5].Cells[4].Style.BackColor = Color.Green;
            }
            else if (media_pm25 >= 40.2 && media_pm25 <= 70.1)
            {
                this.dataGridView1.Rows.Add("PM2.5 (ug/m³)", max_pm25, min_pm25, media_pm25.ToString("F"), "POUCO SAUDÁVEL");
                this.dataGridView1.Rows[5].Cells[4].Style.BackColor = Color.Yellow;
            }
            else if (media_pm25 > 70.1)
            {
                this.dataGridView1.Rows.Add("PM2.5 (ug/m³)", max_pm25, min_pm25, media_pm25.ToString("F"), "PERIGOSO");
                this.dataGridView1.Rows[5].Cells[4].Style.BackColor = Color.Red;
            }

            this.dataGridView1.ClearSelection();

        }

        private string getEpochTime(string s)
        {
            string[] subs = s.Split('|');
            string epochtime;

            epochtime = subs[6];

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

        private double getTVOCFromString(String s)
        {
            string[] subs = s.Split('|');
            double TVOC = Convert.ToDouble(subs[3]);
            return TVOC;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

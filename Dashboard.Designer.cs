namespace Dashboard_Monitor
{
    partial class frmDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chartTemperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnTemp = new System.Windows.Forms.Panel();
            this.lbTempValue = new System.Windows.Forms.Label();
            this.lbTemp = new System.Windows.Forms.Label();
            this.pnHumidity = new System.Windows.Forms.Panel();
            this.lbHumidityValue = new System.Windows.Forms.Label();
            this.lbHumidity = new System.Windows.Forms.Label();
            this.picBoxHumidity = new System.Windows.Forms.PictureBox();
            this.picBoxTemp = new System.Windows.Forms.PictureBox();
            this.lbTimeLastMeasure = new System.Windows.Forms.Label();
            this.lbLastUpdate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).BeginInit();
            this.pnTemp.SuspendLayout();
            this.pnHumidity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHumidity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chartTemperature
            // 
            this.chartTemperature.BackColor = System.Drawing.Color.Gray;
            this.chartTemperature.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea3.AxisX.Interval = 1D;
            chartArea3.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.IsMarginVisible = false;
            chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            chartArea3.AxisX.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.LineWidth = 0;
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.MajorGrid.Interval = 0D;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            chartArea3.AxisX.MajorTickMark.Size = 5F;
            chartArea3.AxisX.Maximum = 23D;
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisX.Title = "Horas";
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            chartArea3.AxisY.Interval = 1D;
            chartArea3.AxisY.IsLabelAutoFit = false;
            chartArea3.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            chartArea3.AxisY.LabelStyle.Format = "0*C";
            chartArea3.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisY.Maximum = 35D;
            chartArea3.AxisY.Minimum = 28D;
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea3.BorderWidth = 5;
            chartArea3.Name = "ChartArea1";
            this.chartTemperature.ChartAreas.Add(chartArea3);
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            this.chartTemperature.Legends.Add(legend3);
            this.chartTemperature.Location = new System.Drawing.Point(12, 191);
            this.chartTemperature.Name = "chartTemperature";
            series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series3.BorderWidth = 5;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series3.Color = System.Drawing.Color.Firebrick;
            series3.Legend = "Legend1";
            series3.LegendText = "Temperatura em °C";
            series3.Name = "Temp";
            series3.ShadowColor = System.Drawing.Color.Transparent;
            this.chartTemperature.Series.Add(series3);
            this.chartTemperature.Size = new System.Drawing.Size(710, 373);
            this.chartTemperature.TabIndex = 0;
            this.chartTemperature.Text = "Temperature";
            title3.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title3.Name = "Title1";
            title3.Text = "Temperatura";
            this.chartTemperature.Titles.Add(title3);
            this.chartTemperature.Click += new System.EventHandler(this.chartTemperature_Click);
            // 
            // pnTemp
            // 
            this.pnTemp.BackColor = System.Drawing.Color.White;
            this.pnTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnTemp.CausesValidation = false;
            this.pnTemp.Controls.Add(this.lbTempValue);
            this.pnTemp.Controls.Add(this.picBoxTemp);
            this.pnTemp.Controls.Add(this.lbTemp);
            this.pnTemp.Location = new System.Drawing.Point(12, 12);
            this.pnTemp.Name = "pnTemp";
            this.pnTemp.Size = new System.Drawing.Size(164, 160);
            this.pnTemp.TabIndex = 1;
            // 
            // lbTempValue
            // 
            this.lbTempValue.AutoSize = true;
            this.lbTempValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTempValue.Location = new System.Drawing.Point(59, 99);
            this.lbTempValue.Name = "lbTempValue";
            this.lbTempValue.Size = new System.Drawing.Size(53, 20);
            this.lbTempValue.TabIndex = 2;
            this.lbTempValue.Text = "25 ºC";
            // 
            // lbTemp
            // 
            this.lbTemp.AutoSize = true;
            this.lbTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTemp.Location = new System.Drawing.Point(28, 119);
            this.lbTemp.Name = "lbTemp";
            this.lbTemp.Size = new System.Drawing.Size(111, 20);
            this.lbTemp.TabIndex = 0;
            this.lbTemp.Text = "Temperatura";
            // 
            // pnHumidity
            // 
            this.pnHumidity.BackColor = System.Drawing.Color.White;
            this.pnHumidity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnHumidity.CausesValidation = false;
            this.pnHumidity.Controls.Add(this.lbHumidityValue);
            this.pnHumidity.Controls.Add(this.picBoxHumidity);
            this.pnHumidity.Controls.Add(this.lbHumidity);
            this.pnHumidity.Location = new System.Drawing.Point(182, 12);
            this.pnHumidity.Name = "pnHumidity";
            this.pnHumidity.Size = new System.Drawing.Size(164, 160);
            this.pnHumidity.TabIndex = 3;
            // 
            // lbHumidityValue
            // 
            this.lbHumidityValue.AutoSize = true;
            this.lbHumidityValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHumidityValue.Location = new System.Drawing.Point(59, 99);
            this.lbHumidityValue.Name = "lbHumidityValue";
            this.lbHumidityValue.Size = new System.Drawing.Size(44, 20);
            this.lbHumidityValue.TabIndex = 2;
            this.lbHumidityValue.Text = "50%";
            // 
            // lbHumidity
            // 
            this.lbHumidity.AutoSize = true;
            this.lbHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHumidity.Location = new System.Drawing.Point(48, 119);
            this.lbHumidity.Name = "lbHumidity";
            this.lbHumidity.Size = new System.Drawing.Size(80, 20);
            this.lbHumidity.TabIndex = 0;
            this.lbHumidity.Text = "Umidade";
            // 
            // picBoxHumidity
            // 
            this.picBoxHumidity.Image = global::Dashboard_Monitor.Properties.Resources.humidity_icon;
            this.picBoxHumidity.Location = new System.Drawing.Point(52, 18);
            this.picBoxHumidity.Name = "picBoxHumidity";
            this.picBoxHumidity.Size = new System.Drawing.Size(60, 69);
            this.picBoxHumidity.TabIndex = 1;
            this.picBoxHumidity.TabStop = false;
            // 
            // picBoxTemp
            // 
            this.picBoxTemp.Image = global::Dashboard_Monitor.Properties.Resources.temperature_termometer_icon;
            this.picBoxTemp.Location = new System.Drawing.Point(52, 18);
            this.picBoxTemp.Name = "picBoxTemp";
            this.picBoxTemp.Size = new System.Drawing.Size(60, 69);
            this.picBoxTemp.TabIndex = 1;
            this.picBoxTemp.TabStop = false;
            // 
            // lbTimeLastMeasure
            // 
            this.lbTimeLastMeasure.AutoSize = true;
            this.lbTimeLastMeasure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeLastMeasure.Location = new System.Drawing.Point(593, 9);
            this.lbTimeLastMeasure.Name = "lbTimeLastMeasure";
            this.lbTimeLastMeasure.Size = new System.Drawing.Size(168, 17);
            this.lbTimeLastMeasure.TabIndex = 4;
            this.lbTimeLastMeasure.Text = "8/10/2022 9:03:26 PM";
            // 
            // lbLastUpdate
            // 
            this.lbLastUpdate.AutoSize = true;
            this.lbLastUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastUpdate.Location = new System.Drawing.Point(401, 9);
            this.lbLastUpdate.Name = "lbLastUpdate";
            this.lbLastUpdate.Size = new System.Drawing.Size(186, 17);
            this.lbLastUpdate.TabIndex = 5;
            this.lbLastUpdate.Text = "Última leitura do sensor:";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(817, 576);
            this.Controls.Add(this.lbLastUpdate);
            this.Controls.Add(this.lbTimeLastMeasure);
            this.Controls.Add(this.pnHumidity);
            this.Controls.Add(this.pnTemp);
            this.Controls.Add(this.chartTemperature);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDashboard";
            this.ShowIcon = false;
            this.Text = "Dashboard Monitor";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).EndInit();
            this.pnTemp.ResumeLayout(false);
            this.pnTemp.PerformLayout();
            this.pnHumidity.ResumeLayout(false);
            this.pnHumidity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHumidity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemperature;
        private System.Windows.Forms.Panel pnTemp;
        private System.Windows.Forms.Label lbTemp;
        private System.Windows.Forms.PictureBox picBoxTemp;
        private System.Windows.Forms.Label lbTempValue;
        private System.Windows.Forms.Panel pnHumidity;
        private System.Windows.Forms.Label lbHumidityValue;
        private System.Windows.Forms.PictureBox picBoxHumidity;
        private System.Windows.Forms.Label lbHumidity;
        private System.Windows.Forms.Label lbTimeLastMeasure;
        private System.Windows.Forms.Label lbLastUpdate;
    }
}


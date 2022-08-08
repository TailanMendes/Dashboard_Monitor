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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chartTemperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).BeginInit();
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
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineWidth = 0;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.Interval = 0D;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            chartArea1.AxisX.MajorTickMark.Size = 5F;
            chartArea1.AxisX.Maximum = 23D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.Title = "Horas";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            chartArea1.AxisY.Interval = 1D;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LabelStyle.Format = "0*C";
            chartArea1.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.Maximum = 35D;
            chartArea1.AxisY.Minimum = 28D;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea1.BorderWidth = 5;
            chartArea1.Name = "ChartArea1";
            this.chartTemperature.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chartTemperature.Legends.Add(legend1);
            this.chartTemperature.Location = new System.Drawing.Point(37, 30);
            this.chartTemperature.Name = "chartTemperature";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Color = System.Drawing.Color.Firebrick;
            series1.Legend = "Legend1";
            series1.LegendText = "Temperatura em °C";
            series1.Name = "Temp";
            series1.ShadowColor = System.Drawing.Color.Transparent;
            this.chartTemperature.Series.Add(series1);
            this.chartTemperature.Size = new System.Drawing.Size(1099, 499);
            this.chartTemperature.TabIndex = 0;
            this.chartTemperature.Text = "Temperature";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title1.Name = "Title1";
            title1.Text = "Temperatura";
            this.chartTemperature.Titles.Add(title1);
            this.chartTemperature.Click += new System.EventHandler(this.chartTemperature_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 576);
            this.Controls.Add(this.chartTemperature);
            this.Name = "frmDashboard";
            this.ShowIcon = false;
            this.Text = "Dashboard Monitor";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemperature;
    }
}


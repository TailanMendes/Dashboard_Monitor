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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title8 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine2 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 440D);
            System.Windows.Forms.DataVisualization.Charting.Title title9 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title10 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title11 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title12 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chartTemperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnTemp = new System.Windows.Forms.Panel();
            this.lbTempValue = new System.Windows.Forms.Label();
            this.lbTemp = new System.Windows.Forms.Label();
            this.pnHumidity = new System.Windows.Forms.Panel();
            this.lbHumidityValue = new System.Windows.Forms.Label();
            this.lbHumidity = new System.Windows.Forms.Label();
            this.chartUmidade = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnCO2 = new System.Windows.Forms.Panel();
            this.lbCO2Value = new System.Windows.Forms.Label();
            this.lbCO2 = new System.Windows.Forms.Label();
            this.pnTVOC = new System.Windows.Forms.Panel();
            this.lbTVOCValue = new System.Windows.Forms.Label();
            this.lbTVOC = new System.Windows.Forms.Label();
            this.pnPM25 = new System.Windows.Forms.Panel();
            this.lbPM25Value = new System.Windows.Forms.Label();
            this.lbPM25 = new System.Windows.Forms.Label();
            this.pnPM10 = new System.Windows.Forms.Panel();
            this.lbPM10Value = new System.Windows.Forms.Label();
            this.lbPM10 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSensorReadTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTEMP = new System.Windows.Forms.TabPage();
            this.tabRH = new System.Windows.Forms.TabPage();
            this.tabCO2 = new System.Windows.Forms.TabPage();
            this.chartCO2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabTVOC = new System.Windows.Forms.TabPage();
            this.chartTVOC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPM25 = new System.Windows.Forms.TabPage();
            this.chartPM25 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPM10 = new System.Windows.Forms.TabPage();
            this.charPM10 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.picBoxPM10 = new System.Windows.Forms.PictureBox();
            this.picBoxPM25 = new System.Windows.Forms.PictureBox();
            this.picBoxTVOC = new System.Windows.Forms.PictureBox();
            this.picBoxCO2 = new System.Windows.Forms.PictureBox();
            this.picBoxHumidity = new System.Windows.Forms.PictureBox();
            this.picBoxTemp = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).BeginInit();
            this.pnTemp.SuspendLayout();
            this.pnHumidity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartUmidade)).BeginInit();
            this.pnCO2.SuspendLayout();
            this.pnTVOC.SuspendLayout();
            this.pnPM25.SuspendLayout();
            this.pnPM10.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabTEMP.SuspendLayout();
            this.tabRH.SuspendLayout();
            this.tabCO2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCO2)).BeginInit();
            this.tabTVOC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTVOC)).BeginInit();
            this.tabPM25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPM25)).BeginInit();
            this.tabPM10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charPM10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPM10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPM25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTVOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCO2)).BeginInit();
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
            this.chartTemperature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.chartTemperature.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            chartArea7.AxisX.Interval = 1D;
            chartArea7.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea7.AxisX.IsLabelAutoFit = false;
            chartArea7.AxisX.IsMarginVisible = false;
            chartArea7.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            chartArea7.AxisX.LineColor = System.Drawing.Color.White;
            chartArea7.AxisX.LineWidth = 0;
            chartArea7.AxisX.MajorGrid.Interval = 1D;
            chartArea7.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea7.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea7.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            chartArea7.AxisX.MajorTickMark.Size = 2F;
            chartArea7.AxisX.Maximum = 23D;
            chartArea7.AxisX.Minimum = 0D;
            chartArea7.AxisX.Title = "Horas";
            chartArea7.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            chartArea7.AxisX2.MajorGrid.Enabled = false;
            chartArea7.AxisX2.MajorGrid.Interval = 1D;
            chartArea7.AxisY.Interval = 1D;
            chartArea7.AxisY.IsLabelAutoFit = false;
            chartArea7.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            chartArea7.AxisY.LabelStyle.Interval = 2D;
            chartArea7.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea7.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea7.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea7.AxisY.MajorTickMark.Enabled = false;
            chartArea7.AxisY.Maximum = 40D;
            chartArea7.AxisY.Minimum = 20D;
            chartArea7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea7.BorderWidth = 5;
            chartArea7.Name = "ChartArea1";
            this.chartTemperature.ChartAreas.Add(chartArea7);
            legend7.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            legend7.IsTextAutoFit = false;
            legend7.Name = "Legend1";
            this.chartTemperature.Legends.Add(legend7);
            this.chartTemperature.Location = new System.Drawing.Point(3, 3);
            this.chartTemperature.Name = "chartTemperature";
            series8.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            series8.BorderWidth = 4;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series8.Color = System.Drawing.Color.Firebrick;
            series8.Legend = "Legend1";
            series8.LegendText = "Temperatura em °C";
            series8.Name = "Temp";
            series8.ShadowColor = System.Drawing.Color.Transparent;
            this.chartTemperature.Series.Add(series8);
            this.chartTemperature.Size = new System.Drawing.Size(1012, 359);
            this.chartTemperature.TabIndex = 0;
            this.chartTemperature.Text = "Temperature";
            title7.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title7.Name = "Title1";
            title7.Text = "Temperatura";
            this.chartTemperature.Titles.Add(title7);
            this.chartTemperature.Click += new System.EventHandler(this.chartTemperature_Click);
            // 
            // pnTemp
            // 
            this.pnTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(209)))), ((int)(((byte)(227)))));
            this.pnTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnTemp.CausesValidation = false;
            this.pnTemp.Controls.Add(this.lbTempValue);
            this.pnTemp.Controls.Add(this.picBoxTemp);
            this.pnTemp.Controls.Add(this.lbTemp);
            this.pnTemp.Location = new System.Drawing.Point(6, 8);
            this.pnTemp.Name = "pnTemp";
            this.pnTemp.Size = new System.Drawing.Size(164, 160);
            this.pnTemp.TabIndex = 1;
            // 
            // lbTempValue
            // 
            this.lbTempValue.AutoSize = true;
            this.lbTempValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTempValue.Location = new System.Drawing.Point(59, 125);
            this.lbTempValue.Name = "lbTempValue";
            this.lbTempValue.Size = new System.Drawing.Size(53, 20);
            this.lbTempValue.TabIndex = 2;
            this.lbTempValue.Text = "25 ºC";
            // 
            // lbTemp
            // 
            this.lbTemp.AutoSize = true;
            this.lbTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTemp.Location = new System.Drawing.Point(53, 10);
            this.lbTemp.Name = "lbTemp";
            this.lbTemp.Size = new System.Drawing.Size(56, 20);
            this.lbTemp.TabIndex = 0;
            this.lbTemp.Text = "TEMP";
            // 
            // pnHumidity
            // 
            this.pnHumidity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(209)))), ((int)(((byte)(227)))));
            this.pnHumidity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnHumidity.CausesValidation = false;
            this.pnHumidity.Controls.Add(this.lbHumidityValue);
            this.pnHumidity.Controls.Add(this.picBoxHumidity);
            this.pnHumidity.Controls.Add(this.lbHumidity);
            this.pnHumidity.Location = new System.Drawing.Point(175, 8);
            this.pnHumidity.Name = "pnHumidity";
            this.pnHumidity.Size = new System.Drawing.Size(164, 160);
            this.pnHumidity.TabIndex = 3;
            // 
            // lbHumidityValue
            // 
            this.lbHumidityValue.AutoSize = true;
            this.lbHumidityValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHumidityValue.Location = new System.Drawing.Point(59, 123);
            this.lbHumidityValue.Name = "lbHumidityValue";
            this.lbHumidityValue.Size = new System.Drawing.Size(44, 20);
            this.lbHumidityValue.TabIndex = 2;
            this.lbHumidityValue.Text = "50%";
            // 
            // lbHumidity
            // 
            this.lbHumidity.AutoSize = true;
            this.lbHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHumidity.Location = new System.Drawing.Point(63, 11);
            this.lbHumidity.Name = "lbHumidity";
            this.lbHumidity.Size = new System.Drawing.Size(35, 20);
            this.lbHumidity.TabIndex = 0;
            this.lbHumidity.Text = "RH";
            // 
            // chartUmidade
            // 
            this.chartUmidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.chartUmidade.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            chartArea8.AxisX.Interval = 1D;
            chartArea8.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea8.AxisX.IsLabelAutoFit = false;
            chartArea8.AxisX.IsMarginVisible = false;
            chartArea8.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            chartArea8.AxisX.LineColor = System.Drawing.Color.White;
            chartArea8.AxisX.LineWidth = 0;
            chartArea8.AxisX.MajorGrid.Enabled = false;
            chartArea8.AxisX.MajorGrid.Interval = 0D;
            chartArea8.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea8.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            chartArea8.AxisX.MajorTickMark.Size = 2F;
            chartArea8.AxisX.Maximum = 23D;
            chartArea8.AxisX.Minimum = 0D;
            chartArea8.AxisX.Title = "Horas";
            chartArea8.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            chartArea8.AxisY.Interval = 10D;
            chartArea8.AxisY.IsLabelAutoFit = false;
            chartArea8.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            chartArea8.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea8.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea8.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea8.AxisY.MajorTickMark.Enabled = false;
            chartArea8.AxisY.Maximum = 80D;
            chartArea8.AxisY.Minimum = 30D;
            chartArea8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea8.BorderWidth = 5;
            chartArea8.Name = "ChartArea1";
            this.chartUmidade.ChartAreas.Add(chartArea8);
            legend8.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            legend8.IsTextAutoFit = false;
            legend8.Name = "Legend1";
            this.chartUmidade.Legends.Add(legend8);
            this.chartUmidade.Location = new System.Drawing.Point(3, 3);
            this.chartUmidade.Name = "chartUmidade";
            series9.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series9.BorderWidth = 5;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series9.Color = System.Drawing.Color.Firebrick;
            series9.Legend = "Legend1";
            series9.LegendText = "Umidade Relativa %";
            series9.Name = "Temp";
            series9.ShadowColor = System.Drawing.Color.Transparent;
            this.chartUmidade.Series.Add(series9);
            this.chartUmidade.Size = new System.Drawing.Size(1012, 405);
            this.chartUmidade.TabIndex = 6;
            this.chartUmidade.Text = "Temperature";
            title8.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title8.Name = "Title1";
            title8.Text = "Umidade";
            this.chartUmidade.Titles.Add(title8);
            // 
            // pnCO2
            // 
            this.pnCO2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(209)))), ((int)(((byte)(227)))));
            this.pnCO2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnCO2.CausesValidation = false;
            this.pnCO2.Controls.Add(this.lbCO2Value);
            this.pnCO2.Controls.Add(this.picBoxCO2);
            this.pnCO2.Controls.Add(this.lbCO2);
            this.pnCO2.Location = new System.Drawing.Point(344, 8);
            this.pnCO2.Name = "pnCO2";
            this.pnCO2.Size = new System.Drawing.Size(164, 160);
            this.pnCO2.TabIndex = 4;
            // 
            // lbCO2Value
            // 
            this.lbCO2Value.AutoSize = true;
            this.lbCO2Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCO2Value.Location = new System.Drawing.Point(41, 121);
            this.lbCO2Value.Name = "lbCO2Value";
            this.lbCO2Value.Size = new System.Drawing.Size(80, 20);
            this.lbCO2Value.TabIndex = 2;
            this.lbCO2Value.Text = "400 PPM";
            // 
            // lbCO2
            // 
            this.lbCO2.AutoSize = true;
            this.lbCO2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCO2.Location = new System.Drawing.Point(59, 10);
            this.lbCO2.Name = "lbCO2";
            this.lbCO2.Size = new System.Drawing.Size(44, 20);
            this.lbCO2.TabIndex = 0;
            this.lbCO2.Text = "CO2";
            // 
            // pnTVOC
            // 
            this.pnTVOC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(209)))), ((int)(((byte)(227)))));
            this.pnTVOC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnTVOC.CausesValidation = false;
            this.pnTVOC.Controls.Add(this.lbTVOCValue);
            this.pnTVOC.Controls.Add(this.picBoxTVOC);
            this.pnTVOC.Controls.Add(this.lbTVOC);
            this.pnTVOC.Location = new System.Drawing.Point(513, 8);
            this.pnTVOC.Name = "pnTVOC";
            this.pnTVOC.Size = new System.Drawing.Size(164, 160);
            this.pnTVOC.TabIndex = 5;
            // 
            // lbTVOCValue
            // 
            this.lbTVOCValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTVOCValue.Location = new System.Drawing.Point(13, 116);
            this.lbTVOCValue.Name = "lbTVOCValue";
            this.lbTVOCValue.Size = new System.Drawing.Size(137, 20);
            this.lbTVOCValue.TabIndex = 2;
            this.lbTVOCValue.Text = "0.2 PPM";
            this.lbTVOCValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTVOC
            // 
            this.lbTVOC.AutoSize = true;
            this.lbTVOC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTVOC.Location = new System.Drawing.Point(53, 6);
            this.lbTVOC.Name = "lbTVOC";
            this.lbTVOC.Size = new System.Drawing.Size(56, 20);
            this.lbTVOC.TabIndex = 0;
            this.lbTVOC.Text = "TVOC";
            // 
            // pnPM25
            // 
            this.pnPM25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(209)))), ((int)(((byte)(227)))));
            this.pnPM25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnPM25.CausesValidation = false;
            this.pnPM25.Controls.Add(this.lbPM25Value);
            this.pnPM25.Controls.Add(this.picBoxPM25);
            this.pnPM25.Controls.Add(this.lbPM25);
            this.pnPM25.Location = new System.Drawing.Point(684, 8);
            this.pnPM25.Name = "pnPM25";
            this.pnPM25.Size = new System.Drawing.Size(164, 160);
            this.pnPM25.TabIndex = 5;
            // 
            // lbPM25Value
            // 
            this.lbPM25Value.AutoSize = true;
            this.lbPM25Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPM25Value.Location = new System.Drawing.Point(39, 116);
            this.lbPM25Value.Name = "lbPM25Value";
            this.lbPM25Value.Size = new System.Drawing.Size(94, 20);
            this.lbPM25Value.TabIndex = 2;
            this.lbPM25Value.Text = "20.5 ug/m³";
            // 
            // lbPM25
            // 
            this.lbPM25.AutoSize = true;
            this.lbPM25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPM25.Location = new System.Drawing.Point(55, 6);
            this.lbPM25.Name = "lbPM25";
            this.lbPM25.Size = new System.Drawing.Size(54, 20);
            this.lbPM25.TabIndex = 0;
            this.lbPM25.Text = "PM25";
            // 
            // pnPM10
            // 
            this.pnPM10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(209)))), ((int)(((byte)(227)))));
            this.pnPM10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnPM10.CausesValidation = false;
            this.pnPM10.Controls.Add(this.lbPM10Value);
            this.pnPM10.Controls.Add(this.picBoxPM10);
            this.pnPM10.Controls.Add(this.lbPM10);
            this.pnPM10.Location = new System.Drawing.Point(854, 8);
            this.pnPM10.Name = "pnPM10";
            this.pnPM10.Size = new System.Drawing.Size(164, 160);
            this.pnPM10.TabIndex = 7;
            // 
            // lbPM10Value
            // 
            this.lbPM10Value.AutoSize = true;
            this.lbPM10Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPM10Value.Location = new System.Drawing.Point(42, 116);
            this.lbPM10Value.Name = "lbPM10Value";
            this.lbPM10Value.Size = new System.Drawing.Size(84, 20);
            this.lbPM10Value.TabIndex = 2;
            this.lbPM10Value.Text = "1.5 ug/m³";
            // 
            // lbPM10
            // 
            this.lbPM10.AutoSize = true;
            this.lbPM10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPM10.Location = new System.Drawing.Point(53, 6);
            this.lbPM10.Name = "lbPM10";
            this.lbPM10.Size = new System.Drawing.Size(54, 20);
            this.lbPM10.TabIndex = 0;
            this.lbPM10.Text = "PM10";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripSensorReadTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 623);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1031, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(186, 17);
            this.toolStripStatusLabel1.Text = "Última leitura do sensor:";
            // 
            // toolStripSensorReadTime
            // 
            this.toolStripSensorReadTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.toolStripSensorReadTime.Name = "toolStripSensorReadTime";
            this.toolStripSensorReadTime.Size = new System.Drawing.Size(0, 17);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTEMP);
            this.tabControl1.Controls.Add(this.tabRH);
            this.tabControl1.Controls.Add(this.tabCO2);
            this.tabControl1.Controls.Add(this.tabTVOC);
            this.tabControl1.Controls.Add(this.tabPM25);
            this.tabControl1.Controls.Add(this.tabPM10);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabControl1.ItemSize = new System.Drawing.Size(50, 20);
            this.tabControl1.Location = new System.Drawing.Point(0, 224);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1026, 396);
            this.tabControl1.TabIndex = 12;
            // 
            // tabTEMP
            // 
            this.tabTEMP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.tabTEMP.Controls.Add(this.chartTemperature);
            this.tabTEMP.Location = new System.Drawing.Point(4, 24);
            this.tabTEMP.Name = "tabTEMP";
            this.tabTEMP.Padding = new System.Windows.Forms.Padding(3);
            this.tabTEMP.Size = new System.Drawing.Size(1018, 368);
            this.tabTEMP.TabIndex = 0;
            this.tabTEMP.Text = "TEMP";
            // 
            // tabRH
            // 
            this.tabRH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.tabRH.Controls.Add(this.chartUmidade);
            this.tabRH.Location = new System.Drawing.Point(4, 24);
            this.tabRH.Name = "tabRH";
            this.tabRH.Padding = new System.Windows.Forms.Padding(3);
            this.tabRH.Size = new System.Drawing.Size(1018, 358);
            this.tabRH.TabIndex = 1;
            this.tabRH.Text = "RH%";
            // 
            // tabCO2
            // 
            this.tabCO2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.tabCO2.Controls.Add(this.chartCO2);
            this.tabCO2.Location = new System.Drawing.Point(4, 24);
            this.tabCO2.Name = "tabCO2";
            this.tabCO2.Size = new System.Drawing.Size(1018, 358);
            this.tabCO2.TabIndex = 2;
            this.tabCO2.Text = "CO2";
            // 
            // chartCO2
            // 
            this.chartCO2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.chartCO2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            chartArea9.AxisX.Interval = 1D;
            chartArea9.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea9.AxisX.IsLabelAutoFit = false;
            chartArea9.AxisX.IsMarginVisible = false;
            chartArea9.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            chartArea9.AxisX.LineColor = System.Drawing.Color.White;
            chartArea9.AxisX.LineWidth = 0;
            chartArea9.AxisX.MajorGrid.Enabled = false;
            chartArea9.AxisX.MajorGrid.Interval = 0D;
            chartArea9.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea9.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            chartArea9.AxisX.MajorTickMark.Size = 2F;
            chartArea9.AxisX.Maximum = 23D;
            chartArea9.AxisX.Minimum = 0D;
            chartArea9.AxisX.Title = "Horas";
            chartArea9.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            chartArea9.AxisY.Interval = 50D;
            chartArea9.AxisY.IsLabelAutoFit = false;
            chartArea9.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            chartArea9.AxisY.LabelStyle.Interval = 200D;
            chartArea9.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea9.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea9.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea9.AxisY.MajorTickMark.Enabled = false;
            chartArea9.AxisY.Maximum = 2000D;
            chartArea9.AxisY.Minimum = 200D;
            stripLine2.BorderColor = System.Drawing.Color.Lime;
            stripLine2.BorderWidth = 2;
            chartArea9.AxisY.StripLines.Add(stripLine2);
            chartArea9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea9.BorderWidth = 5;
            chartArea9.Name = "ChartArea1";
            this.chartCO2.ChartAreas.Add(chartArea9);
            legend9.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            legend9.IsTextAutoFit = false;
            legend9.Name = "Legend1";
            this.chartCO2.Legends.Add(legend9);
            this.chartCO2.Location = new System.Drawing.Point(3, 3);
            this.chartCO2.Name = "chartCO2";
            series10.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series10.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            series10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            series10.BorderWidth = 3;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series10.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(127)))));
            series10.Legend = "Legend1";
            series10.LegendText = "CO2 em PPM";
            series10.Name = "CO2";
            series10.Points.Add(dataPoint2);
            series10.ShadowColor = System.Drawing.Color.Transparent;
            this.chartCO2.Series.Add(series10);
            this.chartCO2.Size = new System.Drawing.Size(1012, 405);
            this.chartCO2.TabIndex = 1;
            this.chartCO2.Text = "CO2";
            title9.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title9.Name = "Title1";
            title9.Text = "Dióxido de Carbono (CO2)";
            this.chartCO2.Titles.Add(title9);
            // 
            // tabTVOC
            // 
            this.tabTVOC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.tabTVOC.Controls.Add(this.chartTVOC);
            this.tabTVOC.Location = new System.Drawing.Point(4, 24);
            this.tabTVOC.Name = "tabTVOC";
            this.tabTVOC.Size = new System.Drawing.Size(1018, 358);
            this.tabTVOC.TabIndex = 3;
            this.tabTVOC.Text = "TVOC";
            // 
            // chartTVOC
            // 
            this.chartTVOC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.chartTVOC.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            chartArea10.AxisX.Interval = 1D;
            chartArea10.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea10.AxisX.IsLabelAutoFit = false;
            chartArea10.AxisX.IsMarginVisible = false;
            chartArea10.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            chartArea10.AxisX.LineColor = System.Drawing.Color.White;
            chartArea10.AxisX.LineWidth = 0;
            chartArea10.AxisX.MajorGrid.Enabled = false;
            chartArea10.AxisX.MajorGrid.Interval = 0D;
            chartArea10.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea10.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            chartArea10.AxisX.MajorTickMark.Size = 2F;
            chartArea10.AxisX.Maximum = 23D;
            chartArea10.AxisX.Minimum = 0D;
            chartArea10.AxisX.Title = "Horas";
            chartArea10.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            chartArea10.AxisY.Interval = 15D;
            chartArea10.AxisY.IsLabelAutoFit = false;
            chartArea10.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            chartArea10.AxisY.LabelStyle.Interval = 50D;
            chartArea10.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea10.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea10.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea10.AxisY.MajorTickMark.Enabled = false;
            chartArea10.AxisY.Maximum = 500D;
            chartArea10.AxisY.Minimum = 0D;
            chartArea10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea10.BorderWidth = 5;
            chartArea10.Name = "ChartArea1";
            this.chartTVOC.ChartAreas.Add(chartArea10);
            legend10.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            legend10.IsTextAutoFit = false;
            legend10.Name = "Legend1";
            this.chartTVOC.Legends.Add(legend10);
            this.chartTVOC.Location = new System.Drawing.Point(3, 3);
            this.chartTVOC.Name = "chartTVOC";
            series11.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series11.BorderWidth = 5;
            series11.ChartArea = "ChartArea1";
            series11.Color = System.Drawing.Color.Firebrick;
            series11.Legend = "Legend1";
            series11.LegendText = "TVOC em PPM";
            series11.Name = "TVOC";
            series11.ShadowColor = System.Drawing.Color.Transparent;
            this.chartTVOC.Series.Add(series11);
            this.chartTVOC.Size = new System.Drawing.Size(1012, 374);
            this.chartTVOC.TabIndex = 1;
            title10.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title10.Name = "Title1";
            title10.Text = "TVOC - Total Volitile Organic Compound";
            this.chartTVOC.Titles.Add(title10);
            // 
            // tabPM25
            // 
            this.tabPM25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.tabPM25.Controls.Add(this.chartPM25);
            this.tabPM25.Location = new System.Drawing.Point(4, 24);
            this.tabPM25.Name = "tabPM25";
            this.tabPM25.Size = new System.Drawing.Size(1018, 358);
            this.tabPM25.TabIndex = 4;
            this.tabPM25.Text = "PM2.5";
            // 
            // chartPM25
            // 
            this.chartPM25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.chartPM25.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            chartArea11.AxisX.Interval = 1D;
            chartArea11.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea11.AxisX.IsLabelAutoFit = false;
            chartArea11.AxisX.IsMarginVisible = false;
            chartArea11.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            chartArea11.AxisX.LineColor = System.Drawing.Color.White;
            chartArea11.AxisX.LineWidth = 0;
            chartArea11.AxisX.MajorGrid.Enabled = false;
            chartArea11.AxisX.MajorGrid.Interval = 0D;
            chartArea11.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea11.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            chartArea11.AxisX.MajorTickMark.Size = 2F;
            chartArea11.AxisX.Maximum = 23D;
            chartArea11.AxisX.Minimum = 0D;
            chartArea11.AxisX.Title = "Horas";
            chartArea11.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            chartArea11.AxisY.Interval = 0.1D;
            chartArea11.AxisY.IsLabelAutoFit = false;
            chartArea11.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            chartArea11.AxisY.LabelStyle.Format = "0.00";
            chartArea11.AxisY.LabelStyle.Interval = 0.25D;
            chartArea11.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea11.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea11.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea11.AxisY.MajorTickMark.Enabled = false;
            chartArea11.AxisY.Maximum = 3D;
            chartArea11.AxisY.Minimum = 0D;
            chartArea11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea11.BorderWidth = 5;
            chartArea11.Name = "ChartArea1";
            this.chartPM25.ChartAreas.Add(chartArea11);
            legend11.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            legend11.IsTextAutoFit = false;
            legend11.Name = "Legend1";
            this.chartPM25.Legends.Add(legend11);
            this.chartPM25.Location = new System.Drawing.Point(3, 3);
            this.chartPM25.Name = "chartPM25";
            series12.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series12.BorderWidth = 5;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series12.Color = System.Drawing.Color.Firebrick;
            series12.Legend = "Legend1";
            series12.LegendText = "PM 2.5";
            series12.Name = "pm25";
            series12.ShadowColor = System.Drawing.Color.Transparent;
            series13.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series13.Color = System.Drawing.Color.Gold;
            series13.Legend = "Legend1";
            series13.LegendText = "PM 10";
            series13.Name = "pm10";
            series13.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chartPM25.Series.Add(series12);
            this.chartPM25.Series.Add(series13);
            this.chartPM25.Size = new System.Drawing.Size(1012, 405);
            this.chartPM25.TabIndex = 1;
            title11.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title11.Name = "Title1";
            title11.Text = "PM2.5 & PM10";
            this.chartPM25.Titles.Add(title11);
            // 
            // tabPM10
            // 
            this.tabPM10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.tabPM10.Controls.Add(this.charPM10);
            this.tabPM10.Location = new System.Drawing.Point(4, 24);
            this.tabPM10.Name = "tabPM10";
            this.tabPM10.Size = new System.Drawing.Size(1018, 358);
            this.tabPM10.TabIndex = 5;
            this.tabPM10.Text = "PM10";
            // 
            // charPM10
            // 
            this.charPM10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.charPM10.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            chartArea12.AxisX.Interval = 1D;
            chartArea12.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea12.AxisX.IsLabelAutoFit = false;
            chartArea12.AxisX.IsMarginVisible = false;
            chartArea12.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            chartArea12.AxisX.LineColor = System.Drawing.Color.White;
            chartArea12.AxisX.LineWidth = 0;
            chartArea12.AxisX.MajorGrid.Enabled = false;
            chartArea12.AxisX.MajorGrid.Interval = 0D;
            chartArea12.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea12.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            chartArea12.AxisX.MajorTickMark.Size = 2F;
            chartArea12.AxisX.Maximum = 23D;
            chartArea12.AxisX.Minimum = 0D;
            chartArea12.AxisX.Title = "Horas";
            chartArea12.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            chartArea12.AxisY.Interval = 2D;
            chartArea12.AxisY.IsLabelAutoFit = false;
            chartArea12.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            chartArea12.AxisY.LabelStyle.Format = "0*C";
            chartArea12.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea12.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea12.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea12.AxisY.MajorTickMark.Enabled = false;
            chartArea12.AxisY.Maximum = 35D;
            chartArea12.AxisY.Minimum = 20D;
            chartArea12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea12.BorderWidth = 5;
            chartArea12.Name = "ChartArea1";
            this.charPM10.ChartAreas.Add(chartArea12);
            legend12.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            legend12.IsTextAutoFit = false;
            legend12.Name = "Legend1";
            this.charPM10.Legends.Add(legend12);
            this.charPM10.Location = new System.Drawing.Point(3, 3);
            this.charPM10.Name = "charPM10";
            series14.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series14.BorderWidth = 5;
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series14.Color = System.Drawing.Color.Firebrick;
            series14.Legend = "Legend1";
            series14.LegendText = "Temperatura em °C";
            series14.Name = "Temp";
            series14.ShadowColor = System.Drawing.Color.Transparent;
            this.charPM10.Series.Add(series14);
            this.charPM10.Size = new System.Drawing.Size(1012, 405);
            this.charPM10.TabIndex = 1;
            this.charPM10.Text = "Temperature";
            title12.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title12.Name = "Title1";
            title12.Text = "Temperatura";
            this.charPM10.Titles.Add(title12);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 178);
            this.panel1.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 198);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // picBoxPM10
            // 
            this.picBoxPM10.Image = global::Dashboard_Monitor.Properties.Resources._10;
            this.picBoxPM10.Location = new System.Drawing.Point(52, 35);
            this.picBoxPM10.Name = "picBoxPM10";
            this.picBoxPM10.Size = new System.Drawing.Size(60, 69);
            this.picBoxPM10.TabIndex = 1;
            this.picBoxPM10.TabStop = false;
            // 
            // picBoxPM25
            // 
            this.picBoxPM25.Image = global::Dashboard_Monitor.Properties.Resources.pm2_5_icon;
            this.picBoxPM25.Location = new System.Drawing.Point(52, 35);
            this.picBoxPM25.Name = "picBoxPM25";
            this.picBoxPM25.Size = new System.Drawing.Size(60, 69);
            this.picBoxPM25.TabIndex = 1;
            this.picBoxPM25.TabStop = false;
            // 
            // picBoxTVOC
            // 
            this.picBoxTVOC.Image = global::Dashboard_Monitor.Properties.Resources.tvoc_icon;
            this.picBoxTVOC.Location = new System.Drawing.Point(53, 35);
            this.picBoxTVOC.Name = "picBoxTVOC";
            this.picBoxTVOC.Size = new System.Drawing.Size(60, 69);
            this.picBoxTVOC.TabIndex = 1;
            this.picBoxTVOC.TabStop = false;
            // 
            // picBoxCO2
            // 
            this.picBoxCO2.Image = global::Dashboard_Monitor.Properties.Resources.co2_icon;
            this.picBoxCO2.Location = new System.Drawing.Point(52, 40);
            this.picBoxCO2.Name = "picBoxCO2";
            this.picBoxCO2.Size = new System.Drawing.Size(60, 69);
            this.picBoxCO2.TabIndex = 1;
            this.picBoxCO2.TabStop = false;
            // 
            // picBoxHumidity
            // 
            this.picBoxHumidity.Image = global::Dashboard_Monitor.Properties.Resources.humidity_icon;
            this.picBoxHumidity.Location = new System.Drawing.Point(52, 42);
            this.picBoxHumidity.Name = "picBoxHumidity";
            this.picBoxHumidity.Size = new System.Drawing.Size(60, 69);
            this.picBoxHumidity.TabIndex = 1;
            this.picBoxHumidity.TabStop = false;
            // 
            // picBoxTemp
            // 
            this.picBoxTemp.Image = global::Dashboard_Monitor.Properties.Resources.temperature_termometer_icon;
            this.picBoxTemp.Location = new System.Drawing.Point(52, 44);
            this.picBoxTemp.Name = "picBoxTemp";
            this.picBoxTemp.Size = new System.Drawing.Size(60, 69);
            this.picBoxTemp.TabIndex = 1;
            this.picBoxTemp.TabStop = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(212, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 25);
            this.button2.TabIndex = 16;
            this.button2.Text = "RELATÓRIO IAQ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1031, 645);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnPM10);
            this.Controls.Add(this.pnPM25);
            this.Controls.Add(this.pnTVOC);
            this.Controls.Add(this.pnCO2);
            this.Controls.Add(this.pnHumidity);
            this.Controls.Add(this.pnTemp);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDashboard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard Monitor";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).EndInit();
            this.pnTemp.ResumeLayout(false);
            this.pnTemp.PerformLayout();
            this.pnHumidity.ResumeLayout(false);
            this.pnHumidity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartUmidade)).EndInit();
            this.pnCO2.ResumeLayout(false);
            this.pnCO2.PerformLayout();
            this.pnTVOC.ResumeLayout(false);
            this.pnTVOC.PerformLayout();
            this.pnPM25.ResumeLayout(false);
            this.pnPM25.PerformLayout();
            this.pnPM10.ResumeLayout(false);
            this.pnPM10.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabTEMP.ResumeLayout(false);
            this.tabRH.ResumeLayout(false);
            this.tabCO2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCO2)).EndInit();
            this.tabTVOC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTVOC)).EndInit();
            this.tabPM25.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPM25)).EndInit();
            this.tabPM10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.charPM10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPM10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPM25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTVOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCO2)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chartUmidade;
        private System.Windows.Forms.Panel pnCO2;
        private System.Windows.Forms.Label lbCO2Value;
        private System.Windows.Forms.PictureBox picBoxCO2;
        private System.Windows.Forms.Label lbCO2;
        private System.Windows.Forms.Panel pnTVOC;
        private System.Windows.Forms.Label lbTVOCValue;
        private System.Windows.Forms.PictureBox picBoxTVOC;
        private System.Windows.Forms.Label lbTVOC;
        private System.Windows.Forms.Panel pnPM25;
        private System.Windows.Forms.Label lbPM25Value;
        private System.Windows.Forms.PictureBox picBoxPM25;
        private System.Windows.Forms.Label lbPM25;
        private System.Windows.Forms.Panel pnPM10;
        private System.Windows.Forms.Label lbPM10Value;
        private System.Windows.Forms.PictureBox picBoxPM10;
        private System.Windows.Forms.Label lbPM10;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripSensorReadTime;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTEMP;
        private System.Windows.Forms.TabPage tabRH;
        private System.Windows.Forms.TabPage tabCO2;
        private System.Windows.Forms.TabPage tabTVOC;
        private System.Windows.Forms.TabPage tabPM25;
        private System.Windows.Forms.TabPage tabPM10;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCO2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTVOC;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPM25;
        private System.Windows.Forms.DataVisualization.Charting.Chart charPM10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
    }
}


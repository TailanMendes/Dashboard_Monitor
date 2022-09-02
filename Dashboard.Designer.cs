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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title13 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title14 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine3 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 440D);
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title15 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend16 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title16 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea17 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend17 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title17 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea18 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend18 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title18 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chartTemperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnTemp = new System.Windows.Forms.Panel();
            this.lbTempValue = new System.Windows.Forms.Label();
            this.picBoxTemp = new System.Windows.Forms.PictureBox();
            this.lbTemp = new System.Windows.Forms.Label();
            this.pnHumidity = new System.Windows.Forms.Panel();
            this.lbHumidityValue = new System.Windows.Forms.Label();
            this.picBoxHumidity = new System.Windows.Forms.PictureBox();
            this.lbHumidity = new System.Windows.Forms.Label();
            this.chartUmidade = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnCO2 = new System.Windows.Forms.Panel();
            this.lbCO2Value = new System.Windows.Forms.Label();
            this.picBoxCO2 = new System.Windows.Forms.PictureBox();
            this.lbCO2 = new System.Windows.Forms.Label();
            this.pnTVOC = new System.Windows.Forms.Panel();
            this.lbTVOCValue = new System.Windows.Forms.Label();
            this.picBoxTVOC = new System.Windows.Forms.PictureBox();
            this.lbTVOC = new System.Windows.Forms.Label();
            this.pnPM25 = new System.Windows.Forms.Panel();
            this.lbPM25Value = new System.Windows.Forms.Label();
            this.picBoxPM25 = new System.Windows.Forms.PictureBox();
            this.lbPM25 = new System.Windows.Forms.Label();
            this.pnPM10 = new System.Windows.Forms.Panel();
            this.lbPM10Value = new System.Windows.Forms.Label();
            this.picBoxPM10 = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).BeginInit();
            this.pnTemp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTemp)).BeginInit();
            this.pnHumidity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHumidity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartUmidade)).BeginInit();
            this.pnCO2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCO2)).BeginInit();
            this.pnTVOC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTVOC)).BeginInit();
            this.pnPM25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPM25)).BeginInit();
            this.pnPM10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPM10)).BeginInit();
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
            chartArea13.AxisX.Interval = 1D;
            chartArea13.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea13.AxisX.IsLabelAutoFit = false;
            chartArea13.AxisX.IsMarginVisible = false;
            chartArea13.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            chartArea13.AxisX.LineColor = System.Drawing.Color.White;
            chartArea13.AxisX.LineWidth = 0;
            chartArea13.AxisX.MajorGrid.Interval = 1D;
            chartArea13.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea13.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea13.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            chartArea13.AxisX.MajorTickMark.Size = 2F;
            chartArea13.AxisX.Maximum = 23D;
            chartArea13.AxisX.Minimum = 0D;
            chartArea13.AxisX.Title = "Horas";
            chartArea13.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            chartArea13.AxisX2.MajorGrid.Enabled = false;
            chartArea13.AxisX2.MajorGrid.Interval = 1D;
            chartArea13.AxisY.Interval = 1D;
            chartArea13.AxisY.IsLabelAutoFit = false;
            chartArea13.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            chartArea13.AxisY.LabelStyle.Interval = 2D;
            chartArea13.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea13.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea13.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea13.AxisY.MajorTickMark.Enabled = false;
            chartArea13.AxisY.Maximum = 35D;
            chartArea13.AxisY.Minimum = 20D;
            chartArea13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea13.BorderWidth = 5;
            chartArea13.Name = "ChartArea1";
            this.chartTemperature.ChartAreas.Add(chartArea13);
            legend13.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            legend13.IsTextAutoFit = false;
            legend13.Name = "Legend1";
            this.chartTemperature.Legends.Add(legend13);
            this.chartTemperature.Location = new System.Drawing.Point(3, 3);
            this.chartTemperature.Name = "chartTemperature";
            series17.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series17.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            series17.BorderWidth = 4;
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series17.Color = System.Drawing.Color.Firebrick;
            series17.Legend = "Legend1";
            series17.LegendText = "Temperatura em °C";
            series17.Name = "Temp";
            series17.ShadowColor = System.Drawing.Color.Transparent;
            this.chartTemperature.Series.Add(series17);
            this.chartTemperature.Size = new System.Drawing.Size(1012, 405);
            this.chartTemperature.TabIndex = 0;
            this.chartTemperature.Text = "Temperature";
            title13.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title13.Name = "Title1";
            title13.Text = "Temperatura";
            this.chartTemperature.Titles.Add(title13);
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
            // picBoxTemp
            // 
            this.picBoxTemp.Image = global::Dashboard_Monitor.Properties.Resources.temperature_termometer_icon;
            this.picBoxTemp.Location = new System.Drawing.Point(52, 44);
            this.picBoxTemp.Name = "picBoxTemp";
            this.picBoxTemp.Size = new System.Drawing.Size(60, 69);
            this.picBoxTemp.TabIndex = 1;
            this.picBoxTemp.TabStop = false;
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
            // picBoxHumidity
            // 
            this.picBoxHumidity.Image = global::Dashboard_Monitor.Properties.Resources.humidity_icon;
            this.picBoxHumidity.Location = new System.Drawing.Point(52, 42);
            this.picBoxHumidity.Name = "picBoxHumidity";
            this.picBoxHumidity.Size = new System.Drawing.Size(60, 69);
            this.picBoxHumidity.TabIndex = 1;
            this.picBoxHumidity.TabStop = false;
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
            chartArea14.AxisX.Interval = 1D;
            chartArea14.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea14.AxisX.IsLabelAutoFit = false;
            chartArea14.AxisX.IsMarginVisible = false;
            chartArea14.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            chartArea14.AxisX.LineColor = System.Drawing.Color.White;
            chartArea14.AxisX.LineWidth = 0;
            chartArea14.AxisX.MajorGrid.Enabled = false;
            chartArea14.AxisX.MajorGrid.Interval = 0D;
            chartArea14.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea14.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            chartArea14.AxisX.MajorTickMark.Size = 2F;
            chartArea14.AxisX.Maximum = 23D;
            chartArea14.AxisX.Minimum = 0D;
            chartArea14.AxisX.Title = "Horas";
            chartArea14.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            chartArea14.AxisY.Interval = 10D;
            chartArea14.AxisY.IsLabelAutoFit = false;
            chartArea14.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            chartArea14.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea14.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea14.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea14.AxisY.MajorTickMark.Enabled = false;
            chartArea14.AxisY.Maximum = 80D;
            chartArea14.AxisY.Minimum = 30D;
            chartArea14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea14.BorderWidth = 5;
            chartArea14.Name = "ChartArea1";
            this.chartUmidade.ChartAreas.Add(chartArea14);
            legend14.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            legend14.IsTextAutoFit = false;
            legend14.Name = "Legend1";
            this.chartUmidade.Legends.Add(legend14);
            this.chartUmidade.Location = new System.Drawing.Point(3, 3);
            this.chartUmidade.Name = "chartUmidade";
            series18.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series18.BorderWidth = 5;
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series18.Color = System.Drawing.Color.Firebrick;
            series18.Legend = "Legend1";
            series18.LegendText = "Umidade Relativa %";
            series18.Name = "Temp";
            series18.ShadowColor = System.Drawing.Color.Transparent;
            this.chartUmidade.Series.Add(series18);
            this.chartUmidade.Size = new System.Drawing.Size(1012, 405);
            this.chartUmidade.TabIndex = 6;
            this.chartUmidade.Text = "Temperature";
            title14.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title14.Name = "Title1";
            title14.Text = "Umidade";
            this.chartUmidade.Titles.Add(title14);
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
            // picBoxCO2
            // 
            this.picBoxCO2.Image = global::Dashboard_Monitor.Properties.Resources.co2_icon;
            this.picBoxCO2.Location = new System.Drawing.Point(52, 40);
            this.picBoxCO2.Name = "picBoxCO2";
            this.picBoxCO2.Size = new System.Drawing.Size(60, 69);
            this.picBoxCO2.TabIndex = 1;
            this.picBoxCO2.TabStop = false;
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
            this.lbTVOCValue.AutoSize = true;
            this.lbTVOCValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTVOCValue.Location = new System.Drawing.Point(49, 116);
            this.lbTVOCValue.Name = "lbTVOCValue";
            this.lbTVOCValue.Size = new System.Drawing.Size(70, 20);
            this.lbTVOCValue.TabIndex = 2;
            this.lbTVOCValue.Text = "10 PPM";
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
            this.lbPM25Value.Size = new System.Drawing.Size(84, 20);
            this.lbPM25Value.TabIndex = 2;
            this.lbPM25Value.Text = "0.5 ug/m³";
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
            // picBoxPM10
            // 
            this.picBoxPM10.Image = global::Dashboard_Monitor.Properties.Resources._10;
            this.picBoxPM10.Location = new System.Drawing.Point(52, 35);
            this.picBoxPM10.Name = "picBoxPM10";
            this.picBoxPM10.Size = new System.Drawing.Size(60, 69);
            this.picBoxPM10.TabIndex = 1;
            this.picBoxPM10.TabStop = false;
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
            this.tabControl1.Location = new System.Drawing.Point(0, 181);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1026, 439);
            this.tabControl1.TabIndex = 12;
            // 
            // tabTEMP
            // 
            this.tabTEMP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.tabTEMP.Controls.Add(this.chartTemperature);
            this.tabTEMP.Location = new System.Drawing.Point(4, 24);
            this.tabTEMP.Name = "tabTEMP";
            this.tabTEMP.Padding = new System.Windows.Forms.Padding(3);
            this.tabTEMP.Size = new System.Drawing.Size(1018, 411);
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
            this.tabRH.Size = new System.Drawing.Size(1018, 411);
            this.tabRH.TabIndex = 1;
            this.tabRH.Text = "RH%";
            // 
            // tabCO2
            // 
            this.tabCO2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.tabCO2.Controls.Add(this.chartCO2);
            this.tabCO2.Location = new System.Drawing.Point(4, 24);
            this.tabCO2.Name = "tabCO2";
            this.tabCO2.Size = new System.Drawing.Size(1018, 411);
            this.tabCO2.TabIndex = 2;
            this.tabCO2.Text = "CO2";
            // 
            // chartCO2
            // 
            this.chartCO2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.chartCO2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            chartArea15.AxisX.Interval = 1D;
            chartArea15.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea15.AxisX.IsLabelAutoFit = false;
            chartArea15.AxisX.IsMarginVisible = false;
            chartArea15.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            chartArea15.AxisX.LineColor = System.Drawing.Color.White;
            chartArea15.AxisX.LineWidth = 0;
            chartArea15.AxisX.MajorGrid.Enabled = false;
            chartArea15.AxisX.MajorGrid.Interval = 0D;
            chartArea15.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea15.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            chartArea15.AxisX.MajorTickMark.Size = 2F;
            chartArea15.AxisX.Maximum = 23D;
            chartArea15.AxisX.Minimum = 0D;
            chartArea15.AxisX.Title = "Horas";
            chartArea15.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            chartArea15.AxisY.Interval = 50D;
            chartArea15.AxisY.IsLabelAutoFit = false;
            chartArea15.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            chartArea15.AxisY.LabelStyle.Interval = 200D;
            chartArea15.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea15.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea15.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea15.AxisY.MajorTickMark.Enabled = false;
            chartArea15.AxisY.Maximum = 2000D;
            chartArea15.AxisY.Minimum = 200D;
            stripLine3.BorderColor = System.Drawing.Color.Lime;
            stripLine3.BorderWidth = 2;
            chartArea15.AxisY.StripLines.Add(stripLine3);
            chartArea15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea15.BorderWidth = 5;
            chartArea15.Name = "ChartArea1";
            this.chartCO2.ChartAreas.Add(chartArea15);
            legend15.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            legend15.IsTextAutoFit = false;
            legend15.Name = "Legend1";
            this.chartCO2.Legends.Add(legend15);
            this.chartCO2.Location = new System.Drawing.Point(3, 3);
            this.chartCO2.Name = "chartCO2";
            series19.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series19.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            series19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            series19.BorderWidth = 3;
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series19.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(127)))));
            series19.Legend = "Legend1";
            series19.LegendText = "CO2 em PPM";
            series19.Name = "CO2";
            series19.Points.Add(dataPoint3);
            series19.ShadowColor = System.Drawing.Color.Transparent;
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series20.Color = System.Drawing.Color.Lime;
            series20.Legend = "Legend1";
            series20.Name = "CO2Limit";
            this.chartCO2.Series.Add(series19);
            this.chartCO2.Series.Add(series20);
            this.chartCO2.Size = new System.Drawing.Size(1012, 405);
            this.chartCO2.TabIndex = 1;
            this.chartCO2.Text = "CO2";
            title15.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title15.Name = "Title1";
            title15.Text = "Dióxido de Carbono (CO2)";
            this.chartCO2.Titles.Add(title15);
            // 
            // tabTVOC
            // 
            this.tabTVOC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.tabTVOC.Controls.Add(this.chartTVOC);
            this.tabTVOC.Location = new System.Drawing.Point(4, 24);
            this.tabTVOC.Name = "tabTVOC";
            this.tabTVOC.Size = new System.Drawing.Size(1018, 411);
            this.tabTVOC.TabIndex = 3;
            this.tabTVOC.Text = "TVOC";
            // 
            // chartTVOC
            // 
            this.chartTVOC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.chartTVOC.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            chartArea16.AxisX.Interval = 1D;
            chartArea16.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea16.AxisX.IsLabelAutoFit = false;
            chartArea16.AxisX.IsMarginVisible = false;
            chartArea16.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            chartArea16.AxisX.LineColor = System.Drawing.Color.White;
            chartArea16.AxisX.LineWidth = 0;
            chartArea16.AxisX.MajorGrid.Enabled = false;
            chartArea16.AxisX.MajorGrid.Interval = 0D;
            chartArea16.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea16.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            chartArea16.AxisX.MajorTickMark.Size = 2F;
            chartArea16.AxisX.Maximum = 23D;
            chartArea16.AxisX.Minimum = 0D;
            chartArea16.AxisX.Title = "Horas";
            chartArea16.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            chartArea16.AxisY.Interval = 5D;
            chartArea16.AxisY.IsLabelAutoFit = false;
            chartArea16.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            chartArea16.AxisY.LabelStyle.Interval = 30D;
            chartArea16.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea16.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea16.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea16.AxisY.MajorTickMark.Enabled = false;
            chartArea16.AxisY.Maximum = 250D;
            chartArea16.AxisY.Minimum = 0D;
            chartArea16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea16.BorderWidth = 5;
            chartArea16.Name = "ChartArea1";
            this.chartTVOC.ChartAreas.Add(chartArea16);
            legend16.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            legend16.IsTextAutoFit = false;
            legend16.Name = "Legend1";
            this.chartTVOC.Legends.Add(legend16);
            this.chartTVOC.Location = new System.Drawing.Point(3, 3);
            this.chartTVOC.Name = "chartTVOC";
            series21.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series21.BorderWidth = 5;
            series21.ChartArea = "ChartArea1";
            series21.Color = System.Drawing.Color.Firebrick;
            series21.Legend = "Legend1";
            series21.LegendText = "TVOC em PPM";
            series21.Name = "TVOC";
            series21.ShadowColor = System.Drawing.Color.Transparent;
            this.chartTVOC.Series.Add(series21);
            this.chartTVOC.Size = new System.Drawing.Size(1012, 405);
            this.chartTVOC.TabIndex = 1;
            title16.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title16.Name = "Title1";
            title16.Text = "TVOC - Total Volitile Organic Compound";
            this.chartTVOC.Titles.Add(title16);
            // 
            // tabPM25
            // 
            this.tabPM25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.tabPM25.Controls.Add(this.chartPM25);
            this.tabPM25.Location = new System.Drawing.Point(4, 24);
            this.tabPM25.Name = "tabPM25";
            this.tabPM25.Size = new System.Drawing.Size(1018, 411);
            this.tabPM25.TabIndex = 4;
            this.tabPM25.Text = "PM2.5";
            // 
            // chartPM25
            // 
            this.chartPM25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.chartPM25.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            chartArea17.AxisX.Interval = 1D;
            chartArea17.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea17.AxisX.IsLabelAutoFit = false;
            chartArea17.AxisX.IsMarginVisible = false;
            chartArea17.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            chartArea17.AxisX.LineColor = System.Drawing.Color.White;
            chartArea17.AxisX.LineWidth = 0;
            chartArea17.AxisX.MajorGrid.Enabled = false;
            chartArea17.AxisX.MajorGrid.Interval = 0D;
            chartArea17.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea17.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            chartArea17.AxisX.MajorTickMark.Size = 2F;
            chartArea17.AxisX.Maximum = 23D;
            chartArea17.AxisX.Minimum = 0D;
            chartArea17.AxisX.Title = "Horas";
            chartArea17.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            chartArea17.AxisY.Interval = 0.1D;
            chartArea17.AxisY.IsLabelAutoFit = false;
            chartArea17.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            chartArea17.AxisY.LabelStyle.Format = "0.00";
            chartArea17.AxisY.LabelStyle.Interval = 0.25D;
            chartArea17.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea17.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea17.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea17.AxisY.MajorTickMark.Enabled = false;
            chartArea17.AxisY.Maximum = 3D;
            chartArea17.AxisY.Minimum = 0D;
            chartArea17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea17.BorderWidth = 5;
            chartArea17.Name = "ChartArea1";
            this.chartPM25.ChartAreas.Add(chartArea17);
            legend17.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            legend17.IsTextAutoFit = false;
            legend17.Name = "Legend1";
            this.chartPM25.Legends.Add(legend17);
            this.chartPM25.Location = new System.Drawing.Point(3, 3);
            this.chartPM25.Name = "chartPM25";
            series22.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series22.BorderWidth = 5;
            series22.ChartArea = "ChartArea1";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series22.Color = System.Drawing.Color.Firebrick;
            series22.Legend = "Legend1";
            series22.LegendText = "PM 2.5";
            series22.Name = "pm25";
            series22.ShadowColor = System.Drawing.Color.Transparent;
            series23.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series23.ChartArea = "ChartArea1";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series23.Color = System.Drawing.Color.Gold;
            series23.Legend = "Legend1";
            series23.LegendText = "PM 10";
            series23.Name = "pm10";
            series23.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chartPM25.Series.Add(series22);
            this.chartPM25.Series.Add(series23);
            this.chartPM25.Size = new System.Drawing.Size(1012, 405);
            this.chartPM25.TabIndex = 1;
            title17.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title17.Name = "Title1";
            title17.Text = "PM2.5 & PM10";
            this.chartPM25.Titles.Add(title17);
            // 
            // tabPM10
            // 
            this.tabPM10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.tabPM10.Controls.Add(this.charPM10);
            this.tabPM10.Location = new System.Drawing.Point(4, 24);
            this.tabPM10.Name = "tabPM10";
            this.tabPM10.Size = new System.Drawing.Size(1018, 411);
            this.tabPM10.TabIndex = 5;
            this.tabPM10.Text = "PM10";
            // 
            // charPM10
            // 
            this.charPM10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.charPM10.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            chartArea18.AxisX.Interval = 1D;
            chartArea18.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea18.AxisX.IsLabelAutoFit = false;
            chartArea18.AxisX.IsMarginVisible = false;
            chartArea18.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            chartArea18.AxisX.LineColor = System.Drawing.Color.White;
            chartArea18.AxisX.LineWidth = 0;
            chartArea18.AxisX.MajorGrid.Enabled = false;
            chartArea18.AxisX.MajorGrid.Interval = 0D;
            chartArea18.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea18.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            chartArea18.AxisX.MajorTickMark.Size = 2F;
            chartArea18.AxisX.Maximum = 23D;
            chartArea18.AxisX.Minimum = 0D;
            chartArea18.AxisX.Title = "Horas";
            chartArea18.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            chartArea18.AxisY.Interval = 2D;
            chartArea18.AxisY.IsLabelAutoFit = false;
            chartArea18.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            chartArea18.AxisY.LabelStyle.Format = "0*C";
            chartArea18.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea18.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea18.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea18.AxisY.MajorTickMark.Enabled = false;
            chartArea18.AxisY.Maximum = 35D;
            chartArea18.AxisY.Minimum = 20D;
            chartArea18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea18.BorderWidth = 5;
            chartArea18.Name = "ChartArea1";
            this.charPM10.ChartAreas.Add(chartArea18);
            legend18.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            legend18.IsTextAutoFit = false;
            legend18.Name = "Legend1";
            this.charPM10.Legends.Add(legend18);
            this.charPM10.Location = new System.Drawing.Point(3, 3);
            this.charPM10.Name = "charPM10";
            series24.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series24.BorderWidth = 5;
            series24.ChartArea = "ChartArea1";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series24.Color = System.Drawing.Color.Firebrick;
            series24.Legend = "Legend1";
            series24.LegendText = "Temperatura em °C";
            series24.Name = "Temp";
            series24.ShadowColor = System.Drawing.Color.Transparent;
            this.charPM10.Series.Add(series24);
            this.charPM10.Size = new System.Drawing.Size(1012, 405);
            this.charPM10.TabIndex = 1;
            this.charPM10.Text = "Temperature";
            title18.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title18.Name = "Title1";
            title18.Text = "Temperatura";
            this.charPM10.Titles.Add(title18);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 178);
            this.panel1.TabIndex = 13;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1031, 645);
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
            this.Text = "Dashboard Monitor";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).EndInit();
            this.pnTemp.ResumeLayout(false);
            this.pnTemp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTemp)).EndInit();
            this.pnHumidity.ResumeLayout(false);
            this.pnHumidity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHumidity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartUmidade)).EndInit();
            this.pnCO2.ResumeLayout(false);
            this.pnCO2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCO2)).EndInit();
            this.pnTVOC.ResumeLayout(false);
            this.pnTVOC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTVOC)).EndInit();
            this.pnPM25.ResumeLayout(false);
            this.pnPM25.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPM25)).EndInit();
            this.pnPM10.ResumeLayout(false);
            this.pnPM10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPM10)).EndInit();
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
    }
}


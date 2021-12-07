
namespace DormitoryManagementSoftware
{
    partial class fReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fReport));
            this.chartReporting = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxSearchBy = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreateReport = new Bunifu.Framework.UI.BunifuThinButton2();
            this.labelName = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.cbxMonth = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxYear = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnPrintReport = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.chartReporting)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartReporting
            // 
            chartArea1.Name = "ChartArea1";
            this.chartReporting.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartReporting.Legends.Add(legend1);
            this.chartReporting.Location = new System.Drawing.Point(6, 22);
            this.chartReporting.Name = "chartReporting";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "s1";
            this.chartReporting.Series.Add(series1);
            this.chartReporting.Size = new System.Drawing.Size(371, 295);
            this.chartReporting.TabIndex = 0;
            this.chartReporting.Text = "chart1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbxYear);
            this.groupBox3.Controls.Add(this.cbxMonth);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cbxSearchBy);
            this.groupBox3.Controls.Add(this.btnCreateReport);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.groupBox3.Location = new System.Drawing.Point(12, 49);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(431, 169);
            this.groupBox3.TabIndex = 78;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm Kiếm";
            // 
            // cbxSearchBy
            // 
            this.cbxSearchBy.BackColor = System.Drawing.Color.Transparent;
            this.cbxSearchBy.BackgroundColor = System.Drawing.Color.White;
            this.cbxSearchBy.BorderColor = System.Drawing.Color.Silver;
            this.cbxSearchBy.BorderRadius = 1;
            this.cbxSearchBy.Color = System.Drawing.Color.Silver;
            this.cbxSearchBy.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cbxSearchBy.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbxSearchBy.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbxSearchBy.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbxSearchBy.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cbxSearchBy.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cbxSearchBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxSearchBy.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cbxSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSearchBy.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbxSearchBy.FillDropDown = true;
            this.cbxSearchBy.FillIndicator = false;
            this.cbxSearchBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxSearchBy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbxSearchBy.ForeColor = System.Drawing.Color.Black;
            this.cbxSearchBy.FormattingEnabled = true;
            this.cbxSearchBy.Icon = null;
            this.cbxSearchBy.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbxSearchBy.IndicatorColor = System.Drawing.Color.DarkGray;
            this.cbxSearchBy.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbxSearchBy.IndicatorThickness = 2;
            this.cbxSearchBy.IsDropdownOpened = false;
            this.cbxSearchBy.ItemBackColor = System.Drawing.Color.White;
            this.cbxSearchBy.ItemBorderColor = System.Drawing.Color.White;
            this.cbxSearchBy.ItemForeColor = System.Drawing.Color.Black;
            this.cbxSearchBy.ItemHeight = 26;
            this.cbxSearchBy.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cbxSearchBy.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cbxSearchBy.Items.AddRange(new object[] {
            "Tiền Điện",
            "Tiền Nước"});
            this.cbxSearchBy.ItemTopMargin = 3;
            this.cbxSearchBy.Location = new System.Drawing.Point(12, 117);
            this.cbxSearchBy.Name = "cbxSearchBy";
            this.cbxSearchBy.Size = new System.Drawing.Size(254, 32);
            this.cbxSearchBy.TabIndex = 3;
            this.cbxSearchBy.Text = null;
            this.cbxSearchBy.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbxSearchBy.TextLeftMargin = 5;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.label5.Location = new System.Drawing.Point(14, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 26);
            this.label5.TabIndex = 28;
            this.label5.Text = "Tìm kiếm theo:";
            // 
            // btnCreateReport
            // 
            this.btnCreateReport.ActiveBorderThickness = 1;
            this.btnCreateReport.ActiveCornerRadius = 20;
            this.btnCreateReport.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.btnCreateReport.ActiveForecolor = System.Drawing.Color.White;
            this.btnCreateReport.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.btnCreateReport.BackColor = System.Drawing.SystemColors.Control;
            this.btnCreateReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreateReport.BackgroundImage")));
            this.btnCreateReport.ButtonText = "Tạo Thống Kê";
            this.btnCreateReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateReport.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnCreateReport.IdleBorderThickness = 1;
            this.btnCreateReport.IdleCornerRadius = 20;
            this.btnCreateReport.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnCreateReport.IdleForecolor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateReport.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnCreateReport.Location = new System.Drawing.Point(284, 112);
            this.btnCreateReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateReport.Name = "btnCreateReport";
            this.btnCreateReport.Size = new System.Drawing.Size(135, 40);
            this.btnCreateReport.TabIndex = 4;
            this.btnCreateReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCreateReport.Click += new System.EventHandler(this.btnCreateReport_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.labelName.Location = new System.Drawing.Point(12, 4);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(125, 37);
            this.labelName.TabIndex = 79;
            this.labelName.Text = "Báo Cáo";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(12, 39);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(816, 13);
            this.bunifuSeparator1.TabIndex = 80;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // cbxMonth
            // 
            this.cbxMonth.BackColor = System.Drawing.Color.Transparent;
            this.cbxMonth.BackgroundColor = System.Drawing.Color.White;
            this.cbxMonth.BorderColor = System.Drawing.Color.Silver;
            this.cbxMonth.BorderRadius = 1;
            this.cbxMonth.Color = System.Drawing.Color.Silver;
            this.cbxMonth.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cbxMonth.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbxMonth.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbxMonth.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbxMonth.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cbxMonth.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cbxMonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxMonth.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cbxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMonth.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbxMonth.FillDropDown = true;
            this.cbxMonth.FillIndicator = false;
            this.cbxMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxMonth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbxMonth.ForeColor = System.Drawing.Color.Black;
            this.cbxMonth.FormattingEnabled = true;
            this.cbxMonth.Icon = null;
            this.cbxMonth.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbxMonth.IndicatorColor = System.Drawing.Color.DarkGray;
            this.cbxMonth.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbxMonth.IndicatorThickness = 2;
            this.cbxMonth.IsDropdownOpened = false;
            this.cbxMonth.ItemBackColor = System.Drawing.Color.White;
            this.cbxMonth.ItemBorderColor = System.Drawing.Color.White;
            this.cbxMonth.ItemForeColor = System.Drawing.Color.Black;
            this.cbxMonth.ItemHeight = 26;
            this.cbxMonth.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cbxMonth.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cbxMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbxMonth.ItemTopMargin = 3;
            this.cbxMonth.Location = new System.Drawing.Point(10, 51);
            this.cbxMonth.Name = "cbxMonth";
            this.cbxMonth.Size = new System.Drawing.Size(193, 32);
            this.cbxMonth.TabIndex = 1;
            this.cbxMonth.Text = null;
            this.cbxMonth.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbxMonth.TextLeftMargin = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 26);
            this.label1.TabIndex = 61;
            this.label1.Text = "Tháng:";
            // 
            // cbxYear
            // 
            this.cbxYear.BackColor = System.Drawing.Color.Transparent;
            this.cbxYear.BackgroundColor = System.Drawing.Color.White;
            this.cbxYear.BorderColor = System.Drawing.Color.Silver;
            this.cbxYear.BorderRadius = 1;
            this.cbxYear.Color = System.Drawing.Color.Silver;
            this.cbxYear.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cbxYear.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbxYear.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbxYear.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbxYear.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cbxYear.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cbxYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxYear.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cbxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxYear.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbxYear.FillDropDown = true;
            this.cbxYear.FillIndicator = false;
            this.cbxYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxYear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbxYear.ForeColor = System.Drawing.Color.Black;
            this.cbxYear.FormattingEnabled = true;
            this.cbxYear.Icon = null;
            this.cbxYear.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbxYear.IndicatorColor = System.Drawing.Color.DarkGray;
            this.cbxYear.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbxYear.IndicatorThickness = 2;
            this.cbxYear.IsDropdownOpened = false;
            this.cbxYear.ItemBackColor = System.Drawing.Color.White;
            this.cbxYear.ItemBorderColor = System.Drawing.Color.White;
            this.cbxYear.ItemForeColor = System.Drawing.Color.Black;
            this.cbxYear.ItemHeight = 26;
            this.cbxYear.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cbxYear.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cbxYear.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024"});
            this.cbxYear.ItemTopMargin = 3;
            this.cbxYear.Location = new System.Drawing.Point(223, 51);
            this.cbxYear.Name = "cbxYear";
            this.cbxYear.Size = new System.Drawing.Size(193, 32);
            this.cbxYear.TabIndex = 2;
            this.cbxYear.Text = null;
            this.cbxYear.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbxYear.TextLeftMargin = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.label2.Location = new System.Drawing.Point(225, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 26);
            this.label2.TabIndex = 63;
            this.label2.Text = "Năm:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnPrintReport);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 104);
            this.groupBox2.TabIndex = 81;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // btnClose
            // 
            this.btnClose.ActiveBorderThickness = 1;
            this.btnClose.ActiveCornerRadius = 20;
            this.btnClose.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(158)))), ((int)(((byte)(75)))));
            this.btnClose.ActiveForecolor = System.Drawing.Color.White;
            this.btnClose.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(158)))), ((int)(((byte)(75)))));
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.ButtonText = "Đóng";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnClose.IdleBorderThickness = 1;
            this.btnClose.IdleCornerRadius = 20;
            this.btnClose.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.btnClose.IdleForecolor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.btnClose.Location = new System.Drawing.Point(229, 41);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(175, 40);
            this.btnClose.TabIndex = 6;
            this.btnClose.TabStop = false;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.ActiveBorderThickness = 1;
            this.btnPrintReport.ActiveCornerRadius = 20;
            this.btnPrintReport.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.btnPrintReport.ActiveForecolor = System.Drawing.Color.White;
            this.btnPrintReport.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.btnPrintReport.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrintReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrintReport.BackgroundImage")));
            this.btnPrintReport.ButtonText = "In Báo Cáo";
            this.btnPrintReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintReport.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReport.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnPrintReport.IdleBorderThickness = 1;
            this.btnPrintReport.IdleCornerRadius = 20;
            this.btnPrintReport.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnPrintReport.IdleForecolor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrintReport.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnPrintReport.Location = new System.Drawing.Point(18, 41);
            this.btnPrintReport.Margin = new System.Windows.Forms.Padding(6);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(175, 40);
            this.btnPrintReport.TabIndex = 5;
            this.btnPrintReport.TabStop = false;
            this.btnPrintReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chartReporting);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.groupBox1.Location = new System.Drawing.Point(451, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 323);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Báo Cáo";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(12, 360);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(431, 13);
            this.bunifuSeparator2.TabIndex = 83;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // fReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 382);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.groupBox3);
            this.Name = "fReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo Thống Kê";
            ((System.ComponentModel.ISupportInitialize)(this.chartReporting)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartReporting;
        private System.Windows.Forms.GroupBox groupBox3;
        private Bunifu.UI.WinForms.BunifuDropdown cbxSearchBy;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCreateReport;
        private System.Windows.Forms.Label labelName;
        private Bunifu.UI.WinForms.BunifuDropdown cbxYear;
        private Bunifu.UI.WinForms.BunifuDropdown cbxMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClose;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPrintReport;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
    }
}
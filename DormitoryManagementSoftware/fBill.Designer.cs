
namespace DormitoryManagementSoftware
{
    partial class fBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBill));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelName = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxSearchBy = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBillDetail = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnClose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCreateBill = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewRoomBill = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREATING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAYMENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FORMONTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPayBill = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxStudentName = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoomBill)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.labelName.Location = new System.Drawing.Point(12, 4);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(250, 37);
            this.labelName.TabIndex = 75;
            this.labelName.Text = "Quản Lý Hóa Đơn";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(12, 36);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(925, 13);
            this.bunifuSeparator1.TabIndex = 76;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbxSearchBy);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.btnCancel);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.groupBox3.Location = new System.Drawing.Point(9, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(414, 115);
            this.groupBox3.TabIndex = 77;
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
            "Chưa Thanh Toán",
            "Đã Thanh Toán"});
            this.cbxSearchBy.ItemTopMargin = 3;
            this.cbxSearchBy.Location = new System.Drawing.Point(10, 56);
            this.cbxSearchBy.Name = "cbxSearchBy";
            this.cbxSearchBy.Size = new System.Drawing.Size(234, 32);
            this.cbxSearchBy.TabIndex = 60;
            this.cbxSearchBy.Text = null;
            this.cbxSearchBy.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbxSearchBy.TextLeftMargin = 5;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.label5.Location = new System.Drawing.Point(12, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 26);
            this.label5.TabIndex = 28;
            this.label5.Text = "Tìm kiếm theo:";
            // 
            // btnSearch
            // 
            this.btnSearch.ActiveBorderThickness = 1;
            this.btnSearch.ActiveCornerRadius = 20;
            this.btnSearch.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.btnSearch.ActiveForecolor = System.Drawing.Color.White;
            this.btnSearch.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.btnSearch.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.ButtonText = "Tìm Kiếm";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnSearch.IdleBorderThickness = 1;
            this.btnSearch.IdleCornerRadius = 20;
            this.btnSearch.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnSearch.IdleForecolor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnSearch.Location = new System.Drawing.Point(260, 51);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(135, 40);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveBorderThickness = 1;
            this.btnCancel.ActiveCornerRadius = 20;
            this.btnCancel.ActiveFillColor = System.Drawing.Color.Red;
            this.btnCancel.ActiveForecolor = System.Drawing.Color.White;
            this.btnCancel.ActiveLineColor = System.Drawing.Color.Red;
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.ButtonText = "Huỷ Tìm";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.IdleBorderThickness = 1;
            this.btnCancel.IdleCornerRadius = 20;
            this.btnCancel.IdleFillColor = System.Drawing.Color.White;
            this.btnCancel.IdleForecolor = System.Drawing.Color.Red;
            this.btnCancel.IdleLineColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(260, 50);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 40);
            this.btnCancel.TabIndex = 49;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBillDetail);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnCreateBill);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.groupBox2.Location = new System.Drawing.Point(9, 288);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 123);
            this.groupBox2.TabIndex = 79;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // btnBillDetail
            // 
            this.btnBillDetail.ActiveBorderThickness = 1;
            this.btnBillDetail.ActiveCornerRadius = 20;
            this.btnBillDetail.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.btnBillDetail.ActiveForecolor = System.Drawing.Color.White;
            this.btnBillDetail.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.btnBillDetail.BackColor = System.Drawing.SystemColors.Control;
            this.btnBillDetail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBillDetail.BackgroundImage")));
            this.btnBillDetail.ButtonText = "Chi Tiết Hóa Đơn";
            this.btnBillDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBillDetail.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillDetail.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnBillDetail.IdleBorderThickness = 1;
            this.btnBillDetail.IdleCornerRadius = 20;
            this.btnBillDetail.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnBillDetail.IdleForecolor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBillDetail.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnBillDetail.Location = new System.Drawing.Point(220, 24);
            this.btnBillDetail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBillDetail.Name = "btnBillDetail";
            this.btnBillDetail.Size = new System.Drawing.Size(175, 40);
            this.btnBillDetail.TabIndex = 78;
            this.btnBillDetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBillDetail.Click += new System.EventHandler(this.btnBillDetail_Click);
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
            this.btnClose.Location = new System.Drawing.Point(117, 69);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(175, 40);
            this.btnClose.TabIndex = 25;
            this.btnClose.TabStop = false;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Click += new System.EventHandler(this.btnCLose_Click);
            // 
            // btnCreateBill
            // 
            this.btnCreateBill.ActiveBorderThickness = 1;
            this.btnCreateBill.ActiveCornerRadius = 20;
            this.btnCreateBill.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.btnCreateBill.ActiveForecolor = System.Drawing.Color.White;
            this.btnCreateBill.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.btnCreateBill.BackColor = System.Drawing.SystemColors.Control;
            this.btnCreateBill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreateBill.BackgroundImage")));
            this.btnCreateBill.ButtonText = "Tạo Hóa Đơn";
            this.btnCreateBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateBill.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateBill.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCreateBill.IdleBorderThickness = 1;
            this.btnCreateBill.IdleCornerRadius = 20;
            this.btnCreateBill.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnCreateBill.IdleForecolor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateBill.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnCreateBill.Location = new System.Drawing.Point(12, 24);
            this.btnCreateBill.Margin = new System.Windows.Forms.Padding(6);
            this.btnCreateBill.Name = "btnCreateBill";
            this.btnCreateBill.Size = new System.Drawing.Size(175, 40);
            this.btnCreateBill.TabIndex = 26;
            this.btnCreateBill.TabStop = false;
            this.btnCreateBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCreateBill.Click += new System.EventHandler(this.btnCreateBill_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel2);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.groupBox4.Location = new System.Drawing.Point(439, 47);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(557, 364);
            this.groupBox4.TabIndex = 80;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh Sách Hóa Đơn Gần Đây";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewRoomBill);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(3, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(551, 336);
            this.panel2.TabIndex = 39;
            // 
            // dataGridViewRoomBill
            // 
            this.dataGridViewRoomBill.AllowDrop = true;
            this.dataGridViewRoomBill.AllowUserToAddRows = false;
            this.dataGridViewRoomBill.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.dataGridViewRoomBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRoomBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRoomBill.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridViewRoomBill.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRoomBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRoomBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRoomBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.RoomName,
            this.BillType,
            this.STATUS,
            this.PRICE,
            this.CREATING,
            this.PAYMENT,
            this.FORMONTH});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRoomBill.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewRoomBill.GridColor = System.Drawing.Color.White;
            this.dataGridViewRoomBill.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewRoomBill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewRoomBill.Name = "dataGridViewRoomBill";
            this.dataGridViewRoomBill.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRoomBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewRoomBill.RowHeadersVisible = false;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRoomBill.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewRoomBill.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewRoomBill.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewRoomBill.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewRoomBill.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewRoomBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRoomBill.Size = new System.Drawing.Size(548, 339);
            this.dataGridViewRoomBill.StandardTab = true;
            this.dataGridViewRoomBill.TabIndex = 7;
            this.dataGridViewRoomBill.SelectionChanged += new System.EventHandler(this.dataGridViewRoomBill_SelectionChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Mã";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // RoomName
            // 
            this.RoomName.DataPropertyName = "RoomName";
            this.RoomName.HeaderText = "Tên phòng";
            this.RoomName.Name = "RoomName";
            this.RoomName.ReadOnly = true;
            // 
            // BillType
            // 
            this.BillType.DataPropertyName = "BillType";
            this.BillType.HeaderText = "Loại hóa đơn";
            this.BillType.Name = "BillType";
            this.BillType.ReadOnly = true;
            // 
            // STATUS
            // 
            this.STATUS.DataPropertyName = "STATUS";
            this.STATUS.HeaderText = "Trạng thái";
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            // 
            // PRICE
            // 
            this.PRICE.DataPropertyName = "PRICE";
            this.PRICE.HeaderText = "Số tiền";
            this.PRICE.Name = "PRICE";
            this.PRICE.ReadOnly = true;
            // 
            // CREATING
            // 
            this.CREATING.DataPropertyName = "CREATING";
            this.CREATING.HeaderText = "Ngày tạo";
            this.CREATING.Name = "CREATING";
            this.CREATING.ReadOnly = true;
            this.CREATING.Visible = false;
            // 
            // PAYMENT
            // 
            this.PAYMENT.DataPropertyName = "PAYMENT";
            this.PAYMENT.HeaderText = "Ngày thanh toán";
            this.PAYMENT.Name = "PAYMENT";
            this.PAYMENT.ReadOnly = true;
            this.PAYMENT.Visible = false;
            // 
            // FORMONTH
            // 
            this.FORMONTH.DataPropertyName = "FORMONTH";
            this.FORMONTH.HeaderText = "Tháng";
            this.FORMONTH.Name = "FORMONTH";
            this.FORMONTH.ReadOnly = true;
            // 
            // btnPayBill
            // 
            this.btnPayBill.ActiveBorderThickness = 1;
            this.btnPayBill.ActiveCornerRadius = 20;
            this.btnPayBill.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.btnPayBill.ActiveForecolor = System.Drawing.Color.White;
            this.btnPayBill.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.btnPayBill.BackColor = System.Drawing.SystemColors.Control;
            this.btnPayBill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPayBill.BackgroundImage")));
            this.btnPayBill.ButtonText = "Thanh Toán Hóa Đơn";
            this.btnPayBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayBill.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayBill.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnPayBill.IdleBorderThickness = 1;
            this.btnPayBill.IdleCornerRadius = 20;
            this.btnPayBill.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnPayBill.IdleForecolor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPayBill.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnPayBill.Location = new System.Drawing.Point(102, 69);
            this.btnPayBill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPayBill.Name = "btnPayBill";
            this.btnPayBill.Size = new System.Drawing.Size(205, 40);
            this.btnPayBill.TabIndex = 54;
            this.btnPayBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPayBill.Click += new System.EventHandler(this.btnPayBill_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxStudentName);
            this.groupBox1.Controls.Add(this.btnPayBill);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.groupBox1.Location = new System.Drawing.Point(9, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 117);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thanh Toán ";
            // 
            // cbxStudentName
            // 
            this.cbxStudentName.BackColor = System.Drawing.Color.Transparent;
            this.cbxStudentName.BackgroundColor = System.Drawing.Color.White;
            this.cbxStudentName.BorderColor = System.Drawing.Color.Silver;
            this.cbxStudentName.BorderRadius = 1;
            this.cbxStudentName.Color = System.Drawing.Color.Silver;
            this.cbxStudentName.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cbxStudentName.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbxStudentName.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbxStudentName.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbxStudentName.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cbxStudentName.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cbxStudentName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxStudentName.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cbxStudentName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStudentName.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbxStudentName.FillDropDown = true;
            this.cbxStudentName.FillIndicator = false;
            this.cbxStudentName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxStudentName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbxStudentName.ForeColor = System.Drawing.Color.Black;
            this.cbxStudentName.FormattingEnabled = true;
            this.cbxStudentName.Icon = null;
            this.cbxStudentName.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbxStudentName.IndicatorColor = System.Drawing.Color.DarkGray;
            this.cbxStudentName.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbxStudentName.IndicatorThickness = 2;
            this.cbxStudentName.IsDropdownOpened = false;
            this.cbxStudentName.ItemBackColor = System.Drawing.Color.White;
            this.cbxStudentName.ItemBorderColor = System.Drawing.Color.White;
            this.cbxStudentName.ItemForeColor = System.Drawing.Color.Black;
            this.cbxStudentName.ItemHeight = 26;
            this.cbxStudentName.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cbxStudentName.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cbxStudentName.ItemTopMargin = 3;
            this.cbxStudentName.Location = new System.Drawing.Point(68, 29);
            this.cbxStudentName.Name = "cbxStudentName";
            this.cbxStudentName.Size = new System.Drawing.Size(327, 32);
            this.cbxStudentName.TabIndex = 42;
            this.cbxStudentName.Text = null;
            this.cbxStudentName.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbxStudentName.TextLeftMargin = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.label4.Location = new System.Drawing.Point(6, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Tên SV:";
            // 
            // fBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 423);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.labelName);
            this.Name = "fBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Hóa Đơn";
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoomBill)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.GroupBox groupBox3;
        private Bunifu.UI.WinForms.BunifuDropdown cbxSearchBy;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSearch;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClose;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCreateBill;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPayBill;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.UI.WinForms.BunifuDropdown cbxStudentName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewRoomBill;
        private Bunifu.Framework.UI.BunifuThinButton2 btnBillDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillType;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREATING;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAYMENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn FORMONTH;
    }
}
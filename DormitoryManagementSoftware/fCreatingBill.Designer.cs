
namespace DormitoryManagementSoftware
{
    partial class fCreatingBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCreatingBill));
            this.labelName = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbxNameRoom = new Bunifu.UI.WinForms.BunifuDropdown();
            this.cbRoomType = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxBillType = new Bunifu.UI.WinForms.BunifuDropdown();
            this.tbxPrice = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbxMonth = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCreateBill = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.labelName.Size = new System.Drawing.Size(190, 37);
            this.labelName.TabIndex = 74;
            this.labelName.Text = "Tạo Hóa Đơn";
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
            this.bunifuSeparator1.Size = new System.Drawing.Size(419, 13);
            this.bunifuSeparator1.TabIndex = 75;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cbxNameRoom);
            this.groupBox6.Controls.Add(this.cbRoomType);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.groupBox6.Location = new System.Drawing.Point(3, 49);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(435, 91);
            this.groupBox6.TabIndex = 76;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Thông Tin Phòng";
            // 
            // cbxNameRoom
            // 
            this.cbxNameRoom.BackColor = System.Drawing.Color.Transparent;
            this.cbxNameRoom.BackgroundColor = System.Drawing.Color.White;
            this.cbxNameRoom.BorderColor = System.Drawing.Color.Silver;
            this.cbxNameRoom.BorderRadius = 1;
            this.cbxNameRoom.Color = System.Drawing.Color.Silver;
            this.cbxNameRoom.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cbxNameRoom.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbxNameRoom.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbxNameRoom.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbxNameRoom.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cbxNameRoom.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cbxNameRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxNameRoom.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cbxNameRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNameRoom.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbxNameRoom.FillDropDown = true;
            this.cbxNameRoom.FillIndicator = false;
            this.cbxNameRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxNameRoom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbxNameRoom.ForeColor = System.Drawing.Color.Black;
            this.cbxNameRoom.FormattingEnabled = true;
            this.cbxNameRoom.Icon = null;
            this.cbxNameRoom.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbxNameRoom.IndicatorColor = System.Drawing.Color.DarkGray;
            this.cbxNameRoom.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbxNameRoom.IndicatorThickness = 2;
            this.cbxNameRoom.IsDropdownOpened = false;
            this.cbxNameRoom.ItemBackColor = System.Drawing.Color.White;
            this.cbxNameRoom.ItemBorderColor = System.Drawing.Color.White;
            this.cbxNameRoom.ItemForeColor = System.Drawing.Color.Black;
            this.cbxNameRoom.ItemHeight = 26;
            this.cbxNameRoom.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cbxNameRoom.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cbxNameRoom.ItemTopMargin = 3;
            this.cbxNameRoom.Location = new System.Drawing.Point(225, 46);
            this.cbxNameRoom.Name = "cbxNameRoom";
            this.cbxNameRoom.Size = new System.Drawing.Size(203, 32);
            this.cbxNameRoom.TabIndex = 43;
            this.cbxNameRoom.Text = null;
            this.cbxNameRoom.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbxNameRoom.TextLeftMargin = 5;
            // 
            // cbRoomType
            // 
            this.cbRoomType.BackColor = System.Drawing.Color.Transparent;
            this.cbRoomType.BackgroundColor = System.Drawing.Color.White;
            this.cbRoomType.BorderColor = System.Drawing.Color.Silver;
            this.cbRoomType.BorderRadius = 1;
            this.cbRoomType.Color = System.Drawing.Color.Silver;
            this.cbRoomType.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cbRoomType.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbRoomType.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbRoomType.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbRoomType.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cbRoomType.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cbRoomType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbRoomType.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoomType.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbRoomType.FillDropDown = true;
            this.cbRoomType.FillIndicator = false;
            this.cbRoomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRoomType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbRoomType.ForeColor = System.Drawing.Color.Black;
            this.cbRoomType.FormattingEnabled = true;
            this.cbRoomType.Icon = null;
            this.cbRoomType.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbRoomType.IndicatorColor = System.Drawing.Color.DarkGray;
            this.cbRoomType.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbRoomType.IndicatorThickness = 2;
            this.cbRoomType.IsDropdownOpened = false;
            this.cbRoomType.ItemBackColor = System.Drawing.Color.White;
            this.cbRoomType.ItemBorderColor = System.Drawing.Color.White;
            this.cbRoomType.ItemForeColor = System.Drawing.Color.Black;
            this.cbRoomType.ItemHeight = 26;
            this.cbRoomType.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cbRoomType.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cbRoomType.ItemTopMargin = 3;
            this.cbRoomType.Location = new System.Drawing.Point(8, 46);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(205, 32);
            this.cbRoomType.TabIndex = 42;
            this.cbRoomType.Text = null;
            this.cbRoomType.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbRoomType.TextLeftMargin = 5;
            this.cbRoomType.SelectedIndexChanged += new System.EventHandler(this.cbRoomType_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.label17.Location = new System.Drawing.Point(6, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 20);
            this.label17.TabIndex = 32;
            this.label17.Text = "Loại phòng:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.label19.Location = new System.Drawing.Point(222, 24);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 20);
            this.label19.TabIndex = 38;
            this.label19.Text = "Tên Phòng:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxBillType);
            this.groupBox1.Controls.Add(this.tbxPrice);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cbxMonth);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.groupBox1.Location = new System.Drawing.Point(3, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 146);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Hóa Đơn";
            // 
            // cbxBillType
            // 
            this.cbxBillType.BackColor = System.Drawing.Color.Transparent;
            this.cbxBillType.BackgroundColor = System.Drawing.Color.White;
            this.cbxBillType.BorderColor = System.Drawing.Color.Silver;
            this.cbxBillType.BorderRadius = 1;
            this.cbxBillType.Color = System.Drawing.Color.Silver;
            this.cbxBillType.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cbxBillType.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbxBillType.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbxBillType.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbxBillType.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cbxBillType.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cbxBillType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxBillType.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cbxBillType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBillType.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbxBillType.FillDropDown = true;
            this.cbxBillType.FillIndicator = false;
            this.cbxBillType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxBillType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbxBillType.ForeColor = System.Drawing.Color.Black;
            this.cbxBillType.FormattingEnabled = true;
            this.cbxBillType.Icon = null;
            this.cbxBillType.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbxBillType.IndicatorColor = System.Drawing.Color.DarkGray;
            this.cbxBillType.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbxBillType.IndicatorThickness = 2;
            this.cbxBillType.IsDropdownOpened = false;
            this.cbxBillType.ItemBackColor = System.Drawing.Color.White;
            this.cbxBillType.ItemBorderColor = System.Drawing.Color.White;
            this.cbxBillType.ItemForeColor = System.Drawing.Color.Black;
            this.cbxBillType.ItemHeight = 26;
            this.cbxBillType.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cbxBillType.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cbxBillType.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbxBillType.ItemTopMargin = 3;
            this.cbxBillType.Location = new System.Drawing.Point(9, 48);
            this.cbxBillType.Name = "cbxBillType";
            this.cbxBillType.Size = new System.Drawing.Size(206, 32);
            this.cbxBillType.TabIndex = 61;
            this.cbxBillType.Text = null;
            this.cbxBillType.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbxBillType.TextLeftMargin = 5;
            this.cbxBillType.SelectedIndexChanged += new System.EventHandler(this.cbxBillType_SelectedIndexChanged);
            // 
            // tbxPrice
            // 
            this.tbxPrice.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.tbxPrice.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.tbxPrice.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.tbxPrice.BorderThickness = 1;
            this.tbxPrice.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbxPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbxPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxPrice.isPassword = false;
            this.tbxPrice.Location = new System.Drawing.Point(11, 106);
            this.tbxPrice.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPrice.MaxLength = 32767;
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(202, 29);
            this.tbxPrice.TabIndex = 46;
            this.tbxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPrice_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.label1.Location = new System.Drawing.Point(11, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Số tiền:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.label13.Location = new System.Drawing.Point(9, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 20);
            this.label13.TabIndex = 60;
            this.label13.Text = "Loại hóa đơn:";
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
            this.cbxMonth.DropDownHeight = 120;
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
            this.cbxMonth.IntegralHeight = false;
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
            this.cbxMonth.Location = new System.Drawing.Point(225, 47);
            this.cbxMonth.Name = "cbxMonth";
            this.cbxMonth.Size = new System.Drawing.Size(203, 32);
            this.cbxMonth.TabIndex = 43;
            this.cbxMonth.Text = null;
            this.cbxMonth.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbxMonth.TextLeftMargin = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.label2.Location = new System.Drawing.Point(222, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Tháng:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnCreateBill);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.groupBox2.Location = new System.Drawing.Point(3, 291);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 77);
            this.groupBox2.TabIndex = 78;
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
            this.btnClose.Location = new System.Drawing.Point(242, 24);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(175, 40);
            this.btnClose.TabIndex = 25;
            this.btnClose.TabStop = false;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            // fCreatingBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 373);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.labelName);
            this.Name = "fCreatingBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh Toán Hóa Đơn";
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.GroupBox groupBox6;
        private Bunifu.UI.WinForms.BunifuDropdown cbxNameRoom;
        private Bunifu.UI.WinForms.BunifuDropdown cbRoomType;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClose;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCreateBill;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbxPrice;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuDropdown cbxMonth;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuDropdown cbxBillType;
        private System.Windows.Forms.Label label13;
    }
}
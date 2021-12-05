
namespace DormitoryManagementSoftware
{
    partial class fStudent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fStudent));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
            this.bindingStudent = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxSearchBy = new Bunifu.UI.WinForms.BunifuDropdown();
            this.txbSearch = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCloseFStudent = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnUpdateStudent = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAddStudent = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label6 = new System.Windows.Forms.Label();
            this.groupStudent = new System.Windows.Forms.GroupBox();
            this.dropID = new Bunifu.UI.WinForms.BunifuDropdown();
            this.lblId = new System.Windows.Forms.Label();
            this.txbMSSV = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.dropSex = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label14 = new System.Windows.Forms.Label();
            this.txbAddress = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txbPhoneNumber = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbFullName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.datepickerDateOfBirth = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbIDCard = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label16 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNameStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingStudent)).BeginInit();
            this.bindingStudent.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewStudent);
            this.groupBox1.Controls.Add(this.bindingStudent);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.groupBox1.Location = new System.Drawing.Point(427, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 510);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Sinh Viên";
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.AllowUserToAddRows = false;
            this.dataGridViewStudent.AllowUserToDeleteRows = false;
            this.dataGridViewStudent.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.dataGridViewStudent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStudent.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewStudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewStudent.ColumnHeadersHeight = 25;
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colMSSV,
            this.colNameStudent,
            this.colIDCard,
            this.colSex,
            this.colDateOfBirth,
            this.colPhone,
            this.colAddress});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStudent.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStudent.GridColor = System.Drawing.Color.White;
            this.dataGridViewStudent.Location = new System.Drawing.Point(3, 68);
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStudent.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewStudent.RowHeadersVisible = false;
            this.dataGridViewStudent.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewStudent.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dataGridViewStudent.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStudent.Size = new System.Drawing.Size(653, 439);
            this.dataGridViewStudent.TabIndex = 3;
            this.dataGridViewStudent.SelectionChanged += new System.EventHandler(this.dataGridViewStudent_SelectionChanged);
            // 
            // bindingStudent
            // 
            this.bindingStudent.AddNewItem = null;
            this.bindingStudent.AutoSize = false;
            this.bindingStudent.BackColor = System.Drawing.Color.Transparent;
            this.bindingStudent.CountItem = this.bindingNavigatorCountItem;
            this.bindingStudent.CountItemFormat = "của {0}";
            this.bindingStudent.DeleteItem = null;
            this.bindingStudent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingStudent.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingStudent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem});
            this.bindingStudent.Location = new System.Drawing.Point(3, 25);
            this.bindingStudent.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingStudent.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingStudent.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingStudent.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingStudent.Name = "bindingStudent";
            this.bindingStudent.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingStudent.Size = new System.Drawing.Size(653, 43);
            this.bindingStudent.TabIndex = 29;
            this.bindingStudent.Text = "binding";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(47, 40);
            this.bindingNavigatorCountItem.Text = "của {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Tổng số Sinh Viên";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.AutoSize = false;
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(50, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            this.bindingNavigatorMoveFirstItem.ToolTipText = "Sinh Viên đầu tiên";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.AutoSize = false;
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(50, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.ToolTipText = "Sinh Viên trước đó";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 43);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 25);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Vị trí Sinh Viên";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.AutoSize = false;
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(50, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.ToolTipText = "Sinh Viên kế tiếp";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.AutoSize = false;
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(50, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            this.bindingNavigatorMoveLastItem.ToolTipText = "Sinh Viên cuối cùng";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbxSearchBy);
            this.groupBox3.Controls.Add(this.txbSearch);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.btnCancel);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.groupBox3.Location = new System.Drawing.Point(8, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(414, 115);
            this.groupBox3.TabIndex = 57;
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
            "Mã ID",
            "Tên Sinh Viên",
            "CMND",
            "MSSV"});
            this.cbxSearchBy.ItemTopMargin = 3;
            this.cbxSearchBy.Location = new System.Drawing.Point(129, 22);
            this.cbxSearchBy.Name = "cbxSearchBy";
            this.cbxSearchBy.Size = new System.Drawing.Size(266, 32);
            this.cbxSearchBy.TabIndex = 60;
            this.cbxSearchBy.Text = null;
            this.cbxSearchBy.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbxSearchBy.TextLeftMargin = 5;
            // 
            // txbSearch
            // 
            this.txbSearch.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.txbSearch.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.txbSearch.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.txbSearch.BorderThickness = 1;
            this.txbSearch.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbSearch.isPassword = false;
            this.txbSearch.Location = new System.Drawing.Point(16, 65);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txbSearch.MaxLength = 32767;
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(236, 29);
            this.txbSearch.TabIndex = 0;
            this.txbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.btnSearch.Location = new System.Drawing.Point(260, 61);
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
            this.btnCancel.Location = new System.Drawing.Point(260, 61);
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
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnCloseFStudent);
            this.groupBox2.Controls.Add(this.btnUpdateStudent);
            this.groupBox2.Controls.Add(this.btnAddStudent);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.groupBox2.Location = new System.Drawing.Point(8, 449);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 118);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveBorderThickness = 1;
            this.btnDelete.ActiveCornerRadius = 20;
            this.btnDelete.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.btnDelete.ActiveForecolor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.ButtonText = "Xóa";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnDelete.IdleBorderThickness = 1;
            this.btnDelete.IdleCornerRadius = 20;
            this.btnDelete.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnDelete.IdleForecolor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnDelete.Location = new System.Drawing.Point(12, 69);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(175, 40);
            this.btnDelete.TabIndex = 53;
            this.btnDelete.TabStop = false;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCloseFStudent
            // 
            this.btnCloseFStudent.ActiveBorderThickness = 1;
            this.btnCloseFStudent.ActiveCornerRadius = 20;
            this.btnCloseFStudent.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(158)))), ((int)(((byte)(75)))));
            this.btnCloseFStudent.ActiveForecolor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCloseFStudent.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(158)))), ((int)(((byte)(75)))));
            this.btnCloseFStudent.BackColor = System.Drawing.SystemColors.Control;
            this.btnCloseFStudent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCloseFStudent.BackgroundImage")));
            this.btnCloseFStudent.ButtonText = "Đóng";
            this.btnCloseFStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseFStudent.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseFStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnCloseFStudent.IdleBorderThickness = 1;
            this.btnCloseFStudent.IdleCornerRadius = 20;
            this.btnCloseFStudent.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.btnCloseFStudent.IdleForecolor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCloseFStudent.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.btnCloseFStudent.Location = new System.Drawing.Point(217, 69);
            this.btnCloseFStudent.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseFStudent.Name = "btnCloseFStudent";
            this.btnCloseFStudent.Size = new System.Drawing.Size(175, 40);
            this.btnCloseFStudent.TabIndex = 52;
            this.btnCloseFStudent.TabStop = false;
            this.btnCloseFStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCloseFStudent.Click += new System.EventHandler(this.btnCloseFStudent_Click);
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.ActiveBorderThickness = 1;
            this.btnUpdateStudent.ActiveCornerRadius = 20;
            this.btnUpdateStudent.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.btnUpdateStudent.ActiveForecolor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateStudent.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.btnUpdateStudent.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdateStudent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateStudent.BackgroundImage")));
            this.btnUpdateStudent.ButtonText = "Cập Nhật";
            this.btnUpdateStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateStudent.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnUpdateStudent.IdleBorderThickness = 1;
            this.btnUpdateStudent.IdleCornerRadius = 20;
            this.btnUpdateStudent.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnUpdateStudent.IdleForecolor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateStudent.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnUpdateStudent.Location = new System.Drawing.Point(12, 25);
            this.btnUpdateStudent.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(175, 40);
            this.btnUpdateStudent.TabIndex = 51;
            this.btnUpdateStudent.TabStop = false;
            this.btnUpdateStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.ActiveBorderThickness = 1;
            this.btnAddStudent.ActiveCornerRadius = 20;
            this.btnAddStudent.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.btnAddStudent.ActiveForecolor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddStudent.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.btnAddStudent.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddStudent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddStudent.BackgroundImage")));
            this.btnAddStudent.ButtonText = "Thêm";
            this.btnAddStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStudent.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnAddStudent.IdleBorderThickness = 1;
            this.btnAddStudent.IdleCornerRadius = 20;
            this.btnAddStudent.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnAddStudent.IdleForecolor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddStudent.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnAddStudent.Location = new System.Drawing.Point(216, 25);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(175, 40);
            this.btnAddStudent.TabIndex = 8;
            this.btnAddStudent.TabStop = false;
            this.btnAddStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 37);
            this.label6.TabIndex = 62;
            this.label6.Text = "Quản Lý Sinh Viên";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupStudent
            // 
            this.groupStudent.Controls.Add(this.dropID);
            this.groupStudent.Controls.Add(this.lblId);
            this.groupStudent.Controls.Add(this.txbMSSV);
            this.groupStudent.Controls.Add(this.dropSex);
            this.groupStudent.Controls.Add(this.label14);
            this.groupStudent.Controls.Add(this.txbAddress);
            this.groupStudent.Controls.Add(this.txbPhoneNumber);
            this.groupStudent.Controls.Add(this.label11);
            this.groupStudent.Controls.Add(this.label2);
            this.groupStudent.Controls.Add(this.txbFullName);
            this.groupStudent.Controls.Add(this.datepickerDateOfBirth);
            this.groupStudent.Controls.Add(this.label13);
            this.groupStudent.Controls.Add(this.label15);
            this.groupStudent.Controls.Add(this.label1);
            this.groupStudent.Controls.Add(this.txbIDCard);
            this.groupStudent.Controls.Add(this.label16);
            this.groupStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupStudent.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.groupStudent.Location = new System.Drawing.Point(8, 178);
            this.groupStudent.Name = "groupStudent";
            this.groupStudent.Size = new System.Drawing.Size(414, 268);
            this.groupStudent.TabIndex = 58;
            this.groupStudent.TabStop = false;
            this.groupStudent.Text = "Thông Tin Sinh Viên";
            // 
            // dropID
            // 
            this.dropID.BackColor = System.Drawing.Color.Transparent;
            this.dropID.BackgroundColor = System.Drawing.Color.White;
            this.dropID.BorderColor = System.Drawing.Color.Silver;
            this.dropID.BorderRadius = 1;
            this.dropID.Color = System.Drawing.Color.Silver;
            this.dropID.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.dropID.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dropID.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dropID.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dropID.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dropID.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.dropID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dropID.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.dropID.DropDownHeight = 120;
            this.dropID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropID.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.dropID.FillDropDown = true;
            this.dropID.FillIndicator = false;
            this.dropID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dropID.ForeColor = System.Drawing.Color.Black;
            this.dropID.FormattingEnabled = true;
            this.dropID.Icon = null;
            this.dropID.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.dropID.IndicatorColor = System.Drawing.Color.DarkGray;
            this.dropID.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.dropID.IndicatorThickness = 2;
            this.dropID.IntegralHeight = false;
            this.dropID.IsDropdownOpened = false;
            this.dropID.ItemBackColor = System.Drawing.Color.White;
            this.dropID.ItemBorderColor = System.Drawing.Color.White;
            this.dropID.ItemForeColor = System.Drawing.Color.Black;
            this.dropID.ItemHeight = 26;
            this.dropID.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.dropID.ItemHighLightForeColor = System.Drawing.Color.White;
            this.dropID.ItemTopMargin = 3;
            this.dropID.Location = new System.Drawing.Point(11, 43);
            this.dropID.Name = "dropID";
            this.dropID.Size = new System.Drawing.Size(175, 32);
            this.dropID.TabIndex = 62;
            this.dropID.Text = null;
            this.dropID.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.dropID.TextLeftMargin = 5;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.lblId.Location = new System.Drawing.Point(11, 21);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(27, 20);
            this.lblId.TabIndex = 61;
            this.lblId.Text = "ID:";
            // 
            // txbMSSV
            // 
            this.txbMSSV.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.txbMSSV.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.txbMSSV.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.txbMSSV.BorderThickness = 1;
            this.txbMSSV.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbMSSV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbMSSV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMSSV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbMSSV.isPassword = false;
            this.txbMSSV.Location = new System.Drawing.Point(215, 43);
            this.txbMSSV.Margin = new System.Windows.Forms.Padding(0);
            this.txbMSSV.MaxLength = 32767;
            this.txbMSSV.Name = "txbMSSV";
            this.txbMSSV.Size = new System.Drawing.Size(175, 29);
            this.txbMSSV.TabIndex = 60;
            this.txbMSSV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbMSSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMSSVPhoneNumberIdCard_KeyPress);
            // 
            // dropSex
            // 
            this.dropSex.BackColor = System.Drawing.Color.Transparent;
            this.dropSex.BackgroundColor = System.Drawing.Color.White;
            this.dropSex.BorderColor = System.Drawing.Color.Silver;
            this.dropSex.BorderRadius = 1;
            this.dropSex.Color = System.Drawing.Color.Silver;
            this.dropSex.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.dropSex.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dropSex.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dropSex.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dropSex.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dropSex.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.dropSex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dropSex.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.dropSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropSex.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.dropSex.FillDropDown = true;
            this.dropSex.FillIndicator = false;
            this.dropSex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropSex.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dropSex.ForeColor = System.Drawing.Color.Black;
            this.dropSex.FormattingEnabled = true;
            this.dropSex.Icon = null;
            this.dropSex.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.dropSex.IndicatorColor = System.Drawing.Color.DarkGray;
            this.dropSex.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.dropSex.IndicatorThickness = 2;
            this.dropSex.IsDropdownOpened = false;
            this.dropSex.ItemBackColor = System.Drawing.Color.White;
            this.dropSex.ItemBorderColor = System.Drawing.Color.White;
            this.dropSex.ItemForeColor = System.Drawing.Color.Black;
            this.dropSex.ItemHeight = 26;
            this.dropSex.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.dropSex.ItemHighLightForeColor = System.Drawing.Color.White;
            this.dropSex.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.dropSex.ItemTopMargin = 3;
            this.dropSex.Location = new System.Drawing.Point(216, 156);
            this.dropSex.Name = "dropSex";
            this.dropSex.Size = new System.Drawing.Size(175, 32);
            this.dropSex.TabIndex = 59;
            this.dropSex.Text = null;
            this.dropSex.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.dropSex.TextLeftMargin = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.label14.Location = new System.Drawing.Point(216, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 20);
            this.label14.TabIndex = 55;
            this.label14.Text = "Số điện thoại:";
            // 
            // txbAddress
            // 
            this.txbAddress.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.txbAddress.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.txbAddress.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.txbAddress.BorderThickness = 1;
            this.txbAddress.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbAddress.isPassword = false;
            this.txbAddress.Location = new System.Drawing.Point(12, 219);
            this.txbAddress.Margin = new System.Windows.Forms.Padding(0);
            this.txbAddress.MaxLength = 32767;
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(175, 29);
            this.txbAddress.TabIndex = 53;
            this.txbAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txbPhoneNumber
            // 
            this.txbPhoneNumber.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.txbPhoneNumber.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.txbPhoneNumber.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.txbPhoneNumber.BorderThickness = 1;
            this.txbPhoneNumber.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbPhoneNumber.isPassword = false;
            this.txbPhoneNumber.Location = new System.Drawing.Point(216, 99);
            this.txbPhoneNumber.Margin = new System.Windows.Forms.Padding(0);
            this.txbPhoneNumber.MaxLength = 32767;
            this.txbPhoneNumber.Name = "txbPhoneNumber";
            this.txbPhoneNumber.Size = new System.Drawing.Size(175, 29);
            this.txbPhoneNumber.TabIndex = 52;
            this.txbPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMSSVPhoneNumberIdCard_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.label11.Location = new System.Drawing.Point(12, 197);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 20);
            this.label11.TabIndex = 57;
            this.label11.Text = "Quê quán:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.label2.Location = new System.Drawing.Point(215, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "MSSV:";
            // 
            // txbFullName
            // 
            this.txbFullName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.txbFullName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.txbFullName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.txbFullName.BorderThickness = 1;
            this.txbFullName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbFullName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbFullName.isPassword = false;
            this.txbFullName.Location = new System.Drawing.Point(12, 99);
            this.txbFullName.Margin = new System.Windows.Forms.Padding(0);
            this.txbFullName.MaxLength = 32767;
            this.txbFullName.Name = "txbFullName";
            this.txbFullName.Size = new System.Drawing.Size(175, 29);
            this.txbFullName.TabIndex = 1;
            this.txbFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbFullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbFullName_KeyPress);
            // 
            // datepickerDateOfBirth
            // 
            this.datepickerDateOfBirth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.datepickerDateOfBirth.BorderRadius = 0;
            this.datepickerDateOfBirth.ForeColor = System.Drawing.Color.White;
            this.datepickerDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepickerDateOfBirth.FormatCustom = null;
            this.datepickerDateOfBirth.Location = new System.Drawing.Point(216, 219);
            this.datepickerDateOfBirth.Margin = new System.Windows.Forms.Padding(48, 79, 48, 79);
            this.datepickerDateOfBirth.Name = "datepickerDateOfBirth";
            this.datepickerDateOfBirth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.datepickerDateOfBirth.Size = new System.Drawing.Size(176, 29);
            this.datepickerDateOfBirth.TabIndex = 5;
            this.datepickerDateOfBirth.Value = new System.DateTime(2018, 2, 23, 23, 29, 57, 962);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.label13.Location = new System.Drawing.Point(216, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "Giới tính:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.label15.Location = new System.Drawing.Point(12, 133);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 20);
            this.label15.TabIndex = 24;
            this.label15.Text = "Số CMND:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.label1.Location = new System.Drawing.Point(216, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Ngày sinh:";
            // 
            // txbIDCard
            // 
            this.txbIDCard.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.txbIDCard.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.txbIDCard.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.txbIDCard.BorderThickness = 1;
            this.txbIDCard.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbIDCard.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbIDCard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIDCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbIDCard.isPassword = false;
            this.txbIDCard.Location = new System.Drawing.Point(12, 155);
            this.txbIDCard.Margin = new System.Windows.Forms.Padding(0);
            this.txbIDCard.MaxLength = 32767;
            this.txbIDCard.Name = "txbIDCard";
            this.txbIDCard.Size = new System.Drawing.Size(175, 29);
            this.txbIDCard.TabIndex = 2;
            this.txbIDCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbIDCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMSSVPhoneNumberIdCard_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.label16.Location = new System.Drawing.Point(12, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 20);
            this.label16.TabIndex = 22;
            this.label16.Text = "Họ và tên:";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(8, 46);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1078, 12);
            this.bunifuSeparator1.TabIndex = 63;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(1201, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(16, 16);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 60;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            // 
            // colID
            // 
            this.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 53;
            // 
            // colMSSV
            // 
            this.colMSSV.DataPropertyName = "MSSV";
            this.colMSSV.HeaderText = "MSSV";
            this.colMSSV.Name = "colMSSV";
            this.colMSSV.ReadOnly = true;
            // 
            // colNameStudent
            // 
            this.colNameStudent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colNameStudent.DataPropertyName = "Name";
            this.colNameStudent.HeaderText = "Tên";
            this.colNameStudent.Name = "colNameStudent";
            this.colNameStudent.ReadOnly = true;
            this.colNameStudent.Width = 64;
            // 
            // colIDCard
            // 
            this.colIDCard.DataPropertyName = "IDCard";
            this.colIDCard.FillWeight = 90F;
            this.colIDCard.HeaderText = "Số CMND";
            this.colIDCard.Name = "colIDCard";
            this.colIDCard.ReadOnly = true;
            this.colIDCard.Width = 90;
            // 
            // colSex
            // 
            this.colSex.DataPropertyName = "Sex";
            this.colSex.FillWeight = 85F;
            this.colSex.HeaderText = "Giới Tính";
            this.colSex.Name = "colSex";
            this.colSex.ReadOnly = true;
            this.colSex.Visible = false;
            this.colSex.Width = 85;
            // 
            // colDateOfBirth
            // 
            this.colDateOfBirth.DataPropertyName = "dateOfBirth";
            this.colDateOfBirth.FillWeight = 90F;
            this.colDateOfBirth.HeaderText = "Ngày Sinh";
            this.colDateOfBirth.Name = "colDateOfBirth";
            this.colDateOfBirth.ReadOnly = true;
            this.colDateOfBirth.Visible = false;
            this.colDateOfBirth.Width = 90;
            // 
            // colPhone
            // 
            this.colPhone.DataPropertyName = "phoneNumber";
            this.colPhone.HeaderText = "SĐT";
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            // 
            // colAddress
            // 
            this.colAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAddress.DataPropertyName = "Address";
            this.colAddress.HeaderText = "Quê quán";
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            // 
            // fStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 576);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupStudent);
            this.Controls.Add(this.bunifuSeparator1);
            this.Name = "fStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sinh Viên";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingStudent)).EndInit();
            this.bindingStudent.ResumeLayout(false);
            this.bindingStudent.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupStudent.ResumeLayout(false);
            this.groupStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewStudent;
        private System.Windows.Forms.BindingNavigator bindingStudent;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbSearch;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSearch;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCloseFStudent;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUpdateStudent;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddStudent;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupStudent;
        private System.Windows.Forms.Label label14;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbAddress;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbPhoneNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbFullName;
        private Bunifu.Framework.UI.BunifuDatepicker datepickerDateOfBirth;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbIDCard;
        private System.Windows.Forms.Label label16;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuDropdown cbxSearchBy;
        private Bunifu.UI.WinForms.BunifuDropdown dropSex;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbMSSV;
        private System.Windows.Forms.Label lblId;
        private Bunifu.UI.WinForms.BunifuDropdown dropID;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNameStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
    }
}
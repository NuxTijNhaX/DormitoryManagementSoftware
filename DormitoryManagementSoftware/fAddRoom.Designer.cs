
namespace DormitoryManagementSoftware
{
    partial class fAddRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAddRoom));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAddRoom = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupRoom = new System.Windows.Forms.GroupBox();
            this.comboBoxRoomType = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label20 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txbNameRoom = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.groupBox4.SuspendLayout();
            this.groupRoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnClose);
            this.groupBox4.Controls.Add(this.btnAddRoom);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.groupBox4.Location = new System.Drawing.Point(11, 162);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(443, 81);
            this.groupBox4.TabIndex = 70;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức Năng";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(11, 40);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(443, 13);
            this.bunifuSeparator1.TabIndex = 68;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.label6.Location = new System.Drawing.Point(4, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 37);
            this.label6.TabIndex = 67;
            this.label6.Text = "Thêm Phòng";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.IdleBorderThickness = 1;
            this.btnClose.IdleCornerRadius = 20;
            this.btnClose.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.btnClose.IdleForecolor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.btnClose.Location = new System.Drawing.Point(246, 29);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(175, 40);
            this.btnClose.TabIndex = 11;
            this.btnClose.TabStop = false;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.ActiveBorderThickness = 1;
            this.btnAddRoom.ActiveCornerRadius = 20;
            this.btnAddRoom.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.btnAddRoom.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddRoom.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.btnAddRoom.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddRoom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddRoom.BackgroundImage")));
            this.btnAddRoom.ButtonText = "Thêm Phòng";
            this.btnAddRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRoom.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.IdleBorderThickness = 1;
            this.btnAddRoom.IdleCornerRadius = 20;
            this.btnAddRoom.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnAddRoom.IdleForecolor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddRoom.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnAddRoom.Location = new System.Drawing.Point(13, 29);
            this.btnAddRoom.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(175, 40);
            this.btnAddRoom.TabIndex = 10;
            this.btnAddRoom.TabStop = false;
            this.btnAddRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // groupRoom
            // 
            this.groupRoom.Controls.Add(this.comboBoxRoomType);
            this.groupRoom.Controls.Add(this.label20);
            this.groupRoom.Controls.Add(this.label15);
            this.groupRoom.Controls.Add(this.txbNameRoom);
            this.groupRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupRoom.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.groupRoom.Location = new System.Drawing.Point(10, 50);
            this.groupRoom.Name = "groupRoom";
            this.groupRoom.Size = new System.Drawing.Size(444, 103);
            this.groupRoom.TabIndex = 71;
            this.groupRoom.TabStop = false;
            this.groupRoom.Text = "Thông Tin Phòng";
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxRoomType.BackgroundColor = System.Drawing.Color.White;
            this.comboBoxRoomType.BorderColor = System.Drawing.Color.Silver;
            this.comboBoxRoomType.BorderRadius = 1;
            this.comboBoxRoomType.Color = System.Drawing.Color.Silver;
            this.comboBoxRoomType.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.comboBoxRoomType.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.comboBoxRoomType.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.comboBoxRoomType.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.comboBoxRoomType.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.comboBoxRoomType.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.comboBoxRoomType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxRoomType.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.comboBoxRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoomType.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.comboBoxRoomType.FillDropDown = true;
            this.comboBoxRoomType.FillIndicator = false;
            this.comboBoxRoomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxRoomType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBoxRoomType.ForeColor = System.Drawing.Color.Black;
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Icon = null;
            this.comboBoxRoomType.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.comboBoxRoomType.IndicatorColor = System.Drawing.Color.DarkGray;
            this.comboBoxRoomType.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.comboBoxRoomType.IndicatorThickness = 2;
            this.comboBoxRoomType.IsDropdownOpened = false;
            this.comboBoxRoomType.ItemBackColor = System.Drawing.Color.White;
            this.comboBoxRoomType.ItemBorderColor = System.Drawing.Color.White;
            this.comboBoxRoomType.ItemForeColor = System.Drawing.Color.Black;
            this.comboBoxRoomType.ItemHeight = 26;
            this.comboBoxRoomType.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.comboBoxRoomType.ItemHighLightForeColor = System.Drawing.Color.White;
            this.comboBoxRoomType.ItemTopMargin = 3;
            this.comboBoxRoomType.Location = new System.Drawing.Point(225, 53);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(197, 32);
            this.comboBoxRoomType.TabIndex = 46;
            this.comboBoxRoomType.Text = null;
            this.comboBoxRoomType.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.comboBoxRoomType.TextLeftMargin = 5;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.label20.Location = new System.Drawing.Point(228, 30);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(86, 20);
            this.label20.TabIndex = 41;
            this.label20.Text = "Loại Phòng:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.label15.Location = new System.Drawing.Point(18, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 20);
            this.label15.TabIndex = 24;
            this.label15.Text = "Tên Phòng:";
            // 
            // txbNameRoom
            // 
            this.txbNameRoom.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.txbNameRoom.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.txbNameRoom.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.txbNameRoom.BorderThickness = 1;
            this.txbNameRoom.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbNameRoom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNameRoom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNameRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbNameRoom.isPassword = false;
            this.txbNameRoom.Location = new System.Drawing.Point(18, 53);
            this.txbNameRoom.Margin = new System.Windows.Forms.Padding(0);
            this.txbNameRoom.MaxLength = 32767;
            this.txbNameRoom.Name = "txbNameRoom";
            this.txbNameRoom.Size = new System.Drawing.Size(175, 29);
            this.txbNameRoom.TabIndex = 1;
            this.txbNameRoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // fAddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 250);
            this.Controls.Add(this.groupRoom);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label6);
            this.Name = "fAddRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Phòng";
            this.groupBox4.ResumeLayout(false);
            this.groupRoom.ResumeLayout(false);
            this.groupRoom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClose;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddRoom;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupRoom;
        private Bunifu.UI.WinForms.BunifuDropdown comboBoxRoomType;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label15;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbNameRoom;
    }
}
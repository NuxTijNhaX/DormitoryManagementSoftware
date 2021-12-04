using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DormitoryManagementSoftware.DAO;

namespace DormitoryManagementSoftware
{
    public partial class fPrintContract : Form
    {
        #region Methods

        private DateTime creating;
        private string mssv;

        public fPrintContract (string mssv, DateTime creating)
        {
            this.creating = creating;
            this.mssv = mssv;

            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            DataRow row = GetDataContract();

            lblDay.Text = creating.Day.ToString();
            lblMonth.Text = creating.Month.ToString();
            lblYear.Text = creating.Year.ToString();

            lblStaffName.Text = lblStaffNameSign.Text = row["STAFFNAME"].ToString();
            lblStaffType.Text = row["NAMETYPE"].ToString();
            lblStaffNumber.Text = row["STAFFNUMBER"].ToString();

            lblStudentName.Text = lblStaffNameSign.Text = row["StudentName"].ToString();
            lblMSSV.Text = mssv;
            lblSex.Text = row["Sex"].ToString();
            DateTime studentDoB = (DateTime) row["DateOfBirth"];
            string[] dateTime = studentDoB.ToString().Split(' ')[0].Split('/');
            lblDoB.Text = dateTime[1] + "-" + dateTime[0] + "-" + dateTime[2];
            lblStudentNumber.Text = row["PhoneNumber"].ToString();
            lblStudentIdCard.Text = row["IDCard"].ToString();
            lblStudentAddress.Text = row["Address"].ToString();

            lblRoomName.Text = row["RoomName"].ToString();
            lblRoomType.Text = row["RoomType"].ToString();

            int price = (int)row["PRICE"];
            lblPrice.Text = price.ToString("C0", CultureInfo.CreateSpecificCulture("vi-VN"));

            DateTime start = (DateTime)row["STARTTIME"];
            string[] startTime = start.ToString().Split(' ')[0].Split('/');
            lblStart.Text = startTime[1] + "-" + startTime[0] + "-" + startTime[2];
            DateTime end = (DateTime)row["ENDTIME"];
            string[] endTime = end.ToString().Split(' ')[0].Split('/');
            lblEnd.Text = endTime[1] + "-" + endTime[0] + "-" + endTime[2];
        }

        private DataRow GetDataContract()
        {
            return ContractDAO.Instance.LoadContractByMSSV(mssv, creating);
        }

        #endregion


        #region Events

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 58, 70);
            bitmap.Dispose();
        }

        private Bitmap bitmap;
        private void btnPrintContract_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            bitmap = new Bitmap(705, 897, graphics);
            Graphics _graphics = Graphics.FromImage(bitmap);
            _graphics.CopyFromScreen(this.Location.X + 130, this.Location.Y + 40, 0, 0, new Size(705, 897));
            bitmap.Save(Application.StartupPath + @"\Contract.Png", ImageFormat.Png);
            bitmap = new Bitmap(Application.StartupPath + @"\Contract.Png");
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        #endregion
    }
}

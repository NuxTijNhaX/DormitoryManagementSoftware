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
    public partial class fBillDetails : Form
    {
        private int id;

        public fBillDetails(int id)
        {
            this.id = id;
            InitializeComponent();
            LoadBillData();
        }

        private void LoadBillData()
        {
            DataRow row = BillDAO.Instance.GetBillById(id);

            lblBillType.Text = row["BillType"].ToString();
            lblID.Text = row["ID"].ToString();

            DateTime creatingDate = (DateTime)row["CREATING"];
            string[] dateTime = creatingDate.ToString().Split(' ')[0].Split('/');
            lblCreatingDate.Text = dateTime[1] + "-" + dateTime[0] + "-" + dateTime[2];
            //lblCreatingDate.Text = row["CREATING"].ToString();

            lblMSSV.Text = row["MSSV"].ToString();
            lblStuName.Text = row["STUDENTNAME"].ToString();
            lblRoomName.Text = row["RoomName"].ToString();
            lblMonth.Text = row["FORMONTH"].ToString();

            DateTime paymentDate = (DateTime)row["PAYMENT"];
            string[] payment = paymentDate.ToString().Split(' ')[0].Split('/');
            lblPaymentDate.Text = payment[1] + "-" + payment[0] + "-" + payment[2];
            //lblPaymentDate.Text = row["PAYMENT"].ToString();

            int price = (int)row["PRICE"];
            lblPrice.Text = price.ToString("C0", CultureInfo.CreateSpecificCulture("vi-VN"));
        }

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
        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            
            Graphics graphics = this.CreateGraphics();
            bitmap = new Bitmap(725, 470, graphics);
            Graphics _graphics = Graphics.FromImage(bitmap);
            _graphics.CopyFromScreen(this.Location.X + 130, this.Location.Y + 135, 0, 0, new Size(725, 470));
            bitmap.Save(Application.StartupPath + @"\Bill.Png", ImageFormat.Png);
            bitmap = new Bitmap(Application.StartupPath + @"\Bill.Png");
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }
    }
}

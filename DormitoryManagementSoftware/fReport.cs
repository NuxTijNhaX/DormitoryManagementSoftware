using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DormitoryManagementSoftware.DAO;

namespace DormitoryManagementSoftware
{
    public partial class fReport : Form
    {
        public fReport()
        {
            InitializeComponent();
            cbxMonth.SelectedIndex = DateTime.Now.Month - 1;
            cbxYear.SelectedIndex = DateTime.Now.Year - 2018;
            cbxSearchBy.SelectedIndex = 0;

            LoadData();
        }

        private void LoadData()
        {
            string type = cbxSearchBy.Text;
            int month = int.Parse(cbxMonth.Text);
            int year = int.Parse(cbxYear.Text);

            chartReporting.Titles.Clear();
            chartReporting.Titles.Add($"Biểu Đồ Tròn Thống Kê {type} Tháng {cbxMonth.Text} - {cbxYear.Text}");
            chartReporting.Series["s1"].Points.Clear();

            LoadDataReporting(type, month, year);
        }

        private void LoadDataReporting(string type, int month, int year)
        {
            DataTable table = BillDAO.Instance.GetDataForReporting(type, month, year);
            int numOfRows = table.Rows.Count;

            if (numOfRows < 1)
            {
                MessageBox.Show("Không Có Dữ Liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int sum = BillDAO.Instance.GetSumForReporting(type, month, year);

            for (int i = 0; i < numOfRows; i++)
            {
                string roomName = table.Rows[i][0].ToString();
                string comsumption = table.Rows[i][1].ToString();

                chartReporting.Series["s1"].Points.AddXY(roomName, comsumption);
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateReport_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức Năng Chưa Được Hoàn Thiện", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

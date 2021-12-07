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
    public partial class fBill : Form
    {
        public fBill()
        {
            InitializeComponent();
            LoadFullBill(GetFullBill());
        }

        private void LoadFullBill(DataTable table)
        {
            BindingSource source = new BindingSource();
            source.DataSource = table;
            dataGridViewRoomBill.DataSource = source.DataSource;
        }

        private DataTable GetFullBill()
        {
            return BillDAO.Instance.GetFullBill();
        }

        private DataTable GetBillByStatus()
        {
            return BillDAO.Instance.GetBillByStatus(cbxSearchBy.Text);
        }

        private void Search()
        {
            LoadFullBill(GetBillByStatus());
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            fCreatingBill f = new fCreatingBill();
            f.ShowDialog();
        }

        private void dataGridViewRoomBill_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewRoomBill.SelectedRows.Count > 0)
            {
                string roomName = dataGridViewRoomBill.SelectedRows[0].Cells[1].Value.ToString();

                cbxStudentName.DataSource = ContractDAO.Instance.LoadInRoomStudentByRoomName(roomName);
                cbxStudentName.DisplayMember = "Name";
            }
        }

        private void btnPayBill_Click(object sender, EventArgs e)
        {
            if (dataGridViewRoomBill.SelectedRows[0].Cells[3].Value.ToString() == "Đã Thanh Toán")
            {
                MessageBox.Show($"Hóa Đơn Đã Được Thanh Toán", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            int idBill = int.Parse(dataGridViewRoomBill.SelectedRows[0].Cells[0].Value.ToString());
            int idStudent = StudentDAO.Instance.GetIdByName(cbxStudentName.Text);

            if (MessageBox.Show($"{cbxStudentName.Text} Sẽ Thanh Toán Hóa Đơn Này?", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (BillDAO.Instance.AddStudentPayBill(idBill, idStudent))
                {
                    LoadFullBill(GetFullBill());

                    MessageBox.Show($"Thanh Toán Thành Công", "Thông Báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Thanh Toán Không Thành Công", "Thông Báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnBillDetail_Click(object sender, EventArgs e)
        {
            if (dataGridViewRoomBill.SelectedRows[0].Cells[3].Value.ToString() == "Chưa Thanh Toán")
            {
                MessageBox.Show($"Hóa Đơn Chưa Thanh Toán\nNên Không Thể Xem Chi Tiết", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                int roomId = int.Parse(dataGridViewRoomBill.SelectedRows[0].Cells[0].Value.ToString());

                fBillDetails f = new fBillDetails(roomId);
                f.ShowDialog();
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnSearch.Visible = false;
            btnCancel.Visible = true;
            Search();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadFullBill(GetFullBill());

            btnCancel.Visible = false;
            btnSearch.Visible = true;
        }
    }
}

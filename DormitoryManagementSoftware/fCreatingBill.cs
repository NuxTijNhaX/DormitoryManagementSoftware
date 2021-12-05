using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DormitoryManagementSoftware.DAO;

namespace DormitoryManagementSoftware
{
    public partial class fCreatingBill : Form
    {
        public fCreatingBill()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            LoadRoomType();
            LoadBillType();
            int month = DateTime.Now.Month;
            cbxMonth.SelectedIndex = month - 1;
        }

        private void LoadRoomType()
        {
            cbRoomType.DataSource = RoomTypeDAO.Instance.LoadFullRoomType();
            cbRoomType.DisplayMember = "Name";
        }

        private void LoadBillType()
        {
            cbxBillType.DataSource = BillTypeDAO.Instance.LoadFullBillType();
            cbxBillType.DisplayMember = "Name";
        }

        private bool CreateBill()
        {
            int idRoom = int.Parse(RoomDAO.Instance.GetIdByNameRoom(cbxNameRoom.Text));

            return BillDAO.Instance.CreateBill(cbxBillType.SelectedIndex + 1, idRoom, int.Parse(tbxPrice.Text), cbxMonth.SelectedIndex + 1, DateTime.Now);
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            if (tbxPrice.Text == String.Empty)
            {
                MessageBox.Show("Vui Lòng Cung Cấp Đầy Đủ Thông Tin", "Thông Báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (CreateBill())
            {
                MessageBox.Show("Thêm Hóa Đơn Thành Công", "Thông Báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm Hóa Đơn Không Thành Công", "Thông Báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void cbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxNameRoom.DataSource = RoomDAO.Instance.LoadNameRoomByRoomType(cbRoomType.SelectedIndex + 1);
            cbxNameRoom.DisplayMember = "Name";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void cbxBillType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxBillType.SelectedIndex == 0)
            {
                tbxPrice.Text = RoomTypeDAO.Instance.LoadPriceByRoomType(cbRoomType.Text)[0].ToString();
                tbxPrice.Enabled = false;
            }
            else
            {
                tbxPrice.Text = String.Empty;
                tbxPrice.Enabled = true;
            }
        }
    }
}

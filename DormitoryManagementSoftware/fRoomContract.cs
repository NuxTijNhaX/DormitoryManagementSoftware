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
    public partial class fRoomContract : Form
    {
        private string userName;

        public fRoomContract(string userName)
        {
            this.userName = userName;

            InitializeComponent();
            LoadData();
        }

        private int idRoom;
        private int idStudent;

        #region Methods

        public void LoadData()
        {
            LoadRoomType();
            LoadDate();
            LoadContract(GetContract());
        }

        public void LoadRoomType()
        {
            cbRoomType.DataSource = RoomTypeDAO.Instance.LoadFullRoomType();
            cbRoomType.DisplayMember = "Name";
        }

        public void LoadDate()
        {
            dpkDateCheckIn.Value = DateTime.Now;
            dpkDateCheckOut.Value = dpkDateCheckIn.Value.AddMonths(6);
        }

        public void LoadContract(DataTable table)
        {
            BindingSource source = new BindingSource();
            source.DataSource = table;
            dataGridViewRoomContract.DataSource = source.DataSource;

            // dataGridViewRoomContract.DataSource = ContractDAO.Instance.LoadContract();
        }

        public DataTable GetContract()
        {
            return ContractDAO.Instance.LoadContract();
        }
        
        private bool IsMSSVExisted(string mssv)
        {
            return StudentDAO.Instance.IsMSSVExisted(mssv);
        }

        public void GetInfoByMSSV(string mssv)
        {
            DataRow row = StudentDAO.Instance.GetInfoByMSSV(mssv);

            txbName.Text = row["Name"].ToString();
            txbMSSV.Text = row["MSSV"].ToString();
            txbIdCard.Text = row["IDCard"].ToString();
            txbPhoneNumber.Text = row["PhoneNumber"].ToString();
            txbAddress.Text = row["Address"].ToString();
            dropSex.Text = row["Sex"].ToString();

            string[] dateTime = row["DateOfBirth"].ToString().Split(' ')[0].Split('/');
            txbDoB.Text = dateTime[1] + "-" + dateTime[0] + "-" + dateTime[2];

            idStudent = (int)row["ID"];
        }

        public bool CheckValidStatusPeople()
        {
            if (int.Parse(txbStatusPeople.Text) >= int.Parse(txbAmountPeople.Text))
            {
                return false;
            }

            return true;
        }

        public bool CreateContract(DateTime start, DateTime end, DateTime creating)
        {
            return ContractDAO.Instance.CreateContract(idRoom, idStudent, userName, start, end, creating);
        }

        public void UpdateStatusPeople(int idRoom)
        {
            ContractDAO.Instance.UpdateStatusPeople(idRoom);
        }
        
        #endregion

        #region Events

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxNameRoom.DataSource = RoomDAO.Instance.LoadNameRoomByRoomType(cbRoomType.SelectedIndex + 1);
            cbxNameRoom.DisplayMember = "Name";
        }

        private void cbxNameRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxNameRoom.Text == "System.Data.DataRowView") return;

            DataRow row = RoomDAO.Instance.LoadSpecRoomByNameRoom(cbxNameRoom.Text);

            txbStatusPeople.Text = row["STATUSPEOPLE"].ToString();
            txbAmountPeople.Text = row["LIMITPERSON"].ToString();
            int price = (int)row["Price"];
            txbPrice.Text = price.ToString("C0", CultureInfo.CreateSpecificCulture("vi-VN"));

            idRoom = (int)row["ID"];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txbSearch.Text != String.Empty)
            {
                if (IsMSSVExisted(txbSearch.Text))
                    GetInfoByMSSV(txbSearch.Text);
                else
                    MessageBox.Show("MSSV Không Tồn Tại.\nVui Lòng Nhập Lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreateContract_Click(object sender, EventArgs e)
        {
            if (!CheckValidStatusPeople())
            {
                MessageBox.Show("Phòng Đã Đủ Người\nVui Lòng Chọn Phòng Khác", "Thông Báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                
                return;
            }

            if (txbName.Text == String.Empty)
            {
                MessageBox.Show("Vui Lòng Chọn Thông Tin Sinh Viên Thông Qua Chức Năng Tìm Kiếm", "Thông Báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            if (dpkDateCheckIn.Value < DateTime.Now)
            {
                MessageBox.Show("Ngày Không Hợp Lệ\nVui Lòng Chọn Ngày Khác", "Thông Báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                dpkDateCheckIn.Value = DateTime.Now;

                return;
            }

            if (CreateContract(dpkDateCheckIn.Value, dpkDateCheckOut.Value, DateTime.Now))
            {
                MessageBox.Show("Tạo Hợp Đồng Thành Công", "Thông Báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                UpdateStatusPeople(idRoom);
            }
            else
            {
                MessageBox.Show("Tạo Hợp Đồng Không Thành Công", "Thông Báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnPrintContract_Click(object sender, EventArgs e)
        {
            string mssv = dataGridViewRoomContract.SelectedRows[0].Cells[0].Value.ToString();
            DateTime creatingTime = (DateTime)dataGridViewRoomContract.SelectedRows[0].Cells[6].Value;

            fPrintContract f = new fPrintContract(mssv, creatingTime);
            f.ShowDialog();
        }

        private void dpkDateCheckIn_onValueChanged(object sender, EventArgs e)
        {
            dpkDateCheckOut.Value = dpkDateCheckIn.Value.AddMonths(6);
        }
        
        #endregion
    }
}

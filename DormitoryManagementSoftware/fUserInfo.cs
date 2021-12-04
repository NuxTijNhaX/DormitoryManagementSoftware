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
using DormitoryManagementSoftware.DTO;

namespace DormitoryManagementSoftware
{
    public partial class fUserInfo : Form
    {
        private string Password;

        public fUserInfo(string userName)
        {
            InitializeComponent();
            LoadProfile(userName);
        }

        #region Methods

        public void LoadProfile(string username)
        {
            Account user = AccountDAO.Instance.LoadUserInforByUserName(username);

            txbUserName.Text = username;
            lblDisplayName.Text = txbDisplayName.Text = user.DisplayName;
            txbStaffType.Text = AccountTypeDAO.Instance.GetStaffTypeByUserName(username);

            lblDepartment.Text = "Ban " + txbStaffType.Text;

            txbIDCard.Text = user.IdCard;
            txbPhoneNumber.Text = user.PhoneNumber.ToString();
            txbAddress.Text = user.Address;
            dpkDateOfBirth.Value = user.DateOfBirth;
            cbSex.Text = user.Sex;
            txbStartDay.Text = user.StartDay.ToShortDateString();

            Password = user.PassWord;
        }

        public bool UpdateDisplayName(string username, string displayname)
        {
            return AccountDAO.Instance.UpdateDisplayName(username, displayname);
        }

        public bool UpdatePassword(string username, string newPass)
        {
            return AccountDAO.Instance.UpdatePassword(username, newPass);
        }

        #endregion


        #region Events

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveAccInfo_Click(object sender, EventArgs e)
        {
            if (txbDisplayName.Text != String.Empty)
            {
                if (UpdateDisplayName(txbUserName.Text, txbDisplayName.Text))
                {
                    MessageBox.Show("Cập Nhật Thông Tin Tài Khoản Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProfile(txbUserName.Text);
                }
                else
                {
                    MessageBox.Show("Cập Nhật Thông Tin Tài Khoản Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
                MessageBox.Show("Tên Hiển Thị Không Được Để Trống\nVui Lòng Nhập Lại", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSavePass_Click(object sender, EventArgs e)
        {
            if (txbPass.Text == String.Empty || txbNewPass.Text == String.Empty)
            {
                MessageBox.Show("Vui Lòng Điền Đầy Đủ Thông Tin", "Thông Báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (txbNewPass.Text != txbReNewPass.Text)
            {
                MessageBox.Show("Mật Khẩu Nhập Lại Không Trùng Khớp", "Thông Báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (txbPass.Text == Password)
            {
                UpdatePassword(txbUserName.Text, txbNewPass.Text);
                MessageBox.Show("Cập Nhật Mật Khẩu Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbPass.Text = txbNewPass.Text = txbReNewPass.Text = String.Empty;
                LoadProfile(txbUserName.Text);
            }
            else
            {
                MessageBox.Show("Mật Khẩu Không Hợp Lệ.\nVui Lòng Nhập Lại.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbPass.Text = txbNewPass.Text = txbReNewPass.Text = String.Empty;
            }
        }

        private void btnSaveUserInfo_Click(object sender, EventArgs e)
        {
            if (txbAddress.Text != String.Empty && txbPhoneNumber.Text != String.Empty && cbSex.Text != string.Empty && dpkDateOfBirth.Value < DateTime.Now.Date)
            {
                if (AccountDAO.Instance.CheckIdCard(txbIDCard.Text))
                {
                    if (AccountDAO.Instance.UpdateInforByIdCard(txbIDCard.Text, txbAddress.Text, txbPhoneNumber.Text,
                        dpkDateOfBirth.Value, cbSex.Text))
                    {
                        MessageBox.Show("Cập Nhật Thông Tin Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProfile(txbUserName.Text);
                    }
                    else
                    {
                        MessageBox.Show($"Cập Nhật Thông Tin Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
                MessageBox.Show("Thông Tin Không Được Để Trống\nVui Lòng Nhập Lại", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void txbDisplayName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txbIDCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        #endregion
    }
}

using DormitoryManagementSoftware.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DormitoryManagementSoftware
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
            txbUserName.Focus();
        }

        #region Methods

        private bool Login()
        {
            return AccountDAO.Instance.Login(txbUserName.Text, txbPassword.Text);
        }
        
        #endregion

        #region Events

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txbUserName.TextLength < 1 || txbPassword.TextLength < 1)
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Login())
            {
                Form fDM = new fDormitoryManagement(txbUserName.Text);
                this.Hide();
                fDM.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tài Khoản Hoặc Mật Khẩu Không Đúng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        #endregion

        private void txbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnLogin_Click(sender, null);
        }
    }
}

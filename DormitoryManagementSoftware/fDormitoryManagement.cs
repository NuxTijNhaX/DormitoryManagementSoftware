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
    public partial class fDormitoryManagement : Form
    {
        private string userName;
        public fDormitoryManagement(string userName)
        {
            this.userName = userName;
            InitializeComponent();
        }

        #region Methods

        public bool IsAdmin()
        {
            return true;
        }

        private bool CheckAccess(string nameform)
        {
            return true; //AccessDAO.Instance.CheckAccess(userName, nameform);
        }

        void AlertIllegalAccess()
        {
            MessageBox.Show("Bạn không quyền truy cập.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion

        private void btn(object sender, EventArgs e)
        {
            this.Hide();
            fLogin login = new fLogin();
            login.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        // Logout Button
        private void Logout()
        {
            this.Hide();
            fLogin login = new fLogin();
            login.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void btnIconLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void btnLblLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        // Open Introduction Form
        private void IntroDevTeam()
        {
            fIntroduction f = new fIntroduction();
            f.ShowDialog();
        }

        private void btnIntro_Click(object sender, EventArgs e)
        {
            IntroDevTeam();
        }

        private void btnLblIntro_Click(object sender, EventArgs e)
        {
            IntroDevTeam();
        }

        private void btnIconIntro_Click(object sender, EventArgs e)
        {
            IntroDevTeam();
        }

        // Open ManageUserInfo Form
        private void ManageUserInfo()
        {
            fUserInfo f = new fUserInfo(userName);
            f.ShowDialog();
        }

        private void btnManageUserInfo_Click(object sender, EventArgs e)
        {
            ManageUserInfo();
        }

        private void btnLblManageUserInfo_Click(object sender, EventArgs e)
        {
            ManageUserInfo();
        }

        private void btnIconManageUserInfo_Click(object sender, EventArgs e)
        {
            ManageUserInfo();
        }

        // Open ManageStudent Form
        private void ManageStudent()
        {
            fStudent f = new fStudent();
            f.ShowDialog();
        }

        private void btnManageStudent_Click(object sender, EventArgs e)
        {
            ManageStudent();
        }

        private void btnImgManageStudent_Click(object sender, EventArgs e)
        {
            ManageStudent();
        }

        // Open ManageStaff Form
        private void ManageStaff()
        {
            fStaff f = new fStaff();
            f.ShowDialog();
        }

        private void btnManageStaff_Click(object sender, EventArgs e)
        {
            ManageStaff();
        }

        private void btnImgManageStaff_Click(object sender, EventArgs e)
        {
            ManageStaff();
        }

        // Open ManageRoom Form
        private void ManageRoom()
        {
            fRoom f = new fRoom();
            f.ShowDialog();
        }

        private void btnManageRoom_Click(object sender, EventArgs e)
        {
            ManageRoom();
        }

        private void btnImgManageRoom_Click(object sender, EventArgs e)
        {
            ManageRoom();
        }

        // Open MakeContract Form
        private void btnMakeContract_Click(object sender, EventArgs e)
        {
            fRoomContract f = new fRoomContract(userName);
            f.ShowDialog();
        }

        // Open ManageRules Form
        private void btnImgManageRules_Click(object sender, EventArgs e)
        {
            fRules f = new fRules();
            f.ShowDialog();
        }

        // Open CreateReports Form
        private void btnImgCreateReports_Click(object sender, EventArgs e)
        {
            fReport f = new fReport();
            f.ShowDialog();
        }

        // Open ManageBills Form
        private void btnImgManageBills_Click(object sender, EventArgs e)
        {
            fBill f = new fBill();
            f.ShowDialog();
        }

        private void btnManageBills_Click(object sender, EventArgs e)
        {
            btnImgManageBills_Click(sender, e);
        }
    }
}

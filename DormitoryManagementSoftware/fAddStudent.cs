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
    public partial class fAddStudent : Form
    {
        public fAddStudent()
        {
            InitializeComponent();
        }

        #region Methods

        private void Clean()
        {
            txbFullName.Text = string.Empty;
            txbMSSV.Text = string.Empty;
            txbAddress.Text = string.Empty;
            txbIDCard.Text = string.Empty;
            txbPhoneNumber.Text = string.Empty;
        }

        private bool CheckDate()
        {
            if (DateTime.Now.Subtract(datepickerDateOfBirth.Value).Days <= 0)
                return false;

            return true;
        }

        // --Handle Input Typing--
        private void HandleNotANumber(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        public static bool CheckFillInText(Control[] controls)
        {
            foreach (var control in controls)
            {
                if (control.Text == string.Empty)
                    return false;
            }
            return true;
        }

        private Student CreateAStudent()
        {
            Student student = new Student();

            student.MSSV = txbMSSV.Text;
            student.IdCard = txbIDCard.Text;
            student.Name = txbFullName.Text;
            student.Sex = dropSex.Text;
            student.PhoneNumber = txbPhoneNumber.Text;
            student.DateOfBirth = datepickerDateOfBirth.Value;
            student.Address = txbAddress.Text;

            return student;
        }

        private void InsertStudent()
        {

            try
            {
                Student student = CreateAStudent();
                if (StudentDAO.Instance.InsertStudent(student))
                {
                    MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clean();
                }
                else
                    MessageBox.Show("Sinh Viên Đã Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch
            {
                MessageBox.Show("Lỗi Thêm Sinh Viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion


        #region Events

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (!CheckFillInText(new Control[] { txbMSSV, txbPhoneNumber, txbFullName, txbIDCard, txbAddress }))
            {
                MessageBox.Show("Vui Lòng Không Để Trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dropSex.SelectedIndex < 0)
            {
                MessageBox.Show("Vui Lòng Cho Biết Giới Tính", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn Có Muốn Thêm Sinh Viên Này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
                if (CheckDate())
                {
                    InsertStudent();
                }
                else
                    MessageBox.Show("Ngày Sinh Có Vấn Đề!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txbMSSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleNotANumber(e);
        }

        private void txbPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleNotANumber(e);
        }

        private void txbIDCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleNotANumber(e);
        }

        private void txbFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        // ----

        #endregion
    }
}

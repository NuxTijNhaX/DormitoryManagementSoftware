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
    public partial class fAddStaff : Form
    {
        public fAddStaff()
        {
            InitializeComponent();
            LoadFullStaffType();
            datePickerStartDay.Value = DateTime.Now;
            comboBoxSex.SelectedIndex = 1;
        }

        #region Methods

        // Load Staff Type
        private void LoadFullStaffType()
        {
            comboBoxSex.SelectedIndex = 0;
            DataTable table = GetFullStaffType();
            comboBoxStaffType.DataSource = table;
            comboBoxStaffType.DisplayMember = "NameType";

            if (table.Rows.Count > 0)
                comboBoxStaffType.SelectedIndex = 0;
        }

        private DataTable GetFullStaffType()
        {
            return AccountTypeDAO.Instance.LoadFullStaffType();
        }
        // ----

        private bool CheckDate()
        {
            if (!CheckTrueDate(datepickerDateOfBirth.Value, DateTime.Now))
            {
                MessageBox.Show("Ngày Sinh Không Hợp Lệ (Tuổi Phải Lớn Hơn 18)", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            if (!CheckTrueDate(datepickerDateOfBirth.Value, datePickerStartDay.Value))
            {
                MessageBox.Show("Ngày Vào Làm Không Hợp Lệ (Lớn Hơn 18 Tuổi)", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool CheckTrueDate(DateTime date1, DateTime date2)
        {
            if (date2.Subtract(date1).Days < 6574)
                return false;
            return true;
        }

        private void InsertStaff()
        {
            bool isFill = fStudent.CheckFillInText(new Control[] { txbName, comboBoxStaffType, txbName ,
                                                            txbIDcard , comboBoxSex , txbPhoneNumber, txbAddress});
            if (isFill)
            {
                try
                {
                    Account accountNow = GetStaffNow();

                    accountNow.PassWord = "123456";

                    if (AccountDAO.Instance.InsertAccount(accountNow))
                    {
                        MessageBox.Show("Thêm Thành Công\n Mật khẩu mặc đinh cho tài khoản " + txbName.Text +
                            " là: 123456", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Nhân Viên Đã Tồn Tại(Trùng tên đăng nhập hoặc Số CMND)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                catch
                {
                    MessageBox.Show("Lỗi Không xác định", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private Account GetStaffNow()
        {
            Account account = new Account();

            account.UserName = txbUserName.Text;
            int index = comboBoxStaffType.SelectedIndex;
            account.IdStaffType = (int)((DataTable)comboBoxStaffType.DataSource).Rows[index]["id"];
            account.DisplayName = txbName.Text;
            account.IdCard = txbIDcard.Text;
            account.Sex = comboBoxSex.Text;
            account.DateOfBirth = datepickerDateOfBirth.Value;
            account.PhoneNumber = txbPhoneNumber.Text;
            account.Address = txbAddress.Text;
            account.StartDay = datePickerStartDay.Value;

            return account;
        }

        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Có Muốn Thêm Nhân Viên Mới Không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            
            if (result == DialogResult.OK)
            {

                if (CheckDate())
                {
                    InsertStaff();
                }
            }
        }

        private void txbIDcard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txbUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) || char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}

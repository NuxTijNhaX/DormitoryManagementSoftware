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
using DormitoryManagementSoftware.DTO;

namespace DormitoryManagementSoftware
{
    public partial class fStaff : Form
    {
        public fStaff()
        {
            InitializeComponent();
            LoadFullStaffType();
            LoadFullStaff(GetFullStaff());
        }

        #region Methods

        // Load Data Lên Form
        private void LoadFullStaff(DataTable table)
        {
            BindingSource source = new BindingSource();
            source.DataSource = table;
            dataGridStaff.DataSource = source;
            bindingStaff.BindingSource = source;
        }

        private void LoadFullStaffType()
        {
            comboBoxSex.SelectedIndex = 0;
            DataTable table = GetFullStaffType();
            comboBoxStaffType.DataSource = table;
            comboBoxStaffType.DisplayMember = "NAMETYPE";
            if (table.Rows.Count > 0)
                comboBoxStaffType.SelectedIndex = 0;
        }
        // ----

        // Lấy Data Từ DAO
        private DataTable GetFullStaff()
        {
            return AccountDAO.Instance.LoadFullStaff();
        }

        private DataTable GetFullStaffType()
        {
            return AccountTypeDAO.Instance.LoadFullStaffType();
        }
        // ----


        private void ChangeText(DataGridViewRow row)
        {
            if (row.IsNewRow)
            {
                txbUserName.Text = string.Empty;
                txbName.Text = string.Empty;
                txbIDcard.Text = string.Empty;
                txbPhoneNumber.Text = string.Empty;
                txbAddress.Text = string.Empty;
            }
            else
            {
                txbUserName.Text = row.Cells["colUserName"].Value.ToString();
                txbAddress.Text = row.Cells["colAddress"].Value.ToString();
                txbName.Text = row.Cells["colName"].Value.ToString();
                txbPhoneNumber.Text = row.Cells["colPhone"].Value.ToString();
                txbIDcard.Text = row.Cells["colIDCard"].Value.ToString();
                datepickerDateOfBirth.Value = (DateTime)row.Cells["colDateOfBirth"].Value;
                datePickerStartDay.Value = (DateTime)row.Cells["colStartDay"].Value;
                comboBoxSex.Text = row.Cells["colSex"].Value.ToString();
                comboBoxStaffType.SelectedIndex = (int)row.Cells[colIDStaffType.Name].Value - 1;


                Account staff = new Account();
                staff.UserName = txbUserName.Text;
                staff.Address = txbAddress.Text;
                staff.DisplayName = txbName.Text;
                staff.PhoneNumber = txbPhoneNumber.Text;
                staff.IdCard = txbIDcard.Text;
                staff.DateOfBirth = datepickerDateOfBirth.Value;
                staff.StartDay = datePickerStartDay.Value;
                staff.Sex = comboBoxSex.Text;
                staff.IdStaffType = (int)row.Cells[colIDStaffType.Name].Value;

                groupStaff.Tag = staff;
                //bindingNavigatorMoveFirstItem.Enabled = true;
                //bindingNavigatorMovePreviousItem.Enabled = true;
            }
        }

        private void UpdateStaff()
        {
            bool isFill = fStudent.CheckFillInText(new Control[] { txbUserName, comboBoxStaffType, txbName ,
                                                            txbIDcard , comboBoxSex , txbPhoneNumber, txbAddress});
            if (!isFill)
            {
                MessageBox.Show("Không Được Để Trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Account accountPre = groupStaff.Tag as Account;
                
                try
                {
                    Account accountNow = GetStaffNow();

                    if (accountNow.Equals(accountPre))
                    {
                        MessageBox.Show("Bạn Chưa Thay Đổi Dữ Liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        bool check = AccountDAO.Instance.UpdateAccount(accountNow);
                        
                        if (check)
                        {
                            MessageBox.Show("Cập Nhật Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            groupStaff.Tag = accountNow;

                            if (btnCancel.Visible == false)
                            {
                                int index = dataGridStaff.SelectedRows[0].Index;
                                LoadFullStaff(GetFullStaff());
                                dataGridStaff.SelectedRows[0].Selected = false;
                                dataGridStaff.Rows[index].Selected = true;
                            }

                        }
                        else
                        {
                            //if (accountNow.UserName == accountPre.UserName)
                                MessageBox.Show("Cập Nhật Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //else
                                //MessageBox.Show("Không thể cập nhật(Tài khoản chưa tồn tại)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi Không Xác Định", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void Search()
        {
            // LoadFullStaff(GetSearchStaff());
        }

        private Account GetStaffNow()
        {
            Account account = new Account();

            account.UserName = txbUserName.Text.ToLower();
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

        //private DataTable GetSearchStaff()
        //{
        //    if (int.TryParse(txbSearch.Text, out int phoneNumber))
        //        return AccountDAO.Instance.Search(txbSearch.Text, phoneNumber);
        //    else
        //        return AccountDAO.Instance.Search(txbSearch.Text, -1);
        //}

        private bool CheckTrueDate(DateTime date1, DateTime date2)
        {
            if (date2.Subtract(date1).Days < 6574)
                return false;
            return true;
        }

        private bool CheckDate()
        {
            if (!CheckTrueDate(datepickerDateOfBirth.Value, DateTime.Now))
            {
                MessageBox.Show("Ngày sinh không hợp lệ (Tuổi phải lớn hơn 18)", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            if (!CheckTrueDate(datepickerDateOfBirth.Value, datePickerStartDay.Value))
            {
                MessageBox.Show("Ngày vào làm không hợp lệ (Lớn hơn 18 tuổi)", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        #endregion

        private void dataGridStaff_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridStaff.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridStaff.SelectedRows[0];
                ChangeText(row);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn cập nhật nhân viên này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                if (CheckDate())
                {
                    UpdateStaff();
                }
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            new fAddStaff().ShowDialog();

            LoadFullStaff(GetFullStaff());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Chức Năng Đang Được Bảo Trì\nVui Lòng Thông Cảm!", "Thông Báo", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            //txbSearch.Text = txbSearch.Text.Trim();
            //if (txbSearch.Text != string.Empty)
            //{
            //    txbUserName.Text = string.Empty;
            //    txbName.Text = string.Empty;
            //    txbIDcard.Text = string.Empty;
            //    txbPhoneNumber.Text = string.Empty;
            //    txbAddress.Text = string.Empty;

            //    btnSearch.Visible = false;
            //    btnCancel.Visible = true;
            //    Search();
            //}
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Chắc Chắn Muốn Xóa Nhân Viên Này?", "Thông Báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                bool check = AccountDAO.Instance.DeleteStaff(txbUserName.Text);
                if (check)
                {
                    MessageBox.Show($"Xóa Thành Công Nhân Viên Có Tên Đăng Nhập = {txbUserName.Text}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadFullStaff(GetFullStaff());
                }
                else
                {
                    MessageBox.Show("Xóa Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}

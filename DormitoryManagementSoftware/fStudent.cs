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
    public partial class fStudent : Form
    {
        public fStudent()
        {
            InitializeComponent();
            LoadFullStudent(GetFullStudent());
            cbxSearchBy.SelectedIndex = 0;
            dropSex.SelectedIndex = 0;
            dropID.DisplayMember = "id";
        }

        #region Methods

        // Load DataGridView
        private void LoadFullStudent(DataTable table)
        {
            BindingSource source = new BindingSource();
            source.DataSource = table;
            dataGridViewStudent.DataSource = source;
            bindingStudent.BindingSource = source;
            dropID.DataSource = source;
        }

        private DataTable GetFullStudent()
        {
            return StudentDAO.Instance.LoadFullStudent();
        }
        // -----

        // Check Empty Input
        public static bool CheckFillInText(Control[] controls)
        {
            foreach (var control in controls)
            {
                if (control.Text == string.Empty)
                    return false;
            }
            return true;
        }
        // ----

        // Check Validate DoB
        private bool CheckDate()
        {
            if (DateTime.Now.Subtract(datepickerDateOfBirth.Value).Days <= 0)
                return false;
            
            return true;
        }
        // ----

        // Handle NaN
        private void HandleNotANumber(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        // ----

        private DataTable GetSearchStudent(string @string, int mode)
        {
            return StudentDAO.Instance.Search(@string, mode);
        }

        private void Search()
        {
            string @string = txbSearch.Text;
            int mode = cbxSearchBy.SelectedIndex;
            LoadFullStudent(GetSearchStudent(@string, mode));
        }

        private void ChangeText(DataGridViewRow row)
        {
            if (row.IsNewRow)
            {
                txbMSSV.Text = string.Empty;
                txbFullName.Text = string.Empty;
                txbAddress.Text = string.Empty;
                txbIDCard.Text = string.Empty;
                txbPhoneNumber.Text = string.Empty;
                bindingNavigatorMoveFirstItem.Enabled = false;
                bindingNavigatorMovePreviousItem.Enabled = false;
            }
            else
            {
                bindingNavigatorMoveFirstItem.Enabled = true;
                bindingNavigatorMovePreviousItem.Enabled = true;
                txbFullName.Text = row.Cells["colNameStudent"].Value.ToString();
                txbAddress.Text = row.Cells["colAddress"].Value.ToString();
                txbIDCard.Text = row.Cells["colIDCard"].Value.ToString();
                txbMSSV.Text = row.Cells["colMSSV"].Value.ToString();
                txbPhoneNumber.Text = row.Cells["colPhone"].Value.ToString();
                dropSex.SelectedItem = row.Cells["colSex"].Value;
                datepickerDateOfBirth.Value = (DateTime)row.Cells["colDateOfBirth"].Value;

                Student student = new Student(((DataRowView)row.DataBoundItem).Row);
                groupStudent.Tag = student;
            }
        }

        private Student GetStudentNow()
        {
            Student student = new Student();

            student.Id = int.Parse(dropID.Text);
            student.MSSV = txbMSSV.Text;
            student.IdCard = txbIDCard.Text;
            student.Name = txbFullName.Text;
            student.Sex = dropSex.Text;
            student.PhoneNumber = txbPhoneNumber.Text;
            student.DateOfBirth = datepickerDateOfBirth.Value;
            student.Address = txbAddress.Text;

            return student;
        }

        private void UpdateStudent()
        {
            if (dropID.Text == string.Empty)
            {
                MessageBox.Show("Sinh Viên Không Tồn Tại, Không Thể Thay Đổi Thông Tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            if (!CheckFillInText(new Control[] { txbPhoneNumber, txbFullName, txbIDCard, txbMSSV, txbAddress }))
            {
                MessageBox.Show("Không Được Để Trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Student studentPre = groupStudent.Tag as Student;
                try
                {
                    Student studentNow = GetStudentNow();

                    if (studentNow.Equals(studentPre))
                        MessageBox.Show("Chưa Có Dữ Liệu Nào Được Thay Đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        bool check = StudentDAO.Instance.UpdateStudent(studentNow);
                        if (check)
                        {
                            MessageBox.Show("Cập Nhật Sinh Viên Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // groupStudent.Tag = studentNow;
                            int index = dataGridViewStudent.SelectedRows[0].Index;
                            LoadFullStudent(GetFullStudent());
                            dropID.SelectedIndex = index;
                        }
                        else
                            MessageBox.Show("Sinh Viên Này Đã Tồn Tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi Cập Nhật", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #region Events

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txbSearch.Text = txbSearch.Text.Trim();
            if (txbSearch.Text != string.Empty)
            {
                txbMSSV.Text = string.Empty;
                txbAddress.Text = string.Empty;
                txbFullName.Text = string.Empty;
                txbIDCard.Text = string.Empty;
                txbPhoneNumber.Text = string.Empty;

                btnSearch.Visible = false;
                btnCancel.Visible = true;
                Search();
            }
        }

        private void btnCloseFStudent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sinh Viên Này Sẽ Được Cập Nhật!", "Thông Báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
                if (CheckDate())
                {
                    UpdateStudent();
                    dropID.Focus();
                }
                else
                    MessageBox.Show("Ngày Sinh Có Vấn Đề", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void dataGridViewStudent_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewStudent.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewStudent.SelectedRows[0];
                ChangeText(row);
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            fAddStudent f = new fAddStudent();
            f.ShowDialog();

            LoadFullStudent(GetFullStudent());
        }

        private void txbMSSVPhoneNumberIdCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleNotANumber(e);
        }

        private void txbFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Chắc Chắn Muốn Xóa Sinh Viên Này?", "Thông Báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                bool check = StudentDAO.Instance.DeleteStudent(int.Parse(dropID.Text));
                if (check)
                {
                    MessageBox.Show($"Xóa Thành Công Sinh Viên Có Id = {dropID.Text}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    LoadFullStudent(GetFullStudent());
                }
                else
                {
                    MessageBox.Show("Xóa Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadFullStudent(GetFullStudent());

            btnCancel.Visible = false;
            btnSearch.Visible = true;
        }

        #endregion
    }
}

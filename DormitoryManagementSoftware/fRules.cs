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
    public partial class fRules : Form
    {
        public fRules()
        {
            InitializeComponent();
            LoadFullRules(GetFullRules());
        }

        private DataTable GetFullRules()
        {
            return RulesDAO.Instance.GetFullRules();
        }

        private void LoadFullRules(DataTable table)
        {
            BindingSource source = new BindingSource();
            source.DataSource = table;
            dataGridViewRules.DataSource = source;
            bindingSurcharge.BindingSource = source;
            cbxRuleName.DataSource = source;
            cbxRuleName.DisplayMember = "NAME";
        }

        private void ChangeText(DataGridViewRow row)
        {
            txbDescribe.Text = row.Cells[colDescribe.Name].Value.ToString();
            txbValue.Text = row.Cells[colValue.Name].Value.ToString();
        }

        private bool UpdateRules(string name, string value, string des)
        {
            return RulesDAO.Instance.UpdateRule(name, value, des);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txbValue.Text == String.Empty || txbDescribe.Text == String.Empty)
            {
                MessageBox.Show("Vui Lòng Không Để Trống Trường Thông Tin", "Thông Báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                
                return;
            }

            if (MessageBox.Show("Bạn Có Muốn Cập Nhật Quy Định Này?", "Thông Báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (UpdateRules(cbxRuleName.Text, txbValue.Text, txbDescribe.Text))
                {
                    MessageBox.Show("Cập Nhật Thành Công", "Thông Báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    
                    LoadFullRules(GetFullRules());
                }
                else
                {
                    MessageBox.Show("Cập Nhật Thất Bại", "Thông Báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewRules_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewRules.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewRules.SelectedRows[0];
                ChangeText(row);
            }
        }

        private void txbValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}

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
using DormitoryManagementSoftware.DTO;

namespace DormitoryManagementSoftware
{
    public partial class fRoom : Form
    {
        public fRoom()
        {
            InitializeComponent();
            LoadFullRoomType();
            LoadFullRoom(GetFullRoom());
            comboboxID.DisplayMember = "id";
        }

        #region Methods

        private void LoadFullRoom(DataTable table)
        {
            BindingSource source = new BindingSource();
            ChangePrice(table);
            source.DataSource = table;
            dataGridViewRoom.DataSource = source;
            bindingRoom.BindingSource = source;
            comboboxID.DataSource = source;
        }

        private void LoadFullRoomType()
        {
            DataTable table = GetFullRoomType();
            comboBoxRoomType.DataSource = table;
            comboBoxRoomType.DisplayMember = "Name";
            if (table.Rows.Count > 0)
                comboBoxRoomType.SelectedIndex = 0;

            // _fRoomtType = new fRoomType(table);
            // txbLimitPerson.DataBindings.Add(new Binding("Text", comboBoxRoomType.DataSource, "limitPerson"));
        }

        private DataTable GetFullRoom()
        {
            return RoomDAO.Instance.LoadFullRoom();
        }

        private DataTable GetFullRoomType()
        {
            return RoomTypeDAO.Instance.LoadFullRoomType();
        }

        /*
        private Room GetRoomNow()
        {
            Room room = new Room();
            if (comboboxID.Text == string.Empty)
                room.Id = 0;
            else
                room.Id = int.Parse(comboboxID.Text);
            fStaff.Trim(new Bunifu.Framework.UI.BunifuMetroTextbox[] { txbNameRoom });
            room.Name = txbNameRoom.Text;
            int index = comboBoxRoomType.SelectedIndex;
            room.IdRoomType = (int)((DataTable)comboBoxRoomType.DataSource).Rows[index]["id"];
            index = comboBoxStatusRoom.SelectedIndex;
            room.IdStatusRoom = (int)((DataTable)comboBoxStatusRoom.DataSource).Rows[index]["id"];
            return room;
        }

        private void UpdateRoom()
        {
            if (comboboxID.Text == string.Empty)
            {
                MessageBox.Show("Phòng này chưa tồn tại\n", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            if (!fStudent.CheckFillInText(new Control[] { txbNameRoom, comboBoxStatusRoom, comboBoxRoomType }))
            {
                MessageBox.Show("Không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Room roomPre = groupRoom.Tag as Room;
                try
                {
                    Room roomNow = GetRoomNow();
                    if (roomNow.Equals(roomPre))
                    {
                        MessageBox.Show("Bạn chưa thay đổi dữ liệu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        bool check = RoomDAO.Instance.UpdateCustomer(roomNow);
                        if (check)
                        {
                            MessageBox.Show("Cập Nhật Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            groupRoom.Tag = roomNow;
                            if (btnCancel.Visible == false)
                            {
                                int index = dataGridViewRoom.SelectedRows[0].Index;
                                LoadFullRoom(GetFullRoom());
                                comboboxID.SelectedIndex = index;
                            }
                            else BtnCancel_Click(null, null);
                        }
                        else
                            MessageBox.Show("Phòng này chưa tồn tại\n", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi cập nhật phòng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        */

        private void ChangeText(DataGridViewRow row)
        {
            if (row.IsNewRow)
            {
                txbNameRoom.Text = string.Empty;
                bindingNavigatorMoveFirstItem.Enabled = false;
                bindingNavigatorMovePreviousItem.Enabled = false;
            }
            else
            {
                bindingNavigatorMoveFirstItem.Enabled = true;
                bindingNavigatorMovePreviousItem.Enabled = true;
                txbNameRoom.Text = row.Cells["colName"].Value.ToString();
                comboBoxRoomType.SelectedIndex = (int)row.Cells["colIdRoomType"].Value - 1;
                // comboBoxStatusRoom.SelectedIndex = (int)row.Cells["colIdStatus"].Value - 1;
                Room room = new Room(((DataRowView)row.DataBoundItem).Row);
                groupRoom.Tag = room;

                txbStatusPeople.Text = row.Cells["colStatus"].Value.ToString();
                txbLimitPerson.Text = row.Cells["colLimitPerson"].Value.ToString();
                txbPrice.Text = row.Cells["colPrice"].Value.ToString();
            }
        }

        private void ChangePrice(DataTable table)
        {
            table.Columns.Add("price_New", typeof(string));
            for (int i = 0; i < table.Rows.Count; i++)
            {
                table.Rows[i]["price_New"] = ((int)table.Rows[i]["price"]).ToString("C0", CultureInfo.CreateSpecificCulture("vi-VN"));
            }
            table.Columns.Remove("price");
        }

        #endregion

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức Năng Đang Được Bảo Trì\nVui Lòng Thông Cảm!", "Thông Báo", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnRoomType_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức Năng Đang Được Bảo Trì\nVui Lòng Thông Cảm!", "Thông Báo", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức Năng Đang Được Bảo Trì\nVui Lòng Thông Cảm!", "Thông Báo", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức Năng Đang Được Bảo Trì\nVui Lòng Thông Cảm!", "Thông Báo", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void dataGridViewRoom_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewRoom.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewRoom.SelectedRows[0];
                ChangeText(row);
            }
        }
    }
}

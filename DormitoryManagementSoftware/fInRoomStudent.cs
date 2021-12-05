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
    public partial class fInRoomStudent : Form
    {
        private int idRoom;

        public fInRoomStudent(int idRoom)
        {
            this.idRoom = idRoom;
            InitializeComponent();
            LoadData(GetInRoomStudent());
        }

        private void LoadData(DataTable table)
        {
            dataGridViewInRoomStudent.DataSource = table;
        }

        private DataTable GetInRoomStudent()
        {
            return ContractDAO.Instance.LoadInRoomStudent(idRoom);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

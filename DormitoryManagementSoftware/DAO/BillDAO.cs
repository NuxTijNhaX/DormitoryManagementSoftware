using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryManagementSoftware.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BillDAO();
                }

                return instance;
            }

            set => instance = value;
        }

        private BillDAO() { }

        public bool CreateBill(int idBillType, int idRoom, int price, int month, DateTime creating)
        {
            string query = $"INSERT BILL (IDBILLTYPE, IDROOM, PRICE, FORMONTH, CREATING) VALUES ({idBillType}, {idRoom}, {price}, {month}, CAST(N'{creating}' AS DATE))";

            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public DataTable GetFullBill()
        {
            string query = "EXEC USP_LoadFullBill";

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool AddStudentPayBill(int idBill, int idStudent)
        {
            string query = $"UPDATE BILL SET IDSTUDENT = {idBill} WHERE ID = {idStudent};";

            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
    }
}

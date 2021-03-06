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
            string query = $"INSERT BILL (IDBILLTYPE, IDROOM, PRICE, FORMONTH, CREATING) VALUES ({idBillType}, {idRoom}, {price}, {month}, CAST(N'{creating}' AS DATE));";

            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public DataTable GetFullBill()
        {
            string query = "EXEC USP_LoadFullBill";

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool AddStudentPayBill(int idBill, int idStudent)
        {
            DateTime now = DateTime.Now;
            string query = $"UPDATE BILL SET IDSTUDENT = {idStudent}, STATUS = N'Đã Thanh Toán', PAYMENT = CAST(N'{now}' AS DATE) WHERE ID = {idBill};";

            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public DataTable GetBillByStatus(string status)
        {
            string query = "USP_LoadBillByStatus @status";

            return DataProvider.Instance.ExecuteQuery(query, new object[] { status });
        }

        public DataTable GetDataForReporting(string type, int month, int year)
        {
            string query = "USP_LoadBillByType @type , @month , @year";

            return DataProvider.Instance.ExecuteQuery(query, new object[] { type, month, year });
        }

        public int GetSumForReporting(string type, int month, int year)
        {
            string query = "USP_LoadSumByType @type , @month , @year";

            return int.Parse(DataProvider.Instance.ExecuteQuery(query, new object[] {type, month, year}).Rows[0][0]
                .ToString());
        }

        public DataRow GetBillById(int id)
        {
            string query = "USP_LoadBillById @id";

            return DataProvider.Instance.ExecuteQuery(query, new object[] {id}).Rows[0];
        }
    }
}

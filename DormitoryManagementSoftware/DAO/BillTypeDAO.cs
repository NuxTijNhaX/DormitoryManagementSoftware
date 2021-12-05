using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryManagementSoftware.DAO
{
    public class BillTypeDAO
    {
        private static BillTypeDAO instance;

        public static BillTypeDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BillTypeDAO();
                }

                return instance;
            }

            set => instance = value;
        }

        private BillTypeDAO() { }

        public DataTable LoadFullBillType()
        {
            string query = "SELECT * FROM BILLTYPE";

            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}

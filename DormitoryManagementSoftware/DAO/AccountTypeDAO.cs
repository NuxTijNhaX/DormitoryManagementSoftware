using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryManagementSoftware.DAO
{
    class AccountTypeDAO
    {
        private static AccountTypeDAO instance;

        public static AccountTypeDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AccountTypeDAO();
                }

                return instance;
            }

            private set => instance = value;
        }

        public DataTable LoadFullStaffType()
        {
            string query = "USP_LoadFullStaffType";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public string GetStaffTypeByUserName(string userName)
        {
            string query = "SELECT STAFFTYPE.NAMETYPE " +
                           "FROM STAFF, STAFFTYPE " +
                           "WHERE STAFF.IDSTAFFTYPE = STAFFTYPE.ID AND STAFF.USERNAME = '" + userName + "'; ";

            return DataProvider.Instance.ExecuteQuery(query).Rows[0]["NAMETYPE"].ToString();
        }
    }
}

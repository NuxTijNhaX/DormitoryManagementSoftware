using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryManagementSoftware.DAO
{
    public class RulesDAO
    {
        private static RulesDAO instance;

        public static RulesDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RulesDAO();
                }

                return instance;
            }

            set => instance = value;
        }

        private RulesDAO() { }

        public DataTable GetFullRules()
        {
            string query = "SELECT * FROM RULES";

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool UpdateRule(string name, string value, string des)
        {
            DateTime now = DateTime.Now;
            string query = "USP_UpdateRule @name , @value , @des , @date";

            return DataProvider.Instance.ExecuteNonQuery(query, new object[] {name, value, des, now}) > 0;
        }
    }
}

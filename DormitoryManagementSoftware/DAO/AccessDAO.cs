using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryManagementSoftware.DAO
{
    public class AccessDAO
    {
        private static AccessDAO instance;

        public static AccessDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AccessDAO();
                }

                return instance;
            }

            set => instance = value;
        }

        private AccessDAO() { }

        public bool CheckAccess(string userName, string nameForm)
        {
            string query = "SELECT * " +
            "FROM FORMACESS A, FORM B, STAFFTYPE C, STAFF D " +
            $"WHERE A.IDSTAFF = C.ID AND A.IDFORM = B.ID AND C.ID = D.IDSTAFFTYPE AND D.USERNAME = '{userName}' AND B.FORMNAME = '{nameForm}'; ";

            return DataProvider.Instance.ExecuteQuery(query).Rows.Count > 0;
        }
    }
}

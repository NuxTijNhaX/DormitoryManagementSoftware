using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryManagementSoftware.DAO
{
    public class ContractDAO
    {
        private static ContractDAO instance;

        public static ContractDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ContractDAO();
                }

                return instance;
            }

            set => instance = value;
        }

        ContractDAO() {}

        public bool CreateContract(int idRoom, int idStudent, string userName, DateTime start, DateTime end, DateTime creating)
        {
            string query = $"INSERT ROOMCONTRACT (IDROOM, IDSTUDENT, STAFFNAME, STARTTIME, ENDTIME, CREATINGTIME) VALUES ({idRoom}, {idStudent}, N'{userName}', CAST(N'{start}' AS DATE), CAST(N'{end}' AS DATE), CAST(N'{creating}' AS DATE));";

            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool UpdateStatusPeople(int idRoom)
        {
            string query = $"UPDATE ROOM SET STATUSPEOPLE = STATUSPEOPLE + 1 WHERE ID = {idRoom}";

            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public DataTable LoadContract()
        {
            string query = "USP_LoadContract";

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataRow LoadContractByMSSV(string mssv, DateTime creatingTime)
        {
            string query = "USP_LoadContractByMSSV @mssv , @creating";

            return DataProvider.Instance.ExecuteQuery(query, new object[] {mssv, creatingTime}).Rows[0];
        }

        public DataTable LoadInRoomStudent(int idRoom)
        {
            string query = $"SELECT B.MSSV, B.Name, B.PhoneNumber, B.Sex FROM ROOMCONTRACT A, STUDENT B WHERE A.IDSTUDENT = B.ID AND A.IDROOM = {idRoom};";

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable LoadInRoomStudentByRoomName(string roomName)
        {
            string query = $"SELECT B.Name FROM ROOMCONTRACT A, STUDENT B, ROOM C WHERE A.IDSTUDENT = B.ID AND A.IDROOM = C.ID AND C.NAME = N'{roomName}';";

            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}

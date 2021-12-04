using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DormitoryManagementSoftware.DTO;

namespace DormitoryManagementSoftware.DAO
{
    public class StudentDAO
    {
        private static StudentDAO instance;
        
        public static StudentDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StudentDAO();
                }

                return instance;
            }

            private set => instance = value;
        }

        private StudentDAO() { }

        public bool InsertStudent(string mssv, string idCard, string name, DateTime dateOfBirth, string address, string phoneNumber, string sex)
        {
            string query = "USP_InsertStudent @mssv , @idCard , @name , @dateOfBirth , @address , @phoneNumber , @sex";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { mssv, idCard, name, dateOfBirth, address, phoneNumber, sex }) > 0;
        }

        public bool InsertStudent(Student student)
        {
            return InsertStudent(student.MSSV, student.IdCard, student.Name, student.DateOfBirth, student.Address,
                student.PhoneNumber, student.Sex);
        }

        public bool UpdateStudent(string mssv, string idCard, string name, DateTime dateOfBirth, string address, string phoneNumber, string sex)
        {
            string query = "USP_UpdateStudent @id , @mssv , @name , @idCard , @dateOfBirth , @address , @phoneNumber , @sex";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { mssv, idCard, name, dateOfBirth, address, phoneNumber, sex}) > 0;
        }

        public bool UpdateStudent(Student stuNow)
        {
            string query = "USP_UpdateStudent @id , @mssv , @idCard , @name , @dateOfBirth , @address , " +
                           "@phoneNumber , @sex";
            object[] parameter = new object[] { stuNow.Id, stuNow.MSSV, stuNow.IdCard, stuNow.Name,
                 stuNow.DateOfBirth, stuNow.Address, stuNow.PhoneNumber, stuNow.Sex };
            return DataProvider.Instance.ExecuteNonQuery(query, parameter) > 0;
        }

        public bool DeleteStudent(int id)
        {
            string query = "USP_DeleteStudent @id";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id }) > 0;
        }

        public DataTable Search(string str, int mode)
        {
            string query = "USP_SearchStudent @string , @mode";
            
            return DataProvider.Instance.ExecuteQuery(query, new object[] {str, mode});
        }

        internal DataTable LoadFullStudent()
        {
            string query = "USP_LoadFullStudent";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool IsMSSVExisted(string mssv)
        {
            string query = "SELECT * FROM STUDENT WHERE MSSV = '" + mssv + "';";

            return DataProvider.Instance.ExecuteQuery(query).Rows.Count > 0;
        }

        public DataRow GetInfoByMSSV(string mssv)
        {
            string query = "SELECT * FROM STUDENT WHERE MSSV = '" + mssv + "';";

            return DataProvider.Instance.ExecuteQuery(query).Rows[0];
        }
    }
}

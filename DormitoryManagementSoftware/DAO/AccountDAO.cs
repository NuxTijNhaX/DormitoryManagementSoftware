using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DormitoryManagementSoftware.DTO;

namespace DormitoryManagementSoftware.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance {
            get 
            {
                if(instance == null)
                {
                    instance = new AccountDAO();
                }   
                
                return instance;
            }
            
            set => instance = value; 
        }

        private AccountDAO() { }

        public bool Login(string userName, string password)
        {
            string query = "USP_Login @USERNAME , @PASSWORD";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {userName, password});

            return result.Rows.Count > 0;
        }

        public DataTable LoadFullStaff()
        {
            string query = "USP_LoadFullStaff";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool UpdateAccount(Account account)
        {
            string query = "EXEC USP_UpdateStaff @user , @name , @idStaffType , @idCard , @dateOfBirth , @sex , @address , @phoneNumber , @startDay";
            
            object[] parameter = new object[] {account.UserName, account.DisplayName, account.IdStaffType,
                account.IdCard, account.DateOfBirth, account.Sex,
                account.Address, account.PhoneNumber.ToString(), account.StartDay};

            return DataProvider.Instance.ExecuteNonQuery(query, parameter) > 0;
        }

        public bool InsertAccount(Account account)
        {
            string query = "EXEC USP_InsertStaff @user , @name , @pass , @idStaffType , @idCard , @dateOfBirth , @sex , @address , @phoneNumber , @startDay";
            
            object[] parameter = new object[] {account.UserName, account.DisplayName, account.PassWord, account.IdStaffType,
                account.IdCard, account.DateOfBirth, account.Sex,
                account.Address, account.PhoneNumber.ToString(), account.StartDay};

            return DataProvider.Instance.ExecuteNonQuery(query, parameter) > 0;
        }

        public bool DeleteStaff(string userName)
        {
            string query = "DELETE FROM STAFF WHERE USERNAME = '" + userName + "' ;";

            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public Account LoadUserInforByUserName(string userName)
        {
            string query = "SELECT * FROM STAFF WHERE USERNAME = '" + userName +"';";

            DataRow row = DataProvider.Instance.ExecuteQuery(query).Rows[0];

            Account userInfor = new Account(row);

            return userInfor;
        }

        public bool UpdateDisplayName(string userName, string displayName)
        {
            string query = "UPDATE STAFF SET NAME = N'" + displayName + "' WHERE USERNAME = '" + userName + "';";

            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool UpdatePassword(string userName, string newPass)
        {
            
            string query = "UPDATE STAFF SET PASSWORD = N'" + newPass + "' WHERE USERNAME = '" + userName + "';";

            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool CheckIdCard(string idCard)
        {
            string query = "SELECT * FROM STAFF WHERE IDCARD = '" + idCard + "';";

            return DataProvider.Instance.ExecuteQuery(query).Rows.Count > 0;
        }

        public bool UpdateInforByIdCard(string idCard, string address, string phoneNumber, DateTime doB, string sex)
        {
            string query = $"UPDATE STAFF SET ADDRESS = '{address}', PHONENUMBER = '{phoneNumber}', DATEOFBIRTH = CAST(N'{doB}' AS DATE), SEX = '{sex}' WHERE IDCARD = '{idCard}'";

            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
    }
}

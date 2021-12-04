using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryManagementSoftware.DTO
{
    public class Account
    {

        private string userName;
        private string displayName;
        private string passWord;
        private int idStaffType;
        private string idCard;
        private DateTime dateOfBirth;
        private string sex;
        private string address;
        private string phoneNumber;
        private DateTime startDay;

        public string UserName { get => userName; set => userName = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public int IdStaffType { get => idStaffType; set => idStaffType = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Sex { get => sex; set => sex = value; }
        public string Address { get => address; set => address = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public DateTime StartDay { get => startDay; set => startDay = value; }
        public string IdCard { get => idCard; set => idCard = value; }

        public Account() { }

        public Account(string userName, string displayName, string passWord, int staffType, string idCard, DateTime dateOfBirth, string sex, string address, string phoneNumber, DateTime startDay)
        {
            this.UserName = userName;
            this.DisplayName = displayName;
            this.PassWord = passWord;
            this.IdStaffType = staffType;
            this.DateOfBirth = dateOfBirth;
            this.Sex = sex;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.StartDay = startDay;
            this.IdCard = idCard;
        }

        public Account(DataRow row)
        {
            this.UserName = row["UserName"].ToString();
            this.DisplayName = row["Name"].ToString();
            this.idStaffType = (int)row["IDStaffType"];
            this.DateOfBirth = (DateTime)row["DateOfBirth"];
            this.Sex = row["Sex"].ToString();
            this.Address = row["Address"].ToString();
            this.PhoneNumber = row["PhoneNumber"].ToString();
            this.StartDay = (DateTime)row["StartDay"];
            this.IdCard = (string)row["idCard"];
            this.PassWord = row["PassWord"].ToString();

        }


        public bool Equals(Account accountPre)
        {
            if (accountPre == null)
                return false;

            if (userName != accountPre.userName) return false;
            if (displayName != accountPre.displayName) return false;
            if (idStaffType != accountPre.idStaffType) return false;
            if (idCard != accountPre.idCard) return false;
            if (dateOfBirth != accountPre.dateOfBirth) return false;
            if (sex != accountPre.sex) return false;
            if (phoneNumber != accountPre.phoneNumber) return false;
            if (address != accountPre.address) return false;
            if (startDay != accountPre.startDay) return false;

            return true;
        }
    }
}

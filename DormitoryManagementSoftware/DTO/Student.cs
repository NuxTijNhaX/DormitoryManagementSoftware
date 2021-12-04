using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryManagementSoftware.DTO
{
    public class Student
    {
        private int id;
        private string mssv;
        private string idCard;
        private string name;
        private DateTime dateOfBirth;
        private string address;
        private string phoneNumber;
        private string sex;

        public Student() { }

        public Student(int id, string mssv, string idCard, string name, DateTime dateOfBirth, string address, string phoneNumber, string sex)
        {
            
            this.MSSV = mssv;
            this.IdCard = idCard;
            this.Name = name;
            this.DateOfBirth = dateOfBirth;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.Sex = sex;
        }

        public Student(DataRow row)
        {
            this.Id = (int) row["id"];
            this.MSSV = row["mssv"].ToString();
            this.IdCard = row["idcard"].ToString();
            this.Name = row["Name"].ToString();
            this.DateOfBirth = (DateTime)row["DateOfBirth"];
            this.Address = row["address"].ToString();
            this.PhoneNumber = row["phoneNumber"].ToString();
            this.Sex = row["sex"].ToString();
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as Student);
        }

        public bool Equals(Student studentPre)
        {
            if (studentPre == null)
                return false;

            if (this.id != studentPre.id) return false;
            if (this.mssv != studentPre.mssv) return false;
            if (this.idCard != studentPre.idCard) return false;
            if (this.Name != studentPre.Name) return false;
            if (this.dateOfBirth != studentPre.dateOfBirth) return false;
            if (this.address != studentPre.address) return false;
            if (this.phoneNumber != studentPre.phoneNumber) return false;
            if (this.sex != studentPre.sex) return false;
            
            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public int Id { get => id; set => id = value; }
        public string MSSV { get => mssv; set => mssv = value; }
        public string IdCard { get => idCard; set => idCard = value; }
        public string Name { get => name; set => name = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Address { get => address; set => address = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Sex { get => sex; set => sex = value; }
    }
}

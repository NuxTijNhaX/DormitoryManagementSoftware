using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryManagementSoftware.DAO
{
    class RoomTypeDAO
    {
        private static RoomTypeDAO instance;

        public static RoomTypeDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RoomTypeDAO();
                }

                return instance;
            }

            private set => instance = value;
        }

        private RoomTypeDAO() { }

        public DataTable LoadFullRoomType()
        {
            string query = "SELECT * FROM ROOMTYPE";

            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}

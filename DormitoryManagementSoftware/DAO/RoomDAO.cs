using DormitoryManagementSoftware.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryManagementSoftware.DAO
{
    public class RoomDAO
    {
        private static RoomDAO instance;

        public static RoomDAO Instance { 
            get {
                if(instance == null)
                {
                    instance = new RoomDAO();
                }

                return instance;
            }

            private set => instance = value; 
        }

        private RoomDAO() { }

        public DataTable LoadFullRoom()
        {
            string query = "SELECT Room.ID, Room.Name, RoomType.Name AS [nameRoomType], Price, LimitPerson, IDRoomType, STATUSPEOPLE FROM ROOM INNER JOIN dbo.RoomType ON roomtype.id = room.IDRoomType";

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable LoadNameRoomByRoomType(int value)
        {
            string query = "SELECT Room.ID, Room.Name, RoomType.Price, RoomType.LIMITPERSON, Room.STATUSPEOPLE " +
                           "FROM Room, ROOMTYPE " +
                           "WHERE Room.IDROOMTYPE = RoomType.ID AND RoomType.ID = " + value + ";";

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataRow LoadSpecRoomByNameRoom(string nameRoom)
        {
            string query = "SELECT Room.ID, Room.Name, RoomType.Price, RoomType.LIMITPERSON, Room.STATUSPEOPLE " +
                           "FROM Room, ROOMTYPE " +
                           "WHERE Room.IDROOMTYPE = RoomType.ID AND Room.Name = '" + nameRoom + "';";

            return DataProvider.Instance.ExecuteQuery(query).Rows[0];
        }

        public string GetIdByNameRoom(string nameRoom)
        {
            string query = $"SELECT ID FROM ROOM WHERE NAME = N'{nameRoom}';";

            return DataProvider.Instance.ExecuteQuery(query).Rows[0][0].ToString();
        }

        public DataTable GetSearchRoomByName(string name)
        {
            string query = "USP_SearchRoomByName @string";

            return DataProvider.Instance.ExecuteQuery(query, new object[] { name });
        }
    }
}

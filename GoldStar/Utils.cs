using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldStar
{
    class Utils
    {
        public static int BookingID = 0;
        /**
        Returns the current id of the logged in user
        **/
        public static string GetUserID() {
            var con = new Connection();
            var queryCredentials = $"SELECT id FROM user WHERE status = 'online'";
            var id = con.ReadString(queryCredentials);
            return id;
        }

        /**
        Returns the role of the signed in user
        */
        public static string GetUserRole()
        {
            var con = new Connection();
            var queryCredentials = $"SELECT role FROM user WHERE status = 'online'";
            var role = con.ReadString(queryCredentials);
            return role;
        }

        /**
        Returns the value of the column in the table where the id of the user matches
        */
        public static String GetField(String table, String column, String where)
        {
            var con = new Connection();
            var query = $"SELECT {column} FROM {table} WHERE {where}";
            var result = con.ReadString(query);
            return result;
        }

        public static String FormatDateTime(DateTime time) => $"{time.Year}/{time.Month}/{time.Day}";

        public static bool IsRoomBooked(String roomNumber, String startDate, String endDate)
        {
            var con = new Connection();
            var query = $"SELECT * FROM booking WHERE start_date BETWEEN '{startDate}' AND '{endDate}' OR end_date BETWEEN {startDate} AND {endDate} LIMIT 1";
            var result = con.ReadString(query);

            if (string.IsNullOrEmpty(result))
            {
                return false;
            }

            return true;
        }

        public static String GetServiceId(String serviceType, Connection conn)
        {
            var serviceID = conn.ReadString($"SELECT id FROM services WHERE type = '{serviceType}'");
            return serviceID;
        }

        public static int GetRoomPrice(String roomNo)
        {
            var con = new Connection();
            var result = con.ReadString($"SELECT cost FROM room WHERE id = '{roomNo}'");
            return int.Parse(result);
        }

        public static int GetServicePrice(String id)
        {
            var con = new Connection();
            var result = con.ReadString($"SELECT cost FROM services WHERE id = {id}");
            return int.Parse(result);
        }
    }
}

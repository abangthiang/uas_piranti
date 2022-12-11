using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_Kelompok5.Connection
{
    public class UserConnection
    {
        DBConnect objConn = new DBConnect();
        private MySqlConnection connection;

        public UserConnection()
        {
            connection = objConn.connection;
        }

        public DataTable getDataUserForReport()
        {
            string query = "select username, password from tbl_user order by username asc";
            if (objConn.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter returnVal = new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable("CharacterInfo");
                returnVal.Fill(dt);
                objConn.CloseConnection();
                return dt;
            }
            else
            {
                return null;
            }
        }

        public bool validateUserLogin(string username, string password)
        {
            string sql = "select * from tbl_user where username = '" + username + "' and password = '" + password + "'";
            if (objConn.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataAdapter returnVal = new MySqlDataAdapter(sql, connection);
                DataTable dt = new DataTable("CharacterInfo");
                returnVal.Fill(dt);
                objConn.CloseConnection();
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}

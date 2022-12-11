using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAS_Kelompok5.Model;
using System.Windows.Forms;

namespace UAS_Kelompok5.Connection
{
    public class CustomerConnection
    {
        DBConnect objconn = new DBConnect();
        private MySqlConnection connection;

        public CustomerConnection()
        {
            connection = objconn.connection;
        }

        public DataTable getCustomerName()
        {
            string query = "select nama from tbl_customer";
            if (objconn.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter returnVal = new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable("CharacterInfo");
                returnVal.Fill(dt);
                objconn.CloseConnection();
                return dt;
            }
            else
            {
                return null;
            }
        }

        public DataTable getDataCustomer()
        {
            string query = "select * from tbl_customer";
            if (objconn.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter returnVal = new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable("CharacterInfo");
                returnVal.Fill(dt);
                objconn.CloseConnection();
                return dt;
            }
            else
            {
                return null;
            }
        }

        public bool updateCustomer(CustomerModel obj)
        {
            string tanggal = obj.TglLahir.Year + "-" + obj.TglLahir.Month + "-" + obj.TglLahir.Day;
            string sql = "update tbl_customer set nama='" + obj.Nama + "', tgl_lahir='" + tanggal + "', no_hp='" + obj.NoHP + "', jenis_kelamin='" + obj.JenisKelamin + "', membership='" + obj.Membership + "', alamat='" + obj.Alamat + "', tempat_lahir='" + obj.TempatLahir + "' where id_customer=" + obj.IdCustomer;
            connection.Open();
            try
            {
                MySqlCommand cm = new MySqlCommand(sql, connection);
                cm.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Query");
                return false;
            }
            finally
            {
                //menutup koneksi
                connection.Close();
            }
        }

        public bool deleteDataCustomer(int id)
        {
            string sql = "delete from tbl_customer where id_customer=" + id;
            connection.Open();
            try
            {
                MySqlCommand cm = new MySqlCommand(sql, connection);
                cm.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Query");
                return false;
            }
            finally
            {
                //menutup koneksi
                connection.Close();
            }
        }

        public bool insertDataCustomer(CustomerModel obj)
        {
            string tanggal = obj.TglLahir.Year + "-" + obj.TglLahir.Month + "-" + obj.TglLahir.Day;
            string sql = "insert into tbl_customer(nama, tgl_lahir, no_hp, jenis_kelamin, membership, alamat, tempat_lahir) values ('" + obj.Nama + "','" + tanggal + "', '" + obj.NoHP + "','" + obj.JenisKelamin + "', '" + obj.Membership + "', '" + obj.Alamat + "', '" + obj.TempatLahir + "' )";
            connection.Open();
            try
            {
                MySqlCommand cm = new MySqlCommand(sql, connection);
                cm.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Query");
                return false;
            }
            finally
            {
                //menutup koneksi
                connection.Close();
            }
        }
    }
}

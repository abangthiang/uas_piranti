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
    public class BarangConnection
    {
        DBConnect objconn = new DBConnect();
        private MySqlConnection connection;

        public BarangConnection()
        {
            connection = objconn.connection;
        }

        public DataTable getNamaBarang()
        {
            string query = "select nama_barang from tbl_barang";
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

        public DataTable getDataBarangForReport()
        {
            string query = "select nama_barang as 'NamaBarang', kode_barang as 'KodeBarang', harga, stok from tbl_barang order by nama_barang asc";
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

        public DataTable getDataBarang()
        {
            string query = "select * from tbl_barang";
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

        public bool updateStock(BarangModel obj)
        {
            string sql = "update tbl_barang set stok='" + obj.Stok + "' where id_barang=" + obj.Id_barang;
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

        public bool updateBarang(BarangModel obj)
        {
            string sql = "update tbl_barang set nama_barang='" + obj.NamaBarang + "', kode_barang='" + obj.KodeBarang + "', harga='" + obj.Harga + "', stok='" + obj.Stok + "' where id_barang=" + obj.Id_barang;
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

        public bool deleteDataBarang(int id)
        {
            string sql = "delete from tbl_barang where id_barang=" + id;
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

        public bool insertDataBarang(BarangModel obj)
        {
            string sql = "insert into tbl_barang(nama_barang, kode_barang, harga, stok) values ('" + obj.NamaBarang + "','" + obj.KodeBarang + "', '" + obj.Harga + "','" + obj.Stok + "')";
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

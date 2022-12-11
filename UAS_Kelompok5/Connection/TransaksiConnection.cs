using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UAS_Kelompok5.Model;

namespace UAS_Kelompok5.Connection
{
    public class TransaksiConnection
    {
        DBConnect objconn = new DBConnect();
        private MySqlConnection connection;

        public TransaksiConnection()
        {
            connection = objconn.connection;
        }

        public DataTable getDataTransaksiForReport()
        {
            string query = "select tanggal, id_pelanggan as 'idPelanggan', nama_pelanggan as 'namaPelanggan', total_transaksi as 'totalTransaksi', pembayaran  from tbl_transaksi order by nama_pelanggan asc";
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

        public DataTable getDataTransaksi()
        {
            string query = "select * from tbl_transaksi";
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

        public bool insertDataTransaksi(TransaksiModel obj)
        {
            string tanggal = obj.Tgl.Year + "-" + obj.Tgl.Month + "-" + obj.Tgl.Day;
            string sql = "insert into tbl_transaksi(tanggal, id_pelanggan, nama_pelanggan, total_transaksi, pembayaran) values ('" + tanggal + "','" + obj.IdPelanggan + "', '" + obj.NamaPelanggan + "','" + obj.TotalTransaksi + "', '" + obj.Pembayaran + "' )";
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

        public bool deleteDataTransaksi(int id)
        {
            string sql = "delete from tbl_transaksi where id_transaksi=" + id;
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

        public bool updateTransaksi(TransaksiModel obj)
        {
            string sql = "update tbl_transaksi set nama_pelanggan='" + obj.NamaPelanggan + "' where id_transaksi=" + obj.IdTransaksi;
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

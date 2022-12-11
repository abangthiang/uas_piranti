using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_Kelompok5.Model
{
    public class TransaksiModel
    {
        int idTransaksi, idPelanggan;
        DateTime tgl;
        string namaPelanggan, totalTransaksi, pembayaran;

        public TransaksiModel()
        {
        }

        public int IdTransaksi { get => idTransaksi; set => idTransaksi = value; }
        public int IdPelanggan { get => idPelanggan; set => idPelanggan = value; }
        public string NamaPelanggan { get => namaPelanggan; set => namaPelanggan = value; }
        public string TotalTransaksi { get => totalTransaksi; set => totalTransaksi = value; }
        public DateTime Tgl { get => tgl; set => tgl = value; }
        public string Pembayaran { get => pembayaran; set => pembayaran = value; }
    }
}

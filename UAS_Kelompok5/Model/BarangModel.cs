using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_Kelompok5.Model
{
    public class BarangModel
    {
        string namaBarang, harga;
        int kodeBarang, stok, id_barang;

        public BarangModel()
        {
        }

        public string NamaBarang { get => namaBarang; set => namaBarang = value; }
        public string Harga { get => harga; set => harga = value; }
        public int KodeBarang { get => kodeBarang; set => kodeBarang = value; }
        public int Stok { get => stok; set => stok = value; }
        public int Id_barang { get => id_barang; set => id_barang = value; }
    }
}

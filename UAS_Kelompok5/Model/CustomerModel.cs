using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_Kelompok5.Model
{
    public class CustomerModel
    {
        int idCustomer;
        string nama, alamat, tempatLahir, noHP;
        DateTime tglLahir;
        string jenisKelamin, membership;

        public CustomerModel()
        {
        }

        public string Nama { get => nama; set => nama = value; }
        public string NoHP { get => noHP; set => noHP = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public string TempatLahir { get => tempatLahir; set => tempatLahir = value; }
        public DateTime TglLahir { get => tglLahir; set => tglLahir = value; }
        public string JenisKelamin { get => jenisKelamin; set => jenisKelamin = value; }
        public string Membership { get => membership; set => membership = value; }
        public int IdCustomer { get => idCustomer; set => idCustomer = value; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UAS_Kelompok5.Report;
using UAS_Kelompok5.Connection;

namespace UAS_Kelompok5.GUI
{
    public partial class Rekapitulasi : Form
    {
        BarangConnection bc = new BarangConnection();
        UserConnection uc = new UserConnection();
        TransaksiConnection tc = new TransaksiConnection();
        public Rekapitulasi()
        {
            InitializeComponent();
        }

        private void btnBarang_Click(object sender, EventArgs e)
        {
            BarangDS bds = new BarangDS();
            DataTable dt = bc.getDataBarangForReport();

            BarangReport pr = new BarangReport();
            pr.SetDataSource(dt);
            crvRekap.ReportSource = pr;
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            PenggunaDS pds = new PenggunaDS();
            DataTable dt = uc.getDataUserForReport();

            PenggunaReport pr = new PenggunaReport();
            pr.SetDataSource(dt);
            crvRekap.ReportSource = pr;
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            TransaksiDS tds = new TransaksiDS();
            DataTable dt = tc.getDataTransaksiForReport();

            TransaksiReport tr = new TransaksiReport();
            tr.SetDataSource(dt);
            crvRekap.ReportSource = tr;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAS_Kelompok5.GUI
{
    public partial class HalamanDepan : Form
    {
        Customer customerForm = new Customer();
        KelolaBarang kelolaBarangForm = new KelolaBarang();
        Transaksi transaksiForm = new Transaksi();
        Rekapitulasi rekapitulasiForm = new Rekapitulasi();

        public HalamanDepan()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Hide();
            }

            customerForm.MdiParent = this;
            customerForm.Dock = DockStyle.Fill;
            customerForm.Show();
        }

        private void kelolaBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Hide();
            }

            kelolaBarangForm.MdiParent = this;
            kelolaBarangForm.Dock = DockStyle.Fill;
            kelolaBarangForm.Show();
        }

        private void transaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Hide();
            }

            transaksiForm.MdiParent = this;
            transaksiForm.Dock = DockStyle.Fill;
            transaksiForm.Show();
        }

        private void rekapitulasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Hide();
            }

            rekapitulasiForm.MdiParent = this;
            rekapitulasiForm.Dock = DockStyle.Fill;
            rekapitulasiForm.Show();
        }
    }
}

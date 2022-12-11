using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UAS_Kelompok5.Connection;
using UAS_Kelompok5.Model;
using System.Diagnostics;
using CrystalDecisions.Shared;
using System.Web.Security;
using System.Reflection;

namespace UAS_Kelompok5.GUI
{
    public partial class Transaksi : Form
    {
        CustomerConnection cc = new CustomerConnection();
        BarangConnection bc = new BarangConnection();
        TransaksiConnection tc = new TransaksiConnection();
        KelolaBarang barang = new KelolaBarang();
        Customer customer = new Customer();
        int barangIdx = 0;
        int brgId = 0;
        int customerIdx = 0;
        int index = 0;
        int idx = 0;
        int id = 0;
        int subTotal = 0;
        int total = 0;
        int idCust = 0;
        double diskon = 0;
        int jlhBrg = 0;
        int stok = 0;

        public Transaksi()
        {
            InitializeComponent();
        }

        private TransaksiModel populateTransaksi()
        {
            TransaksiModel t = new TransaksiModel();
            t.Tgl = DateTime.Now;
            t.IdPelanggan = idCust;
            t.NamaPelanggan = cbNama.Text;
            t.TotalTransaksi = lblTotal.Text;
            t.Pembayaran = cbPembayaran.Text;
            return t;
        }

        private BarangModel stoks()
        {
            BarangModel t = new BarangModel();
            t.Stok = stok;
            return t;
        }

        private void fillDataGrid()
        {
            dgvTransaksi.DataSource = tc.getDataTransaksi();
        }

        private void Pilih(DataGridViewCellEventArgs e)
        {
            idx = e.RowIndex;
            if (idx >= 0)
            {
                try
                {
                    id = Convert.ToInt32(dgvTransaksi.Rows[idx].Cells[0].Value.ToString());
                    cbNama.Text = dgvTransaksi.Rows[idx].Cells[3].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Transaksi_Load(object sender, EventArgs e)
        {
            fillDataGrid();
        }

        private void cbNama_Click(object sender, EventArgs e)
        {
            cbNama.ValueMember = "id_customer";
            cbNama.DisplayMember = "nama";
            cbNama.DataSource = cc.getCustomerName();
        }

        private void cbBarang_Click(object sender, EventArgs e)
        {
            cbBarang.ValueMember = "id_barang";
            cbBarang.DisplayMember = "nama_barang";
            cbBarang.DataSource = bc.getNamaBarang();
        }

        private void cbBarang_TextChanged(object sender, EventArgs e)
        {
            nudQty.Value = 0;
            barang.dgvKelolaBarang.DataSource = bc.getDataBarang();
            nudQty.Maximum = Convert.ToInt32(barang.dgvKelolaBarang.Rows[barangIdx].Cells[4].Value.ToString());
            barangIdx = cbBarang.SelectedIndex;
            brgId = Convert.ToInt32(barang.dgvKelolaBarang.Rows[barangIdx].Cells[0].Value.ToString());
            Debug.WriteLine(nudQty.Maximum);
        }

        private void cbNama_TextChanged(object sender, EventArgs e)
        {
            customerIdx = cbNama.SelectedIndex;
            panelBarang.Visible = true;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            subTotal = 0;
            total = 0;
            diskon = 0;

            if (nudQty.Value.ToString().CompareTo("0") == 0)
            {
                //do nothing
            }
            else
            { 
            barang.dgvKelolaBarang.DataSource = bc.getDataBarang();
            DataGridViewRow row = (DataGridViewRow)dgvBarang.Rows[0].Clone();
            row.Cells[0].Value = barang.dgvKelolaBarang.Rows[barangIdx].Cells[2].Value.ToString();
            row.Cells[1].Value = barang.dgvKelolaBarang.Rows[barangIdx].Cells[1].Value.ToString();
            row.Cells[2].Value = nudQty.Value.ToString();
            int harga  = Convert.ToInt32(barang.dgvKelolaBarang.Rows[barangIdx].Cells[3].Value.ToString());
            row.Cells[3].Value = harga * nudQty.Value;
            dgvBarang.Rows.Add(row);


            for (int i = 0; i < dgvBarang.Rows.Count; i++)
            {
                if (dgvBarang.Rows[i].Cells[3].Value != null)
                {
                    subTotal = int.Parse(dgvBarang.Rows[i].Cells[3].Value.ToString()) + subTotal;
                }
            }

            customer.dgvCustomer.DataSource = cc.getDataCustomer();
            int now = (int)DateTime.Now.Day;
            int seminggu = DateTime.Now.AddDays(7).Day;
            int birthDate = DateTime.Parse(customer.dgvCustomer.Rows[customerIdx].Cells[3].Value.ToString()).Day;
            idCust = Convert.ToInt32(customer.dgvCustomer.Rows[customerIdx].Cells[0].Value.ToString());

            if (birthDate >= now && birthDate <= seminggu)
            {
                if (customer.dgvCustomer.Rows[customerIdx].Cells[5].Value.ToString() == "Regular")
                {
                    diskon = ((double)5 / 100) * subTotal;
                }

                else
                {
                    diskon = ((double)10 / 100) * subTotal;
                }
            }

            lblSub.Text =  "Rp. " + subTotal.ToString();
            lblDisc.Text = "Rp. " + diskon.ToString();
            total = subTotal - (int)diskon;
            lblTotal.Text = "Rp. " + total.ToString();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Kamu Mau Hapus Data ?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                index = dgvBarang.CurrentCell.RowIndex;
                dgvBarang.Rows.RemoveAt(index);
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Kamu Mau Simpan Data ?", "Simpan Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                if (tc.insertDataTransaksi(populateTransaksi()))
                {
                    MessageBox.Show("sukses input data transaksi");
                    for (int i = 0; i < dgvBarang.Rows.Count; i++)
                    {
                        if (dgvBarang.Rows[i].Cells[3].Value != null)
                        {
                            jlhBrg = Convert.ToInt32(dgvBarang.Rows[i].Cells[2].Value.ToString()) + jlhBrg;
                        }
                    }

                    stok = Convert.ToInt32(barang.dgvKelolaBarang.Rows[barangIdx].Cells[4].Value.ToString()) - jlhBrg;

                    if (brgId > 0)
                    {
                        BarangModel obj = stoks();
                        obj.Id_barang = brgId;
                        Debug.WriteLine(obj.Id_barang);
                        bc.updateStock(obj);
                    }
                    fillDataGrid();
                    subTotal = 0;
                    total = 0;
                    diskon = 0;
                    jlhBrg = 0;
                    stok = 0;
                    lblSub.Text = "Rp. " + subTotal.ToString();
                    lblDisc.Text = "Rp. " + diskon.ToString();
                    lblTotal.Text = "Rp. " + total.ToString();
                    dgvBarang.Rows.Clear();
                    nudQty.Value = 0;
                    cbBarang.Text = "";
                    cbPembayaran.Text = "";
                }
            }
        }

        private void btnHapusTrans_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Kamu Mau Hapus Data ?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                if (id > 0)
                {
                    if (tc.deleteDataTransaksi(id))
                    {
                        MessageBox.Show("Berhasil Hapus Data");
                        fillDataGrid();
                    }
                }
            }
        }

        private void dgvTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Pilih(e);
            cbBarang.Enabled= false;
            nudQty.Enabled= false;
            cbPembayaran.Enabled= false;

        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            (dgvTransaksi.DataSource as DataTable).DefaultView.RowFilter = string.Format("nama_pelanggan LIKE '%{0}%'", txtCari.Text);
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Kamu Mau Ubah Data ?", "Ubah Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                if (id > 0)
                {
                    TransaksiModel objCust = populateTransaksi();
                    objCust.IdTransaksi = id;
                    if (tc.updateTransaksi(objCust))
                    {
                        MessageBox.Show("Berhasil Ubah Data");
                        cbNama.Text = "";
                        cbBarang.Enabled = true;
                        nudQty.Enabled = true;
                        cbPembayaran.Enabled = true;
                        fillDataGrid();
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cbNama.Text = "";
            cbBarang.Enabled = true;
            nudQty.Enabled = true;
            cbPembayaran.Enabled = true;
        }
    }
}

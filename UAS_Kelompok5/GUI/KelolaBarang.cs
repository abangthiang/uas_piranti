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

namespace UAS_Kelompok5.GUI
{
    public partial class KelolaBarang : Form
    {
        int index;
        private int id = 0;
        BarangConnection bc = new BarangConnection();

        public KelolaBarang()
        {
            InitializeComponent();
        }

        private BarangModel populateBarang()
        {
            BarangModel c = new BarangModel();
            c.KodeBarang = Int32.Parse(txtKodeBarang.Text);
            c.NamaBarang = txtNamaBarang.Text;
            c.Harga = txtHarga.Text;
            c.Stok = Int32.Parse(txtStok.Text);
            return c;
        }

        private void fillDataGrid()
        {
            dgvKelolaBarang.DataSource = bc.getDataBarang();
            dgvKelolaBarang.Columns[3].DefaultCellStyle.Format = "#,##0";//"#,##0";
            dgvKelolaBarang.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void ClearInput()
        {
            txtKodeBarang.Text = txtNamaBarang.Text = txtHarga.Text = txtStok.Text = string.Empty;
        }

        private void Pilih(DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                try
                {
                    id = Convert.ToInt32(dgvKelolaBarang.Rows[index].Cells[0].Value.ToString());
                    txtNamaBarang.Text = dgvKelolaBarang.Rows[index].Cells[1].Value.ToString();
                    txtKodeBarang.Text = dgvKelolaBarang.Rows[index].Cells[2].Value.ToString();
                    txtHarga.Text = dgvKelolaBarang.Rows[index].Cells[3].Value.ToString();
                    txtStok.Text = dgvKelolaBarang.Rows[index].Cells[4].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Kamu Mau Simpan Data ?", "Simpan Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                if (bc.insertDataBarang(populateBarang()))
                {
                    MessageBox.Show("sukses input data barang");
                    fillDataGrid();
                    ClearInput();
                }
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Kamu Mau Ubah Data ?", "Ubah Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                if (id > 0)
                {
                    BarangModel objBrg = populateBarang();
                    objBrg.Id_barang = id;
                    if (bc.updateBarang(objBrg))
                    {
                        MessageBox.Show("Berhasil Ubah Data");
                        fillDataGrid();
                        ClearInput();
                    }
                }
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Kamu Mau Hapus Data ?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                if (id > 0)
                {
                    if (bc.deleteDataBarang(id))
                    {
                        MessageBox.Show("Berhasil Hapus Data");
                        fillDataGrid();
                        ClearInput();
                    }
                }
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            (dgvKelolaBarang.DataSource as DataTable).DefaultView.RowFilter = string.Format("nama_barang LIKE '%{0}%'", txtCari.Text);
        }

        private void KelolaBarang_Load(object sender, EventArgs e)
        {
            fillDataGrid();
        }

        private void dgvKelolaBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Pilih(e);
        }

        private void KelolaBarang_Layout(object sender, LayoutEventArgs e)
        {
            fillDataGrid();
        }
    }
}

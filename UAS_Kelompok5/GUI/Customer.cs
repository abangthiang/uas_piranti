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

namespace UAS_Kelompok5.GUI
{
    public partial class Customer : Form
    {
        int idx;
        private int id = 0;
        CustomerConnection cc = new CustomerConnection();

        public Customer()
        {
            InitializeComponent();
        }

        private CustomerModel populateCustomer()
        {
            CustomerModel c = new CustomerModel();
            string jenisKelamin = "";
            if (rbLaki.Checked == true)
            {
                jenisKelamin = "Laki - Laki";
            }
            else if (rbPerempuan.Checked == true)
            {
                jenisKelamin = "Perempuan";
            }
            c.Nama = txtNama.Text;
            c.NoHP = txtHp.Text;
            c.TglLahir = dtpTglLahir.Value;
            c.JenisKelamin = jenisKelamin;
            c.TempatLahir = txtTmptLahir.Text;
            c.Membership = cbMembership.Text;
            c.Alamat = rtbAlamat.Text;
            return c;
        }

        private void fillDataGrid()
        {
            dgvCustomer.DataSource = cc.getDataCustomer();
        }

        private void Pilih(DataGridViewCellEventArgs e)
        {
            idx = e.RowIndex;
            if (idx >= 0)
            {
                try
                {
                    id = Convert.ToInt32(dgvCustomer.Rows[idx].Cells[0].Value.ToString());
                    txtNama.Text = dgvCustomer.Rows[idx].Cells[1].Value.ToString();
                    txtHp.Text = dgvCustomer.Rows[idx].Cells[2].Value.ToString();
                    rtbAlamat.Text = dgvCustomer.Rows[idx].Cells[6].Value.ToString();
                    txtTmptLahir.Text = dgvCustomer.Rows[idx].Cells[7].Value.ToString();
                    dtpTglLahir.Text = dgvCustomer.Rows[idx].Cells[3].Value.ToString();
                    cbMembership.Text = dgvCustomer.Rows[idx].Cells[5].Value.ToString();
                    if (dgvCustomer.Rows[idx].Cells[4].Value.ToString() == "Perempuan")
                    {
                        rbPerempuan.Checked = true;
                    }
                    else if (dgvCustomer.Rows[idx].Cells[4].Value.ToString() == "Laki - Laki")
                    {
                        rbLaki.Checked = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ClearInput()
        {
            txtNama.Text = txtHp.Text = rtbAlamat.Text = txtTmptLahir.Text = dtpTglLahir.Text = cbMembership.Text = string.Empty;
            rbLaki.Checked = false;
            rbPerempuan.Checked = false;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Kamu Mau Simpan Data ?", "Simpan Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                if (cc.insertDataCustomer(populateCustomer()))
                {
                    MessageBox.Show("sukses input data customer");
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
                    CustomerModel objCust = populateCustomer();
                    objCust.IdCustomer = id;
                    if (cc.updateCustomer(objCust))
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
                    if (cc.deleteDataCustomer(id))
                    {
                        MessageBox.Show("Berhasil Hapus Data");
                        fillDataGrid();
                        ClearInput();
                    }
                }
            }
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            fillDataGrid();
        }

        private void dtpTglLahir_ValueChanged(object sender, EventArgs e)
        {
            dtpTglLahir.MaxDate = DateTime.Now.Date;
        }

        private void txtHp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Pilih(e);
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            (dgvCustomer.DataSource as DataTable).DefaultView.RowFilter = string.Format("nama LIKE '%{0}%'", txtCari.Text);
        }
    }
}

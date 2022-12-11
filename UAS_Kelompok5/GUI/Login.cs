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
using UAS_Kelompok5.Connection;

namespace UAS_Kelompok5.GUI
{
    public partial class Login : Form
    {
        UserConnection uc = new UserConnection();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.CompareTo("") == 0 || txtPassword.Text.CompareTo("") == 0)
            {
                MessageBox.Show("Username & Password tidak boleh kosong");
            }
            else
            {
                if (uc.validateUserLogin(txtUsername.Text, txtPassword.Text))
                {
                    MessageBox.Show("Berhasil Login");
                    HalamanDepan halamanDepanForm = new HalamanDepan();
                    halamanDepanForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username / Password salah!");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
    }
}

using PenjualanProduk.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PenjualanProduk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_nama_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_btnmasuk_Click(object sender, EventArgs e)
        {
            // Validasi login
            string username = "kazuki";
            string password = "1234";

            if (login_nama.Text == username && login_pwd.Text == password)
            {
                // Jika valid, buka Form2 dan sembunyikan Form1
                frmutama FrmUtama = new frmutama();
                FrmUtama.Show();
                this.Hide();
            }
            else
            {
                // Jika tidak valid, tampilkan pesan error
                MessageBox.Show("Nama atau Password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void login_showpwd_CheckedChanged(object sender, EventArgs e)
        {
            login_pwd.PasswordChar = login_showpwd.Checked ? '\0' : '*';
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

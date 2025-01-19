using PenjualanProduk.Controller;
using PenjualanProduk.Model.Context;
using PenjualanProduk.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PenjualanProduk.View
{
    public delegate void CreateUpdateTransaksiEventHandler(Transaksi tsk);
    public partial class FormTambahTransaksi : Form
    {
        private SQLiteConnection _conn;
        //private frmproduk frmproduk;
        public FormTambahTransaksi(DbContext context)
        {
            _conn = context.Conn;
        }
        public event CreateUpdateTransaksiEventHandler OnCreate;
        public event CreateUpdateTransaksiEventHandler OnUpdate;
        private TransaksiController controller;
        private bool isNewData = true;
        private Transaksi tsk;

        public FormTambahTransaksi()
        {
            InitializeComponent();
        }
        public FormTambahTransaksi(string title, TransaksiController controller) : this()
        {
            this.Text = title;
            this.controller = controller;
        }
        
        public FormTambahTransaksi(string title, Transaksi obj, TransaksiController controller) : this()
        {
            this.Text = title;
            if (controller == null)
            {
                MessageBox.Show("Controller belum diinisialisasi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.controller = controller; 
        }

        private void btn_selesai_Click(object sender, EventArgs e)
        {
            TransaksiController controller = new TransaksiController();
            FormTambahTransaksi formTambahPTransaksi = new FormTambahTransaksi("Tambah Transaksi", controller);
            formTambahPTransaksi.Show();

            if (isNewData)
                tsk = new Transaksi();

            tsk.IdProduk = txt_idproduk.Text;
            tsk.NamaProduk = txt_nama.Text;
            tsk.Kategori = cmb_kategori.SelectedItem?.ToString();
            tsk.Harga = txt_harga.Text;
            tsk.TotalHarga = txt_totalharga.Text;
            tsk.Status = cmb_status.SelectedItem?.ToString();
            tsk.IdPelanggan = txt_pelanggan.Text;

            int result = 0;

            if (isNewData) 
            {
                result = controller.Create(tsk);

                if (result > 0)
                {
                    OnCreate?.Invoke(tsk);

                    txt_idproduk.Clear();
                    txt_nama.Clear();
                    cmb_kategori.SelectedIndex = -1;
                    txt_harga.Clear();
                    txt_totalharga.Clear();
                    cmb_status.SelectedIndex = -1;
                    txt_pelanggan.Clear();

                    txt_idproduk.Focus();
                }
            }
            else
            {
                result = controller.Update(tsk);
                if (result > 0)
                {
                    OnUpdate?.Invoke(tsk);
                    this.Close();
                }
            }
        }

        private void btn_hitung_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txt_harga.Text, out decimal harga) && int.TryParse(txt_jumlah.Text, out int jumlah))
            {
                decimal total = harga * jumlah;
                txt_totalharga.Text = total.ToString("N0");
            }
            else
            {
                MessageBox.Show("Masukkan harga dan jumlah yang valid", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

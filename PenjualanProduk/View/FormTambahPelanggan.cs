using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PenjualanProduk.Model.Entity;
using PenjualanProduk.Controller;
using System.IO;
using PenjualanProduk.Model.Context;
using System.Data.SQLite;

namespace PenjualanProduk.View
{
    public delegate void CreateUpdateEventHandler(Pelanggan pgn);
    public partial class FormTambahPelanggan : Form
    {
        private SQLiteConnection _conn;
        public FormTambahPelanggan(DbContext context)
        {
            _conn = context.Conn;
        }
        public event CreateUpdateEventHandler OnCreate;
        public event CreateUpdateEventHandler OnUpdate;
        private PelangganController controller;
        private bool isNewData = true;
        private Pelanggan pgn;

        public FormTambahPelanggan()
        {
            InitializeComponent();
        }
        public FormTambahPelanggan(string title, PelangganController controller) : this()
        {
            this.Text = title;
            this.controller = controller;
        }
        
        public FormTambahPelanggan(string title, Pelanggan obj, PelangganController controller) : this()
        {
            this.Text = title;
            this.controller = controller;

            isNewData = false;
            pgn = obj;

            Nama.Text = pgn.Nama;
            Alamat.Text = pgn.Alamat;
            NoTelpon.Text = pgn.NoTelpon;
            Jenis_Kelamin.Text = pgn.Jenis_Kelamin;
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            PelangganController controller = new PelangganController();
            FormTambahPelanggan formTambahPelanggan = new FormTambahPelanggan("Tambah Pelanggan", controller);

            formTambahPelanggan.Show();

            if (isNewData)
                pgn = new Pelanggan();

            pgn.Nama = Nama.Text;
            pgn.Alamat = Alamat.Text;
            pgn.NoTelpon = NoTelpon.Text;
            pgn.Jenis_Kelamin = Jenis_Kelamin.SelectedItem?.ToString();

            int result = 0;

            if (isNewData) 
            {
                result = controller.Create(pgn);

                if (result > 0)
                {
                    OnCreate?.Invoke(pgn);

                    Nama.Clear();
                    Alamat.Clear();
                    NoTelpon.Clear();
                    Jenis_Kelamin.SelectedIndex = -1;
                    Nama.Focus();
                }
            }
            else 
            {
                result = controller.Update(pgn);
                if (result > 0)
                {
                    OnUpdate?.Invoke(pgn);
                    this.Close();
                }
            }
        }

        private void btn_selesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

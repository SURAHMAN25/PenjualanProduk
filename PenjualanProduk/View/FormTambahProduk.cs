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
    public delegate void CreateUpdateProdukEventHandler(Produk pdk);
    public partial class FormTambahProduk : Form
    {
        private SQLiteConnection _conn;
        public FormTambahProduk(DbContext context)
        {
            _conn = context.Conn;
        }
        public event CreateUpdateProdukEventHandler OnCreate;
        public event CreateUpdateProdukEventHandler OnUpdate;
        private ProdukController controller;
        private bool isNewData = true;
        private Produk pdk;

        public FormTambahProduk()
        {
            InitializeComponent();
        }
        public FormTambahProduk(string title, ProdukController controller) : this()
        {
            this.Text = title;
            this.controller = controller;
        }
        public FormTambahProduk(string title, Produk obj, ProdukController controller) : this()
        { 
            this.Text = title;
            this.controller = controller;

            isNewData = false; 
            pdk = obj; 

            ID_Produk.Text = pdk.ID_Produk;
            Nama_Produk.Text = pdk.Nama_Produk;
            Kategori_Produk.Text = pdk.Kategori_Produk;
            Stok_Produk.Text = pdk.Stok_Produk;
            //ft_produk.Text = pdk.Foto_Produk;
            Harga_Produk.Text = pdk.Harga_Produk;
        }
        private void btn_tambah_Click(object sender, EventArgs e)
        {
            if (isNewData) pdk = new Produk();

            pdk.ID_Produk = ID_Produk.Text;
            pdk.Nama_Produk = Nama_Produk.Text;
            pdk.Kategori_Produk = Kategori_Produk.Text;
            pdk.Stok_Produk = Stok_Produk.Text; 
            //pdk.Foto_Produk = ft_produk.Text;
            pdk.Harga_Produk = Harga_Produk.Text;   

            int result = 0;

            if (isNewData)
            {
                result = controller.Create(pdk);

                if (result > 0)
                {
                    OnCreate(pdk);

                    ID_Produk.Clear();
                    Nama_Produk.Clear();
                    Kategori_Produk.Clear();
                    Stok_Produk.Clear();
                    Harga_Produk.Clear();

                    ID_Produk.Focus();
                }
            }
            else 
            {
                result = controller.Update(pdk);
                if (result > 0)
                {
                    OnUpdate(pdk);
                    this.Close();
                }
            }
        }

        private void btn_selesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_tambahft_Click(object sender, EventArgs e)
        {
            
        }
    }
}

using PenjualanProduk.Controller;
using PenjualanProduk.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PenjualanProduk.View
{
    public partial class frmTransaksi : Form
    {
        private List<Transaksi> listOfTransaksi = new List<Transaksi>();
        private TransaksiController controller;
        public frmTransaksi()
        {
            InitializeComponent();
            controller = new TransaksiController();
            InisialisasiListView();
            LoadDataTransaksi();
        }
        private void InisialisasiListView()
        {
            lvw_transaksi.View = System.Windows.Forms.View.Details;
            lvw_transaksi.FullRowSelect = true;
            lvw_transaksi.GridLines = true;

            lvw_transaksi.Columns.Add("No.", 30, HorizontalAlignment.Center);
            lvw_transaksi.Columns.Add("ID Produk", 100, HorizontalAlignment.Center);
            lvw_transaksi.Columns.Add("Nama", 120, HorizontalAlignment.Center);
            lvw_transaksi.Columns.Add("Kategori", 100, HorizontalAlignment.Center);
            lvw_transaksi.Columns.Add("Harga", 100, HorizontalAlignment.Center);
            lvw_transaksi.Columns.Add("Total Harga", 100, HorizontalAlignment.Center);
            lvw_transaksi.Columns.Add("Status", 90, HorizontalAlignment.Center);
            lvw_transaksi.Columns.Add("Nama Pelanggan", 100, HorizontalAlignment.Center);
            lvw_transaksi.Columns.Add("Tanggal Transaksi", 100, HorizontalAlignment.Center);
        }
        private void LoadDataTransaksi()
        {
            lvw_transaksi.Items.Clear();

            listOfTransaksi = controller.ReadAll();
            foreach (var tsk in listOfTransaksi)
            {
                var noUrut = lvw_transaksi.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
     
                //item.SubItems.Add(tsk.IdTransaksi);
                item.SubItems.Add(tsk.IdProduk);
                item.SubItems.Add(tsk.NamaProduk);
                item.SubItems.Add(tsk.Kategori);
                item.SubItems.Add(tsk.Harga);
                item.SubItems.Add(tsk.TotalHarga);
                item.SubItems.Add(tsk.Status);
                item.SubItems.Add(tsk.IdPelanggan);
                item.SubItems.Add(tsk.Tanggal_Transaksi);

                lvw_transaksi.Items.Add(item);
            }
        }
        private void OnCreateEventHandler(Transaksi tsk)
        {
            listOfTransaksi.Add(tsk);

            int idnoUrut = lvw_transaksi.Items.Count + 1;
            ListViewItem item = new ListViewItem(idnoUrut.ToString());
            item.SubItems.Add(tsk.IdTransaksi);
            item.SubItems.Add(tsk.IdProduk);
            item.SubItems.Add(tsk.NamaProduk);
            item.SubItems.Add(tsk.Kategori);
            item.SubItems.Add(tsk.Harga);
            item.SubItems.Add(tsk.TotalHarga);
            item.SubItems.Add(tsk.Status);
            item.SubItems.Add(tsk.IdPelanggan);
            item.SubItems.Add(tsk.Tanggal_Transaksi);

            lvw_transaksi.Items.Add(item);
        }
        private void OnUpdateEventHandler(Transaksi tsk)
        {
            int index = lvw_transaksi.SelectedIndices[0];
            ListViewItem itemRow = lvw_transaksi.Items[index];
            itemRow.SubItems[1].Text = tsk.IdTransaksi;
            itemRow.SubItems[2].Text = tsk.IdProduk;
            itemRow.SubItems[3].Text = tsk.NamaProduk;
            itemRow.SubItems[4].Text = tsk.Kategori;
            itemRow.SubItems[5].Text = tsk.Harga;
            itemRow.SubItems[6].Text = tsk.TotalHarga;
            itemRow.SubItems[8].Text = tsk.Status;
            itemRow.SubItems[9].Text = tsk.IdPelanggan;
            itemRow.SubItems[10].Text = tsk.Tanggal_Transaksi;
        }

        private void btn_pelanggan_Click(object sender, EventArgs e)
        {
            frmPelanggan FormPelanggan = new frmPelanggan();
            FormPelanggan.Show();
            this.Hide();
        }

        private void btn_produk_Click(object sender, EventArgs e)
        {
            frmproduk FrmProduk = new frmproduk();
            FrmProduk.Show();
            this.Hide();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            frmutama FrmUtama = new frmutama();
            FrmUtama.Show();
            this.Hide();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Form1 FrmLogin = new Form1();
            FrmLogin.Show();
            this.Hide();
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            FormTambahTransaksi FrmTambah = new FormTambahTransaksi();
            FrmTambah.Show();
            //this.Hide();
        }
    }
}

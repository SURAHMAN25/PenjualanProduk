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
    public partial class frmPelanggan : Form
    {
        private List<Pelanggan> listOfPelanggan = new List<Pelanggan>();
        private PelangganController controller;
        public frmPelanggan()
        {
            InitializeComponent();
            controller = new PelangganController();
            InisialisasiListView();
            LoadDataPelanggan();
        }
        private void InisialisasiListView()
        {
            lvw_pelanggan.View = System.Windows.Forms.View.Details;
            lvw_pelanggan.FullRowSelect = true;
            lvw_pelanggan.GridLines = true;

            lvw_pelanggan.Columns.Add("No.", 36, HorizontalAlignment.Center);
            lvw_pelanggan.Columns.Add("Nama", 200, HorizontalAlignment.Center);
            lvw_pelanggan.Columns.Add("Alamat", 180, HorizontalAlignment.Center);
            lvw_pelanggan.Columns.Add("No Telepon", 100, HorizontalAlignment.Center);
            lvw_pelanggan.Columns.Add("Jenis Kelamin", 100, HorizontalAlignment.Center);

        }
        private void LoadDataPelanggan()
        {
            lvw_pelanggan.Items.Clear();
            listOfPelanggan = controller.ReadAll();

            foreach (var pgn in listOfPelanggan)
            {
                var idnoUrut = lvw_pelanggan.Items.Count + 1;

                var item = new ListViewItem(idnoUrut.ToString());
                //item.SubItems.Add(pgn.ID_Pelanggan);
                item.SubItems.Add(pgn.Nama);
                item.SubItems.Add(pgn.Alamat);
                item.SubItems.Add(pgn.NoTelpon);
                item.SubItems.Add(pgn.Jenis_Kelamin);

                lvw_pelanggan.Items.Add(item);
            }
        }
        private void OnCreateEventHandler(Pelanggan pgn)
        {
            listOfPelanggan.Add(pgn);

            int idnoUrut = lvw_pelanggan.Items.Count + 1;

            ListViewItem item = new ListViewItem(idnoUrut.ToString());
            item.SubItems.Add(pgn.ID_Pelanggan);
            item.SubItems.Add(pgn.Nama);
            item.SubItems.Add(pgn.Alamat);
            item.SubItems.Add(pgn.NoTelpon);
            item.SubItems.Add(pgn.Jenis_Kelamin);

            lvw_pelanggan.Items.Add(item);
        }
        private void OnUpdateEventHandler(Pelanggan pgn)
        {
            int index = lvw_pelanggan.SelectedIndices[0];

            ListViewItem itemRow = lvw_pelanggan.Items[index];
            itemRow.SubItems[1].Text = pgn.ID_Pelanggan;
            itemRow.SubItems[2].Text = pgn.Nama;
            itemRow.SubItems[3].Text = pgn.Alamat;
            itemRow.SubItems[4].Text = pgn.NoTelpon;
            itemRow.SubItems[5].Text = pgn.Jenis_Kelamin;
        }


        private void btn_tambah_Click(object sender, EventArgs e)
        {
            FormTambahPelanggan frmpelanggan = new FormTambahPelanggan();
            frmpelanggan.Show();
            //this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            if (lvw_pelanggan.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data Pelanggan ingin dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (konfirmasi == DialogResult.Yes)
                {
                    Pelanggan pgn = listOfPelanggan[lvw_pelanggan.SelectedIndices[0]];

                    var result = controller.Delete(pgn);
                    if (result > 0) LoadDataPelanggan();
                }
            }
            else
            {
                MessageBox.Show("Data Pelanggan belum dipilih !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_transaksi_Click(object sender, EventArgs e)
        {
            frmTransaksi FormTransaksi = new frmTransaksi();
            FormTransaksi.Show();
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Form1 FrmLogin = new Form1();
            FrmLogin.Show();
            this.Hide();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (lvw_pelanggan.SelectedItems.Count > 0)
            {
                Pelanggan pgn = listOfPelanggan[lvw_pelanggan.SelectedIndices[0]];
                FormTambahPelanggan frmTambah = new FormTambahPelanggan("Edit Data Pelanggan", pgn, controller);
                frmTambah.OnUpdate += OnUpdateEventHandler;
                frmTambah.ShowDialog();
            }
            else
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

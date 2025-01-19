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
using System.Data.SQLite;
using System.Xml.Linq;

namespace PenjualanProduk.View
{
    public delegate void CreateUpdateEventHandler(Produk pdk);
    public partial class frmproduk : Form
    {
        private List<Produk> listOfProduk = new List<Produk>();

        public event CreateUpdateEventHandler OnCreate;
        public event CreateUpdateEventHandler OnUpdate;
        private ProdukController controller;
        private bool isNewData = true;
        private Produk pdk;

        public frmproduk()
        {
            InitializeComponent();
            controller = new ProdukController();
            InisialisasiListView();
            LoadDataProduk();
        }
        private void InisialisasiListView()
        {
            lvw_produk.View = System.Windows.Forms.View.Details;
            lvw_produk.FullRowSelect = true;
            lvw_produk.GridLines = true;

            lvw_produk.Columns.Add("No.", 36, HorizontalAlignment.Center);
            lvw_produk.Columns.Add("ID Produk", 90, HorizontalAlignment.Center);
            lvw_produk.Columns.Add("Nama Produk", 180, HorizontalAlignment.Center);
            lvw_produk.Columns.Add("Kategori", 99, HorizontalAlignment.Center);
            lvw_produk.Columns.Add("Stok", 35, HorizontalAlignment.Center);
            lvw_produk.Columns.Add("Foto", 40, HorizontalAlignment.Center);
            lvw_produk.Columns.Add("Harga", 70, HorizontalAlignment.Center);
            lvw_produk.Columns.Add("Tanggal Tambah", 100, HorizontalAlignment.Center);
            lvw_produk.Columns.Add("Tanggal Update", 100, HorizontalAlignment.Center);

        }
        private void LoadDataProduk()
        {
            // kosongkan listview
            lvw_produk.Items.Clear();

            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfProduk = controller.ReadAll();

            // ekstrak objek mhs dari collection
            foreach (var pdk in listOfProduk)
            {
                var noUrut = lvw_produk.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(pdk.ID_Produk);
                item.SubItems.Add(pdk.Nama_Produk);
                item.SubItems.Add(pdk.Kategori_Produk);
                item.SubItems.Add(pdk.Stok_Produk);
                item.SubItems.Add(pdk.Foto_Produk);
                item.SubItems.Add(pdk.Harga_Produk);
                item.SubItems.Add(pdk.Tanggal_Tambah);
                item.SubItems.Add(pdk.Tanggal_Edit);

                // tampilkan data mhs ke listview
                lvw_produk.Items.Add(item);
            }
        }
        private void OnCreateEventHandler(Produk pdk)
        {
            // tambahkan objek mhs yang baru ke dalam collection
            listOfProduk.Add(pdk);

            int noUrut = lvw_produk.Items.Count + 1;

            // tampilkan data mhs yg baru ke list view
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(pdk.ID_Produk);
            item.SubItems.Add(pdk.Nama_Produk);
            item.SubItems.Add(pdk.Kategori_Produk);
            item.SubItems.Add(pdk.Stok_Produk);
            item.SubItems.Add(pdk.Foto_Produk);
            item.SubItems.Add(pdk.Harga_Produk);
            item.SubItems.Add(pdk.Tanggal_Tambah);
            item.SubItems.Add(pdk.Tanggal_Edit);

            lvw_produk.Items.Add(item);
        }
        private void OnUpdateEventHandler(Produk pdk)
        {
            // ambil index data mhs yang edit
            int index = lvw_produk.SelectedIndices[0];
            // update informasi mhs di listview
            ListViewItem itemRow = lvw_produk.Items[index];
            itemRow.SubItems[1].Text = pdk.ID_Produk;
            itemRow.SubItems[2].Text = pdk.Nama_Produk;
            itemRow.SubItems[3].Text = pdk.Kategori_Produk;
            itemRow.SubItems[4].Text = pdk.Stok_Produk;
            itemRow.SubItems[5].Text = pdk.Foto_Produk;
            itemRow.SubItems[6].Text = pdk.Harga_Produk;
        }

        public frmproduk(string title, ProdukController controller): this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;
        }

        public frmproduk(string title, Produk obj, ProdukController controller): this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;   

            isNewData = false; // set status edit data
            pdk = obj; // set objek mhs yang akan diedit
            
            // untuk edit data, tampilkan data lama
            ID_Produk.Text = pdk.ID_Produk;
            Nama_Produk.Text = pdk.Nama_Produk;
            Kategori_Produk.Text = pdk.Kategori_Produk;
            Stok_Produk.Text = pdk.Kategori_Produk;
            ft_produk.Text = pdk.Kategori_Produk;
            Harga_Produk.Text = pdk.Kategori_Produk;
        }

        private void FormProduk_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            if (isNewData)
                pdk = new Produk();

            // Ambil nilai dari input form dan set ke properti objek `pdk`
            pdk.ID_Produk = ID_Produk.Text;
            pdk.Nama_Produk = Nama_Produk.Text;
            pdk.Kategori_Produk = Kategori_Produk.Text;
            pdk.Stok_Produk = Stok_Produk.Text;
            pdk.Foto_Produk = ft_produk.Text;
            pdk.Harga_Produk = Harga_Produk.Text;

            int result = 0;

            if (isNewData) // tambah data baru
            {
                result = controller.Create(pdk);

                if (result > 0)
                {
                    // Panggil event OnCreate
                    OnCreate?.Invoke(pdk);

                    // Reset input form
                    ID_Produk.Clear();
                    Nama_Produk.Clear();
                    Kategori_Produk.Clear();
                    Stok_Produk.Clear();
                    Harga_Produk.Clear();

                    ID_Produk.Focus();
                }
            }
            if (controller == null)
            {
                MessageBox.Show("Controller belum diinisialisasi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmproduk formproduk = new frmproduk("Tambah Data Mahasiswa", controller);
            formproduk.OnCreate += OnCreateEventHandler;
            formproduk.ShowDialog();
        }

        private void btn_tambahft_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";
                string imagePath = "";

                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    ft_produk.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            frmutama FrmUtama = new frmutama();
            FrmUtama.Show();
            this.Hide();
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            if (lvw_produk.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data Produk ingin dihapus?", "Konfirmasi",MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (konfirmasi == DialogResult.Yes)
                {
                    Produk pdk = listOfProduk[lvw_produk.SelectedIndices[0]];

                    var result = controller.Delete(pdk);
                    if (result > 0) LoadDataProduk();
                }
            }
            else
            {
                MessageBox.Show("Data mahasiswa belum dipilih !!!", "Peringatan",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_cari_Click(object sender, EventArgs e)
        {
            var nama_produk = Nama_Produk.Text;
            lvw_produk.Items.Clear();
            listOfProduk = controller.ReadByNama(nama_produk);
            foreach (var pdk in listOfProduk)
            {
                var noUrut = lvw_produk.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(pdk.ID_Produk);
                item.SubItems.Add(pdk.Nama_Produk);
                item.SubItems.Add(pdk.Kategori_Produk);
                item.SubItems.Add(pdk.Stok_Produk);
                item.SubItems.Add(pdk.Foto_Produk);
                item.SubItems.Add(pdk.Harga_Produk);
                item.SubItems.Add(pdk.Tanggal_Tambah);
                item.SubItems.Add(pdk.Tanggal_Edit);

                lvw_produk.Items.Add(item);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (lvw_produk.SelectedItems.Count > 0)
            {
                Produk mhs = listOfProduk[lvw_produk.SelectedIndices[0]];
                frmproduk frmProduk = new frmproduk("Edit Data Produk", pdk, controller);
                frmProduk.OnUpdate += OnUpdateEventHandler;
                frmProduk.ShowDialog();
            }
            else
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void lvw_produk_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvw_produk.SelectedItems.Count > 0)
            {
                int index = lvw_produk.SelectedIndices[0];
                Produk pdk = listOfProduk[index];

                ID_Produk.Text = pdk.ID_Produk.ToString();
                Nama_Produk.Text = pdk.Nama_Produk;
                Kategori_Produk.Text = pdk.Kategori_Produk;
                Stok_Produk.Text = pdk.Stok_Produk.ToString();
                Harga_Produk.Text = pdk.Harga_Produk.ToString();

                if (!string.IsNullOrEmpty(pdk.Foto_Produk) && File.Exists(pdk.Foto_Produk))
                {
                    ft_produk.Image = Image.FromFile(pdk.Foto_Produk);
                    ft_produk.SizeMode = PictureBoxSizeMode.StretchImage; // Sesuaikan ukuran
                }
                else
                {
                    ft_produk.Image = null; // Kosongkan jika foto tidak ditemukan
                }
            }
        }
    }
}

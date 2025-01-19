using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using PenjualanProduk.Model.Entity;
using PenjualanProduk.Model.Repository;
using PenjualanProduk.Model.Context;


namespace PenjualanProduk.Controller
{
    public class ProdukController
    {
        private ProdukRepository _repository;

        
        public List<Produk> ReadByNama(string nama_produk)
        {
            List<Produk> list = new List<Produk>();

            using (DbContext context = new DbContext())
            {
                _repository = new ProdukRepository(context);
                list = _repository.ReadByNama(nama_produk);
            }

            return list;
        }
        public List<Produk> ReadAll()
        {
            List<Produk> list = new List<Produk>();

            using (DbContext Context = new DbContext())
            {
                _repository = new ProdukRepository(Context);
                list = _repository.ReadAll();
            }

            return list;
        }

        public int Create(Produk pdk)
        {
            int result = 0;

            if (string.IsNullOrEmpty(pdk.ID_Produk) ||
                string.IsNullOrEmpty(pdk.Nama_Produk) ||
                string.IsNullOrEmpty(pdk.Kategori_Produk) ||
                string.IsNullOrEmpty(pdk.Stok_Produk) ||
                string.IsNullOrEmpty(pdk.Harga_Produk))
            {
                throw new Exception("Semua field wajib diisi!");
            }

            using (DbContext context = new DbContext())
            {
                _repository = new ProdukRepository(context);
                result = _repository.Create(pdk);
            }

            return result;
        }
        public int Update(Produk pdk)
        {
            int result = 0;

            // cek npm yang diinputkan tidak boleh kosong

            if (string.IsNullOrEmpty(pdk.ID_Produk) ||
                string.IsNullOrEmpty(pdk.Nama_Produk) ||
                string.IsNullOrEmpty(pdk.Kategori_Produk) ||
                string.IsNullOrEmpty(pdk.Stok_Produk) ||
                string.IsNullOrEmpty(pdk.Harga_Produk))
            {
                throw new Exception("Semua field wajib diisi!");
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new ProdukRepository(context);

                // panggil method Update class repository untuk mengupdate data
                result = _repository.Update(pdk);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Produk berhasil diupdate !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Produk gagal diupdate !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Delete(Produk pdk)
        {
            int result = 0;

            // cek nilai npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(pdk.ID_Produk))
            {   
                MessageBox.Show("ID harus diisi !!!", "Peringatan",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new ProdukRepository(context);

                // panggil method Delete class repository untuk menghapus data
                result = _repository.Delete(pdk);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Produk berhasil dihapus !", "Informasi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Produk gagal dihapus !!!", "Peringatan",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }
    }
}

using PenjualanProduk.Model.Context;
using PenjualanProduk.Model.Entity;
using PenjualanProduk.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PenjualanProduk.Controller
{
    public class TransaksiController
    {
        private TransaksiRepository _repository;

        public List<Transaksi> ReadByID(string IdTransaksi)
        {
            List<Transaksi> list = new List<Transaksi>();

            using (DbContext context = new DbContext())
            {
                _repository = new TransaksiRepository(context);
                list = _repository.ReadByID(IdTransaksi);

            }

            return list;
        }
        public List<Transaksi> ReadAll()
        {
            List<Transaksi> list = new List<Transaksi>();

            using (DbContext Context = new DbContext())
            {
                _repository = new TransaksiRepository(Context);
                list = _repository.ReadAll();
            }

            return list;
        }

        public int Create(Transaksi tsk)
        {
            if (string.IsNullOrEmpty(tsk.IdProduk))
            {
                MessageBox.Show("ID Transaksi harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(tsk.NamaProduk))
            {
                MessageBox.Show("Nama Transaksi harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(tsk.Kategori))
            {
                MessageBox.Show("Kategori Transaksi harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(tsk.Harga))
            {
                MessageBox.Show("Harga Transaksi harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(tsk.IdPelanggan))
            {
                MessageBox.Show("Nama pelanggan harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            int result = 0;

            try
            {
                using (DbContext context = new DbContext())
                {
                    _repository = new TransaksiRepository(context);
                    result = _repository.Create(tsk);
                }
                if (result > 0)
                {
                    MessageBox.Show("Data pelanggan berhasil ditambah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data pelanggan gagal ditambah!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }
        public int Update(Transaksi tsk)
        {
            if (string.IsNullOrEmpty(tsk.IdTransaksi))
            {
                MessageBox.Show("Id Transaksi harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(tsk.NamaProduk))
            {
                MessageBox.Show("Nama harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(tsk.Kategori))
            {
                MessageBox.Show("Kategori harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(tsk.Harga))
            {
                MessageBox.Show("Harga harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(tsk.TotalHarga))
            {
                MessageBox.Show("Total harga harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(tsk.IdPelanggan))
            {
                MessageBox.Show("Nama pelanggan harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            int result = 0;

            try
            {
                using (DbContext context = new DbContext())
                {
                    _repository = new TransaksiRepository(context);
                    result = _repository.Create(tsk);
                }
                if (result > 0)
                {
                    MessageBox.Show("Data berhasil ditambah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data gagal ditambah!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }

        public int Delete(Transaksi tsk)
        {
            int result = 0;
            if (string.IsNullOrEmpty(tsk.IdTransaksi))
            {
                MessageBox.Show("ID harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            using (DbContext context = new DbContext())
            {
                _repository = new TransaksiRepository(context);
                result = _repository.Delete(tsk);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Pelangggan berhasil dihapus !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Pelangggan gagal dihapus !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }
    }
}

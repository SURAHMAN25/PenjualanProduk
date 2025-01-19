using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using PenjualanProduk.Model.Entity;
using PenjualanProduk.Model.Repository;
using PenjualanProduk.Model.Context;
using System.Drawing;

namespace PenjualanProduk.Controller
{
    public class PelangganController
    {
        private PelangganRepository _repository;

        public List<Pelanggan> ReadByNama(string nama_pelanggan)
        {
            List<Pelanggan> list = new List<Pelanggan>();

            using (DbContext context = new DbContext())
            {
                _repository = new PelangganRepository(context);
                list = _repository.ReadByNama(nama_pelanggan);

            }

            return list;
        }
        public List<Pelanggan> ReadAll()
        {
            List<Pelanggan> list = new List<Pelanggan>();

            using (DbContext Context = new DbContext())
            {
                _repository = new PelangganRepository(Context);
                list = _repository.ReadAll();
            }

            return list;
        }

        public int Create(Pelanggan pgn)
        { 
            if (string.IsNullOrEmpty(pgn.Nama))
            {
                MessageBox.Show("Nama pelanggan harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pgn.Alamat))
            {
                MessageBox.Show("Alamat pelanggan harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pgn.NoTelpon))
            {
                MessageBox.Show("Nomor telepon pelanggan harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pgn.Jenis_Kelamin))
            {
                MessageBox.Show("Jenis kelamin pelanggan harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            int result = 0;

            try
            {
                using (DbContext context = new DbContext())
                {
                    _repository = new PelangganRepository(context);
                    result = _repository.Create(pgn);
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
        public int Update(Pelanggan pgn)
        {
            int result = 0;

            if (string.IsNullOrEmpty(pgn.Nama))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pgn.Alamat))
            {
                MessageBox.Show("Alamat harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pgn.NoTelpon))
            {
                MessageBox.Show("Nomor Telepon harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pgn.Jenis_Kelamin))
            {
                MessageBox.Show("Gender diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new PelangganRepository(context);
                result = _repository.Update(pgn);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Pelanggan berhasil disimpan !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Pelangggan gagal disimpan !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Delete(Pelanggan pgn)
        {
            int result = 0;

            // cek nilai npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(pgn.ID_Pelanggan))
            {
                MessageBox.Show("ID harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new PelangganRepository(context);

                // panggil method Delete class repository untuk menghapus data
                result = _repository.Delete(pgn);
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

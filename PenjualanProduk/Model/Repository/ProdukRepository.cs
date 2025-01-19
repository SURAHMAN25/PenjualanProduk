using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;
using PenjualanProduk.Model.Entity;
using PenjualanProduk.Model.Context;
using System.IO;
using PenjualanProduk.View;

namespace PenjualanProduk.Model.Repository
{
    public class ProdukRepository
    {
        private SQLiteConnection _conn;
        private frmproduk frmproduk;
        public ProdukRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int Create(Produk pdk)
        {
            int result = 0;
            string sql = @"INSERT INTO produk ([ID_Produk], [Nama_Produk], [Kategori_Produk], [Stok_Produk], [ft_produk], [Harga_Produk], [tgl_tambah])
                     VALUES (@id_produk, @nama_produk, @kategori_produk, @stok_produk, @ft_produk, @harga_produk, @tgl_tambah)";

            string path = Path.Combine(@"E:\Kuliah\Semester 3\Pemrograman Lanjut\rusak\FP_AJI\FP\PenjualanProduk\PenjualanProduk\Product Directory\" + pdk.ID_Produk + ".jpg");

            string directoryPath = Path.GetDirectoryName(path);
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            File.Copy(ft_produk.ImageLocation, path, true);

            DateTime tanggalHariIni = DateTime.Today;
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@id_produk", pdk.ID_Produk);
                cmd.Parameters.AddWithValue("@nama_produk", pdk.Nama_Produk);
                cmd.Parameters.AddWithValue("@kategori_produk", pdk.Kategori_Produk);
                cmd.Parameters.AddWithValue("@stok_produk", pdk.Stok_Produk);
                cmd.Parameters.AddWithValue("@ft_produk", path);
                cmd.Parameters.AddWithValue("@harga_produk", pdk.Harga_Produk);
                cmd.Parameters.AddWithValue("@tgl_tambah", tanggalHariIni.ToString("dd/MM/yyyy"));

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                    throw new Exception("Terjadi kesalahan saat menambahkan produk: " + ex.Message);
                }
            }

            return result;
        }

        public int Update(Produk pdk)
        {
            int result = 0;
            string sql = @"UPDATE produk SET 
                        [Nama Produk] = @nama_produk, 
                        [Kategori Produk] = @kategori_produk, 
                        [Stok Produk] = @stok_produk, 
                        [Foto Produk] = @ft_produk, 
                        [Tanggal Edit] = @tgl_edit 
                      WHERE [ID Produk] = @id_produk";

            DateTime now = DateTime.Now;

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@id_produk", pdk.ID_Produk);
                cmd.Parameters.AddWithValue("@nama_produk", pdk.Nama_Produk);
                cmd.Parameters.AddWithValue("@kategori_produk", pdk.Kategori_Produk);
                cmd.Parameters.AddWithValue("@stok_produk", pdk.Stok_Produk);
                cmd.Parameters.AddWithValue("@ft_produk", pdk.Foto_Produk);
                cmd.Parameters.AddWithValue("@tgl_edit", now);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Update error: {0}", ex.Message);
                    throw new Exception("Terjadi kesalahan saat mengupdate produk: " + ex.Message);
                }
            }

            return result;
        }
        public int Delete(Produk pdk)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"DELETE FROM produk
                           WHERE ID_Produk = @id_produk";

            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@id_produk", pdk.ID_Produk);

                try
                {
                    // jalankan perintah DELETE dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Delete error: {0}", ex.Message);
                }
            }

            return result;
        }

        public List<Produk> ReadAll()
        {
            List<Produk> list = new List<Produk>();

            try
            {
                string sql = @"SELECT id_produk, nama_produk, kategori_produk, stok_produk, ft_produk, harga_produk, tgl_tambah
                               FROM produk
                               ORDER BY nama_produk";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Produk pdk = new Produk()
                            {
                                ID_Produk = dtr["id_produk"].ToString(),
                                Nama_Produk = dtr["nama_produk"].ToString(),
                                Kategori_Produk = dtr["kategori_produk"].ToString(),
                                Stok_Produk = dtr["stok_produk"].ToString(),
                                Foto_Produk = dtr["ft_produk"].ToString(),
                                Harga_Produk = dtr["harga_produk"].ToString(),
                                Tanggal_Tambah = dtr["tgl_tambah"].ToString(),

                            };
                            list.Add(pdk);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
                throw new Exception("Terjadi kesalahan saat membaca data produk: " + ex.Message);
            }

            return list;
        }
        public List<Produk> ReadByNama(string nama_produk)
        {
            // membuat objek collection untuk menampung objek mahasiswa
            List<Produk> list = new List<Produk>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"SELECT id_produk, nama_produk, kategori_produk, stok_produk, ft_produk, harga_produk, tgl_tambah
                             WHERE nama_produk LIKE @nama_produk
                             ORDER BY nama_produk";


                // membuat objek command menggunakan blok using
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    // mendaftarkan parameter dan mengeset nilainya
                    cmd.Parameters.AddWithValue("@nama_produk", string.Format("%{0}%", nama_produk));

                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Produk pdk = new Produk()
                            {
                                ID_Produk = dtr["id_produk"].ToString(),
                                Nama_Produk = dtr["nama_produk"].ToString(),
                                Kategori_Produk = dtr["kategori_produk"].ToString(),
                                Stok_Produk = dtr["stok_produk"].ToString(),
                                Foto_Produk = dtr["ft_produk"].ToString(),
                                Harga_Produk = dtr["harga_produk"].ToString(),
                                Tanggal_Tambah = dtr["tgl_tambah"].ToString(),

                            };

                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(pdk);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByNama error: {0}", ex.Message);
            }

            return list;
        }
    }
}

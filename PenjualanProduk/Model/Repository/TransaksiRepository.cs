using PenjualanProduk.Model.Context;
using PenjualanProduk.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenjualanProduk.Model.Repository
{
    public class TransaksiRepository
    {
        private SQLiteConnection _conn;
        public TransaksiRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int Create(Transaksi tsk)
        {
            int result = 0;

            string sql = @"INSERT INTO Transaksi ([id_transaksi], [id_produk], [nama_produk], [kategori], [harga], [total_harga], [status], [id_pelanggan], [tgl_transaksi])
                          VALUES (@id_transaksi, @id_produk, @nama_produk, @kategori, @harga, @total_harga, @status, @id_pelanggan, @tgl_transaksi)";

            if (_conn.State != ConnectionState.Open)
                _conn.Open();

            DateTime tanggalHariIni = DateTime.Today;

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@id_transaksi", tsk.IdTransaksi);
                cmd.Parameters.AddWithValue("@id_produk", tsk.IdProduk);
                cmd.Parameters.AddWithValue("@nama_produk", tsk.NamaProduk);
                cmd.Parameters.AddWithValue("@kategori", tsk.Kategori);
                cmd.Parameters.AddWithValue("@harga", tsk.Harga);
                cmd.Parameters.AddWithValue("@total_harga", tsk.TotalHarga);
                cmd.Parameters.AddWithValue("@status", tsk.Status);
                cmd.Parameters.AddWithValue("@id_pelanggan", tsk.IdPelanggan);
                cmd.Parameters.AddWithValue("@tgl_transaksi", tanggalHariIni.ToString("dd/MM/yyyy"));

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (SQLiteException ex)
                {
                    System.Diagnostics.Debug.Print("SQLite Error: {0}", ex.Message);
                    throw new Exception("Terjadi kesalahan saat menambahkan pelanggan: " + ex.Message);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Error: {0}", ex.Message);
                    throw new Exception("Terjadi kesalahan: " + ex.Message);
                }
            }

            return result;
        }
        public int Update(Pelanggan pgn)
        {
            int result = 0;
            string sql = @"UPDATE pelanggan SET 
                        Nama_Pelanggan = @nama_pelanggan, 
                        Alamat = @alamat, 
                        NoTelpon = @mo_telepon
                        WHERE ID_Pelanggan = @id_pelanggan";

            DateTime tanggalHariIni = DateTime.Today;

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@id_ppelanggan", pgn.ID_Pelanggan);
                cmd.Parameters.AddWithValue("@nama", pgn.Nama);
                cmd.Parameters.AddWithValue("@alamat", pgn.Alamat);
                cmd.Parameters.AddWithValue("@no_telepob", pgn.NoTelpon);
                cmd.Parameters.AddWithValue("@jenis_kelamin", pgn.Jenis_Kelamin);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Update error: {0}", ex.Message);
                    throw new Exception("Terjadi kesalahan saat mengupdate pelanggan: " + ex.Message);
                }
            }

            return result;
        }
        public int Delete(Transaksi tsk)
        {
            int result = 0;

            string sql = @"DELETE FROM pelanggan
                           WHERE ID_Pelanggan = @id_pelanggan";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@id_pelanggan", tsk.IdTransaksi);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Delete error: {0}", ex.Message);
                }
            }

            return result;
        }

        public List<Transaksi> ReadAll()
        {
            List<Transaksi> list = new List<Transaksi>();

            try
            {
                string sql = @"SELECT id_transaksi, id_produk, nama_produk, kategori, harga, total_harga, status, id_pelanggan, id_produk, tgl_transaksi
                               FROM transaksi
                               ORDER BY id_transaksi";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Transaksi tsk = new Transaksi()
                            {
                                IdTransaksi = dtr["id_transaksi"].ToString(),
                                IdProduk = dtr["id_produk"].ToString(),
                                NamaProduk = dtr["nama_produk"].ToString(),
                                Kategori = dtr["kategori"].ToString(),
                                Harga = dtr["harga"].ToString(),
                                TotalHarga = dtr["total_harga"].ToString(),
                                Status = dtr["status"].ToString(),
                                IdPelanggan = dtr["id_pelanggan"].ToString(),
                                Tanggal_Transaksi = dtr["tgl_transaksi"].ToString(),
                            };
                            list.Add(tsk);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
                throw new Exception("Terjadi kesalahan saat membaca data pelanggan: " + ex.Message);
            }

            return list;
        }
        public List<Transaksi> ReadByID(string IdTransaksi)
        {
            List<Transaksi> list = new List<Transaksi>();

            try
            {
                string sql = @"SELECT id_transaksi, id_produk, nama_produk, kategori, harga, total_harga, status, id_pelanggan, id_produk, tgl_transaksi
                               FROM transaksi
                               WHERE id_transaksi LIKE @id_transaksi
                               ORDER BY id_transaksi";


                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@id_transaksi", string.Format("%{0}%", IdTransaksi));

                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Transaksi tsk = new Transaksi()
                            {
                                IdTransaksi = dtr["id_transaksi"].ToString(),
                                IdProduk = dtr["id_produk"].ToString(), 
                                NamaProduk = dtr["nama_produk"].ToString(),
                                Kategori = dtr["kategori"].ToString(),
                                Harga = dtr["harga"].ToString(),
                                TotalHarga = dtr["total_harga"].ToString(),
                                Status = dtr["status"].ToString(),
                                IdPelanggan = dtr["id_pelanggan"].ToString(),
                                Tanggal_Transaksi = dtr["tgl_transaksi"].ToString(),
                            };
                            list.Add(tsk);
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

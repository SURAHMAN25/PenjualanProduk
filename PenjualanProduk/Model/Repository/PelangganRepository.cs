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
using System.Windows.Forms;
using System.Drawing;
using System.Data;

namespace PenjualanProduk.Model.Repository
{
    public class PelangganRepository
    {
        private SQLiteConnection _conn;
        public PelangganRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int Create(Pelanggan pgn)
        {
            int result = 0;

            string sql = @"INSERT INTO Pelanggan 
            ([ID_Pelanggan], [nama_pelanggan], [Alamat], [no_telepon], [jenis_kelamin])
            VALUES (@id_pelanggan, @nama_pelanggan, @alamat, @no_telepon, @jenis_kelamin)";

            if (_conn.State != ConnectionState.Open)
                _conn.Open();

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@id_pelanggan", pgn.ID_Pelanggan);
                cmd.Parameters.AddWithValue("@nama_pelanggan", pgn.Nama);
                cmd.Parameters.AddWithValue("@alamat", pgn.Alamat);
                cmd.Parameters.AddWithValue("@no_telepon", pgn.NoTelpon);
                cmd.Parameters.AddWithValue("@jenis_kelamin", pgn.Jenis_Kelamin);

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
                        NoTelpon = @no_telepon,
                        Jenis_Kelamin = @jenis_kelamin
                        WHERE ID_Pelanggan = @id_pelanggan";

            DateTime tanggalHariIni = DateTime.Today;

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@id_pelanggan", pgn.ID_Pelanggan);
                cmd.Parameters.AddWithValue("@nama", pgn.Nama);
                cmd.Parameters.AddWithValue("@alamat", pgn.Alamat);
                cmd.Parameters.AddWithValue("@no_telepon", pgn.NoTelpon);
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
        public int Delete(Pelanggan pgn)
        {
            int result = 0;

            string sql = @"DELETE FROM pelanggan
                           WHERE ID_Pelanggan = @id_pelanggan";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@id_pelanggan", pgn.ID_Pelanggan);

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

        public List<Pelanggan> ReadAll()
        {
            List<Pelanggan> list = new List<Pelanggan>();

            try
            {
                string sql = @"SELECT id_pelanggan, nama_pelanggan, alamat, no_telepon, jenis_kelamin
                               FROM pelanggan
                               ORDER BY nama_pelanggan";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Pelanggan pgn = new Pelanggan()
                            {
                                ID_Pelanggan = dtr["id_pelanggan"].ToString(),
                                Nama = dtr["nama_pelanggan"].ToString(),
                                Alamat = dtr["alamat"].ToString(),
                                NoTelpon = dtr["no_telepon"].ToString(),
                                Jenis_Kelamin = dtr["jenis_kelamin"].ToString(),

                            };
                            list.Add(pgn);
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
        public List<Pelanggan> ReadByNama(string nama_pelanggan)
        {
            List<Pelanggan> list = new List<Pelanggan>();

            try
            {
                string sql = @"SELECT id_pelanggan, nama, alamat, no_telepon, jenis_kelamin
                             FROM pelanggan
                             WHERE nama_pelanggan LIKE @nama_pelanggan
                             ORDER BY nama_pelanggan";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@nama_pelanggan", string.Format("%{0}%", nama_pelanggan));

                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Pelanggan pgn = new Pelanggan()
                            {
                                ID_Pelanggan = dtr["id_pelanggan"].ToString(),
                                Nama = dtr["nama_pelanggan"].ToString(),
                                Alamat = dtr["alamat"].ToString(),
                                NoTelpon = dtr["no_telepon"].ToString(),
                                Jenis_Kelamin = dtr["jenis_kelamin"].ToString(),

                            };
                            list.Add(pgn);
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

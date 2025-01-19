using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;
using PenjualanProduk.Model.Entity;
using PenjualanProduk.Model.Context;

namespace PenjualanProduk.Model.Repository
{
    internal class UserRepository
    {
        private SQLiteConnection _conn;

        public UserRepository(DbContext context)
        {
            _conn = context.Conn;
        }
        public int Create(User usr)
        {
            int result = 0;
            string sql = @"insert into user (Id, Nama, Password, Foto Profil, Status, Tanggal Daftar) values (@id, @username, @password, @profile_image, @status, @date_reg)";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@id", usr.Id);
                cmd.Parameters.AddWithValue("@username", usr.Username);
                cmd.Parameters.AddWithValue("@password", usr.Password);
                cmd.Parameters.AddWithValue("@profile_image", usr.Profile_Image);
                cmd.Parameters.AddWithValue("@Status", usr.Status);
                cmd.Parameters.AddWithValue("@date_reg", usr.Date_reg);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);

                }
            }
            return result;
        }
        public int Update(User usr)
        {
            int result = 0;
            string sql = @"update user Id = @id, Nama = @username, Password = @password, Foto Profil = @profile_image, Status = @status, Tanggal Daftar = @date_reg where Id = @id";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@id", usr.Id);
                cmd.Parameters.AddWithValue("@username", usr.Username);
                cmd.Parameters.AddWithValue("@password", usr.Password);
                cmd.Parameters.AddWithValue("@profile_image", usr.Profile_Image);
                cmd.Parameters.AddWithValue("@Status", usr.Status);
                cmd.Parameters.AddWithValue("@date_reg", usr.Date_reg);
                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);

                }
            }
            return result;
        }
        public int Delete(User usr)
        {
            int result = 0;
            string sql = @"delete from user where Id = @id";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@id", usr.Id);
                cmd.Parameters.AddWithValue("@username", usr.Username);
                cmd.Parameters.AddWithValue("@password", usr.Password);
                cmd.Parameters.AddWithValue("@profile_image", usr.Profile_Image);
                cmd.Parameters.AddWithValue("@Status", usr.Status);
                cmd.Parameters.AddWithValue("@date_reg", usr.Date_reg);
                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);

                }
            }
            return result;
        }
        public List<User> ReadAll()
        {
            List<User> list = new List<User>();
            try
            {
                string sql = @"select Id, Nama, Password, Foto Profil, Status, Tanggal Daftar from mahasiswa order by Nama";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            User usr = new User();
                            usr.Id = dtr["Id"].ToString();
                            usr.Username = dtr["Nama"].ToString();
                            usr.Password = dtr["Password"].ToString();
                            usr.Profile_Image = dtr["Foto Profil"].ToString();
                            usr.Status = dtr["Status"].ToString();
                            usr.Date_reg = dtr["Tanggal Daftar"].ToString();
                            list.Add(usr);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }
            return list;
        }
        public List<User> ReadByNama(string nama)
        {
            List<User> list = new List<User>();
            try
            {
                string sql = @"select Id, Nama, from user where Nama like @username order by Nama";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@username", string.Format("%{0}%", nama));
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            User usr = new User();
                            usr.Id = dtr["Id"].ToString();
                            usr.Username = dtr["Nama"].ToString();
                            usr.Password = dtr["Password"].ToString();
                            usr.Profile_Image = dtr["Foto Profil"].ToString();
                            usr.Status = dtr["Status"].ToString();
                            usr.Date_reg = dtr["Tanggal Daftar"].ToString();
                            list.Add(usr);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByNama error: {0}",
               ex.Message);
            }
            return list;
        }
    }
}

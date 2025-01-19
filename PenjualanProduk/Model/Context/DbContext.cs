using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SQLite;


namespace PenjualanProduk.Model.Context
{
    public class DbContext : IDisposable
    {
        private SQLiteConnection _conn;
        public SQLiteConnection Conn
        {
            get { return _conn ?? (_conn = GetOpenConnection()); }
        }
        private SQLiteConnection GetOpenConnection()
        {
            SQLiteConnection conn = null;
            try // penggunaan blok try-catch untuk penanganan error
            {
                string dbName = @"E:\Kuliah\Semester 3\Pemrograman Lanjut\rusak\FP_AJI\FP\PenjualanProduk\Database\penjualanproduk.db";
                string connectionString = string.Format("Data Source ={0}; FailIfMissing = True", dbName);
                conn = new SQLiteConnection(connectionString);
                conn.Open();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("Open Connection Error: {0}", ex.Message);
            }
            return conn;
        }
        public void Dispose()
        {
            if (_conn != null)
            {
                try
                {
                    if (_conn.State != ConnectionState.Closed) _conn.Close();
                }
                finally
                {
                    _conn.Dispose();
                }
            }
            GC.SuppressFinalize(this);
        }
    }
}

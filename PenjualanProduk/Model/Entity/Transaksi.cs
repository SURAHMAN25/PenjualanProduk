using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenjualanProduk.Model.Entity
{
    public class Transaksi
    {
        public string IdTransaksi { get; set; }
        public string IdProduk { get; set; }
        public string NamaProduk { get; set; }
        public string Kategori { get; set; }
        public string Harga { get; set; }
        public string TotalHarga { get; set; }
        public string Status { get; set; }
        public string IdPelanggan { get; set; }
        public string Tanggal_Transaksi { get; set; }
    }
}

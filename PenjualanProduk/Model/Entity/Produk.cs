using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenjualanProduk.Model.Entity
{
    public class Produk
    {
        //public string ID { get; set; }
        public string ID_Produk { get; set; }
        public string Nama_Produk { get; set; }
        public string Kategori_Produk { get; set; }
        public string Stok_Produk { get; set; }
        public string Harga_Produk { get; set; }
        public string Foto_Produk { get; set; }
        public string Tanggal_Tambah { get; set; }
        public string Tanggal_Edit { get; set; }
        public string Tanggal_Hapus { get; set; }

    }
}

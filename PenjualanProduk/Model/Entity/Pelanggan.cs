using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenjualanProduk.Model.Entity
{
    public class Pelanggan
    {
        public string ID_Pelanggan { get; set; }
        public string Nama { get; set; }
        public string Alamat { get; set; }
        public string NoTelpon { get; set; }
        public string Jenis_Kelamin { get; set; }
    }
}

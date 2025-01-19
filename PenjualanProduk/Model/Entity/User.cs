using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenjualanProduk.Model.Entity
{
    internal class User
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Profile_Image { get; set; }
        public string Status { get; set; }
        public string Date_reg { get; set; }
    }
}

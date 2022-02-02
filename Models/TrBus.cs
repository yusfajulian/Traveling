using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Travelingyu.Models
{
    public class TrBus
    {
        [Key]
        public string NoTransaksi { get; set; }
        public Pelanggan KodePelanggan { get; set; }
        public string Dari { get; set; }
        public string Ke { get; set; }
        public int Jumlah { get; set; }
    }
}

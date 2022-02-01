using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Travelingyu.Models
{
    public class TransaksiBus
    {
        [Key]
        public string NoTransaksi { get; set; }
        public Bus KodeBus { get; set; }
        public Pelanggan KodePelanggan { get; set; }
        public int Jumlah { get; set; }
    }
}

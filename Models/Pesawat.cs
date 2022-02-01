using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Travelingyu.Models
{
    public class Pesawat
    {
        [Key]
        public string KodePesawat { get; set; }
        public string NamaMaskapai { get; set; }
        public string JenisPesawat { get; set; }
        public int Kursi { get; set; }
        public DateTime WaktuKeberangkatan { get; set; }
        public string Tujuan { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Travelingyu.Models
{
    public class Pemesanan
    {
        [Key]
        public string KodeTiket { get; set; }
        public Pelanggan KodePelanggan { get; set; }
        public DateTime WaktuKeberangkatan { get; set; }
        public Pesawat Pesawat { get; set; }
        public Maskapai Maskapai { get; set; }
        public Kelas NamaKelas { get; set; }
    }
}

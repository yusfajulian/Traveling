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
        public Pesawat kodePesawat { get; set; }
        public Pelanggan KodePelanggan { get; set; }
        public string DaerahAsal { get; set; }
        public DateTime WaktuKeberangkatan { get; set; }
        public string Tujuan { get; set; }
        public string NamaMaskapai { get; set; }
        public KelasPenerbangan NamaKelas { get; set; }
        public string NamaPelanggan { get; set; }
        public string NomorTelp { get; set; }
    }
}

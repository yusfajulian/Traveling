using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Travelingyu.Models
{
    public class Tiket
    {
        [Key]
        public string IdTiket { get; set; }
        public Pelanggan KodeKodePelanggan { get; set; }
        public Kereta IdIdKereta { get; set; }
        public KelasKereta NamaKelas { get; set; }
    }
}

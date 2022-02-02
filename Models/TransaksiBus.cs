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
        public string IdTr { get; set; }
        public Pelanggan IdPelanggan { get; set; }
        public Bus Bus { get; set; }
        public DateTime TanggalBerangkat { get; set; }
        public int harga { get; set; }
    }
}

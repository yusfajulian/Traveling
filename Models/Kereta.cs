using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Travelingyu.Models
{
    public class Kereta
    {
        [Key]
        public string IdKereta { get; set; }
        public string NamaKereta { get; set; }
        public string Berangkat { get; set; }
        public string Tiba { get; set; } 
        public string Dari { get; set; }
        public string Ke { get; set; }
        public int Harga { get; set; }
    }
}

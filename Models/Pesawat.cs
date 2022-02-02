﻿using System;
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
        public Maskapai Maskapai { get; set; }
        public string Dari { get; set; }
        public string Ke { get; set; }
        public int Kursi { get; set; }
        public int harga { get; set; }
    }
}

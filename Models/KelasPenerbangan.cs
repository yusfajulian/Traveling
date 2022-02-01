using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Travelingyu.Models
{
    public class KelasPenerbangan
    {
        [Key]
        public string NamaKelas { get; set; }
        public bool Chathring { get; set; }
        public int Harga { get; set; }
    }
}

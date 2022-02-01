using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Travelingyu.Models
{
    public class Tujuan
    {
        [Key]
        public string IdTujuan { get; set; }
        public string NamaTujuan { get; set; }
        public string Jenis { get; set; }
    }
}

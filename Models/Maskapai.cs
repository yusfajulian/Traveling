using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Travelingyu.Models
{
    public class Maskapai
    {
        [Key]
        public string IdMaskapai { get; set; }
        public string NamaMaskapai { get; set; }
    }
}

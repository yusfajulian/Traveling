using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Travelingyu.Models
{
    public class Bus
    {
        [Key]
        public string KodeBus { get; set; }
        public string NamaSup { get; set; }
        public string Dari { get; set; }
        public string Ke { get; set; }
        public string Harga { get; set; }
    }   
}

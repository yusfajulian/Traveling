using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Travelingyu.Models
{
    public class Pelanggan
    {
        [Key]
        public string KodePelanggan { get; set; }
        public string NamaPelanggan { get; set; }
        public string JenisKelamin { get; set; }
        public string DaerahAsal { get; set; }
        public string NomorKtp { get; set; }
        public string Propesi { get; set; }
        public string NomorTelpon { get; set; }
        public string Type { get; set; }
    }
}

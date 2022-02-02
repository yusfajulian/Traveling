using Microsoft.EntityFrameworkCore;
using Travelingyu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Travelingyu.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
          : base(options)
        {
            // Kosong
        }

        public virtual DbSet<Pelanggan> Tb_Pelanggan { get; set; }
        public virtual DbSet<Kelas> Tb_Kelas { get; set; }
        public virtual DbSet<Bus> Tb_Bus { get; set; }
        public virtual DbSet<TransaksiBus> TransaksiBuss { get; set; }
        public virtual DbSet<Pesawat> Tb_Pesawat { get; set; }
        public virtual DbSet<Pemesanan> Tb_TransaksiPesawat { get; set; }
        public virtual DbSet<Maskapai> Tb_Maskapai { get; set; }
        public virtual DbSet<Kereta> Tb_Kereta { get; set; }
        public virtual DbSet<Tiket> Tb_TransaksiKereta { get; set; }
        public virtual DbSet<Roles> Tb_Roles{ get; set; }
        public virtual DbSet<User> Tb_User { get; set; }
    }
}
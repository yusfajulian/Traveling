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

        public virtual DbSet<Pelanggan> Tb_Pelanggan { get; set; }    // Tb_Blog adalah nama tabelnya
        public virtual DbSet<Pesawat> Tb_Pesawat { get; set; }
        public virtual DbSet<KelasPenerbangan> Tb_Kelas { get; set; }
        public virtual DbSet<Pemesanan> Tb_Transaksi { get; set; }
        public virtual DbSet<Kereta> Tb_Kereta { get; set; }
        public virtual DbSet<Bus> Tb_Bus { get; set; }
        public virtual DbSet<KelasKereta> Tb_KelasKereta{ get; set; }
        public virtual DbSet<Tiket> Tb_TiketKA { get; set; }
        public virtual DbSet<Tujuan> Tb_Tujuan { get; set; }
        public virtual DbSet<Roles> Tb_Roles{ get; set; }
        public virtual DbSet<User> Tb_User { get; set; }
        public virtual DbSet<TrBus> Tb_TransaksiBus { get; set; }
    }
}
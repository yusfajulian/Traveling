using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace Travelingyu.Migrations
{
    public partial class User : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tb_Bus",
                columns: table => new
                {
                    KodeBus = table.Column<string>(type: "varchar(767)", nullable: false),
                    NamaSup = table.Column<string>(type: "text", nullable: true),
                    Dari = table.Column<string>(type: "text", nullable: true),
                    Ke = table.Column<string>(type: "text", nullable: true),
                    Harga = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Bus", x => x.KodeBus);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Kelas",
                columns: table => new
                {
                    NamaKelas = table.Column<string>(type: "varchar(767)", nullable: false),
                    Chathring = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Harga = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Kelas", x => x.NamaKelas);
                });

            migrationBuilder.CreateTable(
                name: "Tb_KelasKereta",
                columns: table => new
                {
                    NamaKelas = table.Column<string>(type: "varchar(767)", nullable: false),
                    Chathring = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Kursi = table.Column<int>(type: "int", nullable: false),
                    Harga = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_KelasKereta", x => x.NamaKelas);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Kereta",
                columns: table => new
                {
                    IdKereta = table.Column<string>(type: "varchar(767)", nullable: false),
                    NamaKereta = table.Column<string>(type: "text", nullable: true),
                    Berangkat = table.Column<string>(type: "text", nullable: true),
                    Tiba = table.Column<string>(type: "text", nullable: true),
                    Dari = table.Column<string>(type: "text", nullable: true),
                    Ke = table.Column<string>(type: "text", nullable: true),
                    Harga = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Kereta", x => x.IdKereta);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Pelanggan",
                columns: table => new
                {
                    KodePelanggan = table.Column<string>(type: "varchar(767)", nullable: false),
                    NamaPelanggan = table.Column<string>(type: "text", nullable: true),
                    JenisKelamin = table.Column<string>(type: "text", nullable: true),
                    DaerahAsal = table.Column<string>(type: "text", nullable: true),
                    NomorKtp = table.Column<string>(type: "text", nullable: true),
                    Propesi = table.Column<string>(type: "text", nullable: true),
                    NomorTelpon = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Pelanggan", x => x.KodePelanggan);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Pesawat",
                columns: table => new
                {
                    KodePesawat = table.Column<string>(type: "varchar(767)", nullable: false),
                    NamaMaskapai = table.Column<string>(type: "text", nullable: true),
                    JenisPesawat = table.Column<string>(type: "text", nullable: true),
                    Kursi = table.Column<int>(type: "int", nullable: false),
                    WaktuKeberangkatan = table.Column<DateTime>(type: "datetime", nullable: false),
                    Tujuan = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Pesawat", x => x.KodePesawat);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(767)", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Tujuan",
                columns: table => new
                {
                    IdTujuan = table.Column<string>(type: "varchar(767)", nullable: false),
                    NamaTujuan = table.Column<string>(type: "text", nullable: true),
                    Jenis = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Tujuan", x => x.IdTujuan);
                });

            migrationBuilder.CreateTable(
                name: "Tb_TiketKA",
                columns: table => new
                {
                    IdTiket = table.Column<string>(type: "varchar(767)", nullable: false),
                    KodeKodePelangganKodePelanggan = table.Column<string>(type: "varchar(767)", nullable: true),
                    IdIdKeretaIdKereta = table.Column<string>(type: "varchar(767)", nullable: true),
                    NamaKelas1 = table.Column<string>(type: "varchar(767)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_TiketKA", x => x.IdTiket);
                    table.ForeignKey(
                        name: "FK_Tb_TiketKA_Tb_KelasKereta_NamaKelas1",
                        column: x => x.NamaKelas1,
                        principalTable: "Tb_KelasKereta",
                        principalColumn: "NamaKelas",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tb_TiketKA_Tb_Kereta_IdIdKeretaIdKereta",
                        column: x => x.IdIdKeretaIdKereta,
                        principalTable: "Tb_Kereta",
                        principalColumn: "IdKereta",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tb_TiketKA_Tb_Pelanggan_KodeKodePelangganKodePelanggan",
                        column: x => x.KodeKodePelangganKodePelanggan,
                        principalTable: "Tb_Pelanggan",
                        principalColumn: "KodePelanggan",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tb_TrBus",
                columns: table => new
                {
                    NoTransaksi = table.Column<string>(type: "varchar(767)", nullable: false),
                    KodeBus1 = table.Column<string>(type: "varchar(767)", nullable: true),
                    KodePelanggan1 = table.Column<string>(type: "varchar(767)", nullable: true),
                    Jumlah = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_TrBus", x => x.NoTransaksi);
                    table.ForeignKey(
                        name: "FK_Tb_TrBus_Tb_Bus_KodeBus1",
                        column: x => x.KodeBus1,
                        principalTable: "Tb_Bus",
                        principalColumn: "KodeBus",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tb_TrBus_Tb_Pelanggan_KodePelanggan1",
                        column: x => x.KodePelanggan1,
                        principalTable: "Tb_Pelanggan",
                        principalColumn: "KodePelanggan",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Transaksi",
                columns: table => new
                {
                    KodeTiket = table.Column<string>(type: "varchar(767)", nullable: false),
                    KodePesawat = table.Column<string>(type: "varchar(767)", nullable: true),
                    KodePelanggan1 = table.Column<string>(type: "varchar(767)", nullable: true),
                    DaerahAsal = table.Column<string>(type: "text", nullable: true),
                    WaktuKeberangkatan = table.Column<DateTime>(type: "datetime", nullable: false),
                    Tujuan = table.Column<string>(type: "text", nullable: true),
                    NamaMaskapai = table.Column<string>(type: "text", nullable: true),
                    NamaKelas1 = table.Column<string>(type: "varchar(767)", nullable: true),
                    NamaPelanggan = table.Column<string>(type: "text", nullable: true),
                    NomorTelp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Transaksi", x => x.KodeTiket);
                    table.ForeignKey(
                        name: "FK_Tb_Transaksi_Tb_Kelas_NamaKelas1",
                        column: x => x.NamaKelas1,
                        principalTable: "Tb_Kelas",
                        principalColumn: "NamaKelas",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tb_Transaksi_Tb_Pelanggan_KodePelanggan1",
                        column: x => x.KodePelanggan1,
                        principalTable: "Tb_Pelanggan",
                        principalColumn: "KodePelanggan",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tb_Transaksi_Tb_Pesawat_KodePesawat",
                        column: x => x.KodePesawat,
                        principalTable: "Tb_Pesawat",
                        principalColumn: "KodePesawat",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tb_User",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    RolesId = table.Column<string>(type: "varchar(767)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_User", x => x.id);
                    table.ForeignKey(
                        name: "FK_Tb_User_Tb_Roles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Tb_Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tb_TiketKA_IdIdKeretaIdKereta",
                table: "Tb_TiketKA",
                column: "IdIdKeretaIdKereta");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_TiketKA_KodeKodePelangganKodePelanggan",
                table: "Tb_TiketKA",
                column: "KodeKodePelangganKodePelanggan");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_TiketKA_NamaKelas1",
                table: "Tb_TiketKA",
                column: "NamaKelas1");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Transaksi_KodePelanggan1",
                table: "Tb_Transaksi",
                column: "KodePelanggan1");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Transaksi_KodePesawat",
                table: "Tb_Transaksi",
                column: "KodePesawat");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Transaksi_NamaKelas1",
                table: "Tb_Transaksi",
                column: "NamaKelas1");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_TrBus_KodeBus1",
                table: "Tb_TrBus",
                column: "KodeBus1");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_TrBus_KodePelanggan1",
                table: "Tb_TrBus",
                column: "KodePelanggan1");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_User_RolesId",
                table: "Tb_User",
                column: "RolesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_TiketKA");

            migrationBuilder.DropTable(
                name: "Tb_Transaksi");

            migrationBuilder.DropTable(
                name: "Tb_TrBus");

            migrationBuilder.DropTable(
                name: "Tb_Tujuan");

            migrationBuilder.DropTable(
                name: "Tb_User");

            migrationBuilder.DropTable(
                name: "Tb_KelasKereta");

            migrationBuilder.DropTable(
                name: "Tb_Kereta");

            migrationBuilder.DropTable(
                name: "Tb_Kelas");

            migrationBuilder.DropTable(
                name: "Tb_Pesawat");

            migrationBuilder.DropTable(
                name: "Tb_Bus");

            migrationBuilder.DropTable(
                name: "Tb_Pelanggan");

            migrationBuilder.DropTable(
                name: "Tb_Roles");
        }
    }
}

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
                    Harga = table.Column<int>(type: "int", nullable: false)
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
                name: "Tb_Kereta",
                columns: table => new
                {
                    IdKereta = table.Column<string>(type: "varchar(767)", nullable: false),
                    NamaKereta = table.Column<string>(type: "text", nullable: true),
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
                name: "Tb_Maskapai",
                columns: table => new
                {
                    IdMaskapai = table.Column<string>(type: "varchar(767)", nullable: false),
                    NamaMaskapai = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Maskapai", x => x.IdMaskapai);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Pelanggan",
                columns: table => new
                {
                    KodePelanggan = table.Column<string>(type: "varchar(767)", nullable: false),
                    NamaPelanggan = table.Column<string>(type: "text", nullable: false),
                    JenisKelamin = table.Column<string>(type: "text", nullable: false),
                    DaerahAsal = table.Column<string>(type: "text", nullable: false),
                    NomorKtp = table.Column<string>(type: "text", nullable: false),
                    NomorTelpon = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Pelanggan", x => x.KodePelanggan);
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
                name: "Tb_Pesawat",
                columns: table => new
                {
                    KodePesawat = table.Column<string>(type: "varchar(767)", nullable: false),
                    MaskapaiIdMaskapai = table.Column<string>(type: "varchar(767)", nullable: true),
                    Dari = table.Column<string>(type: "text", nullable: true),
                    Ke = table.Column<string>(type: "text", nullable: true),
                    Kursi = table.Column<int>(type: "int", nullable: false),
                    harga = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Pesawat", x => x.KodePesawat);
                    table.ForeignKey(
                        name: "FK_Tb_Pesawat_Tb_Maskapai_MaskapaiIdMaskapai",
                        column: x => x.MaskapaiIdMaskapai,
                        principalTable: "Tb_Maskapai",
                        principalColumn: "IdMaskapai",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tb_TransaksiKereta",
                columns: table => new
                {
                    IdTiket = table.Column<string>(type: "varchar(767)", nullable: false),
                    KodeKodePelangganKodePelanggan = table.Column<string>(type: "varchar(767)", nullable: true),
                    KeretaIdKereta = table.Column<string>(type: "varchar(767)", nullable: true),
                    KelasNamaKelas = table.Column<string>(type: "varchar(767)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_TransaksiKereta", x => x.IdTiket);
                    table.ForeignKey(
                        name: "FK_Tb_TransaksiKereta_Tb_Kelas_KelasNamaKelas",
                        column: x => x.KelasNamaKelas,
                        principalTable: "Tb_Kelas",
                        principalColumn: "NamaKelas",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tb_TransaksiKereta_Tb_Kereta_KeretaIdKereta",
                        column: x => x.KeretaIdKereta,
                        principalTable: "Tb_Kereta",
                        principalColumn: "IdKereta",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tb_TransaksiKereta_Tb_Pelanggan_KodeKodePelangganKodePelangg~",
                        column: x => x.KodeKodePelangganKodePelanggan,
                        principalTable: "Tb_Pelanggan",
                        principalColumn: "KodePelanggan",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TransaksiBuss",
                columns: table => new
                {
                    IdTr = table.Column<string>(type: "varchar(767)", nullable: false),
                    IdPelangganKodePelanggan = table.Column<string>(type: "varchar(767)", nullable: true),
                    BusKodeBus = table.Column<string>(type: "varchar(767)", nullable: true),
                    TanggalBerangkat = table.Column<DateTime>(type: "datetime", nullable: false),
                    harga = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransaksiBuss", x => x.IdTr);
                    table.ForeignKey(
                        name: "FK_TransaksiBuss_Tb_Bus_BusKodeBus",
                        column: x => x.BusKodeBus,
                        principalTable: "Tb_Bus",
                        principalColumn: "KodeBus",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransaksiBuss_Tb_Pelanggan_IdPelangganKodePelanggan",
                        column: x => x.IdPelangganKodePelanggan,
                        principalTable: "Tb_Pelanggan",
                        principalColumn: "KodePelanggan",
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

            migrationBuilder.CreateTable(
                name: "Tb_TransaksiPesawat",
                columns: table => new
                {
                    KodeTiket = table.Column<string>(type: "varchar(767)", nullable: false),
                    KodePelanggan1 = table.Column<string>(type: "varchar(767)", nullable: true),
                    WaktuKeberangkatan = table.Column<DateTime>(type: "datetime", nullable: false),
                    PesawatKodePesawat = table.Column<string>(type: "varchar(767)", nullable: true),
                    MaskapaiIdMaskapai = table.Column<string>(type: "varchar(767)", nullable: true),
                    NamaKelas1 = table.Column<string>(type: "varchar(767)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_TransaksiPesawat", x => x.KodeTiket);
                    table.ForeignKey(
                        name: "FK_Tb_TransaksiPesawat_Tb_Kelas_NamaKelas1",
                        column: x => x.NamaKelas1,
                        principalTable: "Tb_Kelas",
                        principalColumn: "NamaKelas",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tb_TransaksiPesawat_Tb_Maskapai_MaskapaiIdMaskapai",
                        column: x => x.MaskapaiIdMaskapai,
                        principalTable: "Tb_Maskapai",
                        principalColumn: "IdMaskapai",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tb_TransaksiPesawat_Tb_Pelanggan_KodePelanggan1",
                        column: x => x.KodePelanggan1,
                        principalTable: "Tb_Pelanggan",
                        principalColumn: "KodePelanggan",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tb_TransaksiPesawat_Tb_Pesawat_PesawatKodePesawat",
                        column: x => x.PesawatKodePesawat,
                        principalTable: "Tb_Pesawat",
                        principalColumn: "KodePesawat",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Pesawat_MaskapaiIdMaskapai",
                table: "Tb_Pesawat",
                column: "MaskapaiIdMaskapai");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_TransaksiKereta_KelasNamaKelas",
                table: "Tb_TransaksiKereta",
                column: "KelasNamaKelas");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_TransaksiKereta_KeretaIdKereta",
                table: "Tb_TransaksiKereta",
                column: "KeretaIdKereta");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_TransaksiKereta_KodeKodePelangganKodePelanggan",
                table: "Tb_TransaksiKereta",
                column: "KodeKodePelangganKodePelanggan");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_TransaksiPesawat_KodePelanggan1",
                table: "Tb_TransaksiPesawat",
                column: "KodePelanggan1");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_TransaksiPesawat_MaskapaiIdMaskapai",
                table: "Tb_TransaksiPesawat",
                column: "MaskapaiIdMaskapai");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_TransaksiPesawat_NamaKelas1",
                table: "Tb_TransaksiPesawat",
                column: "NamaKelas1");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_TransaksiPesawat_PesawatKodePesawat",
                table: "Tb_TransaksiPesawat",
                column: "PesawatKodePesawat");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_User_RolesId",
                table: "Tb_User",
                column: "RolesId");

            migrationBuilder.CreateIndex(
                name: "IX_TransaksiBuss_BusKodeBus",
                table: "TransaksiBuss",
                column: "BusKodeBus");

            migrationBuilder.CreateIndex(
                name: "IX_TransaksiBuss_IdPelangganKodePelanggan",
                table: "TransaksiBuss",
                column: "IdPelangganKodePelanggan");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_TransaksiKereta");

            migrationBuilder.DropTable(
                name: "Tb_TransaksiPesawat");

            migrationBuilder.DropTable(
                name: "Tb_User");

            migrationBuilder.DropTable(
                name: "TransaksiBuss");

            migrationBuilder.DropTable(
                name: "Tb_Kereta");

            migrationBuilder.DropTable(
                name: "Tb_Kelas");

            migrationBuilder.DropTable(
                name: "Tb_Pesawat");

            migrationBuilder.DropTable(
                name: "Tb_Roles");

            migrationBuilder.DropTable(
                name: "Tb_Bus");

            migrationBuilder.DropTable(
                name: "Tb_Pelanggan");

            migrationBuilder.DropTable(
                name: "Tb_Maskapai");
        }
    }
}

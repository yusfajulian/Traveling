-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 04 Feb 2022 pada 16.39
-- Versi server: 10.4.17-MariaDB
-- Versi PHP: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_travelingyuk`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_bus`
--

CREATE TABLE `tb_bus` (
  `KodeBus` varchar(767) NOT NULL,
  `NamaSup` varchar(767) DEFAULT NULL,
  `Dari` varchar(767) DEFAULT NULL,
  `Ke` varchar(767) DEFAULT NULL,
  `Harga` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tb_bus`
--

INSERT INTO `tb_bus` (`KodeBus`, `NamaSup`, `Dari`, `Ke`, `Harga`) VALUES
('B01', 'Bayu', 'Bandung', 'Yogyakarta', 300000),
('B02', 'Anam', 'Bandung', 'Jakarta', 175000),
('B03', 'Maman', 'Bandung', 'Surabaya', 188000),
('B04', 'mae', 'Bandung', 'Malang', 170000),
('B05', 'Abdul', 'Bandung', 'Semarang', 75000),
('B06', 'Nana', 'Bandung', 'Palembang', 455000),
('B07', 'assa', 'Bandung', 'Pekanbaru', 600000),
('B08', 'ana', 'Bandung', 'Lampung', 400000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_kelas`
--

CREATE TABLE `tb_kelas` (
  `NamaKelas` varchar(767) NOT NULL,
  `Chathring` tinyint(1) NOT NULL,
  `Harga` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_kereta`
--

CREATE TABLE `tb_kereta` (
  `IdKereta` varchar(767) NOT NULL,
  `NamaKereta` text DEFAULT NULL,
  `Tiba` text DEFAULT NULL,
  `Dari` text DEFAULT NULL,
  `Ke` text DEFAULT NULL,
  `Harga` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tb_kereta`
--

INSERT INTO `tb_kereta` (`IdKereta`, `NamaKereta`, `Tiba`, `Dari`, `Ke`, `Harga`) VALUES
('K001', 'Serayu', '08:00', 'Bandung', 'Solo', 890000),
('K002', 'Serayu', '10:00', 'Bandung', 'Banyumas', 85000),
('K003', 'Serayu', '13:00', 'Bandung', 'Jakarta', 40000),
('K004', 'Serayu', '15:00', 'Bandung', 'Garut', 50000),
('K005', 'Serayu', '19:40', 'Bandung', 'Cirebon', 75000),
('K006', 'Argo Parahyangan', '08:00', 'Bandung', 'Cilacap', 85000),
('K007', 'Argo Parahyangan', '10:00', 'Bandung', 'Yogyakarta', 190000),
('K008', 'Argo Parahyangan', '13:00', 'Bandung', 'Malang', 190000),
('K009', 'Argo Parahyangan', '15:00', 'Bandung', 'Purwakarta', 100000),
('K010', 'Argo Parahyangan', '19:40', 'Bandung', 'Surabaya', 160000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_maskapai`
--

CREATE TABLE `tb_maskapai` (
  `IdMaskapai` varchar(767) NOT NULL,
  `NamaMaskapai` varchar(767) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tb_maskapai`
--

INSERT INTO `tb_maskapai` (`IdMaskapai`, `NamaMaskapai`) VALUES
('M001', 'Garuda'),
('M002', 'Citilink'),
('M003', 'Air Asia'),
('M004', 'Lion Air'),
('M005', 'Batik Air');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_pelanggan`
--

CREATE TABLE `tb_pelanggan` (
  `KodePelanggan` varchar(767) NOT NULL,
  `NamaPelanggan` text NOT NULL,
  `JenisKelamin` text NOT NULL,
  `DaerahAsal` text NOT NULL,
  `NomorKtp` text NOT NULL,
  `NomorTelpon` text NOT NULL,
  `Type` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tb_pelanggan`
--

INSERT INTO `tb_pelanggan` (`KodePelanggan`, `NamaPelanggan`, `JenisKelamin`, `DaerahAsal`, `NomorKtp`, `NomorTelpon`, `Type`) VALUES
('121343543463', 'Bayu', 'Pria', 'Banyumas', '121343543463', '08127168', 'Bus'),
('1231', 'Agus', 'Pria', 'Banyumas', '1231', '08127168', 'Kereta'),
('32171516070100101', 'Yusfa Julian', 'Pria', 'KBB', '32171516070100101', '082218050900', 'Pesawat');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_pesawat`
--

CREATE TABLE `tb_pesawat` (
  `KodePesawat` varchar(767) NOT NULL,
  `MaskapaiIdMaskapai` varchar(767) DEFAULT NULL,
  `Dari` varchar(767) DEFAULT NULL,
  `Ke` varchar(767) DEFAULT NULL,
  `Kursi` int(11) NOT NULL,
  `harga` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tb_pesawat`
--

INSERT INTO `tb_pesawat` (`KodePesawat`, `MaskapaiIdMaskapai`, `Dari`, `Ke`, `Kursi`, `harga`) VALUES
('P0010', 'M005', 'Soekarno Hatta', 'Sultan Mahmud Badarudin 2', 550, 405000),
('P0011', 'M005', 'Soekarno Hatta', 'Syamsudin Noor', 550, 843000),
('P002', 'M002', 'Soekarno Hatta', 'Kualanamu', 500, 678000),
('P003', 'M002', 'Soekarno Hatta', 'Husein Sastranegara', 500, 1100000),
('P004', 'M001', 'Soekarno Hatta', 'Sultan Syarif Kasim II', 500, 620000),
('P005', 'M001', 'Soekarno Hatta', 'Ngurah Rai', 500, 550000),
('P006', 'M003', 'Soekarno Hatta', 'Juanda', 450, 635000),
('P007', 'M003', 'Soekarno Hatta', 'Sultan Hasanudin', 450, 770000),
('P008', 'M004', 'Soekarno Hatta', 'Sultan Aji Muhammad sulaiman', 450, 919000),
('P009', 'M004', 'Soekarno Hatta', 'Adisutjipto', 550, 446000),
('P012', 'M002', 'Husein Sastranegara Hatta', 'Kualanamu', 500, 908000),
('P013', 'M002', 'Husein Sastranegara Hatta', 'Soekarno Hatta', 500, 1200000),
('P014', 'M001', 'Husein Sastranegara Hatta', 'Sultan Syarif Kasim II', 500, 670000),
('P015', 'M001', 'Husein Sastranegara Hatta', 'Ngurah Rai', 500, 570000),
('P016', 'M003', 'Husein Sastranegara Hatta', 'Juanda', 450, 735000),
('P017', 'M003', 'Husein Sastranegara Hatta', 'Sultan Hasanudin', 450, 870000),
('P018', 'M004', 'Husein Sastranegara Hatta', 'Sultan Aji Muhammad sulaiman', 450, 909000),
('P019', 'M004', 'Husein Sastranegara Hatta', 'Adisutjipto', 550, 446000),
('P020', 'M005', 'Husein Sastranegara Hatta', 'Sultan Mahmud Badarudin 2', 550, 405000),
('P021', 'M005', 'Husein Sastranegara Hatta', 'Syamsudin Noor', 550, 843000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_roles`
--

CREATE TABLE `tb_roles` (
  `Id` varchar(767) NOT NULL,
  `Name` varchar(767) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tb_roles`
--

INSERT INTO `tb_roles` (`Id`, `Name`) VALUES
('1', 'User'),
('2', 'Admin');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_transaksikereta`
--

CREATE TABLE `tb_transaksikereta` (
  `IdTiket` varchar(767) NOT NULL,
  `KodeKodePelangganKodePelanggan` varchar(767) DEFAULT NULL,
  `KeretaIdKereta` varchar(767) DEFAULT NULL,
  `KelasNamaKelas` varchar(767) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_transaksipesawat`
--

CREATE TABLE `tb_transaksipesawat` (
  `KodeTiket` int(15) NOT NULL,
  `KodePelanggan1` varchar(767) DEFAULT NULL,
  `WaktuKeberangkatan` datetime NOT NULL,
  `PesawatKodePesawat` varchar(767) DEFAULT NULL,
  `MaskapaiIdMaskapai` varchar(767) DEFAULT NULL,
  `NamaKelas1` varchar(767) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_user`
--

CREATE TABLE `tb_user` (
  `id` int(11) NOT NULL,
  `Username` text NOT NULL,
  `Password` text NOT NULL,
  `Name` text NOT NULL,
  `Email` text NOT NULL,
  `RolesId` varchar(767) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tb_user`
--

INSERT INTO `tb_user` (`id`, `Username`, `Password`, `Name`, `Email`, `RolesId`) VALUES
(1, 'YusfaJulian', '160701', 'Yusfa Julian', 'yusfajulian44@gmail.com', '2'),
(2, 'Bayu', '12', 'Bayu Wijiana', 'bayu44@gmail.com', '1'),
(5, 'Uye', '15', 'Yusfa Julian', 'yusfajulian44@gmail.com', '1');

-- --------------------------------------------------------

--
-- Struktur dari tabel `transaksibuss`
--

CREATE TABLE `transaksibuss` (
  `IdTr` int(15) NOT NULL,
  `IdPelangganKodePelanggan` varchar(767) DEFAULT NULL,
  `BusKodeBus` varchar(767) DEFAULT NULL,
  `TanggalBerangkat` datetime NOT NULL,
  `harga` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `transaksibuss`
--

INSERT INTO `transaksibuss` (`IdTr`, `IdPelangganKodePelanggan`, `BusKodeBus`, `TanggalBerangkat`, `harga`) VALUES
(1, NULL, NULL, '0001-01-01 00:00:00', 0),
(2, NULL, NULL, '0001-01-01 00:00:00', 0),
(3, NULL, NULL, '0001-01-01 00:00:00', 0);

-- --------------------------------------------------------

--
-- Struktur dari tabel `__efmigrationshistory`
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20220202122416_User', '5.0.13');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tb_bus`
--
ALTER TABLE `tb_bus`
  ADD PRIMARY KEY (`KodeBus`);

--
-- Indeks untuk tabel `tb_kelas`
--
ALTER TABLE `tb_kelas`
  ADD PRIMARY KEY (`NamaKelas`);

--
-- Indeks untuk tabel `tb_kereta`
--
ALTER TABLE `tb_kereta`
  ADD PRIMARY KEY (`IdKereta`);

--
-- Indeks untuk tabel `tb_maskapai`
--
ALTER TABLE `tb_maskapai`
  ADD PRIMARY KEY (`IdMaskapai`);

--
-- Indeks untuk tabel `tb_pelanggan`
--
ALTER TABLE `tb_pelanggan`
  ADD PRIMARY KEY (`KodePelanggan`);

--
-- Indeks untuk tabel `tb_pesawat`
--
ALTER TABLE `tb_pesawat`
  ADD PRIMARY KEY (`KodePesawat`),
  ADD KEY `IX_Tb_Pesawat_MaskapaiIdMaskapai` (`MaskapaiIdMaskapai`);

--
-- Indeks untuk tabel `tb_roles`
--
ALTER TABLE `tb_roles`
  ADD PRIMARY KEY (`Id`);

--
-- Indeks untuk tabel `tb_transaksikereta`
--
ALTER TABLE `tb_transaksikereta`
  ADD PRIMARY KEY (`IdTiket`),
  ADD KEY `IX_Tb_TransaksiKereta_KelasNamaKelas` (`KelasNamaKelas`),
  ADD KEY `IX_Tb_TransaksiKereta_KeretaIdKereta` (`KeretaIdKereta`),
  ADD KEY `IX_Tb_TransaksiKereta_KodeKodePelangganKodePelanggan` (`KodeKodePelangganKodePelanggan`);

--
-- Indeks untuk tabel `tb_transaksipesawat`
--
ALTER TABLE `tb_transaksipesawat`
  ADD PRIMARY KEY (`KodeTiket`),
  ADD KEY `IX_Tb_TransaksiPesawat_KodePelanggan1` (`KodePelanggan1`),
  ADD KEY `IX_Tb_TransaksiPesawat_MaskapaiIdMaskapai` (`MaskapaiIdMaskapai`),
  ADD KEY `IX_Tb_TransaksiPesawat_NamaKelas1` (`NamaKelas1`),
  ADD KEY `IX_Tb_TransaksiPesawat_PesawatKodePesawat` (`PesawatKodePesawat`);

--
-- Indeks untuk tabel `tb_user`
--
ALTER TABLE `tb_user`
  ADD PRIMARY KEY (`id`),
  ADD KEY `IX_Tb_User_RolesId` (`RolesId`);

--
-- Indeks untuk tabel `transaksibuss`
--
ALTER TABLE `transaksibuss`
  ADD PRIMARY KEY (`IdTr`),
  ADD KEY `IX_TransaksiBuss_BusKodeBus` (`BusKodeBus`),
  ADD KEY `IX_TransaksiBuss_IdPelangganKodePelanggan` (`IdPelangganKodePelanggan`);

--
-- Indeks untuk tabel `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `tb_transaksipesawat`
--
ALTER TABLE `tb_transaksipesawat`
  MODIFY `KodeTiket` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT untuk tabel `tb_user`
--
ALTER TABLE `tb_user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT untuk tabel `transaksibuss`
--
ALTER TABLE `transaksibuss`
  MODIFY `IdTr` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `tb_pesawat`
--
ALTER TABLE `tb_pesawat`
  ADD CONSTRAINT `FK_Tb_Pesawat_Tb_Maskapai_MaskapaiIdMaskapai` FOREIGN KEY (`MaskapaiIdMaskapai`) REFERENCES `tb_maskapai` (`IdMaskapai`);

--
-- Ketidakleluasaan untuk tabel `tb_transaksikereta`
--
ALTER TABLE `tb_transaksikereta`
  ADD CONSTRAINT `FK_Tb_TransaksiKereta_Tb_Kelas_KelasNamaKelas` FOREIGN KEY (`KelasNamaKelas`) REFERENCES `tb_kelas` (`NamaKelas`),
  ADD CONSTRAINT `FK_Tb_TransaksiKereta_Tb_Kereta_KeretaIdKereta` FOREIGN KEY (`KeretaIdKereta`) REFERENCES `tb_kereta` (`IdKereta`),
  ADD CONSTRAINT `FK_Tb_TransaksiKereta_Tb_Pelanggan_KodeKodePelangganKodePelangg~` FOREIGN KEY (`KodeKodePelangganKodePelanggan`) REFERENCES `tb_pelanggan` (`KodePelanggan`);

--
-- Ketidakleluasaan untuk tabel `tb_transaksipesawat`
--
ALTER TABLE `tb_transaksipesawat`
  ADD CONSTRAINT `FK_Tb_TransaksiPesawat_Tb_Kelas_NamaKelas1` FOREIGN KEY (`NamaKelas1`) REFERENCES `tb_kelas` (`NamaKelas`),
  ADD CONSTRAINT `FK_Tb_TransaksiPesawat_Tb_Maskapai_MaskapaiIdMaskapai` FOREIGN KEY (`MaskapaiIdMaskapai`) REFERENCES `tb_maskapai` (`IdMaskapai`),
  ADD CONSTRAINT `FK_Tb_TransaksiPesawat_Tb_Pelanggan_KodePelanggan1` FOREIGN KEY (`KodePelanggan1`) REFERENCES `tb_pelanggan` (`KodePelanggan`),
  ADD CONSTRAINT `FK_Tb_TransaksiPesawat_Tb_Pesawat_PesawatKodePesawat` FOREIGN KEY (`PesawatKodePesawat`) REFERENCES `tb_pesawat` (`KodePesawat`);

--
-- Ketidakleluasaan untuk tabel `tb_user`
--
ALTER TABLE `tb_user`
  ADD CONSTRAINT `FK_Tb_User_Tb_Roles_RolesId` FOREIGN KEY (`RolesId`) REFERENCES `tb_roles` (`Id`);

--
-- Ketidakleluasaan untuk tabel `transaksibuss`
--
ALTER TABLE `transaksibuss`
  ADD CONSTRAINT `FK_TransaksiBuss_Tb_Bus_BusKodeBus` FOREIGN KEY (`BusKodeBus`) REFERENCES `tb_bus` (`KodeBus`),
  ADD CONSTRAINT `FK_TransaksiBuss_Tb_Pelanggan_IdPelangganKodePelanggan` FOREIGN KEY (`IdPelangganKodePelanggan`) REFERENCES `tb_pelanggan` (`KodePelanggan`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

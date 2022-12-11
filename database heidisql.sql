-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               10.4.24-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win64
-- HeidiSQL Version:             12.1.0.6537
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dumping database structure for db_calvin
DROP DATABASE IF EXISTS `db_calvin`;
CREATE DATABASE IF NOT EXISTS `db_calvin` /*!40100 DEFAULT CHARACTER SET armscii8 COLLATE armscii8_bin */;
USE `db_calvin`;

-- Dumping structure for table db_calvin.tbl_barang
DROP TABLE IF EXISTS `tbl_barang`;
CREATE TABLE IF NOT EXISTS `tbl_barang` (
  `id_barang` int(11) NOT NULL AUTO_INCREMENT,
  `nama_barang` varchar(50) COLLATE armscii8_bin DEFAULT NULL,
  `kode_barang` varchar(50) COLLATE armscii8_bin DEFAULT NULL,
  `harga` varchar(50) COLLATE armscii8_bin DEFAULT NULL,
  `stok` varchar(50) COLLATE armscii8_bin DEFAULT NULL,
  PRIMARY KEY (`id_barang`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=armscii8 COLLATE=armscii8_bin;

-- Dumping data for table db_calvin.tbl_barang: ~1 rows (approximately)
DELETE FROM `tbl_barang`;
INSERT INTO `tbl_barang` (`id_barang`, `nama_barang`, `kode_barang`, `harga`, `stok`) VALUES
	(21, 'aqua', '123', '12000', '0');

-- Dumping structure for table db_calvin.tbl_customer
DROP TABLE IF EXISTS `tbl_customer`;
CREATE TABLE IF NOT EXISTS `tbl_customer` (
  `id_customer` int(11) NOT NULL AUTO_INCREMENT,
  `nama` varchar(50) COLLATE armscii8_bin DEFAULT NULL,
  `no_hp` varchar(50) COLLATE armscii8_bin DEFAULT NULL,
  `tgl_lahir` varchar(50) COLLATE armscii8_bin DEFAULT NULL,
  `jenis_kelamin` varchar(50) COLLATE armscii8_bin DEFAULT NULL,
  `membership` varchar(50) COLLATE armscii8_bin DEFAULT NULL,
  `alamat` varchar(50) COLLATE armscii8_bin DEFAULT NULL,
  `tempat_lahir` varchar(50) COLLATE armscii8_bin DEFAULT NULL,
  PRIMARY KEY (`id_customer`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=armscii8 COLLATE=armscii8_bin;

-- Dumping data for table db_calvin.tbl_customer: ~2 rows (approximately)
DELETE FROM `tbl_customer`;
INSERT INTO `tbl_customer` (`id_customer`, `nama`, `no_hp`, `tgl_lahir`, `jenis_kelamin`, `membership`, `alamat`, `tempat_lahir`) VALUES
	(16, 'calvin', '123', '2022-12-11', 'Perempuan', 'Premium', 'jalan asia', '123'),
	(17, 'audric', '123', '2022-12-11', 'Perempuan', 'Premium', 'jalan asia', '123');

-- Dumping structure for table db_calvin.tbl_transaksi
DROP TABLE IF EXISTS `tbl_transaksi`;
CREATE TABLE IF NOT EXISTS `tbl_transaksi` (
  `id_transaksi` int(11) NOT NULL AUTO_INCREMENT,
  `tanggal` varchar(50) COLLATE armscii8_bin DEFAULT NULL,
  `id_pelanggan` int(11) DEFAULT NULL,
  `nama_pelanggan` varchar(50) COLLATE armscii8_bin DEFAULT NULL,
  `total_transaksi` varchar(50) COLLATE armscii8_bin DEFAULT NULL,
  `pembayaran` varchar(50) COLLATE armscii8_bin DEFAULT NULL,
  PRIMARY KEY (`id_transaksi`)
) ENGINE=InnoDB AUTO_INCREMENT=53 DEFAULT CHARSET=armscii8 COLLATE=armscii8_bin;

-- Dumping data for table db_calvin.tbl_transaksi: ~1 rows (approximately)
DELETE FROM `tbl_transaksi`;
INSERT INTO `tbl_transaksi` (`id_transaksi`, `tanggal`, `id_pelanggan`, `nama_pelanggan`, `total_transaksi`, `pembayaran`) VALUES
	(52, '2022-12-11', 16, 'calvin', 'Rp. 129600', 'BCA');

-- Dumping structure for table db_calvin.tbl_user
DROP TABLE IF EXISTS `tbl_user`;
CREATE TABLE IF NOT EXISTS `tbl_user` (
  `username` varchar(50) DEFAULT NULL,
  `password` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Dumping data for table db_calvin.tbl_user: ~5 rows (approximately)
DELETE FROM `tbl_user`;
INSERT INTO `tbl_user` (`username`, `password`) VALUES
	('calvin', 'calvin123'),
	('audric', 'audric123'),
	('justin', 'justin123'),
	('chris', 'chris123'),
	('michael', 'michael123');

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;

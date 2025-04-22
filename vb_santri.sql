-- ----------------------------------------------
-- DATABASE & USE
-- ----------------------------------------------
CREATE DATABASE IF NOT EXISTS `vb_santri` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci;
USE `vb_santri`;

-- ----------------------------------------------
-- TABLE: roles
-- ----------------------------------------------
CREATE TABLE IF NOT EXISTS `roles` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nama` ENUM('santri','petugas','admin') NOT NULL,
  `deskripsi` TEXT,
  `created_at` TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `deleted_at` TIMESTAMP NULL DEFAULT NULL,
  PRIMARY KEY (`id`)
);

INSERT INTO `roles` (`id`, `nama`, `deskripsi`) VALUES
(1, 'santri', 'Pengguna yang berstatus santri'),
(2, 'petugas', 'Pengguna yang berstatus petugas'),
(3, 'admin', 'Pengguna dengan hak admin');

-- ----------------------------------------------
-- TABLE: kelas
-- ----------------------------------------------
CREATE TABLE IF NOT EXISTS `kelas` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nama` VARCHAR(255) NOT NULL,
  `deskripsi` TEXT,
  `created_at` TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `deleted_at` TIMESTAMP NULL DEFAULT NULL,
  PRIMARY KEY (`id`)
);

INSERT INTO `kelas` (`id`, `nama`, `deskripsi`) VALUES
(1, 'Kelas 1 SD', 'Kelas untuk tingkat 1 SD'),
(2, 'Kelas 2 SD', 'Kelas untuk tingkat 2 SD'),
(3, 'Kelas 3 SD', 'Kelas untuk tingkat 3 SD'),
(4, 'Kelas 4 SD', 'Kelas untuk tingkat 4 SD'),
(5, 'Kelas 5 SD', 'Kelas untuk tingkat 5 SD'),
(6, 'Kelas 6 SD', 'Kelas untuk tingkat 6 SD');

-- ----------------------------------------------
-- TABLE: users
-- ----------------------------------------------
CREATE TABLE IF NOT EXISTS `users` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nama` VARCHAR(255) NOT NULL,
  `nama_pengguna` VARCHAR(255) NOT NULL UNIQUE,
  `email` VARCHAR(255) NOT NULL UNIQUE,
  `kata_sandi` VARCHAR(255) NOT NULL,
  `nis` VARCHAR(50) UNIQUE,
  `kelas_id` INT DEFAULT NULL,
  `jenis_kelamin` ENUM('Laki-laki','Perempuan') NOT NULL,
  `tanggal_lahir` DATE DEFAULT NULL,
  `nama_ayah` VARCHAR(255),
  `nama_ibu` VARCHAR(255),
  `alamat` TEXT,
  `created_at` TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `deleted_at` TIMESTAMP NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY (`kelas_id`),
  FOREIGN KEY (`kelas_id`) REFERENCES `kelas` (`id`) ON DELETE SET NULL
);

INSERT INTO `users` (`id`, `nama`, `nama_pengguna`, `email`, `kata_sandi`, `jenis_kelamin`, `tanggal_lahir`, `nama_ayah`, `nama_ibu`, `alamat`)
VALUES
(1, 'Haddad Hikmah M', 'haddadhikmahm', 'haddadhikmahm@gmail.com', 'ef92b778bafe771e...', 'Laki-laki', '1995-06-15', 'Bapak Haddad', 'Ibu Haddad', 'Bandung'),
(2, 'Ikhsan Maulana Saputra', 'ikhsanmaulanasaputra', 'ikhsanmaulanasaputra@gmail.com', 'ef92b778bafe771e...', 'Laki-laki', '1995-06-15', 'Bapak Ikhsan', 'Ibu Ikhsan', 'Bandung'),
(3, 'Muhammad Sofyan', 'muhmmadsofyan', 'muhmmadsofyan@gmail.com', 'ef92b778bafe771e...', 'Laki-laki', '1995-06-15', 'Bapak Sofyan', 'Ibu Sofyan', 'Bandung');

-- ----------------------------------------------
-- TABLE: user_role
-- ----------------------------------------------
CREATE TABLE IF NOT EXISTS `user_role` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `user_id` INT NOT NULL,
  `role_id` INT NOT NULL,
  `created_at` TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `deleted_at` TIMESTAMP NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  FOREIGN KEY (`user_id`) REFERENCES `users` (`id`) ON DELETE CASCADE,
  FOREIGN KEY (`role_id`) REFERENCES `roles` (`id`) ON DELETE CASCADE
);
INSERT INTO `user_role` (`user_id`, `role_id`)
VALUES 
(1, 3), -- User 1 sebagai admin
(2, 2), -- User 2 sebagai petugas
(3, 1); -- User 3 sebagai santri


-- ----------------------------------------------
-- TABLE: perizinan
-- ----------------------------------------------
CREATE TABLE IF NOT EXISTS `perizinan` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `no_izin` VARCHAR(50) NOT NULL UNIQUE,
  `pengguna_id` INT NOT NULL,
  `tanggal_izin` DATE NOT NULL,
  `nama_penjemput` VARCHAR(255) NOT NULL,
  `tanggal_batas_izin` DATE NOT NULL,
  `tanggal_datang` DATE DEFAULT NULL,
  `status` ENUM('Dizinkan','Tidak Dizinkan') NOT NULL DEFAULT 'Tidak Dizinkan',
  `created_at` TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `deleted_at` TIMESTAMP NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  FOREIGN KEY (`pengguna_id`) REFERENCES `users` (`id`) ON DELETE CASCADE
);

-- ----------------------------------------------
-- TABLE: detail_perizinan
-- ----------------------------------------------
CREATE TABLE IF NOT EXISTS `detail_perizinan` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `no_izin` VARCHAR(50) NOT NULL,
  `hubungan` VARCHAR(255) NOT NULL,
  `keperluan` TEXT NOT NULL,
  `alamat_tujuan` TEXT NOT NULL,
  `created_at` TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `deleted_at` TIMESTAMP NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  FOREIGN KEY (`no_izin`) REFERENCES `perizinan` (`no_izin`) ON DELETE CASCADE
);

-- ----------------------------------------------
-- TABLE: transaksi
-- ----------------------------------------------
CREATE TABLE IF NOT EXISTS `transaksi` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `no_transaksi` VARCHAR(50) NOT NULL UNIQUE,
  `nama` VARCHAR(255) NOT NULL,
  `tanggal_transaksi` DATE NOT NULL,
  `type_pembayaran` ENUM('cash','bank') NOT NULL,
  `petugas_id` INT NOT NULL,
  `pengguna_id` INT NOT NULL,
  `created_at` TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `deleted_at` TIMESTAMP NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  FOREIGN KEY (`petugas_id`) REFERENCES `users` (`id`) ON DELETE CASCADE,
  FOREIGN KEY (`pengguna_id`) REFERENCES `users` (`id`) ON DELETE CASCADE
);

-- ----------------------------------------------
-- TABLE: detail_transaksi
-- ----------------------------------------------
CREATE TABLE IF NOT EXISTS `detail_transaksi` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `transaksi_id` INT NOT NULL,
  `jumlah` DECIMAL(15,2) DEFAULT '0.00',
  `type` ENUM('pemasukan','pengeluaran') NOT NULL,
  `saldo` DECIMAL(15,2) NOT NULL,
  `keterangan` TEXT,
  `created_at` TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `deleted_at` TIMESTAMP NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  FOREIGN KEY (`transaksi_id`) REFERENCES `transaksi` (`id`) ON DELETE CASCADE
);
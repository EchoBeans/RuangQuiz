-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 28, 2025 at 02:22 PM
-- Server version: 11.7.2-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `kuis_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `materi`
--

CREATE TABLE `materi` (
  `id` int(11) NOT NULL,
  `judul` varchar(150) NOT NULL,
  `deskripsi` varchar(255) NOT NULL,
  `link` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `materi`
--

INSERT INTO `materi` (`id`, `judul`, `deskripsi`, `link`) VALUES
(1, 'Database', 'Bab 1 Diagram ERD', 'https://repository.bsi.ac.id/repo/files/241229/download/360-P04.pdf'),
(3, 'Basis Data', 'Modul Basi Data', 'https://repository.nusamandiri.ac.id/repo/files/227362/download/Modul-SistemBasis-Data.pdf');

-- --------------------------------------------------------

--
-- Table structure for table `pengumpulan_tugas`
--

CREATE TABLE `pengumpulan_tugas` (
  `id_pengumpulan` int(11) NOT NULL,
  `id_tugas` int(11) DEFAULT NULL,
  `id_siswa` int(11) DEFAULT NULL,
  `link_pengumpulan` varchar(255) DEFAULT NULL,
  `nilai` int(11) DEFAULT NULL,
  `tanggal_submit` datetime DEFAULT NULL,
  `status` varchar(50) DEFAULT 'Belum Dikumpulkan',
  `tanggal_kumpul` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `pengumpulan_tugas`
--

INSERT INTO `pengumpulan_tugas` (`id_pengumpulan`, `id_tugas`, `id_siswa`, `link_pengumpulan`, `nilai`, `tanggal_submit`, `status`, `tanggal_kumpul`) VALUES
(1, 3, 1, 'https://drive.google.com/drive/folders/1JSe1uMT1XqYzSVWmp8EAy5awmku9d1AC', 80, NULL, 'Sudah Dinilai', '2025-11-04 23:47:49'),
(2, 3, 4, 'https://drive.google.com/drive/folders/1yPFJftImoA_P7QhVFPKBSQiRzcX_DHsA', 100, NULL, 'Sudah Dinilai', '2025-11-04 23:55:50'),
(3, 6, 1, 'qGkwX5bETR2XC2iOSn2Hs', 75, NULL, 'Sudah Dinilai', '2025-11-17 21:48:17'),
(4, 7, 1, 'https://sindig-ft.unesa.ac.id/mod/assign/view.php?id=71104', 65, NULL, 'Sudah Dinilai', '2025-11-26 09:46:39');

-- --------------------------------------------------------

--
-- Table structure for table `quiz`
--

CREATE TABLE `quiz` (
  `id` int(11) NOT NULL,
  `judul_quiz` varchar(150) NOT NULL,
  `deskripsi_quiz` varchar(255) NOT NULL,
  `linkquiz` varchar(255) NOT NULL,
  `tanggal_ditambahkan` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `quiz`
--

INSERT INTO `quiz` (`id`, `judul_quiz`, `deskripsi_quiz`, `linkquiz`, `tanggal_ditambahkan`) VALUES
(1, 'Kuesioner Evaluasi Afektif', 'Materi Basis Data 1', 'https://forms.gle/hBwGJpsya7e7MCE27', '28 Oktober 2025'),
(2, 'POST TEST KIMIA', 'MATERI PERIODE KE-3', 'https://forms.gle/gAKuvR2R8dG7HBTw7', '26 Oktober 2025'),
(4, 'Pemrograman Mobile', 'Kerjakan Tugas Ini yaa', 'https://sindig-ft.unesa.ac.id/mod/assign/view.php?id=71104', '26 November 2025');

-- --------------------------------------------------------

--
-- Table structure for table `tugas`
--

CREATE TABLE `tugas` (
  `id_tugas` int(11) NOT NULL,
  `judul` varchar(255) DEFAULT NULL,
  `deskripsi` text DEFAULT NULL,
  `deadline` date DEFAULT NULL,
  `link_materi` varchar(255) DEFAULT NULL,
  `id_guru` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tugas`
--

INSERT INTO `tugas` (`id_tugas`, `judul`, `deskripsi`, `deadline`, `link_materi`, `id_guru`) VALUES
(3, 'Diagram RMD', 'Buatlah Diagram RMD Bedasarkan Studi Kasus Perpustakaan', '2025-11-11', '', 2),
(6, 'Struktur Data', 'Kerjain Ya', '2025-11-19', 'https://wayground.com/admin/quiz/5e604b695441b7001c6bfb04/struktur-data', 2),
(7, 'Grafika Komputer', 'Buatlah animasi 2d dengan durasi minimal 5 detik', '2025-12-02', NULL, 3),
(8, 'Pemrograman MObile', 'Kerjakan Tepat waktu', '2025-11-28', 'https://sindig-ft.unesa.ac.id/mod/assign/view.php?id=71104', 2);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `fullname` varchar(100) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(100) NOT NULL,
  `status` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `fullname`, `username`, `password`, `status`) VALUES
(1, 'Aji Loka', 'Aji', 'Aji123', 'Pelajar'),
(2, 'Panji Darmawan', 'Darma', 'Darma123', 'Guru'),
(3, 'Arya Maulid', 'Arya', 'RYA123', 'Guru'),
(4, 'Rafli Engklek', 'Rafli', 'Rafli123', 'Pelajar'),
(5, 'Pradipta Kaka', 'Kaka', 'KakaTabolaBale', 'Pelajar');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `materi`
--
ALTER TABLE `materi`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `pengumpulan_tugas`
--
ALTER TABLE `pengumpulan_tugas`
  ADD PRIMARY KEY (`id_pengumpulan`),
  ADD KEY `id_tugas` (`id_tugas`),
  ADD KEY `id_siswa` (`id_siswa`);

--
-- Indexes for table `quiz`
--
ALTER TABLE `quiz`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tugas`
--
ALTER TABLE `tugas`
  ADD PRIMARY KEY (`id_tugas`),
  ADD KEY `id_guru` (`id_guru`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `username` (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `materi`
--
ALTER TABLE `materi`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `pengumpulan_tugas`
--
ALTER TABLE `pengumpulan_tugas`
  MODIFY `id_pengumpulan` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `quiz`
--
ALTER TABLE `quiz`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `tugas`
--
ALTER TABLE `tugas`
  MODIFY `id_tugas` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `pengumpulan_tugas`
--
ALTER TABLE `pengumpulan_tugas`
  ADD CONSTRAINT `pengumpulan_tugas_ibfk_1` FOREIGN KEY (`id_tugas`) REFERENCES `tugas` (`id_tugas`),
  ADD CONSTRAINT `pengumpulan_tugas_ibfk_2` FOREIGN KEY (`id_siswa`) REFERENCES `users` (`id`);

--
-- Constraints for table `tugas`
--
ALTER TABLE `tugas`
  ADD CONSTRAINT `tugas_ibfk_1` FOREIGN KEY (`id_guru`) REFERENCES `users` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

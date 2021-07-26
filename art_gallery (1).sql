-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 17, 2020 at 10:03 AM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.2.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `art gallery`
--

-- --------------------------------------------------------

--
-- Table structure for table `accepted`
--

CREATE TABLE `accepted` (
  `id` int(20) NOT NULL,
  `art_id` int(30) NOT NULL,
  `buyer` int(30) NOT NULL,
  `seller` int(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `accepted`
--

INSERT INTO `accepted` (`id`, `art_id`, `buyer`, `seller`) VALUES
(4, 4, 8, 1);

-- --------------------------------------------------------

--
-- Table structure for table `artwork`
--

CREATE TABLE `artwork` (
  `id` int(11) NOT NULL,
  `name` varchar(255) DEFAULT NULL,
  `date` varchar(20) NOT NULL,
  `type` varchar(20) DEFAULT NULL,
  `image` blob DEFAULT NULL,
  `price` int(20) NOT NULL,
  `Sold` varchar(20) NOT NULL,
  `creator_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `artwork`
--

INSERT INTO `artwork` (`id`, `name`, `date`, `type`, `image`, `price`, `Sold`, `creator_id`) VALUES
(3, 'His', '2020-04-23', 'Decorative Art', 0x53797374656d2e427974655b5d, 0, '', 1),
(4, 'Fine', '2020-04-23', 'Fine Art', 0x53797374656d2e427974655b5d, 432, 'Yes', 1),
(21, 'Fies', '2020-05-11', 'Visual Art', 0x53797374656d2e427974655b5d, 432, 'No', 2),
(23, 'Visco', '2020-05-13', 'Visual Art', 0x53797374656d2e427974655b5d, 123, 'Yes', 7),
(24, 'Kosh', '2020-05-14', 'Applied Art', 0x53797374656d2e427974655b5d, 213, 'No', 8),
(25, 'For ', '2020-05-15', 'Decorative Art', 0x53797374656d2e427974655b5d, 3211, 'Yes', 1),
(26, 'Shine', '2020-05-15', 'Decorative Art', 0x53797374656d2e427974655b5d, 443, 'No', 7),
(28, 'Dew', '2020-05-16', 'Visual Art', 0x53797374656d2e427974655b5d, 321, 'No', 10),
(29, 'Jews', '2020-05-16', 'Decorative Art', 0x53797374656d2e427974655b5d, 321, 'No', 10),
(30, 'Grive', '2020-05-17', 'Visual Art', 0x53797374656d2e427974655b5d, 231, 'No', 11);

-- --------------------------------------------------------

--
-- Table structure for table `received art`
--

CREATE TABLE `received art` (
  `id` int(20) NOT NULL,
  `d_id` int(30) NOT NULL,
  `art_id` int(30) NOT NULL,
  `buyerId` int(20) NOT NULL,
  `art_Status` varchar(30) NOT NULL,
  `address` varchar(20) NOT NULL,
  `Collect date` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `received art`
--

INSERT INTO `received art` (`id`, `d_id`, `art_id`, `buyerId`, `art_Status`, `address`, `Collect date`) VALUES
(8, 3, 23, 8, 'Delivered', 'Dhaka', '2020-05-17');

-- --------------------------------------------------------

--
-- Table structure for table `request`
--

CREATE TABLE `request` (
  `id` int(20) NOT NULL,
  `artId` int(30) NOT NULL,
  `buyerId` int(30) NOT NULL,
  `sellerId` int(30) NOT NULL,
  `Phone number` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `request`
--

INSERT INTO `request` (`id`, `artId`, `buyerId`, `sellerId`, `Phone number`) VALUES
(2, 24, 1, 8, '1232211'),
(6, 29, 1, 10, '09221221'),
(7, 24, 1, 8, '882721'),
(8, 26, 1, 7, '09221211');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `full_name` varchar(255) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `type` int(11) DEFAULT NULL,
  `phone_number` varchar(255) DEFAULT NULL,
  `email` varchar(255) DEFAULT NULL,
  `address` varchar(255) DEFAULT NULL,
  `status` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `full_name`, `password`, `type`, `phone_number`, `email`, `address`, `status`) VALUES
(1, 'Karry', '111', 1, '017721112', 'Harrsih@gmai.com', 'Chittagong', 'Active'),
(2, '2231221', '345', 1, '9083321', 'Karim@', 'Dhaka', 'Active'),
(3, 'Fahim', '212', 2, '3432121', 'rahim@', 'Dhaka', 'Active'),
(5, 'Opu', '111', 2, '0918211', 'Opu@gmail.xom', 'Dhaka', 'Active'),
(6, 'Sara', '333', 2, '98211211', 'Sara@mail.com', 'Dhaka', 'Active'),
(7, 'Rahim', '111', 1, '09221211', 'Rahim@sa.com', 'Dhaka', 'Active'),
(8, 'Urmii', '111', 1, '882721', 'Urmi@da.com', 'Dhaka', 'Active'),
(9, 'Afsara', '333', 3, '01822121', 'Tasnim@gmail.com', 'Chittagong', 'Active'),
(10, 'Oscar', '222', 1, '09221221', 'Oscar@gamil.com', 'Dhaka', 'Active'),
(11, 'Hashem', '666', 1, '0912212', 'Has@gmail.com', 'Dhaka', 'Deactive');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `accepted`
--
ALTER TABLE `accepted`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `artwork`
--
ALTER TABLE `artwork`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_art_customer` (`creator_id`);

--
-- Indexes for table `received art`
--
ALTER TABLE `received art`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_receivedArt_artwork` (`art_id`),
  ADD KEY `fh_recivedart_deliveryman` (`d_id`);

--
-- Indexes for table `request`
--
ALTER TABLE `request`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `accepted`
--
ALTER TABLE `accepted`
  MODIFY `id` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `artwork`
--
ALTER TABLE `artwork`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT for table `received art`
--
ALTER TABLE `received art`
  MODIFY `id` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `request`
--
ALTER TABLE `request`
  MODIFY `id` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `artwork`
--
ALTER TABLE `artwork`
  ADD CONSTRAINT `fk_art_customer` FOREIGN KEY (`creator_id`) REFERENCES `users` (`id`);

--
-- Constraints for table `received art`
--
ALTER TABLE `received art`
  ADD CONSTRAINT `fh_recivedart_deliveryman` FOREIGN KEY (`d_id`) REFERENCES `users` (`id`),
  ADD CONSTRAINT `fk_receivedArt_artwork` FOREIGN KEY (`art_id`) REFERENCES `artwork` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

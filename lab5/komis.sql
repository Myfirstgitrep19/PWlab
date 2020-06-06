-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Czas generowania: 06 Cze 2020, 19:06
-- Wersja serwera: 10.4.11-MariaDB
-- Wersja PHP: 7.2.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `komis`
--
CREATE DATABASE IF NOT EXISTS `komis` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `komis`;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `samochod`
--

CREATE TABLE `samochod` (
  `id` int(11) NOT NULL,
  `cena` int(11) NOT NULL,
  `kolor` varchar(50) NOT NULL,
  `marka` varchar(50) NOT NULL,
  `model` varchar(50) NOT NULL,
  `pojemnosc` int(11) NOT NULL,
  `rocznik` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `samochod`
--

INSERT INTO `samochod` (`id`, `cena`, `kolor`, `marka`, `model`, `pojemnosc`, `rocznik`) VALUES
(1, 22000, 'czarny', 'Toyota', 'Camry', 1500, 2002),
(2, 78000, 'czarny', 'Audi', 'Q2', 2000, 2018),
(4, 21650, 'srebrny', 'Skoda', 'Octavia', 1900, 2010),
(5, 3500, 'zielony', 'Renault', 'Twingo', 1100, 2001),
(6, 15000, 'czarny', 'Seat', 'Leon', 1595, 2004),
(7, 25000, 'czarny', 'Mercedes', 'w211', 1800, 2005),
(8, 67000, 'granatowy', 'Toyota', 'Verso', 1800, 2016),
(9, 3000, 'zielony', 'Alfa Romeo', '147', 1595, 2001);

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `samochod`
--
ALTER TABLE `samochod`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT dla tabeli `samochod`
--
ALTER TABLE `samochod`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

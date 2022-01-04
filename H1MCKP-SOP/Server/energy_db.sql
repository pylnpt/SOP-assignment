-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1:3306
-- Létrehozás ideje: 2022. Jan 04. 15:38
-- Kiszolgáló verziója: 5.7.36
-- PHP verzió: 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `energy_db`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `energy_drinks`
--

DROP TABLE IF EXISTS `energy_drinks`;
CREATE TABLE IF NOT EXISTS `energy_drinks` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `brand` varchar(45) COLLATE utf8_bin DEFAULT NULL,
  `coffein_amount` varchar(11) COLLATE utf8_bin DEFAULT NULL,
  `model` varchar(45) COLLATE utf8_bin DEFAULT NULL,
  `price` varchar(11) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=120 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- A tábla adatainak kiíratása `energy_drinks`
--

INSERT INTO `energy_drinks` (`id`, `brand`, `coffein_amount`, `model`, `price`) VALUES
(9, 'Hell', '300', 'Classic', '250'),
(12, 'Monster', '500', 'Ripper', '550'),
(14, 'Monster', '500', 'Ripper', '550'),
(15, 'Monster', '500', 'Ripper', '550'),
(16, 'Monster', '500', 'Ripper', '550'),
(18, 'Monster', '500', 'Ripper', '550'),
(19, 'Monster', '500', 'Ripper', '550'),
(20, 'Monster', '500', 'Ripper', '550'),
(21, 'Monster', '500', 'Ripper', '550'),
(22, 'Monster', '500', 'Ripper', '550'),
(23, 'Monster', '500', 'Ripper', '550'),
(24, 'Monster', '500', 'Ripper', '550'),
(25, 'Monster', '500', 'Ripper', '550'),
(26, 'Monster', '500', 'Ripper', '550'),
(27, 'Monster', '500', 'Ripper', '550'),
(28, 'Monster', '500', 'Ripper', '550'),
(29, 'Monster', '500', 'Ripper', '550'),
(30, 'Monster', '500', 'Ripper', '550'),
(31, 'Monster', '500', 'Ripper', '550'),
(32, 'Monster', '500', 'Ripper', '550'),
(33, 'Monster', '500', 'Ripper', '550'),
(34, 'Monster', '500', 'Ripper', '550'),
(35, 'Monster', '500', 'Ripper', '550'),
(36, 'Monster', '500', 'Ripper', '550'),
(37, 'Monster', '500', 'Ripper', '550'),
(38, 'Monster', '500', 'Ripper', '550'),
(39, 'Monster', '500', 'Ripper', '550'),
(40, 'Monster', '500', 'Ripper', '550'),
(41, 'Monster', '500', 'Ripper', '550'),
(42, 'Monster', '500', 'Ripper', '550'),
(43, 'Monster', '500', 'Ripper', '550'),
(44, 'Monster', '500', 'Ripper', '550'),
(45, 'Monster', '500', 'Ripper', '550'),
(114, 'Bomba', '1000', 'Classic', '1000'),
(103, 'RedBull', '500', 'Zero', '700'),
(109, 'Hell', '300', 'Focus', '250'),
(110, 'Hell', '300', 'Focus', '250'),
(111, 'Hell', '300', 'Focus', '250'),
(118, 'asd', 'asd', 'asd', 'asd'),
(79, '', NULL, '', '');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(45) COLLATE utf8_bin DEFAULT NULL,
  `pwd` varchar(45) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- A tábla adatainak kiíratása `users`
--

INSERT INTO `users` (`id`, `username`, `pwd`) VALUES
(1, 'pepe', 'asd'),
(7, 'username', 'pwd');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 08.10.2017 klo 15:49
-- Palvelimen versio: 5.7.14
-- PHP Version: 5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hockey_database`
--

-- --------------------------------------------------------

--
-- Rakenne taululle `coaches`
--

CREATE TABLE `coaches` (
  `ID` int(11) NOT NULL,
  `name` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Vedos taulusta `coaches`
--

INSERT INTO `coaches` (`ID`, `name`) VALUES
(1, 'Bill Peters'),
(2, 'Barry Trotz'),
(3, 'Mike Sullivan'),
(4, 'Paul Maurice'),
(5, 'Sami Kapanen'),
(6, 'Marko Virtanen'),
(8, 'Testivalmentaja');

-- --------------------------------------------------------

--
-- Rakenne taululle `leagues`
--

CREATE TABLE `leagues` (
  `ID` int(11) NOT NULL,
  `name` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Vedos taulusta `leagues`
--

INSERT INTO `leagues` (`ID`, `name`) VALUES
(1, 'NHL'),
(2, 'SM-Liiga'),
(3, 'KHL');

-- --------------------------------------------------------

--
-- Rakenne taululle `players`
--

CREATE TABLE `players` (
  `ID` int(11) NOT NULL,
  `name` varchar(200) NOT NULL,
  `dateOfBirth` datetime NOT NULL,
  `number` int(11) NOT NULL,
  `team_ID` int(11) NOT NULL,
  `position_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Vedos taulusta `players`
--

INSERT INTO `players` (`ID`, `name`, `dateOfBirth`, `number`, `team_ID`, `position_ID`) VALUES
(1, 'Sebastian Aho', '1997-07-26 00:00:00', 20, 1, 1),
(2, 'Jeff Skinner', '1992-05-16 00:00:00', 53, 1, 1),
(3, 'Teuvo Teräväinen', '1994-09-11 00:00:00', 86, 1, 1),
(4, 'Alex Ovechkin', '1985-09-17 00:00:00', 8, 2, 1),
(5, 'Patrik Laine', '1998-04-19 00:00:00', 29, 3, 1),
(6, 'Joel Armia', '1993-05-31 00:00:00', 40, 3, 1),
(7, 'Sidney Crosby', '1987-08-07 00:00:00', 87, 4, 1),
(8, 'Olli Määttä', '1994-08-22 00:00:00', 3, 4, 2),
(9, 'Juuso Riikola', '1993-11-09 00:00:00', 50, 5, 2),
(10, 'Eetu Laurikainen', '1993-02-01 00:00:00', 41, 6, 3),
(12, 'Moona Partanen', '1993-08-12 00:00:00', 12, 10, 1),
(15, 'testi', '2017-10-08 00:00:00', 15, 1, 1),
(18, 'Eetu Leivo', '1988-04-26 00:00:00', 2, 4, 1);

-- --------------------------------------------------------

--
-- Rakenne taululle `positions`
--

CREATE TABLE `positions` (
  `ID` int(11) NOT NULL,
  `position` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Vedos taulusta `positions`
--

INSERT INTO `positions` (`ID`, `position`) VALUES
(1, 'Hyökkääjä'),
(2, 'Puolustaja'),
(3, 'Maalivahti');

-- --------------------------------------------------------

--
-- Rakenne taululle `stadiums`
--

CREATE TABLE `stadiums` (
  `ID` int(11) NOT NULL,
  `name` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Vedos taulusta `stadiums`
--

INSERT INTO `stadiums` (`ID`, `name`) VALUES
(1, 'PNC Arena'),
(2, 'Capital One Arena'),
(3, 'PPG Paints Arena'),
(4, 'Bell MTS Place'),
(5, 'Data Group Areena'),
(6, 'Synergia-areena');

-- --------------------------------------------------------

--
-- Rakenne taululle `teams`
--

CREATE TABLE `teams` (
  `ID` int(11) NOT NULL,
  `name` varchar(200) NOT NULL,
  `stadium_ID` int(11) NOT NULL,
  `league_ID` int(11) NOT NULL,
  `coach_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Vedos taulusta `teams`
--

INSERT INTO `teams` (`ID`, `name`, `stadium_ID`, `league_ID`, `coach_ID`) VALUES
(1, 'Carolina Hurricanes', 1, 1, 1),
(2, 'Washington Capitals', 2, 1, 2),
(3, 'Winnipeg Jets', 4, 1, 4),
(4, 'Pittsburgh Penguins', 3, 1, 3),
(5, 'Kalpa ', 5, 2, 5),
(6, 'JYP', 6, 2, 6),
(10, 'Testijoukkue2', 4, 1, 2);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `coaches`
--
ALTER TABLE `coaches`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `leagues`
--
ALTER TABLE `leagues`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `players`
--
ALTER TABLE `players`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `team_ID` (`team_ID`,`position_ID`),
  ADD KEY `position_ID` (`position_ID`);

--
-- Indexes for table `positions`
--
ALTER TABLE `positions`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `stadiums`
--
ALTER TABLE `stadiums`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `teams`
--
ALTER TABLE `teams`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `stadium_ID` (`stadium_ID`,`league_ID`,`coach_ID`),
  ADD KEY `league_ID` (`league_ID`),
  ADD KEY `coach_ID` (`coach_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `coaches`
--
ALTER TABLE `coaches`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT for table `leagues`
--
ALTER TABLE `leagues`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `players`
--
ALTER TABLE `players`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;
--
-- AUTO_INCREMENT for table `positions`
--
ALTER TABLE `positions`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `stadiums`
--
ALTER TABLE `stadiums`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT for table `teams`
--
ALTER TABLE `teams`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
--
-- Rajoitteet vedostauluille
--

--
-- Rajoitteet taululle `players`
--
ALTER TABLE `players`
  ADD CONSTRAINT `players_ibfk_2` FOREIGN KEY (`position_ID`) REFERENCES `positions` (`ID`),
  ADD CONSTRAINT `players_ibfk_3` FOREIGN KEY (`team_ID`) REFERENCES `teams` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Rajoitteet taululle `teams`
--
ALTER TABLE `teams`
  ADD CONSTRAINT `teams_ibfk_1` FOREIGN KEY (`stadium_ID`) REFERENCES `stadiums` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `teams_ibfk_2` FOREIGN KEY (`league_ID`) REFERENCES `leagues` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `teams_ibfk_3` FOREIGN KEY (`coach_ID`) REFERENCES `coaches` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

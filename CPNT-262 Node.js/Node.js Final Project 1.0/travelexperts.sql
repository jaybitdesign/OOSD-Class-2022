-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 14, 2022 at 09:14 AM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";

--
-- Database: `travelexperts`
--

-- --------------------------------------------------------

--
-- Table structure for table `agencies`
--

CREATE TABLE `agencies` (
  `AgencyId` int(11) NOT NULL,
  `AgncyAddress` varchar(50) DEFAULT NULL,
  `AgncyCity` varchar(50) DEFAULT NULL,
  `AgncyProv` varchar(50) DEFAULT NULL,
  `AgncyPostal` varchar(50) DEFAULT NULL,
  `AgncyCountry` varchar(50) DEFAULT NULL,
  `AgncyPhone` varchar(50) DEFAULT NULL,
  `AgncyFax` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `agencies`
--

INSERT INTO `agencies` (`AgencyId`, `AgncyAddress`, `AgncyCity`, `AgncyProv`, `AgncyPostal`, `AgncyCountry`, `AgncyPhone`, `AgncyFax`) VALUES
(1, '1155 8th Ave SW', 'Calgary', 'AB', 'T2P1N3', 'Canada', '4032719873', '4032719872'),
(2, '110 Main Street', 'Okotoks', 'AB', 'T7R3J5', 'Canada', '4035632381', '4035632382');

-- --------------------------------------------------------

--
-- Table structure for table `agents`
--

CREATE TABLE `agents` (
  `AgentId` int(11) NOT NULL,
  `AgentFirstName` varchar(20) DEFAULT NULL,
  `AgentMiddleInitial` varchar(5) DEFAULT NULL,
  `AgentLastName` varchar(20) DEFAULT NULL,
  `AgentPhoto` varchar(256) DEFAULT NULL,
  `AgentBusPhone` varchar(20) DEFAULT NULL,
  `AgentEmail` varchar(50) DEFAULT NULL,
  `AgentPosition` varchar(20) DEFAULT NULL,
  `AgencyId` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

--
-- Dumping data for table `agents`
--

INSERT INTO `agents` (`AgentId`, `AgentFirstName`, `AgentMiddleInitial`, `AgentLastName`, `AgentPhoto`, `AgentBusPhone`, `AgentEmail`, `AgentPosition`, `AgencyId`) VALUES
(1, 'Janet', NULL, 'Delton', 'https://place-hold.it/320x320.png&text=Contact%20#1', '(403) 210-7801', 'janet.delton@travelexperts.com', 'Senior Agent', 1),
(2, 'Judy', NULL, 'Lisle', 'https://place-hold.it/320x320.png&text=Contact%20#2', '(403) 210-7802', 'judy.lisle@travelexperts.com', 'Intermediate Agent', 1),
(3, 'Dennis', 'C.', 'Reynolds', 'https://place-hold.it/320x320.png&text=Contact%20#3', '(403) 210-7843', 'dennis.reynolds@travelexperts.com', 'Junior Agent', 1),
(4, 'John', NULL, 'Coville', 'https://place-hold.it/320x320.png&text=Contact%20#4', '(403) 210-7823', 'john.coville@travelexperts.com', 'Intermediate Agent', 1),
(5, 'Fred', 'J', 'Smith', 'https://place-hold.it/320x320.png&text=Contact%20#5', '(403) 210-5555', 'fred@travelexperts.com', 'Junior Agent', 2),
(6, 'Bruce', 'J.', 'Dixon', 'https://place-hold.it/320x320.png&text=Contact%20#6', '(403) 210-7867', 'bruce.dixon@travelexperts.com', 'Intermediate Agent', 2),
(7, 'Beverly', 'S.', 'Jones', 'https://place-hold.it/320x320.png&text=Contact%20#7', '(403) 210-7812', 'beverly.jones@travelexperts.com', 'Intermediate Agent', 1),
(8, 'Jane', NULL, 'Merrill', 'https://place-hold.it/320x320.png&text=Contact%20#8', '(403) 210-7868', 'jane.merrill@travelexperts.com', 'Senior Agent', 2),
(9, 'Brian', 'S.', 'Peterson', 'https://place-hold.it/320x320.png&text=Contact%20#9', '(403) 210-7833', 'brian.peterson@travelexperts.com', 'Junior Agent', 2);

-- --------------------------------------------------------

--
-- Table structure for table `bookings`
--

CREATE TABLE `bookings` (
  `BookingId` int(11) NOT NULL,
  `BookingDate` datetime DEFAULT NULL,
  `CustomerId` int(11) DEFAULT NULL,
  `TripTypeId` varchar(1) DEFAULT NULL,
  `PackageId` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `bookings`
--

INSERT INTO `bookings` (`BookingId`, `BookingDate`, `CustomerId`, `TripTypeId`, `PackageId`) VALUES
(1326, '2022-06-14 00:26:00', 130, NULL, 1),
(1327, '2022-06-14 00:32:59', 130, NULL, 5);

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

CREATE TABLE `customers` (
  `CustomerId` int(11) NOT NULL,
  `CustomerName` varchar(50) NOT NULL,
  `CustomerPostal` varchar(7) NOT NULL,
  `CustomerEmail` varchar(50) NOT NULL,
  `CustomerPassword` varchar(256) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `customers`
--

INSERT INTO `customers` (`CustomerId`, `CustomerName`, `CustomerPostal`, `CustomerEmail`, `CustomerPassword`) VALUES
(105, 'Angel', 'T2J 7E3', 'amoskowitz@home.com                               ', '12345'),
(107, 'Catherine', 'T2Z 2Z9', 'cmierzwa@msn.com                                  ', '12345'),
(108, 'Judy', 'T1Y 6N4', 'judysehti@home.com', '12345'),
(109, 'Larry', 'T2J 6B6', 'lwalter@aol.com                                   ', '12345'),
(118, 'Hiediio', 'T3A 4ZG', 'hlopez@aol.com', '12345'),
(121, 'Sean B', 'T2K 3E3', 'spineda@hotmail.com', '12345'),
(122, 'Julita', 'T2K 6C5', 'jlippen@cadvision.co                              ', '12345'),
(123, 'Pierre', 'T3G 2C6', 'pradicola@home.com                                ', '12345'),
(130, 'Lula', 'T3E 3Z4', 'loates@aol.com                                    ', '12345'),
(133, 'James', 'T3E 4A1', 'jreed@aol.com                                     ', '12345'),
(138, 'John', 'T3E 5C7', 'johnSmith@hotmail.co                              ', '12345'),
(142, 'Monica', 'T2J 6P3', 'mwaldman@aol.com                                  ', '12345'),
(151, 'James Buchanan', 'A1A 1A1', 'abc@abc.com', '1234');

-- --------------------------------------------------------

--
-- Table structure for table `packages`
--

CREATE TABLE `packages` (
  `PackageId` int(11) NOT NULL,
  `PackageName` varchar(50) NOT NULL,
  `PackagePhoto` varchar(256) DEFAULT NULL,
  `PackageStartDate` datetime DEFAULT NULL,
  `PackageEndDate` datetime DEFAULT NULL,
  `PackageDesc` varchar(50) DEFAULT NULL,
  `PackageBasePrice` decimal(19,4) NOT NULL,
  `PackageAgencyCommission` decimal(19,4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `packages`
--

INSERT INTO `packages` (`PackageId`, `PackageName`, `PackagePhoto`, `PackageStartDate`, `PackageEndDate`, `PackageDesc`, `PackageBasePrice`, `PackageAgencyCommission`) VALUES
(1, 'Caribbean New Year', 'https://place-hold.it/600x400.png&text=PackagePhoto', '2017-12-25 00:00:00', '2017-01-04 00:00:00', 'Cruise the Caribbean & Celebrate the New Year.', '4800.0000', '400.0000'),
(2, 'Polynesian Paradise', 'https://place-hold.it/600x400.png&text=PackagePhoto', '2016-12-12 00:00:00', '2016-12-20 00:00:00', '8 Day All Inclusive Hawaiian Vacation', '3000.0000', '310.0000'),
(3, 'Asian Expedition', 'https://place-hold.it/600x400.png&text=PackagePhoto', '2016-05-14 00:00:00', '2016-05-28 00:00:00', 'Airfaire, Hotel and Eco Tour.', '2800.0000', '300.0000'),
(4, 'European Vacation', 'https://place-hold.it/600x400.png&text=PackagePhoto', '2016-11-01 00:00:00', '2016-11-14 00:00:00', 'Euro Tour with Rail Pass and Travel Insurance', '3000.0000', '280.0000'),
(5, 'North African Safari', 'https://place-hold.it/600x400.png&text=PackagePhoto', '2016-05-14 00:00:00', '2016-05-28 00:00:00', '9 Day Expedition In North Africa', '9000.0000', '400.0000'),
(6, 'South American Adventure', 'https://place-hold.it/600x400.png&text=PackagePhoto', '2016-05-14 00:00:00', '2016-05-28 00:00:00', 'A 4 Day Trek Through South Americas Greatest Trail', '3000.0000', '200.0000');

-- --------------------------------------------------------

--
-- Table structure for table `triptypes`
--

CREATE TABLE `triptypes` (
  `TripTypeId` varchar(1) NOT NULL,
  `TTName` varchar(25) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `triptypes`
--

INSERT INTO `triptypes` (`TripTypeId`, `TTName`) VALUES
('B', 'Business                 '),
('G', 'Group                    '),
('L', 'Leisure                  ');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `agencies`
--
ALTER TABLE `agencies`
  ADD PRIMARY KEY (`AgencyId`);

--
-- Indexes for table `agents`
--
ALTER TABLE `agents`
  ADD PRIMARY KEY (`AgentId`),
  ADD KEY `AgencyId` (`AgencyId`);

--
-- Indexes for table `bookings`
--
ALTER TABLE `bookings`
  ADD PRIMARY KEY (`BookingId`),
  ADD KEY `BookingsCustomerId` (`CustomerId`),
  ADD KEY `CustomersBookings` (`CustomerId`),
  ADD KEY `PackageId` (`PackageId`),
  ADD KEY `PackagesBookings` (`PackageId`),
  ADD KEY `TripTypesBookings` (`TripTypeId`);

--
-- Indexes for table `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`CustomerId`);

--
-- Indexes for table `packages`
--
ALTER TABLE `packages`
  ADD PRIMARY KEY (`PackageId`);

--
-- Indexes for table `triptypes`
--
ALTER TABLE `triptypes`
  ADD PRIMARY KEY (`TripTypeId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `agencies`
--
ALTER TABLE `agencies`
  MODIFY `AgencyId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `agents`
--
ALTER TABLE `agents`
  MODIFY `AgentId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `bookings`
--
ALTER TABLE `bookings`
  MODIFY `BookingId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1328;

--
-- AUTO_INCREMENT for table `customers`
--
ALTER TABLE `customers`
  MODIFY `CustomerId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=152;

--
-- AUTO_INCREMENT for table `packages`
--
ALTER TABLE `packages`
  MODIFY `PackageId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `agents`
--
ALTER TABLE `agents`
  ADD CONSTRAINT `agents_ibfk_1` FOREIGN KEY (`AgencyId`) REFERENCES `agencies` (`AgencyId`);

--
-- Constraints for table `bookings`
--
ALTER TABLE `bookings`
  ADD CONSTRAINT `bookings_ibfk_1` FOREIGN KEY (`CustomerId`) REFERENCES `customers` (`CustomerId`),
  ADD CONSTRAINT `bookings_ibfk_2` FOREIGN KEY (`PackageId`) REFERENCES `packages` (`PackageId`),
  ADD CONSTRAINT `bookings_ibfk_3` FOREIGN KEY (`TripTypeId`) REFERENCES `triptypes` (`TripTypeId`);
COMMIT;
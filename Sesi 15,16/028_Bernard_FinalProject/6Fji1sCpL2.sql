-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Oct 21, 2021 at 06:22 PM
-- Server version: 8.0.13-4
-- PHP Version: 7.2.24-0ubuntu0.18.04.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `6Fji1sCpL2`
--

-- --------------------------------------------------------

--
-- Table structure for table `AspNetRoleClaims`
--

CREATE TABLE `AspNetRoleClaims` (
  `Id` int(11) NOT NULL,
  `RoleId` varchar(85) COLLATE utf8_unicode_ci NOT NULL,
  `ClaimType` text COLLATE utf8_unicode_ci,
  `ClaimValue` text COLLATE utf8_unicode_ci
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `AspNetRoles`
--

CREATE TABLE `AspNetRoles` (
  `Id` varchar(85) COLLATE utf8_unicode_ci NOT NULL,
  `Name` varchar(256) COLLATE utf8_unicode_ci DEFAULT NULL,
  `NormalizedName` varchar(85) COLLATE utf8_unicode_ci DEFAULT NULL,
  `ConcurrencyStamp` text COLLATE utf8_unicode_ci
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `AspNetUserClaims`
--

CREATE TABLE `AspNetUserClaims` (
  `Id` int(11) NOT NULL,
  `UserId` varchar(85) COLLATE utf8_unicode_ci NOT NULL,
  `ClaimType` text COLLATE utf8_unicode_ci,
  `ClaimValue` text COLLATE utf8_unicode_ci
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `AspNetUserLogins`
--

CREATE TABLE `AspNetUserLogins` (
  `LoginProvider` varchar(85) COLLATE utf8_unicode_ci NOT NULL,
  `ProviderKey` varchar(85) COLLATE utf8_unicode_ci NOT NULL,
  `ProviderDisplayName` text COLLATE utf8_unicode_ci,
  `UserId` varchar(85) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `AspNetUserRoles`
--

CREATE TABLE `AspNetUserRoles` (
  `UserId` varchar(85) COLLATE utf8_unicode_ci NOT NULL,
  `RoleId` varchar(85) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `AspNetUsers`
--

CREATE TABLE `AspNetUsers` (
  `Id` varchar(85) COLLATE utf8_unicode_ci NOT NULL,
  `UserName` varchar(256) COLLATE utf8_unicode_ci DEFAULT NULL,
  `NormalizedUserName` varchar(85) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Email` varchar(256) COLLATE utf8_unicode_ci DEFAULT NULL,
  `NormalizedEmail` varchar(85) COLLATE utf8_unicode_ci DEFAULT NULL,
  `EmailConfirmed` tinyint(1) NOT NULL,
  `PasswordHash` text COLLATE utf8_unicode_ci,
  `SecurityStamp` text COLLATE utf8_unicode_ci,
  `ConcurrencyStamp` text COLLATE utf8_unicode_ci,
  `PhoneNumber` text COLLATE utf8_unicode_ci,
  `PhoneNumberConfirmed` tinyint(1) NOT NULL,
  `TwoFactorEnabled` tinyint(1) NOT NULL,
  `LockoutEnd` timestamp NULL DEFAULT NULL,
  `LockoutEnabled` tinyint(1) NOT NULL,
  `AccessFailedCount` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `AspNetUsers`
--

INSERT INTO `AspNetUsers` (`Id`, `UserName`, `NormalizedUserName`, `Email`, `NormalizedEmail`, `EmailConfirmed`, `PasswordHash`, `SecurityStamp`, `ConcurrencyStamp`, `PhoneNumber`, `PhoneNumberConfirmed`, `TwoFactorEnabled`, `LockoutEnd`, `LockoutEnabled`, `AccessFailedCount`) VALUES
('938e5432-bc19-4b65-b61e-206ee31c5e49', 'Bernard3', 'BERNARD3', 'bernar3d@gmail.com', 'BERNAR3D@GMAIL.COM', 0, 'AQAAAAEAACcQAAAAEP6Cg01ug/o+Frt/gG4XLWtRhAaqVk+o1JLN7gA22GLrbF7tn6OGMmkygXmwAEyqhA==', 'QIGWYFEZ2XVLS4NG5YCVEFAIF62DUYT4', '3ab8bb9e-fce2-4761-a741-a40604e69038', NULL, 0, 0, NULL, 1, 0),
('b3a05bb5-1e2e-41cf-a879-e5bbfc0d32eb', 'Bernard2', 'BERNARD2', 'bernard2@gmail.com', 'BERNARD2@GMAIL.COM', 0, 'AQAAAAEAACcQAAAAEGXrEyggRU/WFp0cXVy0TvJB04zT46M6tx4HPVCodzo69RyFmFs01tl6evi2CRicOA==', 'UHC67FOOLY3PN2RUUY6JHPKAF7TUP5M5', '1db01817-039b-4e16-b177-7b40090ec963', NULL, 0, 0, NULL, 1, 0),
('d0c8f0bc-461e-47f8-b70c-0025b30c791b', 'Bernard', 'BERNARD', 'bernard@gmail.com', 'BERNARD@GMAIL.COM', 0, 'AQAAAAEAACcQAAAAEPi+cJr7XU+WhSLRJraycJEE3Grwv/gAVS6XahUaPjLiFQgX9ejlyCjfn1bAr41DaQ==', 'HAVN4R47BT4UD2QDNVAD4IPTNAYKNPQ3', '093dbd66-2688-480c-bf0b-7f1a730d4128', NULL, 0, 0, NULL, 1, 0);

-- --------------------------------------------------------

--
-- Table structure for table `AspNetUserTokens`
--

CREATE TABLE `AspNetUserTokens` (
  `UserId` varchar(85) COLLATE utf8_unicode_ci NOT NULL,
  `LoginProvider` varchar(85) COLLATE utf8_unicode_ci NOT NULL,
  `Name` varchar(85) COLLATE utf8_unicode_ci NOT NULL,
  `Value` text COLLATE utf8_unicode_ci
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `RefreshTokens`
--

CREATE TABLE `RefreshTokens` (
  `Id` int(11) NOT NULL,
  `UserId` varchar(85) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Token` text COLLATE utf8_unicode_ci,
  `JwtId` text COLLATE utf8_unicode_ci,
  `IsUsed` tinyint(1) NOT NULL,
  `IsRevoked` tinyint(1) NOT NULL,
  `AddedDate` datetime NOT NULL,
  `ExpiryDate` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `RefreshTokens`
--

INSERT INTO `RefreshTokens` (`Id`, `UserId`, `Token`, `JwtId`, `IsUsed`, `IsRevoked`, `AddedDate`, `ExpiryDate`) VALUES
(1, 'd0c8f0bc-461e-47f8-b70c-0025b30c791b', 'RLG0XTHBKA3QQPBPRABWB5TWBUNIXLBIDHM93f5e3e9-0b7b-42b1-bad1-f33c6c9aaaf2', '535bf4b1-5e72-4452-a42d-755b28a0d371', 0, 0, '2021-10-21 17:34:48', '2022-04-21 17:34:48'),
(2, 'd0c8f0bc-461e-47f8-b70c-0025b30c791b', 'ITA5TYKCRWM5N8DPPDMCRBNC5H69TT9IXCY0ec3c943-dc7f-4ca3-9a11-02b3c6c2c7c9', 'f952d974-bc10-489c-93b4-7bb2351c6f66', 0, 0, '2021-10-21 17:36:37', '2022-04-21 17:36:37'),
(3, 'd0c8f0bc-461e-47f8-b70c-0025b30c791b', 'S5A7JJY6RUOBF3QACNGVBXSMYACATBQY3618eb80ba2-d36c-4e08-91e1-f4c09f8d9e75', '6ef1bff2-8b08-4626-b9f3-d4e3e719af10', 0, 0, '2021-10-21 17:37:25', '2022-04-21 17:37:25'),
(4, 'd0c8f0bc-461e-47f8-b70c-0025b30c791b', 'WD0VT7FKYH0K5BLLDS71BSNXIGHSX0E4595019379db-7551-4f82-bf93-47028f384cb7', '68c83f47-3d87-45c9-9bb9-b4ad57ef982b', 0, 0, '2021-10-21 17:37:37', '2022-04-21 17:37:37'),
(5, 'b3a05bb5-1e2e-41cf-a879-e5bbfc0d32eb', '7CDWEC989BS38XRPETWL7B8VWI4YU6L5LJ8db966965-f493-4027-8b7a-b4c077bf9f6b', '99522917-369b-481d-b370-a5fd5389c042', 0, 0, '2021-10-21 17:38:15', '2022-04-21 17:38:15'),
(6, '938e5432-bc19-4b65-b61e-206ee31c5e49', 'P4QT37HBEP8B8PWU4MLWR8MVZMG8GS2O9YR4e73b9e4-bdb6-4d7a-8237-47d001934c6c', '5e9a6669-9653-48e0-ae6f-fab0ea6ba69d', 0, 0, '2021-10-21 17:45:30', '2022-04-21 17:45:30'),
(7, '938e5432-bc19-4b65-b61e-206ee31c5e49', 'SIUIQTWGGPC2Y616X2FAKQPWP13CLBB55QN89b529cf-6186-46ba-94d6-50990d151c96', '7150eec5-0645-49bc-9917-2a075ccddb4f', 0, 0, '2021-10-21 17:45:56', '2022-04-21 17:45:56'),
(8, 'd0c8f0bc-461e-47f8-b70c-0025b30c791b', 'LSH9B1K4TL0T51RV6NB8Z2QIAAPSOBC4IMQa9ba7d42-fd83-4231-b783-59164a4cdaea', '955d7b12-3b45-474c-927c-8279626800e3', 0, 0, '2021-10-21 17:58:15', '2022-04-21 17:58:15'),
(9, 'd0c8f0bc-461e-47f8-b70c-0025b30c791b', '3EVXO300H4MNXMLTM02B3BGIWOMCJA66B98d7599f33-1081-4cc5-a623-d8f464e2d82f', 'b5c4cf45-8db7-4eb3-b929-6ba68c743947', 0, 0, '2021-10-21 18:12:39', '2022-04-21 18:12:39');

-- --------------------------------------------------------

--
-- Table structure for table `tb_paymentdetail`
--

CREATE TABLE `tb_paymentdetail` (
  `paymentDetailId` int(11) NOT NULL,
  `cardOwnerName` text COLLATE utf8_unicode_ci,
  `cardNumber` text COLLATE utf8_unicode_ci,
  `expirationDate` text COLLATE utf8_unicode_ci,
  `securityCode` text COLLATE utf8_unicode_ci
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `tb_paymentdetail`
--

INSERT INTO `tb_paymentdetail` (`paymentDetailId`, `cardOwnerName`, `cardNumber`, `expirationDate`, `securityCode`) VALUES
(1, 'Bernard', '123456789', '31-12-1999', '12345');

-- --------------------------------------------------------

--
-- Table structure for table `__EFMigrationsHistory`
--

CREATE TABLE `__EFMigrationsHistory` (
  `MigrationId` varchar(150) COLLATE utf8_unicode_ci NOT NULL,
  `ProductVersion` varchar(32) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `__EFMigrationsHistory`
--

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`) VALUES
('20211021173231_Payment Detail', '5.0.11'),
('20211021173245_Refresh Token', '5.0.11');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `AspNetRoleClaims`
--
ALTER TABLE `AspNetRoleClaims`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_AspNetRoleClaims_RoleId` (`RoleId`);

--
-- Indexes for table `AspNetRoles`
--
ALTER TABLE `AspNetRoles`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `RoleNameIndex` (`NormalizedName`);

--
-- Indexes for table `AspNetUserClaims`
--
ALTER TABLE `AspNetUserClaims`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_AspNetUserClaims_UserId` (`UserId`);

--
-- Indexes for table `AspNetUserLogins`
--
ALTER TABLE `AspNetUserLogins`
  ADD PRIMARY KEY (`LoginProvider`,`ProviderKey`),
  ADD KEY `IX_AspNetUserLogins_UserId` (`UserId`);

--
-- Indexes for table `AspNetUserRoles`
--
ALTER TABLE `AspNetUserRoles`
  ADD PRIMARY KEY (`UserId`,`RoleId`),
  ADD KEY `IX_AspNetUserRoles_RoleId` (`RoleId`);

--
-- Indexes for table `AspNetUsers`
--
ALTER TABLE `AspNetUsers`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `UserNameIndex` (`NormalizedUserName`),
  ADD KEY `EmailIndex` (`NormalizedEmail`);

--
-- Indexes for table `AspNetUserTokens`
--
ALTER TABLE `AspNetUserTokens`
  ADD PRIMARY KEY (`UserId`,`LoginProvider`,`Name`);

--
-- Indexes for table `RefreshTokens`
--
ALTER TABLE `RefreshTokens`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_RefreshTokens_UserId` (`UserId`);

--
-- Indexes for table `tb_paymentdetail`
--
ALTER TABLE `tb_paymentdetail`
  ADD PRIMARY KEY (`paymentDetailId`);

--
-- Indexes for table `__EFMigrationsHistory`
--
ALTER TABLE `__EFMigrationsHistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `AspNetRoleClaims`
--
ALTER TABLE `AspNetRoleClaims`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `AspNetUserClaims`
--
ALTER TABLE `AspNetUserClaims`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `RefreshTokens`
--
ALTER TABLE `RefreshTokens`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `tb_paymentdetail`
--
ALTER TABLE `tb_paymentdetail`
  MODIFY `paymentDetailId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `AspNetRoleClaims`
--
ALTER TABLE `AspNetRoleClaims`
  ADD CONSTRAINT `FK_AspNetRoleClaims_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `AspNetRoles` (`id`) ON DELETE CASCADE;

--
-- Constraints for table `AspNetUserClaims`
--
ALTER TABLE `AspNetUserClaims`
  ADD CONSTRAINT `FK_AspNetUserClaims_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`id`) ON DELETE CASCADE;

--
-- Constraints for table `AspNetUserLogins`
--
ALTER TABLE `AspNetUserLogins`
  ADD CONSTRAINT `FK_AspNetUserLogins_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`id`) ON DELETE CASCADE;

--
-- Constraints for table `AspNetUserRoles`
--
ALTER TABLE `AspNetUserRoles`
  ADD CONSTRAINT `FK_AspNetUserRoles_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `AspNetRoles` (`id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_AspNetUserRoles_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`id`) ON DELETE CASCADE;

--
-- Constraints for table `AspNetUserTokens`
--
ALTER TABLE `AspNetUserTokens`
  ADD CONSTRAINT `FK_AspNetUserTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`id`) ON DELETE CASCADE;

--
-- Constraints for table `RefreshTokens`
--
ALTER TABLE `RefreshTokens`
  ADD CONSTRAINT `FK_RefreshTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`id`) ON DELETE RESTRICT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

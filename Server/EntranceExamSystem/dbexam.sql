-- phpMyAdmin SQL Dump
-- version 3.2.4
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Mar 07, 2015 at 10:25 AM
-- Server version: 5.1.41
-- PHP Version: 5.3.1

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `computerized_examination`
--
CREATE DATABASE `computerized_examination` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `computerized_examination`;

-- --------------------------------------------------------

--
-- Table structure for table `tblexaminee`
--

CREATE TABLE IF NOT EXISTS `tblexaminee` (
  `ExamineeID` int(10) NOT NULL AUTO_INCREMENT,
  `SchoolID` varchar(50) DEFAULT NULL,
  `FirstName` varchar(50) DEFAULT NULL,
  `MiddleName` varchar(50) DEFAULT NULL,
  `LastName` varchar(50) DEFAULT NULL,
  `Gender` varchar(20) DEFAULT NULL,
  `Yr` varchar(50) DEFAULT NULL,
  `Section` varchar(10) DEFAULT NULL,
  `CPNo` varchar(50) DEFAULT NULL,
  `LanguageTaken` varchar(80) DEFAULT NULL,
  PRIMARY KEY (`ExamineeID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=1010 ;

--
-- Dumping data for table `tblexaminee`
--

INSERT INTO `tblexaminee` (`ExamineeID`, `SchoolID`, `FirstName`, `MiddleName`, `LastName`, `Gender`, `Yr`, `Section`, `CPNo`, `LanguageTaken`) VALUES
(1001, '11-11292', 'Peter John', 'Baysa', 'Casasola', 'MALE', '2ND', 'C', '98765432112', 'VB.NET'),
(1002, '13-11454', 'Michael', 'Adriano', 'Matias', 'MALE', '2ND', 'C', '98765432121', 'Photoshop'),
(1003, '13-10224', 'Femart', 'Bulan', 'Cabacungan', 'MALE', '2ND', 'B', '98512321321', 'VB.NET'),
(1004, '12-54321', 'Marcelino', 'Gasmin', 'Barroga', 'MALE', '2ND', 'C', '09876543211', 'JAVA'),
(1005, '12-10000', 'Lorwin', 'Aguilar', 'Dela Cruz', 'MALE', '3RD', 'C', '12345678901', 'vb6'),
(1006, '12-34567', 'Peter John', 'Baysa', 'Casasola', 'MALE', '2ND', 'C', '09061711567', 'VB.NET'),
(1007, '10-67890', 'Balagtas', 'Tamani', 'Balagtas', 'FEMALE', '4TH', 'A', '12213221321', 'HTML'),
(1008, '11-22222', 'Jelyn', 'DIKOALAM', 'Vosotros', 'FEMALE', '1ST', 'C', '', 'TURBO C'),
(1009, '11-11111', 'Peejay', 'AS', 'Manaligod', 'MALE', '4TH', 'C', '', 'VB.NET');

-- --------------------------------------------------------

--
-- Table structure for table `tblexamineeanswer`
--

CREATE TABLE IF NOT EXISTS `tblexamineeanswer` (
  `ExamineeID` varchar(45) DEFAULT NULL,
  `Question` varchar(45) DEFAULT NULL,
  `Answer` varchar(80) DEFAULT NULL,
  `CorrectAnswer` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblexamineeanswer`
--

INSERT INTO `tblexamineeanswer` (`ExamineeID`, `Question`, `Answer`, `CorrectAnswer`) VALUES
('1001', '12345weqwe', '12345', '12345'),
('1001', 'sdsda', 'fgfdgh', 'fgfdgh'),
('1001', 'CSS?', 'CSS', 'CSS'),
('1001', 'Sino si Kassius?', 'Clay', 'Clay'),
('1001', 'What is DBMS?', 'DBMS', 'DATABASE MANAGEMENT SYSTEM'),
('1001', 'SAD?', 'System Analysis and Design', 'System Analysis and Design'),
('1001', 'ITA?', 'asAD', 'asAD'),
('1005', 'ITA?', 'asAD', 'asAD'),
('1005', '12345weqwe', '123456', '12345');

-- --------------------------------------------------------

--
-- Table structure for table `tblmanageexam`
--

CREATE TABLE IF NOT EXISTS `tblmanageexam` (
  `no` varchar(15) NOT NULL,
  `TimeDuration` varchar(50) DEFAULT NULL,
  `NumberofItems` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblmanageexam`
--

INSERT INTO `tblmanageexam` (`no`, `TimeDuration`, `NumberofItems`) VALUES
('1', '1', '7');

-- --------------------------------------------------------

--
-- Table structure for table `tblquestions`
--

CREATE TABLE IF NOT EXISTS `tblquestions` (
  `QID` int(11) NOT NULL AUTO_INCREMENT,
  `Question` varchar(100) NOT NULL,
  `choice1` varchar(100) NOT NULL,
  `choice2` varchar(100) NOT NULL,
  `choice3` varchar(100) NOT NULL,
  `choice4` varchar(100) NOT NULL,
  `answer` varchar(100) NOT NULL,
  PRIMARY KEY (`QID`,`Question`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=11 ;

--
-- Dumping data for table `tblquestions`
--

INSERT INTO `tblquestions` (`QID`, `Question`, `choice1`, `choice2`, `choice3`, `choice4`, `answer`) VALUES
(4, 'What is DBMS?', 'DBMS', '234512345', 'DATABASE MANAGEMENT SYSTEM', 'DATABASE MANAGEMENT SYSTEM', 'DATABASE MANAGEMENT SYSTEM'),
(5, '12345weqwe', '12345', '123456', '23456789', '23456789', '12345'),
(6, 'Sino si Kassius?', 'Clay', 'Sales', 'Malakas ang 3p', 'Malakas ang 3p', 'Clay'),
(7, 'ITA?', 'asAD', 'sadsad', 'fsdfsd', 'fsdfsd', 'asAD'),
(8, 'CSS?', 'CSS', 'sadsdf', 'sdfsfsfsd', 'csvcsf', 'CSS'),
(9, 'SAD?', 'System Analysis and Design', 'SasAD', 'DDSF', 'DSFSD', 'System Analysis and Design'),
(10, 'sdsda', 'sdfsdfd', 'fdgsdfg', 'dgfsdgd', 'fgfdgh', 'fgfdgh');

-- --------------------------------------------------------

--
-- Table structure for table `tblresults`
--

CREATE TABLE IF NOT EXISTS `tblresults` (
  `ResultNo` int(11) NOT NULL AUTO_INCREMENT,
  `ExamineeID` int(11) NOT NULL,
  `SchoolID` varchar(50) NOT NULL,
  `DateExam` varchar(50) NOT NULL,
  `Score` varchar(11) NOT NULL,
  PRIMARY KEY (`ResultNo`),
  UNIQUE KEY `ExamineeID` (`ExamineeID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=30 ;

--
-- Dumping data for table `tblresults`
--

INSERT INTO `tblresults` (`ResultNo`, `ExamineeID`, `SchoolID`, `DateExam`, `Score`) VALUES
(28, 1001, '11-11292', '3/7/2015', ' 6/7'),
(29, 1005, '12-10000', '3/7/2015', ' 1/7');

-- --------------------------------------------------------

--
-- Table structure for table `tbluser`
--

CREATE TABLE IF NOT EXISTS `tbluser` (
  `Username` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL,
  PRIMARY KEY (`Username`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbluser`
--

INSERT INTO `tbluser` (`Username`, `Password`) VALUES
('ITAssociates', '1234');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

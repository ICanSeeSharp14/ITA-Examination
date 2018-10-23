-- phpMyAdmin SQL Dump
-- version 4.2.11
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Aug 25, 2017 at 03:17 AM
-- Server version: 5.6.21
-- PHP Version: 5.6.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `computerized_examination`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblexaminee`
--

CREATE TABLE IF NOT EXISTS `tblexaminee` (
`ExamineeID` int(10) NOT NULL,
  `SchoolID` varchar(50) DEFAULT NULL,
  `FirstName` varchar(50) DEFAULT NULL,
  `MiddleName` varchar(50) DEFAULT NULL,
  `LastName` varchar(50) DEFAULT NULL,
  `Gender` varchar(20) DEFAULT NULL,
  `Yr` varchar(50) DEFAULT NULL,
  `Section` varchar(10) DEFAULT NULL,
  `CPNo` varchar(50) DEFAULT NULL,
  `LanguageTaken` varchar(80) DEFAULT NULL,
  `ExamCode` varchar(30) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblexaminee`
--

INSERT INTO `tblexaminee` (`ExamineeID`, `SchoolID`, `FirstName`, `MiddleName`, `LastName`, `Gender`, `Yr`, `Section`, `CPNo`, `LanguageTaken`, `ExamCode`) VALUES
(2, '11-11292', 'Peter John', 'Baysa', 'Casasola', 'MALE', '2ND', 'C', '09061711567', 'C++', 'hnIROALGF');

-- --------------------------------------------------------

--
-- Table structure for table `tblexamineeanswer`
--

CREATE TABLE IF NOT EXISTS `tblexamineeanswer` (
  `ExamineeID` varchar(10) DEFAULT NULL,
  `Question` varchar(500) DEFAULT NULL,
  `Answer` varchar(150) DEFAULT NULL,
  `CorrectAnswer` varchar(150) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

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
('1', '20', '50');

-- --------------------------------------------------------

--
-- Table structure for table `tblquestions`
--

CREATE TABLE IF NOT EXISTS `tblquestions` (
`QID` int(11) NOT NULL,
  `Question` varchar(500) NOT NULL,
  `choice1` varchar(100) NOT NULL,
  `choice2` varchar(100) NOT NULL,
  `choice3` varchar(100) NOT NULL,
  `choice4` varchar(100) NOT NULL,
  `answer` varchar(100) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=170 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblquestions`
--

INSERT INTO `tblquestions` (`QID`, `Question`, `choice1`, `choice2`, `choice3`, `choice4`, `answer`) VALUES
(4, 'Which of the following can be both input and output device?', 'Joystick', 'Monitor', 'Modem', 'None of the above', 'Modem'),
(11, 'Which command will stop an infinite loop?', 'Alt - C', 'Shift - C', 'Alt -F4', 'Ctrl - C', 'Ctrl - C'),
(12, 'It display information in visual  for using text and graphics what is it? ', 'System unit', 'Keyboard', 'Monitor', 'All of the above', 'Monitor'),
(14, 'It is a positional number system which has only 2 symbols what is it?', 'Binary number', 'Binary conversion', 'Binary digit', 'All of the above', 'Binary number'),
(15, 'In what year Blaise Pascal invented the machine called pascaline?', '1669', '1642', '1651', 'All of the above', '1642'),
(16, 'It is a pointing device used to select items on your screen what is it?', 'Modem', 'Mouse', 'Keyboard', 'All of the above', 'Mouse'),
(17, 'If 1=5, 2=8, 3=12, 4=16 then 5=?', '20', '24', '1', '4', '1'),
(18, 'What is a NIC?', 'No Internet Connection', 'Network Interface Card', 'Netware Intranet Controller', 'Network Interference Control', 'Network Interface Card'),
(19, 'From what location are the 1st computer instructions available on boot up?', 'ROM BIOS', 'CPU', 'boot.ini', 'CONFIG.SYS', 'ROM BIOS'),
(20, 'Which Motherboard form factor uses one 20 pin connector', 'ATX', 'AT', 'BABY AT', 'All of the above', 'ATX'),
(21, 'Frames from one LAN can be transmitted to another LAN via the device', 'Router', 'Bridge', 'Repeater', 'Modem', 'Bridge'),
(22, 'A six digit Hex color code (#ADD8E6) defines values of Red, Blue, and Green in what order?', '#RRBBGG', '#GGRRBB', '#RRGGBB', '##BBRRGG', '#RRGGBB'),
(23, 'JavaScript is ....?', 'a client-side scripting language', 'a server-side scripting language', 'both a and b', 'another name for java', 'a client-side scripting language'),
(25, 'How many layers are in the OSI model?', '4', '5', '7', '6', '7'),
(26, 'Which of the following is not a type of hard drive?', 'IDE', 'IDS', 'SATA', 'SCSI', 'IDS'),
(27, 'Which of the following people was a co-founder of Microsoft?', 'Steve wozniak', 'Paul Allen', 'Bill Moggride', 'Gary Starkweather', 'Paul Allen'),
(28, 'What cable connects a cable modem to a wireless router?', 'CAT5 Cable', 'RJ-11 Cable', 'Coaxial Cable', 'None of the above', 'CAT5 Cable'),
(29, 'he Central Processing Unit is an embeded chip that acts as the ''brains'' of a computer. What Intel chip was used in the Altair (the first real personal computer)?', '6502', '6400', '8086', '8080', '8080'),
(30, 'What is the default port number for Apache and most web servers?', '20', '27', '80', '887', '80'),
(31, 'In Perl, what does a scalar variable always begin with?', '@', '#', '$', '%', '$'),
(32, 'What company built the first processor in the Apple Macintosh', 'AMD', 'Apple', 'Intel', 'Motorola', 'Motorola'),
(33, 'A DNS translates a domain name into what?', 'Binary', 'Hex', 'IP', 'URL', 'IP'),
(34, 'What is SSL short for?', 'Secure Socket LAN', 'Software Security Layer', 'Secure Software Layer', 'Secure Socket Layer', 'Secure Socket Layer'),
(35, 'Which of the below has the most capacity?', '100GB', '100KB', '100MB', '100TB', '100TB'),
(37, 'What type of memory is volatile', 'Cache', 'Hard Drive', 'RAM', 'ROM', 'RAM'),
(38, 'Which of the below is not a type of computer battery?', 'BIOS', 'CMOS', 'Li-ion', 'NiMH', 'BIOS'),
(39, 'What is a firewall?', 'Antivirus Program', 'Internet Blocker', 'Internet Filter', 'Internet logger', 'Internet Filter'),
(40, 'In Perl, if $var = "1"; and you print ''You win $var dollar''; what would it return?', 'You win $var dollar', 'You win $1 dollar', 'You win 1 dollar', 'You win 0 dollar', 'You win $var dollar'),
(41, 'Which of the below utilities allow you to view a drives partition information?', 'Chkdsk', 'Disk Management', 'Device Manager', 'Scandisk', 'Disk Management'),
(42, 'Which of the below media types hold the most information?', 'Blu-ray', 'CD', 'DVD', 'Floppy diskette', 'Blu-ray'),
(43, 'Where is the BIOS stored?', 'on the hard drive', 'On a diskette', 'On a USB drive', 'On a flash memory chip', 'On a flash memory chip'),
(44, 'What does TCP breaks data into?', 'Binary', 'Bits', 'Files', 'Packets', 'Packets'),
(45, 'What language does the computer use and understand?', 'High-Level', 'Assembly', 'Machine', 'All of the above', 'Machine'),
(46, 'The Intel Pentium bug was an issue with what part of the CPU?', 'Cache', 'FPU/Floating Point Unit', 'Socket', 'There was no bug/flaw', 'FPU/Floating Point Unit'),
(47, 'What does the term IRQ stand for?', 'Input Request Que', 'Interrupt Request Que', 'Interrupt Request', 'Input Request', 'Interrupt Request'),
(48, 'A Cathode Ray Tube is found in what?', 'CPU', 'Printer', 'Monitor', 'Scanner', 'Monitor'),
(49, 'A Computer Virus cannot be contracted by which of the below.', 'Floppy diskette', 'E-mail', 'Scanner', 'Internet Downloads', 'Scanner'),
(50, 'What is a cookie?', 'Cooking software', 'Web site', 'Internet information file', 'Hacker file', 'Internet information file'),
(51, 'What is a NIC?', 'Network Interupt Connection', 'Network Intranet Controller', 'Network Interface Card', 'Network Interference Control', 'Network Interface Card'),
(52, 'Which command lists files in MS-DOS?', 'cd', 'ls', 'dir', 'list', 'dir'),
(53, 'On what date was the debut of the first IBM Personal Computer?', 'January 21 1979', 'August 21, 1980', 'January 12, 1982', 'August 12, 1981', 'August 12, 1981'),
(54, 'How many bits is a byte?', '32', '16', '8', '4', '8'),
(55, 'Which of these is not a computer?', 'Macintosh', 'Aptiva', 'Paseo', 'Acorn', 'Paseo'),
(56, 'The Central Processing Unit is an embeded chip that acts as the ''brains'' of a computer. What Intel chip was used in the Altair (the first real personal computer)?', '8086', '8286', '6400', '8080', '8080'),
(57, 'The letters, "DOS" stand for...', 'Data Operating System', 'Disk Operating System', 'Data Out System', 'Disk Out System', 'Disk Operating System'),
(58, 'Which of the following is not an image file?', 'JPEG', 'GIF', 'TMP', 'BMP', 'TMP'),
(59, '''CD'' computer abbreviation usually means ?', 'Compact Disk', 'Command Description', 'Change Data', 'Copy Density', 'Compact Disk'),
(60, 'IC chips used in computers are usually made of', 'Lead', 'Silicon', 'Chromium', 'Gold', 'Silicon'),
(61, 'CD–ROM is a kind of', 'Optical disk', 'Magnetic disk', 'Magneto–Optical disk', 'None of these', 'Magnetic Disk'),
(62, 'The first mechanical computer designed by Charles Babbage was called', 'Abacus', 'Analytical Engine', 'Calculator', 'Processor', 'Analytical Engine'),
(63, 'A device that converts digital signals to analog signals is', 'A packet', 'A modem', 'A block', 'Both (A) and (B)', 'A modem'),
(64, 'Full form of TCP is', 'Transmission control program', 'Totalling control program', 'Transmission control protocol', 'Total control Protocol', 'Transmission control protocol'),
(65, 'Processors of all computers, whether micro, mini or mainframe must have', ' ALU', 'Primary Storage', 'Control unit', 'All of the above', 'All of the above'),
(66, 'What is the control unit''s function in the CPU?', 'To transfer data to primary storage  ', 'to store program instruction', 'to perform logic operations', 'to decode program instruction', 'to decode program instruction'),
(67, 'CHKDSK command is used to', 'Analyze the hard disk error ', 'Diagnose the hard disk error', 'Report the status of files on disk', 'All of the above', 'All of the above'),
(68, 'Which of the following registers is used to keep track of address of the memory location where the next instruction is located?', 'Memory Address Register  ', 'Memory Data Register', 'Instruction Register', 'Program Register', 'Program Register'),
(69, 'Which file is the batch file that is read while booting a computer?', 'Autoexec.bat', 'Autoexecutive.bat', 'Auto.bat', 'Auto-batch', 'Autoexec.bat'),
(70, ' FAT stands for', 'File Accomodation Table', 'File Access Tape', 'File Allocation Table', 'File Activity Table', 'File Allocation Table'),
(71, 'Full form of MS-DOS is', 'Micro System Disk Operating System', 'Micro Simple Disk Operating System', 'Micro Soft Disk Operating System', 'Micro Sort Disk Operating System', 'Micro Soft Disk Operating System'),
(72, ' Which command is used to clear the screen', 'Cls', 'Clear', 'Clrscreen', 'All of the above', 'Cls'),
(73, 'Which command is used to backup in DOS 6+ Version', 'BACKUP', 'MSBACKUP', 'MSBACKEDUP', 'All of the above', 'MSBACKUP'),
(74, 'Which command is used to change the file name?', 'Ren', 'Rename', 'Both A and B', 'None of the above', 'Both A and B'),
(75, 'Which of the following memories is an optical memory?', 'Floppy Disk', 'Bubble Memories', 'CD-ROM', 'Core Memories', 'CD-ROM'),
(76, 'What character is used in an OR operator?', 'Ampersand', 'Bracket', 'Colon', 'Pipe', 'Pipe'),
(77, 'What does the term MIME stand for?', 'Mail Internet Mail Exchange', 'Mail Interleave Method Exchange', 'Multipurpose Internet Mail Extensions', 'Multipurpose Interleave Mail Exchange', 'Multipurpose Internet Mail Extensions'),
(78, 'What is downloading?', 'Sending a file on the internet', 'Retrieving a file on the internet', 'Moving a file from a floppy', 'Scanning a files', 'Retrieving a file on the internet'),
(79, 'What is XP short for in Windows XP?', 'Whistler', 'Extra Powerful', 'eXPerience', 'It is not an acronym', 'eXPerience'),
(80, 'ypically, hard disk drives employ what technology as a storage mechanism?', 'Laser', 'Magnetic', 'Light', 'Chemical', 'Magnetic'),
(81, 'Which of the following is not or was not a Internet browser?', 'Internet Explorer', 'Hotmail', 'Netscape', 'Opera', 'Hotmail'),
(82, 'Which of the following is part of a hard disk drive?', 'Mother Board', 'Platter', 'Laser', 'Riser Board', 'Platter'),
(83, 'Which of the following is not a programming language?', 'Lisp', 'Siddharta', 'Brainfuck', 'Perl', 'Siddharta'),
(84, 'Which of the following is not a mouse technology?', 'Mechanical', 'Optical', 'Motorized', 'Optical-Technology', 'Motorized'),
(85, 'Which of the following companies is still a hard disk drive manufacturer?', 'Dell', 'Microsoft', 'Corner', 'Seagate', 'Seagate'),
(86, 'Which of the follwoing video resolution is not correct?', '640x480', '800x680', '1024x768', '1152x864', '800x680'),
(87, 'Which of the following formulas add cells a1 through a5 in Microsoft Excel?', '=sum(A1+A5)', '=sum(A1:A5)', '=add(A1+A5)', '=total(A1:A5)', '=sum(A1:A5)'),
(88, 'Which of the following is not a search engine?', 'Google', 'Lycos', 'Amazon', 'Hotbot', 'Amazon'),
(89, 'What was the first Intel processor?', '3080', '4004', '8080', '8086', '4004'),
(90, 'Which of the following file system did Microsoft Windows 95 not support?', 'NTFS', 'ext3', 'HPFS', 'All of the above', 'All of the above'),
(91, 'Which of the following is not related to computer video.', 'DirectX', 'AC-3', 'GeForce', 'OpenGL', 'AC-3'),
(92, 'How many pins does a IDE/EIDE connector have?', '20 pins', '25 pins', '40 pins', '50 pins', '40 pins'),
(93, 'Which of the following is not a type of DVD drive?', 'DVD-RD', 'DVD-RW', 'DVD+RW', 'DVD-RAM', 'DVD-RD'),
(94, ' Which of the following does not allow communication with another computer?', 'Network Card', 'Serial Port', 'VGA Port', 'Modem', 'VGA Port'),
(95, 'Which of the following is not a Linux text editor?', 'Vim', 'Perl', 'Pico', 'Vi', 'Perl'),
(96, 'How many keys does the standard Windows US keyboard with a number pad have?', '74', '94', '107', '104', '104'),
(97, 'Which of the following is not a type of network?', 'MAN', 'HAN', 'LPN', 'VPN', 'LPN'),
(98, ' Which of the following types of memory can the computer not save information to?', 'DRAM', 'RAM', 'ROM', 'SRAM', 'ROM'),
(99, 'What is another common name for a motherboard?', 'MOBO', 'Father Board', 'Main System', 'System Board', 'System Board'),
(100, 'Which year was Microsoft Windows XP released?', '2001', '2002', '2001', '2003', '2001'),
(101, 'Which of the following people is credited for developing the World Wide Web?', 'Alan Kay', 'Tim Berners-Lee', 'Jack Kilby', 'Robert Noyce', 'Tim Berners-Lee'),
(102, 'What is the maximum transfer speed of the wireless 802.11a standard?', '100 Mbps', '54 Mbps', '12 Mbps', '10 Mbps', '54 Mbps'),
(103, 'Which of the following HTML tags is correct for inserting an image?', '<a img="">', '<img src="">', '<image source="">', '<image="">', '<img src="">'),
(104, 'Which of the following is not a network connector?', 'DVI', 'RJ-45', 'BNC', 'DB-15', 'DVI'),
(105, 'What does LOL stand for?', 'Log Off Laptop', 'Laughing Out Loud', 'Lack Of Laughter', 'Lag On Laptop', 'Laughing Out Loud'),
(106, 'What is the original capacity of a standard CD?', '650MB', '600MB', '500MB', '200MB', '650MB'),
(107, 'Which of the following is not a codec?', 'DivX', 'Evid', 'FLAC', 'XviD', 'Evid'),
(108, 'What is 10100110?', '166', '170', '151', '57', '166'),
(109, 'Which part of the computer does an EIDE cable connect to?', 'Floppy Drive', 'HDD', 'Sound Card', 'Video Card', 'HDD'),
(110, 'Which of the following is the GUI commonly used with Linux?', 'LUI', 'GPL', 'GNOME', 'GNU', 'GNOME'),
(111, 'Which of the following is not a type of computer memory?', 'DIMM', 'MIMM', 'RIMM', 'SIMM', 'MIMM'),
(112, 'Who created the first mouse?', 'Bill Gates', 'Douglas Englebart', 'John Mauchly', 'Robert Noyce', 'Douglas Englebart'),
(113, 'Which of the following is not an anti-virus company?', 'AVG', 'Panda', 'Sysmantec', 'Xargon', 'Xargon'),
(114, 'What is the transfer rate of USB 2.0?', '12Mbps', '64Mbps', '256Mbps', '480Mbps', '480Mbps'),
(115, 'What MS-DOS command can display hidden files?', 'attrib', ' cd', 'ls', 'more', 'attrib'),
(116, 'What command clears the screen in MS-DOS and the Windows command line?', 'cd', 'cls', 'clear', 'echo', 'cls'),
(117, '  Which of the following is not a social network site?', 'Amazon', 'MySpace', 'Orkut', 'Twitter', 'Amazon'),
(118, 'What version of Windows was first to be released after Windows 98?', 'Windows 99', 'Windows 2000', 'Windows ME', 'Windows XP', 'Windows 2000'),
(119, 'Which of the following is not an iPod that Apple has released?', 'iPod Mini', 'iPod Nano', 'iPod Shuffle', 'iPod Vision', 'iPod Vision'),
(120, ' What is Apache?', 'Browser', 'Computer', 'Computer Virus', 'Web Server', 'Web Server'),
(121, ' What is XML short for?', 'eXtensive Markup Language', 'eXtensive Markup List', 'eXtension Markup List', 'eXtensible Markup Language', 'eXtensible Markup Language'),
(122, ' What is the minimum memory requirements for Microsoft Windows XP?', '32MB', '64MB', '128MB', '256MB', '64MB'),
(123, 'Which below IP address would be used for a local network?', '74.125.127.100', '69.72.169.241', '192.168.1.100', '209.131.36.100', '192.168.1.100'),
(125, 'What drive usually represents the main hard disk drive?', 'D', 'E', 'F', 'C', 'C'),
(126, 'Which of the following application programs is best suited for performing calculations and analyzing data?', 'Word Processing Program', 'Spreadsheet Program', 'Database Program', 'Presentation Program', 'Spreadsheet Program'),
(127, ' What is subscript?', 'Text that is smaller and below the baseline', 'Text that is smaller and above the baseline', 'Text that is larger and below the baseline', 'Text that is larger and above the baseline', 'Text that is smaller and below the baseline'),
(128, 'A problem with parity error indicates a problem with:  ', 'hard drive', 'I/O Controller', 'power supply', 'memory', 'memory'),
(129, ' Your system boots up but you don''t hear a beep, which part should you check first?', 'RAM', 'System Board', 'CPU', 'Speaker', 'Speaker'),
(130, 'Which of the following connectors is used with a CD-ROM or other disc drive?', 'DB-15', 'Molex', 'RJ-11', 'PS/2', 'Molex'),
(131, 'Which of the following connectors is used with a CD-ROM or other disc drive?', 'DB-15', 'Molex', 'RJ-11', 'PS/2', 'Molex'),
(132, 'which of the following is not related to the Internet and web development?', 'DOS', 'HTML', 'Java', 'PHP', 'DOS'),
(133, 'Which of the following HTML lines is correct?', '<strong>bold text<strong>', '</strong>bold text</strong>', '<b>Bold text<b>', '<b>bold text</b>', '<b>bold text</b>'),
(134, 'Which of the following is not a type of hard drive interface?', 'IDE', 'IDS', ' SATA', 'SCSI', 'IDS'),
(135, 'What are three types of networks?', 'LAN TAN WAN', 'LAN SAN WAN', 'LAN PAN WAN', 'LAN MAN WAN', 'LAN MAN WAN'),
(136, 'You run a SELECT statement, and multiple duplicates of values are retrieved. What keyword can you use to retrieve only the non duplicate data?', 'DUPLICATE', 'INDIVIDUAL', 'SEPERATE', 'DISTINCT', 'DISTINCT'),
(137, 'What does PHP stand for?', 'PHP:Hypertext Processor', 'Personal Home Page', 'Private Home Page', 'Public Hypertext Processor', 'PHP:Hypertext Processor'),
(138, 'What is the correct way to connect to a MySQL database?', 'mysql_open("localhost");', 'connect_mysql("localhost")', 'mysql_connect("localhost");', 'dbopen("localhost");', 'mysql_connect("localhost");'),
(139, 'What does break; do?', 'Ends execution of the current switch structure', 'Moves on to the next iteration of the current for, foreach, while, do-while or switch structure', 'Ends execution of the current for, foreach, while, do-while or switch structure', 'All of the above', 'Ends execution of the current for, foreach, while, do-while or switch structure'),
(140, 'PHP comments for a single line have the following syntax:', '/* comments /*', '#', '//', 'Both A and B', 'Both A and B'),
(141, 'In PHP, the error control operator is ________.', '*', '%', '@', '&', '@'),
(142, 'What does CSS stand for?   ', 'Creative Style Sheets', 'Computer Style Sheets', 'Cascading Style Sheets', 'Cascading Style Sheet', 'Cascading Style Sheets'),
(143, 'You reject someone''s proposal to use File-based databases. Which of the following are the disadvantages of such databases? ', 'repetition of data', 'separation of data', 'incompatibility of files', 'All of the above', 'All of the above'),
(145, 'How do you insert a comment in a CSS file?', '/* this is a comment */', ''' this is a comment', '// this is a comment //', '// this is a comment', '/* this is a comment */'),
(146, ' How do you change the text color of an element?', ' text-color:', 'text-color=', 'color:', 'font-color:', 'font-color:'),
(147, 'How do you display hyperlinks without an underline? ', 'a {decoration:no underline}', 'a {text-decoration:no underline}', 'a {underline:none}', 'a {text-decoration:none}', 'a {text-decoration:none}'),
(148, 'Which HTML tag is used to define an internal style sheet?      ', '<script>', '<stylesheet>', '<style>', '<css>', '<style>'),
(149, 'How do you display a border like this: The top border = 10 pixels, The bottom border = 5 pixels, The left border = 20 pixels, The right border = 1pixel?     ', 'border-width:10px 20px 5px 1px', 'border-width:10px 1px 5px 20px', 'border-width:10px 5px 20px 1px', 'border-width:5px 20px 10px 1px', 'border-width:10px 1px 5px 20px'),
(150, 'What''s the maximum value can an INT data type hold?', '2,147,483,647', '2,147,483,648', '4,294,967,295', '4,294,967,296', '2,147,483,647'),
(151, 'What is the correct way to create a function in PHP?', 'function myFunction()', 'new_function myFunction()', 'create myFunction()', 'create function myFunction()', 'function myFunction()'),
(153, 'Where are the device drivers settings for Windows stored?', 'BIOS', 'CMOS', 'EEPROM', 'REGISTRY', 'REGISTRY'),
(154, 'Which of the following types of JDBC drivers allows your Java programs to communicate with the ODBC driver of your DBMS?', 'Pure Java', 'JDBC-ODBC Bridge', 'Native-API', 'JDBC-net', 'JDBC-ODBC Bridge'),
(155, 'Three SQL, DDL, CREATE commands are ________ .', 'Schema, Base and Table', 'Key, Base and Table', 'Base, Table and Schema', 'Schema, Table and View', 'Schema, Table and View'),
(156, 'Data are ________ in client/server computing.', 'never sent to the client machine', 'sent in complete copies for the client to filter and sor', 'sent only upon the client''s request', 'sent in very large sections to save processing time', 'sent only upon the client''s request'),
(157, ' Which one of the following is a direct benefit of databse normalization?', 'higher query processing efficiency', 'smaller number of tables', 'reduced data redundancy', 'reduced I/O for most queries', 'reduced data redundancy'),
(158, 'A field or a combination of fields that has a unique value is called :', 'Foreign key', 'Primary key', 'Secondary key', 'Alternate key', 'Primary key'),
(159, 'What rows will this select statement return ? SELECT * FROM products WHERE ordernumber > = 1000', 'All rows in the products table whose order number is greater than or equal to 1000', 'All rows in the products table whose order number is less than or equal to 1000', 'The first 1000 rows of the product table', 'All rows in the products table whose order number is greater than 1000', 'All rows in the products table whose order number is greater than or equal to 1000'),
(160, 'Most popular commercial Database', 'SQL Server', 'MySQL server', 'Oracle', 'MS Access', 'Oracle'),
(161, ' In RDBMS, Data is presented as a collection of', 'Relation', 'Attribute', 'Table', 'Entity', 'Relation'),
(162, 'Full Form of SQL', 'Standard Query Language', 'Serial Query Language', 'Structured Query Language', 'None of the Above', 'Structured Query Language'),
(163, 'What is the control unit''s function in the CPU', 'To transfer data to primary storage', 'To store program instructions', 'To perform logic functions', 'To decode program instructions', 'To perform logic functions'),
(164, 'Which part interprets program instructions and initiate control operations.', 'Input', 'Storage Unit', 'Logic Unit', 'Control Unit', 'Control Unit'),
(165, 'A computer program that converts assembly language to machine language is', 'Compiler', 'Interpreter', 'Assembler', 'Comparator', 'Assembler'),
(166, 'The section of the CPU that selects, interprets and sees to the execution of program instructions', 'Memory', 'Register Unit', 'ALU', 'Control Unit', 'Control Unit'),
(167, ' A systems programming language for microcomputers in the Intel family is', 'PL/C', 'PL/CT', 'PL/M', 'PLA', 'PL/M'),
(168, 'A program that is employed in the development, repair or enhancement of other programs is known as', 'System software', 'Software tool', 'Application program', 'Utility program', 'System software'),
(169, 'Large computer system typically uses:', 'Line printers', 'Ink-jet printers', 'Dot-matrix printers', 'Daisy wheel printers', 'Line printers');

-- --------------------------------------------------------

--
-- Table structure for table `tblresults`
--

CREATE TABLE IF NOT EXISTS `tblresults` (
`ResultNo` int(11) NOT NULL,
  `ExamineeID` int(11) NOT NULL,
  `SchoolID` varchar(50) NOT NULL,
  `DateExam` varchar(50) NOT NULL,
  `Score` varchar(11) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbluser`
--

CREATE TABLE IF NOT EXISTS `tbluser` (
  `Username` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbluser`
--

INSERT INTO `tbluser` (`Username`, `Password`) VALUES
('ITAssociates', '1234');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblexaminee`
--
ALTER TABLE `tblexaminee`
 ADD PRIMARY KEY (`ExamineeID`);

--
-- Indexes for table `tblquestions`
--
ALTER TABLE `tblquestions`
 ADD PRIMARY KEY (`QID`,`Question`);

--
-- Indexes for table `tblresults`
--
ALTER TABLE `tblresults`
 ADD PRIMARY KEY (`ResultNo`), ADD UNIQUE KEY `ExamineeID` (`ExamineeID`);

--
-- Indexes for table `tbluser`
--
ALTER TABLE `tbluser`
 ADD PRIMARY KEY (`Username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tblexaminee`
--
ALTER TABLE `tblexaminee`
MODIFY `ExamineeID` int(10) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `tblquestions`
--
ALTER TABLE `tblquestions`
MODIFY `QID` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=170;
--
-- AUTO_INCREMENT for table `tblresults`
--
ALTER TABLE `tblresults`
MODIFY `ResultNo` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=5;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

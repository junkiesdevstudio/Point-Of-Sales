-- MySqlBackup.NET 2.0.9.3
-- Dump Time: 2016-05-18 16:19:59
-- --------------------------------------
-- Server version 5.5.27 MySQL Community Server (GPL)


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES latin1 */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- 
-- Definition of tblusers
-- 

DROP TABLE IF EXISTS `tblusers`;
CREATE TABLE IF NOT EXISTS `tblusers` (
  `autoid` int(11) NOT NULL AUTO_INCREMENT,
  `usercode` varchar(50) NOT NULL,
  `fullname` varchar(50) NOT NULL,
  `address` text NOT NULL,
  `email` varchar(50) NOT NULL,
  `telephone` varchar(50) NOT NULL,
  `usertype` int(50) NOT NULL,
  `status` varchar(50) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `datemodify` date NOT NULL,
  `usermodifyby` int(11) NOT NULL,
  `dateadded` date NOT NULL,
  `useraddedby` int(11) NOT NULL,
  PRIMARY KEY (`autoid`),
  KEY `usercode` (`usercode`),
  KEY `usertype` (`usertype`),
  CONSTRAINT `tblusers_ibfk_1` FOREIGN KEY (`usertype`) REFERENCES `tblusertype` (`autoid`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table tblusers
-- 

/*!40000 ALTER TABLE `tblusers` DISABLE KEYS */;
INSERT INTO `tblusers`(`autoid`,`usercode`,`fullname`,`address`,`email`,`telephone`,`usertype`,`status`,`username`,`password`,`datemodify`,`usermodifyby`,`dateadded`,`useraddedby`) VALUES
(1,'ADM-0000','Angging Wahyu Wibowo','Jln.Parangtritis Km4, Sorowajan RT10 Panggungharjo Sewon Bantul','junkiesdevstudio@gmail.com','085702363359',1,'ACTIVE','admin','21232f297a57a5a743894a0e4a801fc3','2005-01-01 00:00:00',1,'2005-01-01 00:00:00',1),
(10,'USR-0001','Bahar Setiawan','Jln.Imogiri Timur, Bantul, Yogyakarta','baharsetiawan@yahoo.co.id','1234567890',2,'ACTIVE','USER-0001','21232f297a57a5a743894a0e4a801fc3','2016-05-18 00:00:00',1,'2016-05-18 00:00:00',1);
/*!40000 ALTER TABLE `tblusers` ENABLE KEYS */;

-- 
-- Definition of tblusertype
-- 

DROP TABLE IF EXISTS `tblusertype`;
CREATE TABLE IF NOT EXISTS `tblusertype` (
  `autoid` int(50) NOT NULL AUTO_INCREMENT,
  `typename` varchar(50) NOT NULL,
  PRIMARY KEY (`autoid`),
  KEY `autoid` (`autoid`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table tblusertype
-- 

/*!40000 ALTER TABLE `tblusertype` DISABLE KEYS */;
INSERT INTO `tblusertype`(`autoid`,`typename`) VALUES
(1,'ADMINISTRATOR'),
(2,'KASIR');
/*!40000 ALTER TABLE `tblusertype` ENABLE KEYS */;


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2016-05-18 16:19:59
-- Total time: 0:0:0:0:57 (d:h:m:s:ms)

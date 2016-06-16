-- MySqlBackup.NET 2.0.9.3
-- Dump Time: 2016-06-16 16:11:57
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
-- Definition of tblcategory
-- 

DROP TABLE IF EXISTS `tblcategory`;
CREATE TABLE IF NOT EXISTS `tblcategory` (
  `autoid` int(50) NOT NULL AUTO_INCREMENT,
  `categorycode` varchar(50) NOT NULL,
  `categoryname` varchar(50) NOT NULL,
  `description` text NOT NULL,
  `dateadded` date NOT NULL,
  `addedby` int(50) NOT NULL,
  PRIMARY KEY (`autoid`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table tblcategory
-- 

/*!40000 ALTER TABLE `tblcategory` DISABLE KEYS */;
INSERT INTO `tblcategory`(`autoid`,`categorycode`,`categoryname`,`description`,`dateadded`,`addedby`) VALUES
(4,'CAT-000000000','BATIK TULIS','batik hand made','2016-06-15 00:00:00',1),
(5,'CAT-000000004','BATIK CAP','batik pabrikan','2016-06-15 00:00:00',1);
/*!40000 ALTER TABLE `tblcategory` ENABLE KEYS */;

-- 
-- Definition of tbldiscount
-- 

DROP TABLE IF EXISTS `tbldiscount`;
CREATE TABLE IF NOT EXISTS `tbldiscount` (
  `autoid` int(50) NOT NULL AUTO_INCREMENT,
  `percent` decimal(50,0) NOT NULL,
  PRIMARY KEY (`autoid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table tbldiscount
-- 

/*!40000 ALTER TABLE `tbldiscount` DISABLE KEYS */;

/*!40000 ALTER TABLE `tbldiscount` ENABLE KEYS */;

-- 
-- Definition of tblmember
-- 

DROP TABLE IF EXISTS `tblmember`;
CREATE TABLE IF NOT EXISTS `tblmember` (
  `autoid` int(50) NOT NULL AUTO_INCREMENT,
  `membercode` varchar(50) NOT NULL,
  `fullname` varchar(50) NOT NULL,
  `address` text NOT NULL,
  `telephone` varchar(50) NOT NULL,
  `status` varchar(50) NOT NULL,
  `discount` int(50) NOT NULL,
  PRIMARY KEY (`autoid`),
  KEY `discount` (`discount`),
  CONSTRAINT `tblmember_ibfk_1` FOREIGN KEY (`discount`) REFERENCES `tbldiscount` (`autoid`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table tblmember
-- 

/*!40000 ALTER TABLE `tblmember` DISABLE KEYS */;

/*!40000 ALTER TABLE `tblmember` ENABLE KEYS */;

-- 
-- Definition of tblproduct
-- 

DROP TABLE IF EXISTS `tblproduct`;
CREATE TABLE IF NOT EXISTS `tblproduct` (
  `autoid` int(11) NOT NULL AUTO_INCREMENT,
  `productcode` varchar(50) NOT NULL,
  `productname` varchar(50) NOT NULL,
  `categoryautoid` int(50) NOT NULL,
  `supplierautoid` int(50) NOT NULL,
  `unitprice` decimal(10,0) NOT NULL,
  `sellingprice` decimal(10,0) NOT NULL,
  `discount` int(20) NOT NULL,
  `stock` int(11) NOT NULL,
  `tanggal` date NOT NULL,
  PRIMARY KEY (`autoid`),
  KEY `categoryautoid` (`categoryautoid`,`supplierautoid`),
  KEY `supplierautoid` (`supplierautoid`),
  CONSTRAINT `tblproduct_ibfk_1` FOREIGN KEY (`categoryautoid`) REFERENCES `tblcategory` (`autoid`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `tblproduct_ibfk_2` FOREIGN KEY (`supplierautoid`) REFERENCES `tblsupplier` (`autoid`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table tblproduct
-- 

/*!40000 ALTER TABLE `tblproduct` DISABLE KEYS */;
INSERT INTO `tblproduct`(`autoid`,`productcode`,`productname`,`categoryautoid`,`supplierautoid`,`unitprice`,`sellingprice`,`discount`,`stock`,`tanggal`) VALUES
(21,'22','BATIK SOLO',4,3,78000,102000,3,0,'2016-06-15 00:00:00'),
(22,'33','BATIK MALANG',4,3,34000,67000,4,6,'2016-06-15 00:00:00'),
(23,'44','BATIK PEKALONGAN',4,3,67000,78000,1,110,'2016-06-15 00:00:00'),
(24,'55','BATIK MAGELANG',4,3,89000,135000,0,100,'2016-06-15 00:00:00'),
(25,'66','BATIK BAYAT',4,3,89000,120000,1,1,'2016-06-15 00:00:00'),
(26,'77','BATIK SEMAR',4,3,32000,45000,1,7,'2016-06-15 00:00:00'),
(27,'88','BATIK JEMBER',4,3,69000,71000,25,100,'2016-06-15 00:00:00'),
(28,'11','BATIK TASIK',4,3,49000,56000,20,17,'2016-06-16 00:00:00');
/*!40000 ALTER TABLE `tblproduct` ENABLE KEYS */;

-- 
-- Definition of tblsales
-- 

DROP TABLE IF EXISTS `tblsales`;
CREATE TABLE IF NOT EXISTS `tblsales` (
  `autoid` int(11) NOT NULL AUTO_INCREMENT,
  `productcode` varchar(30) NOT NULL,
  `invoiceno` varchar(50) NOT NULL,
  `nama_produk` varchar(50) NOT NULL,
  `unitprice` decimal(30,0) NOT NULL,
  `quantity` int(30) NOT NULL,
  `discount` int(30) NOT NULL,
  `subtotal` int(30) NOT NULL,
  `cash` decimal(30,0) NOT NULL,
  `changecash` decimal(30,0) NOT NULL,
  `dateadded` date NOT NULL,
  PRIMARY KEY (`autoid`)
) ENGINE=InnoDB AUTO_INCREMENT=113 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table tblsales
-- 

/*!40000 ALTER TABLE `tblsales` DISABLE KEYS */;
INSERT INTO `tblsales`(`autoid`,`productcode`,`invoiceno`,`nama_produk`,`unitprice`,`quantity`,`discount`,`subtotal`,`cash`,`changecash`,`dateadded`) VALUES
(111,'11','1466068013','BATIK TASIK',49000,1,20,39200,40000,800,'2016-06-16 00:00:00'),
(112,'33','1466068062','BATIK MALANG',34000,2,4,65280,70000,4720,'2016-06-16 00:00:00');
/*!40000 ALTER TABLE `tblsales` ENABLE KEYS */;

-- 
-- Definition of tblsupplier
-- 

DROP TABLE IF EXISTS `tblsupplier`;
CREATE TABLE IF NOT EXISTS `tblsupplier` (
  `autoid` int(50) NOT NULL AUTO_INCREMENT,
  `suppliercode` varchar(50) NOT NULL,
  `suppliername` varchar(50) NOT NULL,
  `discription` text NOT NULL,
  `contactperson` varchar(50) NOT NULL,
  `bussinessno` varchar(50) NOT NULL,
  `telefaxno` varchar(50) NOT NULL,
  `mobileno` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `address` text NOT NULL,
  `status` varchar(50) NOT NULL,
  `cash` decimal(50,0) NOT NULL,
  `tempo` date NOT NULL,
  `stock` int(50) NOT NULL,
  `dateadded` date NOT NULL,
  PRIMARY KEY (`autoid`),
  KEY `suppliercode` (`suppliercode`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table tblsupplier
-- 

/*!40000 ALTER TABLE `tblsupplier` DISABLE KEYS */;
INSERT INTO `tblsupplier`(`autoid`,`suppliercode`,`suppliername`,`discription`,`contactperson`,`bussinessno`,`telefaxno`,`mobileno`,`email`,`address`,`status`,`cash`,`tempo`,`stock`,`dateadded`) VALUES
(3,'SUPP-000000000','TOKO BATIK NINGRAT','BATIK TULIS','RISA LIANA','08157905241','','','risa@gmail.com','PASAR NGASEM','ACTIVE',0,'0001-01-01 00:00:00',0,'2016-06-15 00:00:00');
/*!40000 ALTER TABLE `tblsupplier` ENABLE KEYS */;

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
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table tblusers
-- 

/*!40000 ALTER TABLE `tblusers` DISABLE KEYS */;
INSERT INTO `tblusers`(`autoid`,`usercode`,`fullname`,`address`,`email`,`telephone`,`usertype`,`status`,`username`,`password`,`datemodify`,`usermodifyby`,`dateadded`,`useraddedby`) VALUES
(1,'ADM-0000','Bahar','Jln.Parangtritis Km4, Sorowajan RT10 Panggungharjo Sewon Bantul','junkiesdevstudio@gmail.com','085702363359',1,'ACTIVE','admin','bayat123','2005-01-01 00:00:00',1,'2005-01-01 00:00:00',1),
(10,'USR-0001','Bahar Setiawan','Jln.Imogiri Timur, Bantul, Yogyakarta','baharsetiawan@yahoo.co.id','1234567890',2,'ACTIVE','kasir','1234','2016-05-18 00:00:00',1,'2016-05-18 00:00:00',1),
(15,'USR-000000010','DWI SUSANTI','','dwi@gmail.com','0813875656567',2,'ACTIVE','kasir2','1234','2005-01-01 00:00:00',1,'2005-01-01 00:00:00',1);
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

-- 
-- Dumping triggers
-- 

DROP TRIGGER /*!50030 IF EXISTS */ `penjualan`;
DELIMITER |
CREATE TRIGGER `penjualan` AFTER INSERT ON `tblsales` FOR EACH ROW BEGIN
 UPDATE tblproduct SET stock=stock-NEW.quantity
 WHERE productcode=NEW.productcode;
END |
DELIMITER ;


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2016-06-16 16:11:57
-- Total time: 0:0:0:0:58 (d:h:m:s:ms)

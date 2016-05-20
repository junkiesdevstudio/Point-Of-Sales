-- MySqlBackup.NET 2.0.9.3
-- Dump Time: 2016-05-20 16:19:28
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
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table tblcategory
-- 

/*!40000 ALTER TABLE `tblcategory` DISABLE KEYS */;
INSERT INTO `tblcategory`(`autoid`,`categorycode`,`categoryname`,`description`,`dateadded`,`addedby`) VALUES
(1,'CAT-0000','Makanan','Makanan Ringan','2016-05-19 00:00:00',1),
(2,'CAT-0001','Minuman','Minuman Dingin','2016-05-19 00:00:00',1);
/*!40000 ALTER TABLE `tblcategory` ENABLE KEYS */;

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
  `stock` int(11) NOT NULL,
  PRIMARY KEY (`autoid`),
  KEY `categoryautoid` (`categoryautoid`,`supplierautoid`),
  KEY `supplierautoid` (`supplierautoid`),
  CONSTRAINT `tblproduct_ibfk_1` FOREIGN KEY (`categoryautoid`) REFERENCES `tblcategory` (`autoid`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `tblproduct_ibfk_2` FOREIGN KEY (`supplierautoid`) REFERENCES `tblsupplier` (`autoid`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table tblproduct
-- 

/*!40000 ALTER TABLE `tblproduct` DISABLE KEYS */;
INSERT INTO `tblproduct`(`autoid`,`productcode`,`productname`,`categoryautoid`,`supplierautoid`,`unitprice`,`sellingprice`,`stock`) VALUES
(13,'9780201374445','HTA',1,2,5000,5500,19),
(14,'9780201375558','HTB',2,2,3000,3200,8),
(15,'9780201376661','HTC',1,2,4000,4300,8),
(16,'9780201371116','HTD',1,2,1500,2000,20);
/*!40000 ALTER TABLE `tblproduct` ENABLE KEYS */;

-- 
-- Definition of tblsales
-- 

DROP TABLE IF EXISTS `tblsales`;
CREATE TABLE IF NOT EXISTS `tblsales` (
  `autoid` int(11) NOT NULL AUTO_INCREMENT,
  `invoiceno` varchar(50) NOT NULL,
  `productautoid` int(50) NOT NULL,
  `unitprice` decimal(50,0) NOT NULL,
  `quantity` int(50) NOT NULL,
  `subtotal` decimal(50,0) NOT NULL,
  `totalamount` decimal(50,0) NOT NULL,
  `cash` decimal(50,0) NOT NULL,
  `changecash` decimal(50,0) NOT NULL,
  `dateadded` date NOT NULL,
  PRIMARY KEY (`autoid`),
  KEY `invoiceno` (`invoiceno`,`productautoid`),
  KEY `productautoid` (`productautoid`),
  CONSTRAINT `tblsales_ibfk_1` FOREIGN KEY (`productautoid`) REFERENCES `tblproduct` (`autoid`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table tblsales
-- 

/*!40000 ALTER TABLE `tblsales` DISABLE KEYS */;
INSERT INTO `tblsales`(`autoid`,`invoiceno`,`productautoid`,`unitprice`,`quantity`,`subtotal`,`totalamount`,`cash`,`changecash`,`dateadded`) VALUES
(11,'INV-0000/1463728518',16,1500,5,7500,26500,30000,3500,'2016-05-20 00:00:00'),
(12,'INV-0000/1463728518',15,4000,2,8000,26500,30000,3500,'2016-05-20 00:00:00'),
(13,'INV-0000/1463728518',14,3000,2,6000,26500,30000,3500,'2016-05-20 00:00:00'),
(14,'INV-0000/1463728518',13,5000,1,5000,26500,30000,3500,'2016-05-20 00:00:00');
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
(2,'SUPP-0000','Toko Maju Mundur','Ini Keterangan Supplier','Joni Widianto','1234567890','','','asdfg@gmail.com','Ini Alamat Supplier','ACTIVE',0,'2016-05-16 00:00:00',0,'2016-05-17 00:00:00');
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

-- 
-- Dumping triggers
-- 

DROP TRIGGER /*!50030 IF EXISTS */ `MIN_STOCK`;
DELIMITER |
CREATE TRIGGER `MIN_STOCK` AFTER INSERT ON `tblsales` FOR EACH ROW BEGIN
UPDATE tblproduct SET stock=stock-NEW.quantity 
WHERE autoid=NEW.productautoid;
END |
DELIMITER ;


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2016-05-20 16:19:28
-- Total time: 0:0:0:0:81 (d:h:m:s:ms)

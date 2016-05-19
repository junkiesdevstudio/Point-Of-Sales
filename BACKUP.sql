-- MySqlBackup.NET 2.0.9.3
-- Dump Time: 2016-05-20 01.18.47
-- --------------------------------------
-- Server version 5.6.21 MySQL Community Server (GPL)


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
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table tblproduct
-- 

/*!40000 ALTER TABLE `tblproduct` DISABLE KEYS */;
INSERT INTO `tblproduct`(`autoid`,`productcode`,`productname`,`categoryautoid`,`supplierautoid`,`unitprice`,`sellingprice`,`stock`) VALUES
(1,'8990001000135','Fresh Tea',2,2,3000,3500,10),
(2,'8990001000128','Es Teh',2,2,5000,6000,10);
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
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table tblsales
-- 

/*!40000 ALTER TABLE `tblsales` DISABLE KEYS */;
INSERT INTO `tblsales`(`autoid`,`invoiceno`,`productautoid`,`unitprice`,`quantity`,`subtotal`,`totalamount`,`cash`,`changecash`,`dateadded`) VALUES
(1,'INV-0000',1,3000,1,3000,3000,5000,2000,'2016-05-19 00:00:00'),
(2,'INV-0001',1,3000,1,3000,13000,15000,2000,'2016-05-19 00:00:00'),
(3,'INV-0001',2,5000,2,10000,13000,15000,2000,'2016-05-19 00:00:00'),
(4,'INV-0003/497',2,5000,1,5000,20000,50000,30000,'2016-05-19 00:00:00'),
(5,'INV-0003/497',1,3000,5,15000,20000,50000,30000,'2016-05-19 00:00:00'),
(6,'INV-0005/1463681215',2,5000,5,25000,25000,0,0,'2016-05-20 00:00:00'),
(7,'INV-0006/1463681404',1,3000,5,15000,15000,20000,5000,'2016-05-20 00:00:00');
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
  `dateadded` date NOT NULL,
  PRIMARY KEY (`autoid`),
  KEY `suppliercode` (`suppliercode`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table tblsupplier
-- 

/*!40000 ALTER TABLE `tblsupplier` DISABLE KEYS */;
INSERT INTO `tblsupplier`(`autoid`,`suppliercode`,`suppliername`,`discription`,`contactperson`,`bussinessno`,`telefaxno`,`mobileno`,`email`,`address`,`status`,`dateadded`) VALUES
(2,'SUPP-0000','Toko Maju Mundur','Ini Keterangan Supplier','Joni Widianto','1234567890','','','asdfg@gmail.com','Ini Alamat Supplier','ACTIVE','2016-05-17 00:00:00');
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


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2016-05-20 01.18.47
-- Total time: 0:0:0:0:217 (d:h:m:s:ms)

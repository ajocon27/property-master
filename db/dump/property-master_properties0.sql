-- MySQL dump 10.13  Distrib 8.0.18, for Win64 (x86_64)
--
-- Host: localhost    Database: property-master
-- ------------------------------------------------------
-- Server version	8.0.18

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `properties`
--

DROP TABLE IF EXISTS `properties`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `properties` (
  `property_id` int(11) NOT NULL AUTO_INCREMENT,
  `property_name` text,
  `price` double DEFAULT NULL,
  `address` text,
  `city` text,
  `province` text,
  `land_size` double DEFAULT NULL,
  `likes` int(11) DEFAULT NULL,
  `description` text,
  `photo_group_id` int(11) DEFAULT NULL,
  `bathrooms` text,
  `bedrooms` text,
  `address2` text,
  `postalcode` text,
  `user_id` int(11) DEFAULT NULL,
  `category` text,
  PRIMARY KEY (`property_id`)
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `properties`
--

LOCK TABLES `properties` WRITE;
/*!40000 ALTER TABLE `properties` DISABLE KEYS */;
INSERT INTO `properties` VALUES (1,'1047 Consol Ave.',500000,'1047 Consol Ave.','Winnipeg','Manitoba',3000,NULL,'DUPLEX in Fort-Coulonge! Great for investors, or for occupying owner! 2 good revenues of $580 and $550 per month, easy to rent, very central, low inoccupation rates in the village. Sold below municipal value.',1,'2','Bachelor/Studio','','R2K 1T9',1,'Houses for Sale'),(2,'Consol Ave.',500000,'1047 Consol Ave.','Winnipeg','Manitoba',3000,NULL,'DUPLEX in Fort-Coulonge! Great for investors, or for occupying owner! 2 good revenues of $580 and $550 per month, easy to rent, very central, low inoccupation rates in the village. Sold below municipal value.',2,'2','Bachelor/Studio','','R2K 1T9',2,'Houses for Sale'),(18,'',0,'','','Choose Province',0,NULL,'',1,'0','0','','',1,'Choose Category'),(19,'',0,'','','Choose Province',0,NULL,'',1,'0','0','','',1,'Choose Category'),(20,'',0,'','','Choose Province',0,NULL,'',1,'0','0','','',1,'Choose Category'),(21,'',0,'','','Choose Province',0,NULL,'',1,'0','0','','',1,'Choose Category'),(22,'',0,'','','Choose Province',0,NULL,'',1,'0','0','','',1,'Choose Category'),(23,'',0,'','','Choose Province',0,NULL,'',1,'0','0','','',1,'Choose Category'),(24,'',0,'','','Choose Province',0,NULL,'',1,'0','0','','',1,'Choose Category'),(25,'',0,'','','Choose Province',0,NULL,'',1,'0','0','','',1,'Choose Category'),(26,'',0,'','','Choose Province',0,NULL,'',1,'0','0','','',1,'Choose Category'),(27,'',0,'','','Choose Province',0,NULL,'',1,'0','0','','',1,'Choose Category'),(28,'',0,'','','Choose Province',0,NULL,'',1,'0','0','','',1,'Choose Category');
/*!40000 ALTER TABLE `properties` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-10-21  2:16:24

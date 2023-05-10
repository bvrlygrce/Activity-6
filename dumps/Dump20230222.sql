CREATE DATABASE  IF NOT EXISTS `mydatabase` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `mydatabase`;
-- MySQL dump 10.13  Distrib 8.0.30, for Win64 (x86_64)
--
-- Host: localhost    Database: mydatabase
-- ------------------------------------------------------
-- Server version	8.0.30

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
-- Temporary view structure for view `client_deadline`
--

DROP TABLE IF EXISTS `client_deadline`;
/*!50001 DROP VIEW IF EXISTS `client_deadline`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `client_deadline` AS SELECT 
 1 AS `client_no`,
 1 AS `firstname`,
 1 AS `lastname`,
 1 AS `code_id`,
 1 AS `days`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `client_info`
--

DROP TABLE IF EXISTS `client_info`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `client_info` (
  `Client_no` int NOT NULL,
  `Firstname` varchar(255) DEFAULT NULL,
  `Lastname` varchar(255) DEFAULT NULL,
  `Project` int DEFAULT NULL,
  `Difficulties` int DEFAULT NULL,
  `Deadline` int DEFAULT NULL,
  `Price` int DEFAULT NULL,
  PRIMARY KEY (`Client_no`),
  KEY `DeadlineClient_Info` (`Deadline`),
  KEY `DifficultiesClient_Info` (`Difficulties`),
  KEY `PriceClient_Info` (`Price`),
  KEY `ProjectClient_Info` (`Project`),
  CONSTRAINT `deadline` FOREIGN KEY (`Deadline`) REFERENCES `deadline` (`Code_ID`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `difficulties` FOREIGN KEY (`Difficulties`) REFERENCES `difficulties` (`Diff_code`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `price` FOREIGN KEY (`Price`) REFERENCES `price` (`Price_Id`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `project` FOREIGN KEY (`Project`) REFERENCES `project` (`Project_ID`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `client_info`
--

LOCK TABLES `client_info` WRITE;
/*!40000 ALTER TABLE `client_info` DISABLE KEYS */;
INSERT INTO `client_info` VALUES (1,'Beverly','Borbe',1,2,1,2),(2,'Mary','Ala',2,3,2,5),(3,'Greys','Fortalejo',3,4,3,4),(4,'Ann','Llamera',4,1,4,3),(5,'Grace','Garcera',5,6,5,6),(6,'Rose','Belista',4,5,6,3),(7,'Khris','Ocampo',8,9,7,9),(8,'Joyce','Loterte',9,7,8,8),(9,'Masbate','Keith',6,5,9,8),(10,'Bracamonte','Jay',10,9,10,10);
/*!40000 ALTER TABLE `client_info` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `commissionservers`
--

DROP TABLE IF EXISTS `commissionservers`;
/*!50001 DROP VIEW IF EXISTS `commissionservers`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `commissionservers` AS SELECT 
 1 AS `client_no`,
 1 AS `firstname`,
 1 AS `lastname`,
 1 AS `code_id`,
 1 AS `days`,
 1 AS `project_name`,
 1 AS `scale`,
 1 AS `price_unit`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `deadline`
--

DROP TABLE IF EXISTS `deadline`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `deadline` (
  `Code_ID` int NOT NULL,
  `Days` longtext,
  PRIMARY KEY (`Code_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `deadline`
--

LOCK TABLES `deadline` WRITE;
/*!40000 ALTER TABLE `deadline` DISABLE KEYS */;
INSERT INTO `deadline` VALUES (1,'Monday'),(2,'Tuesday'),(3,'Wednesday'),(4,'Thursday'),(5,'Friday'),(6,'Saturday'),(7,'Sunday'),(8,'Rush'),(9,'Late'),(10,'Today');
/*!40000 ALTER TABLE `deadline` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `difficulties`
--

DROP TABLE IF EXISTS `difficulties`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `difficulties` (
  `Diff_code` int NOT NULL,
  `Scale` int DEFAULT NULL,
  PRIMARY KEY (`Diff_code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `difficulties`
--

LOCK TABLES `difficulties` WRITE;
/*!40000 ALTER TABLE `difficulties` DISABLE KEYS */;
INSERT INTO `difficulties` VALUES (1,1),(2,2),(3,3),(4,4),(5,5),(6,6),(7,7),(8,8),(9,9),(10,10);
/*!40000 ALTER TABLE `difficulties` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `price`
--

DROP TABLE IF EXISTS `price`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `price` (
  `Price_Id` int NOT NULL,
  `Price_unit` varchar(255) DEFAULT NULL,
  `price_no` int DEFAULT NULL,
  PRIMARY KEY (`Price_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `price`
--

LOCK TABLES `price` WRITE;
/*!40000 ALTER TABLE `price` DISABLE KEYS */;
INSERT INTO `price` VALUES (2,'1000',2),(3,'300',3),(4,'400',4),(5,'450',5),(6,'550',6),(7,'700',7),(8,'800',8),(9,'950',9),(10,'1000',10),(11,'1000',1);
/*!40000 ALTER TABLE `price` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = cp850 */ ;
/*!50003 SET character_set_results = cp850 */ ;
/*!50003 SET collation_connection  = cp850_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `after_insert_onprice` AFTER INSERT ON `price` FOR EACH ROW begin 
if new.price_no is not null then
update prodprice 
set priceTotal = priceTotal + new.Price_unit 
where price_no = new.price_no;
end if;
end */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = cp850 */ ;
/*!50003 SET character_set_results = cp850 */ ;
/*!50003 SET collation_connection  = cp850_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `after_updatePrice` AFTER UPDATE ON `price` FOR EACH ROW begin
if old.price_no is not null then 
update prodprice 
set priceTotal = priceTotal - old.price_unit
where price_no = old.price_no;
end if;
if new.price_no is not null then 
update prodprice 
set priceTotal = priceTotal + new.price_unit 
where price_no = new.price_no; 
end if;
end */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = cp850 */ ;
/*!50003 SET character_set_results = cp850 */ ;
/*!50003 SET collation_connection  = cp850_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `before_delete_onPrice` BEFORE DELETE ON `price` FOR EACH ROW begin 
if (old.price_no is not null) then 
update prodprice
set priceTotal = priceTotal - old.price_unit 
where price_no = old.price_no;
end if; 
end */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `prodprice`
--

DROP TABLE IF EXISTS `prodprice`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `prodprice` (
  `price_no` int DEFAULT NULL,
  `priceTotal` int NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prodprice`
--

LOCK TABLES `prodprice` WRITE;
/*!40000 ALTER TABLE `prodprice` DISABLE KEYS */;
INSERT INTO `prodprice` VALUES (1,1000),(2,1000),(3,300),(4,400),(5,450),(6,550),(7,700),(8,800),(9,950),(10,1000);
/*!40000 ALTER TABLE `prodprice` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `project`
--

DROP TABLE IF EXISTS `project`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `project` (
  `Project_ID` int NOT NULL,
  `Project_name` longtext,
  PRIMARY KEY (`Project_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `project`
--

LOCK TABLES `project` WRITE;
/*!40000 ALTER TABLE `project` DISABLE KEYS */;
INSERT INTO `project` VALUES (1,'essay'),(2,'case_study'),(3,'exams'),(4,'poems'),(5,'coding'),(6,'digital_art'),(7,'thesis'),(8,'research'),(9,'problem_solving'),(10,'software_installation');
/*!40000 ALTER TABLE `project` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `totalprice`
--

DROP TABLE IF EXISTS `totalprice`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `totalprice` (
  `price_id` int NOT NULL,
  `totalprice` int NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `totalprice`
--

LOCK TABLES `totalprice` WRITE;
/*!40000 ALTER TABLE `totalprice` DISABLE KEYS */;
INSERT INTO `totalprice` VALUES (1,50),(2,100),(3,200),(4,300),(5,400),(6,500),(7,600),(8,700),(9,950),(10,1000);
/*!40000 ALTER TABLE `totalprice` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `works`
--

DROP TABLE IF EXISTS `works`;
/*!50001 DROP VIEW IF EXISTS `works`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `works` AS SELECT 
 1 AS `client_no`,
 1 AS `firstname`,
 1 AS `lastname`,
 1 AS `code_id`,
 1 AS `days`,
 1 AS `project_name`*/;
SET character_set_client = @saved_cs_client;

--
-- Dumping routines for database 'mydatabase'
--
/*!50003 DROP FUNCTION IF EXISTS `priceRaise` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `priceRaise`(oldprice double, amount double) RETURNS double
    DETERMINISTIC
BEGIN
	declare newprice double;
    set newprice = oldprice * (1 + amount);
    return newprice;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `updatePrice` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `updatePrice`(IN param1 int)
BEGIN
	update prodprice
    set priceTotal = (select sum(price_unit) from price where price_no= param1)
    where price_no= param1;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Final view structure for view `client_deadline`
--

/*!50001 DROP VIEW IF EXISTS `client_deadline`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `client_deadline` AS select `client_info`.`Client_no` AS `client_no`,`client_info`.`Firstname` AS `firstname`,`client_info`.`Lastname` AS `lastname`,`deadline`.`Code_ID` AS `code_id`,`deadline`.`Days` AS `days` from (`client_info` join `deadline` on((`client_info`.`Client_no` = `deadline`.`Code_ID`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `commissionservers`
--

/*!50001 DROP VIEW IF EXISTS `commissionservers`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `commissionservers` AS select `client_info`.`Client_no` AS `client_no`,`client_info`.`Firstname` AS `firstname`,`client_info`.`Lastname` AS `lastname`,`deadline`.`Code_ID` AS `code_id`,`deadline`.`Days` AS `days`,`project`.`Project_name` AS `project_name`,`difficulties`.`Scale` AS `scale`,`price`.`Price_unit` AS `price_unit` from ((((`client_info` join `deadline` on((`client_info`.`Client_no` = `deadline`.`Code_ID`))) join `project` on((`client_info`.`Project` = `project`.`Project_ID`))) join `price` on((`client_info`.`Price` = `price`.`Price_Id`))) join `difficulties` on((`difficulties`.`Scale` = `difficulties`.`Diff_code`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `works`
--

/*!50001 DROP VIEW IF EXISTS `works`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `works` AS select `client_info`.`Client_no` AS `client_no`,`client_info`.`Firstname` AS `firstname`,`client_info`.`Lastname` AS `lastname`,`deadline`.`Code_ID` AS `code_id`,`deadline`.`Days` AS `days`,`project`.`Project_name` AS `project_name` from ((`client_info` join `deadline` on((`client_info`.`Client_no` = `deadline`.`Code_ID`))) join `project` on((`client_info`.`Project` = `project`.`Project_ID`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-02-22 15:11:19

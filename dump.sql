CREATE DATABASE  IF NOT EXISTS `decanat` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `decanat`;
-- MySQL dump 10.13  Distrib 8.0.22, for Win64 (x86_64)
--
-- Host: localhost    Database: decanat
-- ------------------------------------------------------
-- Server version	5.5.23

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
-- Table structure for table `disciplines`
--

DROP TABLE IF EXISTS `disciplines`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `disciplines` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `disciplin` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `disciplines`
--

LOCK TABLES `disciplines` WRITE;
/*!40000 ALTER TABLE `disciplines` DISABLE KEYS */;
INSERT INTO `disciplines` VALUES (1,'Информатика'),(2,'Математика'),(3,'Физика'),(4,'Экономика');
/*!40000 ALTER TABLE `disciplines` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `results`
--

DROP TABLE IF EXISTS `results`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `results` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `students_id` int(11) NOT NULL,
  `disciplins_id` int(11) NOT NULL,
  `result` varchar(45) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_results_students_idx` (`students_id`),
  KEY `fk_results_disciplins1_idx` (`disciplins_id`),
  CONSTRAINT `fk_results_students` FOREIGN KEY (`students_id`) REFERENCES `students` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_results_disciplins1` FOREIGN KEY (`disciplins_id`) REFERENCES `disciplines` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=64 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `results`
--

LOCK TABLES `results` WRITE;
/*!40000 ALTER TABLE `results` DISABLE KEYS */;
INSERT INTO `results` VALUES (1,1,1,'4'),(2,1,2,'5'),(3,1,3,'4'),(4,1,4,'4'),(5,2,1,'5'),(6,2,2,'5'),(7,2,3,'4'),(8,2,4,'4'),(9,3,1,'3'),(10,3,2,'5'),(11,3,3,'4'),(12,3,4,'3'),(13,4,1,'4'),(14,4,2,'4'),(15,4,3,'5'),(16,4,4,'4'),(17,5,1,'5'),(18,5,2,'5'),(19,5,3,'5'),(20,5,4,'5'),(21,6,1,'5'),(22,6,2,'4'),(23,6,3,'5'),(24,6,4,'4'),(25,7,1,'4'),(26,7,2,'3'),(27,7,3,'4'),(28,7,4,'3'),(29,8,1,'3'),(30,8,2,'5'),(31,8,3,'5'),(32,8,4,'4'),(33,9,1,'4'),(34,9,2,'4'),(35,9,3,'4'),(36,9,4,'4'),(37,10,1,'5'),(38,10,2,'5'),(39,10,3,'5'),(40,10,4,'5');
/*!40000 ALTER TABLE `results` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `students`
--

DROP TABLE IF EXISTS `students`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `students` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `fio` varchar(45) NOT NULL,
  `group` varchar(45) NOT NULL,
  `phone` varchar(10) NOT NULL,
  `stipend` decimal(5,2) unsigned DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `students`
--

LOCK TABLES `students` WRITE;
/*!40000 ALTER TABLE `students` DISABLE KEYS */;
INSERT INTO `students` VALUES (1,'Арбузов Николай Николаевич','151','260-15-63',800.00),(2,'Киршин Петр Валерьевич','151','110-67-82',800.00),(3,'Кривинский Сергей Николаевич','151','172-97-21',0.00),(4,'Крылова Елена Петровна','151','130-31-87',500.00),(5,'Кульчий Григорий Викторович','151','269-53-75',500.00),(6,'Патрикеев Олег Борисович','152','234-11-63',0.00),(7,'Перлов Кирилл Николаевич','152','312-21-33',0.00),(8,'Соколова Наталия Петровна','152','166-87-24',0.00),(9,'Степанская Ольга Витальевна','152','293-43-77',800.00),(10,'Тимофеев Сергей Трофимович','152','260-11-57',800.00);
/*!40000 ALTER TABLE `students` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `teachers`
--

DROP TABLE IF EXISTS `teachers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `teachers` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `fio` varchar(45) NOT NULL,
  `date_birthday` date NOT NULL,
  `position` varchar(45) NOT NULL,
  `phone` varchar(45) NOT NULL,
  `salary` decimal(10,2) NOT NULL,
  `disciplins_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_teachers_disciplins1_idx` (`disciplins_id`),
  CONSTRAINT `fk_teachers_disciplins1` FOREIGN KEY (`disciplins_id`) REFERENCES `disciplines` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `teachers`
--

LOCK TABLES `teachers` WRITE;
/*!40000 ALTER TABLE `teachers` DISABLE KEYS */;
INSERT INTO `teachers` VALUES (1,'Истомин Темир Евгеньевич','1954-10-23','Доцент','110-44-68',6500.00,1),(2,'Миронов Павел Юрьевич','1940-07-25','Профессор','312-21-40',8000.00,4),(3,'Гришин Евгений Сергеевич','1967-12-05','Доцент','260-23-65',6500.00,2),(4,'Сергеева Ольга Ивановна','1972-02-12','Ассистент','234-85-69',6200.00,2),(5,'Емец Татьяна Ивановна','1951-02-16','Доцент','166-75-33',6500.00,4),(6,'Игнатьева Татьяна Павловна','1966-05-30','Доцент','210-36-98',6500.00,1),(7,'Миронов Алексей Николаевич','1948-07-30','Доцент','166-75-33',6500.00,3);
/*!40000 ALTER TABLE `teachers` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-01-03 15:08:23

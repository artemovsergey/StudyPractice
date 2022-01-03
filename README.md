# Создание серверной части приложения

## ERD модель


![img](http://localhost/Bonobo.Git.Server/Repository/d076735c-f6a0-4942-965f-d0c8985f3c2a/master/Raw/images/decanat.png)



## Дамп базы данных
## Код генерации объектов базы данных

```sql
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema decanat
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema decanat
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `decanat` DEFAULT CHARACTER SET utf8 ;
USE `decanat` ;

-- -----------------------------------------------------
-- Table `decanat`.`disciplins`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `decanat`.`disciplins` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `disciplin` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `decanat`.`teachers`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `decanat`.`teachers` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `fio` VARCHAR(45) NOT NULL,
  `date_birthday` DATE NOT NULL,
  `position` VARCHAR(45) NOT NULL,
  `phone` VARCHAR(45) NOT NULL,
  `salary` DECIMAL(5,2) NOT NULL,
  `disciplins_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_teachers_disciplins1_idx` (`disciplins_id` ASC),
  CONSTRAINT `fk_teachers_disciplins1`
    FOREIGN KEY (`disciplins_id`)
    REFERENCES `decanat`.`disciplins` (`id`)
    ON DELETE RESTRICT
    ON UPDATE RESTRICT)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `decanat`.`students`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `decanat`.`students` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `fio` VARCHAR(45) NOT NULL,
  `group` VARCHAR(45) NOT NULL,
  `date_birthday` DATE NOT NULL,
  `stipend` DECIMAL(5,2) UNSIGNED NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `decanat`.`results`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `decanat`.`results` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `result` VARCHAR(45) NOT NULL,
  `students_id` INT NOT NULL,
  `disciplins_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_results_students_idx` (`students_id` ASC),
  INDEX `fk_results_disciplins1_idx` (`disciplins_id` ASC),
  CONSTRAINT `fk_results_students`
    FOREIGN KEY (`students_id`)
    REFERENCES `decanat`.`students` (`id`)
    ON DELETE RESTRICT
    ON UPDATE RESTRICT,
  CONSTRAINT `fk_results_disciplins1`
    FOREIGN KEY (`disciplins_id`)
    REFERENCES `decanat`.`disciplins` (`id`)
    ON DELETE RESTRICT
    ON UPDATE RESTRICT)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;


```
## Файл MySQL Workbench модели <a href = "/decanat.mwb">Скачать</a>

## Скрипт для импорта <a href = "./load data.sql">Скачать</a>

## Модель в формате pdf <a href = "./decanat.pdf">Скачать</a>
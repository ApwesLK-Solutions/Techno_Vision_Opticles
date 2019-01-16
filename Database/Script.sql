-- MySQL Script generated by MySQL Workbench
-- Wed Jan 16 20:43:06 2019
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema Technovision
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema Technovision
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `Technovision` DEFAULT CHARACTER SET utf8 ;
USE `Technovision` ;

-- -----------------------------------------------------
-- Table `Technovision`.`users`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Technovision`.`users` (
  `username` VARCHAR(20) NOT NULL,
  `password` VARCHAR(20) NOT NULL,
  `fullName` VARCHAR(150) NOT NULL,
  `nic` VARCHAR(12) NOT NULL,
  `contactNumber` VARCHAR(10) NOT NULL,
  PRIMARY KEY (`username`),
  UNIQUE INDEX `username_UNIQUE` (`username` ASC) ,
  UNIQUE INDEX `nic_UNIQUE` (`nic` ASC) ,
  UNIQUE INDEX `contactNumber_UNIQUE` (`contactNumber` ASC) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Technovision`.`customers`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Technovision`.`customers` (
  `customerId` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(255) NOT NULL,
  `address` VARCHAR(255) NOT NULL,
  `profession` VARCHAR(150) NOT NULL,
  `age` INT NOT NULL,
  `phone` VARCHAR(14) NOT NULL,
  `email` VARCHAR(100) NOT NULL,
  PRIMARY KEY (`customerId`),
  UNIQUE INDEX `idcustomers_UNIQUE` (`customerId` ASC) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Technovision`.`order_summary`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Technovision`.`order_summary` (
  `order_number` VARCHAR(6) NOT NULL,
  `receipt_number` VARCHAR(7) NOT NULL,
  `customer_id` INT NOT NULL,
  `order_type` VARCHAR(1) NOT NULL,
  PRIMARY KEY (`order_number`),
  UNIQUE INDEX `receipt_number_UNIQUE` (`receipt_number` ASC) ,
  UNIQUE INDEX `order_number_UNIQUE` (`order_number` ASC) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Technovision`.`lense_orders`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Technovision`.`lense_orders` (
  `receipt_number` VARCHAR(7) NOT NULL,
  `order_number` VARCHAR(6) NOT NULL,
  `customer_id` INT NOT NULL,
  `job_type` VARCHAR(11) NOT NULL,
  `tested_by` VARCHAR(50) NOT NULL,
  `lenses_total` DOUBLE NOT NULL,
  `advance` DOUBLE NULL,
  `balance` DOUBLE NULL,
  `old_right_sph` VARCHAR(10) NULL,
  `old_right_cyl` VARCHAR(10) NULL,
  `old_right_axis` VARCHAR(10) NULL,
  `old_right_add` VARCHAR(10) NULL,
  `old_left_sph` VARCHAR(10) NULL,
  `old_left_cyl` VARCHAR(10) NULL,
  `old_left_axis` VARCHAR(10) NULL,
  `old_left_add` VARCHAR(10) NULL,
  `present_right_sph` VARCHAR(10) NULL,
  `present_right_cyl` VARCHAR(10) NULL,
  `present_right_axis` VARCHAR(10) NULL,
  `present_right_add` VARCHAR(10) NULL,
  `present_left_sph` VARCHAR(10) NULL,
  `present_left_cyl` VARCHAR(10) NULL,
  `present_left_axis` VARCHAR(10) NULL,
  `present_left_add` VARCHAR(10) NULL,
  `right_bc` VARCHAR(10) NULL,
  `right_pow` VARCHAR(10) NULL,
  `right_dia` VARCHAR(10) NULL,
  `right_desz` VARCHAR(10) NULL,
  `left_bc` VARCHAR(10) NULL,
  `left_pow` VARCHAR(10) NULL,
  `left_dia` VARCHAR(10) NULL,
  `left_desz` VARCHAR(10) NULL,
  `trail_lense` VARCHAR(150) NULL,
  `over_refract` VARCHAR(45) NULL,
  `k_reading` VARCHAR(45) NULL,
  `blink_test` VARCHAR(45) NULL,
  `special_instractions` VARCHAR(225) NULL,
  `remarks` VARCHAR(225) NULL,
  `order_status` VARCHAR(45) NULL DEFAULT 'PENDING',
  `order_date` DATE NOT NULL,
  `due_date` DATE NOT NULL,
  `payment_method` VARCHAR(45) NOT NULL,
  `payment_plan` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`receipt_number`),
  UNIQUE INDEX `recipt_id_UNIQUE` (`receipt_number` ASC) ,
  UNIQUE INDEX `order_number_UNIQUE` (`order_number` ASC) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Technovision`.`specs_orders`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Technovision`.`specs_orders` (
  `receipt_number` VARCHAR(7) NOT NULL,
  `order_number` VARCHAR(6) NOT NULL,
  `customer_id` INT NOT NULL,
  `test_by` VARCHAR(50) NOT NULL,
  `eye_wear` VARCHAR(50) NULL,
  `lenses` VARCHAR(50) NULL,
  `total` DOUBLE NOT NULL,
  `advance` DOUBLE NULL,
  `discount` DOUBLE NULL,
  `balance` DOUBLE NULL,
  `dist_right_sph` VARCHAR(10) NULL,
  `dist_right_cyl` VARCHAR(10) NULL,
  `dist_right_axis` VARCHAR(10) NULL,
  `dist_left_sph` VARCHAR(10) NULL,
  `dist_left_cyl` VARCHAR(10) NULL,
  `dist_left_axis` VARCHAR(10) NULL,
  `add_right_sph` VARCHAR(10) NULL,
  `add_right_cyl` VARCHAR(10) NULL,
  `add_right_axis` VARCHAR(10) NULL,
  `add_left_sph` VARCHAR(10) NULL,
  `add_left_cyl` VARCHAR(10) NULL,
  `add_left_axis` VARCHAR(10) NULL,
  `lense_type` VARCHAR(45) NULL,
  `frame` VARCHAR(45) NULL,
  `pd` VARCHAR(45) NULL,
  `segment_hight` VARCHAR(45) NULL,
  `special_ins` VARCHAR(225) NULL,
  `remarks` VARCHAR(45) NULL,
  `order_status` VARCHAR(20) NULL DEFAULT 'PENDING',
  `order_date` DATE NOT NULL,
  `due_date` DATE NOT NULL,
  `payment_method` VARCHAR(45) NOT NULL,
  `payment_plan` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`receipt_number`),
  UNIQUE INDEX `receipt_number_UNIQUE` (`receipt_number` ASC) ,
  UNIQUE INDEX `order_number_UNIQUE` (`order_number` ASC) )
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

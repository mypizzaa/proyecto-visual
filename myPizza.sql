CREATE USER 'administrator'@'localhost' IDENTIFIED BY 'adminpsw';
-- Crear base de dades.

CREATE DATABASE mypizza  DEFAULT CHARACTER SET utf8  DEFAULT COLLATE utf8_general_ci;

-- Permisos
GRANT SELECT, INSERT, UPDATE, DELETE ON mypizza.* TO 'administrator'@'localhost';

USE mypizza;

-- TABLAS DE USUARIOS
CREATE TABLE `tb_cliente` (
    `id` INT(4) NOT NULL AUTO_INCREMENT,
    `dni` VARCHAR(9) DEFAULT NULL UNIQUE,
    `nombre` VARCHAR(40) DEFAULT NULL,
    `apellidos` VARCHAR(40) DEFAULT NULL,
    `password` VARCHAR(40) DEFAULT NULL,
    `direccion1` VARCHAR(40) DEFAULT NULL,
    `direccion2` VARCHAR(40) DEFAULT NULL,
    PRIMARY KEY (`id`)
) ENGINE=InnoDB;

CREATE TABLE `tb_empleado` (
    `id` INT(4) NOT NULL AUTO_INCREMENT,
    `dni` VARCHAR(9) DEFAULT NULL UNIQUE,
    `nombre` VARCHAR(40) DEFAULT NULL,
    `apellidos` VARCHAR(40) DEFAULT NULL,
    `password` VARCHAR(40) DEFAULT NULL,
    `hora_entrada` VARCHAR(40) DEFAULT NULL,
    `hora_salida` VARCHAR(40) DEFAULT NULL,
    `horas_semanales` VARCHAR(40) DEFAULT NULL,
    `salario` DOUBLE DEFAULT 0.0,
    PRIMARY KEY (`id`)
) ENGINE=InnoDB;

CREATE TABLE `usuarios` (
    `id` INT(4) NOT NULL AUTO_INCREMENT,
    `nickname` VARCHAR(40) DEFAULT NULL ,
    `password` VARCHAR(40) DEFAULT NULL ,
    `role` VARCHAR(40) DEFAULT NULL,
    `id_tb_empleado` 
    PRIMARY KEY (`id`)
) ENGINE=InnoDB;


CREATE TABLE `tb_pizza_info` (
    `id` INT(4) NOT NULL AUTO_INCREMENT,
    `nombre` VARCHAR(40) DEFAULT NULL,
    `descripcion` VARCHAR(40) DEFAULT NULL,
    `imagen` VARCHAR(40) DEFAULT NULL,
    `precio` DOUBLE DEFAULT 0.0,
    PRIMARY KEY (`id`)
) ENGINE=InnoDB;

CREATE TABLE `tb_pizza` (
    `id` INT(4) NOT NULL AUTO_INCREMENT,
    `id_ingredientes` INT(4) NOT NULL,
    `id_pizza_info` INT(4) NOT NULL,
    PRIMARY KEY (`id`)
) ENGINE=InnoDB;

CREATE TABLE `tb_ingredientes` (
    `id` INT(4) NOT NULL AUTO_INCREMENT,
    `nombre` VARCHAR(40) DEFAULT NULL,
    `precio` DOUBLE DEFAULT 0.0,
    PRIMARY KEY (`id`)
) ENGINE=InnoDB;





CREATE TABLE `tb_pedido_info` (
    `id` INT(4) NOT NULL AUTO_INCREMENT,
    `id_cliente` INT(4) NOT NULL,
    `id_empleado` INT(4) NOT NULL,
    `direccion` VARCHAR(40) DEFAULT NULL,
    `estado` VARCHAR(40) DEFAULT NULL,
    `fecha` DATE,
    `hora` TIME,
    PRIMARY KEY (`id`)
) ENGINE=InnoDB;

CREATE TABLE `tb_pedido` (
    `id` INT(4) NOT NULL AUTO_INCREMENT,
    `id_pizza` INT(4) NOT NULL,
    `id_ingredientes` INT(4) NOT NULL,
    `id_pedido` DOUBLE DEFAULT 0.0,
    PRIMARY KEY (`id`)
) ENGINE=InnoDB;

CREATE TABLE `tb_pizza_pedido` (
    `id` INT(4) NOT NULL AUTO_INCREMENT,
    `id_pedido_info` INT(4) NOT NULL,
    `precio_total` DOUBLE DEFAULT 0.0,
    PRIMARY KEY (`id`)
) ENGINE=InnoDB;

CREATE TABLE `tb_otros_productos_pedido` (
    `id` INT(4) NOT NULL AUTO_INCREMENT,
    `id_pedido` INT(4) NOT NULL,
    `id_otros_productos` INT(4) NOT NULL,
    PRIMARY KEY (`id`)
) ENGINE=InnoDB;

CREATE TABLE `tb_otros_productos` (
    `id` INT(4) NOT NULL AUTO_INCREMENT,
    `id_categoria_producto` INT(4) NOT NULL,
    `nombre` VARCHAR(40) DEFAULT NULL,
    `descripcion` VARCHAR(40) DEFAULT NULL,    
    `precio` DOUBLE DEFAULT 0.0,
    PRIMARY KEY (`id`)
) ENGINE=InnoDB;

CREATE TABLE `tb_categoria_producto` (
    `id` INT(4) NOT NULL AUTO_INCREMENT,
    `nombre` VARCHAR(40) DEFAULT NULL,
    PRIMARY KEY (`id`)
) ENGINE=InnoDB;




--alter table products
--add foreign key (id_category) references category(id_category)
--on update cascade;



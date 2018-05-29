-- phpMyAdmin SQL Dump
-- version 2.7.0-pl2
-- http://www.phpmyadmin.net
-- 
-- Servidor: localhost
-- Tiempo de generación: 28-09-2012 a las 17:28:49
-- Versión del servidor: 5.0.18
-- Versión de PHP: 5.1.2
-- 
-- Base de datos: `pasteleria`
-- 

-- --------------------------------------------------------

-- 
-- Estructura de tabla para la tabla `abono`
-- 

CREATE TABLE `abono` (
  `Abono_Id` int(11) NOT NULL,
  `Abono_Id_Pedido` smallint(6) NOT NULL,
  `Abono_Valor` double NOT NULL,
  `Abono_Saldo` double NOT NULL,
  `Abono_Fecha` date NOT NULL,
  PRIMARY KEY  (`Abono_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Volcar la base de datos para la tabla `abono`
-- 

INSERT INTO `abono` VALUES (1, 1, 20500, 29500, '2012-09-28');
INSERT INTO `abono` VALUES (2, 2, 15200, 29800, '2012-09-28');

-- --------------------------------------------------------

-- 
-- Estructura de tabla para la tabla `cliente`
-- 

CREATE TABLE `cliente` (
  `Cliente_Id` int(11) NOT NULL,
  `Cliente_Nombre` varchar(40) NOT NULL,
  `Cliente_Telefono` varchar(40) NOT NULL,
  `Cliente_Direccion` varchar(40) NOT NULL,
  PRIMARY KEY  (`Cliente_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Volcar la base de datos para la tabla `cliente`
-- 

INSERT INTO `cliente` VALUES (1, 'CARLOS ADOLFO SIABATO COTAMO', '3134526955-45269789933', 'CARRERA 24 NUMERO 25-18 AVENIDA SIEMPRE');
INSERT INTO `cliente` VALUES (2, 'JUANITO PEREZ PEREZ', '313465269555', 'NO TIENE');
INSERT INTO `cliente` VALUES (3, 'CARLOS GOMEZ', '313695448-1326547878', 'CARRERA 25 NUMERO 13-15 SUR');
INSERT INTO `cliente` VALUES (4, 'CARLOS ADOLFO SIABATO COTAMO', '3134526955-45269789933', 'CARRERA 24 NUMERO 25-18 AVENIDA SIEMPRE ');
INSERT INTO `cliente` VALUES (5, 'JUAN CAMILO', '3134526955-3134526955', 'CARRERA 25 NUMERO 19-15 SUR');

-- --------------------------------------------------------

-- 
-- Estructura de tabla para la tabla `pastel`
-- 

CREATE TABLE `pastel` (
  `pastel_Id` smallint(6) NOT NULL,
  `Pastel_Nombre` varchar(20) NOT NULL,
  `Pastel_Precio` double NOT NULL,
  `Pastel_NumPers` varchar(4) NOT NULL,
  `Pastel_Detalle` varchar(40) NOT NULL,
  `Pastel_Forma` varchar(15) NOT NULL,
  `Pastel_Cubierta` varchar(20) NOT NULL,
  PRIMARY KEY  (`pastel_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Volcar la base de datos para la tabla `pastel`
-- 

INSERT INTO `pastel` VALUES (1, 'PASTEL LAS DELICIAS', 50000, '30', 'TIENE VARIAS FORMAS', 'REDONDA', 'CHOCOLATE');
INSERT INTO `pastel` VALUES (2, 'LA DELICIA', 45000, '35', 'VAINILLA O CHOCOLATE', 'CUADRADA', 'VAINILLA');

-- --------------------------------------------------------

-- 
-- Estructura de tabla para la tabla `pedido`
-- 

CREATE TABLE `pedido` (
  `Pedido_Id` int(11) NOT NULL,
  `Pedido_Id_Pastel` smallint(6) NOT NULL,
  `Pedido_Id_Cliente` smallint(6) NOT NULL,
  `Pedido_FechaPedido` date NOT NULL,
  `Pedido_FechaEntrega` date NOT NULL,
  `Pedido_HoraEntrega` varchar(12) NOT NULL,
  `Pedido_NumMesas` smallint(6) NOT NULL,
  `Pedido_Deposito` double NOT NULL,
  `Pedido_Comentario` varchar(50) NOT NULL,
  `Pedido_Usuario` varchar(30) NOT NULL,
  PRIMARY KEY  (`Pedido_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Volcar la base de datos para la tabla `pedido`
-- 

INSERT INTO `pedido` VALUES (1, 1, 3, '2012-09-28', '2012-09-28', '02:29:00 p.m', 2, 15200, 'NADA', 'NADA');
INSERT INTO `pedido` VALUES (2, 2, 4, '2012-09-28', '2012-09-28', '02:29:00 p.m', 2, 15000, 'NINGUNA', 'CARLOS');

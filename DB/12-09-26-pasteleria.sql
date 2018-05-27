-- phpMyAdmin SQL Dump
-- version 2.7.0-pl2
-- http://www.phpmyadmin.net
-- 
-- Servidor: localhost
-- Tiempo de generación: 26-09-2012 a las 12:35:24
-- Versión del servidor: 5.0.18
-- Versión de PHP: 5.1.2
-- 
-- Base de datos: `pasteleria`
-- 

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
INSERT INTO `cliente` VALUES (2, 'JUANITO PERES PEREZ PEREZ', '313465269555', 'NO TIENE');
INSERT INTO `cliente` VALUES (3, 'CARLOS ADOLOF SIABATO COTAMO', '313695448-1326547878', 'CARRERA 25 NUMERO 13-15 SUR');
INSERT INTO `cliente` VALUES (4, 'CARLOS ADOLFO SIABATO COTAMO', '3134526955-45269789933', 'CARRERA 24 NUMERO 25-18 AVENIDA SIEMPRE ');
INSERT INTO `cliente` VALUES (5, 'JUAN CALROS', '3134526955-3134526955', 'CARRERA 25 NUMERO 19-15 SUR');
INSERT INTO `cliente` VALUES (6, 'CARLOS', 'asdfadsf', 'DAFADS');

-- --------------------------------------------------------

-- 
-- Estructura de tabla para la tabla `pastel`
-- 

CREATE TABLE `pastel` (
  `pastel_Id` smallint(6) NOT NULL,
  `Pastel_Nombre` varchar(20) NOT NULL,
  `Pastel_Precio` varchar(15) NOT NULL,
  `Pastel_NumPers` varchar(4) NOT NULL,
  `Pastel_Detalle` varchar(40) NOT NULL,
  `Pastel_Forma` varchar(15) NOT NULL,
  `Pastel_Cubierta` varchar(20) NOT NULL,
  PRIMARY KEY  (`pastel_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Volcar la base de datos para la tabla `pastel`
-- 

INSERT INTO `pastel` VALUES (1, 'PASTEL PORCION MEJOR', '45622', '45', 'VIENE PARA X O Y', 'REDONDA', 'CHOCOLATE');
INSERT INTO `pastel` VALUES (2, 'CARLOS ADOLFO', 'adsfasdf', 'adsf', 'ASDFADSF', 'FADSFASD', 'CASSDF');

-- --------------------------------------------------------

-- 
-- Estructura de tabla para la tabla `pedido`
-- 

CREATE TABLE `pedido` (
  `Pedido_Id` int(11) NOT NULL,
  `Pedido_Id_Pastel` smallint(6) NOT NULL,
  `Pedido_Abono` double NOT NULL,
  `Pedido_Saldo` double NOT NULL,
  `Pedido_FechaPedido` datetime NOT NULL,
  `Pedido_FechaEntrega` datetime NOT NULL,
  `Pedido_Comentario` varchar(50) NOT NULL,
  PRIMARY KEY  (`Pedido_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Volcar la base de datos para la tabla `pedido`
-- 


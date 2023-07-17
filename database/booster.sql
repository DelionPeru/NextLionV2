-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         10.5.0-MariaDB - mariadb.org binary distribution
-- SO del servidor:              Win32
-- HeidiSQL Versión:             10.2.0.5599
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Volcando estructura de base de datos para nextlion
CREATE DATABASE IF NOT EXISTS `nextlion` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `nextlion`;

-- Volcando estructura para tabla nextlion.booster
CREATE TABLE IF NOT EXISTS `booster` (
  `idbooster` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) DEFAULT NULL,
  `diametro` double DEFAULT NULL,
  `longitud` double DEFAULT NULL,
  `densidad` double DEFAULT NULL,
  `energia` double DEFAULT NULL,
  `vod` double DEFAULT NULL,
  `rws` double DEFAULT NULL,
  `color` text DEFAULT NULL,
  `costo` double DEFAULT NULL,
  `is_delete` int(11) DEFAULT NULL,
  `usuario_idusuario` int(11) NOT NULL,
  `is_public_local` int(11) DEFAULT NULL,
  `is_public_nube` int(11) DEFAULT NULL,
  PRIMARY KEY (`idbooster`),
  KEY `fk_booster_usuario1_idx` (`usuario_idusuario`),
  CONSTRAINT `fk_booster_usuario1` FOREIGN KEY (`usuario_idusuario`) REFERENCES `usuario` (`idusuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla nextlion.booster: ~4 rows (aproximadamente)
/*!40000 ALTER TABLE `booster` DISABLE KEYS */;
INSERT INTO `booster` (`idbooster`, `nombre`, `diametro`, `longitud`, `densidad`, `energia`, `vod`, `rws`, `color`, `costo`, `is_delete`, `usuario_idusuario`, `is_public_local`, `is_public_nube`) VALUES
	(1, 'Prueba', 1, 12, 0, 21, 9, 9, '96,128,128,255', 1.2, 0, 1, 0, 0),
	(2, 'test', 2, 18, 0, 282, 15, 9, '89,0,128,128', 1.8, 0, 1, 0, 0),
	(3, 'test2', 1, 12, 0, 0, 0, 0, '255,128,128,0', 0, 1, 1, 0, 0),
	(4, 'BS-450', 2, 5, 0, 0, 0, 0, '255,128,0,64', 0, 0, 4, 0, 0);
/*!40000 ALTER TABLE `booster` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;

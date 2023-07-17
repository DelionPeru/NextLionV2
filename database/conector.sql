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

-- Volcando estructura para tabla nextlion.conector
CREATE TABLE IF NOT EXISTS `conector` (
  `idconector` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) DEFAULT NULL,
  `tiempo_superficie` int(11) DEFAULT NULL,
  `tiempo_fondo` int(11) DEFAULT NULL,
  `tipo` int(11) DEFAULT NULL,
  `color` text DEFAULT NULL,
  `costo` double DEFAULT NULL,
  `vod` double DEFAULT NULL,
  `is_delete` int(11) DEFAULT NULL,
  `usuario_idusuario` int(11) NOT NULL,
  `is_public_local` int(11) DEFAULT NULL,
  `is_public_nube` int(11) DEFAULT NULL,
  `tiempo` int(11) DEFAULT NULL,
  `is_electronico` int(11) DEFAULT NULL,
  `tiempo_dispersion` int(11) DEFAULT 0,
  PRIMARY KEY (`idconector`),
  KEY `fk_conector_usuario1_idx` (`usuario_idusuario`),
  CONSTRAINT `fk_conector_usuario1` FOREIGN KEY (`usuario_idusuario`) REFERENCES `usuario` (`idusuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla nextlion.conector: ~25 rows (aproximadamente)
/*!40000 ALTER TABLE `conector` DISABLE KEYS */;
INSERT INTO `conector` (`idconector`, `nombre`, `tiempo_superficie`, `tiempo_fondo`, `tipo`, `color`, `costo`, `vod`, `is_delete`, `usuario_idusuario`, `is_public_local`, `is_public_nube`, `tiempo`, `is_electronico`, `tiempo_dispersion`) VALUES
	(1, 'test', 0, 0, 1, '119,0,255,0', 1.5, 36, 0, 1, 0, 0, 6, 0, 5),
	(2, 'test1', 0, 0, 2, '200,255,128,64', 1.5, 1.5, 0, 1, 0, 0, 18, 0, 0),
	(3, 'test2', 12, 18, 3, '187,0,128,192', 1.5, 1.8, 0, 1, 0, 0, 0, 0, 0),
	(4, 'test4', 0, 0, 0, '203,0,255,255', 1.5, 1.5, 0, 1, 0, 0, 15, 1, 0),
	(5, 'Test5', 0, 0, 0, '255,0,255,64', 2.1, 2.1, 0, 1, 0, 0, 9, 1, 0),
	(6, 'fametronic', 0, 0, 0, '128,0,255,64', 0, 0, 0, 1, 0, 0, 0, 1, 0),
	(7, '500 ms', 0, 0, 2, '200,0,64,128', 1.5, 1.5, 0, 1, 0, 0, 500, 0, 0),
	(8, '550 ms', 0, 0, 2, '255,255,0,0', 0, 0, 0, 1, 0, 0, 550, 0, 0),
	(9, '550 ms', 0, 0, 2, '255,255,0,0', 0, 0, 0, 1, 0, 0, 550, 0, 0),
	(10, 'fametronic', 0, 0, 0, '128,255,0,0', 0, 0, 0, 1, 0, 0, 0, 1, 0),
	(11, '500 ms', 0, 0, 2, '200,128,0,64', 1.5, 1.5, 0, 1, 0, 0, 500, 0, 0),
	(12, '25 ms', 0, 0, 1, '255,255,0,0', 0, 0, 0, 1, 0, 0, 25, 0, 0),
	(13, '42 ms', 0, 0, 1, '255,128,128,128', 0, 0, 0, 1, 0, 0, 42, 0, 0),
	(14, '0 ms', 0, 0, 1, '255,128,0,64', 0, 0, 0, 1, 0, 0, 0, 0, 0),
	(15, 'Conectyor PRueba', 0, 0, 1, '255,0,64,64', 0, 0, 0, 1, 0, 0, 12, 0, 3),
	(16, '15 ms - 2 ms', 15, 2, 9, '255,0,128,128', 0, 0, 0, 1, 0, 0, 0, 1, 0),
	(17, '27 ms - 2 ms', 27, 2, 9, '255,0,0,255', 0, 0, 0, 1, 0, 0, 0, 1, 0),
	(18, '14 ms - 2 ms', 14, 2, 9, '255,0,0,160', 0, 0, 0, 4, 0, 0, 0, 1, 0),
	(19, '14 ms', 14, 0, 9, '255,0,0,255', 0, 0, 1, 4, 0, 0, 0, 1, 0),
	(20, '26 ms', 26, 0, 9, '255,255,128,64', 0, 0, 0, 4, 0, 0, 0, 1, 0),
	(21, '14 ms - 2 ms', 14, 2, 9, '255,0,0,160', 0, 0, 1, 4, 0, 0, 0, 1, 0),
	(22, 'fametronic', 0, 0, 0, '128,0,255,64', 0, 0, 0, 4, 0, 0, 0, 1, 0),
	(23, 'Next3', 0, 0, 0, '255,0,0,160', 0, 0, 0, 4, 0, 0, 0, 1, 0),
	(24, '30 ms - 10 ms', 30, 10, 9, '255,0,255,0', 0, 0, 0, 4, 0, 0, 0, 1, 0),
	(25, '100 ms - 10 ms', 100, 10, 9, '255,128,0,64', 0, 0, 0, 4, 0, 0, 0, 1, 0);
/*!40000 ALTER TABLE `conector` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;

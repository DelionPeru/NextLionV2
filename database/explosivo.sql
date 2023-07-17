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

-- Volcando estructura para tabla nextlion.explosivo
CREATE TABLE IF NOT EXISTS `explosivo` (
  `idexplosivo` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) DEFAULT NULL,
  `densidad` double DEFAULT NULL,
  `vod` double DEFAULT NULL,
  `rws` double DEFAULT NULL,
  `energia` double DEFAULT NULL,
  `is_cartucho` int(11) DEFAULT NULL,
  `longitud` double DEFAULT NULL,
  `diametro` double DEFAULT NULL,
  `color` text DEFAULT NULL,
  `costo` double DEFAULT NULL,
  `unidad` text DEFAULT NULL,
  `is_delete` int(11) DEFAULT NULL,
  `usuario_idusuario` int(11) NOT NULL,
  `is_public_local` int(11) DEFAULT NULL,
  `is_public_nube` int(11) DEFAULT NULL,
  `tipo` int(11) DEFAULT 1,
  PRIMARY KEY (`idexplosivo`),
  KEY `fk_explosivo_usuario1_idx` (`usuario_idusuario`),
  CONSTRAINT `fk_explosivo_usuario1` FOREIGN KEY (`usuario_idusuario`) REFERENCES `usuario` (`idusuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=40 DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla nextlion.explosivo: ~39 rows (aproximadamente)
/*!40000 ALTER TABLE `explosivo` DISABLE KEYS */;
INSERT INTO `explosivo` (`idexplosivo`, `nombre`, `densidad`, `vod`, `rws`, `energia`, `is_cartucho`, `longitud`, `diametro`, `color`, `costo`, `unidad`, `is_delete`, `usuario_idusuario`, `is_public_local`, `is_public_nube`, `tipo`) VALUES
	(1, 'ANFO', 0.84, 0, 0, 0, 0, 0, 0, '139,255,128,0', 0, '0', 0, 1, 0, 0, 1),
	(2, 'SANG-APU', 1.11, 0, 0, 0, 0, 0, 0, '255,0,255,64', 0, '0', 0, 1, 0, 0, 1),
	(3, 'AIRE', 1, 0, 0, 0, 0, 0, 0, '255,192,192,192', 0, '0', 0, 1, 0, 0, 2),
	(4, 'TEST', 1.1, 0, 0, 0, 0, 0, 0, '46,128,0,255', 0, '0', 0, 1, 0, 0, 1),
	(5, 'TEST2', 1.2, 0, 0, 0, 0, 0, 0, '255,0,128,64', 0, '0', 0, 1, 0, 0, 1),
	(6, 'TEST3', 1.5, 0, 0, 0, 0, 0, 0, '255,0,128,64', 0, '0', 0, 1, 0, 0, 1),
	(7, 'TEST4', 1.5, 0, 0, 0, 0, 0, 0, '255,0,255,255', 0, '0', 0, 1, 0, 0, 1),
	(8, 'TEST5', 1.5, 0, 0, 0, 0, 0, 0, '255,0,64,128', 0, '0', 0, 1, 0, 0, 1),
	(9, 'TEST6', 1.4, 0, 0, 0, 0, 0, 0, '255,128,128,255', 0, '0', 0, 1, 0, 0, 1),
	(10, 'TEST2', 1.22, 0, 0, 0, 0, 0, 0, '255,128,0,128', 0, '0', 0, 1, 0, 0, 1),
	(11, 'TEST2', 1.23, 0, 0, 0, 0, 0, 0, '255,255,0,128', 0, '0', 0, 1, 0, 0, 1),
	(12, 'CARTUCHO TEST', 1.2, 0, 0, 0, 1, 20, 2, '255,0,128,128', 0, '0', 0, 1, 0, 0, 1),
	(13, 'PRUEBA', 0.1, 0, 0, 0, 0, 0, 0, '255,128,64,64', 0, '0', 1, 1, 0, 0, 1),
	(14, 'PRUEBA 2', 0.1, 0, 0, 0, 0, 0, 0, '255,128,128,192', 0, '0', 1, 1, 0, 0, 1),
	(15, 'CARTUCHO PRUEBA', 0.1, 0, 0, 0, 1, 30, 1, '255,128,128,255', 0, '0', 0, 1, 0, 0, 1),
	(16, 'TEST2', 1.2, 0, 0, 0, 0, 0, 0, '255,0,0,255', 0, '0', 0, 1, 0, 0, 1),
	(17, 'TEST2', 1.2, 0, 0, 0, 0, 0, 0, '255,128,0,255', 0, '0', 0, 1, 0, 0, 1),
	(18, 'TEST2', 1.2, 0, 0, 0, 0, 0, 0, '255,128,0,255', 0, '0', 0, 1, 0, 0, 1),
	(19, 'INERTE 1', 1.8, 6, 0, 0, 0, 0, 0, '255,0,0,0', 0, '0', 0, 1, 0, 0, 2),
	(20, 'DETRITUS', 1.8, 6, 0, 0, 0, 0, 0, '255,128,128,0', 0, '0', 1, 1, 0, 0, 2),
	(21, 'AIRDECK_', 1, 0, 0, 0, 0, 0, 0, '255,0,255,255', 0, '0', 1, 1, 0, 0, 2),
	(22, 'AIRE', 1, 0, 0, 0, 0, 0, 0, '255,192,192,192', 0, '0', 1, 1, 0, 0, 2),
	(23, 'DETRITUS', 1.8, 6, 0, 0, 0, 0, 0, '255,128,128,0', 0, '0', 1, 1, 0, 0, 2),
	(24, 'AIRDECK_', 1, 0, 0, 0, 0, 0, 0, '255,0,255,255', 0, '0', 1, 1, 0, 0, 2),
	(25, 'AIRE', 1, 0, 0, 0, 0, 0, 0, '255,192,192,192', 0, '0', 1, 1, 0, 0, 2),
	(26, 'DETRITUS', 1.8, 6, 0, 0, 0, 0, 0, '255,128,128,0', 0, '0', 0, 1, 0, 0, 2),
	(27, 'AIRDECK_', 1, 0, 0, 0, 0, 0, 0, '255,0,255,255', 0, '0', 0, 1, 0, 0, 2),
	(28, 'INERTE2', 2.7, 0, 0, 0, 0, 0, 0, '255,128,128,64', 0, '0', 0, 1, 0, 0, 2),
	(29, 'EXPLOSIVO 2 EDIT', 1.2, 6, 12, 9, 0, 0, 0, '255,255,128,64', 0.6, '0', 0, 1, 0, 0, 1),
	(30, 'SANG-APU', 1.11, 0, 0, 0, 0, 0, 0, '255,0,128,255', 0, '0', 0, 1, 0, 0, 1),
	(31, 'EMULNOR 5000', 1.16, 5500, 0, 1010, 1, 40.64, 2, '255,255,255,0', 0, '0', 0, 1, 0, 0, 1),
	(32, 'ANFITO', 0.84, 0, 0, 0, 0, 0, 0, '139,255,128,0', 0, '0', 0, 1, 0, 0, 1),
	(33, 'ANFITO_EDIT', 0.84, 0, 0, 0, 0, 0, 0, '139,255,128,0', 0, '0', 0, 1, 0, 0, 1),
	(34, 'SUPERFAM DOS', 0.8, 3300, 0, 0, 0, 0, 0, '255,255,128,64', 0, '0', 0, 1, 0, 0, 1),
	(35, 'INERTE', 1, 0, 0, 0, 0, 0, 0, '255,128,128,0', 0, '0', 0, 4, 0, 0, 2),
	(36, 'DETRITUS', 1, 0, 0, 0, 0, 0, 0, '255,128,128,0', 0, '0', 0, 4, 0, 0, 2),
	(37, 'ANFO', 0.84, 0, 0, 0, 0, 0, 0, '255,255,0,255', 0, '0', 0, 4, 0, 0, 1),
	(38, 'EMULSION', 1.2, 4500, 110, 0, 0, 0, 0, '255,0,64,128', 0, '0', 0, 4, 0, 0, 1),
	(39, 'CARTUCHO 1', 1.3, 5500, 0, 0, 1, 35, 2, '255,255,0,0', 0, '0', 0, 4, 0, 0, 1);
/*!40000 ALTER TABLE `explosivo` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;

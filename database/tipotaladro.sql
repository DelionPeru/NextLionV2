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

-- Volcando estructura para tabla nextlion.tipotaladro
CREATE TABLE IF NOT EXISTS `tipotaladro` (
  `idtipotaladro` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(150) DEFAULT '',
  `color` text DEFAULT '255,0,0,0',
  `is_delete` int(11) DEFAULT 0,
  PRIMARY KEY (`idtipotaladro`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla nextlion.tipotaladro: ~10 rows (aproximadamente)
/*!40000 ALTER TABLE `tipotaladro` DISABLE KEYS */;
INSERT INTO `tipotaladro` (`idtipotaladro`, `nombre`, `color`, `is_delete`) VALUES
	(1, 'No Definido', '255,0,0,0', 0),
	(2, 'Precorte', '255,20,160,223', 0),
	(3, 'Buffer', '255,153,223,20', 0),
	(4, 'Produccion', '255,223,125,20', 0),
	(5, '01 DECK', '255,223,125,20', 0),
	(6, '02 DECK', '255,223,125,20', 0),
	(7, '03 DECK', '255,223,125,20', 0),
	(8, '04 DECK', '255,223,125,20', 0),
	(9, '05 DECK', '255,223,125,20', 0),
	(10, '06 DECK', '255,223,125,20', 0);
/*!40000 ALTER TABLE `tipotaladro` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;

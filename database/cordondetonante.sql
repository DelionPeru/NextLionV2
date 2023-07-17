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

-- Volcando estructura para tabla nextlion.cordondetonante
CREATE TABLE IF NOT EXISTS `cordondetonante` (
  `idcordondetonante` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) DEFAULT NULL,
  `energia` double DEFAULT NULL,
  `vod` double DEFAULT NULL,
  `color` text DEFAULT NULL,
  `costo` double DEFAULT NULL,
  `is_delete` int(11) DEFAULT NULL,
  `usuario_idusuario` int(11) NOT NULL,
  `is_public_local` int(11) DEFAULT NULL,
  `is_public_nube` int(11) DEFAULT NULL,
  PRIMARY KEY (`idcordondetonante`),
  KEY `fk_cordondetonante_usuario1_idx` (`usuario_idusuario`),
  CONSTRAINT `fk_cordondetonante_usuario1` FOREIGN KEY (`usuario_idusuario`) REFERENCES `usuario` (`idusuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla nextlion.cordondetonante: ~4 rows (aproximadamente)
/*!40000 ALTER TABLE `cordondetonante` DISABLE KEYS */;
INSERT INTO `cordondetonante` (`idcordondetonante`, `nombre`, `energia`, `vod`, `color`, `costo`, `is_delete`, `usuario_idusuario`, `is_public_local`, `is_public_nube`) VALUES
	(1, 'Cordon1Edit', 0, 3, '115,128,0,128', 0.3, 0, 1, 0, 0),
	(2, 'Cordon2', 0, 3, '86,128,128,192', 0.3, 1, 1, 0, 0),
	(3, 'Cordon3', 0, 9, '255,128,128,255', 0.12, 0, 1, 0, 0),
	(4, 'CD', 0, 0, '255,128,0,128', 0, 0, 4, 0, 0);
/*!40000 ALTER TABLE `cordondetonante` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;

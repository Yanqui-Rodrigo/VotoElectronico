-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         10.1.38-MariaDB - mariadb.org binary distribution
-- SO del servidor:              Win64
-- HeidiSQL Versión:             9.3.0.4984
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Volcando estructura de base de datos para monitoreo_agricola_proyect
CREATE DATABASE IF NOT EXISTS `monitoreo_agricola_proyect` /*!40100 DEFAULT CHARACTER SET utf8 COLLATE utf8_spanish_ci */;
USE `monitoreo_agricola_proyect`;


-- Volcando estructura para tabla monitoreo_agricola_proyect.tbcargo
CREATE TABLE IF NOT EXISTS `tbcargo` (
  `id` varchar(10) COLLATE utf8_spanish_ci NOT NULL,
  `cargo` varchar(40) COLLATE utf8_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- Volcando datos para la tabla monitoreo_agricola_proyect.tbcargo: ~1 rows (aproximadamente)
/*!40000 ALTER TABLE `tbcargo` DISABLE KEYS */;
INSERT INTO `tbcargo` (`id`, `cargo`) VALUES
	('0tbencargadosvotoselectronicosUsp_S_Ingresar0001', 'administrador');
/*!40000 ALTER TABLE `tbcargo` ENABLE KEYS */;


-- Volcando estructura para tabla monitoreo_agricola_proyect.tbencargados
CREATE TABLE IF NOT EXISTS `tbencargados` (
  `id` varchar(10) COLLATE utf8_spanish_ci NOT NULL,
  `nombre` varchar(40) COLLATE utf8_spanish_ci DEFAULT NULL,
  `apellido` varchar(40) COLLATE utf8_spanish_ci DEFAULT NULL,
  `telefono` varchar(9) COLLATE utf8_spanish_ci DEFAULT NULL,
  `direccion` varchar(80) COLLATE utf8_spanish_ci DEFAULT NULL,
  `correo` varchar(50) COLLATE utf8_spanish_ci DEFAULT NULL,
  `fcargo` varchar(10) COLLATE utf8_spanish_ci DEFAULT NULL,
  `clave` varchar(10) COLLATE utf8_spanish_ci DEFAULT NULL,
  `estado` varchar(10) COLLATE utf8_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `Fcargo` (`fcargo`),
  CONSTRAINT `Fcargo` FOREIGN KEY (`fcargo`) REFERENCES `tbcargo` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- Volcando datos para la tabla monitoreo_agricola_proyect.tbencargados: ~2 rows (aproximadamente)
/*!40000 ALTER TABLE `tbencargados` DISABLE KEYS */;
INSERT INTO `tbencargados` (`id`, `nombre`, `apellido`, `telefono`, `direccion`, `correo`, `fcargo`, `clave`, `estado`) VALUES
	('001', 'jose', 'contreras', '9328343', 'asdnasjd', 'contreras.murguia@gmail.com', '00001', '123456', 'Activo'),
	('123', 'carlos', 'limache', '123213', 'deadaedae', 'sadasd', '00001', '123123', 'activo');
/*!40000 ALTER TABLE `tbencargados` ENABLE KEYS */;


-- Volcando estructura para procedimiento monitoreo_agricola_proyect.Usp_D_EliminarCargo
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `Usp_D_EliminarCargo`(IN `Aid` VARCHAR(10))
BEGIN
delete  from tbcargo where id=Aid;
END//
DELIMITER ;


-- Volcando estructura para procedimiento monitoreo_agricola_proyect.Usp_D_EliminarEncargados
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `Usp_D_EliminarEncargados`(IN `Aid` VARCHAR(10))
BEGIN
delete from tbencargados where id =Aid;
END//
DELIMITER ;


-- Volcando estructura para procedimiento monitoreo_agricola_proyect.Usp_I_IngresarCargo
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `Usp_I_IngresarCargo`(IN `Aid` VARCHAR(10), IN `Acargo` VARCHAR(40))
BEGIN
insert into tbcargo(id,cargo)
values (Aid,Acargo);
END//
DELIMITER ;


-- Volcando estructura para procedimiento monitoreo_agricola_proyect.Usp_I_IngresarEncargados
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `Usp_I_IngresarEncargados`(IN `Aid` VARCHAR(10), IN `Anombre` VARCHAR(40), IN `Aapellido` VARCHAR(40), IN `Atelefono` VARCHAR(9), IN `Adireccion` VARCHAR(80), IN `Acorreo` VARCHAR(50), IN `Afcargo` VARCHAR(10), IN `Aclave` VARCHAR(10), IN `Aestado` VARCHAR(10))
BEGIN
insert into tbencargados (id,nombre,apellido,telefono,direccion,correo,fcargo,clave,estado)
values (Aid,Anombre,Aapellido,Atelefono,Adireccion,Acorreo,Afcargo,Aclave,Aestado);
END//
DELIMITER ;


-- Volcando estructura para procedimiento monitoreo_agricola_proyect.Usp_S_BuscarCargo
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `Usp_S_BuscarCargo`(IN `Aid` VARCHAR(10))
BEGIN
select id,cargo from tbcargo where id=Aid;
END//
DELIMITER ;


-- Volcando estructura para procedimiento monitoreo_agricola_proyect.Usp_S_BuscarEncargado
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `Usp_S_BuscarEncargado`(IN `Aid` VARCHAR(10))
BEGIN
select id,nombre,apellido,telefono,direccion,correo,fcargo,clave,estado from tbencargados where id=Aid;
END//
DELIMITER ;


-- Volcando estructura para procedimiento monitoreo_agricola_proyect.Usp_S_ListarCargo
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `Usp_S_ListarCargo`()
BEGIN
select * from tbcargo;
END//
DELIMITER ;


-- Volcando estructura para procedimiento monitoreo_agricola_proyect.Usp_S_ListarEncargado
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `Usp_S_ListarEncargado`()
BEGIN
select * from tbencargados;
END//
DELIMITER ;


-- Volcando estructura para procedimiento monitoreo_agricola_proyect.Usp_S_Login
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `Usp_S_Login`(IN `Aid` VARCHAR(10), IN `Aclave` VARCHAR(10))
BEGIN
SELECT * FROM tbencargados
where 
id=Aid and clave=Aclave;
END//
DELIMITER ;


-- Volcando estructura para procedimiento monitoreo_agricola_proyect.Usp_U_ModificarCargo
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `Usp_U_ModificarCargo`(IN `Aid` VARCHAR(10), IN `Acargo` VARCHAR(40))
BEGIN
update tbcargo set
cargo = Acargo
where id=Aid;
END//
DELIMITER ;


-- Volcando estructura para procedimiento monitoreo_agricola_proyect.Usp_U_ModificarEncargado
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `Usp_U_ModificarEncargado`(IN `Aid` VARCHAR(10), IN `Anombre` VARCHAR(40), IN `Aapellido` VARCHAR(40), IN `Atelefono` VARCHAR(9), IN `Adireccion` VARCHAR(80), IN `Acorreo` VARCHAR(50), IN `Afcargo` VARCHAR(10), IN `Aclave` VARCHAR(10), IN `Aestado` VARCHAR(10))
BEGIN
update tbencargados set
nombre=Anombre,apellido=Aapellido,telefono=Atelefono,direccion=Adireccion,correo=Acorreo,fcargo=Afcargo,clave=Aclave,estado=Aestado
where id=Aid;
END//
DELIMITER ;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;

DROP TABLE `laboratorio`.`usuarios`;
create table Inventario
(
ID int,
Descripcion char(85) not null,
Cantidad int not null,
Marca char(20) not null,
Modelo char(25),
Serie char(25)
);
insert into `laboratorio`.`inventario` (`ID`, `Descripcion`, `Cantidad`, `Marca`, `Modelo`, `Serie`, `Laboratorio`) 
VALUES (1, 'cincel', 1, 'STANLEY', '', '', 'ing. industrial');
insert into `laboratorio`.`usuarios` (`ID`, `Contraseña`, `Carrera`, `Nombre`, `Encargado`) 
VALUES ('52', 'Jairo', 'ing. industrial', 'Jairo Blas Izquierdo', 1);
ALTER TABLE `laboratorio`.`herramienta` 
CHANGE COLUMN `ID` `ID` INT AUTO_INCREMENT NOT NULL;
truncate table herramienta;
insert into herramienta values(0,'Pinza', 'Jesus','','31/10/2022 10:08 a. m.','ing. en sistemas computacionales');
SELECT * FROM usuarios where Nombre = 'Felipe de Jesús castillo Duarte' and Encargado = 1;
SELECT * FROM usuarios where Encargado = 0;
select substring_index(Nombre, ',', 1) from usuarios where Maestro = 1 and Carrera = 'ing. industrial';
SELECT * FROM inventario where Laboratorio = "ing. civil";
alter table herramienta add Carrera varchar(85) not null;
update usuarios set Contraseña = 'admin' where ID = '2';
delete from usuarios where ID = 19302040;
SELECT * FROM usuarios where Maestro = 1 and Carrera = 'ing. en sistemas computacionales';
select * from usuarios;
select * from usuarios where ID = 2 and Contraseña = 'admin';
select * from usuarios where Carrera = 'ing. en sistemas computacionales' and Encargado = 1;
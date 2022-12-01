Create database HOSPITAL

USE HOSPITAL 

Create table Paciente(
 DPI_PACIENTE int,
 Nombre varchar(50),
 Apellido varchar(50),
 Dirección varchar(50),
 Estado Bit
 PRIMARY KEY (DPI_PACIENTE)
);

Create table Consulta(
 ID_CONSULTA int,
 DPI_PACIENTE int,
 ID_EMPLEADO int,
 Fecha_Consulta date,
 Padecimiento varchar(50),
 PRIMARY KEY (ID_CONSULTA)
);

Create table Empleado(
 ID_Empleado int,
 Nombre varchar(50),
 Apellido varchar(50),
 Puesto varchar(50),
 Teléfono int,
 Sueldo float,
 Estado Bit
 PRIMARY KEY (ID_Empleado)
); 


select * from Paciente
select * from Consulta
select * from Empleado


--INSERTAR DATOS DE LA TABLA PACIENTE--
INSERT INTO Paciente(DPI_PACIENTE, Nombre, Apellido, Dirección,Estado )Values
('896','Carlos Jose','Perez Alonzo','Mixco, Guatemala','1')

INSERT INTO Paciente(DPI_PACIENTE, Nombre, Apellido, Dirección,Estado )Values
('547','Maria Jose','Gonzales Mendez','Villa Nueva, Guatemala','1'),
('456','Fernanda','Lopez Día','Santa Rosa, Guatemala','1'),
('789','Lucia Mariela','Ezpinoza Paz','Chiquimula, Guatemala','1'),
('9101','Rafael Jose','Ramirez Garcia','Peten, Guatemala','1'),
('0102','Jose Alejandro','Guerra Estrada','Baja Verapaz, Guatemala','1'),
('0103','Edin Jose','Maldonado Jurado','Alta Verpaz, Guatemala','1'),
('6597','Maritza Andrea','Arellano Rodriguez','Escuintla, Guatemala','1'),
('7458','Daniela Estefany','Pirir Beltrán','Mixco, Guatemala','1')


--Insertar DATOS DE LA TABLA CONSULTA--

INSERT INTO Consulta(ID_CONSULTA,  DPI_PACIENTE, ID_EMPLEADO , Fecha_Consulta, Padecimiento)Values
('01','896','202001','2021-02-02','apendicitis aguda')

INSERT INTO Consulta(ID_CONSULTA,  DPI_PACIENTE, ID_EMPLEADO , Fecha_Consulta)Values
('03','547','202002','2021-03-02','Indigestion Intestinal'),
('04','456','202003','2021-03-03','Fiebre'),
('05','789','202001','2021-03-04','Mareas'),
('06','9101','202003','2021-03-05','Hipertensión'),
('07','0102','202001','2021-03-05','Alteración de la frecuencia cardíaca'),
('08','0103','202004','2021-03-06','Síntomas del sistema nervioso'),
('09','6597','202004','2021-03-07','Alteraciones en la orina'),
('10','7458','202002','2021-04-04','Complicación a nivel del drenaje biliar')


--INSERTAR DATOS DE LA TABLA EMPLEADOS--
INSERT INTO Empleado (ID_Empleado, Nombre, Apellido, Puesto, Teléfono, Sueldo,Estado) VALUES 
('202001', 'Lidia Griselda', 'Cujá Jerónimo', 'Doctora Cirujana', '53306776', '5500','1')

INSERT INTO Empleado (ID_Empleado, Nombre, Apellido, Puesto, Teléfono, Sueldo) VALUES 
('202003', 'Rolando Jose', 'Gonzales Mendez', 'Dermatología.', '98567412', '6000','1'),
('202004', 'Kevin Alexander', 'Monroy Mellano', 'Ginecología y obstetricia o tocología.', '98745123', '7000','1'),
('202005', 'Daniel Jose', 'Canel Chitay', 'Medicina de Urgencias', '65847129', '6500','1'),
('202006', 'Martina Alejandra', 'Jimenez Mendez', 'Oftalmología', '85471234', '6500','1'),
('202007', 'Tania Estefany', 'Roblero Vasquez', 'Otorrinolaringología', '78456312', '7000','1'),
('202008', 'Kelly Raquel', 'Botero Gutierrez', 'Traumatología', '96547123', '7000','1'),
('202009', 'Diana', 'Giron Loera', 'Urología.', '87456321', '5500','1'),
('2020010', 'Marcelo Octaviano', 'Alvarador Giron', 'Urología.', '23568974', '600','1')









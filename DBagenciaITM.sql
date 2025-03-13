CREATE DATABASE Agencia_ITM;
GO

USE Agencia_ITM;
GO

CREATE TABLE Agencia (
id_agencia INT PRIMARY KEY,
nombre VARCHAR(200) NOT NULL,
direccion VARCHAR(200) NOT NULL,
telefono VARCHAR(200) NOT NULL
);

CREATE TABLE Cliente (
id_cliente INT PRIMARY KEY,
nombre VARCHAR(50) NOT NULL,
apellido VARCHAR(150) NOT NULL,
telefono VARCHAR(15) NOT NULL,
correo VARCHAR(50) NOT NULL
);

CREATE TABLE TipoVivienda (
id_tipo_vivienda INT PRIMARY KEY,
descripción VARCHAR(200) NOT NULL
);

CREATE TABLE Vivienda(
id_vivienda INT PRIMARY KEY,
id_tipo_vivienda INT NOT NULL, 
id_agencia INT NOT NULL,
num_cuartos INT NOT NULL,
num_banos INT NOT NULL,
tamano FLOAT NOT NULL,
num_pisos INT NOT NULL,
accesorios varchar(200) NOT NULL,
CONSTRAINT fk_tipo_vivienda FOREIGN KEY (id_tipo_vivienda) REFERENCES TipoVivienda(id_tipo_vivienda),
CONSTRAINT fk_agencia FOREIGN KEY (id_agencia) REFERENCES Agencia (id_agencia)
);

CREATE TABLE Venta (
id_venta INT PRIMARY KEY,
id_cliente INT NOT NULL,
id_vivienda INT NOT NULL,
fecha_venta DATETIME,
precio_venta FLOAT NOT NULL,
CONSTRAINT fk_cliente FOREIGN KEY (id_cliente) REFERENCES Cliente(id_cliente),
CONSTRAINT fk_Vivienda FOREIGN KEY (id_vivienda) REFERENCES Vivienda(id_vivienda),
CONSTRAINT uq_vivienda UNIQUE (id_vivienda)
);

INSERT INTO Agencia (id_agencia, nombre, direccion, telefono) VALUES (1009, 'ITM', 'FRATERNIDAD BOSTON', '6043456728');
GO

INSERT INTO Cliente (id_cliente, nombre, apellido, telefono, correo) VALUES (55, 'Juan', 'Perez', '3245674351', 'jperez@gmail.com');
INSERT INTO Cliente (id_cliente, nombre, apellido, telefono, correo) VALUES (56, 'Camila', 'Argaez', '3235667342', 'camiarg@gmail.com');
GO

INSERT INTO TipoVivienda (id_tipo_vivienda, descripción) VALUES (1, 'Casa familiar amplia');
INSERT INTO TipoVivienda (id_tipo_vivienda, descripción) VALUES (2, 'Casa finca');
INSERT INTO TipoVivienda (id_tipo_vivienda, descripción) VALUES (3, 'Apartamento');
GO

INSERT INTO Vivienda (id_vivienda, id_tipo_vivienda, id_agencia, num_cuartos, num_banos, tamano, num_pisos, accesorios) VALUES (1, 1, 1009, 3, 1, 80.5, 1, 'Patio');
INSERT INTO Vivienda (id_vivienda, id_tipo_vivienda, id_agencia, num_cuartos, num_banos, tamano, num_pisos, accesorios) VALUES (2, 2, 1009, 4, 2, 92.5, 2, 'Balcon');
GO

INSERT INTO Venta (id_venta,id_cliente,id_vivienda,fecha_venta,precio_venta) VALUES (1, 55, 1, 2025-02-28, 43589765.98);
INSERT INTO Venta (id_venta,id_cliente,id_vivienda,fecha_venta,precio_venta) VALUES (2, 56, 2, 2025-01-13, 88589765.99);
GO

select * from tipoVivienda;
select * from vivienda;
select * from cliente;
select * from venta;

CREATE DATABASE doble_cinco

USE doble_cinco

CREATE TABLE perfil
(
  id_perfil INT IDENTITY NOT NULL,
  perfil_descripcion VARCHAR(150) NOT NULL,
  CONSTRAINT PK_perfil PRIMARY KEY (id_perfil)
);

CREATE TABLE estado
(
  estado_descripcion VARCHAR(100) NOT NULL,
  id_estado INT NOT NULL,
  CONSTRAINT PK_estado PRIMARY KEY (id_estado)
);


CREATE TABLE categoria
(
  id_categoria INT IDENTITY NOT NULL,
  nombre_categoria VARCHAR(255) NOT NULL,
  CONSTRAINT PK_categoria PRIMARY KEY (id_categoria)
);

CREATE TABLE forma_de_pago
(
  id_forma_de_pago INT IDENTITY NOT NULL,
  forma_descripcion INT NOT NULL,
  CONSTRAINT PK_forma_de_pago PRIMARY KEY (id_forma_de_pago)
);


CREATE TABLE usuario
(
  id_usuario INT IDENTITY NOT NULL,
  nombre_usuario VARCHAR(50) NOT NULL,
  apellido_usuario VARCHAR(40) NOT NULL,
  correo_usuario VARCHAR(50) NOT NULL,
  telefono_usuario VARCHAR(20) NOT NULL,
  dni_usuario INT NOT NULL,
  contraseña_usuario VARCHAR(255) NOT NULL,
  id_perfil INT NOT NULL,
  id_estado INT NOT NULL,
  direccion_usuario VARCHAR(255) NOT NULL
  CONSTRAINT PK_usuario PRIMARY KEY (id_usuario),
  CONSTRAINT FK_usuario_perfil FOREIGN KEY (id_perfil) REFERENCES Perfil(id_perfil),
  CONSTRAINT FK_usuario_estado FOREIGN KEY (id_estado) REFERENCES Estado(id_estado),
  CONSTRAINT UQ_correo UNIQUE (correo_usuario),
  CONSTRAINT UQ_dni UNIQUE (dni_usuario)
);

ALTER TABLE usuario
ADD CONSTRAINT CK_usuario_dni CHECK (dni_usuario > 0);

ALTER TABLE usuario
ADD fecha_nacimiento_usuario DATETIME NOT NULL;

CREATE TABLE producto
(
  id_producto INT IDENTITY NOT NULL,
  descripcion_producto VARCHAR(80) NOT NULL,
  nombre_producto VARCHAR(60) NOT NULL,
  precio_producto FLOAT NOT NULL,
  cantidad_producto INT NOT NULL,
  imagen_producto VARCHAR(255) NOT NULL,
  id_estado INT NOT NULL,
  id_categoria INT NOT NULL,
  CONSTRAINT PK_producto PRIMARY KEY (id_producto),
  CONSTRAINT FK_producto_estado FOREIGN KEY (id_estado) REFERENCES Estado(id_estado),
  CONSTRAINT FK_producto_categoria FOREIGN KEY (id_categoria) REFERENCES Categoria(id_categoria)
);

ALTER TABLE producto
ADD CONSTRAINT CK_producto_precio CHECK (precio_producto >= 0),
	CONSTRAINT CK_producto_cantidad CHECK (cantidad_producto >= 0);

CREATE TABLE venta
(
  id_venta INT IDENTITY NOT NULL,
  id_usuarios INT NOT NULL,
  id_forma INT NOT NULL,
  CONSTRAINT PK_venta PRIMARY KEY (id_venta),
  CONSTRAINT FK_venta_usuario FOREIGN KEY (id_usuarios) REFERENCES Usuario(id_usuario),
  CONSTRAINT FK_venta_forma_de_pago FOREIGN KEY (id_forma) REFERENCES Forma_de_pago(id_forma_de_pago)
);

ALTER TABLE venta
ADD venta_fecha DATETIME DEFAULT GETDATE();


CREATE TABLE detalle_ventas
(
  id_detalle INT IDENTITY NOT NULL,
  detalle_cantidad INT NOT NULL,
  detalle_precio FLOAT NOT NULL,
  id_producto INT NOT NULL,
  id_ventas INT NOT NULL,
  CONSTRAINT PK_detalle_ventas PRIMARY KEY (id_detalle),
  CONSTRAINT FK_detalle_vts_producto FOREIGN KEY (id_producto) REFERENCES Producto(id_producto),
  CONSTRAINT FK_detalle_vts_ventas FOREIGN KEY (id_ventas) REFERENCES Venta(id_venta)
);

ALTER TABLE detalle_ventas
ADD CONSTRAINT CK_detalle_ventas_cantidad CHECK (detalle_cantidad > 0),
	CONSTRAINT CK_detalle_ventas_precio CHECK (detalle_precio >= 0);


-- Agregamos perfiles

INSERT INTO perfil VALUES ('Gerente');

INSERT INTO perfil VALUES ('Administrador');

INSERT INTO perfil VALUES ('Vendedor');


-- Agregamos estados

INSERT INTO estado(id_estado, estado_descripcion) VALUES ('0', 'INACTIVO');

INSERT INTO estado(id_estado, estado_descripcion) VALUES ('1', 'ACTIVO');


-- Agregamos usuarios

INSERT INTO usuario VALUES ('Benjamin', 'Castillo', 'benja@gmail.com', '3794638461', '45645652', 'hola123', '1', '1', 'Junin 1500', '20040502'); -- Usuario tipo "Gerente"

INSERT INTO usuario VALUES ('Andres', 'Barberan', 'andresbarberan@gmail.com', '3794123456', '1234', '1234', '2', '1', 'Paraguay 300', '20040502'); -- Usuario tipo "Administrador"

INSERT INTO usuario VALUES ('Juan', ' Gomez', 'jg@gmail.com', '3894123456', '123456', '123456', '3', '1', 'Paraguay 301', '20040502'); -- Usuario tipo "Vendedor"


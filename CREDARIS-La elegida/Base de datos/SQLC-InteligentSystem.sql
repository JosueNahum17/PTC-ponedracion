CREATE DATABASE Test_Apha01;
GO
USE Test_Apha01;
GO

-- Roles
CREATE TABLE Roles (
    idRol INT IDENTITY(1,1) PRIMARY KEY,
    nombreRol VARCHAR(25) NOT NULL UNIQUE
);
GO
-- Metodos de pago
CREATE TABLE MetodosPagos (
    idMetodoPago INT IDENTITY(1,1) PRIMARY KEY,
    nombreMetodo VARCHAR(50) NOT NULL UNIQUE
);
GO

-- Usuarios
CREATE TABLE Usuarios (
    idUsuario INT IDENTITY(1,1) PRIMARY KEY,
    idRol INT NOT NULL,
    nombreUsuario NVARCHAR(100) NOT NULL,
    apellidoUsuario NVARCHAR(100) NOT NULL,
    usuario NVARCHAR(15) NOT NULL UNIQUE,
    direccion NVARCHAR(200),
    contrasena NVARCHAR(255) NOT NULL,
    fechaRegistro DATE NOT NULL DEFAULT GETDATE(),
    CONSTRAINT fk_Rol FOREIGN KEY (idRol) REFERENCES Roles(idRol)
);
GO

-- Clientes
CREATE TABLE Clientes (
    idCliente INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    apellido VARCHAR(100) NOT NULL,
    carnet VARCHAR(50) NOT NULL UNIQUE,
    direccion NVARCHAR(200),
    fechaRegistro DATE NOT NULL DEFAULT GETDATE()
);
GO

-- Prestamos
CREATE TABLE Prestamos (
    idPrestamo INT IDENTITY(1,1) PRIMARY KEY,
    idCliente INT NOT NULL,
    montoTotal DECIMAL(12,2) NOT NULL CHECK (montoTotal > 0),
    interes DECIMAL(5,2) NOT NULL CHECK (interes >= 0),
    tiempoMeses INT NOT NULL CHECK (tiempoMeses > 0),
    cuota DECIMAL(12,2) NOT NULL CHECK (cuota >= 0),
    estado VARCHAR(50) NOT NULL CHECK (estado IN ('activo','pagado','mora')),
    fechaInicio DATE NOT NULL,
    fechaRegistro DATE NOT NULL DEFAULT GETDATE(),
    CONSTRAINT fkCliente FOREIGN KEY (idCliente) REFERENCES Clientes(idCliente) ON DELETE CASCADE
);
GO

-- Cuotas
CREATE TABLE Cuotas (
    idCuota INT IDENTITY(1,1) PRIMARY KEY,
    idPrestamo INT NOT NULL,
    fechaVencimiento DATE NOT NULL,
    montoCuota DECIMAL(12,2) NOT NULL,
    montoPagado DECIMAL(12,2) DEFAULT 0,
    estado VARCHAR(50) NOT NULL CHECK (estado IN ('pendiente','pagado','mora')),
    montoMora DECIMAL(12,2) DEFAULT 0,
    CONSTRAINT fk_Prestamo FOREIGN KEY (idPrestamo) REFERENCES Prestamos(idPrestamo) ON DELETE CASCADE
);
GO

-- Pagos
CREATE TABLE Pagos (
    idPago INT IDENTITY(1,1) PRIMARY KEY,
    idPrestamo INT NOT NULL,
    idCuota INT NOT NULL,
    idMetodoPago INT NOT NULL,
    montoPago DECIMAL(12,2) NOT NULL CHECK (montoPago > 0),
    fechaPago DATE NOT NULL DEFAULT GETDATE(),
    CONSTRAINT fkPago_Prestamo FOREIGN KEY (idPrestamo) REFERENCES Prestamos(idPrestamo),
    CONSTRAINT fkPago_Cuota FOREIGN KEY (idCuota) REFERENCES Cuotas(idCuota) ON DELETE CASCADE,
    CONSTRAINT fkPago_Metodo FOREIGN KEY (idMetodoPago) REFERENCES MetodosPagos(idMetodoPago)
);
GO

-- Procedimiento para generar cuotas automáticamente
CREATE PROCEDURE CuotasAutomaticas
    @idPrestamo INT
AS
BEGIN
    DECLARE @tiempoMeses INT, @cuota DECIMAL(12,2), @fechaInicio DATE;
    DECLARE @contador INT = 0;
    DECLARE @fechaVencimientoCalculada DATE;
    DECLARE @diaInicio INT, @anio INT, @mes INT;

    SELECT @tiempoMeses = tiempoMeses, @cuota = cuota, @fechaInicio = fechaInicio
    FROM Prestamos
    WHERE idPrestamo = @idPrestamo;

    SET @diaInicio = DAY(@fechaInicio);

    WHILE @contador < @tiempoMeses
    BEGIN
        SET @contador = @contador + 1;
        SET @fechaVencimientoCalculada = DATEADD(month, @contador, @fechaInicio);

        SET @anio = YEAR(@fechaVencimientoCalculada);
        SET @mes = MONTH(@fechaVencimientoCalculada);

        IF (@diaInicio > DAY(EOMONTH(@fechaVencimientoCalculada)))
            SET @fechaVencimientoCalculada = EOMONTH(@fechaVencimientoCalculada);
        ELSE
            SET @fechaVencimientoCalculada = DATEFROMPARTS(@anio, @mes, @diaInicio);

        INSERT INTO Cuotas (idPrestamo, fechaVencimiento, montoCuota, montoPagado, estado)
        VALUES (@idPrestamo, @fechaVencimientoCalculada, @cuota, 0, 'pendiente');
    END;
END;
GO


-- Inserciones de prueba
-- ======================

-- Roles
INSERT INTO Roles (nombreRol) VALUES
('Administrador'),
('Usuario');

-- Métodos de Pago
INSERT INTO MetodosPagos (nombreMetodo) VALUES
('Cheque'),
('PayPal'),
('Tarjeta de Débito'),
('Transferencia Interbancaria'),
('Criptomoneda');

-- Usuarios
INSERT INTO Usuarios (idRol, nombreUsuario, apellidoUsuario, usuario, direccion, contrasena) VALUES
(1,'Jonathan','Perez','jonathan','San Salvador','pass123'),
(2,'Maria','Castro','mariaca','Santa Ana','pass456'),
(2,'Raul','Gomez','raulg','San Miguel','pass789'),
(1,'Carlos','Martinez','carlosm','Sonsonate','passabc'),
(2,'Ana','Martinez','anam','La Libertad','passdef');

-- Clientes
INSERT INTO Clientes (nombre, apellido, carnet, direccion) VALUES
('Sofia', 'Rodriguez', 'SR001', 'Direccion Ejemplo 1'),
('Daniel', 'Lopez', 'DL002', 'Direccion Ejemplo 2'),
('Laura', 'Perez', 'LP003', 'Direccion Ejemplo 3'),
('Miguel', 'Hernandez', 'MH004', 'Direccion Ejemplo 4'),
('Gabriela', 'Torres', 'GT005', 'Direccion Ejemplo 5');

-- Prestamos
INSERT INTO Prestamos (idCliente, montoTotal, interes, tiempoMeses, cuota, estado, fechaInicio, fechaRegistro) VALUES
(1, 15000, 8, 18, 900, 'activo', '2025-09-01', '2025-09-01'),
(2, 2500, 12, 6, 450, 'activo', '2025-09-02', '2025-09-02'),
(3, 7500, 9, 36, 250, 'activo', '2025-09-03', '2025-09-03'),
(4, 40000, 7, 60, 800, 'activo', '2025-09-04', '2025-09-04'),
(5, 6000, 11, 12, 550, 'activo', '2025-09-05', '2025-09-05');
GO

-- Generar las cuotas para los prestamos creados
EXEC CuotasAutomaticas @idPrestamo = 1;
EXEC CuotasAutomaticas @idPrestamo = 2;
EXEC CuotasAutomaticas @idPrestamo = 3;
EXEC CuotasAutomaticas @idPrestamo = 4;
EXEC CuotasAutomaticas @idPrestamo = 5;
GO

-- Pagos
-- Se insertan pagos de ejemplo una vez que las cuotas han sido generadas
INSERT INTO Pagos (idPrestamo, idCuota, idMetodoPago, montoPago) VALUES
(1, 1, 3, 900), -- Pago de la primera cuota del préstamo 1
(2, 2, 1, 450), -- Pago de la segunda cuota del préstamo 2
(3, 3, 4, 250); -- Pago de la tercera cuota del préstamo 3
GO

-- Vistas y Procedimientos Adicionales
-- ======================

--Credenciales de Usuarios
CREATE VIEW Credenciales AS
SELECT dbo.Roles.nombreRol AS [Cargo],
dbo.Usuarios.nombreUsuario AS [Nombre] ,
dbo.Usuarios.apellidoUsuario AS [Apellido],
dbo.Usuarios.usuario AS [Usuario],
dbo.Usuarios.contrasena AS [Contraseña]
FROM      
dbo.Roles INNER JOIN
dbo.Usuarios ON dbo.Roles.idRol = dbo.Usuarios.idRol
GO

--Iformacion de Pagos
CREATE VIEW InfoPagos AS
SELECT dbo.Pagos.idPrestamo AS ID, dbo.Cuotas.idCuota AS [ID Cuota], dbo.MetodosPagos.nombreMetodo AS [Metodo de pago], dbo.Pagos.montoPago AS Monto, dbo.Pagos.fechaPago AS [Fecha de pago], dbo.Clientes.nombre AS Nombre, 
dbo.Clientes.apellido AS Apellido
FROM dbo.Pagos INNER JOIN
dbo.Cuotas ON dbo.Pagos.idCuota = dbo.Cuotas.idCuota INNER JOIN
dbo.Prestamos ON dbo.Pagos.idPrestamo = dbo.Prestamos.idPrestamo AND dbo.Cuotas.idPrestamo = dbo.Prestamos.idPrestamo INNER JOIN
dbo.MetodosPagos ON dbo.Pagos.idMetodoPago = dbo.MetodosPagos.idMetodoPago INNER JOIN
dbo.Clientes ON dbo.Prestamos.idCliente = dbo.Clientes.idCliente
GO
-- iNFORMACION DE PAGOS

CREATE VIEW InformacionClientes AS
SELECT
    c.nombre,
    c.apellido,
    c.carnet,
    c.direccion,
    p.interes,
    p.tiempoMeses,
    p.montoTotal,
    p.estado
FROM Clientes c
INNER JOIN Prestamos p ON c.idCliente = p.idCliente;
GO

-- Consultas de prueba
-- ======================

SELECT * FROM Usuarios;
GO
SELECT * FROM Clientes;
GO
SELECT * FROM Cuotas;
GO
SELECT * FROM Prestamos;
GO
SELECT * FROM MetodosPagos;
GO
SELECT * FROM Pagos;

GO

-- Vistas
-- ====================
SELECT * FROM InformacionClientes;
GO
SELECT * FROM InfoPagos
GO
SELECT * FROM Credenciales;

-- =====================================
-- PROCEDIMIENTOS DE BÚSQUEDA (cBusqueda)
-- =====================================

-- Buscar Usuarios
CREATE PROCEDURE dbo.SP_BUSCAR_USUARIOS @cBusqueda NVARCHAR(100) = ''
AS
BEGIN
    SELECT 
        u.idUsuario AS ID,
        r.nombreRol AS Rol,
        u.nombreUsuario AS Nombre,
        u.apellidoUsuario AS Apellido,
        u.usuario AS Usuario,
        u.direccion AS Direccion,
        u.fechaRegistro AS FechaRegistro,
		u.contrasena AS contrasena
    FROM Usuarios u
    INNER JOIN Roles r ON u.idRol = r.idRol
    WHERE 
        UPPER(
            ISNULL(u.nombreUsuario,'') + ' ' +
            ISNULL(u.apellidoUsuario,'') + ' ' +
            ISNULL(u.usuario,'') + ' ' +
            ISNULL(r.nombreRol,'')
        ) LIKE '%' + UPPER(@cBusqueda) + '%';
END;
GO

-- Buscar Clientes
CREATE PROC SP_BUSCAR_CLIENTES
    @cBusqueda NVARCHAR(100) = ''
AS
BEGIN
    SELECT 
        c.idCliente AS ID,
        c.nombre,
        c.apellido,
        c.carnet,
        c.direccion,
        p.montoTotal,
        p.interes,
        p.tiempoMeses,
        p.estado
    FROM Clientes c
    INNER JOIN Prestamos p ON c.idCliente = p.idCliente
    WHERE 
        UPPER(c.nombre + ' ' + c.apellido + ' ' + c.carnet + ' ' + CAST(p.idPrestamo AS NVARCHAR)) 
        LIKE '%' + UPPER(@cBusqueda) + '%';
END;
GO

-- Buscar Préstamos
CREATE PROC SP_BUSCAR_PRESTAMOS
    @cBusqueda NVARCHAR(100) = ''
AS
BEGIN
    SELECT 
        p.idPrestamo,
        c.nombre AS NombreCliente,
        c.apellido AS ApellidoCliente,
        p.montoTotal,
        p.interes,
        p.tiempoMeses,
        p.cuota,
        p.estado,
        p.fechaInicio,
        p.fechaRegistro
    FROM Prestamos p
    INNER JOIN Clientes c ON p.idCliente = c.idCliente
    WHERE 
        UPPER(c.nombre + ' ' + c.apellido + ' ' 
              + CAST(p.idPrestamo AS NVARCHAR) + ' ' 
              + CAST(p.montoTotal AS NVARCHAR)) 
        LIKE '%' + UPPER(@cBusqueda) + '%';
END;
GO

-- Buscar Pagos
CREATE PROC SP_BUSCAR_PAGOS
    @cBusqueda NVARCHAR(100) = ''
AS
BEGIN
    SELECT 
        pg.idPago,
        pr.idPrestamo,
        c.nombre AS NombreCliente,
        c.apellido AS ApellidoCliente,
        m.nombreMetodo AS MetodoPago,
        pg.montoPago,
        pg.fechaPago
    FROM Pagos pg
    INNER JOIN Prestamos pr ON pg.idPrestamo = pr.idPrestamo
    INNER JOIN Clientes c ON pr.idCliente = c.idCliente
    INNER JOIN MetodosPagos m ON pg.idMetodoPago = m.idMetodoPago
    WHERE 
        UPPER(c.nombre + ' ' + c.apellido + ' ' 
              + CAST(pr.idPrestamo AS NVARCHAR) + ' ' 
              + CAST(pg.idPago AS NVARCHAR) + ' ' 
              + m.nombreMetodo) 
        LIKE '%' + UPPER(@cBusqueda) + '%';
END;
GO

-- Buscar Cuotas
CREATE PROC SP_BUSCAR_CUOTAS
    @cBusqueda NVARCHAR(100) = ''
AS
BEGIN
    SELECT 
        cu.idCuota,
        cu.idPrestamo,
        c.nombre AS NombreCliente,
        c.apellido AS ApellidoCliente,
        cu.fechaVencimiento,
        cu.montoCuota,
        cu.montoPagado,
        cu.estado,
        cu.montoMora
    FROM Cuotas cu
    INNER JOIN Prestamos p ON cu.idPrestamo = p.idPrestamo
    INNER JOIN Clientes c ON p.idCliente = c.idCliente
    WHERE 
        UPPER(c.nombre + ' ' + c.apellido + ' ' 
              + CAST(cu.idCuota AS NVARCHAR) + ' ' 
              + cu.estado) 
        LIKE '%' + UPPER(@cBusqueda) + '%';
END;
GO

-- Buscar Métodos de Pago
CREATE PROC SP_BUSCAR_METODOS_PAGO
    @cBusqueda NVARCHAR(100) = ''
AS
BEGIN
    SELECT 
        m.idMetodoPago,
        m.nombreMetodo
    FROM MetodosPagos m
    WHERE 
        UPPER(m.nombreMetodo + ' ' + CAST(m.idMetodoPago AS NVARCHAR)) 
        LIKE '%' + UPPER(@cBusqueda) + '%';
END;
GO


-- =====================================
-- EJEMPLOS DE USO
-- =====================================
-- Buscar usuarios
EXEC SP_BUSCAR_USUARIOS 'jonathan';

-- Buscar clientes
EXEC SP_BUSCAR_CLIENTES 'Rodriguez';

-- Buscar préstamos
EXEC SP_BUSCAR_PRESTAMOS '6000';

-- Buscar pagos
EXEC SP_BUSCAR_PAGOS 'Tarjeta';

-- Buscar cuotas
EXEC SP_BUSCAR_CUOTAS 'pendiente';
-- Buscar métodos de pago
EXEC SP_BUSCAR_METODOS_PAGO 'Tarjeta';

EXEC SP_BUSCAR_METODOS_PAGO 'PayPal';
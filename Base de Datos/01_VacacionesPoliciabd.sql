CREATE DATABASE VacacionesPolicia;
GO

USE VacacionesPolicia;

GO

-- CREACIÒN DE LAS TABLAS

CREATE TABLE Rol (
	IdRol INT IDENTITY(1,1) PRIMARY KEY,
	Nombre NVARCHAR(50) NOT NULL UNIQUE
)

CREATE TABLE Rango (
	IdRango INT IDENTITY(1,1) PRIMARY KEY,
	Nombre NVARCHAR(50) NOT NULL UNIQUE
)

CREATE TABLE Cargo (
IdCargo INT IDENTITY(1,1) PRIMARY KEY,
NOMBRE NVARCHAR(80) NOT NULL UNIQUE
)

CREATE TABLE Departamento (
	IdDepartamento INT IDENTITY(1,1) PRIMARY KEY,
	Nombre NVARCHAR(80) NOT NULL UNIQUE
)

CREATE TABLE EstadoSolicitud (
    IdEstado INT PRIMARY KEY,
    Nombre NVARCHAR(30) NOT NULL UNIQUE
)

CREATE TABLE Usuario (
    IdUsuario INT IDENTITY(1,1) PRIMARY KEY,
    IdRol INT NOT NULL,
    NombreUsuario NVARCHAR(50) NOT NULL UNIQUE,
    NombreCompleto NVARCHAR(100) NOT NULL,
    ClaveHash NVARCHAR(64) NOT NULL,
    Activo BIT NOT NULL DEFAULT 1,

    CONSTRAINT FK_Usuario_Rol FOREIGN KEY (IdRol) REFERENCES Rol(IdRol) 
)

CREATE TABLE Personal (
    IdPersonal INT IDENTITY(1,1) PRIMARY KEY,
    Cedula NVARCHAR(13) NOT NULL UNIQUE,
    Nombres NVARCHAR(100) NOT NULL,
    Apellidos NVARCHAR(100) NOT NULL,
    IdRango INT NOT NULL,
    IdDepartamento INT NOT NULL, 
    IdCargo INT NOT NULL,
    FechaIngreso DATE NOT NULL,
    Correo NVARCHAR(100) NULL,
    Activo BIT NOT NULL DEFAULT 1,

    CONSTRAINT FK_Personal_Rango FOREIGN KEY (IdRango) REFERENCES Rango(IdRango),

    CONSTRAINT FK_Personal_Departamento FOREIGN KEY (IdDepartamento) REFERENCES Departamento(IdDepartamento),

    CONSTRAINT FK_Personal_Cargo FOREIGN KEY (IdCargo) REFERENCES Cargo(IdCargo)
)

CREATE TABLE TipoAusencia (
    IdTipo INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(80) NOT NULL UNIQUE,
    Categoria NVARCHAR(20) NOT NULL,
    DiasMaximos INT NOT NULL,
    RequiereDocumento BIT NOT NULL DEFAULT 0,

    CONSTRAINT CK_TipoAusencia_Categoria CHECK (Categoria IN (N'Vacacion', N'Licencia', N'Permiso')),

    CONSTRAINT CK_TipoAusencia_DiasMaximos CHECK (DiasMaximos > 0)
)

CREATE TABLE Solicitud (
    IdSolicitud INT IDENTITY(1,1) PRIMARY KEY,
    IdPersonal INT NOT NULL,
    IdTipo INT NOT NULL,
    FechaInicio DATE NOT NULL,
    FechaFin DATE NOT NULL,
    DiasSolicitados INT NOT NULL,
    Motivo NVARCHAR(300) NULL,
    ReferenciaDocumento NVARCHAR(100) NULL,
    IdEstado INT NOT NULL DEFAULT 1,
    IdUsuarioRegistra INT NOT NULL,

    CONSTRAINT FK_Solicitud_Personal FOREIGN KEY (IdPersonal) REFERENCES Personal(IdPersonal),

    CONSTRAINT FK_Solicitud_TipoAusencia FOREIGN KEY (IdTipo) REFERENCES TipoAusencia(IdTipo),

    CONSTRAINT FK_Solicitud_Estado FOREIGN KEY (IdEstado) REFERENCES EstadoSolicitud(IdEstado),

    CONSTRAINT FK_Solicitud_Usuario FOREIGN KEY (IdUsuarioRegistra) REFERENCES Usuario(IdUsuario),

    CONSTRAINT CK_Solicitud_Fechas CHECK (FechaFin >= FechaInicio),

    CONSTRAINT CK_Solicitud_Dias CHECK (DiasSolicitados > 0)
)

CREATE TABLE HistorialAprobacion (
    IdHistorial INT IDENTITY(1,1) PRIMARY KEY,
    IdSolicitud INT NOT NULL,
    IdUsuario INT NOT NULL,
    Decision NVARCHAR(20) NOT NULL,
    Comentario NVARCHAR(300) NULL,
    Fecha DATETIME NOT NULL DEFAULT GETDATE(),

    CONSTRAINT FK_Historial_Solicitud FOREIGN KEY (IdSolicitud) REFERENCES Solicitud(IdSolicitud),

    CONSTRAINT FK_Historial_Usuario FOREIGN KEY (IdUsuario) REFERENCES Usuario(IdUsuario),

    CONSTRAINT CK_Historial_Decision CHECK (Decision IN (N'Aprobada', N'Rechazada'))
)

CREATE TABLE SaldoVacaciones (
    IdSaldo INT IDENTITY(1,1) PRIMARY KEY,
    IdPersonal INT NOT NULL,
    Anio INT NOT NULL,
    DiasCorrespondientes INT NOT NULL,
    DiasTomados INT NOT NULL DEFAULT 0,

    CONSTRAINT FK_Saldo_Personal FOREIGN KEY (IdPersonal) REFERENCES Personal(IdPersonal),

    CONSTRAINT UQ_Saldo_Personal_Anio UNIQUE (IdPersonal, Anio),

    CONSTRAINT CK_Saldo_DiasCorrespondientes CHECK (DiasCorrespondientes >= 0),

    CONSTRAINT CK_Saldo_DiasTomados CHECK (DiasTomados >= 0),

    CONSTRAINT CK_Saldo_NoExceder CHECK (DiasTomados <= DiasCorrespondientes)
)

CREATE TABLE Ausencia (
    IdAusencia INT IDENTITY(1,1) PRIMARY KEY,
    IdSolicitud INT NOT NULL UNIQUE,
    FechaInicioReal DATE NULL,
    FechaReincorporacionPrevista DATE NOT NULL,
    FechaReincorporacionReal DATE NULL,

    CONSTRAINT FK_Ausencia_Solicitud FOREIGN KEY (IdSolicitud) REFERENCES Solicitud(IdSolicitud)
)

CREATE TABLE Feriado (
    IdFeriado INT IDENTITY(1,1) PRIMARY KEY,
    Fecha DATE NOT NULL UNIQUE,
    Descripcion NVARCHAR(100) NOT NULL
)

CREATE TABLE Bitacora (
    IdBitacora INT IDENTITY(1,1) PRIMARY KEY,
    IdUsuario INT NULL,
    Accion NVARCHAR(100) NOT NULL,
    Detalle NVARCHAR(300) NULL,
    Fecha DATETIME NOT NULL DEFAULT GETDATE(),

    CONSTRAINT FK_Bitacora_Usuario FOREIGN KEY (IdUsuario) REFERENCES Usuario(IdUsuario)
)

-- INDICES

CREATE INDEX IX_Solicitud_Personal_Fechas
    ON Solicitud (IdPersonal, FechaInicio, FechaFin);

CREATE INDEX IX_Solicitud_Estado
    ON Solicitud (IdEstado)

CREATE INDEX IX_Personal_Departamento
    ON Personal (IdDepartamento)

CREATE INDEX IX_Bitacora_Fecha
    ON Bitacora (Fecha)
GO

-- VER TABLAS CREADAS

SELECT COUNT(*) AS CantidadTablas
    FROM INFORMATION_SCHEMA.TABLES
    WHERE TABLE_TYPE = 'BASE TABLE'

--RELACIONES CREADAS
SELECT
    OBJECT_NAME(parent_object_id) AS TablaHija,
    name AS LlaveForanea
FROM sys.foreign_keys
ORDER BY TablaHija;
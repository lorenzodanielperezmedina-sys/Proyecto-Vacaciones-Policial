
USE VacacionesPolicia;
GO

-- ROLES
INSERT INTO Rol (Nombre)
VALUES
    (N'Administrador'),
    (N'Operador RRHH');


-- ESTADOS FIJOS DE LAS SOLICITUDES
INSERT INTO EstadoSolicitud (IdEstado, Nombre)
VALUES
    (1, N'Pendiente'),
    (2, N'Aprobada'),
    (3, N'Rechazada'),
    (4, N'En curso'),
    (5, N'Finalizada');


-- USUARIOS DE PRUEBA
-- admin: Admin123
-- Los demás usuarios: Operador123
INSERT INTO Usuario
    (IdRol, NombreUsuario, NombreCompleto, ClaveHash, Activo)
VALUES
    (2, N'm.perez', N'María Pérez',
     CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'Operador123'), 2), 1),

    (1, N'admin', N'Administrador del sistema',
     CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'Admin123'), 2), 1),

    (2, N'j.santos', N'José Santos',
     CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'Operador123'), 2), 1),

    (2, N'l.diaz', N'Laura Díaz',
     CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'Operador123'), 2), 1),

    (2, N'r.mejia', N'Rafael Mejía',
     CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'Operador123'), 2), 0);


-- RANGOS
INSERT INTO Rango (Nombre)
VALUES
    (N'Raso'),
    (N'Agente'),
    (N'Cabo'),
    (N'Sargento'),
    (N'Teniente'),
    (N'Capitán');


-- DEPARTAMENTOS
INSERT INTO Departamento (Nombre)
VALUES
    (N'Operaciones'),
    (N'Investigaciones'),
    (N'Tránsito'),
    (N'Administración'),
    (N'Recursos Humanos');


-- CARGOS
INSERT INTO Cargo (Nombre)
VALUES
    (N'Agente de patrulla'),
    (N'Investigador'),
    (N'Supervisor'),
    (N'Oficial administrativo'),
    (N'Jefe de unidad');


-- PERSONAL FICTICIO
INSERT INTO Personal
    (Cedula, Nombres, Apellidos, IdRango, IdDepartamento,
     IdCargo, FechaIngreso, Correo, Activo)
VALUES
    (N'001-1234567-8', N'Juan', N'Pérez Medina',
     3, 1, 1, '2018-03-12', N'juan.perez@ejemplo.com', 1),

    (N'001-2345678-9', N'Ana', N'Rosario Núñez',
     2, 2, 2, '2019-05-20', NULL, 1),

    (N'001-3456789-0', N'Luis', N'Martínez Cruz',
     4, 3, 3, '2012-09-01', NULL, 1),

    (N'001-4567890-1', N'Pedro', N'Gómez Rey',
     3, 4, 4, '2016-01-15', NULL, 1),

    (N'001-5678901-2', N'Carla', N'Díaz Polanco',
     1, 1, 1, '2022-07-04', NULL, 1),

    (N'001-6789012-3', N'Miguel', N'Santos Peña',
     5, 3, 5, '2008-11-10', NULL, 1),

    (N'001-7890123-4', N'Rosa', N'Féliz Ortiz',
     2, 2, 2, '2017-02-27', NULL, 0);


-- TIPOS DE AUSENCIA
INSERT INTO TipoAusencia
    (Nombre, Categoria, DiasMaximos, RequiereDocumento)
VALUES
    (N'Vacaciones ordinarias', N'Vacacion', 30, 0),
    (N'Licencia médica', N'Licencia', 90, 1),
    (N'Licencia por maternidad', N'Licencia', 84, 1),
    (N'Licencia por estudios', N'Licencia', 60, 1),
    (N'Permiso por asuntos personales', N'Permiso', 3, 0),
    (N'Permiso por fallecimiento', N'Permiso', 5, 1);


-- FERIADOS FICTICIOS
INSERT INTO Feriado (Fecha, Descripcion)
VALUES
    ('2026-12-25', N'Navidad'),
    ('2027-01-01', N'Año Nuevo'),
    ('2027-01-21', N'Día de la Altagracia');


-- SALDOS DE VACACIONES PARA TODOS LOS MIEMBROS
INSERT INTO SaldoVacaciones
    (IdPersonal, Anio, DiasCorrespondientes, DiasTomados)
SELECT
    IdPersonal, 2026, 30, 0
FROM Personal;

INSERT INTO SaldoVacaciones
    (IdPersonal, Anio, DiasCorrespondientes, DiasTomados)
SELECT
    IdPersonal, 2027, 30, 0
FROM Personal;


-- SOLICITUDES DE PRUEBA
INSERT INTO Solicitud
    (IdPersonal, IdTipo, FechaInicio, FechaFin, DiasSolicitados,
     Motivo, ReferenciaDocumento, IdEstado, IdUsuarioRegistra)
VALUES
    -- Juan: ausencia actualmente en curso
    (1, 1, '2026-11-09', '2026-11-20', 10,
     NULL, NULL, 4, 1),

    -- Juan: solicitud pendiente; al aprobarla baja saldo de 14 a 5
    (1, 1, '2026-12-14', '2026-12-25', 9,
     N'Vacaciones familiares de fin de año.', NULL, 1, 1),

    -- Ana: permiso en curso
    (2, 5, '2026-11-16', '2026-11-17', 2,
     N'Asuntos personales', NULL, 4, 1),

    -- Pedro: vacaciones en curso
    (4, 1, '2026-11-02', '2026-11-17', 12,
     NULL, NULL, 4, 1),

    -- Carla: permiso finalizado
    (5, 5, '2026-11-02', '2026-11-03', 2,
     N'Trámite personal', NULL, 5, 1);


-- HISTORIAL DE LAS SOLICITUDES YA APROBADAS
INSERT INTO HistorialAprobacion
    (IdSolicitud, IdUsuario, Decision, Comentario)
VALUES
    (1, 2, N'Aprobada', N'Aprobada'),
    (3, 2, N'Aprobada', N'Aprobada'),
    (4, 2, N'Aprobada', N'Aprobada'),
    (5, 2, N'Aprobada', N'Aprobada');


-- SALDOS YA UTILIZADOS
UPDATE SaldoVacaciones
SET DiasTomados = 16
WHERE IdPersonal = 1
  AND Anio = 2026;

UPDATE SaldoVacaciones
SET DiasTomados = 12
WHERE IdPersonal = 4
  AND Anio = 2026;


-- AUSENCIAS GENERADAS POR SOLICITUDES APROBADAS
INSERT INTO Ausencia
    (IdSolicitud, FechaInicioReal,
     FechaReincorporacionPrevista, FechaReincorporacionReal)
VALUES
    (1, '2026-11-09', '2026-11-23', NULL),
    (3, '2026-11-16', '2026-11-18', NULL),
    (4, '2026-11-02', '2026-11-18', NULL),
    (5, '2026-11-02', '2026-11-04', '2026-11-04');
GO

SELECT COUNT(*) AS Roles FROM Rol;
SELECT COUNT(*) AS Usuarios FROM Usuario;
SELECT COUNT(*) AS Personal FROM Personal;
SELECT COUNT(*) AS TiposAusencia FROM TipoAusencia;
SELECT COUNT(*) AS Feriados FROM Feriado;
SELECT COUNT(*) AS Saldos FROM SaldoVacaciones;
SELECT COUNT(*) AS Solicitudes FROM Solicitud;
SELECT COUNT(*) AS Historiales FROM HistorialAprobacion;
SELECT COUNT(*) AS Ausencias FROM Ausencia;
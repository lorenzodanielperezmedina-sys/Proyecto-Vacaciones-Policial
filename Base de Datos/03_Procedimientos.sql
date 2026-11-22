USE VacacionesPolicia;
GO
-- VISTA QUE REUNE LA INFORMACION COMPLETA DE CADA AUSENCIA
CREATE VIEW vw_AusenciaDetalle AS
SELECT a.IdAusencia,s.IdSolicitud,p.IdPersonal,p.Cedula,p.Nombres+N' '+p.Apellidos 
	AS Personal,r.Nombre AS Rango,d.IdDepartamento,d.Nombre AS Departamento,t.IdTipo,t.Nombre 
	AS TipoAusencia,t.Categoria,s.IdEstado,e.Nombre 
	AS Estado,s.FechaInicio,s.FechaFin,s.DiasSolicitados,a.FechaReincorporacionPrevista,a.FechaReincorporacionReal
FROM Ausencia a 
INNER JOIN Solicitud s ON s.IdSolicitud=a.IdSolicitud 
INNER JOIN Personal p ON p.IdPersonal=s.IdPersonal 
INNER JOIN Rango r ON r.IdRango=p.IdRango 
INNER JOIN Departamento d ON d.IdDepartamento=p.IdDepartamento
INNER JOIN TipoAusencia t ON t.IdTipo=s.IdTipo 
INNER JOIN EstadoSolicitud e ON e.IdEstado=s.IdEstado;
GO
-- PROCEDIMIENTOS

--AUSENTES CON ESTADO EN CURSO

CREATE PROCEDURE sp_AusentesActuales 
AS 
BEGIN
	SET NOCOUNT ON 
SELECT * FROM vw_AusenciaDetalle WHERE IdEstado=4 
ORDER BY FechaReincorporacionPrevista
END
GO

--PRÓXIMAS REINCORPORACIONES
CREATE PROCEDURE sp_ProximasReincorporaciones 
@Dias INT 
AS
BEGIN
	SET NOCOUNT ON 
DECLARE @Hoy DATE=CAST(GETDATE() AS DATE)
SELECT * FROM vw_AusenciaDetalle WHERE IdEstado=4 AND 
FechaReincorporacionPrevista BETWEEN @Hoy AND DATEADD(DAY,@Dias,@Hoy) 
ORDER BY FechaReincorporacionPrevista
END
GO

-- REPORTE CON FILTROS OPCIONALES

CREATE PROCEDURE sp_ReporteAusencias @Desde DATE,@Hasta DATE,@IdDepartamento INT=NULL,@IdTipo INT=NULL 
AS
BEGIN
SET NOCOUNT ON
SELECT * FROM vw_AusenciaDetalle WHERE FechaInicio<=@Hasta AND FechaFin>=@Desde AND (@IdDepartamento IS NULL 
OR IdDepartamento=@IdDepartamento) AND (@IdTipo IS NULL OR IdTipo=@IdTipo) ORDER BY FechaInicio; END
GO

-- DETALLE DEL PERSONAL PARA EL MANTENIMIENTO

CREATE PROCEDURE sp_PersonalDetalle 
AS
BEGIN
SET NOCOUNT ON
SELECT p.IdPersonal,p.Cedula,p.Nombres,p.Apellidos,p.IdRango,r.Nombre AS Rango,p.IdDepartamento,d.Nombre AS Departamento,
p.IdCargo,c.Nombre AS Cargo,p.FechaIngreso,p.Correo,p.Activo 
FROM Personal p 
INNER JOIN Rango r ON r.IdRango=p.IdRango 
INNER JOIN Departamento d ON d.IdDepartamento=p.IdDepartamento 
INNER JOIN Cargo c ON c.IdCargo=p.IdCargo 
ORDER BY p.Apellidos,p.Nombres
END
GO

-- DETALLE DE USUARIOS PARA LA PANTALLA DE USUARIOS

CREATE PROCEDURE sp_UsuarioDetalle 
AS
BEGIN
SET NOCOUNT ON
SELECT u.IdUsuario,u.NombreUsuario,u.NombreCompleto,u.IdRol,r.Nombre AS Rol,u.Activo,
CASE WHEN u.Activo=1 THEN N'Activo' ELSE N'Inactivo' END AS Estado,(SELECT MAX(b.Fecha) 
FROM Bitacora b WHERE b.IdUsuario=u.IdUsuario AND b.Accion=N'Login exitoso') AS UltimoAcceso 
FROM Usuario u 
INNER JOIN Rol r ON r.IdRol=u.IdRol 
ORDER BY u.NombreUsuario
END
GO

-- SOLICITUDES PENDIENTES PARA LA BANDEJA DE APROBACIÓN

CREATE PROCEDURE sp_SolicitudesPendientes 
AS
BEGIN
SET NOCOUNT ON
SELECT s.IdSolicitud,p.IdPersonal,p.Cedula,p.Nombres+N' '+p.Apellidos AS Personal,r.Nombre AS Rango,t.Nombre AS TipoAusencia,
t.IdTipo,t.Categoria,s.FechaInicio,s.FechaFin,s.DiasSolicitados,s.Motivo,s.ReferenciaDocumento,s.IdEstado,e.Nombre AS Estado 
FROM Solicitud s 
INNER JOIN Personal p ON p.IdPersonal=s.IdPersonal 
INNER JOIN Rango r ON r.IdRango=p.IdRango 
INNER JOIN TipoAusencia t ON t.IdTipo=s.IdTipo 
INNER JOIN EstadoSolicitud e ON e.IdEstado=s.IdEstado WHERE s.IdEstado=1 ORDER BY s.FechaInicio; END
GO

EXEC sp_UsuarioDetalle;
EXEC sp_PersonalDetalle;
EXEC sp_SolicitudesPendientes;
EXEC sp_AusentesActuales;

EXEC sp_ReporteAusencias
    @Desde = '2026-11-01',
    @Hasta = '2026-12-31';
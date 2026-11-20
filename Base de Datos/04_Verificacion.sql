/* Ejecutar despues de 01, 02 y 03. Debe devolver 14 tablas, 7 personal y 5 solicitudes. */
USE VacacionesPolicia;
GO
SELECT COUNT(*) AS TablasCreadas FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE';
SELECT COUNT(*) AS PersonalDePrueba FROM Personal;
SELECT COUNT(*) AS SolicitudesDePrueba FROM Solicitud;
EXEC sp_UsuarioDetalle;
EXEC sp_SolicitudesPendientes;
EXEC sp_PersonalDetalle;
EXEC sp_AusentesActuales;
EXEC sp_ReporteAusencias @Desde='2026-11-01',@Hasta='2026-12-31';
GO

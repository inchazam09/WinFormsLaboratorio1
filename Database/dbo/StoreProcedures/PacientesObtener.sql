CREATE PROCEDURE [dbo].PacientesObtener
@PacientesId INT=NULL

AS
BEGIN
SET NOCOUNT ON

	SELECT
	PacientesId,
	  Nombre,
	Apellidos ,
	Cedula ,
	Nacionalidad ,
	Edad ,
	Direccion ,
	Telefono ,
	Enfermedades ,
	Alergias
	FROM Pacientes
	WHERE (@PacientesId IS NULL OR PacientesId=@PacientesId)

END
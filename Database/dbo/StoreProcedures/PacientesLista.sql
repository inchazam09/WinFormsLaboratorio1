CREATE PROCEDURE dbo.PacientesLista

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
	Enfermedades 

		FROM	
			dbo.Pacientes

			WHERE
					Alergias=1






	END
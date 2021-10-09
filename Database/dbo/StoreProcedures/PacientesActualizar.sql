CREATE PROCEDURE [dbo].[PacientesActualizar]
	@PacientesId INT,
	@Nombre VARCHAR(50),
	@Apellidos VARCHAR(50),
	@Cedula VARCHAR(50),
	@Nacionalidad VARCHAR(50),
	@Edad VARCHAR(50),
	@Direccion VARCHAR(50),
	@Telefono VARCHAR(50),
	@Enfermedades VARCHAR(50),
	@Alergias Bit
    
AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
	-- AQUI VA EL CODIGO
		
	UPDATE dbo.Pacientes SET
	Nombre=@Nombre,
	Apellidos=@Apellidos,
	Cedula=@Cedula,
	Nacionalidad=@Nacionalidad,
	Edad=@Edad,
	Direccion=@Direccion,
	Telefono=@Telefono,
	Enfermedades=@Enfermedades,
	Alergias=@Alergias
	WHERE PacientesId=@PacientesId


		COMMIT TRANSACTION TRASA
		
		SELECT 0 AS CodeError, '' AS MsgError



	END TRY

	BEGIN CATCH
		SELECT 
				ERROR_NUMBER() AS CodeError
			,	ERROR_MESSAGE() AS MsgError

			ROLLBACK TRANSACTION TRASA
	END CATCH

END
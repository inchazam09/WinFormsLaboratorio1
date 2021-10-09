CREATE PROCEDURE dbo.DoctoresActualizar
	@DoctoresId INT,
    @Nombre VARCHAR(250),
	@Apellidos VARCHAR(250),
	@Cedula VARCHAR(250),
	@Especialidad VARCHAR(250),
	@Direccion VARCHAR(250),
	@Telefono VARCHAR(250) 
AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
	-- AQUI VA EL CODIGO
		
	UPDATE dbo.Doctores SET
	 DoctoresId = @DoctoresId,
     Nombre = @Nombre,
	 Apellidos = @Apellidos,
	 Cedula = @Cedula ,
	 Especialidad = @Especialidad,
	 Direccion = @Direccion,
	 Telefono = @Telefono  

	WHERE DoctoresId = @DoctoresId

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

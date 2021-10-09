CREATE PROCEDURE dbo.DoctoresInsertar
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
		
		INSERT INTO dbo.Doctores 
		(
	    DoctoresId ,
		Nombre ,
		Apellidos ,
		Cedula ,
		Especialidad ,
		Direccion,
		Telefono 
		)
		VALUES
		(
		@DoctoresId ,
		@Nombre ,
		@Apellidos ,
		@Cedula ,
		@Especialidad ,
		@Direccion,
		@Telefono 
		)


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
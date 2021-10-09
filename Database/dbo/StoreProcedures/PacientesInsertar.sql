CREATE PROCEDURE [dbo].[PacientesInsertar]
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
  --Aqui va la función
      INSERT INTO dbo.Pacientes 
	  (
	      Nombre,
	Apellidos ,
	Cedula ,
	Nacionalidad ,
	Edad ,
	Direccion ,
	Telefono ,
	Enfermedades ,
	Alergias 
	  )
	  VALUES
	  (
	   @Nombre,
	@Apellidos ,
	@Cedula ,
	@Nacionalidad,
	@Edad,
	@Direccion,
	@Telefono,
	@Enfermedades ,
	@Alergias
	  )
  --
	  COMMIT TRANSACTION TRASA

	  SELECT 0 AS CodeError, '' AS MsgError

 END TRY

 BEGIN CATCH 

 SELECT 
 
    ERROR_NUMBER() AS CodeError
,   ERROR_MESSAGE() AS MsgError

    ROLLBACK TRANSACTION TRASA

 END CATCH

 END

	
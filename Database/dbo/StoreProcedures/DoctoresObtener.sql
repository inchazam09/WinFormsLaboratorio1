CREATE PROCEDURE [dbo].DoctoresObtener
@DoctoresId INT=NULL

AS BEGIN
	SET NOCOUNT ON

	SELECT
		V.DoctoresId ,
		V.Nombre ,
		V.Apellidos ,
		V.Cedula ,
		MV.Especialidad ,
		V.Direccion,
		V.Telefono 
	
				

	FROM dbo.Doctores V
	 INNER JOIN dbo.Doctores MV
         ON V.Especialidad = MV.Especialidad
	WHERE
	     (@DoctoresId IS NULL OR DoctoresId=@DoctoresId)

END
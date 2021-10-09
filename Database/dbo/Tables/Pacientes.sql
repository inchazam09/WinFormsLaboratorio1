CREATE TABLE [dbo].[Pacientes]
(
	  PacientesId INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_PacientesId  PRIMARY KEY CLUSTERED(PacientesId)
	, Nombre VARCHAR(250),
	Apellidos VARCHAR(250), 
	Nacionalidad VARCHAR(250), 
Cedula VARCHAR(250), 
Edad VARCHAR(250), 
Direccion VARCHAR(250)
, Telefono VARCHAR(250)
, Enfermedades VARCHAR(250)
	,Alergias BIT NOT NULL
) WITH (DATA_COMPRESSION=PAGE)
GO
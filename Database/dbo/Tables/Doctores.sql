CREATE TABLE [dbo].Doctores
(
	  DoctoresId INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_DoctoresId  PRIMARY KEY CLUSTERED(DoctoresId)
	, Nombre VARCHAR(250),
	Apellidos VARCHAR(250), 
	Cedula VARCHAR(250), 
	Especialidad VARCHAR(250), 
	Direccion VARCHAR(250)
	, Telefono VARCHAR(250)
	
	) WITH (DATA_COMPRESSION=PAGE)
	GO

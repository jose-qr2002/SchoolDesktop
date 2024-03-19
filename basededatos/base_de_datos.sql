USE [Senati]
/****** Object:  Table [dbo].[Alumno]    Script Date: 18/03/2024 23:06:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alumno](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[dni] [varchar](8) NOT NULL,
	[nombres] [varchar](50) NOT NULL,
	[apellidos] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Curso]    Script Date: 18/03/2024 23:06:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Curso](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [varchar](50) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[ciclo] [varchar](4) NOT NULL,
	[carrera] [varchar](50) NOT NULL,
	[fechaInicio] [date] NOT NULL,
	[fechaFinalizacion] [date] NOT NULL,
 CONSTRAINT [PK_Curso] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Instructor]    Script Date: 18/03/2024 23:06:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Instructor](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[dni] [varchar](8) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[telefono] [varchar](9) NOT NULL,
	[direccion] [varchar](100) NOT NULL,
	[fechaNacimiento] [date] NOT NULL,
	[sexo] [char](1) NOT NULL,
	[especialidad] [varchar](100) NOT NULL,
	[titulo] [varchar](50) NOT NULL,
	[salario] [decimal](10, 2) NOT NULL,
 CONSTRAINT [PK_Instructor] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 18/03/2024 23:06:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [varchar](50) NOT NULL,
	[contrasenia] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Alumno] ON 
GO
INSERT [dbo].[Alumno] ([id], [dni], [nombres], [apellidos]) VALUES (1, N'40689783', N'JUAN', N'PEREZ')
GO
INSERT [dbo].[Alumno] ([id], [dni], [nombres], [apellidos]) VALUES (2, N'73177471', N'Josee', N'Quispe')
GO
SET IDENTITY_INSERT [dbo].[Alumno] OFF
GO
SET IDENTITY_INSERT [dbo].[Curso] ON 
GO
INSERT [dbo].[Curso] ([id], [codigo], [nombre], [ciclo], [carrera], [fechaInicio], [fechaFinalizacion]) VALUES (1, N'CRS-20240318191201914', N'Algoritmia para la Inteligencia', N'X', N'Ing de Software', CAST(N'2024-03-18' AS Date), CAST(N'2024-03-18' AS Date))
GO
INSERT [dbo].[Curso] ([id], [codigo], [nombre], [ciclo], [carrera], [fechaInicio], [fechaFinalizacion]) VALUES (4, N'CRS-20240318191201918', N'Sistemas Operativos', N'IV', N'Ing de Software', CAST(N'2023-06-23' AS Date), CAST(N'2024-03-18' AS Date))
GO
INSERT [dbo].[Curso] ([id], [codigo], [nombre], [ciclo], [carrera], [fechaInicio], [fechaFinalizacion]) VALUES (5, N'CRS-20240318194930912', N'Machine Learning con IA', N'VII', N'Ing de Software', CAST(N'2024-04-01' AS Date), CAST(N'2024-04-19' AS Date))
GO
INSERT [dbo].[Curso] ([id], [codigo], [nombre], [ciclo], [carrera], [fechaInicio], [fechaFinalizacion]) VALUES (6, N'CRS-20240318230045034', N'Calculo |', N'II', N'Ing Matematica', CAST(N'2024-03-09' AS Date), CAST(N'2024-06-20' AS Date))
GO
INSERT [dbo].[Curso] ([id], [codigo], [nombre], [ciclo], [carrera], [fechaInicio], [fechaFinalizacion]) VALUES (7, N'CRS-20240318230124859', N'Calculo ||', N'III', N'Ing Matematica', CAST(N'2024-03-07' AS Date), CAST(N'2024-07-10' AS Date))
GO
INSERT [dbo].[Curso] ([id], [codigo], [nombre], [ciclo], [carrera], [fechaInicio], [fechaFinalizacion]) VALUES (8, N'CRS-20240318230259992', N'Arquitectura de Computadoras', N'II', N'Ciencias de la computacion', CAST(N'2024-03-22' AS Date), CAST(N'2024-07-25' AS Date))
GO
SET IDENTITY_INSERT [dbo].[Curso] OFF
GO
SET IDENTITY_INSERT [dbo].[Instructor] ON 
GO
INSERT [dbo].[Instructor] ([id], [dni], [nombre], [apellido], [telefono], [direccion], [fechaNacimiento], [sexo], [especialidad], [titulo], [salario]) VALUES (1, N'73177471', N'Jose Alfredo', N'Quispe', N'917916696', N'Asociacion Quiñonez Mz X Lt 12', CAST(N'2002-07-05' AS Date), N'M', N'PHP', N'Ing de Software', CAST(1200.20 AS Decimal(10, 2)))
GO
INSERT [dbo].[Instructor] ([id], [dni], [nombre], [apellido], [telefono], [direccion], [fechaNacimiento], [sexo], [especialidad], [titulo], [salario]) VALUES (3, N'76398736', N'Jose Fernando', N'Tapia Quispe', N'928657738', N'Asociacion Quiñonez', CAST(N'2001-06-06' AS Date), N'M', N'Docente', N'Lengua y Literatura', CAST(1500.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Instructor] ([id], [dni], [nombre], [apellido], [telefono], [direccion], [fechaNacimiento], [sexo], [especialidad], [titulo], [salario]) VALUES (4, N'43781456', N'Fernando Paza', N'Perez Peralta', N'942234481', N'Asoc. Nuevo Amanecer Mz X Lt 40', CAST(N'1991-03-06' AS Date), N'M', N'Comunicacion', N'Docente Matematicas', CAST(1300.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Instructor] ([id], [dni], [nombre], [apellido], [telefono], [direccion], [fechaNacimiento], [sexo], [especialidad], [titulo], [salario]) VALUES (5, N'43188749', N'Rosendo', N'Alcides Huapaya', N'912347851', N'Asoc Nueva Alianza Mz 2 Lt 4', CAST(N'1984-06-14' AS Date), N'M', N'Ingles', N'Docente Ingles', CAST(1500.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Instructor] ([id], [dni], [nombre], [apellido], [telefono], [direccion], [fechaNacimiento], [sexo], [especialidad], [titulo], [salario]) VALUES (6, N'75446565', N'Juan', N'Mamani Chambilla', N'943487213', N'Asoc. Nueva Alianza Mz 12 Lt 5', CAST(N'1970-07-23' AS Date), N'M', N'Programacion', N'Docente: Computacion', CAST(1700.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Instructor] ([id], [dni], [nombre], [apellido], [telefono], [direccion], [fechaNacimiento], [sexo], [especialidad], [titulo], [salario]) VALUES (7, N'43487876', N'Francisco Manuel', N'Caceres Mayta', N'913347866', N'Santa Rosa Mz 9 Lt 4', CAST(N'1956-12-06' AS Date), N'M', N'Integrales', N'Educacion: Matematicas', CAST(2000.00 AS Decimal(10, 2)))
GO
SET IDENTITY_INSERT [dbo].[Instructor] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 
GO
INSERT [dbo].[Usuario] ([id], [usuario], [contrasenia]) VALUES (1, N'jorge', N'jorge1')
GO
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [uc_DNI]    Script Date: 18/03/2024 23:06:53 ******/
ALTER TABLE [dbo].[Alumno] ADD  CONSTRAINT [uc_DNI] UNIQUE NONCLUSTERED 
(
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[buscarAlumnoByTipoAndParametro]    Script Date: 18/03/2024 23:06:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[buscarAlumnoByTipoAndParametro] 
(
	@Tipo int,
    @Parametro varchar(50)
)   
AS  
BEGIN  
    
    SET NOCOUNT ON;

	-- DNI
	IF @Tipo = 1  
    BEGIN
		SELECT * FROM Alumno WHERE dni LIKE '%'+@Parametro+'%' ORDER BY id DESC;
	END
    IF @Tipo = 2  
    BEGIN
		SELECT * FROM Alumno WHERE nombres LIKE '%'+@Parametro+'%' ORDER BY id DESC;
	END
	IF @Tipo = 3  
    BEGIN
		SELECT * FROM Alumno WHERE apellidos LIKE '%'+@Parametro+'%' ORDER BY id DESC;
	END

END  
GO
/****** Object:  StoredProcedure [dbo].[buscarCursoByTipoAndParametro]    Script Date: 18/03/2024 23:06:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[buscarCursoByTipoAndParametro] 
(
	@Tipo int,
    @Parametro varchar(50)
)   
AS  
BEGIN  
    
    SET NOCOUNT ON;

	-- CODIGO
	IF @Tipo = 1  
    BEGIN
		SELECT * FROM Curso WHERE codigo LIKE '%'+@Parametro+'%' ORDER BY id DESC;
	END
	-- NOMBRE
    IF @Tipo = 2  
    BEGIN
		SELECT * FROM Curso WHERE nombre LIKE '%'+@Parametro+'%' ORDER BY id DESC;
	END
	-- CARRERA
	IF @Tipo = 3  
    BEGIN
		SELECT * FROM Curso WHERE carrera LIKE '%'+@Parametro+'%' ORDER BY id DESC;
	END

END  
GO
/****** Object:  StoredProcedure [dbo].[buscarInstructorById]    Script Date: 18/03/2024 23:06:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[buscarInstructorById]
    @Id INT
AS
BEGIN
    SELECT * FROM Instructor WHERE id = @Id;
END
GO
/****** Object:  StoredProcedure [dbo].[buscarInstructorByTipoAndParametro]    Script Date: 18/03/2024 23:06:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[buscarInstructorByTipoAndParametro] 
(
	@Tipo int,
    @Parametro varchar(50)
)   
AS  
BEGIN  
    
    SET NOCOUNT ON;

	-- DNI
	IF @Tipo = 1  
    BEGIN
		SELECT id,dni,nombre,apellido,telefono,sexo,salario FROM Instructor WHERE dni LIKE '%'+@Parametro+'%' ORDER BY id DESC;
	END
    IF @Tipo = 2  
    BEGIN
		SELECT id,dni,nombre,apellido,telefono,sexo,salario FROM Instructor WHERE nombre LIKE '%'+@Parametro+'%' ORDER BY id DESC;
	END
	IF @Tipo = 3  
    BEGIN
		SELECT id,dni,nombre,apellido,telefono,sexo,salario FROM Instructor WHERE apellido LIKE '%'+@Parametro+'%' ORDER BY id DESC;
	END

END  
GO
/****** Object:  StoredProcedure [dbo].[editarAlumno]    Script Date: 18/03/2024 23:06:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[editarAlumno] 
	-- Add the parameters for the stored procedure here
	@Id int,
	@Dni varchar(8),
    @Nombres varchar(50),
    @Apellidos varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
	UPDATE Alumno SET dni =@Dni , nombres = @Nombres,apellidos=@Apellidos WHERE id=@Id
END
GO
/****** Object:  StoredProcedure [dbo].[editarCurso]    Script Date: 18/03/2024 23:06:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[editarCurso]
	-- Add the parameters for the stored procedure here
	@Id int,
	@Codigo varchar(50),
    @Nombre varchar(50),
    @Ciclo varchar(4),
	@Carrera varchar(50),
	@FechaInicio date,
	@FechaFinalizacion date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
	UPDATE Curso SET codigo =@Codigo , nombre = @Nombre,ciclo=@Ciclo , carrera=@Carrera , fechaInicio=@FechaInicio , fechaFinalizacion=@FechaFinalizacion WHERE id=@Id
END
GO
/****** Object:  StoredProcedure [dbo].[editarInstructor]    Script Date: 18/03/2024 23:06:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[editarInstructor] 
	-- Add the parameters for the stored procedure here
	@Id int,
	@Dni varchar(8),
    @Nombres varchar(50),
    @Apellidos varchar(50),
	@Telefono varchar(9),
	@Direccion varchar(100),
	@FechaNacimiento date,
	@Sexo char(1),
	@Especialidad varchar(100),
	@Titulo varchar(50),
	@Salario decimal(10,2)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
	UPDATE Instructor SET dni =@Dni , nombre = @Nombres,apellido=@Apellidos , telefono=@Telefono , direccion = @Direccion , fechaNacimiento = @FechaNacimiento , sexo = @Sexo , especialidad = @Especialidad , titulo = @Titulo , salario = @Salario WHERE id=@Id
END
GO
/****** Object:  StoredProcedure [dbo].[eliminarAlumno]    Script Date: 18/03/2024 23:06:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[eliminarAlumno]
	-- Add the parameters for the stored procedure here
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
	DELETE FROM Alumno WHERE id=@Id;
END
GO
/****** Object:  StoredProcedure [dbo].[eliminarCurso]    Script Date: 18/03/2024 23:06:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[eliminarCurso]
	-- Add the parameters for the stored procedure here
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
	DELETE FROM Curso WHERE id=@Id;
END
GO
/****** Object:  StoredProcedure [dbo].[eliminarInstructor]    Script Date: 18/03/2024 23:06:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[eliminarInstructor]
	-- Add the parameters for the stored procedure here
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
	DELETE FROM Instructor WHERE id=@Id;
END
GO
/****** Object:  StoredProcedure [dbo].[insertarAlumno]    Script Date: 18/03/2024 23:06:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--PROCEDIMIENTOS ALMACENADOS
CREATE PROCEDURE [dbo].[insertarAlumno] 
(
    @Dni varchar(8),
    @Nombres varchar(50),
    @Apellidos varchar(50)
)   
AS  
BEGIN  
    
    SET NOCOUNT OFF;

    INSERT INTO Alumno VALUES(@Dni,@Nombres,@Apellidos)

END
GO
/****** Object:  StoredProcedure [dbo].[insertarCurso]    Script Date: 18/03/2024 23:06:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertarCurso] 
(
    @Codigo varchar(50),
    @Nombre varchar(50),
    @Ciclo varchar(4),
	@Carrera varchar(50),
	@FechaInicio date,
	@FechaFinalizacion date
)   
AS  
BEGIN  
    
    SET NOCOUNT OFF;

    INSERT INTO Curso (codigo,nombre,ciclo,carrera,fechaInicio,fechaFinalizacion) VALUES(@Codigo,@Nombre,@Ciclo,@Carrera,@FechaInicio,@FechaFinalizacion)

END
GO
/****** Object:  StoredProcedure [dbo].[insertarInstructor]    Script Date: 18/03/2024 23:06:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
CREATE PROCEDURE [dbo].[insertarInstructor] 
(
    @Dni varchar(8),
    @Nombres varchar(50),
    @Apellidos varchar(50),
	@Telefono varchar(9),
	@Direccion varchar(100),
	@FechaNac date,
	@Sexo char(1),
	@Especialidad varchar(50),
	@Titulo varchar(100),
	@Salario decimal(10,2)
)   
AS  
BEGIN  
    
    SET NOCOUNT OFF;

    INSERT INTO Instructor(dni,nombre,apellido,telefono,direccion,fechaNacimiento,sexo,especialidad,titulo,salario) VALUES(@Dni,@Nombres,@Apellidos,@Telefono,@Direccion,@FechaNac,@Sexo,@Especialidad,@Titulo,@Salario)

END
GO
/****** Object:  StoredProcedure [dbo].[Logeo]    Script Date: 18/03/2024 23:06:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Logeo]
(
    @Usuario varchar(20),
    @Contrasenia varchar(20)
)    
AS  
BEGIN  
    
    SET NOCOUNT ON;

    SELECT *  FROM Usuario WHERE usuario=@Usuario and contrasenia=@Contrasenia

END
GO
/****** Object:  StoredProcedure [dbo].[obtenerTodosAlumnos]    Script Date: 18/03/2024 23:06:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[obtenerTodosAlumnos]    
AS  
BEGIN  
    
    SET NOCOUNT ON;

    SELECT * from Alumno ORDER BY id DESC;

END  
GO
/****** Object:  StoredProcedure [dbo].[obtenerTodosCursos]    Script Date: 18/03/2024 23:06:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[obtenerTodosCursos]    
AS  
BEGIN  
    
    SET NOCOUNT ON;

    SELECT * from Curso ORDER BY id DESC;

END  
GO
/****** Object:  StoredProcedure [dbo].[obtenerTodosInstructores]    Script Date: 18/03/2024 23:06:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[obtenerTodosInstructores]    
AS  
BEGIN  
    
    SET NOCOUNT ON;

    SELECT id,dni,nombre,apellido,telefono,sexo,salario from Instructor ORDER BY id DESC;

END  
GO

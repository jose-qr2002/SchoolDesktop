USE Senati
GO

CREATE TABLE Usuario(  
    id int IDENTITY(1,1) NOT NULL PRIMARY KEY,  
    usuario varchar(50) NOT NULL,  
    contrasenia varchar(50) NOT NULL  
)
GO

CREATE TABLE Alumno(
	id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	dni varchar(8) NOT NULL,
	nombres varchar(50) NOT NULL,
	apellidos varchar(50) NOT NULL,
	CONSTRAINT uc_DNI_ALUMNO UNIQUE (dni)
)
GO

CREATE TABLE Instructor(
	id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	dni varchar(8) NOT NULL,
	nombre varchar(50) NOT NULL,
	apellido varchar(50) NOT NULL,
	telefono varchar(9) NOT NULL,
	direccion varchar(100) NOT NULL,
	fechaNacimiento date NOT NULL,
	sexo char(1) NOT NULL,
	especialidad varchar(100) NOT NULL,
	titulo varchar(50) NOT NULL,
	salario decimal(10, 2) NOT NULL,
	CONSTRAINT uc_DNI_INSTRUCTOR UNIQUE (dni)
)
GO

CREATE TABLE Curso(
	id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	codigo varchar(50) NOT NULL,
	nombre varchar(50) NOT NULL,
	ciclo varchar(4) NOT NULL,
	carrera varchar(50) NOT NULL,
	fechaInicio date NOT NULL,
	fechaFinalizacion date NOT NULL,
)
GO

CREATE TABLE Asignacion (
    id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    id_curso int NOT NULL,
    id_instructor int NOT NULL,
	anio_acad varchar(10) NOT NULL CHECK(anio_acad IN('2024-I','2024-II')),
    CONSTRAINT fk_asignacion_curso FOREIGN KEY (id_curso) REFERENCES Curso(id),
    CONSTRAINT fk_asignacion_instructor FOREIGN KEY (id_instructor) REFERENCES Instructor(id),
    CONSTRAINT uc_Asignacion UNIQUE (id_curso, id_instructor, anio_acad),
)
GO

CREATE TABLE Matricula (
    id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    id_alumno int NOT NULL,
    id_curso int NOT NULL,
	anio_acad varchar(10) NOT NULL CHECK(anio_acad IN('2024-I','2024-II')),
    CONSTRAINT fk_alumno FOREIGN KEY (id_alumno) REFERENCES Alumno(id),
    CONSTRAINT fk_curso FOREIGN KEY (id_curso) REFERENCES Curso(id),
    CONSTRAINT uc_Matricula UNIQUE (id_alumno, id_curso, anio_acad),
)
GO

-- Insertar datos Alumnos
INSERT INTO Alumno VALUES ('40689783', 'Juan', 'Perez')
GO
INSERT INTO Alumno VALUES ('73177471', 'Jose', 'Quispe')
GO
INSERT INTO Alumno VALUES ('75462128', 'Angela', 'Ramos')
GO

-- Insertar datos Curso
INSERT INTO Curso VALUES ('CRS-20240318191201914', 'Algoritmia para la Inteligencia', 'X', 'Ing de Software', '2024-03-18', '2024-03-18')
GO
INSERT INTO Curso VALUES ('CRS-20240318191201918', 'Sistemas Operativos', 'IV', 'Ing de Software', '2023-06-23', '2024-03-18')
GO
INSERT INTO Curso VALUES ('CRS-20240318194930912', 'Machine Learning con IA', 'VII', 'Ing de Software', '2024-04-01', '2024-04-19')
GO
INSERT INTO Curso VALUES ('CRS-20240318230045034', 'Calculo I', 'II', 'Ing Matematica', '2024-03-09', '2024-06-20')
GO
INSERT INTO Curso VALUES ('CRS-20240318230124859', 'Calculo II', 'III', 'Ing Matematica', '2024-03-07', '2024-07-10')
GO
INSERT INTO Curso VALUES ('CRS-20240318230259992', 'Arquitectura de Computadoras', 'II', 'Ciencias de la computacio', '2024-03-22', '2024-07-25')
GO
INSERT INTO Curso VALUES ('CRS-20240318232713031', 'Lenguaje de Programacio', 'IV', 'Ing de Software', '2024-03-09', '2024-04-04')
GO


INSERT INTO Instructor VALUES ('73177471', 'Jose Alfredo', 'Quispe', '917916696', 'Asociacion Quiñonez Mz X Lt 12', '2002-07-05', 'M', 'PHP', 'Ing de Software', 1200.20)
GO
INSERT INTO Instructor VALUES ('76398736', 'Jose Fernando', 'Tapia Quispe', '928657738', 'Asociacion Quiñonez', '2001-06-06', 'M', 'Docente', 'Lengua y Literatura', 1500.00)
GO
INSERT INTO Instructor VALUES ('43781456', 'Fernando Paza', 'Perez Peralta', '942234481', 'Asoc. Nuevo Amanecer Mz X Lt 40', '1991-03-06', 'M', 'Comunicacion', 'Docente Matematicas', 1300.00)
GO
INSERT INTO Instructor VALUES ('43188749', 'Rosendo', 'Alcides Huapaya', '912347851', 'Asoc Nueva Alianza Mz 2 Lt 4', '1984-06-14', 'M', 'Ingles', 'Docente Ingles', 1500.00)
GO
INSERT INTO Instructor VALUES ('75446565', 'Juan', 'Mamani Chambilla', '943487213', 'Asoc. Nueva Alianza Mz 12 Lt 5', '1970-07-23', 'M', 'Programacion', 'Docente: Computacion', 1700.00)
GO
INSERT INTO Instructor VALUES ('43487876', 'Francisco Manuel', 'Caceres Mayta', '913347866', 'Santa Rosa Mz 9 Lt 4', '1956-12-06', 'M', 'Integrales', 'Educacion: Matematicas', 2000.00)
GO
INSERT INTO Instructor VALUES ('73157523', 'Juan Gabriel', 'Huaman Roca', '943157234', 'Asoc Nueva Alianza Mz 4 Lt 6', '1971-08-12', 'M', 'Comunicacion', 'Lengua y Literatura', 2400.00)
GO


INSERT INTO Matricula VALUES (1, 1, '2024-I')
GO
INSERT INTO Matricula VALUES (1, 2, '2024-I')
GO
INSERT INTO Matricula VALUES (2, 4, '2024-I')
GO
INSERT INTO Matricula VALUES (2, 7, '2024-I')
GO
INSERT INTO Matricula VALUES (2, 7, '2024-II')
GO
INSERT INTO Matricula VALUES (2, 6, '2024-I')
GO
INSERT INTO Matricula VALUES (2, 5, '2024-I')
GO


-- Insertar datos Asignaciones
INSERT INTO Asignacion VALUES (1, 1, '2024-I')
GO
INSERT INTO Asignacion VALUES (2, 1, '2024-I')
GO
INSERT INTO Asignacion VALUES (1, 3, '2024-I')
GO
INSERT INTO Asignacion VALUES (1, 2, '2024-I')
GO


INSERT INTO Usuario VALUES ('jorge', 'jorge1')
GO

-- Procedimiento Logueo
CREATE PROCEDURE Logeo
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

-- Procedimientos Alumnos
CREATE PROCEDURE obtenerTodosAlumnos  
AS  
BEGIN  
    
    SET NOCOUNT ON;

    SELECT * from Alumno ORDER BY id DESC;

END  
GO


CREATE PROCEDURE editarAlumno
	@Id int,
	@Dni varchar(8),
    @Nombres varchar(50),
    @Apellidos varchar(50)
AS
BEGIN
	
	SET NOCOUNT OFF;

	UPDATE Alumno SET dni =@Dni , nombres = @Nombres,apellidos=@Apellidos WHERE id=@Id
END
GO


CREATE PROCEDURE eliminarAlumno
	@Id int
AS
BEGIN
	SET NOCOUNT OFF;

	DELETE FROM Alumno WHERE id=@Id;
END
GO

CREATE PROCEDURE insertarAlumno
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

CREATE PROCEDURE buscarAlumnoByTipoAndParametro
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

-- Procedimientos Cursos
CREATE PROCEDURE obtenerTodosCursos  
AS  
BEGIN  
    
    SET NOCOUNT ON;

    SELECT * from Curso ORDER BY id DESC;

END  
GO

CREATE PROCEDURE editarCurso
	@Id int,
	@Codigo varchar(50),
    @Nombre varchar(50),
    @Ciclo varchar(4),
	@Carrera varchar(50),
	@FechaInicio date,
	@FechaFinalizacion date
AS
BEGIN
	SET NOCOUNT OFF;

	UPDATE Curso SET codigo =@Codigo , nombre = @Nombre,ciclo=@Ciclo , carrera=@Carrera , fechaInicio=@FechaInicio , fechaFinalizacion=@FechaFinalizacion WHERE id=@Id
END
GO

CREATE PROCEDURE eliminarCurso
	@Id int
AS
BEGIN
	SET NOCOUNT OFF;

	DELETE FROM Curso WHERE id=@Id;
END
GO

CREATE PROCEDURE insertarCurso
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

CREATE PROCEDURE buscarCursoByTipoAndParametro
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

-- Procedimientos Instructores
CREATE PROCEDURE obtenerTodosInstructores   
AS  
BEGIN  
    
    SET NOCOUNT ON;

    SELECT id,dni,nombre,apellido,telefono,sexo,salario from Instructor ORDER BY id DESC;

END  
GO

CREATE PROCEDURE editarInstructor
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
	SET NOCOUNT OFF;

	UPDATE Instructor SET dni =@Dni , nombre = @Nombres,apellido=@Apellidos , telefono=@Telefono , direccion = @Direccion , fechaNacimiento = @FechaNacimiento , sexo = @Sexo , especialidad = @Especialidad , titulo = @Titulo , salario = @Salario WHERE id=@Id
END
GO

CREATE PROCEDURE eliminarInstructor
	@Id int
AS
BEGIN
	SET NOCOUNT OFF;

	DELETE FROM Instructor WHERE id=@Id;
END
GO


CREATE PROCEDURE insertarInstructor
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

CREATE PROCEDURE buscarInstructorById
    @Id INT
AS
BEGIN
    SELECT * FROM Instructor WHERE id = @Id;
END
GO

CREATE PROCEDURE buscarInstructorByTipoAndParametro
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

-- Procedimientos Matriculas
CREATE PROCEDURE obtenerTodasMatriculas
AS  
BEGIN  
    
    SET NOCOUNT ON;

    SELECT M.id, M.id_alumno AS id_alumno, A.nombres AS Nombres, A.apellidos AS Apellidos, A.dni as DNI, M.id_curso AS id_curso ,C.nombre AS Curso , C.carrera AS Carrera , C.ciclo AS Ciclo ,anio_acad AS "Año Academico"
    FROM Matricula M
    INNER JOIN Alumno A ON A.id = M.id_alumno
	INNER JOIN Curso C ON C.id = M.id_curso


END  
GO

CREATE PROCEDURE insertarMatricula
(
    @IdAlumno int, 
    @IdCurso int,
    @AnioAcademico varchar(10)
)
AS  
BEGIN  
    
    SET NOCOUNT OFF;

    INSERT INTO Matricula (id_alumno, id_curso, anio_acad) VALUES(@IdAlumno, @IdCurso, @AnioAcademico)

END
GO

CREATE PROCEDURE obtenerInstructoreDeMatricula
(
	@IdCurso int,
	@AnioAcademico varchar(10)
)
AS
BEGIN
    
    SET NOCOUNT ON;

    SELECT I.nombre + ' ' + I.apellido AS nombres FROM Asignacion A
	INNER JOIN Instructor I ON I.id = A.id_instructor
	WHERE A.id_curso = @IdCurso AND A.anio_acad = @AnioAcademico;

END  
GO


-- Procedimientos Asignaciones
CREATE PROCEDURE obtenerTodasAsignaciones
AS  
BEGIN  
    
    SET NOCOUNT ON;

    SELECT A.id, A.id_instructor AS id_intructor, I.nombre AS Nombres, I.apellido AS Apellidos, I.dni as DNI, A.id_curso AS id_curso ,C.nombre AS Curso , C.carrera AS Carrera , C.ciclo AS Ciclo ,anio_acad AS "Año Academico"
    FROM Asignacion A
    INNER JOIN Instructor I ON I.id = A.id_instructor
	INNER JOIN Curso C ON C.id = A.id_curso

END
GO

CREATE PROCEDURE insertarAsignacion

    @IdInstructor int, 
    @IdCurso int,
    @AnioAcademico varchar(10)

AS  
BEGIN  
    
    SET NOCOUNT OFF;

    INSERT INTO Asignacion(id_instructor, id_curso, anio_acad) VALUES(@IdInstructor, @IdCurso, @AnioAcademico)

END
GO

CREATE PROCEDURE obtenerAlumnosDeAsignacion
(
	@IdCurso int,
	@AnioAcademico varchar(10)
)
AS
BEGIN
    
    SET NOCOUNT ON;

    SELECT M.id as id, A.dni as Dni, A.nombres AS Nombre, A.apellidos as Apellidos, C.nombre as Curso, M.anio_acad AS "Año academico" FROM Matricula M
	INNER JOIN Alumno A ON A.id = M.id_alumno
	INNER JOIN Curso C ON C.id = M.id_curso
	WHERE M.id_curso = @IdCurso AND M.anio_acad = @AnioAcademico;

END  
GO

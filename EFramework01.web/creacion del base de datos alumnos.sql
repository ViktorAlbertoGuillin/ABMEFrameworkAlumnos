Create database Alumnos;
use Alumnos;

-- Crear la tabla Alumno
CREATE TABLE Alumno (
    Id int IDENTITY(1,1) PRIMARY KEY,
    Nombre varchar(100),
    Edad int,
    Ciudad varchar(100)
);

-- Insertar datos en la tabla Alumno
INSERT INTO Alumno (Nombre, Edad, Ciudad)
VALUES ('Juan Pérez', 20, 'Ciudad de México');

INSERT INTO Alumno (Nombre, Edad, Ciudad)
VALUES ('María García', 22, 'Madrid');

INSERT INTO Alumno (Nombre, Edad, Ciudad)
VALUES ('Carlos López', 21, 'Buenos Aires');

select * from Alumno

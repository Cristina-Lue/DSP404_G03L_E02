CREATE DATABASE hospital

USE hospital;
GO


CREATE TABLE Usuarios (
idUsuario INT PRIMARY KEY IDENTITY (1,1),
Nombre VARCHAR (100) NOT NULL,
Correo VARCHAR (100) NOT NULL UNIQUE, 
Contrasena VARCHAR(255) NOT NULL,
NivelAcceso VARCHAR (50) NOT NULL, 
usuarioinsert VARCHAR (100),
usuariouptade VARCHAR(100),
fechainsert DATETIME DEFAULT GETDATE(), 
fechauptade DATETIME DEFAULT GETDATE()
); 


INSERT INTO Usuarios (Nombre, Correo, Contrasena, NivelAcceso, usuarioinsert)
VALUES 
('Juan Perez', 'juanperez@example.com', 'pass123', 'Admin', 'System'),
('Maria Lopez', 'marialopez@example.com', 'pass456', 'Usuario', 'System'),
('Carlos Gomez', 'carlosgomez@example.com', 'pass789', 'Usuario', 'System'),
('Ana Martinez', 'anamartinez@example.com', 'pass321', 'Admin', 'System'),
('Luis Fernandez', 'luisfernandez@example.com', 'pass654', 'Usuario', 'System'),
('Jose Castillo', 'josecastillo@example.com', 'pass987', 'Usuario', 'System'),
('Laura Ruiz', 'lauraruiz@example.com', 'pass159', 'Admin', 'System'),
('Andrea Soto', 'andreasoto@example.com', 'pass753', 'Usuario', 'System'),
('Oscar Diaz', 'oscardiaz@example.com', 'pass258', 'Admin', 'System'),
('Valeria Campos', 'valeriacampos@example.com', 'pass369', 'Usuario', 'System'),
('Pedro Ortiz', 'pedroortiz@example.com', 'pass741', 'Usuario', 'System'),
('Sofia Navarro', 'sofianavarro@example.com', 'pass852', 'Admin', 'System'),
('Miguel Garcia', 'miguelgarcia@example.com', 'pass963', 'Usuario', 'System'),
('Lucia Herrera', 'luciaherrera@example.com', 'pass159', 'Usuario', 'System'),
('Antonio Perez', 'antonioperez@example.com', 'pass357', 'Usuario', 'System'),
('Gloria Morales', 'gloriamorales@example.com', 'pass951', 'Admin', 'System'),
('Daniel Mendez', 'danielmendez@example.com', 'pass753', 'Usuario', 'System'),
('Carla Rivera', 'carlarivera@example.com', 'pass123', 'Usuario', 'System'),
('Esteban Nuñez', 'estebannunez@example.com', 'pass456', 'Admin', 'System'),
('Rosa Fernandez', 'rosafernandez@example.com', 'pass789', 'Usuario', 'System');

CREATE TABLE Empleados (
idEmpleado INT PRIMARY KEY IDENTITY (1,1),
Nombre VARCHAR (100) NOT NULL, 
Apellidos VARCHAR(150) NOT NULL,
EstadoCivil VARCHAR (50), 
Sexo VARCHAR(50),
FechaNacimiento DATE, 
Direccion VARCHAR (255), 
Telefono VARCHAR (20),
EMAIL VARCHAR (100),
idUsuario INT, 
FOREIGN KEY (idUsuario) REFERENCES  Usuarios(idUsuario),
usuarioinsert VARCHAR (100),
usuarioupdate VARCHAR(100),
fechainsert DATETIME DEFAULT GETDATE(),
fechaupdate DATETIME DEFAULT GETDATE(),

);

INSERT INTO Empleados (Nombre, Apellidos, EstadoCivil, Sexo, FechaNacimiento, Direccion, Telefono, EMAIL, idUsuario, usuarioinsert)
VALUES 
('Pedro Ruiz', 'Lopez', 'Soltero', 'M', '1980-04-23', 'San Salvador', '12345678', 'pedroruiz@example.com', 1, 'System'),
('Sofia Cruz', 'Martinez', 'Casada', 'F', '1992-11-14', 'Santa Ana', '87654321', 'sofiacruz@example.com', 2, 'System'),
('Miguel Torres', 'Lopez', 'Divorciado', 'M', '1985-07-19', 'La Libertad', '23456789', 'migueltorres@example.com', 3, 'System'),
('Diana Reyes', 'Mendez', 'Viudo', 'F', '1990-03-11', 'Chalatenango', '34567890', 'dianareyes@example.com', 4, 'System'),
('Jorge Salazar', 'Hernandez', 'Soltero', 'M', '1978-09-27', 'Usulutan', '45678901', 'jorgesalazar@example.com', 5, 'System'),
('Rosa Garcia', 'Sanchez', 'Casada', 'F', '1981-05-06', 'San Miguel', '56789012', 'rosagarcia@example.com', 6, 'System'),
('Juan Lopez', 'Mendez', 'Soltero', 'M', '1993-12-20', 'Ahuachapan', '67890123', 'juanlopez@example.com', 7, 'System'),
('Camila Herrera', 'Ramirez', 'Soltera', 'F', '1999-01-30', 'Sonsonate', '78901234', 'camilaherrera@example.com', 8, 'System'),
('Alberto Rivera', 'Perez', 'Casado', 'M', '1989-03-10', 'San Vicente', '89012345', 'albertorivera@example.com', 9, 'System'),
('Luis Gomez', 'Hernandez', 'Divorciado', 'M', '1975-07-25', 'La Union', '90123456', 'luisgomez@example.com', 10, 'System'),
('Marta Jimenez', 'Vasquez', 'Viuda', 'F', '1982-09-01', 'Morazan', '23456789', 'martajimenez@example.com', 11, 'System'),
('Raul Salinas', 'Gomez', 'Soltero', 'M', '1996-04-17', 'San Salvador', '34567890', 'raulsalinas@example.com', 12, 'System'),
('Lorena Ayala', 'Castro', 'Casada', 'F', '1994-10-02', 'La Paz', '45678901', 'lorenaayala@example.com', 13, 'System'),
('Oscar Torres', 'Diaz', 'Divorciado', 'M', '1987-06-18', 'Sonsonate', '56789012', 'oscartorres@example.com', 14, 'System'),
('Gloria Paredes', 'Ortiz', 'Soltera', 'F', '1991-05-05', 'Cuscatlan', '67890123', 'gloriaparedes@example.com', 15, 'System'),
('Carlos Cruz', 'Villanueva', 'Viudo', 'M', '1979-12-31', 'San Vicente', '78901234', 'carloscruz@example.com', 16, 'System'),
('Carmen Castillo', 'Hernandez', 'Casada', 'F', '1985-03-16', 'Cabañas', '89012345', 'carmencastillo@example.com', 17, 'System'),
('Enrique Martinez', 'Lara', 'Soltero', 'M', '1998-02-09', 'San Miguel', '90123456', 'enriquemartinez@example.com', 18, 'System'),
('Karen Cabrera', 'Ruiz', 'Casada', 'F', '1983-08-21', 'Ahuachapan', '23456789', 'karencabrera@example.com', 19, 'System'),
('Fernando Jimenez', 'Arroyo', 'Soltero', 'M', '1970-01-12', 'San Salvador', '34567890', 'fernandojimenez@example.com', 20, 'System');






CREATE TABLE Pacientes (
idPaciente INT PRIMARY KEY IDENTITY (1,1),
Nombre VARCHAR (100) NOT NULL, 
Apellidos VARCHAR (150) NOT NULL, 
FechaNacimiento DATE, 
Direccion  VARCHAR (255),
Telefono VARCHAR(20),
Sexo VARCHAR (10), 
EnfermedadPrincipal VARCHAR (255),
idMedico INT, 
FOREIGN KEY (idMedico) REFERENCES Empleados(idEmpleado),
usuarioinsert VARCHAR (100), 
usuarioupdate VARCHAR (100),
fechainsert DATETIME DEFAULT GETDATE(),
fechaupdate DATETIME DEFAULT GETDATE()
);


INSERT INTO Pacientes (Nombre, Apellidos, FechaNacimiento, Direccion, Telefono, Sexo, EnfermedadPrincipal, idMedico, usuarioinsert)
VALUES 
('Isabel Franco', 'Martinez', '1981-01-02', 'Usulutan', '71234567', 'F', 'Hipotiroidismo', 6, 'System'),
('Carlos Mejia', 'Dominguez', '1975-05-23', 'San Salvador', '79876543', 'M', 'Parkinson', 7, 'System'),
('Luisa Fernandez', 'Herrera', '1989-08-17', 'La Libertad', '71239876', 'F', 'Artritis Reumatoide', 8, 'System'),
('Jose Chavez', 'Campos', '1990-10-12', 'Ahuachapan', '78912345', 'M', 'Colitis', 9, 'System'),
('Rosario Lara', 'Lopez', '1984-12-06', 'La Union', '71237654', 'F', 'Obesidad', 10, 'System'),
('Daniela Flores', 'Gomez', '1992-09-23', 'San Vicente', '75123648', 'F', 'Hipertensión', 6, 'System'),
('Emmanuel Solis', 'Vasquez', '1987-07-15', 'Sonsonate', '73456789', 'M', 'Diabetes', 7, 'System'),
('Nancy Martinez', 'Lopez', '2000-06-25', 'Santa Ana', '76543219', 'F', 'Ansiedad', 8, 'System'),
('Miguel Sanchez', 'Rodriguez', '1978-11-11', 'Chalatenango', '71235476', 'M', 'Anemia', 9, 'System'),
('Elena Cruz', 'Ramirez', '1986-04-05', 'San Miguel', '72123459', 'F', 'Gastritis', 10, 'System'),
('Roberto Pineda', 'Perez', '1979-02-02', 'Cabañas', '76512384', 'M', 'Epilepsia', 6, 'System'),
('Adriana Fuentes', 'Martinez', '1983-10-28', 'Cuscatlan', '73214567', 'F', 'Fractura', 7, 'System'),
('Martin Perez', 'Gutierrez', '1988-03-03', 'Morazan', '76512345', 'M', 'Gripe', 8, 'System'),
('Carmen Torres', 'Jimenez', '1991-05-05', 'San Salvador', '75123468', 'F', 'Colesterol', 9, 'System'),
('Gabriel Ortiz', 'Salinas', '1980-12-18', 'La Paz', '72135476', 'M', 'Migraña', 10, 'System'),
('Patricia Romero', 'Hernandez', '1984-09-19', 'Sonsonate', '75234678', 'F', 'Hernia', 6, 'System'),
('Felipe Rivera', 'Martinez', '1993-06-16', 'Santa Ana', '76543127', 'M', 'Asma', 7, 'System'),
('Monica Guzman', 'Mendoza', '1976-08-08', 'La Libertad', '73456712', 'F', 'Diabetes', 8, 'System'),
('Raquel Escobar', 'Cruz', '1994-11-14', 'San Miguel', '76431234', 'F', 'Parkinson', 9, 'System'),
('Rafael Velasquez', 'Quintanilla', '1987-03-20', 'Ahuachapan', '75213678', 'M', 'Epilepsia', 10, 'System');





CREATE TABLE Almacen(
idAlmacen INT PRIMARY KEY IDENTITY(1,1),
Ubicacion VARCHAR(255) NOT NULL,
Capacidad INT,
usuarioinsert VARCHAR (100),
usuarioupdate VARCHAR (100),
fechainsert DATETIME DEFAULT GETDATE(),
fechaupdate DATETIME DEFAULT GETDATE()

);
INSERT INTO Almacen (Ubicacion, Capacidad, usuarioinsert, usuarioupdate, fechainsert, fechaupdate)
VALUES 
('San Salvador', 500, 'System', 'System', GETDATE(), GETDATE()),
('Santa Ana', 300, 'System', 'System', GETDATE(), GETDATE()),
('San Miguel', 450, 'System', 'System', GETDATE(), GETDATE()),
('La Libertad', 250, 'System', 'System', GETDATE(), GETDATE()),
('Sonsonate', 200, 'System', 'System', GETDATE(), GETDATE()),
('Ahuachapan', 350, 'System', 'System', GETDATE(), GETDATE()),
('Chalatenango', 400, 'System', 'System', GETDATE(), GETDATE()),
('Cuscatlan', 300, 'System', 'System', GETDATE(), GETDATE()),
('La Union', 250, 'System', 'System', GETDATE(), GETDATE()),
('Usulutan', 350, 'System', 'System', GETDATE(), GETDATE()),
('Cabañas', 275, 'System', 'System', GETDATE(), GETDATE()),
('Morazan', 225, 'System', 'System', GETDATE(), GETDATE()),
('San Vicente', 325, 'System', 'System', GETDATE(), GETDATE()),
('La Paz', 150, 'System', 'System', GETDATE(), GETDATE()),
('San Francisco Gotera', 180, 'System', 'System', GETDATE(), GETDATE()),
('Ilobasco', 240, 'System', 'System', GETDATE(), GETDATE()),
('Sensuntepeque', 230, 'System', 'System', GETDATE(), GETDATE()),
('Coatepeque', 280, 'System', 'System', GETDATE(), GETDATE()),
('Zacatecoluca', 260, 'System', 'System', GETDATE(), GETDATE()),
('Soyapango', 290, 'System', 'System', GETDATE(), GETDATE());




CREATE TABLE Medicamentos(
    idMedicamentos INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100) NOT NULL,
	idAlmacen INT, 
    Descripcion VARCHAR(255),
    StockActual INT NOT NULL, 
    Precio DECIMAL(10,2),
    FechaVencimiento DATE,
    usuarioinsert VARCHAR(100),
    usuarioupdate VARCHAR(100),
    fechainsert DATETIME DEFAULT GETDATE(),
    fechaupdate DATETIME DEFAULT GETDATE(),
	FOREIGN KEY (idAlmacen) REFERENCES Almacen(idAlmacen)
);
INSERT INTO Medicamentos (Nombre, idAlmacen, Descripcion, StockActual, Precio, FechaVencimiento, usuarioinsert, usuarioupdate, fechainsert, fechaupdate)
VALUES 
('Paracetamol', 1, 'Analgésico y antipirético', 100, 1.50, '2025-12-31', 'admin', 'admin', GETDATE(), GETDATE()),
('Ibuprofeno', 2, 'Antiinflamatorio no esteroideo', 200, 2.00, '2024-11-30', 'admin', 'admin', GETDATE(), GETDATE()),
('Amoxicilina', 3, 'Antibiótico de amplio espectro', 150, 3.00, '2023-10-31', 'admin', 'admin', GETDATE(), GETDATE()),
('Loratadina', 4, 'Antihistamínico', 120, 1.75, '2025-09-30', 'admin', 'admin', GETDATE(), GETDATE()),
('Metformina', 5, 'Antidiabético', 180, 2.50, '2024-08-31', 'admin', 'admin', GETDATE(), GETDATE()),
('Omeprazol', 6, 'Inhibidor de la bomba de protones', 130, 2.25, '2025-07-31', 'admin', 'admin', GETDATE(), GETDATE()),
('Aspirina', 7, 'Analgésico y antiinflamatorio', 170, 1.25, '2023-06-30', 'admin', 'admin', GETDATE(), GETDATE()),
('Clorfenamina', 8, 'Antihistamínico', 110, 1.00, '2024-05-31', 'admin', 'admin', GETDATE(), GETDATE()),
('Diclofenaco', 9, 'Antiinflamatorio no esteroideo', 140, 2.75, '2025-04-30', 'admin', 'admin', GETDATE(), GETDATE()),
('Azitromicina', 10, 'Antibiótico de amplio espectro', 160, 3.50, '2023-03-31', 'admin', 'admin', GETDATE(), GETDATE()),
('Simvastatina', 11, 'Reductor del colesterol', 190, 2.00, '2024-02-28', 'admin', 'admin', GETDATE(), GETDATE()),
('Losartán', 12, 'Antihipertensivo', 150, 2.20, '2025-01-31', 'admin', 'admin', GETDATE(), GETDATE()),
('Furosemida', 13, 'Diurético', 130, 1.80, '2023-12-31', 'admin', 'admin', GETDATE(), GETDATE()),
('Levotiroxina', 14, 'Hormona tiroidea', 140, 2.10, '2024-11-30', 'admin', 'admin', GETDATE(), GETDATE()),
('Prednisona', 15, 'Corticosteroide', 120, 2.30, '2025-10-31', 'admin', 'admin', GETDATE(), GETDATE()),
('Enalapril', 16, 'Antihipertensivo', 110, 1.90, '2023-09-30', 'admin', 'admin', GETDATE(), GETDATE()),
('Ciprofloxacino', 17, 'Antibiótico de amplio espectro', 100, 3.00, '2024-08-31', 'admin', 'admin', GETDATE(), GETDATE()),
('Amlodipino', 18, 'Antihipertensivo', 180, 2.40, '2025-07-31', 'admin', 'admin', GETDATE(), GETDATE()),
('Clopidogrel', 19, 'Anticoagulante', 170, 2.60, '2023-06-30', 'admin', 'admin', GETDATE(), GETDATE()),
('Metronidazol', 20, 'Antibiótico y antiparasitario', 160, 2.80, '2024-05-31', 'admin', 'admin', GETDATE(), GETDATE());




CREATE TABLE Pedidos (
idPedido INT PRIMARY KEY IDENTITY(1,1),
idPaciente INT, 
idMedicamento INT,
Cantidad INT NOT NULL, 
FechaPedido DATE DEFAULT GETDATE(),
FOREIGN KEY (idPaciente) REFERENCES Pacientes(idPaciente),
FOREIGN KEY (idMedicamento) REFERENCES Medicamentos(idMedicamentos),
usuarioinsert VARCHAR (100),
usuarioupdate VARCHAR (100),
fechainsert DATETIME DEFAULT GETDATE(),
fechaupdate DATETIME DEFAULT GETDATE(),
);

INSERT INTO Pedidos (idPaciente,  Cantidad, FechaPedido, usuarioinsert)
VALUES 
(1, 3, '2024-10-01', 'System'),
(2, 5, '2024-10-02', 'System'),
(3,  2, '2024-10-03', 'System'),
(4,  6, '2024-10-04', 'System'),
(5,  1, '2024-10-05', 'System'),
(6,  4, '2024-10-06', 'System'),
(7,  3, '2024-10-07', 'System'),
(8,  7, '2024-10-08', 'System'),
(9, 5, '2024-10-09', 'System'),
(10,  2, '2024-10-10', 'System'),
(11, 6, '2024-10-11', 'System'),
(12,  4, '2024-10-12', 'System'),
(13,  3, '2024-10-13', 'System'),
(14,  7, '2024-10-14', 'System'),
(15,  5, '2024-10-15', 'System'),
(16,  2, '2024-10-16', 'System'),
(17,  6, '2024-10-17', 'System'),
(18,  4, '2024-10-18', 'System'),
(19,  3, '2024-10-19', 'System'),
(20,  7, '2024-10-20', 'System');





select*from Almacen
select*from Empleados
select*from Medicamentos
select*from Pacientes
select*from Pedidos
select*from Usuarios


-- Insertar empleado
CREATE PROCEDURE InsertarEmpleado
    @Nombre VARCHAR(100),
    @Apellidos VARCHAR(150),
    @EstadoCivil VARCHAR(50),
    @Sexo VARCHAR(50),
    @FechaNacimiento DATE,
    @Direccion VARCHAR(255),
    @Telefono VARCHAR(20),
    @Email VARCHAR(100),
    @idUsuario INT
AS
BEGIN
    INSERT INTO Empleados (Nombre, Apellidos, EstadoCivil, Sexo, FechaNacimiento, Direccion, Telefono, Email, idUsuario)
    VALUES (@Nombre, @Apellidos, @EstadoCivil, @Sexo, @FechaNacimiento, @Direccion, @Telefono, @Email, @idUsuario);
END;




-- Modificar empleado
CREATE PROCEDURE ModificarEmpleado
    @idEmpleado INT,
    @Nombre VARCHAR(100),
    @Apellidos VARCHAR(150),
    @EstadoCivil VARCHAR(50),
    @Sexo VARCHAR(50),
    @FechaNacimiento DATE,
    @Direccion VARCHAR(255),
    @Telefono VARCHAR(20),
    @Email VARCHAR(100)
AS
BEGIN
    UPDATE Empleados
    SET Nombre = @Nombre,
        Apellidos = @Apellidos,
        EstadoCivil = @EstadoCivil,
        Sexo = @Sexo,
        FechaNacimiento = @FechaNacimiento,
        Direccion = @Direccion,
        Telefono = @Telefono,
        Email = @Email,
        usuarioupdate = CURRENT_USER,
        fechaupdate = GETDATE()
    WHERE idEmpleado = @idEmpleado;
END;


-- Eliminar empleado
CREATE PROCEDURE EliminarEmpleado
    @idEmpleado INT
AS
BEGIN
    DELETE FROM Empleados WHERE idEmpleado = @idEmpleado;
END;


CREATE PROCEDURE InsertarPaciente
    @Nombre VARCHAR(100),
    @Apellidos VARCHAR(150),
    @FechaNacimiento DATE,
    @Direccion VARCHAR(255),
    @Telefono VARCHAR(20),
    @Sexo VARCHAR(10),
    @EnfermedadPrincipal VARCHAR(255),
    @idMedico INT
AS
BEGIN
    INSERT INTO Pacientes (Nombre, Apellidos, FechaNacimiento, Direccion, Telefono, Sexo, EnfermedadPrincipal, idMedico)
    VALUES (@Nombre, @Apellidos, @FechaNacimiento, @Direccion, @Telefono, @Sexo, @EnfermedadPrincipal, @idMedico);
END;



CREATE PROCEDURE ModificarPaciente
    @idPaciente INT,
    @Nombre VARCHAR(100),
    @Apellidos VARCHAR(150),
    @FechaNacimiento DATE,
    @Direccion VARCHAR(255),
    @Telefono VARCHAR(20),
    @Sexo VARCHAR(10),
    @EnfermedadPrincipal VARCHAR(255)
AS
BEGIN
    UPDATE Pacientes
    SET Nombre = @Nombre,
        Apellidos = @Apellidos,
        FechaNacimiento = @FechaNacimiento,
        Direccion = @Direccion,
        Telefono = @Telefono,
        Sexo = @Sexo,
        EnfermedadPrincipal = @EnfermedadPrincipal,
        usuarioupdate = CURRENT_USER,
        fechaupdate = GETDATE()
    WHERE idPaciente = @idPaciente;
END;





CREATE PROCEDURE EliminarPaciente
    @idPaciente INT
AS
BEGIN
    DELETE FROM Pacientes WHERE idPaciente = @idPaciente;
END;




CREATE PROCEDURE InsertarMedicamento
    @Nombre VARCHAR(100),
    @Descripcion VARCHAR(255),
    @StockActual INT,
    @Precio DECIMAL(10,2),
    @FechaVencimiento DATE,
    @idAlmacen INT
AS
BEGIN
    INSERT INTO Medicamentos (Nombre, Descripcion, StockActual, Precio, FechaVencimiento, idAlmacen)
    VALUES (@Nombre, @Descripcion, @StockActual, @Precio, @FechaVencimiento, @idAlmacen);
END;


CREATE PROCEDURE ModificarMedicamento
    @idMedicamento INT,
    @Nombre VARCHAR(100),
    @Descripcion VARCHAR(255),
    @StockActual INT,
    @Precio DECIMAL(10,2),
    @FechaVencimiento DATE
AS
BEGIN
    UPDATE Medicamentos
    SET Nombre = @Nombre,
        Descripcion = @Descripcion,
        StockActual = @StockActual,
        Precio = @Precio,
        FechaVencimiento = @FechaVencimiento,
        usuarioupdate = CURRENT_USER,
        fechaupdate = GETDATE()
    WHERE idMedicamentos = @idMedicamento;
END;





CREATE PROCEDURE EliminarMedicamento
    @idMedicamento INT
AS
BEGIN
    DELETE FROM Medicamentos WHERE idMedicamentos = @idMedicamento;
END;

 ---- 5 VISTAS-----


CREATE VIEW VistaEmpleadosPacientes AS
SELECT 
    e.Nombre AS NombreEmpleado,
    e.Apellidos AS ApellidoEmpleado,
    p.Nombre AS NombrePaciente,
    p.Apellidos AS ApellidoPaciente,
    p.EnfermedadPrincipal
FROM Empleados e
JOIN Pacientes p ON e.idEmpleado = p.idMedico;
 --medicos tienen pacientes los medicos son los que salen como empleados








 CREATE VIEW VistaMedicamentosDisponibles AS
SELECT 
    m.Nombre AS NombreMedicamento,
    m.Descripcion,
    m.StockActual,
    a.Ubicacion AS UbicacionAlmacen,
    a.Capacidad AS CapacidadAlmacen
FROM Medicamentos m
JOIN Almacen a ON m.idAlmacen = a.idAlmacen
WHERE m.StockActual > 0;
 --Muestra medicamentos actuales con stock..

 EXEC sp_columns Medicamentos;


CREATE VIEW VistaPedidosPacientes AS
SELECT 
    p.Nombre AS NombrePaciente,
    p.Apellidos AS ApellidoPaciente,
    med.Nombre AS NombreMedicamento,
    ped.Cantidad,
    ped.FechaPedido
FROM Pedidos ped
JOIN Pacientes p ON ped.idPaciente = p.idPaciente
JOIN Medicamentos med ON ped.idMedicamento = med.idMedicamentos;
--pacientes pedidos que hacen de medicamentos



CREATE VIEW VistaEmpleadosAcceso AS
SELECT 
    e.Nombre AS NombreEmpleado,
    e.Apellidos AS ApellidoEmpleado,
    u.NivelAcceso AS NivelAcceso
FROM Empleados e
JOIN Usuarios u ON e.idUsuario = u.idUsuario;
--muestran los empleados y que pueden hacer



CREATE VIEW VistaPacientesEnfermedad AS
SELECT 
    EnfermedadPrincipal,
    COUNT(*) AS NumeroPacientes
FROM Pacientes
GROUP BY EnfermedadPrincipal;
--Muestra Pacientes por enfermedad



------5 DISPARADORES----


-- Crear tabla persistente para almacenar los registros eliminados
CREATE TABLE TempMedicamentos (
    idMedicamentos INT,
    Nombre NVARCHAR(100),
    StockActual INT,
    FechaEliminacion DATE
);

-- Crear el trigger para capturar los registros eliminados
CREATE TRIGGER Medicamento_Deleted
ON Medicamentos
AFTER DELETE
AS
BEGIN
    DECLARE @id INT, @Nombre NVARCHAR(100), @Stock INT, @Fecha DATE;
    
    -- Seleccionar los valores eliminados
    SELECT @id = d.idMedicamentos, 
           @Nombre = d.Nombre, 
           @Stock = d.StockActual, 
           @Fecha = GETDATE()
    FROM deleted d;
    
    -- Guardar el registro eliminado en la tabla persistente
    INSERT INTO TempMedicamentos (idMedicamentos, Nombre, StockActual, FechaEliminacion)
    SELECT idMedicamentos, Nombre, StockActual, GETDATE()
    FROM deleted;
    
    -- Imprimir información sobre el medicamento eliminado
    PRINT 'Medicamento eliminado: ' + @Nombre;
END;












CREATE TRIGGER StockActual_Updated
ON Medicamentos
AFTER UPDATE
AS
BEGIN
    DECLARE @id INT, @Nombre NVARCHAR(100), @NuevoStock INT, @Fecha DATE;
    
    SET @Fecha = GETDATE(); -- Fecha de la actualización

    -- Insertar en la tabla Stock_Cambios solo si el stock ha cambiado
    INSERT INTO Stock_Cambios (idMedicamento, Nombre, StockNuevo, FechaActualizacion)
    SELECT i.idMedicamentos, i.Nombre, i.StockActual, @Fecha
    FROM inserted i
    INNER JOIN deleted d ON i.idMedicamentos = d.idMedicamentos
    WHERE i.StockActual != d.StockActual;
    
    -- Imprimir información sobre el cambio de stock para cada medicamento afectado
    DECLARE curMedicamentos CURSOR FOR
    SELECT i.Nombre
    FROM inserted i
    INNER JOIN deleted d ON i.idMedicamentos = d.idMedicamentos
    WHERE i.StockActual != d.StockActual;

    OPEN curMedicamentos;

    FETCH NEXT FROM curMedicamentos INTO @Nombre;
    WHILE @@FETCH_STATUS = 0
    BEGIN
        PRINT 'Stock actualizado para el medicamento: ' + @Nombre;
        FETCH NEXT FROM curMedicamentos INTO @Nombre;
    END;

    CLOSE curMedicamentos;
    DEALLOCATE curMedicamentos;
END;




CREATE TABLE #TempEmpleados (
    idEmpleado INT,
    Nombre VARCHAR(100),
    Apellidos VARCHAR(100),
    FechaEliminacion DATE
);

CREATE TRIGGER Empleado_Deleted
ON Empleados
AFTER DELETE
AS
BEGIN
    DECLARE @id INT, @Nombre VARCHAR(100), @Apellidos VARCHAR(100), @Fecha DATE;
    
    SELECT @id = deleted.idEmpleado, 
           @Nombre = deleted.Nombre, 
           @Apellidos = deleted.Apellidos, 
           @Fecha = GETDATE()
    FROM deleted;
    
    -- Guardar el registro eliminado en la tabla temporal
    INSERT INTO #TempEmpleados (idEmpleado, Nombre, Apellidos, FechaEliminacion)
    SELECT idEmpleado, Nombre, Apellidos, GETDATE()
    FROM deleted;
    
    -- Imprimir información del empleado eliminado
    PRINT 'Empleado eliminado: ' + @Nombre + ' ' + @Apellidos;
END;




CREATE TABLE #TempPacientes (
    idPaciente INT,
    Nombre VARCHAR(100),
    Apellidos VARCHAR(100),
    EnfermedadPrincipal VARCHAR(100),
    Fecha DATE
);



CREATE TRIGGER Paciente_BeforeDelete
ON Pacientes
INSTEAD OF DELETE
AS
BEGIN
    -- Imprimir el registro eliminado
    SELECT * FROM deleted;

    -- Guardar el registro eliminado en la tabla temporal
    INSERT INTO #TempPacientes (idPaciente, Nombre, Apellidos, EnfermedadPrincipal, Fecha)
    SELECT idPaciente, Nombre, Apellidos, EnfermedadPrincipal, GETDATE()
    FROM deleted;
END;


CREATE TABLE TempPacientes (
    idPaciente INT,
    Nombre NVARCHAR(100),
    idMedico INT,
    Fecha DATE
);
CREATE TRIGGER MedicoAsignado_Deleted
ON Pacientes
AFTER DELETE
AS
BEGIN
    -- Imprimir el registro eliminado
    SELECT * FROM deleted;

    -- Guardar el registro eliminado en la tabla persistente
    INSERT INTO TempPacientes (idPaciente, Nombre, idMedico, Fecha)
    SELECT idPaciente, Nombre, idMedico, GETDATE()
    FROM deleted;
END;

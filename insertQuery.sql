
USE DBNeoCare;

INSERT INTO [dbo].[profesion] ([id], [tipo_profesion])
VALUES (1, 'administrativo'),
       (2, 'enfermero'),
       (3, 'medico'),
       (4, 'bioquimico'),
       (5, 'admin');


	   INSERT INTO [dbo].[Paciente] ([dni], [nombre], [apellido], [domicilio], [fecha_nacimiento], [sexo], [obra_social],[condicion], [baja])
VALUES
 
	(12023456, 'Agustina', 'Soto', 'Ruta 345', '1989-04-12', 'Mujer', 'IOSCOR', null, 'n'),
	(12567890, 'Fernando', 'Lopez', 'Callejón 456', '1983-07-25', 'Hombre', 'IOSCOR', null, 'n'),
	(13234567, 'Luciana', 'Garcia', 'Avenida 567', '1995-11-08', 'Mujer', 'IOSCOR', null, 'n'),
	(14234568, 'Ramiro', 'Rojas', 'Boulevard 678', '1987-02-28', 'Hombre', 'IOSCOR', null, 'n'),
	(15234567, 'Maria', 'Lopez', 'Avenida 456', '1985-08-22', 'Mujer', 'OSDE', null, 'n'),
	(16234568, 'Carlos', 'Gonzalez', 'Callejón 789', '1978-12-10', 'Hombre', 'OMINT', null, 'n'),
	(17234569, 'Laura', 'Rodriguez', 'Boulevard 012', '1993-03-05', 'Mujer', 'MEDIFE', null, 'n'),
	(18234570, 'Javier', 'Fernandez', 'Ruta 345', '1980-06-18', 'Hombre', 'SWISS MEDICAL', null, 'n'),
	(19234571, 'Ana', 'Diaz', 'Callejón 678', '1995-09-12', 'Mujer', 'MEDICUS', null, 'n'),
	(20234572, 'Gabriel', 'Alvarez', 'Avenida 901', '1987-02-28', 'Hombre', 'PREVENCION SALUD', null, 'n'),
	(21234573, 'Luisa', 'Martinez', 'Calle 234', '1998-07-14', 'Mujer', 'AVALIAN', null, 'n'),
	(22234574, 'Martín', 'Moreno', 'Boulevard 567', '1982-11-08', 'Hombre', 'GALENO', null, 'n'),
	(23234575, 'Paula', 'Gomez', 'Ruta 890', '1990-04-01', 'Mujer', 'SANCOR SALUD', null, 'n'),
	(24234576, 'Ezequiel', 'Peralta', 'Avenida 123', '1986-07-25', 'Hombre', 'FEDERADA SALUD', null, 'n'),
	(25234577, 'Celeste', 'Rios', 'Calle 234', '1992-10-15', 'Mujer', 'OSDE', null, 'n'),
	(26234578, 'Alejandro', 'Vega', 'Boulevard 345', '1984-01-04', 'Hombre', 'OMINT', null, 'n'),
	(27234579, 'Valentina', 'Flores', 'Ruta 456', '1996-04-18', 'Mujer', 'MEDIFE', null, 'n'),
	(28234580, 'Facundo', 'Santos', 'Callejón 567', '1989-08-22', 'Hombre', 'SWISS MEDICAL', null, 'n'),
	(29234581, 'Isabel', 'Luna', 'Avenida 678', '1994-11-07', 'Mujer', 'MEDICUS', null, 'n'),
	(30234582, 'Diego', 'Castro', 'Boulevard 789', '1988-03-31', 'Hombre', 'PREVENCION SALUD', null, 'n'),
	(31234583, 'Rocio', 'Herrera', 'Ruta 901', '1991-06-15', 'Mujer', 'AVALIAN', null, 'n'),
	(32234584, 'Miguel', 'Romero', 'Calle 012', '1983-10-29', 'Hombre', 'GALENO', null, 'n'),
	(33234585, 'Julieta', 'Mendoza', 'Boulevard 123', '1997-02-14', 'Mujer', 'SANCOR SALUD', null, 'n'),
	(34234586, 'Hernan', 'Silva', 'Avenida 234', '1981-05-08', 'Hombre', 'FEDERADA SALUD', null, 'n');

	INSERT INTO [dbo].[personal_salud] ([matricula], [dni], [nombre], [apellido], [profesion_id], [pass])
VALUES
    --administrativo
	(98765, 1, 'Martín', 'Gómez', 1, '1234'),
    (34567, 18902345, 'Alejandro', 'Díaz', 1, '1234'),
    (90123, 20913456, 'Ignacio', 'Sánchez', 1, '1234'),
	
	--enfermero
    (52321, 2, 'Liliana', 'Meza', 2, '1234'),
    (23216, 22, 'Sofía', 'López', 2, '1234'),
    (85012, 23, 'Valentina', 'Martínez', 2, '1234'),
    (36561, 26767890, 'Tomás', 'Vega', 2, '1234'),
	(67432, 28123456, 'Luciana', 'Moreno', 2, '1234'),
    (88654, 29789012, 'Mariano', 'Vargas', 2, '1234'),
    (29456, 30123456, 'Lucas', 'Suárez', 2, '1234'),
    (80112, 31234567, 'Catalina', 'López', 2, '1234'),
    (81632, 32245678, 'Renata', 'Álvarez', 2, '1234'),
    (32361, 33456789, 'Matías', 'Fernández', 2, '1234'),
	
	--medico
    (43678, 3, 'Walter', 'Marciello', 3, '1234'),
    (54789, 32, 'Camila', 'Rojas', 3, '1234'),
	(75901, 33, 'Elena', 'Gutierrez', 3, '1234'),
    (16212, 37678901, 'Mateo', 'Silva', 3, '1234'),
    (17123, 38901234, 'Carla', 'Martínez', 3, '1234'),

	--bioquimico
    (28344, 4, 'Florencia', 'Castillo', 4, '1234'),
    (19355, 42, 'Gabriel', 'Fernández', 4, '1234'),
    (65890, 41245678, 'Facundo', 'García', 4, '1234'),
	(53389, 42356789, 'Ramiro', 'Gómez', 4, '1234'),

	--admin
    (54143, 5, 'Celeste', 'Ramírez', 5, '1234'),
    (54343, 44901234, 'Gonzalo', 'Rodríguez', 5, '1234'),
    (23451, 45567890, 'Carolina', 'Torres', 5, '1234');

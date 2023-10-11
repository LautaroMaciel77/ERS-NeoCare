

USE DBNeoCare;

INSERT INTO [dbo].[profesion] ([id], [tipo_profesion])
VALUES (1, 'administrativo'),
       (2, 'enfermero'),
       (3, 'medico'),
       (4, 'bioquimico'),
       (5, 'admin');


	   INSERT INTO [dbo].[Paciente] ([dni], [nombre], [apellido], [domicilio], [fecha_nacimiento], [sexo], [obra_social], [historia_clinica_id], [condicion])
VALUES
    (12345678, 'Juan', 'Perez', 'Calle 123', '1990-05-15', 'Masculino', 'ObraSocialA', 1, 'CondicionA'),
    (87654321, 'Maria', 'Gomez', 'Avenida 456', '1985-08-20', 'Femenino', 'ObraSocialB', 2, 'CondicionB'),
    (98765432, 'Carlos', 'Lopez', 'Calle 789', '1978-02-10', 'Masculino', 'ObraSocialC', 3, 'CondicionC');

	INSERT INTO [dbo].[personal_salud] ([matricula], [dni], [nombre], [apellido], [profesion_id], [pass])
VALUES
    (12345, 1, 'Juan', 'Perez', 1, '1234'),
    (54321, 2, 'Maria', 'Gomez', 2, '1234'),
    (98765, 3, 'Carlos', 'Lopez', 3, '1234'),
	(11212, 4, 'Carlos', 'Lopez', 4, '1234'),
	(32, 5, 'Carlos', 'Lopez', 5, '1234');
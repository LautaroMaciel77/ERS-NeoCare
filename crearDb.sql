-- Crear la base de datos si no existe
CREATE DATABASE DBNeoCare;
go
use DBNeoCare



CREATE TABLE [dbo].[profesion] (
    [id]             INT          NOT NULL,
    [tipo_profesion] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    UNIQUE NONCLUSTERED ([id] ASC),
);


CREATE TABLE [dbo].[Paciente] (
	[id]                  INT           IDENTITY (1, 1)      NOT NULL,
    [dni]                 INT           NOT NULL,
    [nombre]              VARCHAR (100) NULL,  
    [apellido]            VARCHAR (100) NULL,  
    [domicilio]           VARCHAR (150) NULL,  
    [fecha_nacimiento]    DATE          NULL,
    [sexo]                VARCHAR (10)  NULL,
    [obra_social]         VARCHAR (100) NULL,  
    [historia_clinica_id] INT           NULL,
    [condicion]           VARCHAR (100) NULL,  
	CONSTRAINT [UQ_Paciente_id] UNIQUE ([id]),
	CONSTRAINT [UQ_Paciente_dni] UNIQUE ([dni]),
    PRIMARY KEY CLUSTERED ([id] ASC),
    UNIQUE NONCLUSTERED ([dni] ASC),
    
);

-- Crear la tabla Personal Salud
CREATE TABLE [dbo].[personal_salud] (
    [id]           INT           IDENTITY (1, 1) NOT NULL,
    [matricula]    INT           NULL,
    [dni]          INT           NOT NULL,
    [nombre]       VARCHAR (100) NOT NULL,  
    [apellido]     VARCHAR (100) NULL,      
    [profesion_id] INT           NULL,
    [pass]         VARCHAR (100) NOT NULL,  
    CONSTRAINT [PK_personal_salud] PRIMARY KEY CLUSTERED ([id] ASC),
	CONSTRAINT [UQ_personal_salud_matricula] UNIQUE ([matricula]),
	CONSTRAINT [UQ_personal_salud_dni] UNIQUE ([dni]),
    CONSTRAINT [FK_personal_profesion] FOREIGN KEY ([profesion_id]) REFERENCES [dbo].[profesion] ([id])
);

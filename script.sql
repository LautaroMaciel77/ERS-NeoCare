USE [master]
GO
/****** Object:  Database [DBNeoCare]    Script Date: 15/11/2023 03:12:49 a. m. ******/
CREATE DATABASE [DBNeoCare]

GO
ALTER DATABASE [DBNeoCare] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBNeoCare].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBNeoCare] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBNeoCare] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBNeoCare] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBNeoCare] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBNeoCare] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBNeoCare] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DBNeoCare] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBNeoCare] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBNeoCare] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBNeoCare] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBNeoCare] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBNeoCare] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBNeoCare] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBNeoCare] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBNeoCare] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DBNeoCare] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBNeoCare] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBNeoCare] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBNeoCare] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBNeoCare] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBNeoCare] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DBNeoCare] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBNeoCare] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DBNeoCare] SET  MULTI_USER 
GO
ALTER DATABASE [DBNeoCare] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBNeoCare] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DBNeoCare] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DBNeoCare] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DBNeoCare] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DBNeoCare] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DBNeoCare] SET QUERY_STORE = ON
GO
ALTER DATABASE [DBNeoCare] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [DBNeoCare]
GO
/****** Object:  Table [dbo].[analisis]    Script Date: 15/11/2023 03:12:49 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[analisis](
	[id_analisis] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [datetime2](7) NULL,
	[observaciones] [text] NULL,
	[id_orden] [int] NULL,
	[id_usuario] [int] NULL,
	[tipo_analisis] [nvarchar](30) NULL,
	[id_archivo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_analisis] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[archivos_estudio]    Script Date: 15/11/2023 03:12:50 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[archivos_estudio](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre_archivo] [varchar](255) NULL,
	[ubicacion] [varchar](255) NULL,
	[id_historia_clinica] [int] NULL,
	[fecha_creacion] [datetime2](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[atencion_enfermeria]    Script Date: 15/11/2023 03:12:50 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[atencion_enfermeria](
	[id_atencion] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [datetime2](7) NULL,
	[observaciones] [text] NULL,
	[indicaciones] [text] NULL,
	[estado] [bit] NULL,
	[id_orden] [int] NULL,
	[id_usuario] [int] NULL,
	[id_medico] [int] NULL,
	[id_paciente] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_atencion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Evaluacion]    Script Date: 15/11/2023 03:12:50 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Evaluacion](
	[id_evaluacion] [int] IDENTITY(1,1) NOT NULL,
	[fecha_creacion] [datetime] NOT NULL,
	[sintomas] [text] NULL,
	[observaciones] [text] NULL,
	[indicaciones] [text] NOT NULL,
	[id_medico] [int] NOT NULL,
	[id_paciente] [int] NOT NULL,
 CONSTRAINT [PK_Evaluacion] PRIMARY KEY CLUSTERED 
(
	[id_evaluacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[historia_clinica]    Script Date: 15/11/2023 03:12:50 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[historia_clinica](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[alergias] [text] NULL,
	[medicamentos] [text] NULL,
	[estudios] [text] NULL,
	[tipo_sangre] [char](3) NULL,
	[id_usuario] [int] NULL,
	[id_paciente] [int] NULL,
	[Familiares] [text] NULL,
	[fecha_inicio] [datetime2](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[historial]    Script Date: 15/11/2023 03:12:50 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[historial](
	[id_historial] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [nvarchar](12) NULL,
	[id] [int] NULL,
	[fecha] [datetime2](7) NULL,
	[id_atencion] [int] NULL,
	[id_paciente] [int] NULL,
	[id_medico] [int] NULL,
	[id_evaluacion] [int] NULL,
	[id_analisis] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_historial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orden]    Script Date: 15/11/2023 03:12:50 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orden](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tipo_orden] [varchar](255) NULL,
	[urgencia] [bit] NULL,
	[Indicaciones] [text] NULL,
	[fecha_creacion] [datetime2](7) NULL,
	[id_personal_salud] [int] NULL,
	[id_paciente] [int] NULL,
	[estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paciente]    Script Date: 15/11/2023 03:12:50 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paciente](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[dni] [int] NOT NULL,
	[nombre] [varchar](100) NULL,
	[apellido] [varchar](100) NULL,
	[domicilio] [varchar](150) NULL,
	[fecha_nacimiento] [date] NULL,
	[sexo] [varchar](10) NULL,
	[obra_social] [varchar](100) NULL,
	[condicion] [varchar](100) NULL,
	[baja] [varchar](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_Paciente_dni] UNIQUE NONCLUSTERED 
(
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_Paciente_id] UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[personal_salud]    Script Date: 15/11/2023 03:12:50 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[personal_salud](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[matricula] [int] NULL,
	[dni] [int] NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[apellido] [varchar](100) NULL,
	[profesion_id] [int] NULL,
	[pass] [varchar](64) NULL,
	[baja] [char](1) NULL,
 CONSTRAINT [PK_personal_salud] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_personal_salud_dni] UNIQUE NONCLUSTERED 
(
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_personal_salud_matricula] UNIQUE NONCLUSTERED 
(
	[matricula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[profesion]    Script Date: 15/11/2023 03:12:50 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[profesion](
	[id] [int] NOT NULL,
	[tipo_profesion] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipo_analisis]    Script Date: 15/11/2023 03:12:50 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipo_analisis](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Turno]    Script Date: 15/11/2023 03:12:50 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Turno](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[selectedDate] [date] NULL,
	[selectedTimeRange] [time](7) NULL,
	[prioridad] [varchar](10) NULL,
	[notasComentarios] [text] NULL,
	[medico_id] [int] NULL,
	[paciente_id] [int] NULL,
	[estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[archivos_estudio] ADD  CONSTRAINT [DF_archivos_estudio_fecha_creacion]  DEFAULT (CONVERT([datetime2],sysdatetime(),(121))) FOR [fecha_creacion]
GO
ALTER TABLE [dbo].[atencion_enfermeria] ADD  DEFAULT ((0)) FOR [estado]
GO
ALTER TABLE [dbo].[Evaluacion] ADD  DEFAULT (getdate()) FOR [fecha_creacion]
GO
ALTER TABLE [dbo].[orden] ADD  DEFAULT (getdate()) FOR [fecha_creacion]
GO
ALTER TABLE [dbo].[orden] ADD  CONSTRAINT [orden_DF_estado]  DEFAULT ((0)) FOR [estado]
GO
ALTER TABLE [dbo].[personal_salud] ADD  DEFAULT ('n') FOR [baja]
GO
ALTER TABLE [dbo].[Turno] ADD  DEFAULT ((0)) FOR [estado]
GO
ALTER TABLE [dbo].[analisis]  WITH CHECK ADD FOREIGN KEY([id_archivo])
REFERENCES [dbo].[archivos_estudio] ([id])
GO
ALTER TABLE [dbo].[analisis]  WITH CHECK ADD FOREIGN KEY([id_orden])
REFERENCES [dbo].[orden] ([id])
GO
ALTER TABLE [dbo].[analisis]  WITH CHECK ADD FOREIGN KEY([id_usuario])
REFERENCES [dbo].[personal_salud] ([id])
GO
ALTER TABLE [dbo].[archivos_estudio]  WITH NOCHECK ADD  CONSTRAINT [archivos_estudio_FK_id_historia_clinica] FOREIGN KEY([id_historia_clinica])
REFERENCES [dbo].[historia_clinica] ([id])
GO
ALTER TABLE [dbo].[archivos_estudio] CHECK CONSTRAINT [archivos_estudio_FK_id_historia_clinica]
GO
ALTER TABLE [dbo].[atencion_enfermeria]  WITH CHECK ADD FOREIGN KEY([id_medico])
REFERENCES [dbo].[personal_salud] ([id])
GO
ALTER TABLE [dbo].[atencion_enfermeria]  WITH CHECK ADD FOREIGN KEY([id_orden])
REFERENCES [dbo].[orden] ([id])
GO
ALTER TABLE [dbo].[atencion_enfermeria]  WITH CHECK ADD FOREIGN KEY([id_paciente])
REFERENCES [dbo].[Paciente] ([id])
GO
ALTER TABLE [dbo].[atencion_enfermeria]  WITH CHECK ADD FOREIGN KEY([id_usuario])
REFERENCES [dbo].[personal_salud] ([id])
GO
ALTER TABLE [dbo].[Evaluacion]  WITH CHECK ADD  CONSTRAINT [FK_Evaluacion_Medico] FOREIGN KEY([id_medico])
REFERENCES [dbo].[personal_salud] ([id])
GO
ALTER TABLE [dbo].[Evaluacion] CHECK CONSTRAINT [FK_Evaluacion_Medico]
GO
ALTER TABLE [dbo].[Evaluacion]  WITH CHECK ADD  CONSTRAINT [FK_Evaluacion_Paciente] FOREIGN KEY([id_paciente])
REFERENCES [dbo].[Paciente] ([id])
GO
ALTER TABLE [dbo].[Evaluacion] CHECK CONSTRAINT [FK_Evaluacion_Paciente]
GO
ALTER TABLE [dbo].[historia_clinica]  WITH NOCHECK ADD  CONSTRAINT [historia_clinica_FK_id_paciente] FOREIGN KEY([id_paciente])
REFERENCES [dbo].[Paciente] ([id])
GO
ALTER TABLE [dbo].[historia_clinica] CHECK CONSTRAINT [historia_clinica_FK_id_paciente]
GO
ALTER TABLE [dbo].[historia_clinica]  WITH NOCHECK ADD  CONSTRAINT [historia_clinica_FK_id_usuario] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[personal_salud] ([id])
GO
ALTER TABLE [dbo].[historia_clinica] CHECK CONSTRAINT [historia_clinica_FK_id_usuario]
GO
ALTER TABLE [dbo].[historial]  WITH CHECK ADD  CONSTRAINT [FK_Historial_Analisis] FOREIGN KEY([id_analisis])
REFERENCES [dbo].[analisis] ([id_analisis])
GO
ALTER TABLE [dbo].[historial] CHECK CONSTRAINT [FK_Historial_Analisis]
GO
ALTER TABLE [dbo].[historial]  WITH CHECK ADD  CONSTRAINT [FK_Historial_AtencionEnfermeria] FOREIGN KEY([id_atencion])
REFERENCES [dbo].[atencion_enfermeria] ([id_atencion])
GO
ALTER TABLE [dbo].[historial] CHECK CONSTRAINT [FK_Historial_AtencionEnfermeria]
GO
ALTER TABLE [dbo].[historial]  WITH CHECK ADD  CONSTRAINT [FK_Historial_Evaluacion] FOREIGN KEY([id_evaluacion])
REFERENCES [dbo].[Evaluacion] ([id_evaluacion])
GO
ALTER TABLE [dbo].[historial] CHECK CONSTRAINT [FK_Historial_Evaluacion]
GO
ALTER TABLE [dbo].[historial]  WITH CHECK ADD  CONSTRAINT [FK_Historial_Paciente] FOREIGN KEY([id_paciente])
REFERENCES [dbo].[Paciente] ([id])
GO
ALTER TABLE [dbo].[historial] CHECK CONSTRAINT [FK_Historial_Paciente]
GO
ALTER TABLE [dbo].[historial]  WITH CHECK ADD  CONSTRAINT [FK_Historial_PersonalSalud] FOREIGN KEY([id_medico])
REFERENCES [dbo].[personal_salud] ([id])
GO
ALTER TABLE [dbo].[historial] CHECK CONSTRAINT [FK_Historial_PersonalSalud]
GO
ALTER TABLE [dbo].[orden]  WITH CHECK ADD FOREIGN KEY([id_paciente])
REFERENCES [dbo].[Paciente] ([id])
GO
ALTER TABLE [dbo].[orden]  WITH CHECK ADD FOREIGN KEY([id_personal_salud])
REFERENCES [dbo].[personal_salud] ([id])
GO
ALTER TABLE [dbo].[personal_salud]  WITH NOCHECK ADD  CONSTRAINT [FK_personal_profesion] FOREIGN KEY([profesion_id])
REFERENCES [dbo].[profesion] ([id])
GO
ALTER TABLE [dbo].[personal_salud] CHECK CONSTRAINT [FK_personal_profesion]
GO
ALTER TABLE [dbo].[Turno]  WITH NOCHECK ADD  CONSTRAINT [turno_fk_medico_id] FOREIGN KEY([medico_id])
REFERENCES [dbo].[personal_salud] ([id])
GO
ALTER TABLE [dbo].[Turno] CHECK CONSTRAINT [turno_fk_medico_id]
GO
ALTER TABLE [dbo].[Turno]  WITH NOCHECK ADD  CONSTRAINT [turno_fk_paciente_id] FOREIGN KEY([paciente_id])
REFERENCES [dbo].[Paciente] ([id])
GO
ALTER TABLE [dbo].[Turno] CHECK CONSTRAINT [turno_fk_paciente_id]
GO
ALTER TABLE [dbo].[historia_clinica]  WITH NOCHECK ADD CHECK  (([tipo_sangre]='O-' OR [tipo_sangre]='O+' OR [tipo_sangre]='AB-' OR [tipo_sangre]='AB+' OR [tipo_sangre]='B-' OR [tipo_sangre]='B+' OR [tipo_sangre]='A-' OR [tipo_sangre]='A+'))
GO
ALTER TABLE [dbo].[Paciente]  WITH NOCHECK ADD CHECK  (([baja]='n' OR [baja]='s'))
GO
ALTER TABLE [dbo].[personal_salud]  WITH NOCHECK ADD CHECK  (([baja]='n' OR [baja]='s'))
GO
ALTER TABLE [dbo].[Turno]  WITH NOCHECK ADD  CONSTRAINT [check_prioridad] CHECK  (([prioridad]='Baja' OR [prioridad]='Normal' OR [prioridad]='Alta'))
GO
ALTER TABLE [dbo].[Turno] CHECK CONSTRAINT [check_prioridad]
GO
USE [master]
GO
ALTER DATABASE [DBNeoCare] SET  READ_WRITE 
GO

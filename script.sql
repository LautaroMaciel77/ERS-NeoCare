USE [master]
GO
/****** Object:  Database [consulta_cliente]    Script Date: 6/10/2023 23:22:58 ******/
CREATE DATABASE [consulta_cliente]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'consulta_cliente', FILENAME = N'E:\sql\MSSQL16.SQLEXPRESS\MSSQL\DATA\consulta_cliente.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'consulta_cliente_log', FILENAME = N'E:\sql\MSSQL16.SQLEXPRESS\MSSQL\DATA\consulta_cliente_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [consulta_cliente] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [consulta_cliente].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [consulta_cliente] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [consulta_cliente] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [consulta_cliente] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [consulta_cliente] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [consulta_cliente] SET ARITHABORT OFF 
GO
ALTER DATABASE [consulta_cliente] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [consulta_cliente] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [consulta_cliente] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [consulta_cliente] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [consulta_cliente] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [consulta_cliente] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [consulta_cliente] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [consulta_cliente] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [consulta_cliente] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [consulta_cliente] SET  ENABLE_BROKER 
GO
ALTER DATABASE [consulta_cliente] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [consulta_cliente] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [consulta_cliente] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [consulta_cliente] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [consulta_cliente] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [consulta_cliente] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [consulta_cliente] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [consulta_cliente] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [consulta_cliente] SET  MULTI_USER 
GO
ALTER DATABASE [consulta_cliente] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [consulta_cliente] SET DB_CHAINING OFF 
GO
ALTER DATABASE [consulta_cliente] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [consulta_cliente] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [consulta_cliente] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [consulta_cliente] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [consulta_cliente] SET QUERY_STORE = ON
GO
ALTER DATABASE [consulta_cliente] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [consulta_cliente]
GO
/****** Object:  Table [dbo].[categoria]    Script Date: 6/10/2023 23:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categoria](
	[id_categoria] [int] IDENTITY(1,1) NOT NULL,
	[fecha_creacion] [datetime] NULL,
	[usuario_creacion] [varchar](255) NULL,
	[categoria] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 6/10/2023 23:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cliente](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[fecha_creacion] [datetime] NULL,
	[nombre] [varchar](1) NULL,
	[fecha_nacimiento] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[consulta]    Script Date: 6/10/2023 23:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[consulta](
	[id_consulta] [int] IDENTITY(1,1) NOT NULL,
	[fecha_creacion] [datetime] NULL,
	[id_cliente] [int] NULL,
	[id_producto] [int] NULL,
	[id_detalles] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_consulta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[departamento]    Script Date: 6/10/2023 23:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[departamento](
	[id_departamento] [int] NOT NULL,
	[fecha_creacion] [datetime] NULL,
	[usuario_creacion] [varchar](255) NULL,
	[departamento] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_departamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalles]    Script Date: 6/10/2023 23:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalles](
	[id_detalles] [int] IDENTITY(1,1) NOT NULL,
	[fecha_creacion] [datetime] NULL,
	[fecha_consulta] [datetime] NULL,
	[usuario_creacion] [varchar](255) NULL,
	[id_categoria] [int] NULL,
	[id_respuesta] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_detalles] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[producto]    Script Date: 6/10/2023 23:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[producto](
	[id_producto] [int] IDENTITY(1,1) NOT NULL,
	[fecha_creacion] [datetime] NULL,
	[nombre_producto] [varchar](255) NULL,
	[usuario_creacion] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[respuesta]    Script Date: 6/10/2023 23:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[respuesta](
	[id_respuesta] [int] IDENTITY(1,1) NOT NULL,
	[fecha_creacion] [datetime] NULL,
	[dni_vendedor] [int] NULL,
	[fecha_respuesta] [date] NULL,
	[usuario_creacion] [varchar](255) NULL,
	[respuesta] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_respuesta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vendedor]    Script Date: 6/10/2023 23:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vendedor](
	[dni] [int] NOT NULL,
	[fecha_creacion] [datetime] NULL,
	[usuario_creacion] [varchar](255) NULL,
	[nombre] [varchar](255) NULL,
	[apellido] [varchar](255) NULL,
	[id_departamento] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[categoria] ADD  DEFAULT (getdate()) FOR [fecha_creacion]
GO
ALTER TABLE [dbo].[cliente] ADD  DEFAULT (getdate()) FOR [fecha_creacion]
GO
ALTER TABLE [dbo].[consulta] ADD  DEFAULT (getdate()) FOR [fecha_creacion]
GO
ALTER TABLE [dbo].[departamento] ADD  DEFAULT (getdate()) FOR [fecha_creacion]
GO
ALTER TABLE [dbo].[detalles] ADD  DEFAULT (getdate()) FOR [fecha_creacion]
GO
ALTER TABLE [dbo].[producto] ADD  DEFAULT (getdate()) FOR [fecha_creacion]
GO
ALTER TABLE [dbo].[respuesta] ADD  DEFAULT (getdate()) FOR [fecha_creacion]
GO
ALTER TABLE [dbo].[vendedor] ADD  DEFAULT (getdate()) FOR [fecha_creacion]
GO
ALTER TABLE [dbo].[consulta]  WITH CHECK ADD  CONSTRAINT [fk_cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[cliente] ([id_cliente])
GO
ALTER TABLE [dbo].[consulta] CHECK CONSTRAINT [fk_cliente]
GO
ALTER TABLE [dbo].[consulta]  WITH CHECK ADD  CONSTRAINT [fk_detalle] FOREIGN KEY([id_detalles])
REFERENCES [dbo].[detalles] ([id_detalles])
GO
ALTER TABLE [dbo].[consulta] CHECK CONSTRAINT [fk_detalle]
GO
ALTER TABLE [dbo].[consulta]  WITH CHECK ADD  CONSTRAINT [fk_producto] FOREIGN KEY([id_producto])
REFERENCES [dbo].[producto] ([id_producto])
GO
ALTER TABLE [dbo].[consulta] CHECK CONSTRAINT [fk_producto]
GO
ALTER TABLE [dbo].[detalles]  WITH CHECK ADD  CONSTRAINT [fk_categoria] FOREIGN KEY([id_categoria])
REFERENCES [dbo].[categoria] ([id_categoria])
GO
ALTER TABLE [dbo].[detalles] CHECK CONSTRAINT [fk_categoria]
GO
ALTER TABLE [dbo].[detalles]  WITH CHECK ADD  CONSTRAINT [fk_respuesta] FOREIGN KEY([id_respuesta])
REFERENCES [dbo].[respuesta] ([id_respuesta])
GO
ALTER TABLE [dbo].[detalles] CHECK CONSTRAINT [fk_respuesta]
GO
ALTER TABLE [dbo].[respuesta]  WITH CHECK ADD  CONSTRAINT [fk_dni_vendedor] FOREIGN KEY([dni_vendedor])
REFERENCES [dbo].[vendedor] ([dni])
GO
ALTER TABLE [dbo].[respuesta] CHECK CONSTRAINT [fk_dni_vendedor]
GO
ALTER TABLE [dbo].[vendedor]  WITH CHECK ADD  CONSTRAINT [fk_departamento] FOREIGN KEY([id_departamento])
REFERENCES [dbo].[departamento] ([id_departamento])
GO
ALTER TABLE [dbo].[vendedor] CHECK CONSTRAINT [fk_departamento]
GO
ALTER TABLE [dbo].[cliente]  WITH CHECK ADD CHECK  (((datepart(year,getdate())-datepart(year,[fecha_nacimiento]))<=(100)))
GO
USE [master]
GO
ALTER DATABASE [consulta_cliente] SET  READ_WRITE 
GO

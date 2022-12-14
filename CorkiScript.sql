USE [master]
GO
/****** Object:  Database [Corki]    Script Date: 14/11/2022 09:59:19 ******/
CREATE DATABASE [Corki]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Corki', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Corki.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Corki_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Corki_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Corki] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Corki].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Corki] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Corki] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Corki] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Corki] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Corki] SET ARITHABORT OFF 
GO
ALTER DATABASE [Corki] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Corki] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Corki] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Corki] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Corki] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Corki] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Corki] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Corki] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Corki] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Corki] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Corki] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Corki] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Corki] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Corki] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Corki] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Corki] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Corki] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Corki] SET RECOVERY FULL 
GO
ALTER DATABASE [Corki] SET  MULTI_USER 
GO
ALTER DATABASE [Corki] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Corki] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Corki] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Corki] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Corki] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Corki', N'ON'
GO
ALTER DATABASE [Corki] SET QUERY_STORE = OFF
GO
USE [Corki]
GO
/****** Object:  User [alumno]    Script Date: 14/11/2022 09:59:19 ******/
CREATE USER [alumno] FOR LOGIN [alumno] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 14/11/2022 09:59:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[IdMateria] [int] IDENTITY(1,1) NOT NULL,
	[NombreMateria] [varchar](50) NULL,
	[Año] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Elecciones]    Script Date: 14/11/2022 09:59:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Elecciones](
	[IdElecciones] [int] IDENTITY(1,1) NOT NULL,
	[ParteAr] [int] NOT NULL,
	[ParteMe] [int] NOT NULL,
	[ParteAb] [int] NOT NULL,
 CONSTRAINT [PK_Elecciones] PRIMARY KEY CLUSTERED 
(
	[IdElecciones] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Partes]    Script Date: 14/11/2022 09:59:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Partes](
	[IdPartes] [int] IDENTITY(1,1) NOT NULL,
	[NombreP] [varchar](50) NOT NULL,
	[Link] [varchar](max) NULL,
 CONSTRAINT [PK_Partes] PRIMARY KEY CLUSTERED 
(
	[IdPartes] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Skins]    Script Date: 14/11/2022 09:59:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Skins](
	[IdDocente] [int] IDENTITY(1,1) NOT NULL,
	[NombreDocente] [varchar](150) NULL,
	[FotoDocente] [varchar](150) NULL,
	[IdMateria] [int] NULL,
	[AntiguedadDocente] [int] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categorias] ON 

INSERT [dbo].[Categorias] ([IdMateria], [NombreMateria], [Año]) VALUES (1, N'Basica', 390)
INSERT [dbo].[Categorias] ([IdMateria], [NombreMateria], [Año]) VALUES (2, N'Unica', 460)
INSERT [dbo].[Categorias] ([IdMateria], [NombreMateria], [Año]) VALUES (3, N'Clasica', 520)
INSERT [dbo].[Categorias] ([IdMateria], [NombreMateria], [Año]) VALUES (4, N'Real', 750)
INSERT [dbo].[Categorias] ([IdMateria], [NombreMateria], [Año]) VALUES (5, N'Imperial', 975)
INSERT [dbo].[Categorias] ([IdMateria], [NombreMateria], [Año]) VALUES (6, N'Epica', 1350)
INSERT [dbo].[Categorias] ([IdMateria], [NombreMateria], [Año]) VALUES (7, N'Legendaria', 1820)
INSERT [dbo].[Categorias] ([IdMateria], [NombreMateria], [Año]) VALUES (8, N'Definitiva', 3250)
SET IDENTITY_INSERT [dbo].[Categorias] OFF
GO
SET IDENTITY_INSERT [dbo].[Partes] ON 

INSERT [dbo].[Partes] ([IdPartes], [NombreP], [Link]) VALUES (1, N'Arriba', N'https://cdn5.dibujos.net/dibujos/pintados/201638/cabeza-humana-el-cuerpo-humano-10808813.jpg')
INSERT [dbo].[Partes] ([IdPartes], [NombreP], [Link]) VALUES (2, N'Arriba', N'https://cdn5.dibujos.net/dibujos/pintados/201531/cabeza-humana-el-cuerpo-humano-10086624.jpg')
INSERT [dbo].[Partes] ([IdPartes], [NombreP], [Link]) VALUES (3, N'Arriba', N'https://cdn5.dibujos.net/dibujos/pintados/201828/cabeza-humana-el-cuerpo-humano-11408152.jpg')
INSERT [dbo].[Partes] ([IdPartes], [NombreP], [Link]) VALUES (4, N'Medio', N'https://static.vecteezy.com/system/resources/previews/003/764/858/non_2x/muscular-male-torso-linear-icon-fitness-bodybuilding-thin-line-illustration-contour-symbol-isolated-outline-drawing-vector.jpg')
INSERT [dbo].[Partes] ([IdPartes], [NombreP], [Link]) VALUES (5, N'Medio', N'https://media.istockphoto.com/vectors/male-torso-line-icon-diet-and-body-man-figure-sign-vector-graphics-a-vector-id1144419689?b=1&k=6&m=1144419689&s=170667a&w=0&h=aBbOfjwTW4RFX_5o1yn_kyLVmqmcxeNKP98quUhEPq4=')
INSERT [dbo].[Partes] ([IdPartes], [NombreP], [Link]) VALUES (6, N'Abajo', N'https://i0.wp.com/colorear.gratis/wp-content/uploads/2021/10/1634607135_32_Archivos-para-dibujar-piernas-ligeras-para-ninos.png?resize=300%2C216&ssl=1')
INSERT [dbo].[Partes] ([IdPartes], [NombreP], [Link]) VALUES (7, N'Abajo', N'https://www.educima.com/dibujo-para-colorear-piernas-dm11476.jpg')
SET IDENTITY_INSERT [dbo].[Partes] OFF
GO
SET IDENTITY_INSERT [dbo].[Skins] ON 

INSERT [dbo].[Skins] ([IdDocente], [NombreDocente], [FotoDocente], [IdMateria], [AntiguedadDocente]) VALUES (12, N'ENCHULAME LA CORKINETA', N'https://www.xtrafondos.com/wallpapers/resoluciones/21/astronauta-corki-league-of-legends-splash-art_3840x2160_7960.jpg', 7, 1350)
SET IDENTITY_INSERT [dbo].[Skins] OFF
GO
USE [master]
GO
ALTER DATABASE [Corki] SET  READ_WRITE 
GO

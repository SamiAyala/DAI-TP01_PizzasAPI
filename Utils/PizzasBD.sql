USE [master]
GO
/****** Object:  Database [Pizzas]    Script Date: 17/3/2023 11:14:47 ******/
CREATE DATABASE [Pizzas]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Pizzas', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Pizzas.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Pizzas_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Pizzas_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Pizzas] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Pizzas].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Pizzas] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Pizzas] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Pizzas] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Pizzas] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Pizzas] SET ARITHABORT OFF 
GO
ALTER DATABASE [Pizzas] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Pizzas] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Pizzas] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Pizzas] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Pizzas] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Pizzas] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Pizzas] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Pizzas] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Pizzas] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Pizzas] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Pizzas] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Pizzas] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Pizzas] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Pizzas] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Pizzas] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Pizzas] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Pizzas] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Pizzas] SET RECOVERY FULL 
GO
ALTER DATABASE [Pizzas] SET  MULTI_USER 
GO
ALTER DATABASE [Pizzas] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Pizzas] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Pizzas] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Pizzas] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Pizzas] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Pizzas', N'ON'
GO
ALTER DATABASE [Pizzas] SET QUERY_STORE = OFF
GO
USE [Pizzas]
GO
/****** Object:  User [alumno]    Script Date: 17/3/2023 11:14:47 ******/
CREATE USER [alumno] FOR LOGIN [alumno] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Pizzas]    Script Date: 17/3/2023 11:14:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pizzas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](150) NULL,
	[LibreGluten] [bit] NULL,
	[Importe] [float] NULL,
	[Descripcion] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Pizzas] ON 

INSERT [dbo].[Pizzas] ([Id], [Nombre], [LibreGluten], [Importe], [Descripcion]) VALUES (1, N'Muzzarela', 0, 3000, N'La clasica')
INSERT [dbo].[Pizzas] ([Id], [Nombre], [LibreGluten], [Importe], [Descripcion]) VALUES (2, N'Fugazzeta', 0, 3500, N'Cebolla y queso')
INSERT [dbo].[Pizzas] ([Id], [Nombre], [LibreGluten], [Importe], [Descripcion]) VALUES (3, N'Hawaiana', 1, 3200, N'Anana, jamon, queso y morron')
INSERT [dbo].[Pizzas] ([Id], [Nombre], [LibreGluten], [Importe], [Descripcion]) VALUES (4, N'Jamon y morrones', 0, 3100, N'Jamon y morrones')
INSERT [dbo].[Pizzas] ([Id], [Nombre], [LibreGluten], [Importe], [Descripcion]) VALUES (5, N'Pollo', 0, 3300, N'Clasica con pollo y morrones')
INSERT [dbo].[Pizzas] ([Id], [Nombre], [LibreGluten], [Importe], [Descripcion]) VALUES (6, N'4 Quesos', 1, 3800, N'Muzzarela, cheddar, Emmental, Gorgonzola')
INSERT [dbo].[Pizzas] ([Id], [Nombre], [LibreGluten], [Importe], [Descripcion]) VALUES (10, N'Pizza de Chocolate', 0, 2900, N'Masa de pizza cubierta de chocolate.')
SET IDENTITY_INSERT [dbo].[Pizzas] OFF
GO
USE [master]
GO
ALTER DATABASE [Pizzas] SET  READ_WRITE 
GO

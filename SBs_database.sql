USE [master]
GO
/****** Object:  Database [starbungs]    Script Date: 28/4/2563 2:36:08 ******/
CREATE DATABASE [starbungs]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'starbungs', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\starbungs.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'starbungs_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\starbungs_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [starbungs] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [starbungs].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [starbungs] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [starbungs] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [starbungs] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [starbungs] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [starbungs] SET ARITHABORT OFF 
GO
ALTER DATABASE [starbungs] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [starbungs] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [starbungs] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [starbungs] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [starbungs] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [starbungs] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [starbungs] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [starbungs] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [starbungs] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [starbungs] SET  DISABLE_BROKER 
GO
ALTER DATABASE [starbungs] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [starbungs] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [starbungs] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [starbungs] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [starbungs] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [starbungs] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [starbungs] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [starbungs] SET RECOVERY FULL 
GO
ALTER DATABASE [starbungs] SET  MULTI_USER 
GO
ALTER DATABASE [starbungs] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [starbungs] SET DB_CHAINING OFF 
GO
ALTER DATABASE [starbungs] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [starbungs] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [starbungs] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'starbungs', N'ON'
GO
ALTER DATABASE [starbungs] SET QUERY_STORE = OFF
GO
USE [starbungs]
GO
/****** Object:  User [NT AUTHORITY\SYSTEM]    Script Date: 28/4/2563 2:36:08 ******/
CREATE USER [NT AUTHORITY\SYSTEM] FOR LOGIN [NT AUTHORITY\SYSTEM] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [NT AUTHORITY\SYSTEM]
GO
/****** Object:  Table [dbo].[coffee]    Script Date: 28/4/2563 2:36:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[coffee](
	[coffeeID] [nchar](4) NULL,
	[coffeeName] [nvarchar](50) NOT NULL,
	[coffeeHot] [float] NULL,
	[coffeeIced] [float] NULL,
	[coffeeFrappe] [float] NULL,
	[coffeeDetail] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[customer]    Script Date: 28/4/2563 2:36:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customer](
	[username] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[name] [varchar](50) NULL,
	[nickname] [varchar](50) NULL,
	[born] [date] NULL,
	[address] [varchar](50) NULL,
	[tel] [varchar](10) NULL,
	[point] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[permissions]    Script Date: 28/4/2563 2:36:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[permissions](
	[sale] [int] NULL,
	[coffee] [int] NULL,
	[customer] [int] NULL,
	[staff] [int] NULL,
	[promotion] [int] NULL,
	[username] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[promotions]    Script Date: 28/4/2563 2:36:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[promotions](
	[promotion_ID] [int] IDENTITY(1,1) NOT NULL,
	[promotion_coupon] [varchar](50) NULL,
	[promotion_condition] [varchar](50) NULL,
	[promotion_discount] [int] NULL,
	[promotion_count] [int] NULL,
	[promotion_user] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sale_details]    Script Date: 28/4/2563 2:36:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sale_details](
	[saleDetailID] [int] IDENTITY(1,1) NOT NULL,
	[saleFullID] [varchar](50) NULL,
	[saleTotal] [float] NULL,
	[discount] [float] NULL,
	[discount_condition] [varchar](50) NULL,
	[sale_net] [float] NULL,
	[customer] [varchar](50) NULL,
	[staff] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sales]    Script Date: 28/4/2563 2:36:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sales](
	[saleID] [int] IDENTITY(1,1) NOT NULL,
	[saleFullID] [varchar](50) NULL,
	[coffeeID] [varchar](50) NULL,
	[coffeeAmount] [int] NULL,
	[coffeeTotal] [float] NULL,
	[date] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[staffs]    Script Date: 28/4/2563 2:36:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[staffs](
	[staffID] [nchar](10) NULL,
	[staffPassword] [nchar](10) NULL,
	[staffName] [nvarchar](50) NULL,
	[gender] [nvarchar](50) NULL,
	[staffLevel] [nvarchar](50) NULL,
	[staffEmail] [nvarchar](50) NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [starbungs] SET  READ_WRITE 
GO

USE [master]
GO
/****** Object:  Database [starbungs]    Script Date: 24/4/2563 22:20:58 ******/
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
/****** Object:  User [NT AUTHORITY\SYSTEM]    Script Date: 24/4/2563 22:20:58 ******/
CREATE USER [NT AUTHORITY\SYSTEM] FOR LOGIN [NT AUTHORITY\SYSTEM] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [NT AUTHORITY\SYSTEM]
GO
/****** Object:  Table [dbo].[coffee]    Script Date: 24/4/2563 22:20:58 ******/
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
/****** Object:  Table [dbo].[promotions]    Script Date: 24/4/2563 22:20:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[promotions](
	[promotion_ID] [int] IDENTITY(1,1) NOT NULL,
	[promotion_coupon] [varchar](50) NULL,
	[promotion_condition] [varchar](50) NULL,
	[promotion_discount] [int] NULL,
	[promotion_count] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sale_details]    Script Date: 24/4/2563 22:20:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sale_details](
	[saleDetailID] [int] IDENTITY(1,1) NOT NULL,
	[saleFullID] [varchar](50) NULL,
	[saleTotal] [float] NULL,
	[discount] [float] NULL,
	[discount_condition] [nchar](10) NULL,
	[sale_net] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sales]    Script Date: 24/4/2563 22:20:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sales](
	[saleID] [int] IDENTITY(1,1) NOT NULL,
	[saleFullID] [nvarchar](50) NULL,
	[coffeeID] [nvarchar](50) NULL,
	[coffeeAmount] [int] NULL,
	[coffeeTotal] [float] NULL,
	[date] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[staffs]    Script Date: 24/4/2563 22:20:58 ******/
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
INSERT [dbo].[coffee] ([coffeeID], [coffeeName], [coffeeHot], [coffeeIced], [coffeeFrappe], [coffeeDetail]) VALUES (N'8420', N'Mocca', 182, 210, 230, N'Best')
INSERT [dbo].[coffee] ([coffeeID], [coffeeName], [coffeeHot], [coffeeIced], [coffeeFrappe], [coffeeDetail]) VALUES (N'9197', N'Latte', 165, 185, 200, N'Latte')
GO
SET IDENTITY_INSERT [dbo].[promotions] ON 

INSERT [dbo].[promotions] ([promotion_ID], [promotion_coupon], [promotion_condition], [promotion_discount], [promotion_count]) VALUES (4, N'9197', N'100', 100, 1)
INSERT [dbo].[promotions] ([promotion_ID], [promotion_coupon], [promotion_condition], [promotion_discount], [promotion_count]) VALUES (5, N'pattanan', N'-200 bath', 200, 1)
SET IDENTITY_INSERT [dbo].[promotions] OFF
GO
SET IDENTITY_INSERT [dbo].[sale_details] ON 

INSERT [dbo].[sale_details] ([saleDetailID], [saleFullID], [saleTotal], [discount], [discount_condition], [sale_net]) VALUES (6, N'SB-2563/00001', 600, 0, N'0         ', 600)
INSERT [dbo].[sale_details] ([saleDetailID], [saleFullID], [saleTotal], [discount], [discount_condition], [sale_net]) VALUES (7, N'SB-2563/00006', 400, 0, N'0         ', 400)
INSERT [dbo].[sale_details] ([saleDetailID], [saleFullID], [saleTotal], [discount], [discount_condition], [sale_net]) VALUES (8, N'SB-2563/00007', 382, 200, N'xxx       ', 382)
INSERT [dbo].[sale_details] ([saleDetailID], [saleFullID], [saleTotal], [discount], [discount_condition], [sale_net]) VALUES (9, N'SB-2563/00009', 495, 200, N'xxx       ', 495)
SET IDENTITY_INSERT [dbo].[sale_details] OFF
GO
SET IDENTITY_INSERT [dbo].[sales] ON 

INSERT [dbo].[sales] ([saleID], [saleFullID], [coffeeID], [coffeeAmount], [coffeeTotal], [date]) VALUES (4, N'SB-2563/00001', N'8420', 1, 230, CAST(N'2020-04-24' AS Date))
INSERT [dbo].[sales] ([saleID], [saleFullID], [coffeeID], [coffeeAmount], [coffeeTotal], [date]) VALUES (5, N'SB-2563/00001', N'9197', 2, 370, CAST(N'2020-04-24' AS Date))
INSERT [dbo].[sales] ([saleID], [saleFullID], [coffeeID], [coffeeAmount], [coffeeTotal], [date]) VALUES (6, N'SB-2563/00006', N'9197', 2, 400, CAST(N'2020-04-24' AS Date))
INSERT [dbo].[sales] ([saleID], [saleFullID], [coffeeID], [coffeeAmount], [coffeeTotal], [date]) VALUES (7, N'SB-2563/00007', N'9197', 1, 200, CAST(N'2020-04-24' AS Date))
INSERT [dbo].[sales] ([saleID], [saleFullID], [coffeeID], [coffeeAmount], [coffeeTotal], [date]) VALUES (8, N'SB-2563/00007', N'8420', 1, 182, CAST(N'2020-04-24' AS Date))
INSERT [dbo].[sales] ([saleID], [saleFullID], [coffeeID], [coffeeAmount], [coffeeTotal], [date]) VALUES (9, N'SB-2563/00009', N'9197', 3, 495, CAST(N'2020-04-24' AS Date))
SET IDENTITY_INSERT [dbo].[sales] OFF
GO
INSERT [dbo].[staffs] ([staffID], [staffPassword], [staffName], [gender], [staffLevel], [staffEmail]) VALUES (N'6140204063', N'0000000000', N'Pattanan', N'Male', N'Manager', N'phattanan1999@gmail.com')
GO
USE [master]
GO
ALTER DATABASE [starbungs] SET  READ_WRITE 
GO

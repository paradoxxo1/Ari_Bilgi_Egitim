USE [master]
GO
/****** Object:  Database [Casher]    Script Date: 14.08.2023 17:59:46 ******/
CREATE DATABASE [Casher]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Casher', FILENAME = N'G:\sql\MSSQL16.SQLEXPRESS\MSSQL\DATA\Casher.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Casher_log', FILENAME = N'G:\sql\MSSQL16.SQLEXPRESS\MSSQL\DATA\Casher_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Casher] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Casher].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Casher] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Casher] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Casher] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Casher] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Casher] SET ARITHABORT OFF 
GO
ALTER DATABASE [Casher] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Casher] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Casher] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Casher] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Casher] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Casher] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Casher] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Casher] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Casher] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Casher] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Casher] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Casher] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Casher] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Casher] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Casher] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Casher] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Casher] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Casher] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Casher] SET  MULTI_USER 
GO
ALTER DATABASE [Casher] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Casher] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Casher] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Casher] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Casher] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Casher] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Casher] SET QUERY_STORE = ON
GO
ALTER DATABASE [Casher] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Casher]
GO
/****** Object:  Table [dbo].[Musteri]    Script Date: 14.08.2023 17:59:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Musteri](
	[Musteri_ID] [int] NOT NULL,
	[Adi] [nvarchar](100) NULL,
	[Soyadi] [nvarchar](100) NULL,
	[Yasi] [int] NULL,
	[Cinsiyeti] [nvarchar](10) NULL,
	[Bakiye] [int] NULL,
	[Tarih] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[Musteri_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Musteri] ([Musteri_ID], [Adi], [Soyadi], [Yasi], [Cinsiyeti], [Bakiye], [Tarih]) VALUES (1, N'Fatih', N'Tasdelen', 27, N'Erkek', 78512, CAST(N'2023-08-10' AS Date))
INSERT [dbo].[Musteri] ([Musteri_ID], [Adi], [Soyadi], [Yasi], [Cinsiyeti], [Bakiye], [Tarih]) VALUES (2, N'Mustafa ', N'Demirkıran', 32, N'Erkek', 12078, CAST(N'2023-08-11' AS Date))
INSERT [dbo].[Musteri] ([Musteri_ID], [Adi], [Soyadi], [Yasi], [Cinsiyeti], [Bakiye], [Tarih]) VALUES (3, N'Nigar', N'Demirkıran', 28, N'Kadın', 6000, CAST(N'2023-08-09' AS Date))
INSERT [dbo].[Musteri] ([Musteri_ID], [Adi], [Soyadi], [Yasi], [Cinsiyeti], [Bakiye], [Tarih]) VALUES (4, N'Faize', N'Akçaba', 45, N'Kadın', 5500, CAST(N'2023-08-08' AS Date))
INSERT [dbo].[Musteri] ([Musteri_ID], [Adi], [Soyadi], [Yasi], [Cinsiyeti], [Bakiye], [Tarih]) VALUES (5, N'Hatice', N'Baydır', 36, N'Kadın', 168664, CAST(N'2023-08-07' AS Date))
INSERT [dbo].[Musteri] ([Musteri_ID], [Adi], [Soyadi], [Yasi], [Cinsiyeti], [Bakiye], [Tarih]) VALUES (6, N'Sinan', N'Topal', 23, N'Erkek', 7000, CAST(N'2023-08-22' AS Date))
INSERT [dbo].[Musteri] ([Musteri_ID], [Adi], [Soyadi], [Yasi], [Cinsiyeti], [Bakiye], [Tarih]) VALUES (7, N'Admin', N'Admin', 34, N'Erkek', 100000000, CAST(N'2023-08-31' AS Date))
INSERT [dbo].[Musteri] ([Musteri_ID], [Adi], [Soyadi], [Yasi], [Cinsiyeti], [Bakiye], [Tarih]) VALUES (8, N'Sibel', N'Sayın', 44, N'Kadın', 8550, CAST(N'2023-08-30' AS Date))
INSERT [dbo].[Musteri] ([Musteri_ID], [Adi], [Soyadi], [Yasi], [Cinsiyeti], [Bakiye], [Tarih]) VALUES (9, N'Adile', N'Bayar', 38, N'Erkek', 4548, CAST(N'2023-08-29' AS Date))
INSERT [dbo].[Musteri] ([Musteri_ID], [Adi], [Soyadi], [Yasi], [Cinsiyeti], [Bakiye], [Tarih]) VALUES (10, N'Mustafa', N'Aşık', 55, N'Erkek', 8877, CAST(N'2023-08-15' AS Date))
INSERT [dbo].[Musteri] ([Musteri_ID], [Adi], [Soyadi], [Yasi], [Cinsiyeti], [Bakiye], [Tarih]) VALUES (11, NULL, NULL, NULL, NULL, NULL, CAST(N'2023-08-26' AS Date))
GO
USE [master]
GO
ALTER DATABASE [Casher] SET  READ_WRITE 
GO

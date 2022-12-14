USE [master]
GO
/****** Object:  Database [banka_otomasyonu]    Script Date: 28.08.2022 21:26:54 ******/
CREATE DATABASE [banka_otomasyonu]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'banka_otomasyonu', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\banka_otomasyonu.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'banka_otomasyonu_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\banka_otomasyonu_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [banka_otomasyonu] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [banka_otomasyonu].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [banka_otomasyonu] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [banka_otomasyonu] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [banka_otomasyonu] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [banka_otomasyonu] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [banka_otomasyonu] SET ARITHABORT OFF 
GO
ALTER DATABASE [banka_otomasyonu] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [banka_otomasyonu] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [banka_otomasyonu] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [banka_otomasyonu] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [banka_otomasyonu] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [banka_otomasyonu] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [banka_otomasyonu] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [banka_otomasyonu] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [banka_otomasyonu] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [banka_otomasyonu] SET  DISABLE_BROKER 
GO
ALTER DATABASE [banka_otomasyonu] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [banka_otomasyonu] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [banka_otomasyonu] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [banka_otomasyonu] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [banka_otomasyonu] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [banka_otomasyonu] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [banka_otomasyonu] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [banka_otomasyonu] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [banka_otomasyonu] SET  MULTI_USER 
GO
ALTER DATABASE [banka_otomasyonu] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [banka_otomasyonu] SET DB_CHAINING OFF 
GO
ALTER DATABASE [banka_otomasyonu] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [banka_otomasyonu] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [banka_otomasyonu] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [banka_otomasyonu] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [banka_otomasyonu] SET QUERY_STORE = OFF
GO
USE [banka_otomasyonu]
GO
/****** Object:  Table [dbo].[banka_rapor]    Script Date: 28.08.2022 21:26:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[banka_rapor](
	[mevcut_para] [int] NULL,
	[toplam_gelen_para] [int] NULL,
	[toplam_giden_para] [int] NULL,
	[net_para] [int] NULL,
	[tarih] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hesap_ozeti]    Script Date: 28.08.2022 21:26:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hesap_ozeti](
	[musteri_tc] [nvarchar](11) NULL,
	[musteri_adi] [nvarchar](50) NULL,
	[musteri_soyadi] [nvarchar](50) NULL,
	[hesap_no] [nvarchar](50) NULL,
	[bakiye] [int] NULL,
	[gelen_para] [int] NULL,
	[giden_para] [int] NULL,
	[musteri_tipi] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[musteri_bilgi]    Script Date: 28.08.2022 21:26:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[musteri_bilgi](
	[musteri_tc] [nvarchar](11) NULL,
	[musteri_adi] [nvarchar](50) NOT NULL,
	[musteri_soyadi] [nvarchar](50) NOT NULL,
	[musteri_tipi] [nvarchar](50) NULL,
	[hesap_no] [nvarchar](50) NULL,
	[musteri_sifre] [nvarchar](50) NULL,
	[musteri_mail] [nvarchar](50) NULL,
	[bakiye] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[personel_bilgi]    Script Date: 28.08.2022 21:26:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[personel_bilgi](
	[personel_tc] [nvarchar](11) NULL,
	[personel_adi] [nvarchar](50) NULL,
	[personel_soyadi] [nvarchar](50) NULL,
	[personel_sifre] [nvarchar](11) NULL,
	[personel_tip] [nvarchar](50) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[banka_rapor] ([mevcut_para], [toplam_gelen_para], [toplam_giden_para], [net_para], [tarih]) VALUES (1000000000, NULL, NULL, NULL, CAST(N'2022-08-28T19:26:22.847' AS DateTime))
GO
INSERT [dbo].[hesap_ozeti] ([musteri_tc], [musteri_adi], [musteri_soyadi], [hesap_no], [bakiye], [gelen_para], [giden_para], [musteri_tipi]) VALUES (N'78452658421', N'Mustfa', N'Akbal', N'1860', 4000, 2000, 0, N'Bireysel')
INSERT [dbo].[hesap_ozeti] ([musteri_tc], [musteri_adi], [musteri_soyadi], [hesap_no], [bakiye], [gelen_para], [giden_para], [musteri_tipi]) VALUES (N'78452658421', N'Mustfa', N'Akbal', N'1026', 1880, 0, -120, N'Bireysel')
INSERT [dbo].[hesap_ozeti] ([musteri_tc], [musteri_adi], [musteri_soyadi], [hesap_no], [bakiye], [gelen_para], [giden_para], [musteri_tipi]) VALUES (N'56327201843', N'Mücahit', N'Akbal', N'5806', 140, 140, -2000, N'İşletme')
INSERT [dbo].[hesap_ozeti] ([musteri_tc], [musteri_adi], [musteri_soyadi], [hesap_no], [bakiye], [gelen_para], [giden_para], [musteri_tipi]) VALUES (N'56327201843', N'Mücahit', N'Akbal', N'5846', 1880, 0, -120, N'İşletme')
INSERT [dbo].[hesap_ozeti] ([musteri_tc], [musteri_adi], [musteri_soyadi], [hesap_no], [bakiye], [gelen_para], [giden_para], [musteri_tipi]) VALUES (N'12345678912', N'Seher Kader', N'Erdem', N'7117', 2120, 120, 0, N'Çiftçi')
INSERT [dbo].[hesap_ozeti] ([musteri_tc], [musteri_adi], [musteri_soyadi], [hesap_no], [bakiye], [gelen_para], [giden_para], [musteri_tipi]) VALUES (N'12345678912', N'Seher Kader', N'Erdem', N'8942', 2000, 250, -250, N'Çiftçi')
GO
INSERT [dbo].[musteri_bilgi] ([musteri_tc], [musteri_adi], [musteri_soyadi], [musteri_tipi], [hesap_no], [musteri_sifre], [musteri_mail], [bakiye]) VALUES (N'78452658421', N'Mustfa', N'Akbal', N'Bireysel', N'7923', N'6346', N'info@mytmustafa.com', 2500)
INSERT [dbo].[musteri_bilgi] ([musteri_tc], [musteri_adi], [musteri_soyadi], [musteri_tipi], [hesap_no], [musteri_sifre], [musteri_mail], [bakiye]) VALUES (N'56327201843', N'Mücahit', N'Akbal', N'İşletme', N'1061', N'2359', N'info@mytmucahit.com', 60000)
INSERT [dbo].[musteri_bilgi] ([musteri_tc], [musteri_adi], [musteri_soyadi], [musteri_tipi], [hesap_no], [musteri_sifre], [musteri_mail], [bakiye]) VALUES (N'12345678912', N'Seher Kader', N'Erdem', N'Çiftçi', N'3015', N'5019', N'info@seher.com', 12000)
GO
INSERT [dbo].[personel_bilgi] ([personel_tc], [personel_adi], [personel_soyadi], [personel_sifre], [personel_tip]) VALUES (N'1212', N'Computer', N'Worm', N'3698', N'CEO')
GO
ALTER TABLE [dbo].[banka_rapor] ADD  CONSTRAINT [DF_banka_rapor]  DEFAULT (getdate()) FOR [tarih]
GO
USE [master]
GO
ALTER DATABASE [banka_otomasyonu] SET  READ_WRITE 
GO

USE [master]
GO
/****** Object:  Database [omuGrossDataBase]    Script Date: 20.01.2023 21:11:10 ******/
CREATE DATABASE [omuGrossDataBase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'omuGrossDataBase', FILENAME = N'E:\Microsoft SQL\MSSQL15.MSSQLSERVER\MSSQL\DATA\omuGrossDataBase.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'omuGrossDataBase_log', FILENAME = N'E:\Microsoft SQL\MSSQL15.MSSQLSERVER\MSSQL\DATA\omuGrossDataBase_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [omuGrossDataBase] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [omuGrossDataBase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [omuGrossDataBase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [omuGrossDataBase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [omuGrossDataBase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [omuGrossDataBase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [omuGrossDataBase] SET ARITHABORT OFF 
GO
ALTER DATABASE [omuGrossDataBase] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [omuGrossDataBase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [omuGrossDataBase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [omuGrossDataBase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [omuGrossDataBase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [omuGrossDataBase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [omuGrossDataBase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [omuGrossDataBase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [omuGrossDataBase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [omuGrossDataBase] SET  DISABLE_BROKER 
GO
ALTER DATABASE [omuGrossDataBase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [omuGrossDataBase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [omuGrossDataBase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [omuGrossDataBase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [omuGrossDataBase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [omuGrossDataBase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [omuGrossDataBase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [omuGrossDataBase] SET RECOVERY FULL 
GO
ALTER DATABASE [omuGrossDataBase] SET  MULTI_USER 
GO
ALTER DATABASE [omuGrossDataBase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [omuGrossDataBase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [omuGrossDataBase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [omuGrossDataBase] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [omuGrossDataBase] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [omuGrossDataBase] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'omuGrossDataBase', N'ON'
GO
ALTER DATABASE [omuGrossDataBase] SET QUERY_STORE = OFF
GO
USE [omuGrossDataBase]
GO
/****** Object:  Table [dbo].[irsaliye]    Script Date: 20.01.2023 21:11:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[irsaliye](
	[irsaliyeNo] [int] IDENTITY(1,1) NOT NULL,
	[urunGirdiMiktari] [int] NOT NULL,
	[urunFiyati] [int] NOT NULL,
	[tedarikciID] [int] NOT NULL,
	[urunID] [int] NOT NULL,
	[barkodNo] [int] NOT NULL,
 CONSTRAINT [PK_irsaliye] PRIMARY KEY CLUSTERED 
(
	[irsaliyeNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[market]    Script Date: 20.01.2023 21:11:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[market](
	[musteriID] [int] NOT NULL,
	[tedarikciID] [int] NOT NULL,
	[satisID] [int] NOT NULL,
	[urunID] [int] NOT NULL,
	[marketID] [int] NOT NULL,
 CONSTRAINT [PK_market] PRIMARY KEY CLUSTERED 
(
	[marketID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[musteri]    Script Date: 20.01.2023 21:11:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[musteri](
	[musteriID] [int] IDENTITY(1,1) NOT NULL,
	[ad] [nchar](50) NOT NULL,
	[soyad] [nchar](50) NOT NULL,
	[sifre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_musteri] PRIMARY KEY CLUSTERED 
(
	[musteriID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[musteriBorc]    Script Date: 20.01.2023 21:11:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[musteriBorc](
	[musteriID] [int] IDENTITY(1,1) NOT NULL,
	[borcMiktari] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[musteriOdeme]    Script Date: 20.01.2023 21:11:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[musteriOdeme](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[odemeMiktari] [int] NOT NULL,
	[odemeTarihi] [date] NOT NULL,
	[musteriID] [int] NOT NULL,
 CONSTRAINT [PK_musteriOdeme] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[perakendeSatis]    Script Date: 20.01.2023 21:11:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[perakendeSatis](
	[satisID] [int] IDENTITY(1,1) NOT NULL,
	[urunID] [int] NOT NULL,
	[satisTarih] [smalldatetime] NOT NULL,
	[satisMiktar] [int] NOT NULL,
 CONSTRAINT [PK_perakendeSatis] PRIMARY KEY CLUSTERED 
(
	[satisID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pesinSatis]    Script Date: 20.01.2023 21:11:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pesinSatis](
	[satisID] [int] NOT NULL,
	[satisTarih] [smalldatetime] NOT NULL,
	[satisMiktar] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tedarikci]    Script Date: 20.01.2023 21:11:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tedarikci](
	[tedarikciID] [int] IDENTITY(1,1) NOT NULL,
	[ad] [nchar](50) NOT NULL,
 CONSTRAINT [PK_tedarikci] PRIMARY KEY CLUSTERED 
(
	[tedarikciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tedarikciBorc]    Script Date: 20.01.2023 21:11:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tedarikciBorc](
	[tedarikciID] [int] NOT NULL,
	[borcMiktar] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tedarikciOdeme]    Script Date: 20.01.2023 21:11:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tedarikciOdeme](
	[tedarikciID] [int] NOT NULL,
	[odemeMiktar] [int] NOT NULL,
	[odemeTarih] [date] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[urun]    Script Date: 20.01.2023 21:11:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[urun](
	[urunID] [int] IDENTITY(1,1) NOT NULL,
	[urunAd] [nchar](100) NOT NULL,
	[urunFiyat] [int] NOT NULL,
	[barkodNo] [int] NOT NULL,
 CONSTRAINT [PK_urun] PRIMARY KEY CLUSTERED 
(
	[urunID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[urunStokDurum]    Script Date: 20.01.2023 21:11:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[urunStokDurum](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[urunID] [int] NOT NULL,
	[stokMiktar] [int] NOT NULL,
 CONSTRAINT [PK_urunStokDurum] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[veresiye]    Script Date: 20.01.2023 21:11:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[veresiye](
	[satisID] [int] NOT NULL,
	[satisTarih] [int] NOT NULL,
	[satisMiktar] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[musteriBorc] ADD  CONSTRAINT [DF_musteriBorc_borcMiktari]  DEFAULT ((0)) FOR [borcMiktari]
GO
ALTER TABLE [dbo].[musteriOdeme] ADD  CONSTRAINT [DF_musteriOdeme_odemeMiktari]  DEFAULT ((0)) FOR [odemeMiktari]
GO
ALTER TABLE [dbo].[tedarikciBorc] ADD  CONSTRAINT [DF_tedarikciBorc_borcMiktar]  DEFAULT ((0)) FOR [borcMiktar]
GO
ALTER TABLE [dbo].[tedarikciOdeme] ADD  CONSTRAINT [DF_tedarikciOdeme_odemeMiktar]  DEFAULT ((0)) FOR [odemeMiktar]
GO
ALTER TABLE [dbo].[urunStokDurum] ADD  CONSTRAINT [DF_urunStokDurum_stokMiktar]  DEFAULT ((0)) FOR [stokMiktar]
GO
ALTER TABLE [dbo].[irsaliye]  WITH CHECK ADD  CONSTRAINT [FK_irsaliye_tedarikci] FOREIGN KEY([tedarikciID])
REFERENCES [dbo].[tedarikci] ([tedarikciID])
GO
ALTER TABLE [dbo].[irsaliye] CHECK CONSTRAINT [FK_irsaliye_tedarikci]
GO
ALTER TABLE [dbo].[irsaliye]  WITH CHECK ADD  CONSTRAINT [FK_irsaliye_urun] FOREIGN KEY([urunID])
REFERENCES [dbo].[urun] ([urunID])
GO
ALTER TABLE [dbo].[irsaliye] CHECK CONSTRAINT [FK_irsaliye_urun]
GO
ALTER TABLE [dbo].[market]  WITH CHECK ADD  CONSTRAINT [FK_market_musteri] FOREIGN KEY([musteriID])
REFERENCES [dbo].[musteri] ([musteriID])
GO
ALTER TABLE [dbo].[market] CHECK CONSTRAINT [FK_market_musteri]
GO
ALTER TABLE [dbo].[market]  WITH CHECK ADD  CONSTRAINT [FK_market_perakendeSatis] FOREIGN KEY([satisID])
REFERENCES [dbo].[perakendeSatis] ([satisID])
GO
ALTER TABLE [dbo].[market] CHECK CONSTRAINT [FK_market_perakendeSatis]
GO
ALTER TABLE [dbo].[market]  WITH CHECK ADD  CONSTRAINT [FK_market_tedarikci] FOREIGN KEY([tedarikciID])
REFERENCES [dbo].[tedarikci] ([tedarikciID])
GO
ALTER TABLE [dbo].[market] CHECK CONSTRAINT [FK_market_tedarikci]
GO
ALTER TABLE [dbo].[market]  WITH CHECK ADD  CONSTRAINT [FK_market_urun] FOREIGN KEY([urunID])
REFERENCES [dbo].[urun] ([urunID])
GO
ALTER TABLE [dbo].[market] CHECK CONSTRAINT [FK_market_urun]
GO
ALTER TABLE [dbo].[musteriBorc]  WITH CHECK ADD  CONSTRAINT [FK_musteriBorc_musteri] FOREIGN KEY([musteriID])
REFERENCES [dbo].[musteri] ([musteriID])
GO
ALTER TABLE [dbo].[musteriBorc] CHECK CONSTRAINT [FK_musteriBorc_musteri]
GO
ALTER TABLE [dbo].[musteriOdeme]  WITH CHECK ADD  CONSTRAINT [FK_musteriOdeme_musteri1] FOREIGN KEY([musteriID])
REFERENCES [dbo].[musteri] ([musteriID])
GO
ALTER TABLE [dbo].[musteriOdeme] CHECK CONSTRAINT [FK_musteriOdeme_musteri1]
GO
ALTER TABLE [dbo].[perakendeSatis]  WITH CHECK ADD  CONSTRAINT [FK_perakendeSatis_urun] FOREIGN KEY([urunID])
REFERENCES [dbo].[urun] ([urunID])
GO
ALTER TABLE [dbo].[perakendeSatis] CHECK CONSTRAINT [FK_perakendeSatis_urun]
GO
ALTER TABLE [dbo].[pesinSatis]  WITH CHECK ADD  CONSTRAINT [FK_pesinSatis_perakendeSatis] FOREIGN KEY([satisID])
REFERENCES [dbo].[perakendeSatis] ([satisID])
GO
ALTER TABLE [dbo].[pesinSatis] CHECK CONSTRAINT [FK_pesinSatis_perakendeSatis]
GO
ALTER TABLE [dbo].[tedarikciBorc]  WITH CHECK ADD  CONSTRAINT [FK_tedarikciBorc_tedarikci] FOREIGN KEY([tedarikciID])
REFERENCES [dbo].[tedarikci] ([tedarikciID])
GO
ALTER TABLE [dbo].[tedarikciBorc] CHECK CONSTRAINT [FK_tedarikciBorc_tedarikci]
GO
ALTER TABLE [dbo].[tedarikciOdeme]  WITH CHECK ADD  CONSTRAINT [FK_tedarikciOdeme_tedarikci] FOREIGN KEY([tedarikciID])
REFERENCES [dbo].[tedarikci] ([tedarikciID])
GO
ALTER TABLE [dbo].[tedarikciOdeme] CHECK CONSTRAINT [FK_tedarikciOdeme_tedarikci]
GO
ALTER TABLE [dbo].[urunStokDurum]  WITH CHECK ADD  CONSTRAINT [FK_urunStokDurum_urun1] FOREIGN KEY([urunID])
REFERENCES [dbo].[urun] ([urunID])
GO
ALTER TABLE [dbo].[urunStokDurum] CHECK CONSTRAINT [FK_urunStokDurum_urun1]
GO
ALTER TABLE [dbo].[veresiye]  WITH CHECK ADD  CONSTRAINT [FK_veresiteSatis_perakendeSatis] FOREIGN KEY([satisID])
REFERENCES [dbo].[perakendeSatis] ([satisID])
GO
ALTER TABLE [dbo].[veresiye] CHECK CONSTRAINT [FK_veresiteSatis_perakendeSatis]
GO
ALTER TABLE [dbo].[veresiye]  WITH CHECK ADD  CONSTRAINT [FK_veresiye_musteri] FOREIGN KEY([satisTarih])
REFERENCES [dbo].[musteri] ([musteriID])
GO
ALTER TABLE [dbo].[veresiye] CHECK CONSTRAINT [FK_veresiye_musteri]
GO
USE [master]
GO
ALTER DATABASE [omuGrossDataBase] SET  READ_WRITE 
GO

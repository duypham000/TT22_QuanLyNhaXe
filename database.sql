USE [master]
GO
/****** Object:  Database [QuanLyNhaXe]    Script Date: 5/12/2022 9:48:21 AM ******/
CREATE DATABASE [QuanLyNhaXe]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyNhaXe', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QuanLyNhaXe.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyNhaXe_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QuanLyNhaXe_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QuanLyNhaXe] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyNhaXe].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyNhaXe] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyNhaXe] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyNhaXe] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyNhaXe] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyNhaXe] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyNhaXe] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyNhaXe] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyNhaXe] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyNhaXe] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyNhaXe] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyNhaXe] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyNhaXe] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyNhaXe] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyNhaXe] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyNhaXe] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyNhaXe] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyNhaXe] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyNhaXe] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyNhaXe] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyNhaXe] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyNhaXe] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyNhaXe] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyNhaXe] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLyNhaXe] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyNhaXe] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyNhaXe] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyNhaXe] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyNhaXe] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyNhaXe] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyNhaXe] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLyNhaXe', N'ON'
GO
ALTER DATABASE [QuanLyNhaXe] SET QUERY_STORE = OFF
GO
USE [QuanLyNhaXe]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 5/12/2022 9:48:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenKH] [nvarchar](250) NULL,
	[SDT] [varchar](50) NULL,
	[DiaChi] [nvarchar](500) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 5/12/2022 9:48:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaNV] [varchar](250) NULL,
	[MatKhau] [varchar](250) NULL,
	[TenNV] [nvarchar](250) NULL,
	[DiaChi] [nvarchar](250) NULL,
	[SDT] [varchar](50) NULL,
	[NgayVaoLam] [datetime] NULL,
	[TrangThai] [nvarchar](250) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VeXe]    Script Date: 5/12/2022 9:48:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VeXe](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDXe] [int] NULL,
	[NgayGui] [datetime] NULL,
	[NgayLay] [datetime] NULL,
	[LoaiVe] [nvarchar](50) NULL,
	[QuaHan] [bit] NULL,
	[DaLay] [bit] NULL,
	[GiaVe] [decimal](18, 2) NULL,
 CONSTRAINT [PK_VeXe] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Xe]    Script Date: 5/12/2022 9:48:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Xe](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BienXe] [varchar](250) NULL,
	[IDChuXe] [int] NULL,
	[LoaiXe] [nvarchar](250) NULL,
	[MoTaXe] [nvarchar](500) NULL,
	[DangDeXe] [bit] NULL,
 CONSTRAINT [PK_Xe] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([ID], [TenKH], [SDT], [DiaChi]) VALUES (1, N'Phạm Khánh Duy', N'0344848305', N'Sóc sơn HN')
INSERT [dbo].[KhachHang] ([ID], [TenKH], [SDT], [DiaChi]) VALUES (2, N'Lê Khánh An', N'03448421', N'ascjn')
INSERT [dbo].[KhachHang] ([ID], [TenKH], [SDT], [DiaChi]) VALUES (3, N'Lê Huy Khánh', N'0192321039i', N'Soc Son')
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
GO
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([ID], [MaNV], [MatKhau], [TenNV], [DiaChi], [SDT], [NgayVaoLam], [TrangThai]) VALUES (1, N'NV1', N'0508', N'Duy Pham', N'Soc Son', N'0123456789', CAST(N'2022-05-06T21:58:52.000' AS DateTime), N'Đang làm')
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
GO
SET IDENTITY_INSERT [dbo].[VeXe] ON 

INSERT [dbo].[VeXe] ([ID], [IDXe], [NgayGui], [NgayLay], [LoaiVe], [QuaHan], [DaLay], [GiaVe]) VALUES (1, 1, CAST(N'2022-04-26T19:09:15.870' AS DateTime), CAST(N'2022-04-27T00:41:56.457' AS DateTime), N'Vé ngày', 1, 0, CAST(5000.00 AS Decimal(18, 2)))
INSERT [dbo].[VeXe] ([ID], [IDXe], [NgayGui], [NgayLay], [LoaiVe], [QuaHan], [DaLay], [GiaVe]) VALUES (2, 2, CAST(N'2022-04-26T19:11:17.710' AS DateTime), CAST(N'2022-04-27T00:41:56.457' AS DateTime), N'Vé qua đêm', 0, 1, CAST(30000.00 AS Decimal(18, 2)))
INSERT [dbo].[VeXe] ([ID], [IDXe], [NgayGui], [NgayLay], [LoaiVe], [QuaHan], [DaLay], [GiaVe]) VALUES (3, 3, CAST(N'2022-04-26T20:35:17.033' AS DateTime), CAST(N'2022-04-27T00:41:56.457' AS DateTime), N'Vé ngày', 1, 0, CAST(5000.00 AS Decimal(18, 2)))
INSERT [dbo].[VeXe] ([ID], [IDXe], [NgayGui], [NgayLay], [LoaiVe], [QuaHan], [DaLay], [GiaVe]) VALUES (4, 5, CAST(N'2022-04-26T22:46:01.100' AS DateTime), CAST(N'2022-05-01T11:39:00.000' AS DateTime), N'Vé qua đêm', 1, 0, CAST(20000.00 AS Decimal(18, 2)))
INSERT [dbo].[VeXe] ([ID], [IDXe], [NgayGui], [NgayLay], [LoaiVe], [QuaHan], [DaLay], [GiaVe]) VALUES (8, 5, CAST(N'2022-04-27T15:28:11.170' AS DateTime), CAST(N'2022-05-01T11:39:00.000' AS DateTime), N'Vé qua đêm', 1, 0, CAST(20000.00 AS Decimal(18, 2)))
INSERT [dbo].[VeXe] ([ID], [IDXe], [NgayGui], [NgayLay], [LoaiVe], [QuaHan], [DaLay], [GiaVe]) VALUES (9, 6, CAST(N'2022-04-27T15:28:29.577' AS DateTime), CAST(N'2022-04-27T00:41:56.457' AS DateTime), N'Vé ngày', 1, 0, CAST(3000.00 AS Decimal(18, 2)))
INSERT [dbo].[VeXe] ([ID], [IDXe], [NgayGui], [NgayLay], [LoaiVe], [QuaHan], [DaLay], [GiaVe]) VALUES (11, 5, CAST(N'2022-04-27T15:28:08.867' AS DateTime), CAST(N'2022-04-27T15:28:08.867' AS DateTime), N'Vé qua đêm', 0, 1, CAST(20000.00 AS Decimal(18, 2)))
INSERT [dbo].[VeXe] ([ID], [IDXe], [NgayGui], [NgayLay], [LoaiVe], [QuaHan], [DaLay], [GiaVe]) VALUES (12, 3, CAST(N'2022-04-26T19:25:15.000' AS DateTime), CAST(N'2022-04-27T00:41:56.457' AS DateTime), N'Vé qua đêm', 0, 1, CAST(30000.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[VeXe] OFF
GO
SET IDENTITY_INSERT [dbo].[Xe] ON 

INSERT [dbo].[Xe] ([ID], [BienXe], [IDChuXe], [LoaiXe], [MoTaXe], [DangDeXe]) VALUES (1, N'71DCYUAS', 1, N'Vé ngày', N'Hello kitty màu trắng', 1)
INSERT [dbo].[Xe] ([ID], [BienXe], [IDChuXe], [LoaiXe], [MoTaXe], [DangDeXe]) VALUES (2, N'a1sd4aw', 2, N'Xe máy', N'awd41ws', 1)
INSERT [dbo].[Xe] ([ID], [BienXe], [IDChuXe], [LoaiXe], [MoTaXe], [DangDeXe]) VALUES (3, N'71asdhjc', 1, N'Xe máy', N'Vàng toàn thân', 0)
INSERT [dbo].[Xe] ([ID], [BienXe], [IDChuXe], [LoaiXe], [MoTaXe], [DangDeXe]) VALUES (4, N'', 3, N'Xe đạp', N'Mau den', 0)
INSERT [dbo].[Xe] ([ID], [BienXe], [IDChuXe], [LoaiXe], [MoTaXe], [DangDeXe]) VALUES (5, N'', 3, N'Xe đạp', N'LJKANCS', 1)
INSERT [dbo].[Xe] ([ID], [BienXe], [IDChuXe], [LoaiXe], [MoTaXe], [DangDeXe]) VALUES (6, N'', 3, N'Xe đạp', N'ascasc', 1)
SET IDENTITY_INSERT [dbo].[Xe] OFF
GO
ALTER TABLE [dbo].[VeXe]  WITH CHECK ADD  CONSTRAINT [FK_VeXe_Xe] FOREIGN KEY([IDXe])
REFERENCES [dbo].[Xe] ([ID])
GO
ALTER TABLE [dbo].[VeXe] CHECK CONSTRAINT [FK_VeXe_Xe]
GO
ALTER TABLE [dbo].[Xe]  WITH CHECK ADD  CONSTRAINT [FK_Xe_KhachHang] FOREIGN KEY([IDChuXe])
REFERENCES [dbo].[KhachHang] ([ID])
GO
ALTER TABLE [dbo].[Xe] CHECK CONSTRAINT [FK_Xe_KhachHang]
GO
USE [master]
GO
ALTER DATABASE [QuanLyNhaXe] SET  READ_WRITE 
GO

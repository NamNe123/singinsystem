USE [master]
GO
/****** Object:  Database [Learning_QLBH]    Script Date: 2024-06-24 1:12:08 PM ******/
CREATE DATABASE [Learning_QLBH]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Learning_QLBH', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Learning_QLBH.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Learning_QLBH_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Learning_QLBH_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Learning_QLBH] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Learning_QLBH].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Learning_QLBH] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Learning_QLBH] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Learning_QLBH] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Learning_QLBH] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Learning_QLBH] SET ARITHABORT OFF 
GO
ALTER DATABASE [Learning_QLBH] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Learning_QLBH] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Learning_QLBH] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Learning_QLBH] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Learning_QLBH] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Learning_QLBH] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Learning_QLBH] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Learning_QLBH] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Learning_QLBH] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Learning_QLBH] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Learning_QLBH] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Learning_QLBH] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Learning_QLBH] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Learning_QLBH] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Learning_QLBH] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Learning_QLBH] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Learning_QLBH] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Learning_QLBH] SET RECOVERY FULL 
GO
ALTER DATABASE [Learning_QLBH] SET  MULTI_USER 
GO
ALTER DATABASE [Learning_QLBH] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Learning_QLBH] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Learning_QLBH] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Learning_QLBH] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Learning_QLBH] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Learning_QLBH] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Learning_QLBH] SET QUERY_STORE = OFF
GO
USE [Learning_QLBH]
GO
/****** Object:  Table [dbo].[BangGia]    Script Date: 2024-06-24 1:12:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangGia](
	[MaBangGia] [int] IDENTITY(1,1) NOT NULL,
	[TenBangGia] [nvarchar](100) NULL,
	[TinhTrang] [char](1) NULL,
	[NgayTao] [date] NULL,
	[NguoiTao] [nvarchar](50) NULL,
 CONSTRAINT [PK_BangGia] PRIMARY KEY CLUSTERED 
(
	[MaBangGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BangGiaChiTiet]    Script Date: 2024-06-24 1:12:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangGiaChiTiet](
	[MaBangGia] [int] NOT NULL,
	[MaSanPham] [varchar](10) NOT NULL,
	[DonGia] [decimal](18, 0) NULL,
 CONSTRAINT [PK_BangGiaChiTiet] PRIMARY KEY CLUSTERED 
(
	[MaBangGia] ASC,
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonDatHang]    Script Date: 2024-06-24 1:12:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonDatHang](
	[MaDatHang] [nchar](10) NOT NULL,
	[NgayDatHang] [date] NULL,
	[MaKhachHang] [nchar](10) NULL,
	[MaBangGia] [int] NULL,
	[NgayTao] [date] NULL,
	[NguoiTao] [nvarchar](50) NULL,
	[NgayGiaoHang] [date] NULL,
	[TinhTrang] [nchar](1) NULL,
	[DaChotDon] [nchar](1) NULL,
 CONSTRAINT [PK_DonDatHang] PRIMARY KEY CLUSTERED 
(
	[MaDatHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonDatHangChiTiet]    Script Date: 2024-06-24 1:12:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonDatHangChiTiet](
	[MaDatHang] [nchar](10) NOT NULL,
	[MaSanPham] [nchar](10) NOT NULL,
	[SoLuongDat] [int] NULL,
	[DonGia] [decimal](18, 0) NULL,
	[ThanhTien] [decimal](18, 0) NULL,
 CONSTRAINT [PK_DonDatHangChiTiet] PRIMARY KEY CLUSTERED 
(
	[MaDatHang] ASC,
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonGiaoHang]    Script Date: 2024-06-24 1:12:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonGiaoHang](
	[MaGiaoHang] [nchar](10) NOT NULL,
	[NgayGiaoHang] [date] NULL,
	[MaKhachHang] [nchar](10) NULL,
	[MaBangGia] [int] NULL,
	[TinhTrang] [nchar](1) NULL,
	[DaGiaoHang] [nchar](1) NULL,
	[NgayTao] [date] NULL,
	[NguoiTao] [nvarchar](50) NULL,
	[MaDatHang] [nchar](10) NULL,
 CONSTRAINT [PK_DonGiaoHang] PRIMARY KEY CLUSTERED 
(
	[MaGiaoHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonGiaoHangChiTiet]    Script Date: 2024-06-24 1:12:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonGiaoHangChiTiet](
	[MaGiaoHang] [nchar](10) NOT NULL,
	[MaSanPham] [nchar](10) NOT NULL,
	[SoLuongDat] [int] NULL,
	[DonGia] [decimal](18, 0) NULL,
	[ThanhTien] [decimal](18, 0) NULL,
 CONSTRAINT [PK_DonGiaoHangChiTiet] PRIMARY KEY CLUSTERED 
(
	[MaGiaoHang] ASC,
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonViTinh]    Script Date: 2024-06-24 1:12:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonViTinh](
	[MaDVT] [nvarchar](2) NOT NULL,
	[TenDVT] [nvarchar](50) NULL,
	[NguoiTao] [nvarchar](50) NULL,
	[NgayTao] [date] NULL,
	[TinhTrang] [char](1) NULL,
 CONSTRAINT [PK_DonViTinh] PRIMARY KEY CLUSTERED 
(
	[MaDVT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 2024-06-24 1:12:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKhachHang] [char](10) NOT NULL,
	[TenKhachHang] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[CCCD] [nvarchar](20) NULL,
	[MaSoThue] [nvarchar](20) NULL,
	[TinhTrang] [char](1) NULL,
	[NgayTao] [date] NULL,
	[NguoiTao] [nvarchar](50) NULL,
	[MaTinhThanh] [varchar](2) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QLDiLai]    Script Date: 2024-06-24 1:12:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QLDiLai](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MaNV] [int] NULL,
	[TenNV] [nvarchar](200) NULL,
	[LyDo] [nvarchar](200) NULL,
	[TimeOut] [datetime] NULL,
	[TimeIn] [datetime] NULL,
	[TongTime] [float] NULL,
	[TongTimeSuDung] [float] NULL,
	[GhiChu] [nvarchar](200) NULL,
	[TrangThai] [nvarchar](200) NULL,
 CONSTRAINT [PK_QLDiLai_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QLLoaiDangKy]    Script Date: 2024-06-24 1:12:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QLLoaiDangKy](
	[Id] [int] NOT NULL,
	[Kieu] [nvarchar](200) NULL,
	[ThoiGian] [int] NULL,
	[SoLan] [int] NULL,
 CONSTRAINT [PK_QLLoaiDangKy_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QLNhanSu]    Script Date: 2024-06-24 1:12:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QLNhanSu](
	[STT] [int] IDENTITY(1,1) NOT NULL,
	[Id] [int] NOT NULL,
	[Ten] [nvarchar](200) NULL,
	[IdTen] [nvarchar](200) NULL,
 CONSTRAINT [PK_QLNhanSu_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QLQuyDinh]    Script Date: 2024-06-24 1:12:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QLQuyDinh](
	[Id] [int] NOT NULL,
	[QuyDinh] [nvarchar](200) NULL,
	[DiemBiTru] [int] NULL,
	[Kieu] [nvarchar](200) NULL,
 CONSTRAINT [PK_QLQuyDinh_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QLVanPhong]    Script Date: 2024-06-24 1:12:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QLVanPhong](
	[Id] [int] NOT NULL,
	[Ten] [nvarchar](200) NULL,
 CONSTRAINT [PK_QLVanPhong_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QLXuongCa]    Script Date: 2024-06-24 1:12:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QLXuongCa](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MaNV] [int] NULL,
	[Ten] [nvarchar](200) NULL,
	[GioLamViec] [datetime] NULL,
	[GioXuongCa] [datetime] NULL,
	[TongGioLam] [float] NULL,
	[TrangThai] [nvarchar](200) NULL,
 CONSTRAINT [PK_QLXuongCa_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuyenDangNhap]    Script Date: 2024-06-24 1:12:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuyenDangNhap](
	[MaQuyen] [char](1) NOT NULL,
	[MoTa] [nvarchar](100) NULL,
	[TinhTrang] [char](1) NULL,
 CONSTRAINT [PK_QuyenDangNhap] PRIMARY KEY CLUSTERED 
(
	[MaQuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 2024-06-24 1:12:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSanPham] [nchar](10) NOT NULL,
	[TenSanPham] [nvarchar](50) NULL,
	[MaDVT] [nvarchar](2) NULL,
	[NgayTao] [date] NULL,
	[NguoiTao] [nvarchar](50) NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 2024-06-24 1:12:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TenDangNhap] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NULL,
	[TenDayDu] [nvarchar](100) NULL,
	[TinhTrang] [char](1) NULL,
	[NgayTao] [date] NULL,
	[MaQuyen] [char](1) NULL,
	[NguoiTao] [nvarchar](50) NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TinhThanh]    Script Date: 2024-06-24 1:12:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TinhThanh](
	[MaTinhThanh] [varchar](2) NOT NULL,
	[TenTinhThanh] [nvarchar](50) NULL,
	[NguoiTao] [varchar](50) NULL,
	[NgayTao] [date] NULL,
	[TinhTrang] [char](1) NULL,
 CONSTRAINT [PK_TinhThanh] PRIMARY KEY CLUSTERED 
(
	[MaTinhThanh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BangGia] ON 

INSERT [dbo].[BangGia] ([MaBangGia], [TenBangGia], [TinhTrang], [NgayTao], [NguoiTao]) VALUES (4, N'Bảng giá ngày 24/04/2024', N'Y', CAST(N'2024-04-24' AS Date), N'trung.vudinh')
INSERT [dbo].[BangGia] ([MaBangGia], [TenBangGia], [TinhTrang], [NgayTao], [NguoiTao]) VALUES (5, N'Bảng giá ngày 25/04/2024', N'Y', CAST(N'2024-04-24' AS Date), N'trung.vudinh')
INSERT [dbo].[BangGia] ([MaBangGia], [TenBangGia], [TinhTrang], [NgayTao], [NguoiTao]) VALUES (7, N'bảng giá ngày 26/04/2024', N'Y', CAST(N'2024-04-27' AS Date), N'trung.vudinh')
SET IDENTITY_INSERT [dbo].[BangGia] OFF
GO
INSERT [dbo].[BangGiaChiTiet] ([MaBangGia], [MaSanPham], [DonGia]) VALUES (4, N'P000000001', CAST(300000 AS Decimal(18, 0)))
INSERT [dbo].[BangGiaChiTiet] ([MaBangGia], [MaSanPham], [DonGia]) VALUES (4, N'P000000002', CAST(500000 AS Decimal(18, 0)))
INSERT [dbo].[BangGiaChiTiet] ([MaBangGia], [MaSanPham], [DonGia]) VALUES (4, N'P000000003', CAST(100000 AS Decimal(18, 0)))
INSERT [dbo].[BangGiaChiTiet] ([MaBangGia], [MaSanPham], [DonGia]) VALUES (4, N'P000000004', CAST(200000 AS Decimal(18, 0)))
GO
INSERT [dbo].[DonDatHang] ([MaDatHang], [NgayDatHang], [MaKhachHang], [MaBangGia], [NgayTao], [NguoiTao], [NgayGiaoHang], [TinhTrang], [DaChotDon]) VALUES (N'1         ', CAST(N'2024-01-01' AS Date), N'KH00000004', 4, CAST(N'2024-01-01' AS Date), N'trung.vudinh', CAST(N'2024-01-01' AS Date), N'Y', N'Y')
INSERT [dbo].[DonDatHang] ([MaDatHang], [NgayDatHang], [MaKhachHang], [MaBangGia], [NgayTao], [NguoiTao], [NgayGiaoHang], [TinhTrang], [DaChotDon]) VALUES (N'2         ', CAST(N'2024-04-26' AS Date), N'KH00000004', 4, CAST(N'2024-04-26' AS Date), N'trung.vudinh', CAST(N'2024-04-26' AS Date), N'Y', N'Y')
INSERT [dbo].[DonDatHang] ([MaDatHang], [NgayDatHang], [MaKhachHang], [MaBangGia], [NgayTao], [NguoiTao], [NgayGiaoHang], [TinhTrang], [DaChotDon]) VALUES (N'3         ', CAST(N'2024-04-27' AS Date), N'KH00000013', 4, CAST(N'2024-04-27' AS Date), N'trung.vudinh', CAST(N'2024-04-27' AS Date), N'Y', N'Y')
INSERT [dbo].[DonDatHang] ([MaDatHang], [NgayDatHang], [MaKhachHang], [MaBangGia], [NgayTao], [NguoiTao], [NgayGiaoHang], [TinhTrang], [DaChotDon]) VALUES (N'4         ', CAST(N'2024-04-27' AS Date), N'KH00000011', 4, CAST(N'2024-04-27' AS Date), N'trung.vudinh', CAST(N'2024-04-27' AS Date), N'Y', N'Y')
GO
INSERT [dbo].[DonDatHangChiTiet] ([MaDatHang], [MaSanPham], [SoLuongDat], [DonGia], [ThanhTien]) VALUES (N'1         ', N'P000000001', 2, CAST(300000 AS Decimal(18, 0)), CAST(600000 AS Decimal(18, 0)))
INSERT [dbo].[DonDatHangChiTiet] ([MaDatHang], [MaSanPham], [SoLuongDat], [DonGia], [ThanhTien]) VALUES (N'1         ', N'P000000002', 3, CAST(500000 AS Decimal(18, 0)), CAST(1500000 AS Decimal(18, 0)))
INSERT [dbo].[DonDatHangChiTiet] ([MaDatHang], [MaSanPham], [SoLuongDat], [DonGia], [ThanhTien]) VALUES (N'4         ', N'P000000001', 2, CAST(300000 AS Decimal(18, 0)), CAST(600000 AS Decimal(18, 0)))
INSERT [dbo].[DonDatHangChiTiet] ([MaDatHang], [MaSanPham], [SoLuongDat], [DonGia], [ThanhTien]) VALUES (N'4         ', N'P000000002', 1, CAST(500000 AS Decimal(18, 0)), CAST(500000 AS Decimal(18, 0)))
GO
INSERT [dbo].[DonViTinh] ([MaDVT], [TenDVT], [NguoiTao], [NgayTao], [TinhTrang]) VALUES (N'01', N'Cái', N'trung.vudinh', CAST(N'2024-01-01' AS Date), N'Y')
INSERT [dbo].[DonViTinh] ([MaDVT], [TenDVT], [NguoiTao], [NgayTao], [TinhTrang]) VALUES (N'02', N'Kg', N'trung.vudinh', CAST(N'2024-01-01' AS Date), N'Y')
INSERT [dbo].[DonViTinh] ([MaDVT], [TenDVT], [NguoiTao], [NgayTao], [TinhTrang]) VALUES (N'03', N'Ðôi', N'trung.vudinh', CAST(N'2024-01-01' AS Date), N'Y')
INSERT [dbo].[DonViTinh] ([MaDVT], [TenDVT], [NguoiTao], [NgayTao], [TinhTrang]) VALUES (N'04', N'Bộ', N'trung.vudinh', CAST(N'2024-01-01' AS Date), N'Y')
INSERT [dbo].[DonViTinh] ([MaDVT], [TenDVT], [NguoiTao], [NgayTao], [TinhTrang]) VALUES (N'05', N'123', N'trung.vudinh', CAST(N'2024-04-24' AS Date), N'Y')
INSERT [dbo].[DonViTinh] ([MaDVT], [TenDVT], [NguoiTao], [NgayTao], [TinhTrang]) VALUES (N'06', N'123', N'trung.vudinh', CAST(N'2024-04-24' AS Date), N'Y')
GO
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [CCCD], [MaSoThue], [TinhTrang], [NgayTao], [NguoiTao], [MaTinhThanh]) VALUES (N'KH00000001', N'Nguyễn Quang Hải', N'111 Xô Viết Nghệ Tĩnh, Phường Thắng Tam, TP.Vũng Tàu, Tỉnh Bà Rịa - Vũng Tàu', N'67534748639', N'11232455456', N'Y', CAST(N'2024-01-01' AS Date), N'trung.vudinh', N'07')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [CCCD], [MaSoThue], [TinhTrang], [NgayTao], [NguoiTao], [MaTinhThanh]) VALUES (N'KH00000002', N'Phan Tấn Tài', N'Số 295, Tân Hiệp, Phường Tân Bình, Thành phố Dĩ An, Tỉnh Bình Dương', N'97846838638', N'42776877474', N'Y', CAST(N'2024-01-01' AS Date), N'trung.vudinh', N'05')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [CCCD], [MaSoThue], [TinhTrang], [NgayTao], [NguoiTao], [MaTinhThanh]) VALUES (N'KH00000003', N'Nguyễn Hoàng Đức', N'16/5, Nguyễn Ảnh Thủ, Khu phố 4, Phường Hiệp Thành, Quận 12, Thành phố Hồ Chí Minh', N'43876897934', N'55543353355', N'Y', CAST(N'2024-01-01' AS Date), N'trung.vudinh', N'01')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [CCCD], [MaSoThue], [TinhTrang], [NgayTao], [NguoiTao], [MaTinhThanh]) VALUES (N'KH00000004', N'Nguyễn Phi Hùng', N'Ninh Trung, Phường Ninh Sơn, Thị xã Tây Ninh, Tỉnh Tây Ninh', N'48676839434', N'90008763335', N'Y', CAST(N'2024-01-01' AS Date), N'trung.vudinh', N'06')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [CCCD], [MaSoThue], [TinhTrang], [NgayTao], [NguoiTao], [MaTinhThanh]) VALUES (N'KH00000005', N'Đặng Văn Lâm', N'318 Đường số 7, Phường Tân Tạo, Quận Bình Tân, Thành phố Hồ Chí Minh', N'47268492843', N'98847843943', N'Y', CAST(N'2024-01-01' AS Date), N'trung.vudinh', N'01')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [CCCD], [MaSoThue], [TinhTrang], [NgayTao], [NguoiTao], [MaTinhThanh]) VALUES (N'KH00000006', N'Đoàn Văn Hậu', N'53A Dương Quảng Hàm, Phường 5, Quận Gò Vấp, Thành phố Hồ Chí Minh', N'54979504544', N'55558842408', N'Y', CAST(N'2024-01-01' AS Date), N'trung.vudinh', N'01')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [CCCD], [MaSoThue], [TinhTrang], [NgayTao], [NguoiTao], [MaTinhThanh]) VALUES (N'KH00000007', N'Phan Văn Đức', N'Khu phố Thạnh Sơn, Thị trấn Phước Bửu,  Huyện Xuyên Mộc, Tỉnh Bà Rịa - Vũng Tàu', N'53998977443', N'42245646666', N'Y', CAST(N'2024-01-01' AS Date), N'trung.vudinh', N'07')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [CCCD], [MaSoThue], [TinhTrang], [NgayTao], [NguoiTao], [MaTinhThanh]) VALUES (N'KH00000008', N'Nguyễn Văn Toàn', N'Bình Long, Xã Thái Bình, Huyện Châu Thành, Tỉnh Tây Ninh', N'90978788334', N'33255653344', N'Y', CAST(N'2024-01-01' AS Date), N'trung.vudinh', N'06')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [CCCD], [MaSoThue], [TinhTrang], [NgayTao], [NguoiTao], [MaTinhThanh]) VALUES (N'KH00000009', N'Lương Văn Khiêm', N'Xã Long Tân, Huyện Dầu Tiếng, Tỉnh Bình Dương', N'43862846834', N'90009989988', N'Y', CAST(N'2024-01-01' AS Date), N'trung.vudinh', N'05')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [CCCD], [MaSoThue], [TinhTrang], [NgayTao], [NguoiTao], [MaTinhThanh]) VALUES (N'KH00000010', N'Nguyễn Tuấn Hoàng', N'Ấp 1A, Xã Thanh Phú, Huyện Bến Lức, Tỉnh Long An', N'09783674837', N'44433357786', N'Y', CAST(N'2024-01-01' AS Date), N'trung.vudinh', N'04')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [CCCD], [MaSoThue], [TinhTrang], [NgayTao], [NguoiTao], [MaTinhThanh]) VALUES (N'KH00000011', N'Trương Lâm', N'Ấp 3, Xã Xuân Tâm, Huyện Xuân Lộc, Tỉnh Đồng Nai', N'38785999444', N'21223324345', N'Y', CAST(N'2024-01-01' AS Date), N'trung.vudinh', N'02')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [CCCD], [MaSoThue], [TinhTrang], [NgayTao], [NguoiTao], [MaTinhThanh]) VALUES (N'KH00000012', N'Trần Tuấn', N'106, KP1, Xuân Bình, TX Long Khánh, Tỉnh Đồng Nai', N'22387947783', N'44433346777', N'Y', CAST(N'2024-01-01' AS Date), N'trung.vudinh', N'02')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [CCCD], [MaSoThue], [TinhTrang], [NgayTao], [NguoiTao], [MaTinhThanh]) VALUES (N'KH00000013', N'Trấn Thành', N'Khu phố 1, Phường Xuân Thanh, Thị xã Long Khánh, Tỉnh Đồng Nai', N'97594008473', N'77667877766', N'Y', CAST(N'2024-01-01' AS Date), N'trung.vudinh', N'02')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [CCCD], [MaSoThue], [TinhTrang], [NgayTao], [NguoiTao], [MaTinhThanh]) VALUES (N'KH00000014', N'Nguyễn Hồ Tấn Tài', N'24/4 Khu phố 2, Phường Tam Hòa, TP.Biên Hòa, Tỉnh Đồng Nai', N'98738794573', N'44456666677', N'Y', CAST(N'2024-01-01' AS Date), N'trung.vudinh', N'02')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [CCCD], [MaSoThue], [TinhTrang], [NgayTao], [NguoiTao], [MaTinhThanh]) VALUES (N'KH00000015', N'Trương Minh Hoàng', N'Xã Cây Gáo, Huyện Trảng Bom, Tỉnh Đồng Nai', N'98843662844', N'34333344677', N'Y', CAST(N'2024-01-01' AS Date), N'trung.vudinh', N'02')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [CCCD], [MaSoThue], [TinhTrang], [NgayTao], [NguoiTao], [MaTinhThanh]) VALUES (N'KH00000016', N'Phạm Văn Tâm', N'Khu phố 4, Phường Hố Nai 1, TP.Biên Hòa, Tỉnh Đồng Nai', N'99877334244', N'00908948943', N'Y', CAST(N'2024-01-01' AS Date), N'trung.vudinh', N'02')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [CCCD], [MaSoThue], [TinhTrang], [NgayTao], [NguoiTao], [MaTinhThanh]) VALUES (N'KH00000017', N'Nguyễn Hữu Thắng', N'332 Tổ 43, Khóm 5, P6, TP Cao Lãnh, Tỉnh Đồng Tháp', N'16432523434', N'09988833234', N'Y', CAST(N'2024-01-01' AS Date), N'trung.vudinh', N'03')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [CCCD], [MaSoThue], [TinhTrang], [NgayTao], [NguoiTao], [MaTinhThanh]) VALUES (N'KH00000018', N'Trương Hoàng Hà', N'Khóm 2, An Thạnh, TX.Hồng Ngự, Tỉnh Đồng Tháp', N'98787644433', N'43444332223', N'Y', CAST(N'2024-01-01' AS Date), N'trung.vudinh', N'03')
GO
SET IDENTITY_INSERT [dbo].[QLDiLai] ON 

INSERT [dbo].[QLDiLai] ([Id], [MaNV], [TenNV], [LyDo], [TimeOut], [TimeIn], [TongTime], [TongTimeSuDung], [GhiChu], [TrangThai]) VALUES (35, 1, N'1 - Nam', N'Ăn sáng', CAST(N'2024-05-30T23:49:32.710' AS DateTime), CAST(N'2024-05-30T23:49:53.523' AS DateTime), -34.64, NULL, NULL, N'Đã vào')
INSERT [dbo].[QLDiLai] ([Id], [MaNV], [TenNV], [LyDo], [TimeOut], [TimeIn], [TongTime], [TongTimeSuDung], [GhiChu], [TrangThai]) VALUES (36, 1, N'1 - Nam', N'Ăn trưa', CAST(N'2024-05-31T23:52:02.000' AS DateTime), CAST(N'2024-05-31T00:02:00.967' AS DateTime), -1465, NULL, NULL, N'Đã vào')
INSERT [dbo].[QLDiLai] ([Id], [MaNV], [TenNV], [LyDo], [TimeOut], [TimeIn], [TongTime], [TongTimeSuDung], [GhiChu], [TrangThai]) VALUES (37, 1, N'1 - Nam', N'Hút thuốc', CAST(N'2024-05-31T00:58:24.350' AS DateTime), CAST(N'2024-05-31T01:02:35.703' AS DateTime), -6, NULL, NULL, N'Đã vào')
INSERT [dbo].[QLDiLai] ([Id], [MaNV], [TenNV], [LyDo], [TimeOut], [TimeIn], [TongTime], [TongTimeSuDung], [GhiChu], [TrangThai]) VALUES (38, 1, N'1 - Nam', N'Ăn tối', CAST(N'2024-05-31T00:58:30.337' AS DateTime), CAST(N'2024-06-01T21:11:33.497' AS DateTime), 2618, NULL, NULL, N'Đã vào')
INSERT [dbo].[QLDiLai] ([Id], [MaNV], [TenNV], [LyDo], [TimeOut], [TimeIn], [TongTime], [TongTimeSuDung], [GhiChu], [TrangThai]) VALUES (39, 1, N'1 - Nam', N'Tiểu tiện', CAST(N'2024-05-31T01:00:00.993' AS DateTime), CAST(N'2024-05-31T01:02:40.810' AS DateTime), -7, NULL, NULL, N'Đã vào')
INSERT [dbo].[QLDiLai] ([Id], [MaNV], [TenNV], [LyDo], [TimeOut], [TimeIn], [TongTime], [TongTimeSuDung], [GhiChu], [TrangThai]) VALUES (40, 1, N'1 - Nam', N'Khác', CAST(N'2024-05-31T01:00:47.377' AS DateTime), CAST(N'2024-06-01T21:11:32.640' AS DateTime), 2646, NULL, NULL, N'Đã vào')
INSERT [dbo].[QLDiLai] ([Id], [MaNV], [TenNV], [LyDo], [TimeOut], [TimeIn], [TongTime], [TongTimeSuDung], [GhiChu], [TrangThai]) VALUES (41, 1, N'Nam', N'Tiểu tiện', CAST(N'2024-05-31T03:45:20.770' AS DateTime), CAST(N'2024-05-31T21:28:34.627' AS DateTime), 1053, NULL, NULL, N'Đã vào')
INSERT [dbo].[QLDiLai] ([Id], [MaNV], [TenNV], [LyDo], [TimeOut], [TimeIn], [TongTime], [TongTimeSuDung], [GhiChu], [TrangThai]) VALUES (42, 2, N'Vân', N'Ăn sáng', CAST(N'2024-05-31T03:49:06.037' AS DateTime), CAST(N'2024-05-31T03:59:41.947' AS DateTime), -24, NULL, NULL, N'Đã vào')
INSERT [dbo].[QLDiLai] ([Id], [MaNV], [TenNV], [LyDo], [TimeOut], [TimeIn], [TongTime], [TongTimeSuDung], [GhiChu], [TrangThai]) VALUES (43, 1, N'Nam', N'Ăn sáng', CAST(N'2024-05-31T21:28:43.180' AS DateTime), CAST(N'2024-06-01T21:11:31.190' AS DateTime), 1388, NULL, NULL, N'Đã vào')
INSERT [dbo].[QLDiLai] ([Id], [MaNV], [TenNV], [LyDo], [TimeOut], [TimeIn], [TongTime], [TongTimeSuDung], [GhiChu], [TrangThai]) VALUES (44, 3, N'Trọng', N'Ăn sáng', CAST(N'2024-06-01T06:03:34.193' AS DateTime), CAST(N'2024-06-01T06:04:16.177' AS DateTime), -34, NULL, NULL, N'Đã vào')
INSERT [dbo].[QLDiLai] ([Id], [MaNV], [TenNV], [LyDo], [TimeOut], [TimeIn], [TongTime], [TongTimeSuDung], [GhiChu], [TrangThai]) VALUES (45, 2, N'Vân', N'Ăn sáng', CAST(N'2024-06-01T20:13:43.433' AS DateTime), CAST(N'2024-06-01T21:11:25.247' AS DateTime), 23, NULL, NULL, N'Đã vào')
INSERT [dbo].[QLDiLai] ([Id], [MaNV], [TenNV], [LyDo], [TimeOut], [TimeIn], [TongTime], [TongTimeSuDung], [GhiChu], [TrangThai]) VALUES (46, 12, N'Nguyên', N'Ăn sáng', CAST(N'2024-06-01T21:11:59.833' AS DateTime), CAST(N'2024-06-01T21:14:00.480' AS DateTime), -33, NULL, N'', N'Đã vào')
INSERT [dbo].[QLDiLai] ([Id], [MaNV], [TenNV], [LyDo], [TimeOut], [TimeIn], [TongTime], [TongTimeSuDung], [GhiChu], [TrangThai]) VALUES (47, 12, N'Nguyên', N'Hút thuốc', CAST(N'2024-06-01T21:14:06.530' AS DateTime), NULL, NULL, NULL, NULL, N'Đã ra')
INSERT [dbo].[QLDiLai] ([Id], [MaNV], [TenNV], [LyDo], [TimeOut], [TimeIn], [TongTime], [TongTimeSuDung], [GhiChu], [TrangThai]) VALUES (48, 1, N'Nam', N'早餐（35 分钟）- Breakfast (35 minutes)', CAST(N'2024-06-01T22:17:46.357' AS DateTime), CAST(N'2024-06-01T22:18:02.883' AS DateTime), -35, NULL, NULL, N'Đã vào')
INSERT [dbo].[QLDiLai] ([Id], [MaNV], [TenNV], [LyDo], [TimeOut], [TimeIn], [TongTime], [TongTimeSuDung], [GhiChu], [TrangThai]) VALUES (49, 2, N'Vân', N'早餐（35 分钟）- Breakfast (35 minutes)', CAST(N'2024-06-01T22:19:08.207' AS DateTime), CAST(N'2024-06-01T22:19:21.667' AS DateTime), -35, NULL, N'123', N'Đã vào')
INSERT [dbo].[QLDiLai] ([Id], [MaNV], [TenNV], [LyDo], [TimeOut], [TimeIn], [TongTime], [TongTimeSuDung], [GhiChu], [TrangThai]) VALUES (1046, 3, N'Trọng', N'早餐（35 分钟）- Breakfast (35 minutes)', CAST(N'2024-06-05T15:00:44.693' AS DateTime), CAST(N'2024-06-05T15:01:02.557' AS DateTime), -35, NULL, N'1234', N'Đã vào')
INSERT [dbo].[QLDiLai] ([Id], [MaNV], [TenNV], [LyDo], [TimeOut], [TimeIn], [TongTime], [TongTimeSuDung], [GhiChu], [TrangThai]) VALUES (1047, 3, N'Trọng', N'午餐（35 分钟）- Lunch (35 minutes)', CAST(N'2024-06-05T15:01:09.377' AS DateTime), CAST(N'2024-06-05T15:01:13.767' AS DateTime), -35, NULL, N'1234', N'Đã vào')
INSERT [dbo].[QLDiLai] ([Id], [MaNV], [TenNV], [LyDo], [TimeOut], [TimeIn], [TongTime], [TongTimeSuDung], [GhiChu], [TrangThai]) VALUES (1048, 1, N'Nam', N'早餐（35 分钟）- Breakfast (35 minutes)', CAST(N'2024-06-05T22:19:47.653' AS DateTime), NULL, NULL, NULL, NULL, N'Đã ra')
INSERT [dbo].[QLDiLai] ([Id], [MaNV], [TenNV], [LyDo], [TimeOut], [TimeIn], [TongTime], [TongTimeSuDung], [GhiChu], [TrangThai]) VALUES (1049, 11235, N'Hải', N'早餐（35 分钟）- Breakfast (35 minutes)', CAST(N'2024-06-15T18:47:11.393' AS DateTime), CAST(N'2024-06-17T06:59:26.690' AS DateTime), 2137, NULL, NULL, N'Đã vào')
INSERT [dbo].[QLDiLai] ([Id], [MaNV], [TenNV], [LyDo], [TimeOut], [TimeIn], [TongTime], [TongTimeSuDung], [GhiChu], [TrangThai]) VALUES (1050, 2, N'Hải', N'早餐（35 分钟）- Breakfast (35 minutes)', CAST(N'2024-06-17T23:02:50.550' AS DateTime), CAST(N'2024-06-17T23:29:32.310' AS DateTime), -8, NULL, NULL, N'Đã vào')
INSERT [dbo].[QLDiLai] ([Id], [MaNV], [TenNV], [LyDo], [TimeOut], [TimeIn], [TongTime], [TongTimeSuDung], [GhiChu], [TrangThai]) VALUES (1051, 4, N'Vũ', N'早餐（35 分钟）- Breakfast (35 minutes)', CAST(N'2024-06-17T23:04:39.023' AS DateTime), CAST(N'2024-06-17T23:18:10.860' AS DateTime), -21, NULL, NULL, N'Đã vào')
INSERT [dbo].[QLDiLai] ([Id], [MaNV], [TenNV], [LyDo], [TimeOut], [TimeIn], [TongTime], [TongTimeSuDung], [GhiChu], [TrangThai]) VALUES (1052, 8, N'cccc', N'早餐（35 分钟）- Breakfast (35 minutes)', CAST(N'2024-06-17T23:04:49.453' AS DateTime), CAST(N'2024-06-17T23:16:54.007' AS DateTime), -23, NULL, NULL, N'Đã vào')
INSERT [dbo].[QLDiLai] ([Id], [MaNV], [TenNV], [LyDo], [TimeOut], [TimeIn], [TongTime], [TongTimeSuDung], [GhiChu], [TrangThai]) VALUES (1053, 1, N'Nam', N'早餐（35 分钟）- Breakfast (35 minutes)', CAST(N'2024-06-17T23:13:47.407' AS DateTime), CAST(N'2024-06-17T23:13:55.077' AS DateTime), -35, NULL, NULL, N'Đã vào')
INSERT [dbo].[QLDiLai] ([Id], [MaNV], [TenNV], [LyDo], [TimeOut], [TimeIn], [TongTime], [TongTimeSuDung], [GhiChu], [TrangThai]) VALUES (1054, 1, N'Nam', N'午餐（35 分钟）- Lunch (35 minutes)', CAST(N'2024-06-17T23:14:13.077' AS DateTime), CAST(N'2024-06-17T23:14:15.867' AS DateTime), -35, NULL, NULL, N'Đã vào')
INSERT [dbo].[QLDiLai] ([Id], [MaNV], [TenNV], [LyDo], [TimeOut], [TimeIn], [TongTime], [TongTimeSuDung], [GhiChu], [TrangThai]) VALUES (1055, 1, N'Nam', N'晚餐（35 分钟）- Dinner (35 minutes)', CAST(N'2024-06-17T23:18:46.927' AS DateTime), CAST(N'2024-06-19T21:58:54.390' AS DateTime), 2765, NULL, N'1234', N'Đã vào')
INSERT [dbo].[QLDiLai] ([Id], [MaNV], [TenNV], [LyDo], [TimeOut], [TimeIn], [TongTime], [TongTimeSuDung], [GhiChu], [TrangThai]) VALUES (1056, 3, N'Nam', N'早餐（35 分钟）- Breakfast (35 minutes)', CAST(N'2024-06-20T20:58:34.693' AS DateTime), CAST(N'2024-06-20T20:58:39.377' AS DateTime), -35, NULL, NULL, N'Đã vào')
INSERT [dbo].[QLDiLai] ([Id], [MaNV], [TenNV], [LyDo], [TimeOut], [TimeIn], [TongTime], [TongTimeSuDung], [GhiChu], [TrangThai]) VALUES (1057, 3, N'Nam', N'晚餐（35 分钟）- Dinner (35 minutes)', CAST(N'2024-06-20T20:58:48.253' AS DateTime), CAST(N'2024-06-20T20:58:57.307' AS DateTime), -35, NULL, NULL, N'Đã vào')
INSERT [dbo].[QLDiLai] ([Id], [MaNV], [TenNV], [LyDo], [TimeOut], [TimeIn], [TongTime], [TongTimeSuDung], [GhiChu], [TrangThai]) VALUES (1058, 2, N'Hải', N'早餐（35 分钟）- Breakfast (35 minutes)', CAST(N'2024-06-20T22:56:48.713' AS DateTime), CAST(N'2024-06-20T22:56:57.957' AS DateTime), -35, NULL, NULL, N'Đã vào')
INSERT [dbo].[QLDiLai] ([Id], [MaNV], [TenNV], [LyDo], [TimeOut], [TimeIn], [TongTime], [TongTimeSuDung], [GhiChu], [TrangThai]) VALUES (1059, 2, N'Hải', N'午餐（35 分钟）- Lunch (35 minutes)', CAST(N'2024-06-20T22:57:28.000' AS DateTime), NULL, NULL, NULL, NULL, N'Đã ra')
INSERT [dbo].[QLDiLai] ([Id], [MaNV], [TenNV], [LyDo], [TimeOut], [TimeIn], [TongTime], [TongTimeSuDung], [GhiChu], [TrangThai]) VALUES (1060, 23242526, N'李明贵', N'早餐（35 分钟）- Breakfast (35 minutes)', CAST(N'2024-06-19T23:01:19.483' AS DateTime), CAST(N'2024-06-19T23:01:37.297' AS DateTime), -35, NULL, NULL, N'Đã vào')
INSERT [dbo].[QLDiLai] ([Id], [MaNV], [TenNV], [LyDo], [TimeOut], [TimeIn], [TongTime], [TongTimeSuDung], [GhiChu], [TrangThai]) VALUES (1061, 23242526, N'李明贵', N'午餐（35 分钟）- Lunch (35 minutes)', CAST(N'2024-06-20T23:04:58.080' AS DateTime), CAST(N'2024-06-20T23:05:01.217' AS DateTime), -35, NULL, NULL, N'Đã vào')
INSERT [dbo].[QLDiLai] ([Id], [MaNV], [TenNV], [LyDo], [TimeOut], [TimeIn], [TongTime], [TongTimeSuDung], [GhiChu], [TrangThai]) VALUES (1062, 23242526, N'李明贵', N'晚餐（35 分钟）- Dinner (35 minutes)', CAST(N'2024-06-20T23:05:09.830' AS DateTime), CAST(N'2024-06-20T23:05:11.447' AS DateTime), -35, NULL, NULL, N'Đã vào')
INSERT [dbo].[QLDiLai] ([Id], [MaNV], [TenNV], [LyDo], [TimeOut], [TimeIn], [TongTime], [TongTimeSuDung], [GhiChu], [TrangThai]) VALUES (1063, 23242526, N'李明贵', N'抽烟（10 分钟）- Smoking (10 minutes)', CAST(N'2024-06-20T23:05:45.393' AS DateTime), NULL, NULL, NULL, NULL, N'Đã ra')
SET IDENTITY_INSERT [dbo].[QLDiLai] OFF
GO
INSERT [dbo].[QLLoaiDangKy] ([Id], [Kieu], [ThoiGian], [SoLan]) VALUES (1, N'早餐（35 分钟）- Breakfast (35 minutes)', 35, 1)
INSERT [dbo].[QLLoaiDangKy] ([Id], [Kieu], [ThoiGian], [SoLan]) VALUES (2, N'午餐（35 分钟）- Lunch (35 minutes)', 35, 1)
INSERT [dbo].[QLLoaiDangKy] ([Id], [Kieu], [ThoiGian], [SoLan]) VALUES (3, N'晚餐（35 分钟）- Dinner (35 minutes)', 35, 1)
INSERT [dbo].[QLLoaiDangKy] ([Id], [Kieu], [ThoiGian], [SoLan]) VALUES (4, N'抽烟（10 分钟）- Smoking (10 minutes)', 10, 1)
INSERT [dbo].[QLLoaiDangKy] ([Id], [Kieu], [ThoiGian], [SoLan]) VALUES (5, N'厕所小（10 分钟）- CR (10 minutes)', 10, 3)
INSERT [dbo].[QLLoaiDangKy] ([Id], [Kieu], [ThoiGian], [SoLan]) VALUES (6, N'厕所大（15 分钟）- CR (15 minutes)', 15, 1)
INSERT [dbo].[QLLoaiDangKy] ([Id], [Kieu], [ThoiGian], [SoLan]) VALUES (7, N'其他（5 分钟）- Other (5 minutes)', 5, 1)
GO
SET IDENTITY_INSERT [dbo].[QLNhanSu] ON 

INSERT [dbo].[QLNhanSu] ([STT], [Id], [Ten], [IdTen]) VALUES (10, 1, N'Nam', N'1 - Nam')
INSERT [dbo].[QLNhanSu] ([STT], [Id], [Ten], [IdTen]) VALUES (11, 2, N'Hải', N'2 - Hải')
INSERT [dbo].[QLNhanSu] ([STT], [Id], [Ten], [IdTen]) VALUES (12, 3, N'Nam', N'3 - Nam')
INSERT [dbo].[QLNhanSu] ([STT], [Id], [Ten], [IdTen]) VALUES (13, 4, N'Vũ', N'4 - Vũ')
INSERT [dbo].[QLNhanSu] ([STT], [Id], [Ten], [IdTen]) VALUES (14, 5, N'Anh', N'5 - Anh')
INSERT [dbo].[QLNhanSu] ([STT], [Id], [Ten], [IdTen]) VALUES (17, 6, N'aaa', N'6 - aaa')
INSERT [dbo].[QLNhanSu] ([STT], [Id], [Ten], [IdTen]) VALUES (18, 7, N'bbbbbb', N'7 - bbbbbb')
INSERT [dbo].[QLNhanSu] ([STT], [Id], [Ten], [IdTen]) VALUES (19, 8, N'cccc', N'8 - cccc')
INSERT [dbo].[QLNhanSu] ([STT], [Id], [Ten], [IdTen]) VALUES (20, 9, N'ddddd', N'9 - ddddd')
INSERT [dbo].[QLNhanSu] ([STT], [Id], [Ten], [IdTen]) VALUES (21, 10, N'Nam', N'10 - Nam')
INSERT [dbo].[QLNhanSu] ([STT], [Id], [Ten], [IdTen]) VALUES (15, 11, N'hải', N'11 - hải')
INSERT [dbo].[QLNhanSu] ([STT], [Id], [Ten], [IdTen]) VALUES (16, 12, N'Nguyên', N'12 - Nguyên')
INSERT [dbo].[QLNhanSu] ([STT], [Id], [Ten], [IdTen]) VALUES (23, 11235, N'Nam', N'11235 - Nam')
INSERT [dbo].[QLNhanSu] ([STT], [Id], [Ten], [IdTen]) VALUES (22, 1234567, N'abc', N'1234567 - abc')
INSERT [dbo].[QLNhanSu] ([STT], [Id], [Ten], [IdTen]) VALUES (24, 23242526, N'李明贵', N'23242526 - 李明贵')
SET IDENTITY_INSERT [dbo].[QLNhanSu] OFF
GO
INSERT [dbo].[QLQuyDinh] ([Id], [QuyDinh], [DiemBiTru], [Kieu]) VALUES (1, N'Đi muộn', 4, N'上班 - Clock - in')
INSERT [dbo].[QLQuyDinh] ([Id], [QuyDinh], [DiemBiTru], [Kieu]) VALUES (2, N'Bấm điện thoại 11111111111111111111', 2, N'上班 - Clock - in')
INSERT [dbo].[QLQuyDinh] ([Id], [QuyDinh], [DiemBiTru], [Kieu]) VALUES (3, N'nam123123 112222222222222222', 3, N'打卡 - Punch in/out')
GO
INSERT [dbo].[QLVanPhong] ([Id], [Ten]) VALUES (1, N'行政部')
GO
SET IDENTITY_INSERT [dbo].[QLXuongCa] ON 

INSERT [dbo].[QLXuongCa] ([Id], [MaNV], [Ten], [GioLamViec], [GioXuongCa], [TongGioLam], [TrangThai]) VALUES (51, 1, N'Nam', CAST(N'2024-06-01T22:12:09.360' AS DateTime), CAST(N'2024-06-15T18:47:20.510' AS DateTime), 332.6, N'Đã xuống ca')
INSERT [dbo].[QLXuongCa] ([Id], [MaNV], [Ten], [GioLamViec], [GioXuongCa], [TongGioLam], [TrangThai]) VALUES (52, 2, N'Vân', CAST(N'2024-06-01T22:12:56.093' AS DateTime), CAST(N'2024-06-05T15:00:32.930' AS DateTime), 88.8, N'Đã xuống ca')
INSERT [dbo].[QLXuongCa] ([Id], [MaNV], [Ten], [GioLamViec], [GioXuongCa], [TongGioLam], [TrangThai]) VALUES (1045, 3, N'Trọng', CAST(N'2024-06-05T15:00:36.327' AS DateTime), CAST(N'2024-06-15T18:42:05.293' AS DateTime), 243.7, N'Đã xuống ca')
INSERT [dbo].[QLXuongCa] ([Id], [MaNV], [Ten], [GioLamViec], [GioXuongCa], [TongGioLam], [TrangThai]) VALUES (1046, 1, N'Nam', CAST(N'2024-06-05T22:19:37.977' AS DateTime), CAST(N'2024-06-15T18:42:03.190' AS DateTime), 236.4, N'Đã xuống ca')
INSERT [dbo].[QLXuongCa] ([Id], [MaNV], [Ten], [GioLamViec], [GioXuongCa], [TongGioLam], [TrangThai]) VALUES (1047, 11235, N'Hải', CAST(N'2024-06-15T18:42:47.503' AS DateTime), CAST(N'2024-06-17T06:59:30.337' AS DateTime), 36.3, N'Đã xuống ca')
INSERT [dbo].[QLXuongCa] ([Id], [MaNV], [Ten], [GioLamViec], [GioXuongCa], [TongGioLam], [TrangThai]) VALUES (1048, 1, N'Nam', CAST(N'2024-06-17T22:51:26.647' AS DateTime), CAST(N'2024-06-19T22:05:20.490' AS DateTime), 47.2, N'Đã xuống ca')
INSERT [dbo].[QLXuongCa] ([Id], [MaNV], [Ten], [GioLamViec], [GioXuongCa], [TongGioLam], [TrangThai]) VALUES (1049, 2, N'Hải', CAST(N'2024-06-17T22:51:35.900' AS DateTime), CAST(N'2024-06-18T22:40:06.440' AS DateTime), 23.8, N'Đã xuống ca')
INSERT [dbo].[QLXuongCa] ([Id], [MaNV], [Ten], [GioLamViec], [GioXuongCa], [TongGioLam], [TrangThai]) VALUES (1050, 4, N'Vũ', CAST(N'2024-06-17T22:54:06.127' AS DateTime), NULL, NULL, N'Đang làm việc')
INSERT [dbo].[QLXuongCa] ([Id], [MaNV], [Ten], [GioLamViec], [GioXuongCa], [TongGioLam], [TrangThai]) VALUES (1051, 12, N'Nguyên', CAST(N'2024-06-17T22:54:59.677' AS DateTime), NULL, NULL, N'Đang làm việc')
INSERT [dbo].[QLXuongCa] ([Id], [MaNV], [Ten], [GioLamViec], [GioXuongCa], [TongGioLam], [TrangThai]) VALUES (1052, 6, N'aaa', CAST(N'2024-06-17T22:56:03.447' AS DateTime), NULL, NULL, N'Đang làm việc')
INSERT [dbo].[QLXuongCa] ([Id], [MaNV], [Ten], [GioLamViec], [GioXuongCa], [TongGioLam], [TrangThai]) VALUES (1053, 8, N'cccc', CAST(N'2024-06-17T22:57:43.070' AS DateTime), NULL, NULL, N'Đang làm việc')
INSERT [dbo].[QLXuongCa] ([Id], [MaNV], [Ten], [GioLamViec], [GioXuongCa], [TongGioLam], [TrangThai]) VALUES (1054, 9, N'ddddd', CAST(N'2024-06-17T23:00:03.317' AS DateTime), CAST(N'2024-06-17T23:02:00.437' AS DateTime), 0, N'Đã xuống ca')
INSERT [dbo].[QLXuongCa] ([Id], [MaNV], [Ten], [GioLamViec], [GioXuongCa], [TongGioLam], [TrangThai]) VALUES (1055, 3, N'Nam', CAST(N'2024-06-18T19:56:00.320' AS DateTime), CAST(N'2024-06-20T22:56:27.990' AS DateTime), 51, N'Đã xuống ca')
INSERT [dbo].[QLXuongCa] ([Id], [MaNV], [Ten], [GioLamViec], [GioXuongCa], [TongGioLam], [TrangThai]) VALUES (1056, 11, N'hải', CAST(N'2024-06-18T22:40:22.017' AS DateTime), CAST(N'2024-06-18T22:40:24.687' AS DateTime), 0, N'Đã xuống ca')
INSERT [dbo].[QLXuongCa] ([Id], [MaNV], [Ten], [GioLamViec], [GioXuongCa], [TongGioLam], [TrangThai]) VALUES (1057, 9, N'ddddd', CAST(N'2024-06-18T22:40:56.697' AS DateTime), CAST(N'2024-06-18T22:40:58.807' AS DateTime), 0, N'Đã xuống ca')
INSERT [dbo].[QLXuongCa] ([Id], [MaNV], [Ten], [GioLamViec], [GioXuongCa], [TongGioLam], [TrangThai]) VALUES (1058, 11235, N'Nam', CAST(N'2024-06-19T00:00:34.537' AS DateTime), CAST(N'2024-06-19T22:05:39.223' AS DateTime), 0.1, N'Đã xuống ca')
INSERT [dbo].[QLXuongCa] ([Id], [MaNV], [Ten], [GioLamViec], [GioXuongCa], [TongGioLam], [TrangThai]) VALUES (1059, 1, N'Nam', CAST(N'2024-06-20T22:55:47.777' AS DateTime), CAST(N'2024-06-20T22:55:55.447' AS DateTime), 0, N'Đã xuống ca')
INSERT [dbo].[QLXuongCa] ([Id], [MaNV], [Ten], [GioLamViec], [GioXuongCa], [TongGioLam], [TrangThai]) VALUES (1060, 2, N'Hải', CAST(N'2024-06-20T22:56:39.257' AS DateTime), NULL, NULL, N'Đang làm việc')
INSERT [dbo].[QLXuongCa] ([Id], [MaNV], [Ten], [GioLamViec], [GioXuongCa], [TongGioLam], [TrangThai]) VALUES (1061, 23242526, N'李明贵', CAST(N'2024-06-19T23:00:59.970' AS DateTime), NULL, NULL, N'Đang làm việc')
SET IDENTITY_INSERT [dbo].[QLXuongCa] OFF
GO
INSERT [dbo].[QuyenDangNhap] ([MaQuyen], [MoTa], [TinhTrang]) VALUES (N'A', N'Quản tri', N'Y')
INSERT [dbo].[QuyenDangNhap] ([MaQuyen], [MoTa], [TinhTrang]) VALUES (N'U', N'Người sử dụng', N'Y')
GO
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDVT], [NgayTao], [NguoiTao]) VALUES (N'P000000001', N'Balo', N'01', CAST(N'2024-01-01' AS Date), N'trung.vudinh')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDVT], [NgayTao], [NguoiTao]) VALUES (N'P000000002', N'Túi xách', N'01', CAST(N'2024-01-01' AS Date), N'trung.vudinh')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDVT], [NgayTao], [NguoiTao]) VALUES (N'P000000003', N'Áo thun', N'01', CAST(N'2024-01-01' AS Date), N'trung.vudinh')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDVT], [NgayTao], [NguoiTao]) VALUES (N'P000000004', N'Quần tây', N'01', CAST(N'2024-01-01' AS Date), N'trung.vudinh')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDVT], [NgayTao], [NguoiTao]) VALUES (N'P000000005', N'Vải vụn', N'02', CAST(N'2024-01-01' AS Date), N'trung.vudinh')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDVT], [NgayTao], [NguoiTao]) VALUES (N'P000000006', N'Giày Nike', N'03', CAST(N'2024-01-01' AS Date), N'trung.vudinh')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDVT], [NgayTao], [NguoiTao]) VALUES (N'P000000007', N'Quần Short', N'01', CAST(N'2024-01-01' AS Date), N'trung.vudinh')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDVT], [NgayTao], [NguoiTao]) VALUES (N'P000000008', N'Áo ba lỗ', N'01', CAST(N'2024-01-01' AS Date), N'trung.vudinh')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDVT], [NgayTao], [NguoiTao]) VALUES (N'P000000009', N'Đồ ngủ', N'04', CAST(N'2024-01-01' AS Date), N'trung.vudinh')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDVT], [NgayTao], [NguoiTao]) VALUES (N'P000000010', N'Vali kéo', N'01', CAST(N'2024-01-01' AS Date), N'trung.vudinh')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDVT], [NgayTao], [NguoiTao]) VALUES (N'P000000011', N'Mũ lưỡi trai', N'01', CAST(N'2024-01-01' AS Date), N'trung.vudinh')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDVT], [NgayTao], [NguoiTao]) VALUES (N'P000000012', N'Vớ', N'03', CAST(N'2024-01-01' AS Date), N'trung.vudinh')
GO
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [TenDayDu], [TinhTrang], [NgayTao], [MaQuyen], [NguoiTao]) VALUES (N'nam', N'123', N'Nguyễn nam', N'Y', CAST(N'2024-06-20' AS Date), N'U', N'trung.vudinh')
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [TenDayDu], [TinhTrang], [NgayTao], [MaQuyen], [NguoiTao]) VALUES (N'nam.nguyenhoai', N'123456', N'Nguyễn Hoài Nam', N'Y', CAST(N'2024-01-01' AS Date), N'U', N'trung.vudinh')
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [TenDayDu], [TinhTrang], [NgayTao], [MaQuyen], [NguoiTao]) VALUES (N'trung.vudinh', N'123456', N'Vũ Đình Trung', N'Y', CAST(N'2024-02-25' AS Date), N'A', N'trung.vudinh')
GO
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh], [NguoiTao], [NgayTao], [TinhTrang]) VALUES (N'01', N'TP Hồ Chí Minh', N'trung.vudinh', CAST(N'2024-01-01' AS Date), N'Y')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh], [NguoiTao], [NgayTao], [TinhTrang]) VALUES (N'02', N'Đồng Nai', N'trung.vudinh', CAST(N'2024-01-01' AS Date), N'Y')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh], [NguoiTao], [NgayTao], [TinhTrang]) VALUES (N'03', N'Đồng Tháp', N'trung.vudinh', CAST(N'2024-01-01' AS Date), N'Y')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh], [NguoiTao], [NgayTao], [TinhTrang]) VALUES (N'04', N'Long An', N'trung.vudinh', CAST(N'2024-01-01' AS Date), N'Y')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh], [NguoiTao], [NgayTao], [TinhTrang]) VALUES (N'05', N'Bình Dương', N'trung.vudinh', CAST(N'2024-01-01' AS Date), N'Y')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh], [NguoiTao], [NgayTao], [TinhTrang]) VALUES (N'06', N'Tây Ninh', N'trung.vudinh', CAST(N'2024-01-01' AS Date), N'Y')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh], [NguoiTao], [NgayTao], [TinhTrang]) VALUES (N'07', N'Bà Rịa Vũng Tàu', N'trung.vudinh', CAST(N'2024-01-01' AS Date), N'Y')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh], [NguoiTao], [NgayTao], [TinhTrang]) VALUES (N'08', N'An Giang', N'trung.vudinh', CAST(N'2024-01-01' AS Date), N'Y')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh], [NguoiTao], [NgayTao], [TinhTrang]) VALUES (N'09', N'Đồng Tháp', N'trung.vudinh', CAST(N'2024-01-01' AS Date), N'Y')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh], [NguoiTao], [NgayTao], [TinhTrang]) VALUES (N'10', N'Cần Thơ', N'trung.vudinh', CAST(N'2024-01-01' AS Date), N'Y')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh], [NguoiTao], [NgayTao], [TinhTrang]) VALUES (N'11', N'Bắc Giang', N'trung.vudinh', CAST(N'2024-01-01' AS Date), N'Y')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh], [NguoiTao], [NgayTao], [TinhTrang]) VALUES (N'12', N'Hà Nội', N'trung.vudinh', CAST(N'2024-01-01' AS Date), N'Y')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh], [NguoiTao], [NgayTao], [TinhTrang]) VALUES (N'13', N'Hà Giang', N'trung.vudinh', CAST(N'2024-01-01' AS Date), N'Y')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh], [NguoiTao], [NgayTao], [TinhTrang]) VALUES (N'14', N'Vĩnh Phúc', N'trung.vudinh', CAST(N'2024-01-01' AS Date), N'Y')
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Y: Dang su dung: N khong su dung' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BangGia', @level2type=N'COLUMN',@level2name=N'TinhTrang'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Y: Don active; N: don bi xoa' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DonDatHang', @level2type=N'COLUMN',@level2name=N'TinhTrang'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Y: Khach hang chot don mua de giao hang; N: Don dang trong du kien' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DonDatHang', @level2type=N'COLUMN',@level2name=N'DaChotDon'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Y: Don con active: N Don bi xoa' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DonGiaoHang', @level2type=N'COLUMN',@level2name=N'TinhTrang'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Y: Da giao hang cho khach; N chua giao hang' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DonGiaoHang', @level2type=N'COLUMN',@level2name=N'DaGiaoHang'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'A: Quản trị hệ thống; S: Người dùng' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TaiKhoan', @level2type=N'COLUMN',@level2name=N'MaQuyen'
GO
USE [master]
GO
ALTER DATABASE [Learning_QLBH] SET  READ_WRITE 
GO

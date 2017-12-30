USE [master]
GO
/****** Object:  Database [QLMuaBanHangDienTu]    Script Date: 31-Dec-17 0:11:48 ******/
CREATE DATABASE [QLMuaBanHangDienTu] ON  PRIMARY 
( NAME = N'QLMuaBanHangDienTu', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\QLMuaBanHangDienTu.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLMuaBanHangDienTu_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\QLMuaBanHangDienTu_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLMuaBanHangDienTu].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLMuaBanHangDienTu] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLMuaBanHangDienTu] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLMuaBanHangDienTu] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLMuaBanHangDienTu] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLMuaBanHangDienTu] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLMuaBanHangDienTu] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLMuaBanHangDienTu] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLMuaBanHangDienTu] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLMuaBanHangDienTu] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLMuaBanHangDienTu] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLMuaBanHangDienTu] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLMuaBanHangDienTu] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLMuaBanHangDienTu] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLMuaBanHangDienTu] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLMuaBanHangDienTu] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLMuaBanHangDienTu] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLMuaBanHangDienTu] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLMuaBanHangDienTu] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLMuaBanHangDienTu] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLMuaBanHangDienTu] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLMuaBanHangDienTu] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLMuaBanHangDienTu] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLMuaBanHangDienTu] SET RECOVERY FULL 
GO
ALTER DATABASE [QLMuaBanHangDienTu] SET  MULTI_USER 
GO
ALTER DATABASE [QLMuaBanHangDienTu] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLMuaBanHangDienTu] SET DB_CHAINING OFF 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLMuaBanHangDienTu', N'ON'
GO
USE [QLMuaBanHangDienTu]
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [QLMuaBanHangDienTu]
GO
/****** Object:  Table [dbo].[ChiTietDonDatHang]    Script Date: 31-Dec-17 0:11:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDonDatHang](
	[MaDonDatHang] [varchar](10) NOT NULL,
	[MaSanPham] [varchar](10) NOT NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_ChiTietDonDatHang] PRIMARY KEY CLUSTERED 
(
	[MaDonDatHang] ASC,
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietHoaDonBanHang]    Script Date: 31-Dec-17 0:11:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDonBanHang](
	[MaSanPham] [varchar](10) NOT NULL,
	[MaHoaDonBanHang] [varchar](10) NOT NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_ChiTietHoaDonBanHang] PRIMARY KEY CLUSTERED 
(
	[MaSanPham] ASC,
	[MaHoaDonBanHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietPhieuGiaoHang]    Script Date: 31-Dec-17 0:11:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuGiaoHang](
	[MaPhieuGiao] [varchar](10) NOT NULL,
	[MaSanPham] [varchar](10) NOT NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_ChiTietPhieuGiaoHang] PRIMARY KEY CLUSTERED 
(
	[MaPhieuGiao] ASC,
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietPhieuGiaoHangKhachHang]    Script Date: 31-Dec-17 0:11:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuGiaoHangKhachHang](
	[MaGiaoHang] [varchar](10) NOT NULL,
	[MaSanPham] [varchar](10) NOT NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_PhieuGiaoHangKhachHang] PRIMARY KEY CLUSTERED 
(
	[MaGiaoHang] ASC,
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DanhMucSanhPham]    Script Date: 31-Dec-17 0:11:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMucSanhPham](
	[MaDanhMuc] [varchar](10) NOT NULL,
	[TenDanhMuc] [varchar](50) NULL,
	[Mota] [varchar](100) NULL,
 CONSTRAINT [PK_DanhMucSanhPham] PRIMARY KEY CLUSTERED 
(
	[MaDanhMuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DonDatHang]    Script Date: 31-Dec-17 0:11:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonDatHang](
	[MaDonDatHang] [varchar](10) NOT NULL,
	[NgayLap] [date] NULL,
	[MaTrangTrangThai] [int] NULL,
	[MaNhaCungCap] [varchar](10) NULL,
 CONSTRAINT [PK_DonDatHang] PRIMARY KEY CLUSTERED 
(
	[MaDonDatHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GiaoHangKhachHang]    Script Date: 31-Dec-17 0:11:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaoHangKhachHang](
	[MaGiaoHang] [varchar](10) NOT NULL,
	[NgayGiao] [date] NULL,
	[MaTrangThai] [int] NULL,
	[MaHoaDonBanHang] [varchar](10) NULL,
 CONSTRAINT [PK_GiaoHangKhachHang] PRIMARY KEY CLUSTERED 
(
	[MaGiaoHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HangSanXuat]    Script Date: 31-Dec-17 0:11:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangSanXuat](
	[MaHangSanXuat] [varchar](10) NOT NULL,
	[TenhangSanXuat] [nvarchar](50) NULL,
 CONSTRAINT [PK_HangSanXuat] PRIMARY KEY CLUSTERED 
(
	[MaHangSanXuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDonBanHang]    Script Date: 31-Dec-17 0:11:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonBanHang](
	[MaHoaDonBanHang] [varchar](10) NOT NULL,
	[NgayLap] [date] NULL,
	[TongTien] [int] NULL,
	[TrangThai] [int] NULL,
	[MaKhachHang] [varchar](10) NULL,
	[MaNhanVien] [varchar](10) NULL,
 CONSTRAINT [PK_HoaDonBanHang] PRIMARY KEY CLUSTERED 
(
	[MaHoaDonBanHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDonThanhToan]    Script Date: 31-Dec-17 0:11:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonThanhToan](
	[MaHoaDonThanhToan] [varchar](10) NOT NULL,
	[TongTien] [int] NULL,
	[MaDonHang] [varchar](10) NULL,
 CONSTRAINT [PK_HoaDonThanhToan] PRIMARY KEY CLUSTERED 
(
	[MaHoaDonThanhToan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 31-Dec-17 0:11:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKhachHang] [varchar](10) NOT NULL,
	[TenKhachHang] [nvarchar](50) NULL,
	[SoDienThoai] [int] NULL,
	[DiaChi] [nvarchar](100) NULL,
	[Diem] [int] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiNhanVien]    Script Date: 31-Dec-17 0:11:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiNhanVien](
	[MaLoaiNhanVien] [varchar](10) NOT NULL,
	[TenLoaiNhanVien] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiNhanVien] PRIMARY KEY CLUSTERED 
(
	[MaLoaiNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiSanPham]    Script Date: 31-Dec-17 0:11:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSanPham](
	[MaLoaiSanPham] [varchar](10) NOT NULL,
	[TenLoaiSanPham] [nvarchar](50) NULL,
	[MaDanhMuc] [varchar](10) NULL,
 CONSTRAINT [PK_LoaiSanPham] PRIMARY KEY CLUSTERED 
(
	[MaLoaiSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 31-Dec-17 0:11:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNhaCungCap] [varchar](10) NOT NULL,
	[TenNhaCungCap] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNhaCungCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 31-Dec-17 0:11:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [varchar](10) NOT NULL,
	[TenNhanVien] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[SoDienThoai] [int] NULL,
	[MaLoai] [varchar](10) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuGiaoHang]    Script Date: 31-Dec-17 0:11:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuGiaoHang](
	[MaPhieuGiaoHang] [varchar](10) NOT NULL,
	[NgayGiao] [date] NULL,
	[MaTrangThaiTrangThai] [int] NULL,
	[MaDonDatHang] [varchar](10) NULL,
 CONSTRAINT [PK_PhieuGiaoHang] PRIMARY KEY CLUSTERED 
(
	[MaPhieuGiaoHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 31-Dec-17 0:11:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSanPham] [varchar](10) NOT NULL,
	[TenSanPham] [nvarchar](50) NULL,
	[GiaMua] [int] NULL,
	[GiaBan] [int] NULL,
	[XuatXu] [nvarchar](50) NULL,
	[ThoiGianBaoHanh] [int] NULL,
	[MaHangSanXuat] [varchar](10) NULL,
	[MaLoaiSanPham] [varchar](10) NULL,
	[SoLuongTon] [int] NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SanPhamDienThoai]    Script Date: 31-Dec-17 0:11:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPhamDienThoai](
	[MaSanPham] [varchar](10) NOT NULL,
	[ChieuDai] [int] NULL,
	[ChieuRong] [int] NULL,
	[ChieuCao] [int] NULL,
	[TrongLuong] [int] NULL,
	[He Dieu Hanh] [varchar](50) NULL,
 CONSTRAINT [PK_SanPhamDienThoai] PRIMARY KEY CLUSTERED 
(
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TrangThaiDonDatHang]    Script Date: 31-Dec-17 0:11:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrangThaiDonDatHang](
	[MaTrangThaiDonDatHang] [int] NOT NULL,
	[TenTrangThai] [nvarchar](50) NULL,
 CONSTRAINT [PK_TrangThaiDonDatHang] PRIMARY KEY CLUSTERED 
(
	[MaTrangThaiDonDatHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TrangThaiGiaoHangKhachHang]    Script Date: 31-Dec-17 0:11:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrangThaiGiaoHangKhachHang](
	[MaTrangThaiGiaoHangKH] [int] NOT NULL,
	[TenTrangThai] [nvarchar](50) NULL,
 CONSTRAINT [PK_TrangThaiGiaoHangKhachHang] PRIMARY KEY CLUSTERED 
(
	[MaTrangThaiGiaoHangKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TrangThaiHoaDonBanHang]    Script Date: 31-Dec-17 0:11:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrangThaiHoaDonBanHang](
	[MaTrangThaiHoaDonBanHang] [int] NOT NULL,
	[TenTrangThai] [nvarchar](50) NULL,
 CONSTRAINT [PK_TrangThaiHoaDonBanHang] PRIMARY KEY CLUSTERED 
(
	[MaTrangThaiHoaDonBanHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TrangThaiPhieuGiaoHang]    Script Date: 31-Dec-17 0:11:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrangThaiPhieuGiaoHang](
	[MaTrangThaiPhieuGiaoHang] [int] NOT NULL,
	[TenTrangThai] [varchar](50) NULL,
 CONSTRAINT [PK_TrangThaiPhieuGiaoHang] PRIMARY KEY CLUSTERED 
(
	[MaTrangThaiPhieuGiaoHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[ChiTietDonDatHang] ([MaDonDatHang], [MaSanPham], [SoLuong]) VALUES (N'DDH00001', N'SP00011', 100)
INSERT [dbo].[ChiTietDonDatHang] ([MaDonDatHang], [MaSanPham], [SoLuong]) VALUES (N'DDH00001', N'SP00013', 100)
INSERT [dbo].[ChiTietHoaDonBanHang] ([MaSanPham], [MaHoaDonBanHang], [SoLuong]) VALUES (N'SP00053', N'HD00036
', 1)
INSERT [dbo].[ChiTietHoaDonBanHang] ([MaSanPham], [MaHoaDonBanHang], [SoLuong]) VALUES (N'SP00077', N'HD00046
', 1)
INSERT [dbo].[ChiTietHoaDonBanHang] ([MaSanPham], [MaHoaDonBanHang], [SoLuong]) VALUES (N'SP00079', N'HD00046
', 3)
INSERT [dbo].[ChiTietHoaDonBanHang] ([MaSanPham], [MaHoaDonBanHang], [SoLuong]) VALUES (N'SP00085', N'HD00036
', 2)
INSERT [dbo].[ChiTietPhieuGiaoHang] ([MaPhieuGiao], [MaSanPham], [SoLuong]) VALUES (N'PG00001', N'SP00011', 50)
INSERT [dbo].[ChiTietPhieuGiaoHang] ([MaPhieuGiao], [MaSanPham], [SoLuong]) VALUES (N'PG00001', N'SP00013', 50)
INSERT [dbo].[ChiTietPhieuGiaoHang] ([MaPhieuGiao], [MaSanPham], [SoLuong]) VALUES (N'PG00002', N'SP00011', 50)
INSERT [dbo].[ChiTietPhieuGiaoHang] ([MaPhieuGiao], [MaSanPham], [SoLuong]) VALUES (N'PG00002', N'SP00013', 50)
INSERT [dbo].[ChiTietPhieuGiaoHangKhachHang] ([MaGiaoHang], [MaSanPham], [SoLuong]) VALUES (N'GH00001', N'SP00053', 1)
INSERT [dbo].[ChiTietPhieuGiaoHangKhachHang] ([MaGiaoHang], [MaSanPham], [SoLuong]) VALUES (N'GH00001', N'SP00085', 3)
INSERT [dbo].[ChiTietPhieuGiaoHangKhachHang] ([MaGiaoHang], [MaSanPham], [SoLuong]) VALUES (N'GH00002', N'SP00079', 3)
INSERT [dbo].[DanhMucSanhPham] ([MaDanhMuc], [TenDanhMuc], [Mota]) VALUES (N'DM00001', N'Tay nghe', N'Chua có')
INSERT [dbo].[DanhMucSanhPham] ([MaDanhMuc], [TenDanhMuc], [Mota]) VALUES (N'DM00002', N'?p lung', N'Chua có')
INSERT [dbo].[DanhMucSanhPham] ([MaDanhMuc], [TenDanhMuc], [Mota]) VALUES (N'DM00003', N'Loa', N'Chua có')
INSERT [dbo].[DanhMucSanhPham] ([MaDanhMuc], [TenDanhMuc], [Mota]) VALUES (N'DM00004', N'?p lung', N'Chua có')
INSERT [dbo].[DanhMucSanhPham] ([MaDanhMuc], [TenDanhMuc], [Mota]) VALUES (N'DM00005', N'G?y t? su?ng', N'Chua có')
INSERT [dbo].[DanhMucSanhPham] ([MaDanhMuc], [TenDanhMuc], [Mota]) VALUES (N'DM00006', N'Tay nghe', N'Chua có')
INSERT [dbo].[DonDatHang] ([MaDonDatHang], [NgayLap], [MaTrangTrangThai], [MaNhaCungCap]) VALUES (N'DDH00001', CAST(N'2017-12-25' AS Date), 2, N'NCC00023')
INSERT [dbo].[GiaoHangKhachHang] ([MaGiaoHang], [NgayGiao], [MaTrangThai], [MaHoaDonBanHang]) VALUES (N'GH00001', CAST(N'2017-12-31' AS Date), 1, N'HD00036
')
INSERT [dbo].[GiaoHangKhachHang] ([MaGiaoHang], [NgayGiao], [MaTrangThai], [MaHoaDonBanHang]) VALUES (N'GH00002', CAST(N'2017-12-31' AS Date), 1, N'HD00046
')
INSERT [dbo].[GiaoHangKhachHang] ([MaGiaoHang], [NgayGiao], [MaTrangThai], [MaHoaDonBanHang]) VALUES (N'GH00003', CAST(N'2017-05-01' AS Date), 0, N'HD00046
')
INSERT [dbo].[HangSanXuat] ([MaHangSanXuat], [TenhangSanXuat]) VALUES (N'HSX00020', N'Microsoft')
INSERT [dbo].[HangSanXuat] ([MaHangSanXuat], [TenhangSanXuat]) VALUES (N'HSX00023', N'Sony')
INSERT [dbo].[HangSanXuat] ([MaHangSanXuat], [TenhangSanXuat]) VALUES (N'HSX00028', N'VinaPhone')
INSERT [dbo].[HangSanXuat] ([MaHangSanXuat], [TenhangSanXuat]) VALUES (N'HSX00029', N'FPT')
INSERT [dbo].[HangSanXuat] ([MaHangSanXuat], [TenhangSanXuat]) VALUES (N'HSX00032', N'HP')
INSERT [dbo].[HangSanXuat] ([MaHangSanXuat], [TenhangSanXuat]) VALUES (N'HSX00053', N'Panasonic')
INSERT [dbo].[HangSanXuat] ([MaHangSanXuat], [TenhangSanXuat]) VALUES (N'HSX00064', N'Nokia')
INSERT [dbo].[HangSanXuat] ([MaHangSanXuat], [TenhangSanXuat]) VALUES (N'HSX00071', N'Asus')
INSERT [dbo].[HangSanXuat] ([MaHangSanXuat], [TenhangSanXuat]) VALUES (N'HSX00073', N'Dell')
INSERT [dbo].[HoaDonBanHang] ([MaHoaDonBanHang], [NgayLap], [TongTien], [TrangThai], [MaKhachHang], [MaNhanVien]) VALUES (N'HD00036
', CAST(N'2017-12-25' AS Date), 7800000, 1, N'KH00065', N'NV00003')
INSERT [dbo].[HoaDonBanHang] ([MaHoaDonBanHang], [NgayLap], [TongTien], [TrangThai], [MaKhachHang], [MaNhanVien]) VALUES (N'HD00046
', CAST(N'2017-12-25' AS Date), 5900000, 1, N'KH00080', N'NV00005')
INSERT [dbo].[HoaDonThanhToan] ([MaHoaDonThanhToan], [TongTien], [MaDonHang]) VALUES (N'HDTH00001', 180000000, N'DDH00001')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [SoDienThoai], [DiaChi], [Diem]) VALUES (N'KH00010', N'Đỗ Công Thành', 954753191, N'450,  Nguyễn thị minh khai, Phường An Lạc A, Quận 6', 840)
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [SoDienThoai], [DiaChi], [Diem]) VALUES (N'KH00014', N'Trương Tuấn Kiệt', 956205006, N'858, Kinh dương vương, Phường An Lạc , Quận 6', 720)
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [SoDienThoai], [DiaChi], [Diem]) VALUES (N'KH00016', N'Lâm Thiên Kiệt', 967969825, N'54,  Hồng bảng, Phường Bình hưng hòa, Quận Bình tân', 420)
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [SoDienThoai], [DiaChi], [Diem]) VALUES (N'KH00017', N'Trương Công Thiện', 964515966, N'813, Kinh dương vương, Phường Bình hưng hòa, Quận Bình tân', 600)
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [SoDienThoai], [DiaChi], [Diem]) VALUES (N'KH00022', N'Lâm Công Thiện', 947149548, N'847,  Nguyễn văn cừ, Phường An Lạc A, Quận 6', 300)
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [SoDienThoai], [DiaChi], [Diem]) VALUES (N'KH00024', N'Nguyễn Tuấn Kiệt', 961717513, N'264,  Hồng bảng, Phường Bình hưng hòa, Quận 6', 1140)
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [SoDienThoai], [DiaChi], [Diem]) VALUES (N'KH00031', N'Đỗ Tuấn Thiện', 954616592, N'62, Kinh dương vương, Phường An Lạc , Quận Bình tân', 1080)
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [SoDienThoai], [DiaChi], [Diem]) VALUES (N'KH00033', N'Lâm Minh Hưng', 943504302, N'90,  Nguyễn thị minh khai, Phường An Lạc , Quận 7', 660)
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [SoDienThoai], [DiaChi], [Diem]) VALUES (N'KH00034', N'Lâm Thiên Thành', 944226825, N'97, Kinh dương vương, Phường An Lạc A, Quận 6', 180)
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [SoDienThoai], [DiaChi], [Diem]) VALUES (N'KH00042', N'Lâm Minh Thành', 966328490, N'25,  Hồng bảng, Phường Bình hưng hòa, Quận Bình tân', 360)
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [SoDienThoai], [DiaChi], [Diem]) VALUES (N'KH00059', N'Đỗ Công Hưng', 942551308, N'170,  Hồng bảng, Phường An Lạc A, Quận 5', 960)
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [SoDienThoai], [DiaChi], [Diem]) VALUES (N'KH00065', N'Trương Công Thành', 955000109, N'98,  Nguyễn văn cừ, Phường An Lạc A, Quận 6', 0)
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [SoDienThoai], [DiaChi], [Diem]) VALUES (N'KH00069', N'Trương Thiên Thiện', 941327499, N'11,  Hồng bảng, Phường Bình hưng hòa, Quận Bình tân', 240)
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [SoDienThoai], [DiaChi], [Diem]) VALUES (N'KH00070', N'Trương Minh Hưng', 949649061, N'52,  Nguyễn văn cừ, Phường An Lạc , Quận Bình tân', 1020)
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [SoDienThoai], [DiaChi], [Diem]) VALUES (N'KH00073', N'Lâm Thiên Thành', 949048012, N'57,  Nguyễn thị minh khai, Phường An Lạc , Quận 5', 480)
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [SoDienThoai], [DiaChi], [Diem]) VALUES (N'KH00076', N'Đỗ Công Thành', 962256383, N'374, Kinh dương vương, Phường Bình hưng hòa, Quận 6', 120)
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [SoDienThoai], [DiaChi], [Diem]) VALUES (N'KH00080', N'Nguyễn Công Thành', 951069982, N'32, Kinh dương vương, Phường Bình hưng hòa, Quận 6', 780)
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [SoDienThoai], [DiaChi], [Diem]) VALUES (N'KH00086', N'Trương Thiên Thành', 954405138, N'54,  Hồng bảng, Phường An Lạc , Quận 7', 60)
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [SoDienThoai], [DiaChi], [Diem]) VALUES (N'KH00093', N'Đỗ Công Hưng', 943491435, N'804,  Hồng bảng, Phường Bình hưng hòa, Quận Bình tân', 540)
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [SoDienThoai], [DiaChi], [Diem]) VALUES (N'KH00099', N'Đỗ Minh Kiệt', 944254088, N'590, Kinh dương vương, Phường Bình hưng hòa, Quận 7', 900)
INSERT [dbo].[LoaiNhanVien] ([MaLoaiNhanVien], [TenLoaiNhanVien]) VALUES (N'LNV00001', N'Nhân viên thủ kho')
INSERT [dbo].[LoaiNhanVien] ([MaLoaiNhanVien], [TenLoaiNhanVien]) VALUES (N'LNV00002', N'Nhân viên kinh doanh')
INSERT [dbo].[LoaiNhanVien] ([MaLoaiNhanVien], [TenLoaiNhanVien]) VALUES (N'LNV00003', N'Nhân viên bán hàng')
INSERT [dbo].[LoaiNhanVien] ([MaLoaiNhanVien], [TenLoaiNhanVien]) VALUES (N'LNV00004', N'Nhân viên giao hàng')
INSERT [dbo].[LoaiNhanVien] ([MaLoaiNhanVien], [TenLoaiNhanVien]) VALUES (N'LNV00005', N'Nhân viên bảo hành')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham], [MaDanhMuc]) VALUES (N'LSP00022', N'Sản Phẩm D', N'DM00005')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham], [MaDanhMuc]) VALUES (N'LSP00024', N'Sản Phẩm F', N'DM00006')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham], [MaDanhMuc]) VALUES (N'LSP00030', N'Sản Phẩm E', N'DM00004')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham], [MaDanhMuc]) VALUES (N'LSP00032', N'Sản Phẩm E', N'DM00006')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham], [MaDanhMuc]) VALUES (N'LSP00034', N'Sản Phẩm Q', N'DM00003')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham], [MaDanhMuc]) VALUES (N'LSP00041', N'Sản Phẩm X', N'DM00001')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham], [MaDanhMuc]) VALUES (N'LSP00048', N'Sản Phẩm H', N'DM00005')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham], [MaDanhMuc]) VALUES (N'LSP00054', N'Sản Phẩm Q', N'DM00006')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham], [MaDanhMuc]) VALUES (N'LSP00055', N'Sản Phẩm A', N'DM00003')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham], [MaDanhMuc]) VALUES (N'LSP00056', N'Sản Phẩm W', N'DM00005')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham], [MaDanhMuc]) VALUES (N'LSP00060', N'Sản Phẩm W', N'DM00004')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham], [MaDanhMuc]) VALUES (N'LSP00068', N'Sản Phẩm F', N'DM00002')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham], [MaDanhMuc]) VALUES (N'LSP00069', N'Sản Phẩm E', N'DM00001')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham], [MaDanhMuc]) VALUES (N'LSP00072', N'Sản Phẩm G', N'DM00003')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham], [MaDanhMuc]) VALUES (N'LSP00073', N'Sản Phẩm G', N'DM00003')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham], [MaDanhMuc]) VALUES (N'LSP00076', N'Sản Phẩm O', N'DM00006')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham], [MaDanhMuc]) VALUES (N'LSP00078', N'Sản Phẩm Z', N'DM00003')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham], [MaDanhMuc]) VALUES (N'LSP00088', N'Sản Phẩm T', N'DM00004')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham], [MaDanhMuc]) VALUES (N'LSP00089', N'Sản Phẩm F', N'DM00001')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham], [MaDanhMuc]) VALUES (N'LSP00093', N'Sản Phẩm G', N'DM00002')
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap]) VALUES (N'NCC00023', NULL)
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap]) VALUES (N'NCC00033', N'Đồng dung')
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap]) VALUES (N'NCC00034', N'Hoàn vũ')
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap]) VALUES (N'NCC00037', N'Thế giới di động')
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap]) VALUES (N'NCC00039', N'Hoàn vũ')
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap]) VALUES (N'NCC00047', N'Long hưng')
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap]) VALUES (N'NCC00054', N'FPT')
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap]) VALUES (N'NCC00092', N'Tiến Phát')
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap]) VALUES (N'NCC00094', N'Đồng dung')
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap]) VALUES (N'NCC00095', N'Đồng dung')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [SoDienThoai], [MaLoai]) VALUES (N'NV00001', N'Nguyễn Công Hưng', CAST(N'1992-05-12' AS Date), 955773477, N'LNV00003')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [SoDienThoai], [MaLoai]) VALUES (N'NV00002', N'Đỗ Thiên Thiện', CAST(N'1992-01-05' AS Date), 958985552, N'LNV00002')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [SoDienThoai], [MaLoai]) VALUES (N'NV00003', N'Trương Công Hưng', CAST(N'1990-08-29' AS Date), 963199525, N'LNV00003')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [SoDienThoai], [MaLoai]) VALUES (N'NV00004', N'Lâm Tuấn Kiệt', CAST(N'1992-10-01' AS Date), 942860615, N'LNV00003')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [SoDienThoai], [MaLoai]) VALUES (N'NV00005', N'Trương Minh Thành', CAST(N'1992-01-30' AS Date), 967757573, N'LNV00005')
INSERT [dbo].[PhieuGiaoHang] ([MaPhieuGiaoHang], [NgayGiao], [MaTrangThaiTrangThai], [MaDonDatHang]) VALUES (N'PG00001', CAST(N'2017-12-25' AS Date), 1, N'DDH00001')
INSERT [dbo].[PhieuGiaoHang] ([MaPhieuGiaoHang], [NgayGiao], [MaTrangThaiTrangThai], [MaDonDatHang]) VALUES (N'PG00002', CAST(N'2017-12-26' AS Date), 1, N'DDH00001')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00011', N'Sản Phẩm CI', 300000, 3500000, N'Nhật bản', 7, N'HSX00020', N'LSP00022', 25)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00013', N'Sản Phẩm GH', 1500000, 2300000, N'Nhật bản', 11, N'HSX00020', N'LSP00022', 25)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00014', N'Sản Phẩm EL', 500000, 3800000, N'Hàn quốc', 8, N'HSX00032', N'LSP00060', 100)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00015', N'Sản Phẩm IC', 1300000, 1100000, N'Nhật bản', 10, N'HSX00073', N'LSP00093', 100)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00016', N'Sản Phẩm GB', 1300000, 2300000, N'Thailand', 11, N'HSX00028', N'LSP00041', 100)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00017', N'Sản Phẩm OC', 1300000, 2000000, N'Mỹ', 8, N'HSX00032', N'LSP00056', 100)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00018', N'Sản Phẩm UM', 700000, 200000, N'Hàn quốc', 7, N'HSX00064', N'LSP00072', 100)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00020', N'Sản Phẩm TU', 700000, 2600000, N'Thailand', 7, N'HSX00023', N'LSP00034', 100)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00021', N'Sản Phẩm JE', 100000, 1700000, N'Thailand', 10, N'HSX00073', N'LSP00088', 100)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00022', N'Sản Phẩm ZU', 1700000, 2600000, N'Mỹ', 12, N'HSX00073', N'LSP00093', 100)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00024', N'Sản Phẩm XG', 1300000, 500000, N'Nhật bản', NULL, N'HSX00071', N'LSP00088', 100)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00026', N'Sản Phẩm WN', 1100000, 3200000, N'Mỹ', 10, N'HSX00064', N'LSP00073', 100)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00028', N'Sản Phẩm EF', 300000, 800000, N'Malaysia', 9, N'HSX00032', N'LSP00056', 100)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00031', N'Sản Phẩm WP', 300000, 2600000, N'Trung quốc', 9, N'HSX00028', N'LSP00041', 100)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00032', N'Sản Phẩm IY', 1100000, 200000, N'Nhật bản', 7, N'HSX00032', N'LSP00056', 100)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00033', N'Sản Phẩm HK', 500000, 1100000, N'Lào', 7, N'HSX00071', N'LSP00078', 100)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00034', N'Sản Phẩm CM', 1300000, 3500000, N'Lào', 10, N'HSX00020', N'LSP00030', 100)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00036', N'Sản Phẩm DQ', 1100000, 800000, N'Trung quốc', 11, N'HSX00032', N'LSP00056', 100)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00039', N'Sản Phẩm OW', 1700000, NULL, N'Hàn quốc', 10, N'HSX00073', N'LSP00089', 100)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00042', N'Sản Phẩm YP', 1500000, 800000, N'Nhật bản', 12, N'HSX00064', N'LSP00073', 100)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00043', N'Sản Phẩm MN', 500000, 800000, N'Việt nam', 11, N'HSX00053', N'LSP00068', 100)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00044', N'Sản Phẩm NV', 700000, 1100000, N'Lào', 6, N'HSX00029', N'LSP00055', 100)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00045', N'Sản Phẩm HW', 1700000, 1700000, N'Malaysia', 10, N'HSX00029', N'LSP00054', 100)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00048', N'Sản Phẩm XG', 300000, 500000, N'Lào', 7, N'HSX00053', N'LSP00068', 100)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00051', N'Sản Phẩm ZC', 900000, 2900000, N'Malaysia', 11, N'HSX00032', N'LSP00056', 100)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00052', N'Sản Phẩm YZ', 1900000, 2000000, N'Nhật bản', 11, N'HSX00073', N'LSP00093', 100)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00053', N'Sản Phẩm ZR', 1900000, 200000, N'Thailand', 7, N'HSX00032', N'LSP00056', 100)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00055', N'Sản Phẩm FA', 1100000, 1700000, N'Việt nam', 12, N'HSX00032', N'LSP00056', 100)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00057', N'Sản Phẩm UY', 1100000, 2000000, N'Lào', 11, N'HSX00053', N'LSP00072', 100)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00058', N'Sản Phẩm KR', 900000, 1400000, N'Mỹ', 7, N'HSX00028', N'LSP00041', 100)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00060', N'Sản Phẩm AR', 1500000, 2600000, N'Trung quốc', 7, N'HSX00028', N'LSP00034', 100)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00061', N'Sản Phẩm SA', 1900000, 1400000, N'Trung quốc', 9, N'HSX00023', N'LSP00034', 100)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00063', N'Sản Phẩm VM', 100000, 3200000, N'Thailand', 7, N'HSX00071', N'LSP00078', 100)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00065', N'Sản Phẩm MC', 700000, 3200000, N'Thailand', 11, N'HSX00032', N'LSP00056', 100)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00070', N'Sản Phẩm RZ', 100000, 500000, N'Trung quốc', 7, N'HSX00028', N'LSP00048', 100)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00071', N'Sản Phẩm UH', 500000, 2900000, N'Malaysia', 11, N'HSX00071', N'LSP00076', 100)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00077', N'Sản Phẩm NS', 900000, 1700000, NULL, 12, N'HSX00028', N'LSP00041', 100)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00079', N'Sản Phẩm JM', 1500000, 1400000, N'Hàn quốc', 7, N'HSX00064', N'LSP00076', 100)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00081', N'Sản Phẩm SA', 100000, 200000, N'Nhật bản', 11, N'HSX00071', N'LSP00078', 100)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00083', N'Sản Phẩm LF', 900000, 500000, N'Nhật bản', 6, N'HSX00020', N'LSP00024', 100)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00084', N'Sản Phẩm VM', 900000, 3500000, N'Thailand', 9, N'HSX00023', N'LSP00034', 100)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00085', N'Sản Phẩm PM', 1500000, 3800000, N'Thailand', 10, N'HSX00064', N'LSP00073', 100)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00086', N'Sản Phẩm BY', NULL, 3800000, N'Thailand', 6, N'HSX00064', N'LSP00073', 100)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00087', N'Sản Phẩm SM', 500000, 2300000, N'Trung quốc', 12, N'HSX00053', N'LSP00069', 100)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00088', N'Sản Phẩm ED', 700000, 1400000, N'Nhật bản', 6, N'HSX00064', N'LSP00076', 100)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00091', N'Sản Phẩm CA', 1700000, 1100000, N'Hàn quốc', 9, N'HSX00064', N'LSP00072', 100)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00093', N'Sản Phẩm NE', 1900000, 2900000, N'Mỹ', 6, N'HSX00028', N'LSP00048', 100)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00094', N'Sản Phẩm NO', 300000, 2000000, N'Malaysia', 10, N'HSX00071', N'LSP00078', 100)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00097', N'Sản Phẩm BF', 1700000, 2900000, N'Việt nam', 7, N'HSX00020', N'LSP00024', 100)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [GiaMua], [GiaBan], [XuatXu], [ThoiGianBaoHanh], [MaHangSanXuat], [MaLoaiSanPham], [SoLuongTon]) VALUES (N'SP00099', N'Sản Phẩm CJ', 100000, 2300000, N'Trung quốc', 8, N'HSX00064', N'LSP00073', 100)
INSERT [dbo].[SanPhamDienThoai] ([MaSanPham], [ChieuDai], [ChieuRong], [ChieuCao], [TrongLuong], [He Dieu Hanh]) VALUES (N'SP00022', 11, 3, 11, 215, N'Android 7')
INSERT [dbo].[SanPhamDienThoai] ([MaSanPham], [ChieuDai], [ChieuRong], [ChieuCao], [TrongLuong], [He Dieu Hanh]) VALUES (N'SP00028', 9, 4, 12, 237, N'Android 7')
INSERT [dbo].[SanPhamDienThoai] ([MaSanPham], [ChieuDai], [ChieuRong], [ChieuCao], [TrongLuong], [He Dieu Hanh]) VALUES (N'SP00043', 10, 3, 10, 204, N'Android 7')
INSERT [dbo].[SanPhamDienThoai] ([MaSanPham], [ChieuDai], [ChieuRong], [ChieuCao], [TrongLuong], [He Dieu Hanh]) VALUES (N'SP00053', 12, 3, 9, 246, N'Android 7')
INSERT [dbo].[SanPhamDienThoai] ([MaSanPham], [ChieuDai], [ChieuRong], [ChieuCao], [TrongLuong], [He Dieu Hanh]) VALUES (N'SP00055', 9, 3, 8, 300, N'Android 7.1')
INSERT [dbo].[SanPhamDienThoai] ([MaSanPham], [ChieuDai], [ChieuRong], [ChieuCao], [TrongLuong], [He Dieu Hanh]) VALUES (N'SP00077', 11, 3, 11, 223, N'Android 7.1')
INSERT [dbo].[SanPhamDienThoai] ([MaSanPham], [ChieuDai], [ChieuRong], [ChieuCao], [TrongLuong], [He Dieu Hanh]) VALUES (N'SP00079', 11, 4, 8, 279, N'Android 6')
INSERT [dbo].[SanPhamDienThoai] ([MaSanPham], [ChieuDai], [ChieuRong], [ChieuCao], [TrongLuong], [He Dieu Hanh]) VALUES (N'SP00085', 10, 5, 8, 236, N'Android 7')
INSERT [dbo].[SanPhamDienThoai] ([MaSanPham], [ChieuDai], [ChieuRong], [ChieuCao], [TrongLuong], [He Dieu Hanh]) VALUES (N'SP00091', 9, 5, 9, 266, N'Android 5')
INSERT [dbo].[SanPhamDienThoai] ([MaSanPham], [ChieuDai], [ChieuRong], [ChieuCao], [TrongLuong], [He Dieu Hanh]) VALUES (N'SP00099', 8, 3, 9, 245, N'Android 7')
INSERT [dbo].[TrangThaiDonDatHang] ([MaTrangThaiDonDatHang], [TenTrangThai]) VALUES (0, N'Chưa xác nhận')
INSERT [dbo].[TrangThaiDonDatHang] ([MaTrangThaiDonDatHang], [TenTrangThai]) VALUES (1, N'Chưa thanh toán')
INSERT [dbo].[TrangThaiDonDatHang] ([MaTrangThaiDonDatHang], [TenTrangThai]) VALUES (2, N'Đã thanh toán')
INSERT [dbo].[TrangThaiGiaoHangKhachHang] ([MaTrangThaiGiaoHangKH], [TenTrangThai]) VALUES (0, N'Chưa giao')
INSERT [dbo].[TrangThaiGiaoHangKhachHang] ([MaTrangThaiGiaoHangKH], [TenTrangThai]) VALUES (1, N'Đã giao')
INSERT [dbo].[TrangThaiHoaDonBanHang] ([MaTrangThaiHoaDonBanHang], [TenTrangThai]) VALUES (0, N'Chưa thanh toán')
INSERT [dbo].[TrangThaiHoaDonBanHang] ([MaTrangThaiHoaDonBanHang], [TenTrangThai]) VALUES (1, N'Đã thanh toán')
INSERT [dbo].[TrangThaiPhieuGiaoHang] ([MaTrangThaiPhieuGiaoHang], [TenTrangThai]) VALUES (0, N'Chua giao')
INSERT [dbo].[TrangThaiPhieuGiaoHang] ([MaTrangThaiPhieuGiaoHang], [TenTrangThai]) VALUES (1, N'Ðã giao')
ALTER TABLE [dbo].[ChiTietDonDatHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDonDatHang_DonDatHang] FOREIGN KEY([MaDonDatHang])
REFERENCES [dbo].[DonDatHang] ([MaDonDatHang])
GO
ALTER TABLE [dbo].[ChiTietDonDatHang] CHECK CONSTRAINT [FK_ChiTietDonDatHang_DonDatHang]
GO
ALTER TABLE [dbo].[ChiTietDonDatHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDonDatHang_SanPham] FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SanPham] ([MaSanPham])
GO
ALTER TABLE [dbo].[ChiTietDonDatHang] CHECK CONSTRAINT [FK_ChiTietDonDatHang_SanPham]
GO
ALTER TABLE [dbo].[ChiTietHoaDonBanHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDonBanHang_HoaDonBanHang] FOREIGN KEY([MaHoaDonBanHang])
REFERENCES [dbo].[HoaDonBanHang] ([MaHoaDonBanHang])
GO
ALTER TABLE [dbo].[ChiTietHoaDonBanHang] CHECK CONSTRAINT [FK_ChiTietHoaDonBanHang_HoaDonBanHang]
GO
ALTER TABLE [dbo].[ChiTietHoaDonBanHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDonBanHang_SanPham] FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SanPham] ([MaSanPham])
GO
ALTER TABLE [dbo].[ChiTietHoaDonBanHang] CHECK CONSTRAINT [FK_ChiTietHoaDonBanHang_SanPham]
GO
ALTER TABLE [dbo].[ChiTietPhieuGiaoHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuGiaoHang_PhieuGiaoHang] FOREIGN KEY([MaPhieuGiao])
REFERENCES [dbo].[PhieuGiaoHang] ([MaPhieuGiaoHang])
GO
ALTER TABLE [dbo].[ChiTietPhieuGiaoHang] CHECK CONSTRAINT [FK_ChiTietPhieuGiaoHang_PhieuGiaoHang]
GO
ALTER TABLE [dbo].[ChiTietPhieuGiaoHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuGiaoHang_SanPham] FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SanPham] ([MaSanPham])
GO
ALTER TABLE [dbo].[ChiTietPhieuGiaoHang] CHECK CONSTRAINT [FK_ChiTietPhieuGiaoHang_SanPham]
GO
ALTER TABLE [dbo].[ChiTietPhieuGiaoHangKhachHang]  WITH CHECK ADD  CONSTRAINT [FK_PhieuGiaoHangKhachHang_GiaoHangKhachHang] FOREIGN KEY([MaGiaoHang])
REFERENCES [dbo].[GiaoHangKhachHang] ([MaGiaoHang])
GO
ALTER TABLE [dbo].[ChiTietPhieuGiaoHangKhachHang] CHECK CONSTRAINT [FK_PhieuGiaoHangKhachHang_GiaoHangKhachHang]
GO
ALTER TABLE [dbo].[ChiTietPhieuGiaoHangKhachHang]  WITH CHECK ADD  CONSTRAINT [FK_PhieuGiaoHangKhachHang_SanPham] FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SanPham] ([MaSanPham])
GO
ALTER TABLE [dbo].[ChiTietPhieuGiaoHangKhachHang] CHECK CONSTRAINT [FK_PhieuGiaoHangKhachHang_SanPham]
GO
ALTER TABLE [dbo].[DonDatHang]  WITH CHECK ADD  CONSTRAINT [FK_DonDatHang_NhaCungCap] FOREIGN KEY([MaNhaCungCap])
REFERENCES [dbo].[NhaCungCap] ([MaNhaCungCap])
GO
ALTER TABLE [dbo].[DonDatHang] CHECK CONSTRAINT [FK_DonDatHang_NhaCungCap]
GO
ALTER TABLE [dbo].[DonDatHang]  WITH CHECK ADD  CONSTRAINT [FK_DonDatHang_TrangThaiDonDatHang] FOREIGN KEY([MaTrangTrangThai])
REFERENCES [dbo].[TrangThaiDonDatHang] ([MaTrangThaiDonDatHang])
GO
ALTER TABLE [dbo].[DonDatHang] CHECK CONSTRAINT [FK_DonDatHang_TrangThaiDonDatHang]
GO
ALTER TABLE [dbo].[GiaoHangKhachHang]  WITH CHECK ADD  CONSTRAINT [FK_GiaoHangKhachHang_HoaDonBanHang] FOREIGN KEY([MaHoaDonBanHang])
REFERENCES [dbo].[HoaDonBanHang] ([MaHoaDonBanHang])
GO
ALTER TABLE [dbo].[GiaoHangKhachHang] CHECK CONSTRAINT [FK_GiaoHangKhachHang_HoaDonBanHang]
GO
ALTER TABLE [dbo].[GiaoHangKhachHang]  WITH CHECK ADD  CONSTRAINT [FK_GiaoHangKhachHang_TrangThaiGiaoHangKhachHang] FOREIGN KEY([MaTrangThai])
REFERENCES [dbo].[TrangThaiGiaoHangKhachHang] ([MaTrangThaiGiaoHangKH])
GO
ALTER TABLE [dbo].[GiaoHangKhachHang] CHECK CONSTRAINT [FK_GiaoHangKhachHang_TrangThaiGiaoHangKhachHang]
GO
ALTER TABLE [dbo].[HoaDonBanHang]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonBanHang_KhachHang] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[HoaDonBanHang] CHECK CONSTRAINT [FK_HoaDonBanHang_KhachHang]
GO
ALTER TABLE [dbo].[HoaDonBanHang]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonBanHang_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[HoaDonBanHang] CHECK CONSTRAINT [FK_HoaDonBanHang_NhanVien]
GO
ALTER TABLE [dbo].[HoaDonBanHang]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonBanHang_TrangThaiHoaDonBanHang] FOREIGN KEY([TrangThai])
REFERENCES [dbo].[TrangThaiHoaDonBanHang] ([MaTrangThaiHoaDonBanHang])
GO
ALTER TABLE [dbo].[HoaDonBanHang] CHECK CONSTRAINT [FK_HoaDonBanHang_TrangThaiHoaDonBanHang]
GO
ALTER TABLE [dbo].[HoaDonThanhToan]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonThanhToan_DonDatHang] FOREIGN KEY([MaDonHang])
REFERENCES [dbo].[DonDatHang] ([MaDonDatHang])
GO
ALTER TABLE [dbo].[HoaDonThanhToan] CHECK CONSTRAINT [FK_HoaDonThanhToan_DonDatHang]
GO
ALTER TABLE [dbo].[LoaiSanPham]  WITH CHECK ADD  CONSTRAINT [FK_LoaiSanPham_DanhMucSanhPham] FOREIGN KEY([MaDanhMuc])
REFERENCES [dbo].[DanhMucSanhPham] ([MaDanhMuc])
GO
ALTER TABLE [dbo].[LoaiSanPham] CHECK CONSTRAINT [FK_LoaiSanPham_DanhMucSanhPham]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_LoaiNhanVien] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiNhanVien] ([MaLoaiNhanVien])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_LoaiNhanVien]
GO
ALTER TABLE [dbo].[PhieuGiaoHang]  WITH CHECK ADD  CONSTRAINT [FK_PhieuGiaoHang_DonDatHang] FOREIGN KEY([MaDonDatHang])
REFERENCES [dbo].[DonDatHang] ([MaDonDatHang])
GO
ALTER TABLE [dbo].[PhieuGiaoHang] CHECK CONSTRAINT [FK_PhieuGiaoHang_DonDatHang]
GO
ALTER TABLE [dbo].[PhieuGiaoHang]  WITH CHECK ADD  CONSTRAINT [FK_PhieuGiaoHang_TrangThaiPhieuGiaoHang] FOREIGN KEY([MaTrangThaiTrangThai])
REFERENCES [dbo].[TrangThaiPhieuGiaoHang] ([MaTrangThaiPhieuGiaoHang])
GO
ALTER TABLE [dbo].[PhieuGiaoHang] CHECK CONSTRAINT [FK_PhieuGiaoHang_TrangThaiPhieuGiaoHang]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_HangSanXuat] FOREIGN KEY([MaHangSanXuat])
REFERENCES [dbo].[HangSanXuat] ([MaHangSanXuat])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_HangSanXuat]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_LoaiSanPham] FOREIGN KEY([MaLoaiSanPham])
REFERENCES [dbo].[LoaiSanPham] ([MaLoaiSanPham])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_LoaiSanPham]
GO
ALTER TABLE [dbo].[SanPhamDienThoai]  WITH CHECK ADD  CONSTRAINT [FK_SanPhamDienThoai_SanPham] FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SanPham] ([MaSanPham])
GO
ALTER TABLE [dbo].[SanPhamDienThoai] CHECK CONSTRAINT [FK_SanPhamDienThoai_SanPham]
GO
USE [master]
GO
ALTER DATABASE [QLMuaBanHangDienTu] SET  READ_WRITE 
GO

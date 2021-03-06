USE [master]
GO
/****** Object:  Database [QUANLYVEXE]    Script Date: 24/12/2018 5:34:15 CH ******/
CREATE DATABASE [QUANLYVEXE]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QUANLYVEXE', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\QUANLYVEXE.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QUANLYVEXE_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\QUANLYVEXE_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [QUANLYVEXE] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QUANLYVEXE].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QUANLYVEXE] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QUANLYVEXE] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QUANLYVEXE] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QUANLYVEXE] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QUANLYVEXE] SET ARITHABORT OFF 
GO
ALTER DATABASE [QUANLYVEXE] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QUANLYVEXE] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QUANLYVEXE] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QUANLYVEXE] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QUANLYVEXE] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QUANLYVEXE] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QUANLYVEXE] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QUANLYVEXE] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QUANLYVEXE] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QUANLYVEXE] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QUANLYVEXE] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QUANLYVEXE] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QUANLYVEXE] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QUANLYVEXE] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QUANLYVEXE] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QUANLYVEXE] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QUANLYVEXE] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QUANLYVEXE] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QUANLYVEXE] SET  MULTI_USER 
GO
ALTER DATABASE [QUANLYVEXE] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QUANLYVEXE] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QUANLYVEXE] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QUANLYVEXE] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QUANLYVEXE] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QUANLYVEXE] SET QUERY_STORE = OFF
GO
USE [QUANLYVEXE]
GO
/****** Object:  Table [dbo].[Chuyen]    Script Date: 24/12/2018 5:34:16 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chuyen](
	[ID_Chuyen] [int] NOT NULL,
	[Tuyen_ID_Tuyen] [int] NOT NULL,
	[Gio_Khoi_Hanh] [datetime] NOT NULL,
	[Ghi_Chu] [nvarchar](200) NULL,
	[Xe_XeID] [int] NOT NULL,
	[Tai_xe_ID_TaiXe] [int] NULL,
 CONSTRAINT [PK_Chuyen_1] PRIMARY KEY CLUSTERED 
(
	[ID_Chuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ghe]    Script Date: 24/12/2018 5:34:17 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ghe](
	[ID_Ghe] [int] NOT NULL,
	[Dong] [int] NOT NULL,
	[Cot] [int] NOT NULL,
	[Tang] [int] NULL,
	[So_Ghe] [int] NULL,
	[Xe_XeID] [int] NOT NULL,
	[TinhTrang] [nvarchar](50) NULL,
 CONSTRAINT [PK_Ghe] PRIMARY KEY CLUSTERED 
(
	[ID_Ghe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 24/12/2018 5:34:17 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[ID_KhachHang] [int] NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[DienThoai] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Loai] [int] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[ID_KhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiXe]    Script Date: 24/12/2018 5:34:17 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiXe](
	[ID_LoaiXe] [int] NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiXe] PRIMARY KEY CLUSTERED 
(
	[ID_LoaiXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tai_Xe]    Script Date: 24/12/2018 5:34:17 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tai_Xe](
	[ID_TaiXe] [int] NOT NULL,
	[TenTaiXe] [nvarchar](50) NULL,
	[BangLai] [nvarchar](50) NULL,
 CONSTRAINT [PK_Tai_Xe] PRIMARY KEY CLUSTERED 
(
	[ID_TaiXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tuyen]    Script Date: 24/12/2018 5:34:17 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tuyen](
	[ID_Tuyen] [int] NOT NULL,
	[KhoangCach] [float] NULL,
	[ThoiGianChay] [int] NULL,
	[Tram_ID_Tram1] [int] NULL,
	[Tram_ID_Tram] [int] NULL,
	[TenTuyen] [nvarchar](100) NULL,
 CONSTRAINT [PK_Tuyen] PRIMARY KEY CLUSTERED 
(
	[ID_Tuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tram]    Script Date: 24/12/2018 5:34:17 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tram](
	[ID_Tram] [int] NOT NULL,
	[TenTram] [nvarchar](50) NOT NULL,
	[Dia_Diem] [nvarchar](200) NULL,
 CONSTRAINT [PK_Tram_1] PRIMARY KEY CLUSTERED 
(
	[ID_Tram] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tram_Trung_Gian]    Script Date: 24/12/2018 5:34:17 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tram_Trung_Gian](
	[Tuyen_ID_Tuyen] [int] NOT NULL,
	[Tram_ID_Tram] [int] NOT NULL,
	[Thu_tu] [int] NULL,
 CONSTRAINT [PK_Tram_Trung_Gian] PRIMARY KEY CLUSTERED 
(
	[Tuyen_ID_Tuyen] ASC,
	[Tram_ID_Tram] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ve]    Script Date: 24/12/2018 5:34:17 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ve](
	[ID_Ve] [int] NULL,
	[Ghe_ID_Ghe] [int] NULL,
	[Chuyen_ID_Chuyen] [int] NULL,
	[GiaTien] [float] NULL,
	[KhachHang_ID_KhachHang] [int] NULL,
	[NgayXuatVe] [datetime] NULL,
	[GhiChu] [nvarchar](200) NULL,
	[TinhTrang] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Xe]    Script Date: 24/12/2018 5:34:17 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Xe](
	[XeID] [int] NOT NULL,
	[TenXe] [nvarchar](50) NULL,
	[So_dang_ky] [nvarchar](50) NULL,
	[LoaiXe_ID_LoaiXe] [int] NULL,
 CONSTRAINT [PK_Xe] PRIMARY KEY CLUSTERED 
(
	[XeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Chuyen] ([ID_Chuyen], [Tuyen_ID_Tuyen], [Gio_Khoi_Hanh], [Ghi_Chu], [Xe_XeID], [Tai_xe_ID_TaiXe]) VALUES (1, 1, CAST(N'2018-12-22T21:00:00.000' AS DateTime), N'Không có ghi chú', 1, 1)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID], [TinhTrang]) VALUES (1, 1, 1, 1, 1, 1, N'Da dat')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID], [TinhTrang]) VALUES (2, 1, 2, 1, 2, 1, N'Trong')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID], [TinhTrang]) VALUES (3, 1, 3, 1, 3, 1, N'Da dat')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID], [TinhTrang]) VALUES (4, 1, 4, 1, 4, 1, N'Da dat')
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_Ghe], [Xe_XeID], [TinhTrang]) VALUES (5, 2, 1, 1, 5, 1, N'Trong')
INSERT [dbo].[KhachHang] ([ID_KhachHang], [HoTen], [DienThoai], [Email], [Loai]) VALUES (2593, N'Ph?m Bá Long', N'0961879028', N'pblong98@gmail.com', 2)
INSERT [dbo].[KhachHang] ([ID_KhachHang], [HoTen], [DienThoai], [Email], [Loai]) VALUES (2705, N'234', N'123', N'no', 1)
INSERT [dbo].[KhachHang] ([ID_KhachHang], [HoTen], [DienThoai], [Email], [Loai]) VALUES (6123, N'a', N'2', N'no', 1)
INSERT [dbo].[KhachHang] ([ID_KhachHang], [HoTen], [DienThoai], [Email], [Loai]) VALUES (9074, N'Alo', N'12345678909', N'no', 1)
INSERT [dbo].[LoaiXe] ([ID_LoaiXe], [TenLoai]) VALUES (1, N'Giường nằm')
INSERT [dbo].[Tai_Xe] ([ID_TaiXe], [TenTaiXe], [BangLai]) VALUES (1, N'Phạm Bá Long', N'C1')
INSERT [dbo].[Tuyen] ([ID_Tuyen], [KhoangCach], [ThoiGianChay], [Tram_ID_Tram1], [Tram_ID_Tram], [TenTuyen]) VALUES (1, 200, 6, 1, 2, N'HCM - Đà Lạt')
INSERT [dbo].[Tram] ([ID_Tram], [TenTram], [Dia_Diem]) VALUES (1, N'HCM', N'Quận 10')
INSERT [dbo].[Tram] ([ID_Tram], [TenTram], [Dia_Diem]) VALUES (2, N'ĐÀ LẠT', N'Hùng Vương')
INSERT [dbo].[Ve] ([ID_Ve], [Ghe_ID_Ghe], [Chuyen_ID_Chuyen], [GiaTien], [KhachHang_ID_KhachHang], [NgayXuatVe], [GhiChu], [TinhTrang]) VALUES (9769, 2, 1, 50000, 2593, CAST(N'2018-12-22T20:51:00.000' AS DateTime), N'123', N'Da thanh toan')
INSERT [dbo].[Ve] ([ID_Ve], [Ghe_ID_Ghe], [Chuyen_ID_Chuyen], [GiaTien], [KhachHang_ID_KhachHang], [NgayXuatVe], [GhiChu], [TinhTrang]) VALUES (9710, 3, 1, 50000, 6123, CAST(N'2018-12-22T20:52:00.000' AS DateTime), N'', N'Chua thanh toan')
INSERT [dbo].[Ve] ([ID_Ve], [Ghe_ID_Ghe], [Chuyen_ID_Chuyen], [GiaTien], [KhachHang_ID_KhachHang], [NgayXuatVe], [GhiChu], [TinhTrang]) VALUES (6293, 2, 1, 50000, 2705, CAST(N'2018-12-22T20:54:00.000' AS DateTime), N'', N'Da thanh toan')
INSERT [dbo].[Ve] ([ID_Ve], [Ghe_ID_Ghe], [Chuyen_ID_Chuyen], [GiaTien], [KhachHang_ID_KhachHang], [NgayXuatVe], [GhiChu], [TinhTrang]) VALUES (4929, 1, 1, 50000, 9074, CAST(N'2018-12-22T21:02:00.000' AS DateTime), N'', N'Da thanh toan')
INSERT [dbo].[Xe] ([XeID], [TenXe], [So_dang_ky], [LoaiXe_ID_LoaiXe]) VALUES (1, N'SG-DL 1', N'1', 1)
ALTER TABLE [dbo].[Chuyen]  WITH CHECK ADD  CONSTRAINT [FK_Chuyen_Tai_Xe] FOREIGN KEY([Tai_xe_ID_TaiXe])
REFERENCES [dbo].[Tai_Xe] ([ID_TaiXe])
GO
ALTER TABLE [dbo].[Chuyen] CHECK CONSTRAINT [FK_Chuyen_Tai_Xe]
GO
ALTER TABLE [dbo].[Chuyen]  WITH CHECK ADD  CONSTRAINT [FK_Chuyen_Tuyen] FOREIGN KEY([Tuyen_ID_Tuyen])
REFERENCES [dbo].[Tuyen] ([ID_Tuyen])
GO
ALTER TABLE [dbo].[Chuyen] CHECK CONSTRAINT [FK_Chuyen_Tuyen]
GO
ALTER TABLE [dbo].[Chuyen]  WITH CHECK ADD  CONSTRAINT [FK_Chuyen_Xe] FOREIGN KEY([Xe_XeID])
REFERENCES [dbo].[Xe] ([XeID])
GO
ALTER TABLE [dbo].[Chuyen] CHECK CONSTRAINT [FK_Chuyen_Xe]
GO
ALTER TABLE [dbo].[Ghe]  WITH CHECK ADD  CONSTRAINT [FK_Ghe_Xe] FOREIGN KEY([Xe_XeID])
REFERENCES [dbo].[Xe] ([XeID])
GO
ALTER TABLE [dbo].[Ghe] CHECK CONSTRAINT [FK_Ghe_Xe]
GO
ALTER TABLE [dbo].[Tuyen]  WITH CHECK ADD  CONSTRAINT [FK_Tuyen_Tram] FOREIGN KEY([Tram_ID_Tram1])
REFERENCES [dbo].[Tram] ([ID_Tram])
GO
ALTER TABLE [dbo].[Tuyen] CHECK CONSTRAINT [FK_Tuyen_Tram]
GO
ALTER TABLE [dbo].[Tuyen]  WITH CHECK ADD  CONSTRAINT [FK_Tuyen_Tram1] FOREIGN KEY([Tram_ID_Tram])
REFERENCES [dbo].[Tram] ([ID_Tram])
GO
ALTER TABLE [dbo].[Tuyen] CHECK CONSTRAINT [FK_Tuyen_Tram1]
GO
ALTER TABLE [dbo].[Tram_Trung_Gian]  WITH CHECK ADD  CONSTRAINT [FK_Tram_Trung_Gian_Tuyen] FOREIGN KEY([Tuyen_ID_Tuyen])
REFERENCES [dbo].[Tuyen] ([ID_Tuyen])
GO
ALTER TABLE [dbo].[Tram_Trung_Gian] CHECK CONSTRAINT [FK_Tram_Trung_Gian_Tuyen]
GO
ALTER TABLE [dbo].[Tram_Trung_Gian]  WITH CHECK ADD  CONSTRAINT [FK_Tram_Trung_Gian_Tram] FOREIGN KEY([Tram_ID_Tram])
REFERENCES [dbo].[Tram] ([ID_Tram])
GO
ALTER TABLE [dbo].[Tram_Trung_Gian] CHECK CONSTRAINT [FK_Tram_Trung_Gian_Tram]
GO
ALTER TABLE [dbo].[Ve]  WITH CHECK ADD  CONSTRAINT [FK_Ve_Chuyen] FOREIGN KEY([Chuyen_ID_Chuyen])
REFERENCES [dbo].[Chuyen] ([ID_Chuyen])
GO
ALTER TABLE [dbo].[Ve] CHECK CONSTRAINT [FK_Ve_Chuyen]
GO
ALTER TABLE [dbo].[Ve]  WITH CHECK ADD  CONSTRAINT [FK_Ve_Ghe] FOREIGN KEY([Ghe_ID_Ghe])
REFERENCES [dbo].[Ghe] ([ID_Ghe])
GO
ALTER TABLE [dbo].[Ve] CHECK CONSTRAINT [FK_Ve_Ghe]
GO
ALTER TABLE [dbo].[Ve]  WITH CHECK ADD  CONSTRAINT [FK_Ve_KhachHang] FOREIGN KEY([KhachHang_ID_KhachHang])
REFERENCES [dbo].[KhachHang] ([ID_KhachHang])
GO
ALTER TABLE [dbo].[Ve] CHECK CONSTRAINT [FK_Ve_KhachHang]
GO
ALTER TABLE [dbo].[Xe]  WITH CHECK ADD  CONSTRAINT [FK_Xe_LoaiXe] FOREIGN KEY([LoaiXe_ID_LoaiXe])
REFERENCES [dbo].[LoaiXe] ([ID_LoaiXe])
GO
ALTER TABLE [dbo].[Xe] CHECK CONSTRAINT [FK_Xe_LoaiXe]
GO
USE [master]
GO
ALTER DATABASE [QUANLYVEXE] SET  READ_WRITE 
GO

USE [QUANLYVEXE]
GO
/****** Object:  Table [dbo].[Chuyen]    Script Date: 11/12/2018 4:14:19 CH ******/
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
/****** Object:  Table [dbo].[Ghe]    Script Date: 11/12/2018 4:14:19 CH ******/
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
 CONSTRAINT [PK_Ghe] PRIMARY KEY CLUSTERED 
(
	[ID_Ghe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 11/12/2018 4:14:19 CH ******/
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
/****** Object:  Table [dbo].[LoaiXe]    Script Date: 11/12/2018 4:14:19 CH ******/
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
/****** Object:  Table [dbo].[Tai_Xe]    Script Date: 11/12/2018 4:14:19 CH ******/
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
/****** Object:  Table [dbo].[Tuyen]    Script Date: 11/12/2018 4:14:19 CH ******/
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
 CONSTRAINT [PK_Tuyen] PRIMARY KEY CLUSTERED 
(
	[ID_Tuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tram]    Script Date: 11/12/2018 4:14:19 CH ******/
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
/****** Object:  Table [dbo].[Tram_Trung_Gian]    Script Date: 11/12/2018 4:14:19 CH ******/
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
/****** Object:  Table [dbo].[Ve]    Script Date: 11/12/2018 4:14:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ve](
	[ID_Ve] [int] NULL,
	[Ghe_ID_Ghe] [int] NULL,
	[Chuyen_ID_Chuyen] [int] NULL,
	[TinhTrang] [int] NULL,
	[GiaTien] [float] NULL,
	[KhachHang_ID_KhachHang] [int] NULL,
	[NgayXuatVe] [datetime] NULL,
	[GhiChu] [nvarchar](200) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Xe]    Script Date: 11/12/2018 4:14:19 CH ******/
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

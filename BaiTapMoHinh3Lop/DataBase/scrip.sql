USE [NHOM]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 11/17/2018 3:13:48 PM ******/
DROP TABLE [dbo].[Supplier]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 11/17/2018 3:13:48 PM ******/
DROP TABLE [dbo].[Products]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 11/17/2018 3:13:48 PM ******/
DROP TABLE [dbo].[Orders]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 11/17/2018 3:13:48 PM ******/
DROP TABLE [dbo].[Employees]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 11/17/2018 3:13:48 PM ******/
DROP TABLE [dbo].[Customers]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 11/17/2018 3:13:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[MaNhom] [nvarchar](50) NULL,
	[TenNhom] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 11/17/2018 3:13:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[MaNhom] [nvarchar](50) NULL,
	[TenNhom] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 11/17/2018 3:13:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[MaNhom] [nvarchar](50) NULL,
	[TenNhom] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 11/17/2018 3:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[MaNhom] [nvarchar](50) NULL,
	[TenNhom] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 11/17/2018 3:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier](
	[MaNhom] [nvarchar](50) NULL,
	[TenNhom] [nvarchar](50) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Customers] ([MaNhom], [TenNhom]) VALUES (N'1', N'Tống Nguyễn Hoàng Trung')
INSERT [dbo].[Customers] ([MaNhom], [TenNhom]) VALUES (N'2', N'Nguyễn Thanh Bình')
INSERT [dbo].[Customers] ([MaNhom], [TenNhom]) VALUES (N'3', N'Phạm Bá Long')
INSERT [dbo].[Customers] ([MaNhom], [TenNhom]) VALUES (N'4', N'Nguyễn Thế Vương')
INSERT [dbo].[Customers] ([MaNhom], [TenNhom]) VALUES (N'5', N'Nguyễn Ngọc Phương Uyên')
INSERT [dbo].[Customers] ([MaNhom], [TenNhom]) VALUES (N'6', N'Trần Thị Bích Phương')
INSERT [dbo].[Employees] ([MaNhom], [TenNhom]) VALUES (N'1', N'Nguyễn Ngọc Thiên Định')
INSERT [dbo].[Employees] ([MaNhom], [TenNhom]) VALUES (N'2', N'	Đặng Nhơn Nghĩa')
INSERT [dbo].[Employees] ([MaNhom], [TenNhom]) VALUES (N'3', N'Khổng Mai Phương')
INSERT [dbo].[Employees] ([MaNhom], [TenNhom]) VALUES (N'4', N'Đinh Thế Hiền Vương')
INSERT [dbo].[Employees] ([MaNhom], [TenNhom]) VALUES (N'5', N'	Trần Thanh Tuấn')
INSERT [dbo].[Employees] ([MaNhom], [TenNhom]) VALUES (N'6', N'	Huỳnh Bá Nghi')
INSERT [dbo].[Orders] ([MaNhom], [TenNhom]) VALUES (N'1', N'Nguyễn Hoàng Dũng')
INSERT [dbo].[Orders] ([MaNhom], [TenNhom]) VALUES (N'2', N'	Trương Hoàng Nam')
INSERT [dbo].[Orders] ([MaNhom], [TenNhom]) VALUES (N'3', N'Phạm Văn Sanh')
INSERT [dbo].[Orders] ([MaNhom], [TenNhom]) VALUES (N'4', N'Phan Văn Võ')
INSERT [dbo].[Orders] ([MaNhom], [TenNhom]) VALUES (N'5', N'Hà Minh Bảo Toàn')
INSERT [dbo].[Orders] ([MaNhom], [TenNhom]) VALUES (N'6', N'Nguyễn Văn Sang')
INSERT [dbo].[Products] ([MaNhom], [TenNhom]) VALUES (N'1', N'Phùng Thị Thúy')
INSERT [dbo].[Products] ([MaNhom], [TenNhom]) VALUES (N'2', N'	Đinh Hồng Ngọc')
INSERT [dbo].[Products] ([MaNhom], [TenNhom]) VALUES (N'3', N'	Huỳnh Bá Nghi')
INSERT [dbo].[Products] ([MaNhom], [TenNhom]) VALUES (N'4', N'Huỳnh Xuân Viên')
INSERT [dbo].[Products] ([MaNhom], [TenNhom]) VALUES (N'5', N'Nguyễn Mạnh Toàn')
INSERT [dbo].[Products] ([MaNhom], [TenNhom]) VALUES (N'6', N'Nguyễn Mạnh Toàn')
INSERT [dbo].[Supplier] ([MaNhom], [TenNhom]) VALUES (N'1', N'Phan Văn Bất')
INSERT [dbo].[Supplier] ([MaNhom], [TenNhom]) VALUES (N'2', N'	Đinh Hồng Ngọc')
INSERT [dbo].[Supplier] ([MaNhom], [TenNhom]) VALUES (N'3', N'	Phan Anh Việt')
INSERT [dbo].[Supplier] ([MaNhom], [TenNhom]) VALUES (N'4', N'Võ Thái Minh Tuệ')
INSERT [dbo].[Supplier] ([MaNhom], [TenNhom]) VALUES (N'5', N'Hà Đức Tần')

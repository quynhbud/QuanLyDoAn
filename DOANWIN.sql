USE [DBDOANWIN]
GO
/****** Object:  StoredProcedure [dbo].[Getkhoa]    Script Date: 6/27/2020 10:56:25 PM ******/
DROP PROCEDURE [dbo].[Getkhoa]
GO
ALTER TABLE [dbo].[Tien_do] DROP CONSTRAINT [FK_Tien_do_QLDASV]
GO
ALTER TABLE [dbo].[QLSV] DROP CONSTRAINT [FK_QLSV_Lop]
GO
ALTER TABLE [dbo].[QLGV] DROP CONSTRAINT [FK_QLGV_Nganh]
GO
ALTER TABLE [dbo].[QLDASV] DROP CONSTRAINT [FK_QLDASV_QLDA]
GO
ALTER TABLE [dbo].[QLDA] DROP CONSTRAINT [FK_QLDA_The_Loai]
GO
ALTER TABLE [dbo].[QLDA] DROP CONSTRAINT [FK_QLDA_Nganh]
GO
ALTER TABLE [dbo].[Nganh] DROP CONSTRAINT [FK_Nganh_Khoa]
GO
ALTER TABLE [dbo].[Lop] DROP CONSTRAINT [FK_Lop_Nganh]
GO
/****** Object:  Table [dbo].[Tien_do]    Script Date: 6/27/2020 10:56:25 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tien_do]') AND type in (N'U'))
DROP TABLE [dbo].[Tien_do]
GO
/****** Object:  Table [dbo].[The_Loai]    Script Date: 6/27/2020 10:56:25 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[The_Loai]') AND type in (N'U'))
DROP TABLE [dbo].[The_Loai]
GO
/****** Object:  Table [dbo].[QLUser]    Script Date: 6/27/2020 10:56:25 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[QLUser]') AND type in (N'U'))
DROP TABLE [dbo].[QLUser]
GO
/****** Object:  Table [dbo].[QLSV]    Script Date: 6/27/2020 10:56:25 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[QLSV]') AND type in (N'U'))
DROP TABLE [dbo].[QLSV]
GO
/****** Object:  Table [dbo].[QLGV]    Script Date: 6/27/2020 10:56:25 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[QLGV]') AND type in (N'U'))
DROP TABLE [dbo].[QLGV]
GO
/****** Object:  Table [dbo].[QLDASV]    Script Date: 6/27/2020 10:56:25 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[QLDASV]') AND type in (N'U'))
DROP TABLE [dbo].[QLDASV]
GO
/****** Object:  Table [dbo].[QLDA]    Script Date: 6/27/2020 10:56:25 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[QLDA]') AND type in (N'U'))
DROP TABLE [dbo].[QLDA]
GO
/****** Object:  Table [dbo].[Nganh]    Script Date: 6/27/2020 10:56:25 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Nganh]') AND type in (N'U'))
DROP TABLE [dbo].[Nganh]
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 6/27/2020 10:56:25 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Lop]') AND type in (N'U'))
DROP TABLE [dbo].[Lop]
GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 6/27/2020 10:56:25 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Khoa]') AND type in (N'U'))
DROP TABLE [dbo].[Khoa]
GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 6/27/2020 10:56:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khoa](
	[Ma khoa] [nvarchar](50) NOT NULL,
	[Ten khoa] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Khoa_1] PRIMARY KEY CLUSTERED 
(
	[Ma khoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 6/27/2020 10:56:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lop](
	[Ma lop] [nvarchar](50) NOT NULL,
	[Lop] [nvarchar](50) NOT NULL,
	[Ma Nganh] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Lop] PRIMARY KEY CLUSTERED 
(
	[Ma lop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nganh]    Script Date: 6/27/2020 10:56:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nganh](
	[Ma nganh] [nvarchar](50) NOT NULL,
	[Chuyen nganh] [nvarchar](50) NOT NULL,
	[Ma khoa] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Nganh] PRIMARY KEY CLUSTERED 
(
	[Ma nganh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QLDA]    Script Date: 6/27/2020 10:56:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QLDA](
	[Ma ĐA] [nvarchar](50) NOT NULL,
	[Ten ĐA] [nvarchar](50) NOT NULL,
	[The loai] [nvarchar](50) NOT NULL,
	[Chuyen nganh] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_QLDA] PRIMARY KEY CLUSTERED 
(
	[Ma ĐA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QLDASV]    Script Date: 6/27/2020 10:56:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QLDASV](
	[Ma DASV] [nvarchar](50) NOT NULL,
	[Ma DA] [nvarchar](50) NOT NULL,
	[Ten DA] [nvarchar](50) NOT NULL,
	[The loai] [nvarchar](50) NOT NULL,
	[Ma SV] [nvarchar](50) NOT NULL,
	[Ten SV] [nvarchar](50) NOT NULL,
	[Ma GV] [nvarchar](50) NOT NULL,
	[Ten GV] [nvarchar](50) NOT NULL,
	[Ngay bat dau] [nvarchar](50) NOT NULL,
	[Ngay ket thuc] [nvarchar](50) NOT NULL,
	[Link DA] [nchar](50) NULL,
 CONSTRAINT [PK_QLDASV] PRIMARY KEY CLUSTERED 
(
	[Ma DASV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QLGV]    Script Date: 6/27/2020 10:56:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QLGV](
	[Ma GV] [nvarchar](50) NOT NULL,
	[Ten GV] [nvarchar](50) NOT NULL,
	[Gioi tinh] [nvarchar](50) NULL,
	[Ngay sinh] [nvarchar](50) NULL,
	[Dia chi] [nvarchar](50) NULL,
	[SĐT] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Nganh] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_QLGV] PRIMARY KEY CLUSTERED 
(
	[Ma GV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QLSV]    Script Date: 6/27/2020 10:56:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QLSV](
	[Ma SV] [nvarchar](50) NOT NULL,
	[Ten SV] [nvarchar](50) NOT NULL,
	[Gioi tinh] [nvarchar](50) NULL,
	[Ngay sinh] [nvarchar](50) NULL,
	[Lop] [nvarchar](50) NOT NULL,
	[Dia chi] [nvarchar](50) NULL,
	[SĐT] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
 CONSTRAINT [PK_QLSV] PRIMARY KEY CLUSTERED 
(
	[Ma SV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QLUser]    Script Date: 6/27/2020 10:56:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QLUser](
	[Ten dang nhap] [nvarchar](50) NOT NULL,
	[Mat khau] [nvarchar](50) NOT NULL,
	[Quyen han] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_QLUser] PRIMARY KEY CLUSTERED 
(
	[Ten dang nhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[The_Loai]    Script Date: 6/27/2020 10:56:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[The_Loai](
	[Ma TL] [nvarchar](50) NOT NULL,
	[Ten TL] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_The_Loai_1] PRIMARY KEY CLUSTERED 
(
	[Ma TL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tien_do]    Script Date: 6/27/2020 10:56:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tien_do](
	[Ma DASV] [nvarchar](50) NOT NULL,
	[Báo cáo tiến độ lần 1] [nvarchar](50) NULL,
	[Báo cáo giữa kỳ] [nvarchar](50) NULL,
	[Báo cáo tiến độ lần 3] [nvarchar](50) NULL,
	[Báo cáo cuối kỳ] [nvarchar](50) NULL,
	[Link đồ án] [nvarchar](50) NULL,
 CONSTRAINT [PK_Tien_do] PRIMARY KEY CLUSTERED 
(
	[Ma DASV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Khoa] ([Ma khoa], [Ten khoa]) VALUES (N'K01', N'CNTT')
INSERT [dbo].[Khoa] ([Ma khoa], [Ten khoa]) VALUES (N'K02', N'Điện-Điện tử')
INSERT [dbo].[Khoa] ([Ma khoa], [Ten khoa]) VALUES (N'K03', N'Xây dựng')
GO
INSERT [dbo].[Lop] ([Ma lop], [Lop], [Ma Nganh]) VALUES (N'L01', N'CN01', N'N01')
INSERT [dbo].[Lop] ([Ma lop], [Lop], [Ma Nganh]) VALUES (N'L02', N'CN02', N'N02')
INSERT [dbo].[Lop] ([Ma lop], [Lop], [Ma Nganh]) VALUES (N'L03', N'ĐT01', N'N03')
INSERT [dbo].[Lop] ([Ma lop], [Lop], [Ma Nganh]) VALUES (N'L04', N'ĐT02', N'N04')
INSERT [dbo].[Lop] ([Ma lop], [Lop], [Ma Nganh]) VALUES (N'L05', N'XD01', N'N05')
INSERT [dbo].[Lop] ([Ma lop], [Lop], [Ma Nganh]) VALUES (N'L06', N'XD02', N'N06')
GO
INSERT [dbo].[Nganh] ([Ma nganh], [Chuyen nganh], [Ma khoa]) VALUES (N'N01', N'CNPM', N'K01')
INSERT [dbo].[Nganh] ([Ma nganh], [Chuyen nganh], [Ma khoa]) VALUES (N'N02', N'HTTT', N'K01')
INSERT [dbo].[Nganh] ([Ma nganh], [Chuyen nganh], [Ma khoa]) VALUES (N'N03', N'Tự động hóa', N'K02')
INSERT [dbo].[Nganh] ([Ma nganh], [Chuyen nganh], [Ma khoa]) VALUES (N'N04', N'Hệ thống điện', N'K02')
INSERT [dbo].[Nganh] ([Ma nganh], [Chuyen nganh], [Ma khoa]) VALUES (N'N05', N'Kỹ thuật đô thị', N'K03')
INSERT [dbo].[Nganh] ([Ma nganh], [Chuyen nganh], [Ma khoa]) VALUES (N'N06', N'Xây dựng cầu đường', N'K03')
GO
INSERT [dbo].[QLDA] ([Ma ĐA], [Ten ĐA], [The loai], [Chuyen nganh]) VALUES (N'DA01', N'QLSV', N'TL01', N'N02')
INSERT [dbo].[QLDA] ([Ma ĐA], [Ten ĐA], [The loai], [Chuyen nganh]) VALUES (N'DA02', N'Game Cờ Vua', N'TL02', N'N01')
INSERT [dbo].[QLDA] ([Ma ĐA], [Ten ĐA], [The loai], [Chuyen nganh]) VALUES (N'DA03', N'QL Bán Hàng', N'TL01', N'N02')
INSERT [dbo].[QLDA] ([Ma ĐA], [Ten ĐA], [The loai], [Chuyen nganh]) VALUES (N'DA04', N'Game Cờ Caro', N'TL03', N'N01')
INSERT [dbo].[QLDA] ([Ma ĐA], [Ten ĐA], [The loai], [Chuyen nganh]) VALUES (N'DA05', N'QL Doanh Nghiệp', N'TL01', N'N02')
INSERT [dbo].[QLDA] ([Ma ĐA], [Ten ĐA], [The loai], [Chuyen nganh]) VALUES (N'DA06', N'Thiết Kế Mạch Điện Tử', N'TL02', N'N03')
INSERT [dbo].[QLDA] ([Ma ĐA], [Ten ĐA], [The loai], [Chuyen nganh]) VALUES (N'DA07', N'Xe Đua', N'TL01', N'N03')
INSERT [dbo].[QLDA] ([Ma ĐA], [Ten ĐA], [The loai], [Chuyen nganh]) VALUES (N'DA08', N'Nhà Thông Minh', N'TL02', N'N03')
INSERT [dbo].[QLDA] ([Ma ĐA], [Ten ĐA], [The loai], [Chuyen nganh]) VALUES (N'DA09', N'Điện Gia Đình', N'TL03', N'N04')
INSERT [dbo].[QLDA] ([Ma ĐA], [Ten ĐA], [The loai], [Chuyen nganh]) VALUES (N'DA10', N'Mạch Điện Tử', N'TL01', N'N04')
INSERT [dbo].[QLDA] ([Ma ĐA], [Ten ĐA], [The loai], [Chuyen nganh]) VALUES (N'DA11', N'Cây Tìm Kiếm', N'TL03', N'N01')
INSERT [dbo].[QLDA] ([Ma ĐA], [Ten ĐA], [The loai], [Chuyen nganh]) VALUES (N'DA12', N'Mô Hình Đô Thị', N'TL03', N'N05')
INSERT [dbo].[QLDA] ([Ma ĐA], [Ten ĐA], [The loai], [Chuyen nganh]) VALUES (N'DA13', N'Đô Thị Thông Minh', N'TL02', N'N05')
INSERT [dbo].[QLDA] ([Ma ĐA], [Ten ĐA], [The loai], [Chuyen nganh]) VALUES (N'DA14', N'Mô Hình Cây Cầu', N'TL01', N'N06')
INSERT [dbo].[QLDA] ([Ma ĐA], [Ten ĐA], [The loai], [Chuyen nganh]) VALUES (N'DA15', N'Cầu Treo ', N'TL03', N'N06')
INSERT [dbo].[QLDA] ([Ma ĐA], [Ten ĐA], [The loai], [Chuyen nganh]) VALUES (N'DA16', N'Thiết Kế Đường Ống Thoát', N'TL01', N'N06')
GO
INSERT [dbo].[QLDASV] ([Ma DASV], [Ma DA], [Ten DA], [The loai], [Ma SV], [Ten SV], [Ma GV], [Ten GV], [Ngay bat dau], [Ngay ket thuc], [Link DA]) VALUES (N'DASV01', N'DA02', N'Game Cờ Vua', N'TL02', N'SV01', N'Bùi Thanh Ngà', N'GV01', N'Trần Đình Nghĩa', N'01/01/2020', N'30/01/2020', N'https://bitly.com.vn/ukB2b                        ')
INSERT [dbo].[QLDASV] ([Ma DASV], [Ma DA], [Ten DA], [The loai], [Ma SV], [Ten SV], [Ma GV], [Ten GV], [Ngay bat dau], [Ngay ket thuc], [Link DA]) VALUES (N'DASV02', N'DA06', N'Thiết Kế Mạch Điện Tử', N'TL02', N'SV02', N'Cao Văn Thân', N'GV02', N'Trần Mạnh Tiến', N'02/05/2020', N'30/06/2020', N'https://bitly.com.vn/ukB2b                        ')
INSERT [dbo].[QLDASV] ([Ma DASV], [Ma DA], [Ten DA], [The loai], [Ma SV], [Ten SV], [Ma GV], [Ten GV], [Ngay bat dau], [Ngay ket thuc], [Link DA]) VALUES (N'DASV03', N'DA12', N'Mô Hình Đô Thị', N'TL03', N'SV03', N'Châu Thị Hồng Ngọc', N'GV03', N'Nguyễn Thị Phương Hoa', N'29/04/2020', N'25/05/2020', N'https://bitly.com.vn/ukB2b                        ')
INSERT [dbo].[QLDASV] ([Ma DASV], [Ma DA], [Ten DA], [The loai], [Ma SV], [Ten SV], [Ma GV], [Ten GV], [Ngay bat dau], [Ngay ket thuc], [Link DA]) VALUES (N'DASV04', N'DA02', N'Game Cờ Vua', N'TL02', N'SV04', N'Châu Thị Huệ', N'GV07', N'Cao Hoàng Sơn', N'30/04/2020', N'28/05/2020', N'https://bitly.com.vn/ukB2b                        ')
INSERT [dbo].[QLDASV] ([Ma DASV], [Ma DA], [Ten DA], [The loai], [Ma SV], [Ten SV], [Ma GV], [Ten GV], [Ngay bat dau], [Ngay ket thuc], [Link DA]) VALUES (N'DASV05', N'DA03', N'QL Bán Hàng', N'TL01', N'SV05', N'Diệc Bội Thi', N'GV04', N'Dương Phạm Kiên', N'02/05/2020', N'15/06/2020', N'https://bitly.com.vn/ukB2b                        ')
INSERT [dbo].[QLDASV] ([Ma DASV], [Ma DA], [Ten DA], [The loai], [Ma SV], [Ten SV], [Ma GV], [Ten GV], [Ngay bat dau], [Ngay ket thuc], [Link DA]) VALUES (N'DASV06', N'DA07', N'Xe Đua', N'TL01', N'SV06', N'Dương Tử Quỳnh', N'GV08', N'Lê Hoàng Minh', N'05/05/2020', N'28/06/2020', N'https://bitly.com.vn/ukB2b                        ')
INSERT [dbo].[QLDASV] ([Ma DASV], [Ma DA], [Ten DA], [The loai], [Ma SV], [Ten SV], [Ma GV], [Ten GV], [Ngay bat dau], [Ngay ket thuc], [Link DA]) VALUES (N'DASV07', N'DA13', N'Đô Thị Thông Minh', N'TL02', N'SV07', N'Đặng Nguyên', N'GV09', N'Đặng  Thị Bích Ngọc', N'06/05/2020', N'20/06/2020', N'https://bitly.com.vn/ukB2b                        ')
INSERT [dbo].[QLDASV] ([Ma DASV], [Ma DA], [Ten DA], [The loai], [Ma SV], [Ten SV], [Ma GV], [Ten GV], [Ngay bat dau], [Ngay ket thuc], [Link DA]) VALUES (N'DASV08', N'DA05', N'QL Doanh Nghiệp', N'TL01', N'SV08', N'Đặng Thị Kim Phương', N'GV10', N'Trương Minh Kiệt', N'01/05/2020', N'05/07/2020', N'https://bitly.com.vn/ukB2b                        ')
INSERT [dbo].[QLDASV] ([Ma DASV], [Ma DA], [Ten DA], [The loai], [Ma SV], [Ten SV], [Ma GV], [Ten GV], [Ngay bat dau], [Ngay ket thuc], [Link DA]) VALUES (N'DASV09', N'DA08', N'Nhà Thông Minh', N'TL02', N'SV09', N'Đinh Bằng Phi', N'GV02', N'Trần Mạnh Tiến', N'29/04/2020', N'05/06/2020', N'https://bitly.com.vn/ukB2b                        ')
INSERT [dbo].[QLDASV] ([Ma DASV], [Ma DA], [Ten DA], [The loai], [Ma SV], [Ten SV], [Ma GV], [Ten GV], [Ngay bat dau], [Ngay ket thuc], [Link DA]) VALUES (N'DASV10', N'DA14', N'Mô Hình Cây Cầu', N'TL01', N'SV15', N'Mã Như Ngọc', N'GV12', N'Phạm Hồng Sơn', N'11/05/2020', N'15/07/2020', N'https://bitly.com.vn/ukB2b                        ')
INSERT [dbo].[QLDASV] ([Ma DASV], [Ma DA], [Ten DA], [The loai], [Ma SV], [Ten SV], [Ma GV], [Ten GV], [Ngay bat dau], [Ngay ket thuc], [Link DA]) VALUES (N'DASV11', N'DA01', N'QLSV', N'TL02', N'SV08', N'Đặng Thị Kim Phương', N'GV10', N'Trương Minh Kiệt', N'10/04/2020', N'30/05/2020', N'                                                  ')
INSERT [dbo].[QLDASV] ([Ma DASV], [Ma DA], [Ten DA], [The loai], [Ma SV], [Ten SV], [Ma GV], [Ten GV], [Ngay bat dau], [Ngay ket thuc], [Link DA]) VALUES (N'DASV12', N'DA05', N'QL Doanh Nghiệp', N'TL02', N'SV14', N'Lương Công Định', N'GV10', N'Trương Minh Kiệt', N'01/05/2020', N'30/06/2020', N'https://bitly.com.vn/ukB2b                        ')
GO
INSERT [dbo].[QLGV] ([Ma GV], [Ten GV], [Gioi tinh], [Ngay sinh], [Dia chi], [SĐT], [Email], [Nganh]) VALUES (N'GV01', N'Trần Đình Nghĩa', N'Nam', N'01/01/1988', N'TPHCM', N'0981498232', N'gv01@gmail.com', N'N01')
INSERT [dbo].[QLGV] ([Ma GV], [Ten GV], [Gioi tinh], [Ngay sinh], [Dia chi], [SĐT], [Email], [Nganh]) VALUES (N'GV02', N'Trần Mạnh Tiến', N'Nam', N'02/10/1970', N'Kiên Giang', N'0364287182', N'gv02@gmail.com', N'N03')
INSERT [dbo].[QLGV] ([Ma GV], [Ten GV], [Gioi tinh], [Ngay sinh], [Dia chi], [SĐT], [Email], [Nganh]) VALUES (N'GV03', N'Nguyễn Thị Phương Hoa', N'Nữ', N'05/12/1990', N'Đồng Nai', N'0942345872', N'gv03@gmail.com', N'N05')
INSERT [dbo].[QLGV] ([Ma GV], [Ten GV], [Gioi tinh], [Ngay sinh], [Dia chi], [SĐT], [Email], [Nganh]) VALUES (N'GV04', N'Dương Phạm Kiên', N'Nam', N'23/12/1986', N'Hà Nội ', N'0346587838', N'gv04@gmail.com', N'N02')
INSERT [dbo].[QLGV] ([Ma GV], [Ten GV], [Gioi tinh], [Ngay sinh], [Dia chi], [SĐT], [Email], [Nganh]) VALUES (N'GV05', N'Châu Tấn Đạt', N'Nam ', N'26/11/1985', N'Quảng Ngãi ', N'0934278499', N'gv05@gmail.com', N'N04')
INSERT [dbo].[QLGV] ([Ma GV], [Ten GV], [Gioi tinh], [Ngay sinh], [Dia chi], [SĐT], [Email], [Nganh]) VALUES (N'GV06', N'Trương Hồng Mai', N'Nữ ', N'13/04/1990', N'Khánh Hòa', N'0346572822', N'gv06@gmail.com', N'N06')
INSERT [dbo].[QLGV] ([Ma GV], [Ten GV], [Gioi tinh], [Ngay sinh], [Dia chi], [SĐT], [Email], [Nganh]) VALUES (N'GV07', N'Cao Hoàng Sơn ', N'Nam ', N'15/02/1960', N'Bình Thuận ', N'0345588888', N'gv07@gmail.com', N'N01')
INSERT [dbo].[QLGV] ([Ma GV], [Ten GV], [Gioi tinh], [Ngay sinh], [Dia chi], [SĐT], [Email], [Nganh]) VALUES (N'GV08', N'Lê Hoàng Minh ', N'Nam ', N'05/06/1984', N'Quảng Nam', N'0924817354', N'gv08@gmail.com', N'N03')
INSERT [dbo].[QLGV] ([Ma GV], [Ten GV], [Gioi tinh], [Ngay sinh], [Dia chi], [SĐT], [Email], [Nganh]) VALUES (N'GV09', N'Đặng  Thị Bích Ngọc', N'Nữ ', N'14/09/1985', N'TPHCM', N'0334576281', N'gv09@gmail.com', N'N05')
INSERT [dbo].[QLGV] ([Ma GV], [Ten GV], [Gioi tinh], [Ngay sinh], [Dia chi], [SĐT], [Email], [Nganh]) VALUES (N'GV10', N'Trương Minh Kiệt', N'Nam ', N'18/06/1990', N'Quảng Ngãi ', N'0982647218', N'gv10@gmail.com', N'N02')
INSERT [dbo].[QLGV] ([Ma GV], [Ten GV], [Gioi tinh], [Ngay sinh], [Dia chi], [SĐT], [Email], [Nganh]) VALUES (N'GV11', N'Nguyễn Thị Hoa', N'Nữ', N'12/07/1987', N'Đà Nẵng', N'0934857822', N'gv11@gmail.com', N'N04')
INSERT [dbo].[QLGV] ([Ma GV], [Ten GV], [Gioi tinh], [Ngay sinh], [Dia chi], [SĐT], [Email], [Nganh]) VALUES (N'GV12', N'Phạm Hồng Sơn ', N'Nam ', N'23/09/1980', N'Hà Tĩnh', N'0339869892', N'gv12@gmail.com', N'N06')
GO
INSERT [dbo].[QLSV] ([Ma SV], [Ten SV], [Gioi tinh], [Ngay sinh], [Lop], [Dia chi], [SĐT], [Email]) VALUES (N'SV01', N'Bùi Thanh Ngà', N'Nữ', N'23/12/2000', N'L01', N'Hà Nội ', N'0920834881', N'sv01@gmail.com')
INSERT [dbo].[QLSV] ([Ma SV], [Ten SV], [Gioi tinh], [Ngay sinh], [Lop], [Dia chi], [SĐT], [Email]) VALUES (N'SV02', N'Cao Văn Thân ', N'Nam ', N'12/04/1999', N'L03', N'Nam Định', N'0923342345', N'sv02@gmail.com')
INSERT [dbo].[QLSV] ([Ma SV], [Ten SV], [Gioi tinh], [Ngay sinh], [Lop], [Dia chi], [SĐT], [Email]) VALUES (N'SV03', N'Châu Thị Hồng Ngọc ', N'Nữ ', N'16/01/1999', N'L05', N'Khánh Hòa ', N'0992738776', N'sv03@gmail.com')
INSERT [dbo].[QLSV] ([Ma SV], [Ten SV], [Gioi tinh], [Ngay sinh], [Lop], [Dia chi], [SĐT], [Email]) VALUES (N'SV04', N'Châu Thị Huệ', N'Nữ ', N'12/09/2000', N'L01', N'Huế', N'0334367821', N'sv04@gmail.com')
INSERT [dbo].[QLSV] ([Ma SV], [Ten SV], [Gioi tinh], [Ngay sinh], [Lop], [Dia chi], [SĐT], [Email]) VALUES (N'SV05', N'Diệc Bội Thi', N'Nữ', N'10/11/2000', N'L02', N'Lạng Sơn ', N'0398864761', N'sv05@gmail.com')
INSERT [dbo].[QLSV] ([Ma SV], [Ten SV], [Gioi tinh], [Ngay sinh], [Lop], [Dia chi], [SĐT], [Email]) VALUES (N'SV06', N'Dương Tử Quỳnh ', N'Nữ ', N'25/11/1999', N'L03', N'Bến Tro', N'0982467163', N'sv06@gmail.com')
INSERT [dbo].[QLSV] ([Ma SV], [Ten SV], [Gioi tinh], [Ngay sinh], [Lop], [Dia chi], [SĐT], [Email]) VALUES (N'SV07', N'Đặng Nguyên', N'Nam ', N'27/08/1999', N'L05', N'Tây Ninh', N'0982375611', N'sv07@gmail.com')
INSERT [dbo].[QLSV] ([Ma SV], [Ten SV], [Gioi tinh], [Ngay sinh], [Lop], [Dia chi], [SĐT], [Email]) VALUES (N'SV08', N'Đặng Thị Kim Phương', N'Nữ ', N'19/12/2000', N'L02', N'An Giang ', N'0923871100', N'sv08@gmail.com')
INSERT [dbo].[QLSV] ([Ma SV], [Ten SV], [Gioi tinh], [Ngay sinh], [Lop], [Dia chi], [SĐT], [Email]) VALUES (N'SV09', N'Đinh Bằng Phi ', N'Nam', N'12/12/1999', N'L03', N'Kon Tum', N'0981238481', N'sv09@gmail.com')
INSERT [dbo].[QLSV] ([Ma SV], [Ten SV], [Gioi tinh], [Ngay sinh], [Lop], [Dia chi], [SĐT], [Email]) VALUES (N'SV10', N'Đỗ Thu Phương', N'Nữ', N'18/06/1999', N'L05', N'Vũng Tàu', N'0935644567', N'sv10@gmail.com')
INSERT [dbo].[QLSV] ([Ma SV], [Ten SV], [Gioi tinh], [Ngay sinh], [Lop], [Dia chi], [SĐT], [Email]) VALUES (N'SV11', N'Hà Minh Tuấn ', N'Nữ ', N'02/01/1998', N'L04', N'Bình Định ', N'0912874876', N'sv11@gmail.com')
INSERT [dbo].[QLSV] ([Ma SV], [Ten SV], [Gioi tinh], [Ngay sinh], [Lop], [Dia chi], [SĐT], [Email]) VALUES (N'SV12', N'Hà Chế Bình ', N'Nam ', N'09/12/2000', N'L01', N'TPHCM', N'0338975829', N'sv12@gmail.com')
INSERT [dbo].[QLSV] ([Ma SV], [Ten SV], [Gioi tinh], [Ngay sinh], [Lop], [Dia chi], [SĐT], [Email]) VALUES (N'SV13', N'Nguyễn Thị Bích Cẩm ', N'Nữ ', N'22/09/1999', N'L05', N'Cà Mau', N'0999826716', N'sv13@gmail.com')
INSERT [dbo].[QLSV] ([Ma SV], [Ten SV], [Gioi tinh], [Ngay sinh], [Lop], [Dia chi], [SĐT], [Email]) VALUES (N'SV14', N'Lương Công Định', N'Nam', N'01/01/2000', N'L02', N'Bắc Ninh', N'0338759281', N'sv14@gmail.com')
INSERT [dbo].[QLSV] ([Ma SV], [Ten SV], [Gioi tinh], [Ngay sinh], [Lop], [Dia chi], [SĐT], [Email]) VALUES (N'SV15', N'Mã Như Ngọc ', N'Nữ ', N'28/11/2000', N'L06', N'TPHCM', N'0928367169', N'sv15@gmail.com')
INSERT [dbo].[QLSV] ([Ma SV], [Ten SV], [Gioi tinh], [Ngay sinh], [Lop], [Dia chi], [SĐT], [Email]) VALUES (N'SV16', N'Lương Hoài Ân', N'Nữ ', N'02/12/1998', N'L04', N'Bình Thuận', N'0987872381', N'sv16@gmail.com')
GO
INSERT [dbo].[QLUser] ([Ten dang nhap], [Mat khau], [Quyen han]) VALUES (N'Nunu', N'123456', N'Admin')
INSERT [dbo].[QLUser] ([Ten dang nhap], [Mat khau], [Quyen han]) VALUES (N'Thuthu12', N'12345678', N'Người dùng')
INSERT [dbo].[QLUser] ([Ten dang nhap], [Mat khau], [Quyen han]) VALUES (N'user1', N'123456', N'Người dùng')
INSERT [dbo].[QLUser] ([Ten dang nhap], [Mat khau], [Quyen han]) VALUES (N'user2', N'123456', N'Người dùng')
INSERT [dbo].[QLUser] ([Ten dang nhap], [Mat khau], [Quyen han]) VALUES (N'vyvy', N'123456', N'Admin')
GO
INSERT [dbo].[The_Loai] ([Ma TL], [Ten TL]) VALUES (N'TL01', N'Đồ án môn học')
INSERT [dbo].[The_Loai] ([Ma TL], [Ten TL]) VALUES (N'TL02', N'Đồ án chuyên ngành')
INSERT [dbo].[The_Loai] ([Ma TL], [Ten TL]) VALUES (N'TL03', N'Đồ án tiểu luận')
GO
INSERT [dbo].[Tien_do] ([Ma DASV], [Báo cáo tiến độ lần 1], [Báo cáo giữa kỳ], [Báo cáo tiến độ lần 3], [Báo cáo cuối kỳ], [Link đồ án]) VALUES (N'DASV01', N'Hoàn Thành', N'Hoàn Thành', N'Hoàn Thành', N'Hoàn Thành', NULL)
INSERT [dbo].[Tien_do] ([Ma DASV], [Báo cáo tiến độ lần 1], [Báo cáo giữa kỳ], [Báo cáo tiến độ lần 3], [Báo cáo cuối kỳ], [Link đồ án]) VALUES (N'DASV02', N'Hoàn Thành', N'Hoàn Thành', N'Chưa Hoàn Thành', N'Chưa Hoàn Thành', N'https://bitly.com.vn/ukB2b')
INSERT [dbo].[Tien_do] ([Ma DASV], [Báo cáo tiến độ lần 1], [Báo cáo giữa kỳ], [Báo cáo tiến độ lần 3], [Báo cáo cuối kỳ], [Link đồ án]) VALUES (N'DASV03', N'Hoàn Thành', N'Hoàn Thành', N'Hoàn Thành', N'Hoàn Thành', N'https://bitly.com.vn/ukB2b')
INSERT [dbo].[Tien_do] ([Ma DASV], [Báo cáo tiến độ lần 1], [Báo cáo giữa kỳ], [Báo cáo tiến độ lần 3], [Báo cáo cuối kỳ], [Link đồ án]) VALUES (N'DASV04', N'Hoàn Thành', N'Hoàn Thành', N'Hoàn Thành', N'Hoàn Thành', N'https://bitly.com.vn/ukB2b')
INSERT [dbo].[Tien_do] ([Ma DASV], [Báo cáo tiến độ lần 1], [Báo cáo giữa kỳ], [Báo cáo tiến độ lần 3], [Báo cáo cuối kỳ], [Link đồ án]) VALUES (N'DASV05', N'Hoàn Thành', N'Hoàn Thành', N'Chưa Hoàn Thành', N'Chưa Hoàn Thành', N'https://bitly.com.vn/ukB2b')
INSERT [dbo].[Tien_do] ([Ma DASV], [Báo cáo tiến độ lần 1], [Báo cáo giữa kỳ], [Báo cáo tiến độ lần 3], [Báo cáo cuối kỳ], [Link đồ án]) VALUES (N'DASV06', N'Hoàn Thành', N'Hoàn Thành', N'Chưa Hoàn Thành', N'Chưa Hoàn Thành', N'https://bitly.com.vn/ukB2b')
INSERT [dbo].[Tien_do] ([Ma DASV], [Báo cáo tiến độ lần 1], [Báo cáo giữa kỳ], [Báo cáo tiến độ lần 3], [Báo cáo cuối kỳ], [Link đồ án]) VALUES (N'DASV07', N'Hoàn Thành', N'Hoàn Thành', N'Chưa Hoàn Thành', N'Chưa Hoàn Thành', N'https://bitly.com.vn/ukB2b')
INSERT [dbo].[Tien_do] ([Ma DASV], [Báo cáo tiến độ lần 1], [Báo cáo giữa kỳ], [Báo cáo tiến độ lần 3], [Báo cáo cuối kỳ], [Link đồ án]) VALUES (N'DASV08', N'Hoàn Thành', N'Hoàn Thành', N'Chưa Hoàn Thành', N'Chưa Hoàn Thành', N'https://bitly.com.vn/ukB2b')
INSERT [dbo].[Tien_do] ([Ma DASV], [Báo cáo tiến độ lần 1], [Báo cáo giữa kỳ], [Báo cáo tiến độ lần 3], [Báo cáo cuối kỳ], [Link đồ án]) VALUES (N'DASV09', N'Hoàn Thành', N'Hoàn Thành', N'Hoàn Thành', N'Chưa Hoàn Thành', N'https://bitly.com.vn/ukB2b')
INSERT [dbo].[Tien_do] ([Ma DASV], [Báo cáo tiến độ lần 1], [Báo cáo giữa kỳ], [Báo cáo tiến độ lần 3], [Báo cáo cuối kỳ], [Link đồ án]) VALUES (N'DASV10', N'Hoàn Thành', N'Hoàn Thành', N'Chưa Hoàn Thành', N'Chưa Hoàn Thành', N'https://bitly.com.vn/ukB2b')
INSERT [dbo].[Tien_do] ([Ma DASV], [Báo cáo tiến độ lần 1], [Báo cáo giữa kỳ], [Báo cáo tiến độ lần 3], [Báo cáo cuối kỳ], [Link đồ án]) VALUES (N'DASV11', N'Hoàn Thành', N'Hoàn Thành', N'Hoàn Thành', N'Chưa Hoàn Thành', NULL)
INSERT [dbo].[Tien_do] ([Ma DASV], [Báo cáo tiến độ lần 1], [Báo cáo giữa kỳ], [Báo cáo tiến độ lần 3], [Báo cáo cuối kỳ], [Link đồ án]) VALUES (N'DASV12', N'Hoàn Thành', N'Hoàn Thành', N'Chưa Hoàn Thành', N'Chưa Hoàn Thành', NULL)
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD  CONSTRAINT [FK_Lop_Nganh] FOREIGN KEY([Ma Nganh])
REFERENCES [dbo].[Nganh] ([Ma nganh])
GO
ALTER TABLE [dbo].[Lop] CHECK CONSTRAINT [FK_Lop_Nganh]
GO
ALTER TABLE [dbo].[Nganh]  WITH CHECK ADD  CONSTRAINT [FK_Nganh_Khoa] FOREIGN KEY([Ma khoa])
REFERENCES [dbo].[Khoa] ([Ma khoa])
GO
ALTER TABLE [dbo].[Nganh] CHECK CONSTRAINT [FK_Nganh_Khoa]
GO
ALTER TABLE [dbo].[QLDA]  WITH CHECK ADD  CONSTRAINT [FK_QLDA_Nganh] FOREIGN KEY([Chuyen nganh])
REFERENCES [dbo].[Nganh] ([Ma nganh])
GO
ALTER TABLE [dbo].[QLDA] CHECK CONSTRAINT [FK_QLDA_Nganh]
GO
ALTER TABLE [dbo].[QLDA]  WITH CHECK ADD  CONSTRAINT [FK_QLDA_The_Loai] FOREIGN KEY([The loai])
REFERENCES [dbo].[The_Loai] ([Ma TL])
GO
ALTER TABLE [dbo].[QLDA] CHECK CONSTRAINT [FK_QLDA_The_Loai]
GO
ALTER TABLE [dbo].[QLDASV]  WITH CHECK ADD  CONSTRAINT [FK_QLDASV_QLDA] FOREIGN KEY([Ma DA])
REFERENCES [dbo].[QLDA] ([Ma ĐA])
GO
ALTER TABLE [dbo].[QLDASV] CHECK CONSTRAINT [FK_QLDASV_QLDA]
GO
ALTER TABLE [dbo].[QLGV]  WITH CHECK ADD  CONSTRAINT [FK_QLGV_Nganh] FOREIGN KEY([Nganh])
REFERENCES [dbo].[Nganh] ([Ma nganh])
GO
ALTER TABLE [dbo].[QLGV] CHECK CONSTRAINT [FK_QLGV_Nganh]
GO
ALTER TABLE [dbo].[QLSV]  WITH CHECK ADD  CONSTRAINT [FK_QLSV_Lop] FOREIGN KEY([Lop])
REFERENCES [dbo].[Lop] ([Ma lop])
GO
ALTER TABLE [dbo].[QLSV] CHECK CONSTRAINT [FK_QLSV_Lop]
GO
ALTER TABLE [dbo].[Tien_do]  WITH CHECK ADD  CONSTRAINT [FK_Tien_do_QLDASV] FOREIGN KEY([Ma DASV])
REFERENCES [dbo].[QLDASV] ([Ma DASV])
GO
ALTER TABLE [dbo].[Tien_do] CHECK CONSTRAINT [FK_Tien_do_QLDASV]
GO
/****** Object:  StoredProcedure [dbo].[Getkhoa]    Script Date: 6/27/2020 10:56:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Getkhoa]
 as select * from Khoa
GO

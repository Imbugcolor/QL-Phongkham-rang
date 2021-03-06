USE [PhòngKhám]
GO
/****** Object:  Table [dbo].[BÁC SĨ]    Script Date: 11/03/2022 13:55:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BÁC SĨ](
	[MS] [nchar](10) NOT NULL,
	[hotenbs] [nvarchar](50) NULL,
	[Ngaysinh] [nvarchar](50) NULL,
	[Gioitinh] [nchar](10) NULL,
	[sdt] [nvarchar](10) NULL,
	[diachi] [nvarchar](50) NULL,
 CONSTRAINT [PK_BÁC SĨ] PRIMARY KEY CLUSTERED 
(
	[MS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BỆNH NHÂN]    Script Date: 11/03/2022 13:55:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BỆNH NHÂN](
	[MBN] [nchar](10) NOT NULL,
	[hotenbn] [nvarchar](50) NULL,
	[ngaysinh] [nvarchar](50) NULL,
	[gioitinh] [nchar](10) NULL,
	[sdt] [nvarchar](10) NULL,
	[diachi] [nvarchar](50) NULL,
	[ghichu] [nvarchar](50) NOT NULL,
	[ngaykham] [nvarchar](50) NULL,
 CONSTRAINT [PK_BỆNH NHÂN] PRIMARY KEY CLUSTERED 
(
	[MBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dangky]    Script Date: 11/03/2022 13:55:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dangky](
	[Madk] [nchar](15) NOT NULL,
	[hotendk] [nvarchar](30) NULL,
	[thoigiandk] [nvarchar](30) NULL,
	[thoigianhen] [nvarchar](30) NULL,
	[buoihen] [nvarchar](10) NULL,
	[sdtdk] [nvarchar](11) NULL,
	[ghichudk] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Madk] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[staff_user]    Script Date: 11/03/2022 13:55:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[staff_user](
	[namestaff] [nchar](15) NOT NULL,
	[passstaff] [nvarchar](100) NULL,
 CONSTRAINT [PK_staff_user] PRIMARY KEY CLUSTERED 
(
	[namestaff] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user]    Script Date: 11/03/2022 13:55:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user](
	[username] [nchar](15) NOT NULL,
	[password] [nvarchar](15) NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BÁC SĨ] ([MS], [hotenbs], [Ngaysinh], [Gioitinh], [sdt], [diachi]) VALUES (N'BS001     ', N'NGUYỄN VĂN LÂM', N'1990-5-18', N'NAM       ', N'0905286503', N'71- HAI BÀ TRƯNG -QUẬN 1')
INSERT [dbo].[BÁC SĨ] ([MS], [hotenbs], [Ngaysinh], [Gioitinh], [sdt], [diachi]) VALUES (N'BS004     ', N'TRẦN THÚY VY', N'1994-5-24', N'NỮ        ', N'0234348647', N'123 - NGYỄN VĂN CỪ - THỦ ĐỨC')
INSERT [dbo].[BÁC SĨ] ([MS], [hotenbs], [Ngaysinh], [Gioitinh], [sdt], [diachi]) VALUES (N'BS005     ', N'CAO GIA HUY', N'1988-6-1', N'NAM       ', N'0392834289', N'176- TRẦN THỊ TRANG -QUẬN 2')
INSERT [dbo].[BÁC SĨ] ([MS], [hotenbs], [Ngaysinh], [Gioitinh], [sdt], [diachi]) VALUES (N'BS006     ', N'PHAN THỊ NGỌC', N'1992-12-11', N'NỮ        ', N'0186351671', N'767- NGUYỄN VĂN CỪ - GÒ VẤP')
INSERT [dbo].[BÁC SĨ] ([MS], [hotenbs], [Ngaysinh], [Gioitinh], [sdt], [diachi]) VALUES (N'BS007     ', N'TRẦN ANH', N'1982-12-3', N'NỮ        ', N'0652462842', N'67- XÔ VIẾT NGHỆ TĨNH-BÌNH THẠNH')
INSERT [dbo].[BÁC SĨ] ([MS], [hotenbs], [Ngaysinh], [Gioitinh], [sdt], [diachi]) VALUES (N'BS008     ', N'PHAN THẾ TRUNG', N'1984-6-3', N'NAM       ', N'0234234342', N'324- NGUYỄN HỮU CÃNH- QUẬN 5')
INSERT [dbo].[BÁC SĨ] ([MS], [hotenbs], [Ngaysinh], [Gioitinh], [sdt], [diachi]) VALUES (N'BS009     ', N'NGUYỄN THỊ TRÀ', N'1982-7-3', N'NỮ        ', N'0234234235', N'34- VẠN HẠNH- QUẬN 5')
INSERT [dbo].[BÁC SĨ] ([MS], [hotenbs], [Ngaysinh], [Gioitinh], [sdt], [diachi]) VALUES (N'BS010     ', N'PHẠM THỊ THỦY', N'1983-8-23', N'NỮ        ', N'0827469826', N'23- VÕ THỊ SÁU -QUẬN 1')
INSERT [dbo].[BÁC SĨ] ([MS], [hotenbs], [Ngaysinh], [Gioitinh], [sdt], [diachi]) VALUES (N'BS013     ', N'Nguyên Trọng', N'2021-6-6', N'NAM       ', N'0985723421', N'123 Phan Văn Trị')
INSERT [dbo].[BÁC SĨ] ([MS], [hotenbs], [Ngaysinh], [Gioitinh], [sdt], [diachi]) VALUES (N'BS023     ', N'Vit haogn', N'18/01/2001', N'nam       ', N'0987654345', N'87 ngo quyen')
INSERT [dbo].[BÁC SĨ] ([MS], [hotenbs], [Ngaysinh], [Gioitinh], [sdt], [diachi]) VALUES (N'BS025     ', N'Viet hoang Le', N'19/01/1995', N'nam       ', N'0987678456', N'908 go vap')
INSERT [dbo].[BÁC SĨ] ([MS], [hotenbs], [Ngaysinh], [Gioitinh], [sdt], [diachi]) VALUES (N'BS026     ', N'Dinh Viet Hoang', N'18/01/1995', N'Nam       ', N'012489124', N'292 XVNT')
GO
INSERT [dbo].[BỆNH NHÂN] ([MBN], [hotenbn], [ngaysinh], [gioitinh], [sdt], [diachi], [ghichu], [ngaykham]) VALUES (N'BN001     ', N'NGUYỄN NHƯ PHƯỢNG', N'2001-9-23', N'Nữ        ', N'0384928348', N'21-NGUYỄN HỮU CẢNH-QUẬN 1', N'điều trị tủy răng', N'2020-2-23')
INSERT [dbo].[BỆNH NHÂN] ([MBN], [hotenbn], [ngaysinh], [gioitinh], [sdt], [diachi], [ghichu], [ngaykham]) VALUES (N'BN002     ', N'TÔ THANH TÂM', N'2001-2-1', N'NỮ        ', N'0238472483', N'21-NGUYỄN HỮU CẢNH-QUẬN 1', N'tẩy trắng răng', N'2021-5-20')
INSERT [dbo].[BỆNH NHÂN] ([MBN], [hotenbn], [ngaysinh], [gioitinh], [sdt], [diachi], [ghichu], [ngaykham]) VALUES (N'BN003     ', N'Trần Hoàng Hảo', N'2002-7-11', N'NAM       ', N'0921382142', N'342-Lê Quang Định', N'Tẩy trắng răng', N'2021-4-29')
INSERT [dbo].[BỆNH NHÂN] ([MBN], [hotenbn], [ngaysinh], [gioitinh], [sdt], [diachi], [ghichu], [ngaykham]) VALUES (N'BN004     ', N'PHAN TRÙNG DƯƠNG', N'2003-1-11', N'NAM       ', N'0987654684', N'76 Nguyễn Xí', N'Khám đau răng', N'2021-5-31')
INSERT [dbo].[BỆNH NHÂN] ([MBN], [hotenbn], [ngaysinh], [gioitinh], [sdt], [diachi], [ghichu], [ngaykham]) VALUES (N'BN005     ', N'TRẦN BÍCH NHƯ', N'1992-11-24', N'NỮ        ', N'0218387234', N'21-NGUYỄN HỮU CẢNH-QUẬN 1', N'cấy ghép răng', N'2020-12-28')
INSERT [dbo].[BỆNH NHÂN] ([MBN], [hotenbn], [ngaysinh], [gioitinh], [sdt], [diachi], [ghichu], [ngaykham]) VALUES (N'BN006     ', N'CHU THỊ LUYẾN', N'1985-9-9', N'NỮ        ', N'0327364783', N'21-NGUYỄN HỮU CẢNH-QUẬN 1', N'cấy ghép răng', N'2020-11-5')
INSERT [dbo].[BỆNH NHÂN] ([MBN], [hotenbn], [ngaysinh], [gioitinh], [sdt], [diachi], [ghichu], [ngaykham]) VALUES (N'BN007     ', N'Cao Lê Thuần', N'1999-3-13', N'NAM       ', N'0986218232', N'89 - XVNT', N'điều trị tủy răng', N'2021-1-13')
INSERT [dbo].[BỆNH NHÂN] ([MBN], [hotenbn], [ngaysinh], [gioitinh], [sdt], [diachi], [ghichu], [ngaykham]) VALUES (N'BN008     ', N'NGYỄN THỊ YẾN NHI', N'1993-4-2', N'NỮ        ', N'0293927375', N'21-NGUYỄN HỮU CẢNH-QUẬN 1', N'niềng răng', N'2021-4-14')
INSERT [dbo].[BỆNH NHÂN] ([MBN], [hotenbn], [ngaysinh], [gioitinh], [sdt], [diachi], [ghichu], [ngaykham]) VALUES (N'BN009     ', N'Trần Quốc Đạt', N'2001-3-22', N'NAM       ', N'0987654321', N'45- LÊ QUANG ĐỊNH', N'răng sâu', N'1900-1-1')
INSERT [dbo].[BỆNH NHÂN] ([MBN], [hotenbn], [ngaysinh], [gioitinh], [sdt], [diachi], [ghichu], [ngaykham]) VALUES (N'BN010     ', N'Trần Ngọc Nhật', N'2001-3-22', N'NAM       ', N'0687654321', N'45- LÊ QUANG ĐỊNH', N'Niềng răng', N'1900-1-1')
INSERT [dbo].[BỆNH NHÂN] ([MBN], [hotenbn], [ngaysinh], [gioitinh], [sdt], [diachi], [ghichu], [ngaykham]) VALUES (N'BN011     ', N'TRÀN THỊ DIỄM MY', N'2003-4-7', N'NỮ        ', N'0348345563', N'12-NGUYỄN VĂN CỪ-BÌNH CHÁNH', N'niềng răng', N'2021-5-20')
INSERT [dbo].[BỆNH NHÂN] ([MBN], [hotenbn], [ngaysinh], [gioitinh], [sdt], [diachi], [ghichu], [ngaykham]) VALUES (N'BN012     ', N'Nguyễn Nhi', N'2001-6-25', N'NỮ        ', N'0987654321', N'45- LÊ QUANG ĐỊNH', N'răng sâu', N'2021-6-1')
INSERT [dbo].[BỆNH NHÂN] ([MBN], [hotenbn], [ngaysinh], [gioitinh], [sdt], [diachi], [ghichu], [ngaykham]) VALUES (N'BN013     ', N'TRẦN HỮU CHÍ', N'1999-6-8', N'NAM       ', N'0786786758', N'12-NGUYỄN VĂN CỪ-BÌNH CHÁCH', N'điều trị tủy răng', N'2020-5-20')
INSERT [dbo].[BỆNH NHÂN] ([MBN], [hotenbn], [ngaysinh], [gioitinh], [sdt], [diachi], [ghichu], [ngaykham]) VALUES (N'BN014     ', N'LƯƠNG THỊ TRÀ VY', N'2001-11-6', N'NỮ        ', N'0904584534', N'12-NGUYỄN VĂN CỪ-BÌNH CHÁNH', N'chữa đau răng', N'2021-5-25')
INSERT [dbo].[BỆNH NHÂN] ([MBN], [hotenbn], [ngaysinh], [gioitinh], [sdt], [diachi], [ghichu], [ngaykham]) VALUES (N'BN015     ', N'LÊ THỊ THÚY DIỄM', N'2005-6-3', N'NỮ        ', N'0734623467', N'12-NGUYỄN VĂN CỪ-BÌNH CHÁNH', N'cấy ghép răng', N'2021-5-4')
INSERT [dbo].[BỆNH NHÂN] ([MBN], [hotenbn], [ngaysinh], [gioitinh], [sdt], [diachi], [ghichu], [ngaykham]) VALUES (N'BN016     ', N'ĐINH QUỐC BẢO', N'2001-7-8', N'NAM       ', N'0332223456', N'67-PHAN VĂN TRỊ - GÒ VẤP', N'tẩy trắng răng', N'2021-2-25')
INSERT [dbo].[BỆNH NHÂN] ([MBN], [hotenbn], [ngaysinh], [gioitinh], [sdt], [diachi], [ghichu], [ngaykham]) VALUES (N'BN017     ', N'NGUYÊN VĂN TRỌNG', N'2001-12-22', N'NAM       ', N'0985231242', N'109 Nguyễn Oanh', N'Trám răng', N'2021-5-25')
INSERT [dbo].[BỆNH NHÂN] ([MBN], [hotenbn], [ngaysinh], [gioitinh], [sdt], [diachi], [ghichu], [ngaykham]) VALUES (N'BN018     ', N'Vũ Quốc Đại', N'2002-6-23', N'NAM       ', N'0938229421', N'190 Nguyễn Gia Trí', N'Cấy ghép răng', N'2021-6-1')
INSERT [dbo].[BỆNH NHÂN] ([MBN], [hotenbn], [ngaysinh], [gioitinh], [sdt], [diachi], [ghichu], [ngaykham]) VALUES (N'BN019     ', N'TRẦN BÁ TÙNG', N'1997-4-12', N'NAM       ', N'0785456332', N'67-HAI BÀ TRUNG-QUẬN 1', N'nhổ răng khôn', N'2021-2-23')
INSERT [dbo].[BỆNH NHÂN] ([MBN], [hotenbn], [ngaysinh], [gioitinh], [sdt], [diachi], [ghichu], [ngaykham]) VALUES (N'BN020     ', N'NGUYÊN VĂN THIÊN', N'1999-4-26', N'NAM       ', N'0222389299', N'56-XÔ VIẾT NGHỆ TĨNH -BÌNH THẠNH', N'trám răng', N'2021-6-1')
INSERT [dbo].[BỆNH NHÂN] ([MBN], [hotenbn], [ngaysinh], [gioitinh], [sdt], [diachi], [ghichu], [ngaykham]) VALUES (N'BN021     ', N'Trần Minh Trí', N'1999-4-26', N'NAM       ', N'0222389299', N'56-Võ Oanh', N'trám răng', N'2021-3-28')
INSERT [dbo].[BỆNH NHÂN] ([MBN], [hotenbn], [ngaysinh], [gioitinh], [sdt], [diachi], [ghichu], [ngaykham]) VALUES (N'BN022     ', N'LÊ VĂN HOÀNG', N'2002-2-3', N'NAM       ', N'0424324323', N'21-NGUYỄN HỮU CẢNH-QUẬN 1', N'trám răng', N'2021-5-21')
INSERT [dbo].[BỆNH NHÂN] ([MBN], [hotenbn], [ngaysinh], [gioitinh], [sdt], [diachi], [ghichu], [ngaykham]) VALUES (N'BN023     ', N'LÊ VĂN LÝ', N'1984-12-5', N'NAM       ', N'0234808334', N'12-NGUYỄN VĂN CỪ-BÌNH CHÁCH', N'tẩy trắng răng', N'2021-4-14')
INSERT [dbo].[BỆNH NHÂN] ([MBN], [hotenbn], [ngaysinh], [gioitinh], [sdt], [diachi], [ghichu], [ngaykham]) VALUES (N'BN024     ', N'Phan Trung Tín', N'2001-3-24', N'NAM       ', N'0983721234', N'176 Phạm Văn Đồng', N'Nhổ răng khôn', N'2021-3-23')
INSERT [dbo].[BỆNH NHÂN] ([MBN], [hotenbn], [ngaysinh], [gioitinh], [sdt], [diachi], [ghichu], [ngaykham]) VALUES (N'BN025     ', N'Lê Văn Trọng', N'2003-5-12', N'NAM       ', N'0920487277', N'178 Phan Văn Trị', N'lấy vôi răng', N'2021-5-25')
INSERT [dbo].[BỆNH NHÂN] ([MBN], [hotenbn], [ngaysinh], [gioitinh], [sdt], [diachi], [ghichu], [ngaykham]) VALUES (N'BN026     ', N'Nguễn Thị Ngoc', N'1997-6-12', N'NỮ        ', N'0945783467', N'120 Xô Viết Nghệ Tĩnh', N'Niền răng', N'2021-5-25')
INSERT [dbo].[BỆNH NHÂN] ([MBN], [hotenbn], [ngaysinh], [gioitinh], [sdt], [diachi], [ghichu], [ngaykham]) VALUES (N'BN027     ', N'Nguyễn Thu Thủy', N'1978-8-5', N'NỮ        ', N'0934578345', N'234 Phạm Văn Đồng ', N'Trồng răng ', N'2021-5-25')
INSERT [dbo].[BỆNH NHÂN] ([MBN], [hotenbn], [ngaysinh], [gioitinh], [sdt], [diachi], [ghichu], [ngaykham]) VALUES (N'BN028     ', N'Nguyễn Văn Sĩ ', N'1979-3-12', N'NAM       ', N'0943743645', N'222 Xô Viết Nghệ Tĩnh', N'Bọc Răng Sứ', N'2021-5-25')
INSERT [dbo].[BỆNH NHÂN] ([MBN], [hotenbn], [ngaysinh], [gioitinh], [sdt], [diachi], [ghichu], [ngaykham]) VALUES (N'BN029     ', N'Nguyễn Văn Vương', N'1977-2-3', N'NAM       ', N'0924847238', N'22 Xô Viết Nghệ Tĩnh', N'Trồng Răng', N'2021-6-1')
INSERT [dbo].[BỆNH NHÂN] ([MBN], [hotenbn], [ngaysinh], [gioitinh], [sdt], [diachi], [ghichu], [ngaykham]) VALUES (N'BN030     ', N'Pham Van Chinh', N'1978-8-5', N'NAM       ', N'0934578554', N'234 Phạm Văn Đồng', N'Trồng răng', N'2021-5-25')
GO
INSERT [dbo].[Dangky] ([Madk], [hotendk], [thoigiandk], [thoigianhen], [buoihen], [sdtdk], [ghichudk]) VALUES (N'BN0004A        ', N'Nguyễn Văn Khiêm', N'2021-7-5 20:31', N'2021-7-10', N'Sáng', N'1234567890', N'tẩy trắng')
INSERT [dbo].[Dangky] ([Madk], [hotendk], [thoigiandk], [thoigianhen], [buoihen], [sdtdk], [ghichudk]) VALUES (N'BN000A         ', N'Đinh Đức Minh', N'2021-7-4 9:44', N'2021-7-6', N'Tối', N'0872312742', N'tẩy trắng răng')
INSERT [dbo].[Dangky] ([Madk], [hotendk], [thoigiandk], [thoigianhen], [buoihen], [sdtdk], [ghichudk]) VALUES (N'BN000B         ', N'Trần Minh Lợi', N'2021-7-4 14:56', N'2021-7-5', N'Sáng', N'1234567890', N'tẩy trắng')
INSERT [dbo].[Dangky] ([Madk], [hotendk], [thoigiandk], [thoigianhen], [buoihen], [sdtdk], [ghichudk]) VALUES (N'BN001A         ', N'Nguyễn Mạnh', N'2021-7-4 9:6', N'2021-7-6', N'Sáng', N'0872312742', N'tẩy trắng răng')
INSERT [dbo].[Dangky] ([Madk], [hotendk], [thoigiandk], [thoigianhen], [buoihen], [sdtdk], [ghichudk]) VALUES (N'BN003A         ', N'Nguyễn Tấn Đạt', N'2022-3-1 8:23', N'2022-3-2', N'Chiều', N'0923801832', N'khám răng')
INSERT [dbo].[Dangky] ([Madk], [hotendk], [thoigiandk], [thoigianhen], [buoihen], [sdtdk], [ghichudk]) VALUES (N'BN005B         ', N'Vũ Minh Long', N'2021-7-4 9:25', N'2021-7-5', N'Tối', N'9854571201', N'tẩy trắng')
INSERT [dbo].[Dangky] ([Madk], [hotendk], [thoigiandk], [thoigianhen], [buoihen], [sdtdk], [ghichudk]) VALUES (N'BN006B         ', N'Cao Quốc Anh', N'2021-7-4 9:43', N'2021-7-6', N'Tối', N'9854571201', N'tẩy trắng')
GO
INSERT [dbo].[staff_user] ([namestaff], [passstaff]) VALUES (N'1              ', N'c4ca4238a0b923820dcc509a6f75849b')
INSERT [dbo].[staff_user] ([namestaff], [passstaff]) VALUES (N'hoangviet      ', N'c4ca4238a0b923820dcc509a6f75849b')
INSERT [dbo].[staff_user] ([namestaff], [passstaff]) VALUES (N'staff          ', N'ae5a7c626ab26c684686572766f9885c')
INSERT [dbo].[staff_user] ([namestaff], [passstaff]) VALUES (N'staff1         ', N'ce9d92103f4d3bb95a3e2effa267a3d8')
INSERT [dbo].[staff_user] ([namestaff], [passstaff]) VALUES (N'staffroom1     ', N'3ccabb59915d2d79c7f377fd9d35f9f4')
INSERT [dbo].[staff_user] ([namestaff], [passstaff]) VALUES (N'staffroom2     ', N'ae5a7c626ab26c684686572766f9885c')
INSERT [dbo].[staff_user] ([namestaff], [passstaff]) VALUES (N'staffroom3     ', N'ce9d92103f4d3bb95a3e2effa267a3d8')
INSERT [dbo].[staff_user] ([namestaff], [passstaff]) VALUES (N'staffroom4     ', N'ae5a7c626ab26c684686572766f9885c')
INSERT [dbo].[staff_user] ([namestaff], [passstaff]) VALUES (N'vietdz123      ', N'2c034ac7eb7120d1d3e38f4d7dc13e89')
GO
INSERT [dbo].[user] ([username], [password]) VALUES (N'admin          ', N'admin01')
GO

USE [QLSV_NguyenQuangKhanh]
GO
/****** Object:  Table [dbo].[tblSinhVien]    Script Date: 12/23/2024 7:25:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSinhVien](
	[id] [int] NOT NULL,
	[TenSV] [nvarchar](50) NOT NULL,
	[NgaySInh] [datetime] NOT NULL,
	[GioiTinh] [int] NOT NULL,
	[TrinhDoHocVan] [int] NOT NULL,
	[QueQuan] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblSinhVien] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblSinhVien] ([id], [TenSV], [NgaySInh], [GioiTinh], [TrinhDoHocVan], [QueQuan], [DiaChi], [GhiChu]) VALUES (456, N'nguyen van a', CAST(N'2001-07-26T09:59:24.000' AS DateTime), 1, 2, N'hn', N'hn', N'kk')
GO

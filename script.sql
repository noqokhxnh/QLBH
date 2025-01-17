USE [QuanLyBanHang]
GO
/****** Object:  Table [dbo].[tbl_customer]    Script Date: 1/9/2025 9:32:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_customer](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
	[Address] [nchar](30) NULL,
	[UserId] [int] NOT NULL,
 CONSTRAINT [PK_tbl_customer] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_giohang]    Script Date: 1/9/2025 9:32:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_giohang](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](50) NOT NULL,
	[Price] [float] NOT NULL,
	[Stock] [int] NOT NULL,
	[UserId] [int] NULL,
 CONSTRAINT [PK_tbl_giohang] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_magiamgia]    Script Date: 1/9/2025 9:32:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_magiamgia](
	[KeyId] [int] IDENTITY(1,1) NOT NULL,
	[MaGiamGia] [nvarchar](50) NOT NULL,
	[GiamGia] [float] NULL,
 CONSTRAINT [PK_tbl_magiamgia] PRIMARY KEY CLUSTERED 
(
	[MaGiamGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Order]    Script Date: 1/9/2025 9:32:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Order](
	[OrderId] [int] NOT NULL,
	[CustomerName] [int] NULL,
	[TotalAmount] [decimal](10, 2) NULL,
 CONSTRAINT [PK_tbl_Order] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_order_history]    Script Date: 1/9/2025 9:32:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_order_history](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](50) NULL,
	[Stock] [int] NULL,
	[Price] [decimal](18, 0) NULL,
	[MaGiamGia] [nvarchar](50) NULL,
	[GiamGia] [float] NULL,
 CONSTRAINT [PK_tbl_order_history] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_orderdetail]    Script Date: 1/9/2025 9:32:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_orderdetail](
	[OrderDetailId] [int] NOT NULL,
	[OrderId] [int] NULL,
	[ProductId] [int] NULL,
	[Quantity] [int] NULL,
	[TotalPrice] [decimal](10, 2) NULL,
 CONSTRAINT [PK_tbl_orderdetail] PRIMARY KEY CLUSTERED 
(
	[OrderDetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_product]    Script Date: 1/9/2025 9:32:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_product](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nchar](30) NOT NULL,
	[Price] [float] NOT NULL,
	[Stock] [int] NOT NULL,
	[UserId] [int] NULL,
 CONSTRAINT [PK_tbl_product] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_review]    Script Date: 1/9/2025 9:32:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_review](
	[reviewID] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [nchar](10) NULL,
	[UserID] [nchar](10) NULL,
	[Rating] [int] NULL,
	[Comment] [nvarchar](200) NULL,
 CONSTRAINT [PK_tbl_review] PRIMARY KEY CLUSTERED 
(
	[reviewID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_role_request]    Script Date: 1/9/2025 9:32:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_role_request](
	[UserId] [int] NOT NULL,
	[RequestId] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_tbl_role_request] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_user]    Script Date: 1/9/2025 9:32:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_user](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[username] [nchar](50) NULL,
	[password] [nchar](50) NULL,
	[role] [nchar](10) NULL,
 CONSTRAINT [PK_tbl_user_1] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbl_customer]  WITH CHECK ADD  CONSTRAINT [FK_tbl_customer_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[tbl_user] ([UserId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_customer] CHECK CONSTRAINT [FK_tbl_customer_UserId]
GO
ALTER TABLE [dbo].[tbl_order_history]  WITH CHECK ADD  CONSTRAINT [FK_OrderHistory_MaGiamGia] FOREIGN KEY([MaGiamGia])
REFERENCES [dbo].[tbl_magiamgia] ([MaGiamGia])
GO
ALTER TABLE [dbo].[tbl_order_history] CHECK CONSTRAINT [FK_OrderHistory_MaGiamGia]
GO
ALTER TABLE [dbo].[tbl_role_request]  WITH CHECK ADD  CONSTRAINT [FK_New_tbl_role_request_tbl_user] FOREIGN KEY([UserId])
REFERENCES [dbo].[tbl_user] ([UserId])
GO
ALTER TABLE [dbo].[tbl_role_request] CHECK CONSTRAINT [FK_New_tbl_role_request_tbl_user]
GO
ALTER TABLE [dbo].[tbl_role_request]
DROP CONSTRAINT [PK_tbl_role_request];

ALTER TABLE [dbo].[tbl_role_request]
ADD CONSTRAINT [PK_tbl_role_request] PRIMARY KEY CLUSTERED ([UserId], [RequestId]);


INSERT INTO tbl_user (username, password, role)
VALUES 
('admin', '123', 'Admin'),
('seller', '123', 'Seller'),
('sang', '123', 'user'),
('khanh', '123', 'user'),
('uy', '123', 'user'),
('tuan', '123', 'user'),
('diep', '123', 'user');


CREATE TABLE [dbo].[CategoryTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_CategoryTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CompanyTable]    Script Date: 11/13/2018 10:06:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CompanyTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_CompanyTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ItemSetupTable]    Script Date: 11/13/2018 10:06:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ItemSetupTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Category] [varchar](50) NOT NULL,
	[Company] [varchar](50) NOT NULL,
	[ItemName] [varchar](50) NOT NULL,
	[ReOrder] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ItemSetupTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SearchViewTable]    Script Date: 11/13/2018 10:06:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SearchViewTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Item] [varchar](50) NOT NULL,
	[Company] [varchar](50) NOT NULL,
	[Quantity] [varchar](50) NOT NULL,
	[AvailableQuantity] [int] NOT NULL,
	[ReOrder] [int] NOT NULL,
 CONSTRAINT [PK_SearchViewTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[StockInTable]    Script Date: 11/13/2018 10:06:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[StockInTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Company] [varchar](50) NOT NULL,
	[ItemName] [varchar](50) NOT NULL,
	[ReOrder] [int] NOT NULL,
	[AvailableQuantity] [int] NOT NULL,
	[StockIn] [int] NOT NULL,
 CONSTRAINT [PK_StockInTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[StockOutTable]    Script Date: 11/13/2018 10:06:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[StockOutTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Item] [varchar](50) NOT NULL,
	[Company] [varchar](50) NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_StockOutTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ViewSalesTable]    Script Date: 11/13/2018 10:06:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ViewSalesTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Item] [varchar](50) NOT NULL,
	[SaleQuantity] [int] NOT NULL,
 CONSTRAINT [PK_ViewSalesTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[CategoryTable] ON 

INSERT [dbo].[CategoryTable] ([Id], [CategoryName]) VALUES (1, N'Stationary')
INSERT [dbo].[CategoryTable] ([Id], [CategoryName]) VALUES (2, N'Cosmetics')
INSERT [dbo].[CategoryTable] ([Id], [CategoryName]) VALUES (3, N'Electronics')
INSERT [dbo].[CategoryTable] ([Id], [CategoryName]) VALUES (4, N'Kitchen Items')
SET IDENTITY_INSERT [dbo].[CategoryTable] OFF
SET IDENTITY_INSERT [dbo].[CompanyTable] ON 

INSERT [dbo].[CompanyTable] ([Id], [CompanyName]) VALUES (1, N'Uniliver')
INSERT [dbo].[CompanyTable] ([Id], [CompanyName]) VALUES (2, N'RFL')
SET IDENTITY_INSERT [dbo].[CompanyTable] OFF
USE [master]
GO
ALTER DATABASE [StockManagementDB] SET  READ_WRITE 
GO

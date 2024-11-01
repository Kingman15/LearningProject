USE [master]
GO
/****** Object:  Database [LearningDB]    Script Date: 10/31/2024 12:46:49 ******/
CREATE DATABASE [LearningDB] ON  PRIMARY 
( NAME = N'CanteenDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\CanteenDB.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CanteenDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\CanteenDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [LearningDB] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LearningDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LearningDB] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [LearningDB] SET ANSI_NULLS OFF
GO
ALTER DATABASE [LearningDB] SET ANSI_PADDING OFF
GO
ALTER DATABASE [LearningDB] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [LearningDB] SET ARITHABORT OFF
GO
ALTER DATABASE [LearningDB] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [LearningDB] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [LearningDB] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [LearningDB] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [LearningDB] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [LearningDB] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [LearningDB] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [LearningDB] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [LearningDB] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [LearningDB] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [LearningDB] SET  DISABLE_BROKER
GO
ALTER DATABASE [LearningDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [LearningDB] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [LearningDB] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [LearningDB] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [LearningDB] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [LearningDB] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [LearningDB] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [LearningDB] SET  READ_WRITE
GO
ALTER DATABASE [LearningDB] SET RECOVERY FULL
GO
ALTER DATABASE [LearningDB] SET  MULTI_USER
GO
ALTER DATABASE [LearningDB] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [LearningDB] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'LearningDB', N'ON'
GO
USE [LearningDB]
GO
/****** Object:  User [michael]    Script Date: 10/31/2024 12:46:49 ******/
CREATE USER [michael] FOR LOGIN [michael] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[User]    Script Date: 10/31/2024 12:46:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UnitOfMeasure]    Script Date: 10/31/2024 12:46:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UnitOfMeasure](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[shortName] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK__UnitOfMe__3213E83F7F60ED59] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[UnitOfMeasure] ON
INSERT [dbo].[UnitOfMeasure] ([id], [name], [shortName]) VALUES (1, N'Kilogramme', N'kg')
INSERT [dbo].[UnitOfMeasure] ([id], [name], [shortName]) VALUES (2, N'Mètre', N'm')
INSERT [dbo].[UnitOfMeasure] ([id], [name], [shortName]) VALUES (3, N'Litre', N'L')
INSERT [dbo].[UnitOfMeasure] ([id], [name], [shortName]) VALUES (4, N'Centimètre', N'cm')
INSERT [dbo].[UnitOfMeasure] ([id], [name], [shortName]) VALUES (5, N'Gramme', N'g')
SET IDENTITY_INSERT [dbo].[UnitOfMeasure] OFF
/****** Object:  Table [dbo].[StockEntry]    Script Date: 10/31/2024 12:46:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockEntry](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[entryDate] [date] NOT NULL,
	[totalAmount] [decimal](18, 5) NOT NULL,
	[notes] [nvarchar](255) NULL,
	[userSignId] [bigint] NULL,
	[observation] [nvarchar](255) NULL,
	[createdAt] [datetime] NULL,
	[updatedAt] [datetime] NULL,
 CONSTRAINT [PK__StockEnt__3213E83F09DE7BCC] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FoodItem]    Script Date: 10/31/2024 12:46:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FoodItem](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[unitOfMeasureId] [bigint] NULL,
	[description] [nvarchar](255) NULL,
	[stockQuantity] [decimal](18, 2) NOT NULL,
	[alertThreshold] [decimal](18, 2) NOT NULL,
	[category] [nvarchar](50) NULL,
	[createdAt] [datetime] NULL,
	[updatedAt] [datetime] NULL,
 CONSTRAINT [PK__FoodItem__3213E83F03317E3D] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[FoodItem] ON
INSERT [dbo].[FoodItem] ([id], [name], [unitOfMeasureId], [description], [stockQuantity], [alertThreshold], [category], [createdAt], [updatedAt]) VALUES (16, N'Pommes', 1, N'Pommes fraîches et croquantes.', CAST(100.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), N'Fruits', CAST(0x0000B21A00CFE0EE AS DateTime), CAST(0x0000B21A00CFE0EE AS DateTime))
INSERT [dbo].[FoodItem] ([id], [name], [unitOfMeasureId], [description], [stockQuantity], [alertThreshold], [category], [createdAt], [updatedAt]) VALUES (17, N'Bananes', 1, N'Bananes mûres.', CAST(150.00 AS Decimal(18, 2)), CAST(20.00 AS Decimal(18, 2)), N'Fruits', CAST(0x0000B21A00CFE0EE AS DateTime), CAST(0x0000B21A00CFE0EE AS DateTime))
INSERT [dbo].[FoodItem] ([id], [name], [unitOfMeasureId], [description], [stockQuantity], [alertThreshold], [category], [createdAt], [updatedAt]) VALUES (18, N'Riz', 2, N'Riz blanc, idéal pour les repas.', CAST(200.00 AS Decimal(18, 2)), CAST(25.00 AS Decimal(18, 2)), N'Céréales', CAST(0x0000B21A00CFE0EE AS DateTime), CAST(0x0000B21A00CFE0EE AS DateTime))
INSERT [dbo].[FoodItem] ([id], [name], [unitOfMeasureId], [description], [stockQuantity], [alertThreshold], [category], [createdAt], [updatedAt]) VALUES (19, N'Pâtes', 2, N'Pâtes italiennes, disponibles en différentes formes.', CAST(75.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), N'Céréales', CAST(0x0000B21A00CFE0EE AS DateTime), CAST(0x0000B21A00CFE0EE AS DateTime))
INSERT [dbo].[FoodItem] ([id], [name], [unitOfMeasureId], [description], [stockQuantity], [alertThreshold], [category], [createdAt], [updatedAt]) VALUES (20, N'Lait', 3, N'Lait entier, riche en calcium.', CAST(50.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), N'Produits laitiers', CAST(0x0000B21A00CFE0EE AS DateTime), CAST(0x0000B21A00CFE0EE AS DateTime))
INSERT [dbo].[FoodItem] ([id], [name], [unitOfMeasureId], [description], [stockQuantity], [alertThreshold], [category], [createdAt], [updatedAt]) VALUES (21, N'Yaourt', 3, N'Yaourt nature, sans additifs.', CAST(30.00 AS Decimal(18, 2)), CAST(3.00 AS Decimal(18, 2)), N'Produits laitiers', CAST(0x0000B21A00CFE0EE AS DateTime), CAST(0x0000B21A00CFE0EE AS DateTime))
INSERT [dbo].[FoodItem] ([id], [name], [unitOfMeasureId], [description], [stockQuantity], [alertThreshold], [category], [createdAt], [updatedAt]) VALUES (22, N'Viande hachée', 4, N'Viande hachée de boeuf.', CAST(60.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), N'Viandes', CAST(0x0000B21A00CFE0EE AS DateTime), CAST(0x0000B21A00CFE0EE AS DateTime))
INSERT [dbo].[FoodItem] ([id], [name], [unitOfMeasureId], [description], [stockQuantity], [alertThreshold], [category], [createdAt], [updatedAt]) VALUES (23, N'Poulet', 4, N'Filets de poulet, frais.', CAST(80.00 AS Decimal(18, 2)), CAST(15.00 AS Decimal(18, 2)), N'Viandes', CAST(0x0000B21A00CFE0EE AS DateTime), CAST(0x0000B21A00CFE0EE AS DateTime))
INSERT [dbo].[FoodItem] ([id], [name], [unitOfMeasureId], [description], [stockQuantity], [alertThreshold], [category], [createdAt], [updatedAt]) VALUES (24, N'Carottes', 1, N'Carottes fraîches, idéales pour les salades.', CAST(120.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), N'Légumes', CAST(0x0000B21A00CFE0EE AS DateTime), CAST(0x0000B21A00CFE0EE AS DateTime))
INSERT [dbo].[FoodItem] ([id], [name], [unitOfMeasureId], [description], [stockQuantity], [alertThreshold], [category], [createdAt], [updatedAt]) VALUES (25, N'Oignons', 1, N'Oignons jaunes, pour aromatiser les plats.', CAST(100.00 AS Decimal(18, 2)), CAST(15.00 AS Decimal(18, 2)), N'Légumes', CAST(0x0000B21A00CFE0EE AS DateTime), CAST(0x0000B21A00CFE0EE AS DateTime))
INSERT [dbo].[FoodItem] ([id], [name], [unitOfMeasureId], [description], [stockQuantity], [alertThreshold], [category], [createdAt], [updatedAt]) VALUES (26, N'Pain', 2, N'Pain de mie, idéal pour les sandwiches.', CAST(40.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), N'Boulangerie', CAST(0x0000B21A00CFE0EE AS DateTime), CAST(0x0000B21A00CFE0EE AS DateTime))
INSERT [dbo].[FoodItem] ([id], [name], [unitOfMeasureId], [description], [stockQuantity], [alertThreshold], [category], [createdAt], [updatedAt]) VALUES (27, N'Fromage', 3, N'Fromage cheddar, parfait pour les plats cuisinés.', CAST(20.00 AS Decimal(18, 2)), CAST(3.00 AS Decimal(18, 2)), N'Produits laitiers', CAST(0x0000B21A00CFE0EE AS DateTime), CAST(0x0000B21A00CFE0EE AS DateTime))
INSERT [dbo].[FoodItem] ([id], [name], [unitOfMeasureId], [description], [stockQuantity], [alertThreshold], [category], [createdAt], [updatedAt]) VALUES (28, N'Céréales', 2, N'Céréales pour le petit déjeuner, riches en fibres.', CAST(45.00 AS Decimal(18, 2)), CAST(7.00 AS Decimal(18, 2)), N'Céréales', CAST(0x0000B21A00CFE0EE AS DateTime), CAST(0x0000B21A00CFE0EE AS DateTime))
INSERT [dbo].[FoodItem] ([id], [name], [unitOfMeasureId], [description], [stockQuantity], [alertThreshold], [category], [createdAt], [updatedAt]) VALUES (29, N'Huile d''olive', 5, N'Huile d''olive extra vierge, pour la cuisine.', CAST(30.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), N'Condiments', CAST(0x0000B21A00CFE0EE AS DateTime), CAST(0x0000B21A00CFE0EE AS DateTime))
INSERT [dbo].[FoodItem] ([id], [name], [unitOfMeasureId], [description], [stockQuantity], [alertThreshold], [category], [createdAt], [updatedAt]) VALUES (30, N'Sel', 5, N'Sel de table, indispensable en cuisine.', CAST(25.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), N'Condiments', CAST(0x0000B21A00CFE0EE AS DateTime), CAST(0x0000B21A00CFE0EE AS DateTime))
SET IDENTITY_INSERT [dbo].[FoodItem] OFF
/****** Object:  Table [dbo].[StockExit]    Script Date: 10/31/2024 12:46:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockExit](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[exitDate] [date] NOT NULL,
	[totalAmount] [decimal](18, 5) NOT NULL,
	[destination] [nvarchar](100) NULL,
	[userSignId] [bigint] NULL,
	[notes] [nvarchar](255) NULL,
	[createdAt] [datetime] NULL,
	[updatedAt] [datetime] NULL,
 CONSTRAINT [PK__StockExi__3213E83F1367E606] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StockEntryDetail]    Script Date: 10/31/2024 12:46:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[StockEntryDetail](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[stockEntryId] [bigint] NOT NULL,
	[foodItemId] [bigint] NOT NULL,
	[quantity] [decimal](18, 2) NOT NULL,
	[unitPrice] [decimal](18, 5) NOT NULL,
	[totalPrice]  AS ([quantity]*[unitPrice]) PERSISTED,
	[expirationDate] [date] NULL,
	[createdAt] [datetime] NULL,
	[updatedAt] [datetime] NULL,
	[currentQuantity] [decimal](18, 2) NULL,
 CONSTRAINT [PK__StockEnt__3213E83F0DAF0CB0] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[StockExitDetail]    Script Date: 10/31/2024 12:46:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockExitDetail](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[stockExitId] [bigint] NOT NULL,
	[foodItemId] [bigint] NOT NULL,
	[quantity] [decimal](18, 2) NOT NULL,
	[observation] [nvarchar](255) NULL,
	[createdAt] [datetime] NULL,
	[updatedAt] [datetime] NULL,
	[stockEntryDetailId] [bigint] NULL,
 CONSTRAINT [PK__StockExi__3213E83F173876EA] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Default [DF__FoodItem__stockQ__060DEAE8]    Script Date: 10/31/2024 12:46:50 ******/
ALTER TABLE [dbo].[FoodItem] ADD  CONSTRAINT [DF__FoodItem__stockQ__060DEAE8]  DEFAULT ((0)) FOR [stockQuantity]
GO
/****** Object:  Default [DF__FoodItem__alertT__07020F21]    Script Date: 10/31/2024 12:46:50 ******/
ALTER TABLE [dbo].[FoodItem] ADD  CONSTRAINT [DF__FoodItem__alertT__07020F21]  DEFAULT ((0)) FOR [alertThreshold]
GO
/****** Object:  ForeignKey [FK_StockEntry_User]    Script Date: 10/31/2024 12:46:50 ******/
ALTER TABLE [dbo].[StockEntry]  WITH CHECK ADD  CONSTRAINT [FK_StockEntry_User] FOREIGN KEY([userSignId])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[StockEntry] CHECK CONSTRAINT [FK_StockEntry_User]
GO
/****** Object:  ForeignKey [FK__FoodItem__unitOf__0519C6AF]    Script Date: 10/31/2024 12:46:50 ******/
ALTER TABLE [dbo].[FoodItem]  WITH CHECK ADD  CONSTRAINT [FK__FoodItem__unitOf__0519C6AF] FOREIGN KEY([unitOfMeasureId])
REFERENCES [dbo].[UnitOfMeasure] ([id])
GO
ALTER TABLE [dbo].[FoodItem] CHECK CONSTRAINT [FK__FoodItem__unitOf__0519C6AF]
GO
/****** Object:  ForeignKey [FK_StockExit_User]    Script Date: 10/31/2024 12:46:50 ******/
ALTER TABLE [dbo].[StockExit]  WITH CHECK ADD  CONSTRAINT [FK_StockExit_User] FOREIGN KEY([userSignId])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[StockExit] CHECK CONSTRAINT [FK_StockExit_User]
GO
/****** Object:  ForeignKey [FK__StockEntr__foodI__108B795B]    Script Date: 10/31/2024 12:46:50 ******/
ALTER TABLE [dbo].[StockEntryDetail]  WITH CHECK ADD  CONSTRAINT [FK__StockEntr__foodI__108B795B] FOREIGN KEY([foodItemId])
REFERENCES [dbo].[FoodItem] ([id])
GO
ALTER TABLE [dbo].[StockEntryDetail] CHECK CONSTRAINT [FK__StockEntr__foodI__108B795B]
GO
/****** Object:  ForeignKey [FK__StockEntr__stock__0F975522]    Script Date: 10/31/2024 12:46:50 ******/
ALTER TABLE [dbo].[StockEntryDetail]  WITH CHECK ADD  CONSTRAINT [FK__StockEntr__stock__0F975522] FOREIGN KEY([stockEntryId])
REFERENCES [dbo].[StockEntry] ([id])
GO
ALTER TABLE [dbo].[StockEntryDetail] CHECK CONSTRAINT [FK__StockEntr__stock__0F975522]
GO
/****** Object:  ForeignKey [FK__StockExit__foodI__1A14E395]    Script Date: 10/31/2024 12:46:50 ******/
ALTER TABLE [dbo].[StockExitDetail]  WITH CHECK ADD  CONSTRAINT [FK__StockExit__foodI__1A14E395] FOREIGN KEY([foodItemId])
REFERENCES [dbo].[FoodItem] ([id])
GO
ALTER TABLE [dbo].[StockExitDetail] CHECK CONSTRAINT [FK__StockExit__foodI__1A14E395]
GO
/****** Object:  ForeignKey [FK__StockExit__stock__1920BF5C]    Script Date: 10/31/2024 12:46:50 ******/
ALTER TABLE [dbo].[StockExitDetail]  WITH CHECK ADD  CONSTRAINT [FK__StockExit__stock__1920BF5C] FOREIGN KEY([stockExitId])
REFERENCES [dbo].[StockExit] ([id])
GO
ALTER TABLE [dbo].[StockExitDetail] CHECK CONSTRAINT [FK__StockExit__stock__1920BF5C]
GO
/****** Object:  ForeignKey [FK_StockExitDetail_StockEntryDetail]    Script Date: 10/31/2024 12:46:50 ******/
ALTER TABLE [dbo].[StockExitDetail]  WITH CHECK ADD  CONSTRAINT [FK_StockExitDetail_StockEntryDetail] FOREIGN KEY([stockEntryDetailId])
REFERENCES [dbo].[StockEntryDetail] ([id])
GO
ALTER TABLE [dbo].[StockExitDetail] CHECK CONSTRAINT [FK_StockExitDetail_StockEntryDetail]
GO

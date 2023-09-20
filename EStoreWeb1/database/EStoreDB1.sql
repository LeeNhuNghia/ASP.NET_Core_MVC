USE [master]
GO
/****** Object:  Database [EStoreDB1]    Script Date: 9/20/2023 7:38:40 PM ******/
CREATE DATABASE [EStoreDB1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EStoreDB1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\EStoreDB1.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EStoreDB1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\EStoreDB1_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [EStoreDB1] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EStoreDB1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EStoreDB1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EStoreDB1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EStoreDB1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EStoreDB1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EStoreDB1] SET ARITHABORT OFF 
GO
ALTER DATABASE [EStoreDB1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EStoreDB1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EStoreDB1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EStoreDB1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EStoreDB1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EStoreDB1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EStoreDB1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EStoreDB1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EStoreDB1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EStoreDB1] SET  ENABLE_BROKER 
GO
ALTER DATABASE [EStoreDB1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EStoreDB1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EStoreDB1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EStoreDB1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EStoreDB1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EStoreDB1] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [EStoreDB1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EStoreDB1] SET RECOVERY FULL 
GO
ALTER DATABASE [EStoreDB1] SET  MULTI_USER 
GO
ALTER DATABASE [EStoreDB1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EStoreDB1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EStoreDB1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EStoreDB1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [EStoreDB1] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [EStoreDB1] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'EStoreDB1', N'ON'
GO
ALTER DATABASE [EStoreDB1] SET QUERY_STORE = OFF
GO
USE [EStoreDB1]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 9/20/2023 7:38:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 9/20/2023 7:38:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[DisplayOrder] [int] NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 9/20/2023 7:38:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Price] [float] NOT NULL,
	[CategoryId] [int] NOT NULL,
	[ImageUrl] [nvarchar](max) NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230914071042_AddTableCategory', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230914071314_SeedDataToCategoryTable', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230914080244_SeedDataToProductTable', N'5.0.17')
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([Id], [Name], [DisplayOrder]) VALUES (1, N'Điện thoại', 1)
INSERT [dbo].[Categories] ([Id], [Name], [DisplayOrder]) VALUES (2, N'Máy tính bảng', 2)
INSERT [dbo].[Categories] ([Id], [Name], [DisplayOrder]) VALUES (3, N'Laptop', 3)
INSERT [dbo].[Categories] ([Id], [Name], [DisplayOrder]) VALUES (4, N'Tai nghe', 4)
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([Id], [Name], [Description], [Price], [CategoryId], [ImageUrl]) VALUES (1, N'Iphone 7', NULL, 300, 1, N'Products/Imgs/a31c7f15-40f4-4a64-9ec4-0f00259bb08d.jpg')
INSERT [dbo].[Products] ([Id], [Name], [Description], [Price], [CategoryId], [ImageUrl]) VALUES (2, N'Iphone 7s', NULL, 350, 1, N'Products/Imgs/748809a8-fe03-48d5-9d79-1eb5a31d181d.jpeg')
INSERT [dbo].[Products] ([Id], [Name], [Description], [Price], [CategoryId], [ImageUrl]) VALUES (3, N'Iphone 8', NULL, 400, 1, N'Products/Imgs/547b68a9-16f0-43d4-9b66-60be1ae4fc31.jpg')
INSERT [dbo].[Products] ([Id], [Name], [Description], [Price], [CategoryId], [ImageUrl]) VALUES (4, N'Iphone 8s', NULL, 420, 1, N'Products/Imgs/63fd0d82-d4f4-4844-b160-40d64f7bf02a.webp')
INSERT [dbo].[Products] ([Id], [Name], [Description], [Price], [CategoryId], [ImageUrl]) VALUES (5, N'Iphone 11', NULL, 600, 1, N'Products/Imgs/3895884a-9521-44f6-a539-c76eb7eae08e.jpeg')
INSERT [dbo].[Products] ([Id], [Name], [Description], [Price], [CategoryId], [ImageUrl]) VALUES (6, N'Iphone 11s', NULL, 650, 1, N'Products/Imgs/34049c58-27ce-4e45-a136-8944adc7ca7a.webp')
INSERT [dbo].[Products] ([Id], [Name], [Description], [Price], [CategoryId], [ImageUrl]) VALUES (7, N'Iphone 13', NULL, 700, 1, N'Products/Imgs/953968c1-3564-4bf8-8935-ae61550279b0.jpg')
INSERT [dbo].[Products] ([Id], [Name], [Description], [Price], [CategoryId], [ImageUrl]) VALUES (8, N'Iphone 13 Pro', NULL, 850, 1, N'Products/Imgs/602a0ee1-3e4b-4f19-aba8-ea330189cacf.jpeg')
INSERT [dbo].[Products] ([Id], [Name], [Description], [Price], [CategoryId], [ImageUrl]) VALUES (9, N'Iphone 14', NULL, 900, 1, N'Products/Imgs/b334a3e8-8001-4404-9fc2-ec37cf60725c.jpeg')
INSERT [dbo].[Products] ([Id], [Name], [Description], [Price], [CategoryId], [ImageUrl]) VALUES (10, N'Iphone 14 Pro Max', NULL, 1000, 1, N'Products/Imgs/aae94bc9-c4d1-41c0-ba59-3ee913fae0e7.jpeg')
INSERT [dbo].[Products] ([Id], [Name], [Description], [Price], [CategoryId], [ImageUrl]) VALUES (11, N'Ipad Mini', NULL, 350, 2, N'Products/Imgs/ed6a0704-eb11-4544-aefb-107afc119a88.webp')
INSERT [dbo].[Products] ([Id], [Name], [Description], [Price], [CategoryId], [ImageUrl]) VALUES (12, N'Ipad Pro', NULL, 550, 2, N'Products/Imgs/95369c9a-321f-49ba-a4cc-c7c7992c945b.jpg')
INSERT [dbo].[Products] ([Id], [Name], [Description], [Price], [CategoryId], [ImageUrl]) VALUES (13, N'TA', NULL, 34433, 4, N'Products/Imgs/36041d46-1fef-4736-b59e-a94814527b2d.jpg')
INSERT [dbo].[Products] ([Id], [Name], [Description], [Price], [CategoryId], [ImageUrl]) VALUES (14, N'Tai nghe', NULL, 2323232, 4, N'Products/Imgs/be1a7706-c124-4932-a59b-f77f6ff111e9.jpg')
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
/****** Object:  Index [IX_Products_CategoryId]    Script Date: 9/20/2023 7:38:41 PM ******/
CREATE NONCLUSTERED INDEX [IX_Products_CategoryId] ON [dbo].[Products]
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories_CategoryId]
GO
USE [master]
GO
ALTER DATABASE [EStoreDB1] SET  READ_WRITE 
GO

USE [master]
GO
/****** Object:  Database [BookingRestaurant]    Script Date: 26/06/2023 4:39:14 CH ******/
CREATE DATABASE [BookingRestaurant]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BookingRestaurant', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BookingRestaurant.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BookingRestaurant_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BookingRestaurant_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BookingRestaurant] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BookingRestaurant].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BookingRestaurant] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BookingRestaurant] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BookingRestaurant] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BookingRestaurant] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BookingRestaurant] SET ARITHABORT OFF 
GO
ALTER DATABASE [BookingRestaurant] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BookingRestaurant] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BookingRestaurant] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BookingRestaurant] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BookingRestaurant] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BookingRestaurant] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BookingRestaurant] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BookingRestaurant] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BookingRestaurant] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BookingRestaurant] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BookingRestaurant] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BookingRestaurant] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BookingRestaurant] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BookingRestaurant] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BookingRestaurant] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BookingRestaurant] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BookingRestaurant] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BookingRestaurant] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BookingRestaurant] SET  MULTI_USER 
GO
ALTER DATABASE [BookingRestaurant] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BookingRestaurant] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BookingRestaurant] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BookingRestaurant] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BookingRestaurant] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BookingRestaurant] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [BookingRestaurant] SET QUERY_STORE = OFF
GO
USE [BookingRestaurant]
GO
/****** Object:  Table [dbo].[Booking_Table]    Script Date: 26/06/2023 4:39:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Booking_Table](
	[reservation_id] [int] NOT NULL,
	[table_id] [int] NOT NULL,
 CONSTRAINT [PK_Booking_Table] PRIMARY KEY CLUSTERED 
(
	[reservation_id] ASC,
	[table_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reservation]    Script Date: 26/06/2023 4:39:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservation](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[date] [date] NULL,
	[description] [nvarchar](255) NULL,
	[startTime] [datetime] NULL,
	[endTime] [datetime] NULL,
	[numGuest] [int] NULL,
	[phoneGuest] [nvarchar](50) NULL,
	[price] [float] NULL,
	[discount] [int] NULL,
	[status] [bit] NULL,
	[feedback] [nvarchar](255) NULL,
	[user_id] [int] NULL,
 CONSTRAINT [PK_Reservation] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Schedule_Table]    Script Date: 26/06/2023 4:39:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Schedule_Table](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[date] [date] NULL,
	[startTime] [datetime] NULL,
	[endTime] [datetime] NULL,
	[table_id] [int] NULL,
 CONSTRAINT [PK_Schedule_Table] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Table]    Script Date: 26/06/2023 4:39:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[capacity] [int] NOT NULL,
	[name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Restaurant] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 26/06/2023 4:39:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[phone] [nvarchar](50) NOT NULL,
	[role] [nvarchar](50) NULL,
	[status] [bit] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Booking_Table] ([reservation_id], [table_id]) VALUES (1, 1)
GO
SET IDENTITY_INSERT [dbo].[Reservation] ON 

INSERT [dbo].[Reservation] ([id], [date], [description], [startTime], [endTime], [numGuest], [phoneGuest], [price], [discount], [status], [feedback], [user_id]) VALUES (1, CAST(N'2023-06-26' AS Date), N'Near Window', CAST(N'2023-06-26T13:00:00.000' AS DateTime), CAST(N'2023-06-26T14:00:00.000' AS DateTime), 4, N'0961837111', 500, 0, 1, NULL, 1)
INSERT [dbo].[Reservation] ([id], [date], [description], [startTime], [endTime], [numGuest], [phoneGuest], [price], [discount], [status], [feedback], [user_id]) VALUES (2, CAST(N'2023-06-26' AS Date), N'Date', CAST(N'2023-06-26T19:00:00.000' AS DateTime), CAST(N'2023-06-26T21:00:00.000' AS DateTime), 2, N'0961837111', 500, 0, 1, NULL, 1)
SET IDENTITY_INSERT [dbo].[Reservation] OFF
GO
SET IDENTITY_INSERT [dbo].[Schedule_Table] ON 

INSERT [dbo].[Schedule_Table] ([id], [date], [startTime], [endTime], [table_id]) VALUES (1, CAST(N'2023-06-26' AS Date), CAST(N'2023-06-26T10:00:00.000' AS DateTime), CAST(N'2023-06-26T12:00:00.000' AS DateTime), 1)
INSERT [dbo].[Schedule_Table] ([id], [date], [startTime], [endTime], [table_id]) VALUES (2, CAST(N'2023-06-26' AS Date), CAST(N'2023-06-26T10:00:00.000' AS DateTime), CAST(N'2023-06-26T12:00:00.000' AS DateTime), 2)
INSERT [dbo].[Schedule_Table] ([id], [date], [startTime], [endTime], [table_id]) VALUES (3, CAST(N'2023-06-26' AS Date), CAST(N'2023-06-26T10:00:00.000' AS DateTime), CAST(N'2023-06-26T12:00:00.000' AS DateTime), 3)
INSERT [dbo].[Schedule_Table] ([id], [date], [startTime], [endTime], [table_id]) VALUES (4, CAST(N'2023-06-26' AS Date), CAST(N'2023-06-26T10:00:00.000' AS DateTime), CAST(N'2023-06-26T12:00:00.000' AS DateTime), 4)
INSERT [dbo].[Schedule_Table] ([id], [date], [startTime], [endTime], [table_id]) VALUES (5, CAST(N'2023-06-26' AS Date), CAST(N'2023-06-26T18:00:00.000' AS DateTime), CAST(N'2023-06-26T20:00:00.000' AS DateTime), 5)
INSERT [dbo].[Schedule_Table] ([id], [date], [startTime], [endTime], [table_id]) VALUES (6, CAST(N'2023-06-26' AS Date), CAST(N'2023-06-26T17:00:00.000' AS DateTime), CAST(N'2023-06-26T19:00:00.000' AS DateTime), 6)
SET IDENTITY_INSERT [dbo].[Schedule_Table] OFF
GO
SET IDENTITY_INSERT [dbo].[Table] ON 

INSERT [dbo].[Table] ([id], [capacity], [name]) VALUES (1, 5, N'B01')
INSERT [dbo].[Table] ([id], [capacity], [name]) VALUES (2, 5, N'B02')
INSERT [dbo].[Table] ([id], [capacity], [name]) VALUES (3, 10, N'B03')
INSERT [dbo].[Table] ([id], [capacity], [name]) VALUES (4, 10, N'B04')
INSERT [dbo].[Table] ([id], [capacity], [name]) VALUES (5, 2, N'B05')
INSERT [dbo].[Table] ([id], [capacity], [name]) VALUES (6, 2, N'B06')
SET IDENTITY_INSERT [dbo].[Table] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([id], [name], [password], [phone], [role], [status]) VALUES (1, N'Minh Thuan', N'123', N'0961837666', N'1', 1)
INSERT [dbo].[User] ([id], [name], [password], [phone], [role], [status]) VALUES (2, N'Phuong Kha', N'123', N'0961837777', N'1', 1)
INSERT [dbo].[User] ([id], [name], [password], [phone], [role], [status]) VALUES (3, N'Hoang Hai', N'123', N'0971837888', N'1', 1)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[Booking_Table]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Table_Reservation] FOREIGN KEY([reservation_id])
REFERENCES [dbo].[Reservation] ([id])
GO
ALTER TABLE [dbo].[Booking_Table] CHECK CONSTRAINT [FK_Booking_Table_Reservation]
GO
ALTER TABLE [dbo].[Booking_Table]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Table_Table] FOREIGN KEY([table_id])
REFERENCES [dbo].[Table] ([id])
GO
ALTER TABLE [dbo].[Booking_Table] CHECK CONSTRAINT [FK_Booking_Table_Table]
GO
ALTER TABLE [dbo].[Reservation]  WITH CHECK ADD  CONSTRAINT [FK_Reservation_User] FOREIGN KEY([id])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Reservation] CHECK CONSTRAINT [FK_Reservation_User]
GO
ALTER TABLE [dbo].[Schedule_Table]  WITH CHECK ADD  CONSTRAINT [FK_Schedule_Table_Table] FOREIGN KEY([table_id])
REFERENCES [dbo].[Table] ([id])
GO
ALTER TABLE [dbo].[Schedule_Table] CHECK CONSTRAINT [FK_Schedule_Table_Table]
GO
USE [master]
GO
ALTER DATABASE [BookingRestaurant] SET  READ_WRITE 
GO

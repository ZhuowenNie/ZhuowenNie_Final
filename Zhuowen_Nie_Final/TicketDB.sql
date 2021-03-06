USE [master]
GO
/****** Object:  Database [ticket]    Script Date: 04/20/2016 23:17:47 ******/
CREATE DATABASE [ticket] ON  PRIMARY 
( NAME = N'Ticket', FILENAME = N'D:\Ticket.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Ticket_log', FILENAME = N'D:\Ticket_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
EXEC dbo.sp_dbcmptlevel @dbname=N'ticket', @new_cmptlevel=90
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ticket].[dbo].[sp_fulltext_database] @action = 'disable'
end
GO
ALTER DATABASE [ticket] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [ticket] SET ANSI_NULLS OFF
GO
ALTER DATABASE [ticket] SET ANSI_PADDING OFF
GO
ALTER DATABASE [ticket] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [ticket] SET ARITHABORT OFF
GO
ALTER DATABASE [ticket] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [ticket] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [ticket] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [ticket] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [ticket] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [ticket] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [ticket] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [ticket] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [ticket] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [ticket] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [ticket] SET  DISABLE_BROKER
GO
ALTER DATABASE [ticket] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [ticket] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [ticket] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [ticket] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [ticket] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [ticket] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [ticket] SET  READ_WRITE
GO
ALTER DATABASE [ticket] SET RECOVERY FULL
GO
ALTER DATABASE [ticket] SET  MULTI_USER
GO
ALTER DATABASE [ticket] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [ticket] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'ticket', N'ON'
GO
USE [ticket]
GO
/****** Object:  Table [dbo].[TicketInfo]    Script Date: 04/20/2016 23:17:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TicketInfo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FlightNO] [varchar](50) NOT NULL,
	[LeaveCity] [varchar](50) NOT NULL,
	[Destination] [varchar](50) NOT NULL,
	[LeaveTime] [datetime] NOT NULL,
	[arriveTime] [datetime] NULL,
	[SecondClass] [float] NOT NULL,
	[FirstClass] [float] NOT NULL,
	[SeatCount] [int] NULL,
 CONSTRAINT [PK_TicketInfo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_TicketInfo] ON [dbo].[TicketInfo] 
(
	[FlightNO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主键' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TicketInfo', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'航班号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TicketInfo', @level2type=N'COLUMN',@level2name=N'FlightNO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'出发城市' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TicketInfo', @level2type=N'COLUMN',@level2name=N'LeaveCity'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'目的城市' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TicketInfo', @level2type=N'COLUMN',@level2name=N'Destination'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'出发时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TicketInfo', @level2type=N'COLUMN',@level2name=N'LeaveTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'经济舱票价' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TicketInfo', @level2type=N'COLUMN',@level2name=N'SecondClass'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'头等舱票价' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TicketInfo', @level2type=N'COLUMN',@level2name=N'FirstClass'
GO
SET IDENTITY_INSERT [dbo].[TicketInfo] ON
INSERT [dbo].[TicketInfo] ([Id], [FlightNO], [LeaveCity], [Destination], [LeaveTime], [arriveTime], [SecondClass], [FirstClass], [SeatCount]) VALUES (124, N'FK453', N'Shanghai', N'Xian', CAST(0x00009C3100F73140 AS DateTime), CAST(0x00009C31011826C0 AS DateTime), 200, 1200, 26)
INSERT [dbo].[TicketInfo] ([Id], [FlightNO], [LeaveCity], [Destination], [LeaveTime], [arriveTime], [SecondClass], [FirstClass], [SeatCount]) VALUES (125, N'FM0152', N'bejing', N'Shanghai', CAST(0x00009C3100FD8270 AS DateTime), CAST(0x00009C310120F0C0 AS DateTime), 3000, 4000, 21)
INSERT [dbo].[TicketInfo] ([Id], [FlightNO], [LeaveCity], [Destination], [LeaveTime], [arriveTime], [SecondClass], [FirstClass], [SeatCount]) VALUES (126, N'HK563', N'Xian', N'Hong Kong', CAST(0x00009C3400DD1990 AS DateTime), CAST(0x00009C3401232340 AS DateTime), 2500, 3000, 38)
INSERT [dbo].[TicketInfo] ([Id], [FlightNO], [LeaveCity], [Destination], [LeaveTime], [arriveTime], [SecondClass], [FirstClass], [SeatCount]) VALUES (127, N'FM0345', N'Xian', N'Shanghai', CAST(0x00009C4700EC34C0 AS DateTime), CAST(0x00009C4700FF6EA0 AS DateTime), 800, 1200, 33)
INSERT [dbo].[TicketInfo] ([Id], [FlightNO], [LeaveCity], [Destination], [LeaveTime], [arriveTime], [SecondClass], [FirstClass], [SeatCount]) VALUES (128, N'FM3303', N'Xian', N'Hong Kong', CAST(0x00009C4E00CDFE60 AS DateTime), CAST(0x00009C4E00F1B300 AS DateTime), 3000, 4000, 19)
INSERT [dbo].[TicketInfo] ([Id], [FlightNO], [LeaveCity], [Destination], [LeaveTime], [arriveTime], [SecondClass], [FirstClass], [SeatCount]) VALUES (129, N'FM3308', N'Shanghai', N'Hong Kong', CAST(0x00009C4F00D63BC0 AS DateTime), CAST(0x00009C4F00FF6EA0 AS DateTime), 2500, 3000, 84)
INSERT [dbo].[TicketInfo] ([Id], [FlightNO], [LeaveCity], [Destination], [LeaveTime], [arriveTime], [SecondClass], [FirstClass], [SeatCount]) VALUES (130, N'HK003', N'Xian', N'Hong Kong', CAST(0x00009C7F00DE7920 AS DateTime), CAST(0x00009C7F010D2A40 AS DateTime), 600, 3000, 97)
INSERT [dbo].[TicketInfo] ([Id], [FlightNO], [LeaveCity], [Destination], [LeaveTime], [arriveTime], [SecondClass], [FirstClass], [SeatCount]) VALUES (131, N'11111', N'11', N'1111', CAST(0x00009C7F00000000 AS DateTime), CAST(0x00009C7F00000000 AS DateTime), 111, 11, 111)
INSERT [dbo].[TicketInfo] ([Id], [FlightNO], [LeaveCity], [Destination], [LeaveTime], [arriveTime], [SecondClass], [FirstClass], [SeatCount]) VALUES (132, N'AK47', N'Xian', N'bejing', CAST(0x00009C7F00D63BC0 AS DateTime), CAST(0x00009C7F00000000 AS DateTime), 3444, 55555, 200)
INSERT [dbo].[TicketInfo] ([Id], [FlightNO], [LeaveCity], [Destination], [LeaveTime], [arriveTime], [SecondClass], [FirstClass], [SeatCount]) VALUES (133, N'FM002', N'Xian', N'Shanghai', CAST(0x00009C9000C5C100 AS DateTime), CAST(0x00009C9000E6B680 AS DateTime), 2000, 3000, 28)
INSERT [dbo].[TicketInfo] ([Id], [FlightNO], [LeaveCity], [Destination], [LeaveTime], [arriveTime], [SecondClass], [FirstClass], [SeatCount]) VALUES (134, N'FM0002', N'Xian', N'Shanghai', CAST(0x00009CAB00CDFE60 AS DateTime), CAST(0x00009CAB00EEF3E0 AS DateTime), 800, 1800, 100)
INSERT [dbo].[TicketInfo] ([Id], [FlightNO], [LeaveCity], [Destination], [LeaveTime], [arriveTime], [SecondClass], [FirstClass], [SeatCount]) VALUES (135, N'FM001', N'Xian', N'jp', CAST(0x0000000000D8FAE0 AS DateTime), CAST(0x0000000000FCAF80 AS DateTime), 3000, 3500, 40)
SET IDENTITY_INSERT [dbo].[TicketInfo] OFF
/****** Object:  Table [dbo].[User_Login]    Script Date: 04/20/2016 23:17:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User_Login](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[Pwd] [nvarchar](50) NULL,
	[author] [int] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[User_Login] ON
INSERT [dbo].[User_Login] ([UserID], [UserName], [Pwd], [author]) VALUES (1, N'admin', N'admin', 1)
INSERT [dbo].[User_Login] ([UserID], [UserName], [Pwd], [author]) VALUES (2, N'abc', N'abc', 2)
SET IDENTITY_INSERT [dbo].[User_Login] OFF
/****** Object:  StoredProcedure [dbo].[up_GetTicketByFilter]    Script Date: 04/20/2016 23:17:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[up_GetTicketByFilter] 
	@LeaveCity varchar(50),
	@Destination varchar(50)
AS
BEGIN
	Select * from TicketInfo
	Where LeaveCity like '%' + @LeaveCity + '%'
	and Destination like '%' + @Destination + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[up_GetAllTicket]    Script Date: 04/20/2016 23:17:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[up_GetAllTicket] 

AS
BEGIN
	Select * from TicketInfo
END
GO
/****** Object:  Table [dbo].[OrderInfo]    Script Date: 04/20/2016 23:17:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[OrderInfo](
	[FlightNo] [varchar](50) NOT NULL,
	[LeaveDate] [varchar](100) NOT NULL,
	[SeatType] [varchar](20) NOT NULL,
	[Number] [int] NOT NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[IDCard] [nvarchar](50) NULL,
	[State] [nvarchar](50) NULL,
	[userID] [int] NULL,
	[username] [varchar](50) NULL,
 CONSTRAINT [PK_OrderInfo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[OrderInfo] ON
INSERT [dbo].[OrderInfo] ([FlightNo], [LeaveDate], [SeatType], [Number], [id], [IDCard], [State], [userID], [username]) VALUES (N'FK453', N'2009年6月25日', N'Economy', 1, 3, N'610321198502070059', N'0', NULL, NULL)
INSERT [dbo].[OrderInfo] ([FlightNo], [LeaveDate], [SeatType], [Number], [id], [IDCard], [State], [userID], [username]) VALUES (N'FM0152', N'2009年6月23日', N'Business', 1, 4, N'610321198502070059', N'0', NULL, NULL)
INSERT [dbo].[OrderInfo] ([FlightNo], [LeaveDate], [SeatType], [Number], [id], [IDCard], [State], [userID], [username]) VALUES (N'FK453', N'2009年6月23日', N'Business', 1, 8, N'610321198301230059', N'0', NULL, NULL)
INSERT [dbo].[OrderInfo] ([FlightNo], [LeaveDate], [SeatType], [Number], [id], [IDCard], [State], [userID], [username]) VALUES (N'HK563', N'2009年6月23日', N'Economy', 2, 9, N'610321198702070059', N'0', NULL, NULL)
INSERT [dbo].[OrderInfo] ([FlightNo], [LeaveDate], [SeatType], [Number], [id], [IDCard], [State], [userID], [username]) VALUES (N'HK563', N'2009年6月23日', N'Economy', 10, 11, N'610321198302070035', N'1', NULL, NULL)
INSERT [dbo].[OrderInfo] ([FlightNo], [LeaveDate], [SeatType], [Number], [id], [IDCard], [State], [userID], [username]) VALUES (N'FM0345', N'2009年6月23日', N'Economy', 1, 13, N'610321198703060035', N'0', NULL, NULL)
INSERT [dbo].[OrderInfo] ([FlightNo], [LeaveDate], [SeatType], [Number], [id], [IDCard], [State], [userID], [username]) VALUES (N'FM3303', N'2009年6月23日', N'Economy', 1, 15, N'610321198302070045', N'0', NULL, NULL)
INSERT [dbo].[OrderInfo] ([FlightNo], [LeaveDate], [SeatType], [Number], [id], [IDCard], [State], [userID], [username]) VALUES (N'HK563', N'2009年6月23日', N'Economy', 1, 17, N'666666666666666666666666', N'0', NULL, NULL)
INSERT [dbo].[OrderInfo] ([FlightNo], [LeaveDate], [SeatType], [Number], [id], [IDCard], [State], [userID], [username]) VALUES (N'FM3308', N'2009年6月25日', N'Economy', 10, 19, N'11111111', N'0', NULL, NULL)
INSERT [dbo].[OrderInfo] ([FlightNo], [LeaveDate], [SeatType], [Number], [id], [IDCard], [State], [userID], [username]) VALUES (N'HK003', N'2009年9月10日', N'Business', 3, 20, N'610321196602070034', N'0', NULL, NULL)
INSERT [dbo].[OrderInfo] ([FlightNo], [LeaveDate], [SeatType], [Number], [id], [IDCard], [State], [userID], [username]) VALUES (N'FM002', N'2009年9月26日', N'Business', 2, 22, N'610321198702040045', N'0', NULL, NULL)
INSERT [dbo].[OrderInfo] ([FlightNo], [LeaveDate], [SeatType], [Number], [id], [IDCard], [State], [userID], [username]) VALUES (N'FK453', N'2009年6月23日', N'Business', 2, 29, N'234234', N'1', NULL, NULL)
INSERT [dbo].[OrderInfo] ([FlightNo], [LeaveDate], [SeatType], [Number], [id], [IDCard], [State], [userID], [username]) VALUES (N'FM3308', N'2009年6月23日', N'Business', 2, 30, N'234234234', N'1', NULL, NULL)
INSERT [dbo].[OrderInfo] ([FlightNo], [LeaveDate], [SeatType], [Number], [id], [IDCard], [State], [userID], [username]) VALUES (N'FM0345', N'2009年6月23日', N'Business', 2, 31, N'242342352343', N'1', NULL, NULL)
INSERT [dbo].[OrderInfo] ([FlightNo], [LeaveDate], [SeatType], [Number], [id], [IDCard], [State], [userID], [username]) VALUES (N'FK453', N'2009年6月23日', N'Business', 2, 32, N'23423423432234', N'1', NULL, N'abc')
SET IDENTITY_INSERT [dbo].[OrderInfo] OFF
/****** Object:  Default [DF_OrderInfo_State]    Script Date: 04/20/2016 23:17:51 ******/
ALTER TABLE [dbo].[OrderInfo] ADD  CONSTRAINT [DF_OrderInfo_State]  DEFAULT (N'有效') FOR [State]
GO
/****** Object:  ForeignKey [FK_OrderInfo_TicketInfo]    Script Date: 04/20/2016 23:17:51 ******/
ALTER TABLE [dbo].[OrderInfo]  WITH CHECK ADD  CONSTRAINT [FK_OrderInfo_TicketInfo] FOREIGN KEY([FlightNo])
REFERENCES [dbo].[TicketInfo] ([FlightNO])
GO
ALTER TABLE [dbo].[OrderInfo] CHECK CONSTRAINT [FK_OrderInfo_TicketInfo]
GO

alter table OrderInfo drop constraint df_orderinfo_state;
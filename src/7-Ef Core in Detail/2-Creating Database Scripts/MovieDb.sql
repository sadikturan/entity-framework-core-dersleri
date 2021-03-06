USE [MovieDb]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [MovieDb]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 22.06.2018 15:01:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movie]    Script Date: 22.06.2018 15:01:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movie](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Movie] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MovieCategory]    Script Date: 22.06.2018 15:01:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MovieCategory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MovieId] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
 CONSTRAINT [PK_MovieCategory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MovieDetail]    Script Date: 22.06.2018 15:01:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MovieDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Duration] [nvarchar](50) NOT NULL,
	[Year] [nvarchar](50) NOT NULL,
	[MovieId] [int] NOT NULL,
 CONSTRAINT [PK_MovieDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Trailer]    Script Date: 22.06.2018 15:01:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trailer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Duration] [nvarchar](50) NOT NULL,
	[MovieId] [int] NOT NULL,
 CONSTRAINT [PK_Trailer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Id], [Name]) VALUES (1, N'Category 1')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (2, N'Category 2')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (3, N'Category 3')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (4, N'Category 4')
SET IDENTITY_INSERT [dbo].[Category] OFF
SET IDENTITY_INSERT [dbo].[Movie] ON 

INSERT [dbo].[Movie] ([Id], [Name]) VALUES (1, N'Movie 1')
INSERT [dbo].[Movie] ([Id], [Name]) VALUES (2, N'Movie 2')
INSERT [dbo].[Movie] ([Id], [Name]) VALUES (3, N'Movie 3')
INSERT [dbo].[Movie] ([Id], [Name]) VALUES (4, N'Movie 4')
INSERT [dbo].[Movie] ([Id], [Name]) VALUES (5, N'Movie 5')
SET IDENTITY_INSERT [dbo].[Movie] OFF
SET IDENTITY_INSERT [dbo].[MovieCategory] ON 

INSERT [dbo].[MovieCategory] ([Id], [MovieId], [CategoryId]) VALUES (1, 1, 1)
INSERT [dbo].[MovieCategory] ([Id], [MovieId], [CategoryId]) VALUES (2, 1, 2)
INSERT [dbo].[MovieCategory] ([Id], [MovieId], [CategoryId]) VALUES (3, 1, 3)
INSERT [dbo].[MovieCategory] ([Id], [MovieId], [CategoryId]) VALUES (4, 2, 1)
INSERT [dbo].[MovieCategory] ([Id], [MovieId], [CategoryId]) VALUES (5, 2, 2)
INSERT [dbo].[MovieCategory] ([Id], [MovieId], [CategoryId]) VALUES (6, 2, 3)
INSERT [dbo].[MovieCategory] ([Id], [MovieId], [CategoryId]) VALUES (7, 3, 1)
INSERT [dbo].[MovieCategory] ([Id], [MovieId], [CategoryId]) VALUES (8, 3, 4)
SET IDENTITY_INSERT [dbo].[MovieCategory] OFF
SET IDENTITY_INSERT [dbo].[MovieDetail] ON 

INSERT [dbo].[MovieDetail] ([Id], [Duration], [Year], [MovieId]) VALUES (1, N'90', N'2015', 1)
INSERT [dbo].[MovieDetail] ([Id], [Duration], [Year], [MovieId]) VALUES (3, N'100', N'2016', 2)
INSERT [dbo].[MovieDetail] ([Id], [Duration], [Year], [MovieId]) VALUES (4, N'85', N'2017', 3)
INSERT [dbo].[MovieDetail] ([Id], [Duration], [Year], [MovieId]) VALUES (5, N'90', N'2013', 4)
SET IDENTITY_INSERT [dbo].[MovieDetail] OFF
SET IDENTITY_INSERT [dbo].[Trailer] ON 

INSERT [dbo].[Trailer] ([Id], [Name], [Duration], [MovieId]) VALUES (1, N'Trailer 1', N'10', 1)
INSERT [dbo].[Trailer] ([Id], [Name], [Duration], [MovieId]) VALUES (2, N'Trailer 2', N'15', 2)
INSERT [dbo].[Trailer] ([Id], [Name], [Duration], [MovieId]) VALUES (3, N'Trailer 3', N'5', 1)
INSERT [dbo].[Trailer] ([Id], [Name], [Duration], [MovieId]) VALUES (4, N'Trailer 4', N'4', 2)
SET IDENTITY_INSERT [dbo].[Trailer] OFF
/****** Object:  Index [IX_MovieDetail_MovieId]    Script Date: 22.06.2018 15:01:40 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_MovieDetail_MovieId] ON [dbo].[MovieDetail]
(
	[MovieId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[MovieCategory]  WITH CHECK ADD  CONSTRAINT [FK_MovieCategory_Category] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([Id])
GO
ALTER TABLE [dbo].[MovieCategory] CHECK CONSTRAINT [FK_MovieCategory_Category]
GO
ALTER TABLE [dbo].[MovieCategory]  WITH CHECK ADD  CONSTRAINT [FK_MovieCategory_Movie] FOREIGN KEY([MovieId])
REFERENCES [dbo].[Movie] ([Id])
GO
ALTER TABLE [dbo].[MovieCategory] CHECK CONSTRAINT [FK_MovieCategory_Movie]
GO
ALTER TABLE [dbo].[MovieDetail]  WITH CHECK ADD  CONSTRAINT [FK_MovieDetail_Movie] FOREIGN KEY([MovieId])
REFERENCES [dbo].[Movie] ([Id])
GO
ALTER TABLE [dbo].[MovieDetail] CHECK CONSTRAINT [FK_MovieDetail_Movie]
GO
ALTER TABLE [dbo].[Trailer]  WITH CHECK ADD  CONSTRAINT [FK_Trailer_Movie] FOREIGN KEY([MovieId])
REFERENCES [dbo].[Movie] ([Id])
GO
ALTER TABLE [dbo].[Trailer] CHECK CONSTRAINT [FK_Trailer_Movie]
GO
USE [master]
GO
ALTER DATABASE [MovieDb] SET  READ_WRITE 
GO

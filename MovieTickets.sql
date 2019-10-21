USE [Movierentals]
GO
ALTER TABLE [dbo].[RentedMovies] DROP CONSTRAINT [FK__RentedMov__Rente__4E88ABD4]
GO
ALTER TABLE [dbo].[RentedMovies] DROP CONSTRAINT [FK__RentedMov__Rente__4D94879B]
GO
/****** Object:  Table [dbo].[RentedMovies]    Script Date: 07-10-2019 11:21:21 AM ******/
DROP TABLE [dbo].[RentedMovies]
GO
/****** Object:  Table [dbo].[Movies]    Script Date: 07-10-2019 11:21:21 AM ******/
DROP TABLE [dbo].[Movies]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 07-10-2019 11:21:21 AM ******/
DROP TABLE [dbo].[Customer]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 07-10-2019 11:21:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerID] [int] IDENTITY(10,1) NOT NULL,
	[CustomerFirstName] [nvarchar](255) NULL,
	[CustomerLastName] [nvarchar](255) NULL,
	[CustomerAddress] [nvarchar](255) NULL,
	[CustomerPhone] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movies]    Script Date: 07-10-2019 11:21:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movies](
	[MoviesID] [int] IDENTITY(10,1) NOT NULL,
	[MoviesRatings] [nvarchar](50) NULL,
	[MoviesTitle] [nvarchar](255) NULL,
	[MoviesYear] [nvarchar](255) NULL,
	[MoviesRental_Cost] [money] NULL,
	[MoviesCopies] [nvarchar](50) NULL,
	[MoviesPlot] [ntext] NULL,
	[MoviesGenre] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MoviesID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentedMovies]    Script Date: 07-10-2019 11:21:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentedMovies](
	[RentedMovieID] [int] IDENTITY(10,1) NOT NULL,
	[RentedMovie_MID_FK] [int] NULL,
	[RentedMovie_CID_FK] [int] NULL,
	[RentedMovie_DateRented] [datetime] NULL,
	[RentedMovie_DateReturned] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[RentedMovieID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[RentedMovies]  WITH CHECK ADD FOREIGN KEY([RentedMovie_CID_FK])
REFERENCES [dbo].[Customer] ([CustomerID])
GO
ALTER TABLE [dbo].[RentedMovies]  WITH CHECK ADD  CONSTRAINT [FK__RentedMov__Rente__4E88ABD4] FOREIGN KEY([RentedMovie_MID_FK])
REFERENCES [dbo].[Movies] ([MoviesID])
GO
ALTER TABLE [dbo].[RentedMovies] CHECK CONSTRAINT [FK__RentedMov__Rente__4E88ABD4]
GO

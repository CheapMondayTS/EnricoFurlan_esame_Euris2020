USE [TheSpaceCinema]
GO
/****** Object:  Table [dbo].[Biglietto]    Script Date: 19/11/2020 15:51:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Biglietto](
	[IdBiglietto] [int] IDENTITY(1,1) NOT NULL,
	[NumeroPosto] [int] NOT NULL,
	[Fila] [nvarchar](1) NOT NULL,
 CONSTRAINT [PK_Biglietto] PRIMARY KEY CLUSTERED 
(
	[IdBiglietto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BigliettoSpettatoreFilmSalaCinematografica-incr]    Script Date: 19/11/2020 15:51:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BigliettoSpettatoreFilmSalaCinematografica-incr](
	[Id] [int] NOT NULL,
	[IdBiglietto] [int] NOT NULL,
	[IdSpettatore] [int] NOT NULL,
	[IdFilm] [int] NOT NULL,
	[IdSalaCinematografica] [int] NOT NULL,
	[Prezzo] [int] NOT NULL,
 CONSTRAINT [PK_BigliettoSpettatoreFilmSalaCinematografica-incr] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cinema]    Script Date: 19/11/2020 15:51:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cinema](
	[IdCinema] [int] IDENTITY(1,1) NOT NULL,
	[NomeCinema] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Cinema] PRIMARY KEY CLUSTERED 
(
	[IdCinema] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CinemaSalaCinematografica-incr]    Script Date: 19/11/2020 15:51:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CinemaSalaCinematografica-incr](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdCinema] [int] NOT NULL,
	[IdSalaCinematografica] [int] NOT NULL,
 CONSTRAINT [PK_CinemaSalaCinematografica-incr] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Film]    Script Date: 19/11/2020 15:51:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Film](
	[IdFilm] [int] IDENTITY(1,1) NOT NULL,
	[TitoloFilm] [nvarchar](50) NOT NULL,
	[Autore] [nvarchar](50) NOT NULL,
	[Produttore] [nvarchar](50) NOT NULL,
	[Genere] [nvarchar](50) NOT NULL,
	[Durata] [int] NOT NULL,
 CONSTRAINT [PK_Film] PRIMARY KEY CLUSTERED 
(
	[IdFilm] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalaCinematografica]    Script Date: 19/11/2020 15:51:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalaCinematografica](
	[IdSalaCinematografica] [int] IDENTITY(1,1) NOT NULL,
	[NomeSalaCinematografica] [nvarchar](50) NOT NULL,
	[Capienza] [int] NOT NULL,
 CONSTRAINT [PK_SalaCinematografica] PRIMARY KEY CLUSTERED 
(
	[IdSalaCinematografica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalaCinematograficaFilm-incr]    Script Date: 19/11/2020 15:51:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalaCinematograficaFilm-incr](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdSalaCinematografica] [int] NOT NULL,
	[IdFilm] [int] NOT NULL,
	[IdSpettatore] [int] NOT NULL,
	[IdBiglietto] [int] NOT NULL,
 CONSTRAINT [PK_SalaCinematograficaFilm-incr] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Spettatore]    Script Date: 19/11/2020 15:51:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Spettatore](
	[IdSpettatore] [int] IDENTITY(1,1) NOT NULL,
	[NomeSpettatore] [nvarchar](50) NOT NULL,
	[CognomeSpettatore] [nvarchar](50) NOT NULL,
	[DataNascita] [date] NOT NULL,
 CONSTRAINT [PK_Spettatore] PRIMARY KEY CLUSTERED 
(
	[IdSpettatore] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Biglietto] ON 

INSERT [dbo].[Biglietto] ([IdBiglietto], [NumeroPosto], [Fila]) VALUES (1, 10, N'E')
INSERT [dbo].[Biglietto] ([IdBiglietto], [NumeroPosto], [Fila]) VALUES (2, 11, N'E')
INSERT [dbo].[Biglietto] ([IdBiglietto], [NumeroPosto], [Fila]) VALUES (3, 9, N'F')
SET IDENTITY_INSERT [dbo].[Biglietto] OFF
GO
SET IDENTITY_INSERT [dbo].[Cinema] ON 

INSERT [dbo].[Cinema] ([IdCinema], [NomeCinema]) VALUES (1, N'The Space Cinema')
SET IDENTITY_INSERT [dbo].[Cinema] OFF
GO
SET IDENTITY_INSERT [dbo].[Film] ON 

INSERT [dbo].[Film] ([IdFilm], [TitoloFilm], [Autore], [Produttore], [Genere], [Durata]) VALUES (1, N'Close Encounters of the Third Kind', N'Steven Spielberg', N'Julia Phillips, Michael Phillips', N'Science Fiction', 137)
INSERT [dbo].[Film] ([IdFilm], [TitoloFilm], [Autore], [Produttore], [Genere], [Durata]) VALUES (2, N'Halloween', N'David Gordon Green', N'Malek Akkad, Jason Blum, Bill Block

', N'Horror', 108)
INSERT [dbo].[Film] ([IdFilm], [TitoloFilm], [Autore], [Produttore], [Genere], [Durata]) VALUES (3, N'Toy Story 4', N'Josh Cooley', N'Mark Nielsen, Jonas Rivera', N'Animation', 120)
SET IDENTITY_INSERT [dbo].[Film] OFF
GO
SET IDENTITY_INSERT [dbo].[SalaCinematografica] ON 

INSERT [dbo].[SalaCinematografica] ([IdSalaCinematografica], [NomeSalaCinematografica], [Capienza]) VALUES (1, N'Sala 1', 120)
INSERT [dbo].[SalaCinematografica] ([IdSalaCinematografica], [NomeSalaCinematografica], [Capienza]) VALUES (2, N'Sala 2', 150)
INSERT [dbo].[SalaCinematografica] ([IdSalaCinematografica], [NomeSalaCinematografica], [Capienza]) VALUES (3, N'Sala 3', 100)
SET IDENTITY_INSERT [dbo].[SalaCinematografica] OFF
GO
SET IDENTITY_INSERT [dbo].[Spettatore] ON 

INSERT [dbo].[Spettatore] ([IdSpettatore], [NomeSpettatore], [CognomeSpettatore], [DataNascita]) VALUES (1, N'Enrico', N'Furlan', CAST(N'1991-05-04' AS Date))
INSERT [dbo].[Spettatore] ([IdSpettatore], [NomeSpettatore], [CognomeSpettatore], [DataNascita]) VALUES (2, N'Luca', N'Rosato', CAST(N'2017-08-01' AS Date))
INSERT [dbo].[Spettatore] ([IdSpettatore], [NomeSpettatore], [CognomeSpettatore], [DataNascita]) VALUES (3, N'Stefano', N'Stenner', CAST(N'1935-07-24' AS Date))
SET IDENTITY_INSERT [dbo].[Spettatore] OFF
GO

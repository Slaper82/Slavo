USE [SlaWypo]
GO
/****** Object:  User [przefoltyn]    Script Date: 2017-04-19 16:32:24 ******/
CREATE USER [przefoltyn] FOR LOGIN [przefoltyn] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[wypKlient]    Script Date: 2017-04-19 16:32:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wypKlient](
	[IdKlient] [int] IDENTITY(1,1) NOT NULL,
	[Nazwa] [nvarchar](200) NOT NULL,
	[NIP] [nvarchar](14) NOT NULL,
	[Ulica] [nvarchar](200) NOT NULL,
	[Miasto] [nvarchar](200) NOT NULL,
	[NrDomu] [nvarchar](10) NOT NULL,
	[NrMieszkania] [nvarchar](8) NOT NULL,
	[KodPocz] [nvarchar](6) NOT NULL,
	[Tel] [nvarchar](50) NOT NULL DEFAULT (' '),
	[OsobaKont] [nvarchar](300) NOT NULL DEFAULT (' '),
PRIMARY KEY CLUSTERED 
(
	[IdKlient] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[wypLogowanie]    Script Date: 2017-04-19 16:32:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wypLogowanie](
	[IdUser] [int] IDENTITY(1,1) NOT NULL,
	[Nazwa] [nvarchar](50) NOT NULL,
	[Pass] [nvarchar](20) NOT NULL,
	[IdUpra] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[wypMarka]    Script Date: 2017-04-19 16:32:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wypMarka](
	[IdMarka] [int] IDENTITY(1,1) NOT NULL,
	[Nazwa] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdMarka] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[wypModel]    Script Date: 2017-04-19 16:32:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wypModel](
	[IdModel] [int] IDENTITY(1,1) NOT NULL,
	[Nazwa] [nvarchar](50) NOT NULL,
	[IdMarka] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdModel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[wypNaprawa]    Script Date: 2017-04-19 16:32:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wypNaprawa](
	[IdNapr] [int] IDENTITY(1,1) NOT NULL,
	[IdSamo] [int] NOT NULL,
	[DStart] [smalldatetime] NOT NULL,
	[DStop] [smalldatetime] NOT NULL,
	[Kwota] [decimal](8, 2) NOT NULL,
	[Opis] [nvarchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdNapr] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[wypPaliwo]    Script Date: 2017-04-19 16:32:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wypPaliwo](
	[IdTypSilnik] [int] NOT NULL,
	[Nazwa] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdTypSilnik] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[wypSamochod]    Script Date: 2017-04-19 16:32:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wypSamochod](
	[IdSam] [int] IDENTITY(1,1) NOT NULL,
	[IdMarka] [int] NOT NULL,
	[IdModel] [int] NOT NULL,
	[TablRej] [nvarchar](12) NOT NULL,
	[Status] [bit] NOT NULL DEFAULT ((0)),
	[RokProd] [int] NOT NULL,
	[IdPaliwa] [int] NOT NULL,
	[Kolor] [nvarchar](30) NULL,
	[Pojemnosc] [decimal](6, 2) NULL DEFAULT ((1.6)),
	[Active] [bit] NULL DEFAULT ((1)),
PRIMARY KEY CLUSTERED 
(
	[IdSam] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[wypUprawnienia]    Script Date: 2017-04-19 16:32:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wypUprawnienia](
	[IdUpra] [int] NOT NULL,
	[Nazwa] [nvarchar](20) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[wypWypoDni]    Script Date: 2017-04-19 16:32:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wypWypoDni](
	[IdTran] [int] IDENTITY(1,1) NOT NULL,
	[IdSamo] [int] NOT NULL,
	[IdKlient] [int] NOT NULL,
	[DataWyp] [date] NOT NULL,
	[Stawka] [decimal](18, 0) NOT NULL,
	[IdWypo] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[wypWypozycz]    Script Date: 2017-04-19 16:32:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wypWypozycz](
	[IdWypo] [int] IDENTITY(1,1) NOT NULL,
	[IdSamo] [int] NOT NULL,
	[IdKlient] [int] NOT NULL,
	[DStart] [smalldatetime] NOT NULL,
	[DStop] [smalldatetime] NOT NULL,
	[Stawka] [decimal](8, 2) NOT NULL,
	[Suma] [decimal](8, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdWypo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[NapListaView]    Script Date: 2017-04-19 16:32:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[NapListaView]
as
	
		SELECT n.IdNapr,n.IdSamo,n.DStart,n.DStop,n.Kwota,m.Nazwa+' '+s.TablRej as Nazwa,n.Opis FROM wypNaprawa AS n
		INNER JOIN wypSamochod AS s ON n.IdSamo=s.IdSam
		INNER JOIN wypModel AS m ON s.IdModel=m.IdModel



GO
SET IDENTITY_INSERT [dbo].[wypKlient] ON 

INSERT [dbo].[wypKlient] ([IdKlient], [Nazwa], [NIP], [Ulica], [Miasto], [NrDomu], [NrMieszkania], [KodPocz], [Tel], [OsobaKont]) VALUES (1, N'Stefan', N'541-222-34-11', N'Fajna', N'Kraków', N'12', N'2', N'09-888', N'12312-32121', N'Maniek')
INSERT [dbo].[wypKlient] ([IdKlient], [Nazwa], [NIP], [Ulica], [Miasto], [NrDomu], [NrMieszkania], [KodPocz], [Tel], [OsobaKont]) VALUES (2, N'Lalala', N'541-222-34-11', N'Czekoladowa', N'Kraków', N'12', N'2', N'09-888', N'12312-32121', N'Maniek')
INSERT [dbo].[wypKlient] ([IdKlient], [Nazwa], [NIP], [Ulica], [Miasto], [NrDomu], [NrMieszkania], [KodPocz], [Tel], [OsobaKont]) VALUES (3, N'Marian', N'66666666666666', N'jhvhjg', N'jhg', N'77', N'7', N'7yy789', N'888', N'jhvhjjh')
INSERT [dbo].[wypKlient] ([IdKlient], [Nazwa], [NIP], [Ulica], [Miasto], [NrDomu], [NrMieszkania], [KodPocz], [Tel], [OsobaKont]) VALUES (4, N'sdfsd', N'hgv', N'hgvkjhghjb', N'hgv', N'hgv', N'hgv', N'hbjnjn', N'hgv', N'hgchgv')
INSERT [dbo].[wypKlient] ([IdKlient], [Nazwa], [NIP], [Ulica], [Miasto], [NrDomu], [NrMieszkania], [KodPocz], [Tel], [OsobaKont]) VALUES (5, N'wdewed', N'787', N'ughjbh', N'b', N'h', N'hgvhgv', N'ghvhh', N'ghvhvgh', N'vgvg')
INSERT [dbo].[wypKlient] ([IdKlient], [Nazwa], [NIP], [Ulica], [Miasto], [NrDomu], [NrMieszkania], [KodPocz], [Tel], [OsobaKont]) VALUES (6, N'lal;k;l', N'999099909', N'knn', N'mnmn', N'2', N'22', N'05-239', N'123', N'888')
INSERT [dbo].[wypKlient] ([IdKlient], [Nazwa], [NIP], [Ulica], [Miasto], [NrDomu], [NrMieszkania], [KodPocz], [Tel], [OsobaKont]) VALUES (7, N'ZZZZZZZZZZZZZZZZZZZ', N' knkjnikjn', N'knljhn', N'oihou', N'hjuhb', N'ijhbjk', N'bjkb', N'jkbkj', N'juuy')
SET IDENTITY_INSERT [dbo].[wypKlient] OFF
SET IDENTITY_INSERT [dbo].[wypLogowanie] ON 

INSERT [dbo].[wypLogowanie] ([IdUser], [Nazwa], [Pass], [IdUpra]) VALUES (1, N'sl', N'sl', 1)
INSERT [dbo].[wypLogowanie] ([IdUser], [Nazwa], [Pass], [IdUpra]) VALUES (2, N'pr', N'pr', 2)
SET IDENTITY_INSERT [dbo].[wypLogowanie] OFF
SET IDENTITY_INSERT [dbo].[wypMarka] ON 

INSERT [dbo].[wypMarka] ([IdMarka], [Nazwa]) VALUES (1, N'Renault')
INSERT [dbo].[wypMarka] ([IdMarka], [Nazwa]) VALUES (2, N'Dacia')
INSERT [dbo].[wypMarka] ([IdMarka], [Nazwa]) VALUES (3, N'Ford')
INSERT [dbo].[wypMarka] ([IdMarka], [Nazwa]) VALUES (4, N'Honda')
INSERT [dbo].[wypMarka] ([IdMarka], [Nazwa]) VALUES (7, N'Volvo')
SET IDENTITY_INSERT [dbo].[wypMarka] OFF
SET IDENTITY_INSERT [dbo].[wypModel] ON 

INSERT [dbo].[wypModel] ([IdModel], [Nazwa], [IdMarka]) VALUES (2, N'Megane', 1)
INSERT [dbo].[wypModel] ([IdModel], [Nazwa], [IdMarka]) VALUES (3, N'Traffic', 1)
INSERT [dbo].[wypModel] ([IdModel], [Nazwa], [IdMarka]) VALUES (4, N'Logan', 2)
INSERT [dbo].[wypModel] ([IdModel], [Nazwa], [IdMarka]) VALUES (5, N'Accord', 4)
INSERT [dbo].[wypModel] ([IdModel], [Nazwa], [IdMarka]) VALUES (7, N'XC60', 7)
SET IDENTITY_INSERT [dbo].[wypModel] OFF
SET IDENTITY_INSERT [dbo].[wypNaprawa] ON 

INSERT [dbo].[wypNaprawa] ([IdNapr], [IdSamo], [DStart], [DStop], [Kwota], [Opis]) VALUES (10, 7, CAST(N'2017-04-11 23:02:00' AS SmallDateTime), CAST(N'2017-04-16 23:02:00' AS SmallDateTime), CAST(1000.00 AS Decimal(8, 2)), N'koła')
INSERT [dbo].[wypNaprawa] ([IdNapr], [IdSamo], [DStart], [DStop], [Kwota], [Opis]) VALUES (11, 2, CAST(N'2017-04-19 12:39:00' AS SmallDateTime), CAST(N'2017-04-21 12:39:00' AS SmallDateTime), CAST(570.00 AS Decimal(8, 2)), N'Wymiana cewki')
INSERT [dbo].[wypNaprawa] ([IdNapr], [IdSamo], [DStart], [DStop], [Kwota], [Opis]) VALUES (12, 9, CAST(N'2017-04-10 12:40:00' AS SmallDateTime), CAST(N'2017-04-14 12:40:00' AS SmallDateTime), CAST(730.00 AS Decimal(8, 2)), N'Wahacz i przegub')
INSERT [dbo].[wypNaprawa] ([IdNapr], [IdSamo], [DStart], [DStop], [Kwota], [Opis]) VALUES (13, 2, CAST(N'2017-04-19 12:42:00' AS SmallDateTime), CAST(N'2017-04-19 12:42:00' AS SmallDateTime), CAST(1150.00 AS Decimal(8, 2)), N'Lusterko')
INSERT [dbo].[wypNaprawa] ([IdNapr], [IdSamo], [DStart], [DStop], [Kwota], [Opis]) VALUES (14, 9, CAST(N'2017-04-19 12:43:00' AS SmallDateTime), CAST(N'2017-04-20 12:43:00' AS SmallDateTime), CAST(1200.00 AS Decimal(8, 2)), N'Urwana klamka')
SET IDENTITY_INSERT [dbo].[wypNaprawa] OFF
INSERT [dbo].[wypPaliwo] ([IdTypSilnik], [Nazwa]) VALUES (1, N'Benzyna')
INSERT [dbo].[wypPaliwo] ([IdTypSilnik], [Nazwa]) VALUES (2, N'Diesel')
INSERT [dbo].[wypPaliwo] ([IdTypSilnik], [Nazwa]) VALUES (3, N'Gaz')
SET IDENTITY_INSERT [dbo].[wypSamochod] ON 

INSERT [dbo].[wypSamochod] ([IdSam], [IdMarka], [IdModel], [TablRej], [Status], [RokProd], [IdPaliwa], [Kolor], [Pojemnosc], [Active]) VALUES (2, 1, 2, N'WPR 20342', 0, 2017, 1, N'czaeny', CAST(1.40 AS Decimal(6, 2)), 1)
INSERT [dbo].[wypSamochod] ([IdSam], [IdMarka], [IdModel], [TablRej], [Status], [RokProd], [IdPaliwa], [Kolor], [Pojemnosc], [Active]) VALUES (3, 1, 2, N'WS 54333', 0, 2016, 1, N'czerwony', CAST(2.00 AS Decimal(6, 2)), 1)
INSERT [dbo].[wypSamochod] ([IdSam], [IdMarka], [IdModel], [TablRej], [Status], [RokProd], [IdPaliwa], [Kolor], [Pojemnosc], [Active]) VALUES (4, 2, 4, N'WPR 43234', 0, 2015, 2, N'Zielony', CAST(1.10 AS Decimal(6, 2)), 0)
INSERT [dbo].[wypSamochod] ([IdSam], [IdMarka], [IdModel], [TablRej], [Status], [RokProd], [IdPaliwa], [Kolor], [Pojemnosc], [Active]) VALUES (5, 1, 2, N'WWW', 0, 1981, 1, N'bbb', CAST(2.00 AS Decimal(6, 2)), 0)
INSERT [dbo].[wypSamochod] ([IdSam], [IdMarka], [IdModel], [TablRej], [Status], [RokProd], [IdPaliwa], [Kolor], [Pojemnosc], [Active]) VALUES (6, 1, 3, N'WI 39395', 0, 2015, 1, N'Zielony', CAST(1.60 AS Decimal(6, 2)), 1)
INSERT [dbo].[wypSamochod] ([IdSam], [IdMarka], [IdModel], [TablRej], [Status], [RokProd], [IdPaliwa], [Kolor], [Pojemnosc], [Active]) VALUES (7, 1, 2, N'WY 76474', 0, 2001, 2, N'oidj', CAST(2.00 AS Decimal(6, 2)), 1)
INSERT [dbo].[wypSamochod] ([IdSam], [IdMarka], [IdModel], [TablRej], [Status], [RokProd], [IdPaliwa], [Kolor], [Pojemnosc], [Active]) VALUES (8, 4, 5, N'WU 52839', 0, 2005, 1, N'Srebrny', CAST(2.00 AS Decimal(6, 2)), 1)
INSERT [dbo].[wypSamochod] ([IdSam], [IdMarka], [IdModel], [TablRej], [Status], [RokProd], [IdPaliwa], [Kolor], [Pojemnosc], [Active]) VALUES (9, 7, 7, N'WI 5533G', 0, 2014, 1, N'Biały', CAST(2.40 AS Decimal(6, 2)), 1)
SET IDENTITY_INSERT [dbo].[wypSamochod] OFF
INSERT [dbo].[wypUprawnienia] ([IdUpra], [Nazwa]) VALUES (1, N'Administrator')
INSERT [dbo].[wypUprawnienia] ([IdUpra], [Nazwa]) VALUES (2, N'Kierownik')
INSERT [dbo].[wypUprawnienia] ([IdUpra], [Nazwa]) VALUES (3, N'Pracownik')
SET IDENTITY_INSERT [dbo].[wypWypoDni] ON 

INSERT [dbo].[wypWypoDni] ([IdTran], [IdSamo], [IdKlient], [DataWyp], [Stawka], [IdWypo]) VALUES (5179, 8, 3, CAST(N'2017-04-17' AS Date), CAST(200 AS Decimal(18, 0)), 22)
INSERT [dbo].[wypWypoDni] ([IdTran], [IdSamo], [IdKlient], [DataWyp], [Stawka], [IdWypo]) VALUES (5159, 7, 3, CAST(N'2017-04-16' AS Date), CAST(200 AS Decimal(18, 0)), 18)
INSERT [dbo].[wypWypoDni] ([IdTran], [IdSamo], [IdKlient], [DataWyp], [Stawka], [IdWypo]) VALUES (5160, 7, 3, CAST(N'2017-04-17' AS Date), CAST(200 AS Decimal(18, 0)), 18)
INSERT [dbo].[wypWypoDni] ([IdTran], [IdSamo], [IdKlient], [DataWyp], [Stawka], [IdWypo]) VALUES (5161, 7, 3, CAST(N'2017-04-18' AS Date), CAST(200 AS Decimal(18, 0)), 18)
INSERT [dbo].[wypWypoDni] ([IdTran], [IdSamo], [IdKlient], [DataWyp], [Stawka], [IdWypo]) VALUES (5162, 7, 3, CAST(N'2017-04-19' AS Date), CAST(200 AS Decimal(18, 0)), 18)
INSERT [dbo].[wypWypoDni] ([IdTran], [IdSamo], [IdKlient], [DataWyp], [Stawka], [IdWypo]) VALUES (5163, 7, 3, CAST(N'2017-04-20' AS Date), CAST(200 AS Decimal(18, 0)), 18)
INSERT [dbo].[wypWypoDni] ([IdTran], [IdSamo], [IdKlient], [DataWyp], [Stawka], [IdWypo]) VALUES (5164, 6, 4, CAST(N'2017-04-16' AS Date), CAST(1000 AS Decimal(18, 0)), 19)
INSERT [dbo].[wypWypoDni] ([IdTran], [IdSamo], [IdKlient], [DataWyp], [Stawka], [IdWypo]) VALUES (5165, 6, 4, CAST(N'2017-04-17' AS Date), CAST(1000 AS Decimal(18, 0)), 19)
INSERT [dbo].[wypWypoDni] ([IdTran], [IdSamo], [IdKlient], [DataWyp], [Stawka], [IdWypo]) VALUES (5166, 6, 4, CAST(N'2017-04-18' AS Date), CAST(1000 AS Decimal(18, 0)), 19)
INSERT [dbo].[wypWypoDni] ([IdTran], [IdSamo], [IdKlient], [DataWyp], [Stawka], [IdWypo]) VALUES (5167, 6, 4, CAST(N'2017-04-19' AS Date), CAST(1000 AS Decimal(18, 0)), 19)
INSERT [dbo].[wypWypoDni] ([IdTran], [IdSamo], [IdKlient], [DataWyp], [Stawka], [IdWypo]) VALUES (5168, 6, 4, CAST(N'2017-04-20' AS Date), CAST(1000 AS Decimal(18, 0)), 19)
INSERT [dbo].[wypWypoDni] ([IdTran], [IdSamo], [IdKlient], [DataWyp], [Stawka], [IdWypo]) VALUES (5169, 6, 4, CAST(N'2017-04-21' AS Date), CAST(1000 AS Decimal(18, 0)), 19)
INSERT [dbo].[wypWypoDni] ([IdTran], [IdSamo], [IdKlient], [DataWyp], [Stawka], [IdWypo]) VALUES (5170, 6, 4, CAST(N'2017-04-22' AS Date), CAST(1000 AS Decimal(18, 0)), 19)
INSERT [dbo].[wypWypoDni] ([IdTran], [IdSamo], [IdKlient], [DataWyp], [Stawka], [IdWypo]) VALUES (5171, 6, 4, CAST(N'2017-04-23' AS Date), CAST(1000 AS Decimal(18, 0)), 19)
INSERT [dbo].[wypWypoDni] ([IdTran], [IdSamo], [IdKlient], [DataWyp], [Stawka], [IdWypo]) VALUES (5172, 6, 4, CAST(N'2017-04-24' AS Date), CAST(1000 AS Decimal(18, 0)), 19)
INSERT [dbo].[wypWypoDni] ([IdTran], [IdSamo], [IdKlient], [DataWyp], [Stawka], [IdWypo]) VALUES (5173, 6, 4, CAST(N'2017-04-25' AS Date), CAST(1000 AS Decimal(18, 0)), 19)
INSERT [dbo].[wypWypoDni] ([IdTran], [IdSamo], [IdKlient], [DataWyp], [Stawka], [IdWypo]) VALUES (5174, 6, 4, CAST(N'2017-04-26' AS Date), CAST(1000 AS Decimal(18, 0)), 19)
INSERT [dbo].[wypWypoDni] ([IdTran], [IdSamo], [IdKlient], [DataWyp], [Stawka], [IdWypo]) VALUES (5175, 6, 1, CAST(N'2017-04-16' AS Date), CAST(150 AS Decimal(18, 0)), 20)
INSERT [dbo].[wypWypoDni] ([IdTran], [IdSamo], [IdKlient], [DataWyp], [Stawka], [IdWypo]) VALUES (5176, 6, 1, CAST(N'2017-04-17' AS Date), CAST(150 AS Decimal(18, 0)), 20)
INSERT [dbo].[wypWypoDni] ([IdTran], [IdSamo], [IdKlient], [DataWyp], [Stawka], [IdWypo]) VALUES (5177, 6, 1, CAST(N'2017-04-18' AS Date), CAST(150 AS Decimal(18, 0)), 20)
INSERT [dbo].[wypWypoDni] ([IdTran], [IdSamo], [IdKlient], [DataWyp], [Stawka], [IdWypo]) VALUES (5178, 2, 7, CAST(N'2017-04-16' AS Date), CAST(700 AS Decimal(18, 0)), 21)
INSERT [dbo].[wypWypoDni] ([IdTran], [IdSamo], [IdKlient], [DataWyp], [Stawka], [IdWypo]) VALUES (5180, 9, 2, CAST(N'2017-04-17' AS Date), CAST(150 AS Decimal(18, 0)), 23)
INSERT [dbo].[wypWypoDni] ([IdTran], [IdSamo], [IdKlient], [DataWyp], [Stawka], [IdWypo]) VALUES (5181, 9, 2, CAST(N'2017-04-18' AS Date), CAST(150 AS Decimal(18, 0)), 23)
INSERT [dbo].[wypWypoDni] ([IdTran], [IdSamo], [IdKlient], [DataWyp], [Stawka], [IdWypo]) VALUES (5182, 9, 2, CAST(N'2017-04-19' AS Date), CAST(150 AS Decimal(18, 0)), 23)
INSERT [dbo].[wypWypoDni] ([IdTran], [IdSamo], [IdKlient], [DataWyp], [Stawka], [IdWypo]) VALUES (5183, 9, 2, CAST(N'2017-04-20' AS Date), CAST(150 AS Decimal(18, 0)), 23)
SET IDENTITY_INSERT [dbo].[wypWypoDni] OFF
SET IDENTITY_INSERT [dbo].[wypWypozycz] ON 

INSERT [dbo].[wypWypozycz] ([IdWypo], [IdSamo], [IdKlient], [DStart], [DStop], [Stawka], [Suma]) VALUES (18, 7, 3, CAST(N'2017-04-16 00:00:00' AS SmallDateTime), CAST(N'2017-04-21 00:00:00' AS SmallDateTime), CAST(200.00 AS Decimal(8, 2)), CAST(1000.00 AS Decimal(8, 2)))
INSERT [dbo].[wypWypozycz] ([IdWypo], [IdSamo], [IdKlient], [DStart], [DStop], [Stawka], [Suma]) VALUES (19, 6, 4, CAST(N'2017-04-16 00:00:00' AS SmallDateTime), CAST(N'2017-04-27 00:00:00' AS SmallDateTime), CAST(1000.00 AS Decimal(8, 2)), CAST(11000.00 AS Decimal(8, 2)))
INSERT [dbo].[wypWypozycz] ([IdWypo], [IdSamo], [IdKlient], [DStart], [DStop], [Stawka], [Suma]) VALUES (20, 6, 1, CAST(N'2017-04-16 00:00:00' AS SmallDateTime), CAST(N'2017-04-19 00:00:00' AS SmallDateTime), CAST(150.00 AS Decimal(8, 2)), CAST(450.00 AS Decimal(8, 2)))
INSERT [dbo].[wypWypozycz] ([IdWypo], [IdSamo], [IdKlient], [DStart], [DStop], [Stawka], [Suma]) VALUES (21, 2, 7, CAST(N'2017-04-16 00:00:00' AS SmallDateTime), CAST(N'2017-04-17 00:00:00' AS SmallDateTime), CAST(700.00 AS Decimal(8, 2)), CAST(700.00 AS Decimal(8, 2)))
INSERT [dbo].[wypWypozycz] ([IdWypo], [IdSamo], [IdKlient], [DStart], [DStop], [Stawka], [Suma]) VALUES (22, 8, 3, CAST(N'2017-04-17 00:00:00' AS SmallDateTime), CAST(N'2017-04-18 00:00:00' AS SmallDateTime), CAST(200.00 AS Decimal(8, 2)), CAST(200.00 AS Decimal(8, 2)))
INSERT [dbo].[wypWypozycz] ([IdWypo], [IdSamo], [IdKlient], [DStart], [DStop], [Stawka], [Suma]) VALUES (23, 9, 2, CAST(N'2017-04-17 00:00:00' AS SmallDateTime), CAST(N'2017-04-21 00:00:00' AS SmallDateTime), CAST(150.00 AS Decimal(8, 2)), CAST(600.00 AS Decimal(8, 2)))
SET IDENTITY_INSERT [dbo].[wypWypozycz] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__wypLogow__602223FF5D2A8758]    Script Date: 2017-04-19 16:32:24 ******/
ALTER TABLE [dbo].[wypLogowanie] ADD UNIQUE NONCLUSTERED 
(
	[Nazwa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[wypModel]  WITH CHECK ADD  CONSTRAINT [FK_wypMarka_wypModel] FOREIGN KEY([IdMarka])
REFERENCES [dbo].[wypMarka] ([IdMarka])
GO
ALTER TABLE [dbo].[wypModel] CHECK CONSTRAINT [FK_wypMarka_wypModel]
GO
ALTER TABLE [dbo].[wypNaprawa]  WITH CHECK ADD  CONSTRAINT [FK_wypSamo_wypNaprawa] FOREIGN KEY([IdSamo])
REFERENCES [dbo].[wypSamochod] ([IdSam])
GO
ALTER TABLE [dbo].[wypNaprawa] CHECK CONSTRAINT [FK_wypSamo_wypNaprawa]
GO
ALTER TABLE [dbo].[wypSamochod]  WITH CHECK ADD  CONSTRAINT [FK_wypMarka_wypSamochod] FOREIGN KEY([IdMarka])
REFERENCES [dbo].[wypMarka] ([IdMarka])
GO
ALTER TABLE [dbo].[wypSamochod] CHECK CONSTRAINT [FK_wypMarka_wypSamochod]
GO
ALTER TABLE [dbo].[wypSamochod]  WITH CHECK ADD  CONSTRAINT [FK_wypModel_wypSamochod] FOREIGN KEY([IdModel])
REFERENCES [dbo].[wypModel] ([IdModel])
GO
ALTER TABLE [dbo].[wypSamochod] CHECK CONSTRAINT [FK_wypModel_wypSamochod]
GO
ALTER TABLE [dbo].[wypSamochod]  WITH CHECK ADD  CONSTRAINT [FK_wypPaliwo_wypSamochod] FOREIGN KEY([IdPaliwa])
REFERENCES [dbo].[wypPaliwo] ([IdTypSilnik])
GO
ALTER TABLE [dbo].[wypSamochod] CHECK CONSTRAINT [FK_wypPaliwo_wypSamochod]
GO
ALTER TABLE [dbo].[wypWypozycz]  WITH CHECK ADD  CONSTRAINT [FK_wypKlient_wypWypozycz] FOREIGN KEY([IdKlient])
REFERENCES [dbo].[wypKlient] ([IdKlient])
GO
ALTER TABLE [dbo].[wypWypozycz] CHECK CONSTRAINT [FK_wypKlient_wypWypozycz]
GO
ALTER TABLE [dbo].[wypWypozycz]  WITH CHECK ADD  CONSTRAINT [FK_wypSamo_wypWypozycz] FOREIGN KEY([IdSamo])
REFERENCES [dbo].[wypSamochod] ([IdSam])
GO
ALTER TABLE [dbo].[wypWypozycz] CHECK CONSTRAINT [FK_wypSamo_wypWypozycz]
GO
/****** Object:  StoredProcedure [dbo].[NapLista]    Script Date: 2017-04-19 16:32:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NapLista]
AS
	BEGIN
		SELECT n.IdNapr,n.IdSamo,n.DStart,n.DStop,n.Kwota,m.Nazwa+' '+s.TablRej as Nazwa FROM wypNaprawa AS n
		INNER JOIN wypSamochod AS s ON n.IdSamo=s.IdSam
		INNER JOIN wypModel AS m ON s.IdModel=m.IdModel
	END


GO
/****** Object:  StoredProcedure [dbo].[SamoEdit]    Script Date: 2017-04-19 16:32:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SamoEdit](@Id AS INT)
AS 
BEGIN
	SELECT IdSam,IdMarka,IdModel,TablRej,[Status],RokProd,IdPaliwa,Kolor,Pojemnosc,Active 
			FROM wypSamochod
			WHERE IdSam=@Id
END	

GO
/****** Object:  StoredProcedure [dbo].[SamoWyb]    Script Date: 2017-04-19 16:32:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SamoWyb]
AS
	BEGIN
		SELECT s.IdSam,m.Nazwa+' '+s.TablRej AS Nazwa 
		FROM wypSamochod AS s
		INNER JOIN wypModel AS m ON s.IdModel=m.IdModel
		where s.Active=1
	END


GO
/****** Object:  StoredProcedure [dbo].[UsunKlient]    Script Date: 2017-04-19 16:32:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UsunKlient](@id as int)
as
	begin
		delete from wypKlient
		where IdKlient=@id;
	end

GO
/****** Object:  StoredProcedure [dbo].[WypoSum]    Script Date: 2017-04-19 16:32:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[WypoSum] (@Start as DateTime,@Stop as DateTime)
AS
	BEGIN
		SELECT sum(Stawka)
		FROM wypWypoDni 
		where DataWyp>@Start and DataWyp<@Stop
	END

GO
/****** Object:  StoredProcedure [dbo].[ZapKlientEdyt]    Script Date: 2017-04-19 16:32:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ZapKlientEdyt](@IdKlient as int
,@nazwa as nvarchar(200)
,@nip as nvarchar(14)
,@ulica as nvarchar(200)
,@miasto as nvarchar(200)
,@nrdomu as nvarchar(10)
,@nrmieszkania as nvarchar(8)
,@kodpoczt as nvarchar(6)
,@tel as nvarchar(50)
,@osoba as nvarchar(300))
as
begin
	update wypKlient
		set Nazwa=@nazwa,NIP=@nip,Ulica=@ulica,Miasto=@miasto,NrDomu=@nrdomu,NrMieszkania=@nrmieszkania,KodPocz=@kodpoczt,Tel=@tel,OsobaKont=@osoba
		where IdKlient=@IdKlient
end


GO

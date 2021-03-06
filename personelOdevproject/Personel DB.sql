USE [PersonelDB]
GO
/****** Object:  Table [dbo].[Kullanici]    Script Date: 16.12.2020 21:12:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanici](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciAdi] [nvarchar](50) NULL,
	[Sifre] [nvarchar](50) NULL,
 CONSTRAINT [PK_Kullanici] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personel]    Script Date: 16.12.2020 21:12:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personel](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](50) NULL,
	[Soyad] [nvarchar](50) NULL,
	[TC] [nvarchar](50) NULL,
	[SicilNo] [nvarchar](50) NULL,
	[BrutUcret] [decimal](18, 3) NULL,
	[SSKPrimiIsciPayi] [decimal](18, 3) NULL,
	[IssizlikSigortasiIsciPayi] [decimal](18, 3) NULL,
	[GelirVergisiMatrah] [decimal](18, 3) NULL,
	[GelirVergisiMiktar] [decimal](18, 3) NULL,
	[DamgaVergisiMiktari] [decimal](18, 3) NULL,
	[Kesinti] [decimal](18, 3) NULL,
	[NetUcret] [decimal](18, 3) NULL,
 CONSTRAINT [PK_Personel] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Kullanici] ON 

INSERT [dbo].[Kullanici] ([Id], [KullaniciAdi], [Sifre]) VALUES (3, N'ID1959id2372', N'abc')
SET IDENTITY_INSERT [dbo].[Kullanici] OFF
SET IDENTITY_INSERT [dbo].[Personel] ON 

INSERT [dbo].[Personel] ([Id], [Ad], [Soyad], [TC], [SicilNo], [BrutUcret], [SSKPrimiIsciPayi], [IssizlikSigortasiIsciPayi], [GelirVergisiMatrah], [GelirVergisiMiktar], [DamgaVergisiMiktari], [Kesinti], [NetUcret]) VALUES (2, N'Ahmet', N'Akın', N'1111111', N'1231', CAST(2500.000 AS Decimal(18, 3)), CAST(350.000 AS Decimal(18, 3)), CAST(25.000 AS Decimal(18, 3)), CAST(2125.000 AS Decimal(18, 3)), CAST(318.750 AS Decimal(18, 3)), CAST(18.975 AS Decimal(18, 3)), CAST(712.725 AS Decimal(18, 3)), CAST(1787.275 AS Decimal(18, 3)))
INSERT [dbo].[Personel] ([Id], [Ad], [Soyad], [TC], [SicilNo], [BrutUcret], [SSKPrimiIsciPayi], [IssizlikSigortasiIsciPayi], [GelirVergisiMatrah], [GelirVergisiMiktar], [DamgaVergisiMiktari], [Kesinti], [NetUcret]) VALUES (3, N'Mehmet', N'Akın', N'2222222', N'12322', CAST(3500.000 AS Decimal(18, 3)), CAST(490.000 AS Decimal(18, 3)), CAST(35.000 AS Decimal(18, 3)), CAST(2975.000 AS Decimal(18, 3)), CAST(446.250 AS Decimal(18, 3)), CAST(26.565 AS Decimal(18, 3)), CAST(997.815 AS Decimal(18, 3)), CAST(2502.185 AS Decimal(18, 3)))
INSERT [dbo].[Personel] ([Id], [Ad], [Soyad], [TC], [SicilNo], [BrutUcret], [SSKPrimiIsciPayi], [IssizlikSigortasiIsciPayi], [GelirVergisiMatrah], [GelirVergisiMiktar], [DamgaVergisiMiktari], [Kesinti], [NetUcret]) VALUES (4, N'Ahmet', N'Mehmet', N'123123123', N'400', CAST(2500.000 AS Decimal(18, 3)), CAST(350.000 AS Decimal(18, 3)), CAST(25.000 AS Decimal(18, 3)), CAST(2125.000 AS Decimal(18, 3)), CAST(318.750 AS Decimal(18, 3)), CAST(18.975 AS Decimal(18, 3)), CAST(712.725 AS Decimal(18, 3)), CAST(1787.275 AS Decimal(18, 3)))
INSERT [dbo].[Personel] ([Id], [Ad], [Soyad], [TC], [SicilNo], [BrutUcret], [SSKPrimiIsciPayi], [IssizlikSigortasiIsciPayi], [GelirVergisiMatrah], [GelirVergisiMiktar], [DamgaVergisiMiktari], [Kesinti], [NetUcret]) VALUES (5, N'Yasin', N'Kuru', N'123412321', N'451', CAST(2500.000 AS Decimal(18, 3)), CAST(350.000 AS Decimal(18, 3)), CAST(25.000 AS Decimal(18, 3)), CAST(2125.000 AS Decimal(18, 3)), CAST(318.750 AS Decimal(18, 3)), CAST(18.975 AS Decimal(18, 3)), CAST(712.725 AS Decimal(18, 3)), CAST(1787.275 AS Decimal(18, 3)))
INSERT [dbo].[Personel] ([Id], [Ad], [Soyad], [TC], [SicilNo], [BrutUcret], [SSKPrimiIsciPayi], [IssizlikSigortasiIsciPayi], [GelirVergisiMatrah], [GelirVergisiMiktar], [DamgaVergisiMiktari], [Kesinti], [NetUcret]) VALUES (6, N'Tuncay', N'Akın', N'96385274132', N'99987', CAST(4000.000 AS Decimal(18, 3)), CAST(560.000 AS Decimal(18, 3)), CAST(40.000 AS Decimal(18, 3)), CAST(3400.000 AS Decimal(18, 3)), CAST(510.000 AS Decimal(18, 3)), CAST(30.360 AS Decimal(18, 3)), CAST(1140.360 AS Decimal(18, 3)), CAST(2859.640 AS Decimal(18, 3)))
INSERT [dbo].[Personel] ([Id], [Ad], [Soyad], [TC], [SicilNo], [BrutUcret], [SSKPrimiIsciPayi], [IssizlikSigortasiIsciPayi], [GelirVergisiMatrah], [GelirVergisiMiktar], [DamgaVergisiMiktari], [Kesinti], [NetUcret]) VALUES (7, N'Ceyhan', N'Solarmı', N'9876543209', N'2541', CAST(5000.000 AS Decimal(18, 3)), CAST(700.000 AS Decimal(18, 3)), CAST(50.000 AS Decimal(18, 3)), CAST(4250.000 AS Decimal(18, 3)), CAST(637.500 AS Decimal(18, 3)), CAST(37.950 AS Decimal(18, 3)), CAST(1425.450 AS Decimal(18, 3)), CAST(3574.550 AS Decimal(18, 3)))
INSERT [dbo].[Personel] ([Id], [Ad], [Soyad], [TC], [SicilNo], [BrutUcret], [SSKPrimiIsciPayi], [IssizlikSigortasiIsciPayi], [GelirVergisiMatrah], [GelirVergisiMiktar], [DamgaVergisiMiktari], [Kesinti], [NetUcret]) VALUES (9, N'asdasd', N'asdasd', N'123123', N'1223', CAST(12323.000 AS Decimal(18, 3)), CAST(1725.220 AS Decimal(18, 3)), CAST(123.230 AS Decimal(18, 3)), CAST(10474.550 AS Decimal(18, 3)), CAST(1571.183 AS Decimal(18, 3)), CAST(93.532 AS Decimal(18, 3)), CAST(3513.164 AS Decimal(18, 3)), CAST(8809.836 AS Decimal(18, 3)))
INSERT [dbo].[Personel] ([Id], [Ad], [Soyad], [TC], [SicilNo], [BrutUcret], [SSKPrimiIsciPayi], [IssizlikSigortasiIsciPayi], [GelirVergisiMatrah], [GelirVergisiMiktar], [DamgaVergisiMiktari], [Kesinti], [NetUcret]) VALUES (10, N'eeeeeee', N'eeeeee', N'222222', N'33333', CAST(4444.000 AS Decimal(18, 3)), CAST(622.160 AS Decimal(18, 3)), CAST(44.440 AS Decimal(18, 3)), CAST(3777.400 AS Decimal(18, 3)), CAST(566.610 AS Decimal(18, 3)), CAST(33.730 AS Decimal(18, 3)), CAST(1266.940 AS Decimal(18, 3)), CAST(3177.060 AS Decimal(18, 3)))
INSERT [dbo].[Personel] ([Id], [Ad], [Soyad], [TC], [SicilNo], [BrutUcret], [SSKPrimiIsciPayi], [IssizlikSigortasiIsciPayi], [GelirVergisiMatrah], [GelirVergisiMiktar], [DamgaVergisiMiktari], [Kesinti], [NetUcret]) VALUES (11, N'ffffffff', N'ffffffff', N'333333', N'555', CAST(455555.000 AS Decimal(18, 3)), CAST(63777.700 AS Decimal(18, 3)), CAST(4555.550 AS Decimal(18, 3)), CAST(387221.750 AS Decimal(18, 3)), CAST(58083.263 AS Decimal(18, 3)), CAST(3457.662 AS Decimal(18, 3)), CAST(129874.175 AS Decimal(18, 3)), CAST(325680.825 AS Decimal(18, 3)))
SET IDENTITY_INSERT [dbo].[Personel] OFF

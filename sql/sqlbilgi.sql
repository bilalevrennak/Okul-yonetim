USE [yonetimpanel]
GO
/****** Object:  Table [dbo].[ders]    Script Date: 2.12.2022 16:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ders](
	[id] [nchar](10) NOT NULL,
	[ad] [nchar](10) NULL,
	[kredi] [nchar](10) NULL,
	[okulyonetimid] [nchar](10) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ogrenci]    Script Date: 2.12.2022 16:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ogrenci](
	[id] [varchar](50) NULL,
	[adsoyad] [nchar](10) NULL,
	[kayittarihi] [date] NULL,
	[ogrencino] [varchar](50) NULL,
	[dogumtarihi] [date] NULL,
	[bolum] [nchar](10) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ogrenciders]    Script Date: 2.12.2022 16:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ogrenciders](
	[id] [nchar](10) NOT NULL,
	[dersid] [nchar](10) NULL,
	[ogrenciid] [nchar](10) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[yonetim]    Script Date: 2.12.2022 16:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[yonetim](
	[id] [nchar](10) NOT NULL,
	[adsoyad] [nchar](10) NULL,
	[gorev] [nchar](10) NULL,
	[yonetimtipi] [nchar](10) NULL
) ON [PRIMARY]

GO

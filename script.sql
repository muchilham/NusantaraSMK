USE [master]
GO
/****** Object:  Database [NusantaraSMKDB]    Script Date: 4/25/2016 7:49:26 AM ******/
CREATE DATABASE [NusantaraSMKDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'NusantaraSMKDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\NusantaraSMKDB.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'NusantaraSMKDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\NusantaraSMKDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [NusantaraSMKDB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [NusantaraSMKDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [NusantaraSMKDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [NusantaraSMKDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [NusantaraSMKDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [NusantaraSMKDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [NusantaraSMKDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [NusantaraSMKDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [NusantaraSMKDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [NusantaraSMKDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [NusantaraSMKDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [NusantaraSMKDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [NusantaraSMKDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [NusantaraSMKDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [NusantaraSMKDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [NusantaraSMKDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [NusantaraSMKDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [NusantaraSMKDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [NusantaraSMKDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [NusantaraSMKDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [NusantaraSMKDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [NusantaraSMKDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [NusantaraSMKDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [NusantaraSMKDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [NusantaraSMKDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [NusantaraSMKDB] SET  MULTI_USER 
GO
ALTER DATABASE [NusantaraSMKDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [NusantaraSMKDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [NusantaraSMKDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [NusantaraSMKDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [NusantaraSMKDB] SET DELAYED_DURABILITY = DISABLED 
GO
USE [NusantaraSMKDB]
GO
/****** Object:  Table [dbo].[tbl_Animasi]    Script Date: 4/25/2016 7:49:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Animasi](
	[kode_jurusan] [int] NOT NULL,
 CONSTRAINT [PK_tbl_Animasi] PRIMARY KEY CLUSTERED 
(
	[kode_jurusan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_CalonSiswa]    Script Date: 4/25/2016 7:49:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_CalonSiswa](
	[no_pendaftaran] [int] NOT NULL,
	[password] [varchar](50) NULL,
	[nama] [varchar](50) NOT NULL,
	[tgl_lahir] [date] NOT NULL,
	[alamat] [varchar](100) NULL,
	[agama] [char](10) NULL,
	[email] [varchar](100) NOT NULL,
	[jenis_kelamin] [varchar](50) NOT NULL,
	[asal_sekolah] [varchar](50) NOT NULL,
	[kode_nilai] [int] NULL,
	[kode_jawaban] [int] NULL,
 CONSTRAINT [PK_tbl_CalonSiswa] PRIMARY KEY CLUSTERED 
(
	[no_pendaftaran] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Guru]    Script Date: 4/25/2016 7:49:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Guru](
	[nip] [int] NOT NULL,
 CONSTRAINT [PK_tbl_Guru] PRIMARY KEY CLUSTERED 
(
	[nip] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Informasi]    Script Date: 4/25/2016 7:49:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Informasi](
	[kode_informasi] [int] IDENTITY(1,1) NOT NULL,
	[judul] [varchar](50) NOT NULL,
	[isi] [varchar](1000) NOT NULL,
	[tanggal] [datetime] NOT NULL,
	[nip] [int] NOT NULL,
 CONSTRAINT [PK_tbl_Informasi] PRIMARY KEY CLUSTERED 
(
	[kode_informasi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Jadwal]    Script Date: 4/25/2016 7:49:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Jadwal](
	[kode_jadwal] [int] IDENTITY(1,1) NOT NULL,
	[kode_soal] [int] NOT NULL,
	[tanggal] [datetime] NOT NULL,
	[nip] [int] NOT NULL,
 CONSTRAINT [PK_tbl_Jadwal] PRIMARY KEY CLUSTERED 
(
	[kode_jadwal] ASC,
	[kode_soal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Jawaban]    Script Date: 4/25/2016 7:49:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Jawaban](
	[kode_jawaban] [int] IDENTITY(1,1) NOT NULL,
	[file_jawaban] [text] NOT NULL,
	[kode_soal] [int] NOT NULL,
 CONSTRAINT [PK_tbl_Jawaban] PRIMARY KEY CLUSTERED 
(
	[kode_jawaban] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Jurusan]    Script Date: 4/25/2016 7:49:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Jurusan](
	[kode_jurusan] [int] IDENTITY(1,1) NOT NULL,
	[nama_jurusan] [char](20) NOT NULL,
	[deskripsi_jurusan] [text] NULL,
	[kapasitas] [int] NOT NULL,
	[foto_jurusan] [text] NOT NULL,
 CONSTRAINT [PK_tbl_Jurusan] PRIMARY KEY CLUSTERED 
(
	[kode_jurusan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Nilai]    Script Date: 4/25/2016 7:49:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Nilai](
	[kode_nilai] [int] IDENTITY(1,1) NOT NULL,
	[kode_soal] [int] NOT NULL,
 CONSTRAINT [PK_tbl_Nilai] PRIMARY KEY CLUSTERED 
(
	[kode_nilai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Otomotif]    Script Date: 4/25/2016 7:49:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Otomotif](
	[kode_jurusan] [int] NOT NULL,
 CONSTRAINT [PK_tbl_Otomotif] PRIMARY KEY CLUSTERED 
(
	[kode_jurusan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Pilihan]    Script Date: 4/25/2016 7:49:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Pilihan](
	[kode_pilihan] [int] IDENTITY(1,1) NOT NULL,
	[no_pendaftaran] [int] NOT NULL,
	[prioritas1] [varchar](50) NOT NULL,
	[prioritas2] [varchar](50) NOT NULL,
	[prioritas3] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_Pilihan] PRIMARY KEY CLUSTERED 
(
	[kode_pilihan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Rpl]    Script Date: 4/25/2016 7:49:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Rpl](
	[kode_jurusan] [int] NOT NULL,
 CONSTRAINT [PK_tbl_Rpl] PRIMARY KEY CLUSTERED 
(
	[kode_jurusan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Ruangan]    Script Date: 4/25/2016 7:49:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Ruangan](
	[kode_ruangan] [int] IDENTITY(1,1) NOT NULL,
	[kode_jadwal] [int] NOT NULL,
	[kode_soal] [int] NOT NULL,
	[kapasitas] [int] NULL,
 CONSTRAINT [PK_tbl_Ruangan] PRIMARY KEY CLUSTERED 
(
	[kode_ruangan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Soal]    Script Date: 4/25/2016 7:49:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Soal](
	[kode_soal] [int] IDENTITY(1,1) NOT NULL,
	[file_soal] [text] NOT NULL,
 CONSTRAINT [PK_tbl_Soal] PRIMARY KEY CLUSTERED 
(
	[kode_soal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Staf]    Script Date: 4/25/2016 7:49:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Staf](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[kode_karyawan]  AS ('KD'+right('000'+CONVERT([varchar](7),[ID]),(7))) PERSISTED,
	[nip] [int] NOT NULL,
	[password] [char](50) NOT NULL,
	[nama] [char](50) NOT NULL,
	[tgl_lahir] [date] NOT NULL,
	[alamat] [varchar](100) NOT NULL,
	[agama] [char](10) NULL,
	[email] [char](100) NOT NULL,
	[jenis_kelamin] [char](10) NOT NULL,
 CONSTRAINT [PK_tbl_Staf_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Staf_Tu]    Script Date: 4/25/2016 7:49:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Staf_Tu](
	[nip] [int] NOT NULL,
 CONSTRAINT [PK_tbl_Staf_Tu] PRIMARY KEY CLUSTERED 
(
	[nip] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Tkj]    Script Date: 4/25/2016 7:49:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Tkj](
	[kode_jurusan] [int] NOT NULL,
 CONSTRAINT [PK_tbl_Tkj] PRIMARY KEY CLUSTERED 
(
	[kode_jurusan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[tbl_CalonSiswa] ([no_pendaftaran], [password], [nama], [tgl_lahir], [alamat], [agama], [email], [jenis_kelamin], [asal_sekolah], [kode_nilai], [kode_jawaban]) VALUES (739549122, N'1dRqDrUjp', N'Muchammad Ilham', CAST(N'1998-06-06' AS Date), N'Jakarta', NULL, N'muh.ilham0606@gmail.com', N'Laki-laki', N'SMKN 24 Jakarta', NULL, NULL)
SET IDENTITY_INSERT [dbo].[tbl_Jurusan] ON 

INSERT [dbo].[tbl_Jurusan] ([kode_jurusan], [nama_jurusan], [deskripsi_jurusan], [kapasitas], [foto_jurusan]) VALUES (2, N'RPL                 ', N'Rekayasa perangkat lunak (RPL, atau dalam bahasa Inggris: Software Engineering atau SE) adalah satu bidang profesi yang mendalami cara-cara pengembangan perangkat lunak termasuk pembuatan, pemeliharaan, manajemen organisasi pengembanganan perangkat lunak dan manajemen kualitas.', 200, N'dscn0461.jpg')
INSERT [dbo].[tbl_Jurusan] ([kode_jurusan], [nama_jurusan], [deskripsi_jurusan], [kapasitas], [foto_jurusan]) VALUES (3, N'Animasi             ', N'Animasi adalah gambar begerak berbentuk dari sekumpulan objek (gambar) yang disusun secara beraturan mengikuti alur pergerakan yang telah ditentukan pada setiap pertambahan hitungan waktu yang terjadi. Gambar atau objek yang dimaksud dalam definisi di atas bisa berupa gambar manusia, hewan, maupun tulisan.', 200, N'animasi.jpg')
SET IDENTITY_INSERT [dbo].[tbl_Jurusan] OFF
SET IDENTITY_INSERT [dbo].[tbl_Pilihan] ON 

INSERT [dbo].[tbl_Pilihan] ([kode_pilihan], [no_pendaftaran], [prioritas1], [prioritas2], [prioritas3]) VALUES (8, 739549122, N'2', N'2', N'3')
SET IDENTITY_INSERT [dbo].[tbl_Pilihan] OFF
SET ANSI_PADDING ON
SET IDENTITY_INSERT [dbo].[tbl_Staf] ON 

INSERT [dbo].[tbl_Staf] ([id], [nip], [password], [nama], [tgl_lahir], [alamat], [agama], [email], [jenis_kelamin]) VALUES (7, 88741892, N'ilham123                                          ', N'Muchammad Ilham                                   ', CAST(N'1998-06-06' AS Date), N'Jakarta', N'Islam     ', N'muh.ilham0606@gmail.com                                                                             ', N'Laki-laki ')
SET IDENTITY_INSERT [dbo].[tbl_Staf] OFF
SET ANSI_PADDING OFF
/****** Object:  Index [UK_NIP]    Script Date: 4/25/2016 7:49:26 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UK_NIP] ON [dbo].[tbl_Staf]
(
	[nip] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbl_Animasi]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Animasi_tbl_Jurusan] FOREIGN KEY([kode_jurusan])
REFERENCES [dbo].[tbl_Jurusan] ([kode_jurusan])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_Animasi] CHECK CONSTRAINT [FK_tbl_Animasi_tbl_Jurusan]
GO
ALTER TABLE [dbo].[tbl_CalonSiswa]  WITH CHECK ADD  CONSTRAINT [FK_tbl_CalonSiswa_tbl_Jawaban] FOREIGN KEY([kode_jawaban])
REFERENCES [dbo].[tbl_Jawaban] ([kode_jawaban])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_CalonSiswa] CHECK CONSTRAINT [FK_tbl_CalonSiswa_tbl_Jawaban]
GO
ALTER TABLE [dbo].[tbl_CalonSiswa]  WITH CHECK ADD  CONSTRAINT [FK_tbl_CalonSiswa_tbl_Nilai] FOREIGN KEY([kode_nilai])
REFERENCES [dbo].[tbl_Nilai] ([kode_nilai])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_CalonSiswa] CHECK CONSTRAINT [FK_tbl_CalonSiswa_tbl_Nilai]
GO
ALTER TABLE [dbo].[tbl_Jadwal]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Jadwal_tbl_Soal] FOREIGN KEY([kode_soal])
REFERENCES [dbo].[tbl_Soal] ([kode_soal])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_Jadwal] CHECK CONSTRAINT [FK_tbl_Jadwal_tbl_Soal]
GO
ALTER TABLE [dbo].[tbl_Nilai]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Nilai_tbl_Soal] FOREIGN KEY([kode_soal])
REFERENCES [dbo].[tbl_Soal] ([kode_soal])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_Nilai] CHECK CONSTRAINT [FK_tbl_Nilai_tbl_Soal]
GO
ALTER TABLE [dbo].[tbl_Otomotif]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Otomotif_tbl_Jurusan] FOREIGN KEY([kode_jurusan])
REFERENCES [dbo].[tbl_Jurusan] ([kode_jurusan])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_Otomotif] CHECK CONSTRAINT [FK_tbl_Otomotif_tbl_Jurusan]
GO
ALTER TABLE [dbo].[tbl_Pilihan]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Pilihan_tbl_CalonSiswa] FOREIGN KEY([no_pendaftaran])
REFERENCES [dbo].[tbl_CalonSiswa] ([no_pendaftaran])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_Pilihan] CHECK CONSTRAINT [FK_tbl_Pilihan_tbl_CalonSiswa]
GO
ALTER TABLE [dbo].[tbl_Rpl]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Rpl_tbl_Jurusan] FOREIGN KEY([kode_jurusan])
REFERENCES [dbo].[tbl_Jurusan] ([kode_jurusan])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_Rpl] CHECK CONSTRAINT [FK_tbl_Rpl_tbl_Jurusan]
GO
ALTER TABLE [dbo].[tbl_Ruangan]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Ruangan_tbl_Jawaban] FOREIGN KEY([kode_jadwal])
REFERENCES [dbo].[tbl_Jawaban] ([kode_jawaban])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_Ruangan] CHECK CONSTRAINT [FK_tbl_Ruangan_tbl_Jawaban]
GO
ALTER TABLE [dbo].[tbl_Ruangan]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Ruangan_tbl_Soal] FOREIGN KEY([kode_soal])
REFERENCES [dbo].[tbl_Soal] ([kode_soal])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_Ruangan] CHECK CONSTRAINT [FK_tbl_Ruangan_tbl_Soal]
GO
ALTER TABLE [dbo].[tbl_Tkj]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Tkj_tbl_Jurusan] FOREIGN KEY([kode_jurusan])
REFERENCES [dbo].[tbl_Jurusan] ([kode_jurusan])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_Tkj] CHECK CONSTRAINT [FK_tbl_Tkj_tbl_Jurusan]
GO
ALTER TABLE [dbo].[tbl_CalonSiswa]  WITH CHECK ADD  CONSTRAINT [CK_email_CalonSiswa] CHECK  (([Email] like '_%@_%._%'))
GO
ALTER TABLE [dbo].[tbl_CalonSiswa] CHECK CONSTRAINT [CK_email_CalonSiswa]
GO
ALTER TABLE [dbo].[tbl_CalonSiswa]  WITH CHECK ADD  CONSTRAINT [CK_jeniskelamin_CalonSiswa] CHECK  (([jenis_kelamin]='Perempuan' OR [jenis_kelamin]='Laki-laki'))
GO
ALTER TABLE [dbo].[tbl_CalonSiswa] CHECK CONSTRAINT [CK_jeniskelamin_CalonSiswa]
GO
ALTER TABLE [dbo].[tbl_CalonSiswa]  WITH CHECK ADD  CONSTRAINT [CK_password_CalonSiswa] CHECK  ((len([password])>(4)))
GO
ALTER TABLE [dbo].[tbl_CalonSiswa] CHECK CONSTRAINT [CK_password_CalonSiswa]
GO
ALTER TABLE [dbo].[tbl_Jurusan]  WITH CHECK ADD  CONSTRAINT [CK_nama_Jurusan] CHECK  (([nama_jurusan] like replicate('%[a-zA-Z]%',len([nama_jurusan]))))
GO
ALTER TABLE [dbo].[tbl_Jurusan] CHECK CONSTRAINT [CK_nama_Jurusan]
GO
ALTER TABLE [dbo].[tbl_Staf]  WITH CHECK ADD  CONSTRAINT [CK_email_staf] CHECK  (([Email] like '_%@_%._%'))
GO
ALTER TABLE [dbo].[tbl_Staf] CHECK CONSTRAINT [CK_email_staf]
GO
ALTER TABLE [dbo].[tbl_Staf]  WITH CHECK ADD  CONSTRAINT [CK_jeniskelamin_staf] CHECK  (([jenis_kelamin]='Perempuan' OR [jenis_kelamin]='Laki-laki'))
GO
ALTER TABLE [dbo].[tbl_Staf] CHECK CONSTRAINT [CK_jeniskelamin_staf]
GO
ALTER TABLE [dbo].[tbl_Staf]  WITH CHECK ADD  CONSTRAINT [CK_nip_staf] CHECK  (([nip] like replicate('%[0-9]%',len([nip]))))
GO
ALTER TABLE [dbo].[tbl_Staf] CHECK CONSTRAINT [CK_nip_staf]
GO
ALTER TABLE [dbo].[tbl_Staf]  WITH NOCHECK ADD  CONSTRAINT [CK_password_staf] CHECK NOT FOR REPLICATION ((len([password])>(4)))
GO
ALTER TABLE [dbo].[tbl_Staf] CHECK CONSTRAINT [CK_password_staf]
GO
USE [master]
GO
ALTER DATABASE [NusantaraSMKDB] SET  READ_WRITE 
GO

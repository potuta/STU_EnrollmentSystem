USE [master]
GO
/****** Object:  Database [STU_DB]    Script Date: 15/10/2024 9:36:29 pm ******/
CREATE DATABASE [STU_DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'STU_DB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\STU_DB.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'STU_DB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\STU_DB_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [STU_DB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [STU_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [STU_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [STU_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [STU_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [STU_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [STU_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [STU_DB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [STU_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [STU_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [STU_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [STU_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [STU_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [STU_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [STU_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [STU_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [STU_DB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [STU_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [STU_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [STU_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [STU_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [STU_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [STU_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [STU_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [STU_DB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [STU_DB] SET  MULTI_USER 
GO
ALTER DATABASE [STU_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [STU_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [STU_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [STU_DB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [STU_DB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [STU_DB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [STU_DB] SET QUERY_STORE = ON
GO
ALTER DATABASE [STU_DB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [STU_DB]
GO
/****** Object:  User [STU_EnrollmentSystem]    Script Date: 15/10/2024 9:36:29 pm ******/
CREATE USER [STU_EnrollmentSystem] FOR LOGIN [STU_DB_Login] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [STU_EnrollmentSystem]
GO
/****** Object:  Table [dbo].[GradeLevel]    Script Date: 15/10/2024 9:36:29 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GradeLevel](
	[GradeLevel] [varchar](50) NOT NULL,
	[GradeCode] [varchar](20) NOT NULL,
	[SubjectGradeCode] [varchar](20) NOT NULL,
 CONSTRAINT [PK__GradeLev__B1E0A18730A93550] PRIMARY KEY CLUSTERED 
(
	[GradeCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PendingStudents]    Script Date: 15/10/2024 9:36:29 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PendingStudents](
	[RegisterID] [int] NOT NULL,
	[StudentNumber] [varchar](30) NULL,
	[StudFirstName] [varchar](20) NOT NULL,
	[StudMidName] [varchar](20) NOT NULL,
	[StudLastName] [varchar](20) NOT NULL,
	[Gender] [varchar](20) NOT NULL,
	[BirthDate] [varchar](20) NOT NULL,
	[CivilStatus] [varchar](20) NOT NULL,
	[Address] [varchar](20) NOT NULL,
	[ContactNum] [int] NOT NULL,
	[EnrollmentStatus] [varchar](20) NOT NULL,
	[EnrollmentType] [varchar](20) NOT NULL,
	[PaymentType] [varchar](20) NOT NULL,
	[PaymentMethod] [varchar](20) NULL,
	[ProofOfPayment] [varbinary](max) NULL,
	[MotherFirstName] [varchar](20) NOT NULL,
	[MotherLastName] [varchar](20) NOT NULL,
	[MotherOccupation] [varchar](30) NOT NULL,
	[FatherFirstName] [varchar](30) NOT NULL,
	[FatherLastName] [varchar](30) NOT NULL,
	[FatherOccupation] [varchar](30) NOT NULL,
	[StudForm137] [varbinary](max) NULL,
	[LRN] [int] NULL,
	[BirthCertificate] [varbinary](max) NULL,
	[GoodMoral] [varbinary](max) NULL,
	[TransferCertificate] [varbinary](max) NULL,
	[Section] [varchar](20) NULL,
 CONSTRAINT [PK_PendingStudents] PRIMARY KEY CLUSTERED 
(
	[RegisterID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prices]    Script Date: 15/10/2024 9:36:29 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prices](
	[PriceCode] [varchar](20) NOT NULL,
	[GradeCode] [varchar](20) NULL,
	[TuitionFee] [decimal](18, 0) NULL,
	[Books] [decimal](18, 0) NULL,
	[LaboratoryFee] [decimal](18, 0) NULL,
	[Uniform] [decimal](18, 0) NULL,
	[MiscellanaousFee] [decimal](18, 0) NULL,
	[TotalAmount] [decimal](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[PriceCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Registration]    Script Date: 15/10/2024 9:36:29 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registration](
	[RegisterID] [int] NOT NULL,
	[EnrollmentStatus] [varchar](20) NOT NULL,
	[StudFirstName] [varchar](20) NOT NULL,
	[StudMidName] [varchar](20) NOT NULL,
	[StudLastName] [varchar](20) NOT NULL,
	[Gender] [varchar](20) NOT NULL,
	[BirthDate] [varchar](20) NOT NULL,
	[CivilStatus] [varchar](20) NOT NULL,
	[Address] [varchar](20) NOT NULL,
	[ContactNum] [int] NOT NULL,
	[EnrollmentType] [varchar](20) NOT NULL,
	[PaymentType] [varchar](20) NOT NULL,
	[MotherFirstName] [varchar](20) NOT NULL,
	[MotherLastName] [varchar](20) NOT NULL,
	[MotherOccupation] [varchar](30) NOT NULL,
	[FatherFirstName] [varchar](30) NOT NULL,
	[FatherLastName] [varchar](30) NOT NULL,
	[FatherOccupation] [varchar](30) NOT NULL,
	[StudForm137] [varbinary](max) NULL,
	[LRN] [int] NULL,
	[BirthCertificate] [varbinary](max) NULL,
	[GoodMoral] [varbinary](max) NULL,
	[TransferCertificate] [varbinary](max) NULL,
 CONSTRAINT [PK_Registration] PRIMARY KEY CLUSTERED 
(
	[RegisterID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 15/10/2024 9:36:29 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[RoleID] [varchar](20) NOT NULL,
	[RoleName] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Schedule]    Script Date: 15/10/2024 9:36:29 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Schedule](
	[ScheduleCode] [varchar](30) NOT NULL,
	[SectionCode] [varchar](20) NULL,
	[SubjectCode] [varchar](20) NULL,
	[StartTime] [varchar](20) NULL,
	[EndTime] [varchar](20) NULL,
	[Days] [varchar](20) NULL,
	[TeacherCode] [varchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sections]    Script Date: 15/10/2024 9:36:29 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sections](
	[SectionTitle] [varchar](50) NULL,
	[SectionCode] [varchar](20) NOT NULL,
	[Room] [varchar](20) NULL,
	[TeacherCode] [varchar](20) NULL,
	[GradeCode] [varchar](20) NULL,
	[ScheduleCode] [varchar](30) NULL,
	[Capacity] [int] NULL,
	[StudCount] [int] NULL,
 CONSTRAINT [PK_Sections] PRIMARY KEY CLUSTERED 
(
	[SectionCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentPayment]    Script Date: 15/10/2024 9:36:29 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentPayment](
	[PaymentCode] [varchar](20) NULL,
	[PaymentMethod] [varchar](20) NULL,
	[StudentNumber] [varchar](30) NULL,
	[MonthOfPayment] [varchar](20) NULL,
	[PaymentStatus] [varchar](20) NULL,
	[ProofOfPayment] [varbinary](max) NULL,
	[PaymentReceipt] [varbinary](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 15/10/2024 9:36:29 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[RegisterID] [int] NOT NULL,
	[StudentNumber] [varchar](30) NOT NULL,
	[StudFirstName] [varchar](20) NOT NULL,
	[StudMidName] [varchar](20) NOT NULL,
	[StudLastName] [varchar](20) NOT NULL,
	[Gender] [varchar](20) NOT NULL,
	[BirthDate] [varchar](20) NOT NULL,
	[CivilStatus] [varchar](20) NOT NULL,
	[Address] [varchar](20) NOT NULL,
	[ContactNum] [int] NOT NULL,
	[EnrollmentStatus] [varchar](20) NOT NULL,
	[EnrollmentType] [varchar](20) NOT NULL,
	[PaymentType] [varchar](20) NOT NULL,
	[MotherFirstName] [varchar](20) NOT NULL,
	[MotherLastName] [varchar](20) NOT NULL,
	[MotherOccupation] [varchar](30) NOT NULL,
	[FatherFirstName] [varchar](30) NOT NULL,
	[FatherLastName] [varchar](30) NOT NULL,
	[FatherOccupation] [varchar](30) NOT NULL,
	[StudForm137] [varbinary](max) NULL,
	[LRN] [int] NULL,
	[BirthCertificate] [varbinary](max) NULL,
	[GoodMoral] [varbinary](max) NULL,
	[TransferCertificate] [varbinary](max) NULL,
	[Section] [varchar](20) NULL,
 CONSTRAINT [PK__Students__DD81BF6D31E6AD7B] PRIMARY KEY CLUSTERED 
(
	[StudentNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subjects]    Script Date: 15/10/2024 9:36:29 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subjects](
	[SubjectTitle] [varchar](30) NOT NULL,
	[SubjectCode] [varchar](20) NOT NULL,
	[SubjectGradeCode] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Subjects] PRIMARY KEY CLUSTERED 
(
	[SubjectCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teachers]    Script Date: 15/10/2024 9:36:29 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teachers](
	[TeacherName] [varchar](50) NULL,
	[TeacherCode] [varchar](20) NOT NULL,
	[SectionCode] [varchar](20) NULL,
	[SubjectCode] [varchar](20) NULL,
 CONSTRAINT [PK_Teachers] PRIMARY KEY CLUSTERED 
(
	[TeacherCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 15/10/2024 9:36:29 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [varchar](20) NOT NULL,
	[Username] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[RoleID] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[GradeLevel] ([GradeLevel], [GradeCode], [SubjectGradeCode]) VALUES (N'Grade 10', N'G10', N'SubjG10')
INSERT [dbo].[GradeLevel] ([GradeLevel], [GradeCode], [SubjectGradeCode]) VALUES (N'Grade 7', N'G7', N'SubjG7')
INSERT [dbo].[GradeLevel] ([GradeLevel], [GradeCode], [SubjectGradeCode]) VALUES (N'Grade 8', N'G8', N'SubjG8')
INSERT [dbo].[GradeLevel] ([GradeLevel], [GradeCode], [SubjectGradeCode]) VALUES (N'Grade 9 ', N'G9', N'SubjG9')
GO
INSERT [dbo].[Prices] ([PriceCode], [GradeCode], [TuitionFee], [Books], [LaboratoryFee], [Uniform], [MiscellanaousFee], [TotalAmount]) VALUES (N'PG10', N'G10', CAST(30000 AS Decimal(18, 0)), CAST(10000 AS Decimal(18, 0)), CAST(5000 AS Decimal(18, 0)), CAST(5000 AS Decimal(18, 0)), CAST(7000 AS Decimal(18, 0)), CAST(57000 AS Decimal(18, 0)))
INSERT [dbo].[Prices] ([PriceCode], [GradeCode], [TuitionFee], [Books], [LaboratoryFee], [Uniform], [MiscellanaousFee], [TotalAmount]) VALUES (N'PG7', N'G7', CAST(30000 AS Decimal(18, 0)), CAST(10000 AS Decimal(18, 0)), CAST(5000 AS Decimal(18, 0)), CAST(5000 AS Decimal(18, 0)), CAST(7000 AS Decimal(18, 0)), CAST(57000 AS Decimal(18, 0)))
INSERT [dbo].[Prices] ([PriceCode], [GradeCode], [TuitionFee], [Books], [LaboratoryFee], [Uniform], [MiscellanaousFee], [TotalAmount]) VALUES (N'PG8', N'G8', CAST(30000 AS Decimal(18, 0)), CAST(10000 AS Decimal(18, 0)), CAST(5000 AS Decimal(18, 0)), CAST(5000 AS Decimal(18, 0)), CAST(7000 AS Decimal(18, 0)), CAST(57000 AS Decimal(18, 0)))
INSERT [dbo].[Prices] ([PriceCode], [GradeCode], [TuitionFee], [Books], [LaboratoryFee], [Uniform], [MiscellanaousFee], [TotalAmount]) VALUES (N'PG9', N'G9', CAST(30000 AS Decimal(18, 0)), CAST(10000 AS Decimal(18, 0)), CAST(5000 AS Decimal(18, 0)), CAST(5000 AS Decimal(18, 0)), CAST(7000 AS Decimal(18, 0)), CAST(57000 AS Decimal(18, 0)))
GO
INSERT [dbo].[Roles] ([RoleID], [RoleName]) VALUES (N'A', N'Admission')
INSERT [dbo].[Roles] ([RoleID], [RoleName]) VALUES (N'Admin', N'Administrator')
INSERT [dbo].[Roles] ([RoleID], [RoleName]) VALUES (N'C', N'Cashier')
INSERT [dbo].[Roles] ([RoleID], [RoleName]) VALUES (N'R', N'Registrar')
GO
INSERT [dbo].[Schedule] ([ScheduleCode], [SectionCode], [SubjectCode], [StartTime], [EndTime], [Days], [TeacherCode]) VALUES (N'SchedG7_01', N'SecG7_01', N'Eng7', N'7:00AM', N'9:00AM', N'MWF', N'T0001')
INSERT [dbo].[Schedule] ([ScheduleCode], [SectionCode], [SubjectCode], [StartTime], [EndTime], [Days], [TeacherCode]) VALUES (N'SchedG7_01', N'SecG7_01', N'Fil7', N'9:00AM', N'11:00AM', N'MWF', N'T0003')
INSERT [dbo].[Schedule] ([ScheduleCode], [SectionCode], [SubjectCode], [StartTime], [EndTime], [Days], [TeacherCode]) VALUES (N'SchedG7_01', N'SecG7_01', N'AP7', N'12:00PM', N'2:00PM', N'MWF', N'T0005')
INSERT [dbo].[Schedule] ([ScheduleCode], [SectionCode], [SubjectCode], [StartTime], [EndTime], [Days], [TeacherCode]) VALUES (N'SchedG7_01', N'SecG7_01', N'Mat7', N'7:00AM', N'9:00AM', N'TTH', N'T0002')
INSERT [dbo].[Schedule] ([ScheduleCode], [SectionCode], [SubjectCode], [StartTime], [EndTime], [Days], [TeacherCode]) VALUES (N'SchedG7_01', N'SecG7_01', N'Sci7', N'9:00AM', N'11:00AM', N'TTH', N'T0004')
INSERT [dbo].[Schedule] ([ScheduleCode], [SectionCode], [SubjectCode], [StartTime], [EndTime], [Days], [TeacherCode]) VALUES (N'SchedG7_01', N'SecG7_01', N'MP7', N'12:00PM', N'2:00PM', N'TTH', N'T0006')
INSERT [dbo].[Schedule] ([ScheduleCode], [SectionCode], [SubjectCode], [StartTime], [EndTime], [Days], [TeacherCode]) VALUES (N'SchedG7_02', N'SecG7_02', N'AP7', N'7:00AM', N'9:00AM', N'MWF', N'T0005')
INSERT [dbo].[Schedule] ([ScheduleCode], [SectionCode], [SubjectCode], [StartTime], [EndTime], [Days], [TeacherCode]) VALUES (N'SchedG7_02', N'SecG7_02', N'Eng7', N'9:00AM', N'11:00AM', N'MWF', N'T0001')
INSERT [dbo].[Schedule] ([ScheduleCode], [SectionCode], [SubjectCode], [StartTime], [EndTime], [Days], [TeacherCode]) VALUES (N'SchedG7_02', N'SecG7_02', N'Fil7', N'12:00PM', N'2:00PM', N'MWF', N'T0003')
INSERT [dbo].[Schedule] ([ScheduleCode], [SectionCode], [SubjectCode], [StartTime], [EndTime], [Days], [TeacherCode]) VALUES (N'SchedG7_02', N'SecG7_02', N'MP7', N'7:00AM', N'9:00AM', N'TTH', N'T0006')
INSERT [dbo].[Schedule] ([ScheduleCode], [SectionCode], [SubjectCode], [StartTime], [EndTime], [Days], [TeacherCode]) VALUES (N'SchedG7_02', N'SecG7_02', N'Mat7', N'9:00AM', N'11:00AM', N'TTH', N'T0002')
INSERT [dbo].[Schedule] ([ScheduleCode], [SectionCode], [SubjectCode], [StartTime], [EndTime], [Days], [TeacherCode]) VALUES (N'SchedG7_02', N'SecG7_02', N'Sci7', N'12:00PM', N'2:00PM', N'TTH', N'T0004')
GO
INSERT [dbo].[Sections] ([SectionTitle], [SectionCode], [Room], [TeacherCode], [GradeCode], [ScheduleCode], [Capacity], [StudCount]) VALUES (N'Psalm 7', N'SecG7_01', N'Room 101', N'T0001', N'G7', N'SchedG7_01', 30, 0)
INSERT [dbo].[Sections] ([SectionTitle], [SectionCode], [Room], [TeacherCode], [GradeCode], [ScheduleCode], [Capacity], [StudCount]) VALUES (N'Genesis 7', N'SecG7_02', N'Room 102', N'T0002', N'G7', N'SchedG7_02', 30, 0)
GO
INSERT [dbo].[Subjects] ([SubjectTitle], [SubjectCode], [SubjectGradeCode]) VALUES (N'Araling Panlipunan 7', N'AP7', N'SubjG7')
INSERT [dbo].[Subjects] ([SubjectTitle], [SubjectCode], [SubjectGradeCode]) VALUES (N'English 7', N'Eng7', N'SubjG7')
INSERT [dbo].[Subjects] ([SubjectTitle], [SubjectCode], [SubjectGradeCode]) VALUES (N'Filipino 7 ', N'Fil7', N'SubjG7')
INSERT [dbo].[Subjects] ([SubjectTitle], [SubjectCode], [SubjectGradeCode]) VALUES (N'Math 7 ', N'Mat7', N'SubjG7')
INSERT [dbo].[Subjects] ([SubjectTitle], [SubjectCode], [SubjectGradeCode]) VALUES (N'MAPEH 7 ', N'MP7', N'SubjG7')
INSERT [dbo].[Subjects] ([SubjectTitle], [SubjectCode], [SubjectGradeCode]) VALUES (N'Science 7 ', N'Sci7', N'SubjG7')
GO
INSERT [dbo].[Teachers] ([TeacherName], [TeacherCode], [SectionCode], [SubjectCode]) VALUES (N'John Tamayo', N'T0001', N'SecG7_01', N'Eng7')
INSERT [dbo].[Teachers] ([TeacherName], [TeacherCode], [SectionCode], [SubjectCode]) VALUES (N'Anthony Flores', N'T0002', N'SecG7_02', N'Mat7')
INSERT [dbo].[Teachers] ([TeacherName], [TeacherCode], [SectionCode], [SubjectCode]) VALUES (N'Jose Dela Cruz', N'T0003', N'', N'Fil7')
INSERT [dbo].[Teachers] ([TeacherName], [TeacherCode], [SectionCode], [SubjectCode]) VALUES (N'Cesar Mendoza', N'T0004', N'', N'Sci7')
INSERT [dbo].[Teachers] ([TeacherName], [TeacherCode], [SectionCode], [SubjectCode]) VALUES (N'Shane Villanueva', N'T0005', N'', N'AP7')
INSERT [dbo].[Teachers] ([TeacherName], [TeacherCode], [SectionCode], [SubjectCode]) VALUES (N'Gabriel Aquino', N'T0006', N'', N'MP7')
INSERT [dbo].[Teachers] ([TeacherName], [TeacherCode], [SectionCode], [SubjectCode]) VALUES (N'Ann De Leon', N'T0007', N'', N'')
INSERT [dbo].[Teachers] ([TeacherName], [TeacherCode], [SectionCode], [SubjectCode]) VALUES (N'Rachel Manalo', N'T0008', N'', N'')
INSERT [dbo].[Teachers] ([TeacherName], [TeacherCode], [SectionCode], [SubjectCode]) VALUES (N'Noemi Cortez', N'T0009', N'', N'')
INSERT [dbo].[Teachers] ([TeacherName], [TeacherCode], [SectionCode], [SubjectCode]) VALUES (N'Jericho Pineda', N'T0010', N'', N'')
INSERT [dbo].[Teachers] ([TeacherName], [TeacherCode], [SectionCode], [SubjectCode]) VALUES (N'Dan Peralta', N'T0011', N'', N'')
INSERT [dbo].[Teachers] ([TeacherName], [TeacherCode], [SectionCode], [SubjectCode]) VALUES (N'Ara Roque', N'T0012', N'', N'')
GO
INSERT [dbo].[Users] ([UserID], [Username], [Password], [Email], [RoleID]) VALUES (N'U0001', N'Cyril', N'cyril123', N'cyrilbautista@gmail.com', N'Admin')
INSERT [dbo].[Users] ([UserID], [Username], [Password], [Email], [RoleID]) VALUES (N'U0002', N'Johnnywilly', N'6969jowow', N'johnwil69@gmail.com', N'A')
INSERT [dbo].[Users] ([UserID], [Username], [Password], [Email], [RoleID]) VALUES (N'U0003', N'Steph', N'stephanie456', N'stephaniereyes@gmail.com', N'C')
INSERT [dbo].[Users] ([UserID], [Username], [Password], [Email], [RoleID]) VALUES (N'U0004', N'Sheila', N'sheilamae', N'sheilamalolos@gmail.com', N'C')
INSERT [dbo].[Users] ([UserID], [Username], [Password], [Email], [RoleID]) VALUES (N'U0005', N'Eduard', N'eduard00', N'eduardwhaha@gmail.com', N'R')
GO
ALTER TABLE [dbo].[Schedule]  WITH CHECK ADD  CONSTRAINT [FK_Schedule_Sections] FOREIGN KEY([SectionCode])
REFERENCES [dbo].[Sections] ([SectionCode])
GO
ALTER TABLE [dbo].[Schedule] CHECK CONSTRAINT [FK_Schedule_Sections]
GO
ALTER TABLE [dbo].[Schedule]  WITH CHECK ADD  CONSTRAINT [FK_Schedule_Subjects] FOREIGN KEY([SubjectCode])
REFERENCES [dbo].[Subjects] ([SubjectCode])
GO
ALTER TABLE [dbo].[Schedule] CHECK CONSTRAINT [FK_Schedule_Subjects]
GO
ALTER TABLE [dbo].[Schedule]  WITH CHECK ADD  CONSTRAINT [FK_Schedule_Teachers] FOREIGN KEY([TeacherCode])
REFERENCES [dbo].[Teachers] ([TeacherCode])
GO
ALTER TABLE [dbo].[Schedule] CHECK CONSTRAINT [FK_Schedule_Teachers]
GO
ALTER TABLE [dbo].[Sections]  WITH CHECK ADD  CONSTRAINT [FK_Sections_GradeLevel] FOREIGN KEY([GradeCode])
REFERENCES [dbo].[GradeLevel] ([GradeCode])
GO
ALTER TABLE [dbo].[Sections] CHECK CONSTRAINT [FK_Sections_GradeLevel]
GO
ALTER TABLE [dbo].[Sections]  WITH CHECK ADD  CONSTRAINT [FK_Sections_Teachers] FOREIGN KEY([TeacherCode])
REFERENCES [dbo].[Teachers] ([TeacherCode])
GO
ALTER TABLE [dbo].[Sections] CHECK CONSTRAINT [FK_Sections_Teachers]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Roles] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Roles] ([RoleID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Roles]
GO
USE [master]
GO
ALTER DATABASE [STU_DB] SET  READ_WRITE 
GO

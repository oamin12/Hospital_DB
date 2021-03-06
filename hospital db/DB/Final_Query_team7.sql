USE [master]
GO
/****** Object:  Database [DB_Project_Hospital_DataBase1]    Script Date: 1/10/2022 5:43:39 AM ******/
CREATE DATABASE [DB_Project_Hospital_DataBase1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DB_Project_Hospital_DataBase1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DB_Project_Hospital_DataBase1.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DB_Project_Hospital_DataBase1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DB_Project_Hospital_DataBase1_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DB_Project_Hospital_DataBase1] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DB_Project_Hospital_DataBase1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DB_Project_Hospital_DataBase1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DB_Project_Hospital_DataBase1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DB_Project_Hospital_DataBase1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DB_Project_Hospital_DataBase1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DB_Project_Hospital_DataBase1] SET ARITHABORT OFF 
GO
ALTER DATABASE [DB_Project_Hospital_DataBase1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DB_Project_Hospital_DataBase1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DB_Project_Hospital_DataBase1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DB_Project_Hospital_DataBase1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DB_Project_Hospital_DataBase1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DB_Project_Hospital_DataBase1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DB_Project_Hospital_DataBase1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DB_Project_Hospital_DataBase1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DB_Project_Hospital_DataBase1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DB_Project_Hospital_DataBase1] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DB_Project_Hospital_DataBase1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DB_Project_Hospital_DataBase1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DB_Project_Hospital_DataBase1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DB_Project_Hospital_DataBase1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DB_Project_Hospital_DataBase1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DB_Project_Hospital_DataBase1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DB_Project_Hospital_DataBase1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DB_Project_Hospital_DataBase1] SET RECOVERY FULL 
GO
ALTER DATABASE [DB_Project_Hospital_DataBase1] SET  MULTI_USER 
GO
ALTER DATABASE [DB_Project_Hospital_DataBase1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DB_Project_Hospital_DataBase1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DB_Project_Hospital_DataBase1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DB_Project_Hospital_DataBase1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DB_Project_Hospital_DataBase1] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DB_Project_Hospital_DataBase1] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'DB_Project_Hospital_DataBase1', N'ON'
GO
ALTER DATABASE [DB_Project_Hospital_DataBase1] SET QUERY_STORE = OFF
GO
USE [DB_Project_Hospital_DataBase1]
GO
/****** Object:  Table [dbo].[Appointment]    Script Date: 1/10/2022 5:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointment](
	[PatientID] [int] NULL,
	[DrID] [int] NOT NULL,
	[Date_time] [datetime] NOT NULL,
	[Atype] [varchar](50) NULL,
	[Report] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[DrID] ASC,
	[Date_time] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Appointment_Requests]    Script Date: 1/10/2022 5:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointment_Requests](
	[AppointmentRequestID] [int] IDENTITY(1,1) NOT NULL,
	[Patient_ID] [int] NOT NULL,
	[Dr_ID] [int] NOT NULL,
	[Timee] [datetime] NOT NULL,
	[Appointment_Type] [varchar](50) NULL,
	[Accepted] [bit] NULL,
 CONSTRAINT [PK__Appointm__FF271AB9BCF67982] PRIMARY KEY CLUSTERED 
(
	[AppointmentRequestID] ASC,
	[Patient_ID] ASC,
	[Dr_ID] ASC,
	[Timee] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 1/10/2022 5:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[DepID] [int] IDENTITY(1,1) NOT NULL,
	[DepName] [varchar](50) NOT NULL,
	[DepHead] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[DepID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctors]    Script Date: 1/10/2022 5:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctors](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Salary] [int] NOT NULL,
	[DepID] [int] NOT NULL,
	[SuperID] [int] NULL,
	[PersonID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 1/10/2022 5:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PersonID] [int] NULL,
	[EmployeeTypeID] [int] NULL,
	[Salary] [int] NOT NULL,
	[DepartmentID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeType]    Script Date: 1/10/2022 5:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeType](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Tname] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GetsPaid]    Script Date: 1/10/2022 5:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GetsPaid](
	[PersonID] [int] NULL,
	[TransactionID] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Has_a_scan]    Script Date: 1/10/2022 5:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Has_a_scan](
	[PatientID] [int] NULL,
	[Date_time] [datetime] NULL,
	[ScanID] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nurse]    Script Date: 1/10/2022 5:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nurse](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[salary] [int] NOT NULL,
	[PersonID] [int] NOT NULL,
	[SuperID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nurses_Operations]    Script Date: 1/10/2022 5:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nurses_Operations](
	[NurseID] [int] NOT NULL,
	[OperationID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[NurseID] ASC,
	[OperationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OperationRoom]    Script Date: 1/10/2022 5:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OperationRoom](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[RoomNumber] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[operations]    Script Date: 1/10/2022 5:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[operations](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[OLocation] [int] NOT NULL,
	[startTime] [datetime] NOT NULL,
	[endTime] [datetime] NOT NULL,
	[PatientID] [int] NOT NULL,
	[OTypeID] [int] NOT NULL,
	[DoctorID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Operations_Requests]    Script Date: 1/10/2022 5:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Operations_Requests](
	[Operation_ID] [int] IDENTITY(1,1) NOT NULL,
	[Operation_Location] [int] NULL,
	[Starts] [datetime] NULL,
	[Ends] [datetime] NULL,
	[Patient_ID] [int] NOT NULL,
	[Operation_Type] [int] NOT NULL,
	[Doctor_ID] [int] NOT NULL,
	[Accepted] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Operation_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OperationType]    Script Date: 1/10/2022 5:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OperationType](
	[Oname] [varchar](60) NOT NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patient]    Script Date: 1/10/2022 5:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PersonID] [int] NOT NULL,
	[BloodType] [char](4) NULL,
	[ResDrID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patient_allergies]    Script Date: 1/10/2022 5:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient_allergies](
	[patientID] [int] NOT NULL,
	[allergies] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[patientID] ASC,
	[allergies] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patient_Diseases]    Script Date: 1/10/2022 5:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient_Diseases](
	[patientID] [int] NOT NULL,
	[Diseases] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[patientID] ASC,
	[Diseases] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 1/10/2022 5:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FName] [varchar](50) NOT NULL,
	[LName] [varchar](50) NOT NULL,
	[BoD] [date] NULL,
	[gender] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Room]    Script Date: 1/10/2022 5:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ResposibleNurseID] [int] NULL,
	[PatientID] [int] NULL,
	[Notes] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Room_Requests]    Script Date: 1/10/2022 5:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room_Requests](
	[RoomRequestID] [int] IDENTITY(1,1) NOT NULL,
	[Room_ID] [int] NOT NULL,
	[Nurse_ID] [int] NULL,
	[Patient_ID] [int] NULL,
	[Accepted] [bit] NULL,
 CONSTRAINT [PK_Room_Requests] PRIMARY KEY CLUSTERED 
(
	[RoomRequestID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Scan_Requests]    Script Date: 1/10/2022 5:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Scan_Requests](
	[ScanRequestID] [int] IDENTITY(1,1) NOT NULL,
	[Patient_ID] [int] NULL,
	[Datee] [datetime] NULL,
	[Scan_ID] [int] NULL,
	[Accepted] [bit] NULL,
 CONSTRAINT [PK_Scan_Requests] PRIMARY KEY CLUSTERED 
(
	[ScanRequestID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ScanLab]    Script Date: 1/10/2022 5:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ScanLab](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SType] [varchar](50) NOT NULL,
	[Price] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[transactions]    Script Date: 1/10/2022 5:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[transactions](
	[Ttype] [varchar](50) NULL,
	[Payment] [int] NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[requestID] [int] NULL,
 CONSTRAINT [PK__transact__3214EC273BFF8AD2] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 1/10/2022 5:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[passwords] [char](60) NOT NULL,
	[PersonID] [int] NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[UserTypeID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PersonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usertype]    Script Date: 1/10/2022 5:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usertype](
	[Tname] [varchar](50) NOT NULL,
	[ID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Appointment] ADD  DEFAULT ((-1)) FOR [DrID]
GO
ALTER TABLE [dbo].[Appointment_Requests] ADD  CONSTRAINT [DF__Appointme__Dr_ID__73BA3083]  DEFAULT ((-1)) FOR [Dr_ID]
GO
ALTER TABLE [dbo].[Appointment_Requests] ADD  CONSTRAINT [DF__Appointme__Accep__74AE54BC]  DEFAULT ((0)) FOR [Accepted]
GO
ALTER TABLE [dbo].[Doctors] ADD  DEFAULT ((-1)) FOR [DepID]
GO
ALTER TABLE [dbo].[Employee] ADD  DEFAULT ((-1)) FOR [DepartmentID]
GO
ALTER TABLE [dbo].[Nurses_Operations] ADD  DEFAULT ((-1)) FOR [NurseID]
GO
ALTER TABLE [dbo].[Nurses_Operations] ADD  DEFAULT ((-1)) FOR [OperationID]
GO
ALTER TABLE [dbo].[operations] ADD  DEFAULT ((-1)) FOR [OLocation]
GO
ALTER TABLE [dbo].[Operations_Requests] ADD  CONSTRAINT [DF__Operation__Opera__797309D9]  DEFAULT (NULL) FOR [Operation_Location]
GO
ALTER TABLE [dbo].[Operations_Requests] ADD  DEFAULT ((0)) FOR [Accepted]
GO
ALTER TABLE [dbo].[Room_Requests] ADD  CONSTRAINT [DF__Room_Requ__Accep__6B24EA82]  DEFAULT ((0)) FOR [Accepted]
GO
ALTER TABLE [dbo].[Scan_Requests] ADD  CONSTRAINT [DF__Scan_Requ__Accep__6EF57B66]  DEFAULT ((0)) FOR [Accepted]
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD FOREIGN KEY([PatientID])
REFERENCES [dbo].[Patient] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD FOREIGN KEY([DrID])
REFERENCES [dbo].[Doctors] ([ID])
GO
ALTER TABLE [dbo].[Appointment_Requests]  WITH CHECK ADD  CONSTRAINT [FK__Appointme__Dr_ID__76969D2E] FOREIGN KEY([Dr_ID])
REFERENCES [dbo].[Doctors] ([ID])
GO
ALTER TABLE [dbo].[Appointment_Requests] CHECK CONSTRAINT [FK__Appointme__Dr_ID__76969D2E]
GO
ALTER TABLE [dbo].[Appointment_Requests]  WITH CHECK ADD  CONSTRAINT [FK__Appointme__Patie__75A278F5] FOREIGN KEY([Patient_ID])
REFERENCES [dbo].[Patient] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Appointment_Requests] CHECK CONSTRAINT [FK__Appointme__Patie__75A278F5]
GO
ALTER TABLE [dbo].[Department]  WITH CHECK ADD FOREIGN KEY([DepHead])
REFERENCES [dbo].[Doctors] ([ID])
GO
ALTER TABLE [dbo].[Doctors]  WITH CHECK ADD FOREIGN KEY([DepID])
REFERENCES [dbo].[Department] ([DepID])
ON UPDATE CASCADE
ON DELETE SET DEFAULT
GO
ALTER TABLE [dbo].[Doctors]  WITH CHECK ADD FOREIGN KEY([PersonID])
REFERENCES [dbo].[Person] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Doctors]  WITH CHECK ADD FOREIGN KEY([SuperID])
REFERENCES [dbo].[Doctors] ([ID])
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD FOREIGN KEY([DepartmentID])
REFERENCES [dbo].[Department] ([DepID])
ON UPDATE CASCADE
ON DELETE SET DEFAULT
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD FOREIGN KEY([EmployeeTypeID])
REFERENCES [dbo].[EmployeeType] ([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD FOREIGN KEY([PersonID])
REFERENCES [dbo].[Person] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[GetsPaid]  WITH CHECK ADD FOREIGN KEY([PersonID])
REFERENCES [dbo].[Person] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Has_a_scan]  WITH CHECK ADD FOREIGN KEY([PatientID])
REFERENCES [dbo].[Patient] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Has_a_scan]  WITH CHECK ADD FOREIGN KEY([ScanID])
REFERENCES [dbo].[ScanLab] ([ID])
GO
ALTER TABLE [dbo].[Nurse]  WITH CHECK ADD FOREIGN KEY([PersonID])
REFERENCES [dbo].[Person] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Nurse]  WITH CHECK ADD FOREIGN KEY([SuperID])
REFERENCES [dbo].[Nurse] ([ID])
GO
ALTER TABLE [dbo].[Nurses_Operations]  WITH CHECK ADD FOREIGN KEY([NurseID])
REFERENCES [dbo].[Nurse] ([ID])
ON UPDATE SET DEFAULT
ON DELETE SET DEFAULT
GO
ALTER TABLE [dbo].[Nurses_Operations]  WITH CHECK ADD FOREIGN KEY([OperationID])
REFERENCES [dbo].[operations] ([ID])
GO
ALTER TABLE [dbo].[operations]  WITH CHECK ADD FOREIGN KEY([DoctorID])
REFERENCES [dbo].[Doctors] ([ID])
GO
ALTER TABLE [dbo].[operations]  WITH CHECK ADD FOREIGN KEY([OLocation])
REFERENCES [dbo].[OperationRoom] ([ID])
ON UPDATE CASCADE
ON DELETE SET DEFAULT
GO
ALTER TABLE [dbo].[operations]  WITH CHECK ADD FOREIGN KEY([OTypeID])
REFERENCES [dbo].[OperationType] ([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[operations]  WITH CHECK ADD FOREIGN KEY([PatientID])
REFERENCES [dbo].[Patient] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Operations_Requests]  WITH CHECK ADD FOREIGN KEY([Doctor_ID])
REFERENCES [dbo].[Doctors] ([ID])
GO
ALTER TABLE [dbo].[Operations_Requests]  WITH CHECK ADD FOREIGN KEY([Operation_Type])
REFERENCES [dbo].[OperationType] ([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Operations_Requests]  WITH CHECK ADD FOREIGN KEY([Operation_Location])
REFERENCES [dbo].[OperationRoom] ([ID])
ON UPDATE CASCADE
ON DELETE SET DEFAULT
GO
ALTER TABLE [dbo].[Operations_Requests]  WITH CHECK ADD FOREIGN KEY([Patient_ID])
REFERENCES [dbo].[Patient] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Patient]  WITH CHECK ADD FOREIGN KEY([PersonID])
REFERENCES [dbo].[Person] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Patient]  WITH CHECK ADD FOREIGN KEY([ResDrID])
REFERENCES [dbo].[Doctors] ([ID])
GO
ALTER TABLE [dbo].[Patient_allergies]  WITH CHECK ADD FOREIGN KEY([patientID])
REFERENCES [dbo].[Patient] ([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Patient_Diseases]  WITH CHECK ADD FOREIGN KEY([patientID])
REFERENCES [dbo].[Patient] ([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Room]  WITH CHECK ADD FOREIGN KEY([PatientID])
REFERENCES [dbo].[Patient] ([ID])
GO
ALTER TABLE [dbo].[Room]  WITH CHECK ADD FOREIGN KEY([ResposibleNurseID])
REFERENCES [dbo].[Nurse] ([ID])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Room_Requests]  WITH CHECK ADD  CONSTRAINT [FK__Room_Requ__Nurse__6C190EBB] FOREIGN KEY([Nurse_ID])
REFERENCES [dbo].[Nurse] ([ID])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Room_Requests] CHECK CONSTRAINT [FK__Room_Requ__Nurse__6C190EBB]
GO
ALTER TABLE [dbo].[Room_Requests]  WITH CHECK ADD  CONSTRAINT [FK__Room_Requ__Patie__6D0D32F4] FOREIGN KEY([Patient_ID])
REFERENCES [dbo].[Patient] ([ID])
GO
ALTER TABLE [dbo].[Room_Requests] CHECK CONSTRAINT [FK__Room_Requ__Patie__6D0D32F4]
GO
ALTER TABLE [dbo].[Scan_Requests]  WITH CHECK ADD  CONSTRAINT [FK__Scan_Requ__Patie__6FE99F9F] FOREIGN KEY([Patient_ID])
REFERENCES [dbo].[Patient] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Scan_Requests] CHECK CONSTRAINT [FK__Scan_Requ__Patie__6FE99F9F]
GO
ALTER TABLE [dbo].[Scan_Requests]  WITH CHECK ADD  CONSTRAINT [FK__Scan_Requ__Scan___70DDC3D8] FOREIGN KEY([Scan_ID])
REFERENCES [dbo].[ScanLab] ([ID])
GO
ALTER TABLE [dbo].[Scan_Requests] CHECK CONSTRAINT [FK__Scan_Requ__Scan___70DDC3D8]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD FOREIGN KEY([PersonID])
REFERENCES [dbo].[Person] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD FOREIGN KEY([UserTypeID])
REFERENCES [dbo].[Usertype] ([ID])
ON UPDATE CASCADE
GO
/****** Object:  StoredProcedure [dbo].[cancelappointment]    Script Date: 1/10/2022 5:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[cancelappointment]
	@appdate datetime,
	@docid int
AS
BEGIN
Delete from  Appointment
where  Date_time = @appdate and DrID = @docid
END


GO
/****** Object:  StoredProcedure [dbo].[checkappointmentandDr]    Script Date: 1/10/2022 5:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[checkappointmentandDr]
	@appdate datetime,
	@docid int
AS
BEGIN
SELECT  *
From Appointment
where DrID = @docid and Date_time = @appdate
END


GO
/****** Object:  StoredProcedure [dbo].[getAppointments]    Script Date: 1/10/2022 5:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[getAppointments]
	@startdate datetime,
	@finaldate datetime,
	@docid int
AS
BEGIN
SELECT  app.Date_time  , pat.ID ,  p.FName , p.LName , app.Atype
From Appointment as app , Person as p , Patient as pat
where app.DrID = @docid and app.PatientID = pat.ID and pat.PersonID = p.ID 
and app.Date_time > @startdate and app.Date_time < @finaldate
Order by app.Date_time
END


GO
/****** Object:  StoredProcedure [dbo].[getDrPatients]    Script Date: 1/10/2022 5:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[getDrPatients]
	@Docid int
AS
BEGIN
SELECT Distinct FName
From Person as p , Patient as pat
where pat.PersonID = p.ID AND pat.ResDrID = @Docid
UNION
select Distinct LName
from Person as p , Patient as pat 
where pat.PersonID = p.ID AND pat.ResDrID = @Docid
END


GO
/****** Object:  StoredProcedure [dbo].[requestsurgery]    Script Date: 1/10/2022 5:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[requestsurgery]
	@patid int,
	@docid int,
	@opid int
AS
BEGIN
INSERT INTO Operations_Requests (Doctor_ID ,Patient_ID , Operation_Type  )
Values (@docid , @patid , @opid);
END
GO
/****** Object:  StoredProcedure [dbo].[updateappointment]    Script Date: 1/10/2022 5:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[updateappointment]
	@newdate datetime,
	@olddate datetime,
	@docid int
AS
BEGIN
UPDATE  Appointment
SET Date_time = @newdate
where  Date_time = @olddate and DrID = @docid
END


GO
USE [master]
GO
ALTER DATABASE [DB_Project_Hospital_DataBase1] SET  READ_WRITE 
GO

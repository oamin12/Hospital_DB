USE [master]
GO

/****** Object:  Database [DB_Project_Hospital_DataBase1]    Script Date: 1/10/2022 5:26:34 AM ******/
CREATE DATABASE [DB_Project_Hospital_DataBase1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DB_Project_Hospital_DataBase1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DB_Project_Hospital_DataBase1.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DB_Project_Hospital_DataBase1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DB_Project_Hospital_DataBase1_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
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

ALTER DATABASE [DB_Project_Hospital_DataBase1] SET QUERY_STORE = OFF
GO

ALTER DATABASE [DB_Project_Hospital_DataBase1] SET  READ_WRITE 
GO


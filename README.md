# APPServiceWithJWT Create SQL

/*you can https://learn.microsoft.com/en-us/ef/core/cli/powershell codeFirst methood https://www.entityframeworktutorial.net/efcore/pmc-commands-for-ef-core-migration.aspx or */

USE [master]
GO

/****** Object:  Database [JWTServis]    Script Date: 4.06.2023 10:31:09 ******/
CREATE DATABASE [JWTServis]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'JWTAuthentication', FILENAME = N'P:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\JWTAuthentication.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'JWTAuthentication_log', FILENAME = N'P:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\JWTAuthentication_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [JWTServis].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [JWTServis] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [JWTServis] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [JWTServis] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [JWTServis] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [JWTServis] SET ARITHABORT OFF 
GO

ALTER DATABASE [JWTServis] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [JWTServis] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [JWTServis] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [JWTServis] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [JWTServis] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [JWTServis] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [JWTServis] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [JWTServis] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [JWTServis] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [JWTServis] SET  DISABLE_BROKER 
GO

ALTER DATABASE [JWTServis] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [JWTServis] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [JWTServis] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [JWTServis] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [JWTServis] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [JWTServis] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [JWTServis] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [JWTServis] SET RECOVERY FULL 
GO

ALTER DATABASE [JWTServis] SET  MULTI_USER 
GO

ALTER DATABASE [JWTServis] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [JWTServis] SET DB_CHAINING OFF 
GO

ALTER DATABASE [JWTServis] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [JWTServis] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [JWTServis] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [JWTServis] SET QUERY_STORE = OFF
GO

ALTER DATABASE [JWTServis] SET  READ_WRITE 
GO



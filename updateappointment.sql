USE [DB_Project_Hospital_DataBase1]
GO
/****** Object:  StoredProcedure [dbo].[checkappointmentandDr]    Script Date: 1/10/2022 12:10:35 AM ******/
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



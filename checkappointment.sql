USE [DB_Project_Hospital_DataBase1]
GO
/****** Object:  StoredProcedure [dbo].[getAppointments]    Script Date: 1/10/2022 12:03:41 AM ******/
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



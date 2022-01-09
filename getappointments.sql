USE [DB_Project_Hospital_DataBase]
GO
/****** Object:  StoredProcedure [dbo].[getAppointments]    Script Date: 1/9/2022 11:40:22 PM ******/
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
and app.Date_time >= @startdate and app.Date_time <= @finaldate
Order by app.Date_time
END

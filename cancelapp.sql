USE [DB_Project_Hospital_DataBase1]
GO
/****** Object:  StoredProcedure [dbo].[updateappointment]    Script Date: 1/10/2022 12:32:39 AM ******/
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



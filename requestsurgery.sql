USE [DB_Project_Hospital_DataBase1]
GO
/****** Object:  StoredProcedure [dbo].[cancelappointment]    Script Date: 1/10/2022 3:10:09 AM ******/
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



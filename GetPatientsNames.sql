USE [DB_Project_Hospital_DataBase]
GO
/****** Object:  StoredProcedure [dbo].[getDrPatients]    Script Date: 1/9/2022 8:55:14 PM ******/
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



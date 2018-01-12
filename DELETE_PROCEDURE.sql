USE Cabinet_Medical
GO 

CREATE PROCEDURE dbo.DeletePatient @Name nvarchar(30)
AS
DELETE FROM dbo.Patients
WHERE Patients.Nume= @Name
GO
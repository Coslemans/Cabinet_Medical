USE Cabinet_Medical
GO 

CREATE PROCEDURE dbo.SetData @Name  nvarchar(30), @tip int 
AS
UPDATE R
SET Accepted=@tip
FROM dbo.Appointments AS R
INNER JOIN dbo.Patients AS P
ON R.ID_Pacient = P.ID
WHERE P.Nume=@Name

GO
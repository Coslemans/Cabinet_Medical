USE [Cabinet_Medical]
GO

CREATE VIEW dbo.HistView
AS
SELECT        dbo.Employees.Nume, dbo.Employees.Specializare, dbo.Diseases.Denumire, dbo.History_Patients.Data, dbo.Patients.ID
FROM            dbo.Patients INNER JOIN
                         dbo.History_Patients ON dbo.Patients.ID = dbo.History_Patients.ID_Pacient INNER JOIN
                         dbo.Employees ON dbo.History_Patients.ID_Medic = dbo.Employees.ID INNER JOIN
                         dbo.Diseases ON dbo.History_Patients.ID_Afectiune = dbo.Diseases.ID

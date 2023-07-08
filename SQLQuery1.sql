Delete from Stud_detail

DBCC CHECKIDENT ('Stud_detail', RESEED, 5)
GO

Delete from Stud_Marks

DBCC CHECKIDENT ('Stud_Marks', RESEED, 0)
GO
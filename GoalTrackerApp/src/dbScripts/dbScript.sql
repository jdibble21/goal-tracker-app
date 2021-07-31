CREATE TABLE [dbo].[Goals]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [title] NVARCHAR(50) NOT NULL, 
    [description] NVARCHAR(50) NULL, 
    [goalDueTime] NVARCHAR(50) NOT NULL, 
    [goalEnterDate] NVARCHAR(50) NOT NULL, 
    [lastEditDate] NVARCHAR(50) NOT NULL
)
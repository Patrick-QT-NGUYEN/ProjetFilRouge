
DROP TABLE [dbo].[Series]

CREATE TABLE [dbo].[Series]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [name] NCHAR(80) NULL, 
    [genres] NCHAR(80) NULL, 
    [saisons] INT NULL, 
    [episodes] INT NULL, 
    [description] NCHAR(200) NULL, 
    [status] NCHAR(80) NULL, 
    [releaseDate] DATETIME NULL
	
)

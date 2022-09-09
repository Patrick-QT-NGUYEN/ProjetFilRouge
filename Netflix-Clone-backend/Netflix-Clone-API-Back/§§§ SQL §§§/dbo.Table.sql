DROP TABLE [dbo].[Films]

CREATE TABLE [dbo].[Films]
(
	[Id] INT IDENTITY (1,1) NOT NULL PRIMARY KEY, 
    [Title] NVARCHAR(80) NULL, 
    [Description] NVARCHAR(150) NULL, 
    [Poster] NVARCHAR(80) NULL, 
    [Director] NVARCHAR(80) NULL, 
    [ReleaseDate] DATETIME NULL, 
    [trailer] NVARCHAR(80) NULL
)

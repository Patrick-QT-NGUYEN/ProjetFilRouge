CREATE TABLE [dbo].[Films] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Title]       NVARCHAR (100) NULL,
    [Description] NVARCHAR (500) NULL,
    [Poster]      NVARCHAR (80)  NULL,
    [Director]    NVARCHAR (100) NULL,
    [ReleaseDate] DATETIME       NULL,
    [trailer]     NVARCHAR (100) NULL,
    [Genre]       NVARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


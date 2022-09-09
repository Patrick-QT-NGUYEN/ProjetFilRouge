CREATE TABLE [dbo].[Series] (
    [Id]          INT        IDENTITY (1,1) NOT NULL,
    [name]        NVARCHAR(80)  NULL,
    [genres]      NVARCHAR(80)  NULL,
    [saisons]     INT         NULL,
    [episodes]    INT         NULL,
    [description] NVARCHAR(200) NULL,
    [status]      NVARCHAR(80)  NULL,
    [releaseDate] DATETIME    NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


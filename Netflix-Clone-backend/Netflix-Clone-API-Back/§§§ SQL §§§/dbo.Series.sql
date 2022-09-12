--DROP TABLE [dbo].[Series];

CREATE TABLE [dbo].[series] (
    [Id]          INT            NOT NULL,
    [name]        NVARCHAR (80)  NULL,
    [genres]      NVARCHAR (80)  NULL,
    [saisons]     INT            NULL,
    [episodes]    INT            NULL,
    [description] NVARCHAR (200) NULL,
    [status]      NVARCHAR (80)  NULL,
    [releaseDate] DATETIME       NULL,
    [trailer]     NVARCHAR (100) NULL,
    [poster]      NVARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

--CREATE TABLE [dbo].[series] (
--    [Id]          INT            NOT NULL,
--    [name]        NVARCHAR (80)  NULL,
--    [genres]      NVARCHAR (80)  NULL,
--    [saisons]     INT            NULL,
--    [episodes]    INT            NULL,
--    [description] NVARCHAR (200) NULL,
--    [status]      NVARCHAR (80)  NULL,
--    [releaseDate] DATETIME       NULL,
--    [trailer]     NVARCHAR (100) NULL,
--    [poster]      NVARCHAR (100) NULL,
--    PRIMARY KEY CLUSTERED ([Id] ASC)
--);



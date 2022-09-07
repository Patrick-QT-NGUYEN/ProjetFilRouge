CREATE TABLE [dbo].[Episodes] (
    [Id]           INT            NOT NULL,
    [NameEpisodes] VARCHAR(100) NULL,
    [NbEpisodes]   INT            NULL,
    [Lien]         VARCHAR(200) NULL,
    [saisonId] INT NULL, 
    [saisonImg] VARCHAR(100) NULL, 
    [saisonLien] VARCHAR(100) NULL, 
    [saisonAnnees] DATETIME NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


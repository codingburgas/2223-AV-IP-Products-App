CREATE TABLE [dbo].[products] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (50)  NOT NULL,
    [Description] NVARCHAR (200) NOT NULL,
    [Price]       TINYINT        NOT NULL,
    [createdOn] DATE NOT NULL DEFAULT getdate(), 
    [updatedOn] DATE NOT NULL, 
    CONSTRAINT [PK_products] PRIMARY KEY CLUSTERED ([Id] ASC)
);


﻿CREATE TABLE [dbo].[Users] (
    [UserId]   INT            IDENTITY (1, 1) NOT NULL,
    [EMail]    NVARCHAR (MAX) NULL,
    [Password] NVARCHAR (MAX) NULL,
    [Username] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([UserId] ASC)
);


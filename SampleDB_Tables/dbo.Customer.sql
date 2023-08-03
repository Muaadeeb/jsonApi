USE [Samples]
GO

/****** Object: Table [dbo].[Customer] Script Date: 8/3/2023 4:19:46 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Customer] (
    [CustomerId] INT            IDENTITY (1, 1) NOT NULL,
    [FirstName]  NVARCHAR (50)  NOT NULL,
    [LastName]   NVARCHAR (50)  NOT NULL,
    [Email]      NVARCHAR (255) NOT NULL
);



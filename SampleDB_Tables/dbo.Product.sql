USE [Samples]
GO

/****** Object: Table [dbo].[Product] Script Date: 8/3/2023 4:21:14 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Product] (
    [ProductId] INT           IDENTITY (1, 1) NOT NULL,
    [Name]      NVARCHAR (50) NULL,
    [Price]     FLOAT (53)    NULL
);



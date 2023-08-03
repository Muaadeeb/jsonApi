USE [Samples]
GO

/****** Object: Table [dbo].[Order] Script Date: 8/3/2023 4:20:53 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Order] (
    [OrderId]    INT IDENTITY (1, 1) NOT NULL,
    [CustomerId] INT NOT NULL
);



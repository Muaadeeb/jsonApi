USE [Samples]
GO

/****** Object: Table [dbo].[OrderDetail] Script Date: 8/3/2023 4:21:05 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[OrderDetail] (
    [OrderDetailId] INT        IDENTITY (1, 1) NOT NULL,
    [OrderId]       INT        NOT NULL,
    [ProductId]     INT        NOT NULL,
    [Quantity]      INT        NOT NULL,
    [UnitPrice]     FLOAT (53) NOT NULL
);



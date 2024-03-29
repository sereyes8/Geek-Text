﻿CREATE TABLE [dbo].[BookDetails]
(
	[ISBN] VARCHAR(50) PRIMARY KEY NOT NULL,
	[Name] VARCHAR(50) NOT NULL,
	[Description] VARCHAR(255) NULL,
	[Price] DOUBLE PRECISION NOT NULL,
	[Author] INT NOT NULL,
	[Genre] VARCHAR (50),
	[Publisher] VARCHAR (50),
	[Year Published] VARCHAR (4),
	[Sold]  INTEGER DEFAULT 0
)

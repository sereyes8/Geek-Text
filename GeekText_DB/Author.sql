﻿CREATE TABLE [dbo].[Author]
(
	[FirstName] VARCHAR(50) NOT NULL,
	[LastName] VARCHAR(50) PRIMARY KEY NOT NULL,
	[Biography] VARCHAR(255) NULL,
	[Publisher] VARCHAR (50),
	[ID] INTEGER DEFAULT 0
)

﻿CREATE TABLE [dbo].[BookRating]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Rating INT NOT NULL,
	Created DATETIME NOT NULL,
	UserId INT NOT NULL,
	BookISBN INT NOT NULL
)

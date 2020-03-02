CREATE TABLE [dbo].[PasswordTable]
(
	[PasswordId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PasswordText] VARCHAR(64) NOT NULL UNIQUE
)

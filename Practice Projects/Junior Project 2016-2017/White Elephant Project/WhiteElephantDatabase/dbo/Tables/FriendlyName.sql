CREATE TABLE [dbo].[FriendlyName]
(
	[FriendlyNameId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FriendlyName] VARCHAR(128) NOT NULL UNIQUE
)

CREATE TABLE [dbo].[UserTable] (
    [UserId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FriendlyNameId] INT NULL, 
    [PasswordId] INT NOT NULL, 
    [UserName] VARCHAR(128) NOT NULL UNIQUE
);


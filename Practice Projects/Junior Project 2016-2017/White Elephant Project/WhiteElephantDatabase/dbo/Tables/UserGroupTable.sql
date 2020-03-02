CREATE TABLE [dbo].[UserGroupTable]
(
	[UserGroupId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserId] NVARCHAR(128) NULL, 
	[InvitedId] INT NULL, 
    [GroupId] INT NOT NULL, 
	[StatusId] INT NOT NULL, 
    CONSTRAINT [FK_UserGroupTable_UserTable] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers]([Id]),
	CONSTRAINT [FK_UserGroupTable_InvitedTable] FOREIGN KEY ([InvitedId]) REFERENCES [InvitedTable]([InvitedId]),
	CONSTRAINT [FK_UserGroupTable_GroupTable] FOREIGN KEY ([GroupId]) REFERENCES [GroupTable]([GroupId]),
	CONSTRAINT [FK_UserGroupTable_StatusTable] FOREIGN KEY ([StatusId]) REFERENCES [StatusTable]([StatusId]),
	CONSTRAINT UserIdMustExist CHECK ([UserId] IS NOT NULL OR [InvitedId] IS NOT NULL)
)

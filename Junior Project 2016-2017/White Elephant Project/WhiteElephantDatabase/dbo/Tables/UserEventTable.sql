CREATE TABLE [dbo].[UserEventTable]
(
	[UserEventId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserId] NVARCHAR(128) NOT NULL, 
    [EventId] INT NOT NULL, 
	[StatusId] INT NOT NULL, 
    CONSTRAINT [FK_UserEventTable_UserTable] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers]([Id]),
	CONSTRAINT [FK_UserEventTable_EventTable] FOREIGN KEY ([EventId]) REFERENCES [EventTable]([EventId]),
	CONSTRAINT [FK_UserEventTable_StatusTable] FOREIGN KEY ([StatusId]) REFERENCES [StatusTable]([StatusId]) 
)

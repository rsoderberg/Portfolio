CREATE TABLE [dbo].[GroupEventTable]
(
	[GroupEventId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [GroupId] INT NOT NULL, 
    [EventId] INT NOT NULL, 
    CONSTRAINT [FK_GroupEvent_GroupTable] FOREIGN KEY ([GroupId]) REFERENCES [GroupTable]([GroupId]), 
    CONSTRAINT [FK_GroupEvent_Event] FOREIGN KEY ([EventId]) REFERENCES [EventTable]([EventId]),
	CONSTRAINT OnlyUniqueEvents UNIQUE([GroupId], [EventId])
)

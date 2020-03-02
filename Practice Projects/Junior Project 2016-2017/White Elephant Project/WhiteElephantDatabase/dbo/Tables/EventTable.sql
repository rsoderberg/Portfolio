CREATE TABLE [dbo].[EventTable]
(
	[EventId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Date] DATETIME2 NOT NULL, 
    [EventNameId] INT NOT NULL,
	[MaxPrice] DECIMAL(13, 3) NOT NULL,
    CONSTRAINT [FK_Event_EventName] FOREIGN KEY ([EventNameId]) REFERENCES [EventNameTable]([EventNameId])
)

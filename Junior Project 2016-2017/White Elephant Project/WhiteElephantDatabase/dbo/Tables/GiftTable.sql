CREATE TABLE [dbo].[GiftTable]
(
	[GiftId] INT NOT NULL PRIMARY KEY IDENTITY,
	[Title] NVARCHAR(128) NOT NULL, 
    [Description] NVARCHAR(MAX) NULL, 
    [Price] DECIMAL(13, 2) NULL, 
    [URL] NVARCHAR(MAX) NULL, 
    [ClaimUserEventId] INT NULL, 
    [SubmitUserEventId] INT NOT NULL, 
    CONSTRAINT [FK_GiftTable_ClaimUserEventTable] FOREIGN KEY ([ClaimUserEventId]) REFERENCES [UserEventTable]([UserEventId]), 
    CONSTRAINT [FK_GiftTable_SubmitUserEventTable] FOREIGN KEY ([SubmitUserEventId]) REFERENCES [UserEventTable]([UserEventId])
	
)

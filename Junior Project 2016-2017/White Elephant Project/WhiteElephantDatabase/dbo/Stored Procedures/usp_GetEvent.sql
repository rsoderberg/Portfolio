CREATE PROCEDURE [dbo].[usp_GetEvent]
	@GroupId INT,
	@EventName VARCHAR(128),
	@MaxPrice DECIMAL(13, 3),
	@EventDate DATETIME2,
	@UserId VARCHAR(128)
AS
/**************************************************************************
***************************************************************************
Date:		2/11/2017
Author:		Matt Dougal
Project:	White Elephant
Summary:	This procedure will get the event for a user.
Execution Rights granted to -- Public

***************************************************************************
**************************************************************************/
IF 1=0 BEGIN
SET FMTONLY OFF
END
BEGIN
	SELECT		et.EventId
	FROM		EventTable et
	INNER JOIN	GroupEventTable get1 on get1.EventId = et.EventId
	INNER JOIN	UserEventTable uet on uet.EventId = et.EventId
	WHERE		et.MaxPrice = @MaxPrice AND 
				get1.GroupId = @GroupId AND 
				uet.UserId = @UserId AND
				et.Date = @EventDate
END
GRANT EXECUTE ON [dbo].[usp_GetEvent] TO PUBLIC AS [dbo]
GO

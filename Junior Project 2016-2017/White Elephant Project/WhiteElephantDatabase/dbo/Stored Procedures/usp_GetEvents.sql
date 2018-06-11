CREATE PROCEDURE [dbo].[usp_GetEvents]
	@GroupId INT,
	@UserId VARCHAR(128)
AS
	/**************************************************************************
***************************************************************************
Date:		2/11/2017
Author:		Matt Dougal
Project:	White Elephant
Summary:	This procedure will get all events for a user/group.
Execution Rights granted to -- Public

***************************************************************************
**************************************************************************/
IF 1=0 BEGIN
SET FMTONLY OFF
END
BEGIN
	SELECT		et.EventId,
				ent.EventName,
				et.Date,
				et.MaxPrice
	FROM		EventTable et
	INNER JOIN	GroupEventTable get1 on get1.EventId = et.EventId
	INNER JOIN	UserEventTable uet on uet.EventId = et.EventId
	INNER JOIN	EventNameTable ent on ent.EventNameId = et.EventNameId
	WHERE		get1.GroupId = @GroupId AND 
				uet.UserId = @UserId
END
GRANT EXECUTE ON [dbo].[usp_GetEvents] TO PUBLIC AS [dbo]
GO

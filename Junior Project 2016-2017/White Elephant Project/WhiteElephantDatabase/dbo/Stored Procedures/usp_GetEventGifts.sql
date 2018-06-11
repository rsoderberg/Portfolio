CREATE PROCEDURE [dbo].[usp_GetEventGifts]
	@EventID INT
AS
/**************************************************************************
***************************************************************************
Date:		3/07/2017
Author:		Patrick Carlson
Project:	White Elephant
Summary:	This procedure will return all gifts for the event, excluding
the user running the query.
Execution Rights granted to -- Public

***************************************************************************
**************************************************************************/
IF 1=0 BEGIN
SET FMTONLY OFF
END
BEGIN
	SELECT  GT.GiftId,
			GT.Title,
			GT.Description,
			GT.Price,
			GT.URL,
			GT.ClaimUserEventId,
			GT.SubmitUserEventId
			FROM UserEventTable AS UET
			JOIN GiftTable AS GT ON UET.UserEventId = GT.SubmitUserEventId
			WHERE UET.EventId = @EventID 
END
GRANT EXECUTE ON [dbo].[usp_GetEventGifts] TO PUBLIC AS [dbo]
GO
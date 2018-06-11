CREATE PROCEDURE [dbo].[usp_GetEventUsers]
	@EventId INT
	
AS
	/**************************************************************************
***************************************************************************
Date:		2/11/2017
Author:		Matt Dougal
Project:	White Elephant
Summary:	This procedure will get the user data from an event.
Execution Rights granted to -- Public

***************************************************************************
**************************************************************************/
IF 1=0 BEGIN
SET FMTONLY OFF
END
BEGIN
	SELECT		uet.UserEventId AS 'UserEventId',
				uet.EventId AS 'EventId',
				anu.UserName AS 'UserName',
				anu.Email AS 'Email',
				st.StatusName AS 'Status'
	FROM		UserEventTable uet
	INNER JOIN	EventTable et ON uet.EventId = et.EventId
	INNER JOIN	StatusTable st ON uet.StatusId = st.StatusId
	INNER JOIN	AspNetUsers anu ON uet.UserId = anu.Id
	WHERE		et.EventId = @EventId
END
GRANT EXECUTE ON [dbo].[usp_GetEventUsers] TO PUBLIC AS [dbo]
GO

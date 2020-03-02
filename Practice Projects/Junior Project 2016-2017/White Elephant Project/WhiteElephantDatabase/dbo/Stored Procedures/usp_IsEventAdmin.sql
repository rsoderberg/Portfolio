CREATE PROCEDURE [dbo].[usp_IsEventAdmin]
	@EventId INT,
	@UserEmail NVARCHAR(256)
AS
	/**************************************************************************
***************************************************************************
Date:		2/13/2017
Author:		Matt Dougal
Project:	White Elephant
Summary:	This procedure will return the status of an event member.
Execution Rights granted to -- Public

***************************************************************************
**************************************************************************/
IF 1=0 BEGIN
SET FMTONLY OFF
END
BEGIN
	SELECT		st.StatusName AS 'Status'
	FROM		UserEventTable uet
	INNER JOIN	EventTable et ON uet.EventId = et.EventId
	INNER JOIN	StatusTable st ON uet.StatusId = st.StatusId
	INNER JOIN	AspNetUsers anu ON uet.UserId = anu.Id
	WHERE		et.EventId = @EventId AND anu.Email = @UserEmail
END
GRANT EXECUTE ON [dbo].[usp_IsEventAdmin] TO PUBLIC AS [dbo]
GO

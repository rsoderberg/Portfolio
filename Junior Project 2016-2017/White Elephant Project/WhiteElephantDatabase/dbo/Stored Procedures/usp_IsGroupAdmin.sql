CREATE PROCEDURE [dbo].[usp_IsGroupAdmin]
	@GroupId INT,
	@UserEmail NVARCHAR(256)
AS
	/**************************************************************************
***************************************************************************
Date:		1/21/2017
Author:		Matt Dougal
Project:	White Elephant
Summary:	This procedure will return the status of a group member.
Execution Rights granted to -- Public

***************************************************************************
**************************************************************************/
IF 1=0 BEGIN
SET FMTONLY OFF
END
BEGIN
	SELECT		st.StatusName AS 'Status'
	FROM		UserGroupTable ugt
	INNER JOIN	GroupTable gt ON ugt.GroupId = gt.GroupId
	INNER JOIN	StatusTable st ON ugt.StatusId = st.StatusId
	INNER JOIN	AspNetUsers anu ON ugt.UserId = anu.Id
	WHERE		gt.GroupId = @GroupId AND anu.Email = @UserEmail
END
GRANT EXECUTE ON [dbo].[usp_IsGroupAdmin] TO PUBLIC AS [dbo]
GO

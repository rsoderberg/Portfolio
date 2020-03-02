CREATE PROCEDURE [dbo].[usp_GetGroupUsers]
	@GroupId INT
AS
	/**************************************************************************
***************************************************************************
Date:		1/21/2017
Author:		Matt Dougal
Project:	White Elephant
Summary:	This procedure will get the user data from a group.
Execution Rights granted to -- Public

***************************************************************************
**************************************************************************/
IF 1=0 BEGIN
SET FMTONLY OFF
END
BEGIN
	SELECT		anu.UserName AS 'UserName',
				anu.Email AS 'Email',
				it.Email AS 'InvitedEmail',
				st.StatusName AS 'Status'
	FROM		UserGroupTable ugt
	INNER JOIN	GroupTable gt ON ugt.GroupId = gt.GroupId
	INNER JOIN	StatusTable st ON ugt.StatusId = st.StatusId
	LEFT JOIN	AspNetUsers anu ON ugt.UserId = anu.Id
	LEFT JOIN	InvitedTable it ON ugt.InvitedId = it.InvitedId
	WHERE		gt.GroupId = @GroupId
END
GRANT EXECUTE ON [dbo].[usp_GetGroupUsers] TO PUBLIC AS [dbo]
GO

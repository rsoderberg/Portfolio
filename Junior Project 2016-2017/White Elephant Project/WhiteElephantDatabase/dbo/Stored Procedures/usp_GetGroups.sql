CREATE PROCEDURE [dbo].[usp_GetGroups]
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
	SELECT		gt.GroupId,
				gt.GroupName
	FROM		GroupTable gt
	INNER JOIN	UserGroupTable ugt on ugt.GroupId = gt.GroupId
	WHERE		ugt.UserId = @UserId
END
GRANT EXECUTE ON [dbo].[usp_GetGroups] TO PUBLIC AS [dbo]
GO

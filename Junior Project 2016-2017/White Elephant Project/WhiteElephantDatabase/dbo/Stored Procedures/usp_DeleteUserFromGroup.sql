CREATE PROCEDURE [dbo].[usp_DeleteUserFromGroup]
	@UserEmail VARCHAR(128),
	@GroupId INT
AS
/**************************************************************************
***************************************************************************
Date:		11/23/2016
Author:		Patrick Carlson - Based on example by Matt Dougal
Project:	White Elephant
Summary:	This procedure will remove a user from a group
Execution Rights granted to -- Public

Modified Date:		1/22/2017
By:					Matt Dougal
Summary:			Modified to take email instead of user name


***************************************************************************
**************************************************************************/
IF 1=0 BEGIN
SET FMTONLY OFF
END
BEGIN
	BEGIN TRANSACTION
	SET NOCOUNT ON;

	DECLARE @UserId NVARCHAR(128)
	DECLARE @InvitedId INT
	DECLARE @UserGroupId INT

	BEGIN TRY
		-- GET ID'S OF CORRESPONDING GROUP, USER, AND USERGROUP
		SELECT @UserId = Id FROM AspNetUsers WHERE Email = @UserEmail

		IF (@UserId IS NULL)
			BEGIN
				SELECT @InvitedId = InvitedId FROM InvitedTable WHERE Email = @UserEmail
				SELECT @UserGroupId = [UserGroupId] FROM UserGroupTable WHERE InvitedId = @InvitedId AND GroupId = @GroupId
			END
		ELSE
			BEGIN
				SELECT @UserGroupId = [UserGroupId] FROM UserGroupTable WHERE UserId = @UserId AND GroupId = @GroupId
			END

		-- REMOVE USER FROM GROUP IF USER IS MEMBER OF GROUP
		IF @UserGroupId IS NOT NULL
		BEGIN
			DELETE FROM UserGroupTable
			WHERE @UserGroupId = UserGroupId
		END

		-- REMOVE USER FROM ALL CONNECTED EVENTS
		IF (@UserId IS NOT NULL)
			BEGIN
				DELETE FROM UserEventTable WHERE UserId = @UserId
			END

		-- IF THE USER WAS ONLY INVITED TO THAT GROUP DELETE THEM FROM THE INVITED TABLE
		IF(@InvitedId IS NOT NULL AND (SELECT COUNT(*) FROM UserGroupTable WHERE InvitedId = @InvitedId) = 0)
			BEGIN
				DELETE FROM InvitedTable WHERE InvitedId = @InvitedId
			END

		-- CHECK IF ALL USERS HAVE BEEN REMOVED FROM GROUP IF SO DELETE GROUP
		IF (SELECT COUNT(*) FROM UserGroupTable WHERE GroupId = @GroupId) = 0
		BEGIN
			EXEC usp_DeleteGroup @GroupId
		END
	END TRY

	BEGIN CATCH
              DECLARE	@ErrorMsg nvarchar(255),
						@ErrorNumber int,
						@ErrorSeverity int,
						@ErrorState int,
						@ErrorProcedure nvarchar(4000),
						@ErrorLine int,
						@ErrorMessage nvarchar(4000);
              --Get Error details
              SELECT
                     @ErrorNumber = ERROR_NUMBER(),
                     @ErrorSeverity = ERROR_SEVERITY(),
                     @ErrorState = ERROR_STATE(),
                     @ErrorProcedure = ERROR_PROCEDURE(),
                     @ErrorLine = ERROR_LINE(),
                     @ErrorMessage = ERROR_MESSAGE();
                     
              --Create new Error Message.
              SET @ErrorMsg = N'%s raised an error on line %d.' + CHAR(13) + CHAR(10) +
                                         '%s' + CHAR(13) + CHAR(10) + 
                                          'Original Error Num: %d'
              --Throw error to caller.
              RAISERROR(@ErrorMsg,
                             @ErrorSeverity,
                             @ErrorState,
                             @ErrorProcedure,
                             @ErrorLine,
                             @ErrorMessage,
                             @ErrorNumber)
              --Rollback Transaction is one is started.
              IF @@TRANCOUNT > 0
                     BEGIN
                           PRINT N'Rolling back transaction'
                           ROLLBACK TRANSACTION;
                     END    
       END CATCH

       IF @@TRANCOUNT > 0
       BEGIN
              PRINT N'Committing transaction'
              COMMIT TRANSACTION;
       END
END
GRANT EXECUTE ON [dbo].[usp_DeleteUserFromGroup] TO PUBLIC AS [dbo]
GO


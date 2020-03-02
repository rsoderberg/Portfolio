CREATE PROCEDURE [dbo].[usp_DeleteUserFromEvent]
	@UserEmail VARCHAR(128),
	@EventId INT
AS
/**************************************************************************
***************************************************************************
Date:		2/13/2017
Author:		Matt Dougal
Project:	White Elephant
Summary:	This procedure will remove a user from an event
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
	DECLARE @UserEventId INT

	BEGIN TRY
		-- GET ID'S OF CORRESPONDING GROUP, USER, AND USERGROUP
		SELECT @UserId = Id FROM AspNetUsers WHERE Email = @UserEmail
		SELECT @UserEventId = [UserEventId] FROM UserEventTable WHERE UserId = @UserId AND EventId = @EventId

		-- REMOVE USER FROM GROUP IF USER IS MEMBER OF GROUP
		IF @UserEventId IS NOT NULL
		BEGIN
			DELETE FROM UserEventTable
			WHERE @UserEventId = UserEventId
		END

		-- CHECK IF ALL USERS HAVE BEEN REMOVED FROM GROUP IF SO DELETE GROUP
		IF ((SELECT COUNT(*) FROM UserEventTable WHERE EventId = @EventId) = 0)
		BEGIN
			EXEC usp_DeleteEvent @EventId
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
GRANT EXECUTE ON [dbo].[usp_DeleteUserFromEvent] TO PUBLIC AS [dbo]
GO

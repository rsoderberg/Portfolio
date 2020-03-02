CREATE PROCEDURE [dbo].[usp_AddUserToEvent]
	@UserEmail NVARCHAR(256),
	@EventId INT,
	@StatusName VARCHAR(128)
AS
/**************************************************************************
***************************************************************************
Date:		2/11/2017
Author:		Matt Dougal
Project:	White Elephant
Summary:	This procedure will add a user to an event.
Execution Rights granted to -- Public

***************************************************************************
**************************************************************************/
IF 1=0 BEGIN
SET FMTONLY OFF
END
BEGIN
	BEGIN TRANSACTION
	SET NOCOUNT ON;

	DECLARE @UserId NVARCHAR(128)
	DECLARE @StatusId INT

	BEGIN TRY
		-- MAKE SURE STATUS NAME EXISTS
		IF (SELECT COUNT(*) FROM StatusTable WHERE StatusName = @StatusName) = 0
		BEGIN	
			INSERT INTO StatusTable (StatusName)
			VALUES (@StatusName);
		END

		-- GET ID OF USER
		SELECT @UserId = [Id] FROM [AspNetUsers] WHERE Email = @UserEmail
		SELECT @StatusId = [StatusId] FROM StatusTable WHERE StatusName = @StatusName

		-- INPUT USER AND GROUP DATA TO USERGROUPTABLE IF DOES NOT ALREADY EXIST
		IF (@UserId IS NOT NULL AND (SELECT COUNT(*) FROM UserEventTable WHERE UserId = @UserId AND EventId = @EventId) = 0)
			BEGIN	
				INSERT INTO UserEventTable (UserId, EventId, StatusId)
				VALUES (@UserId, @EventId, @StatusId);
			END
		ELSE
			BEGIN
				IF(@UserId IS NOT NULL)
					BEGIN
						UPDATE UserEventTable
						SET StatusId = @StatusId
						WHERE UserId = @UserId AND EventId = @EventId
					END
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
GRANT EXECUTE ON [dbo].[usp_AddUserToEvent] TO PUBLIC AS [dbo]
GO

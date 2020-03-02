CREATE PROCEDURE [dbo].[usp_UpdateInvited]
	@Email nvarchar(256),
	@UserId nvarchar(128)
AS
/**************************************************************************
***************************************************************************
Date:		1/28/2017
Author:		Matt Dougal
Project:	White Elephant
Summary:	This procedure will look for users in the Invited table and remove
			them as well as update the UserGroupTable.
Execution Rights granted to -- Public

***************************************************************************
**************************************************************************/

IF 1=0 BEGIN
SET FMTONLY OFF
END
BEGIN
	BEGIN TRANSACTION
	SET NOCOUNT ON;

	-- DECLARE VARIABLES
	DECLARE @InvitedId INT

	BEGIN TRY

		SELECT @InvitedId = [InvitedId] FROM InvitedTable WHERE @Email = [Email]
		IF @InvitedId IS NOT NULL
			BEGIN
				UPDATE UserGroupTable
				SET UserId = @UserId, InvitedId = NULL
				WHERE InvitedId = @InvitedId

				DELETE FROM InvitedTable
				WHERE InvitedId = @InvitedId
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
GRANT EXECUTE ON [dbo].[usp_UpdateInvited] TO PUBLIC AS [dbo]
GO

CREATE PROCEDURE [dbo].[usp_DeleteUser]
	@UserName VARCHAR(128)
AS
/**************************************************************************
***************************************************************************
Date:		10/24/2016
Author:		Matt Dougal
Project:	White Elephant
Summary:	This procedure will delete a user and password from the database.
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
	DECLARE @FriendlyNameId INT
	DECLARE @PasswordId INT

	BEGIN TRY
		-- GET ID'S OF CURRENT USER TABLE VALUES
		SELECT @FriendlyNameId = [FriendlyNameId] FROM UserTable WHERE [UserName] = @UserName
		SELECT @PasswordId = [PasswordId] FROM UserTable WHERE [UserName] = @UserName

		-- DELETE USERTABLE DATA
		DELETE FROM UserTable
		WHERE [UserName] = @UserName

		-- IF THE FRIENDLY NAME IS NOT USED ANYWHERE ELSE DELETE IT
		IF @FriendlyNameId IS NOT NULL
			BEGIN
				IF (SELECT COUNT(*) FROM UserTable WHERE [FriendlyNameId] = @FriendlyNameId) = 0
					DELETE FROM FriendlyName WHERE [FriendlyNameId] = @FriendlyNameId
			END

		-- IF THE PASSWORD IS NOT USED ANYWHERE ELSE DELETE IT
		IF (SELECT COUNT(*) FROM UserTable WHERE [PasswordId] = @PasswordId) = 0
			DELETE FROM PasswordTable WHERE [PasswordId] = @PasswordId

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
GRANT EXECUTE ON [dbo].[usp_DeleteUser] TO PUBLIC AS [dbo]
GO

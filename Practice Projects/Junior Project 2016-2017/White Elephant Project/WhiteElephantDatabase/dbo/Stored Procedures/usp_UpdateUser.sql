CREATE PROCEDURE [dbo].[usp_UpdateUser]
	@UserName VARCHAR(128),
	@NewFriendlyName VARCHAR(128),
	@NewPassword VARCHAR(64)
AS
/**************************************************************************
***************************************************************************
Date:		10/24/2016
Author:		Matt Dougal
Project:	White Elephant
Summary:	This procedure will update a user in the database.
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
	DECLARE @OldFriendlyNameId INT
	DECLARE @OldPasswordId INT
	DECLARE @NewFriendlyNameId INT
	DECLARE @NewPasswordId INT

	BEGIN TRY
		
		-- GET ID'S OF CURRENT USER TABLE VALUES
		SELECT @OldFriendlyNameId = [FriendlyNameId] FROM UserTable WHERE [UserName] = @UserName
		SELECT @OldPasswordId = [PasswordId] FROM UserTable WHERE [UserName] = @UserName

		-- UPDATE FRIENDLY NAME
		IF @NewFriendlyName IS NOT NULL
			BEGIN
				SELECT @NewFriendlyNameId = [FriendlyNameId] FROM FriendlyName WHERE [FriendlyName] = @NewFriendlyName

				-- VALUE DOES NOT EXIST YET
				IF @NewFriendlyNameId IS NULL
					BEGIN
						INSERT INTO FriendlyName ([FriendlyName]) VALUES (@NewFriendlyName)
						SELECT @NewFriendlyNameId = SCOPE_IDENTITY()
					END
			END
		ELSE 
			SET @NewFriendlyNameId = @OldFriendlyNameId

		-- UPDATE PASSWORD
		IF @NewPassword IS NOT NULL
			BEGIN
				SELECT @NewPasswordId = [PasswordId] FROM PasswordTable WHERE [PasswordText] = @NewPassword

				-- VALUE DOES NOT EXIST YET
				IF @NewPasswordId IS NULL
					BEGIN
						INSERT INTO PasswordTable ([PasswordText]) VALUES (@NewPassword)
						SELECT @NewPasswordId = SCOPE_IDENTITY()
					END
			END
		ELSE
			SET @NewPasswordId = @OldPasswordId

		-- UPDATE USER TABLE WITH NEW VALUES
		UPDATE UserTable
		SET [FriendlyNameId ] = @NewFriendlyNameId, [PasswordId] = @NewPasswordId
		WHERE [UserName] = @UserName

		-- IF THE FRIENDLY NAME IS NOT USED ANYWHERE ELSE DELETE IT
		IF (SELECT COUNT(*) FROM UserTable WHERE [FriendlyNameId] = @OldFriendlyNameId) = 0
				DELETE FROM FriendlyName WHERE [FriendlyNameId] = @OldFriendlyNameId

		-- IF THE PASSWORD IS NOT USED ANYWHERE ELSE DELETE IT
		IF (SELECT COUNT(*) FROM UserTable WHERE [PasswordId] = @OldPasswordId) = 0
			DELETE FROM PasswordTable WHERE [PasswordId] = @OldPasswordId

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
GRANT EXECUTE ON [dbo].[usp_UpdateUser] TO PUBLIC AS [dbo]
GO

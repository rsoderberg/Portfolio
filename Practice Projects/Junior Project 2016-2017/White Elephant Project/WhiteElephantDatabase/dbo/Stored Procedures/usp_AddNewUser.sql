CREATE PROCEDURE [dbo].[usp_AddNewUser]
	@UserName VARCHAR(128),
	@Password VARCHAR(64),
	@FriendlyName VARCHAR(128)
AS
/**************************************************************************
***************************************************************************
Date:		10/24/2016
Author:		Matt Dougal
Project:	White Elephant
Summary:	This procedure will add a user and password to the database.
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

		-- PROCESS FRIENDLY NAME IF EXISTS
		IF @FriendlyName IS NOT NULL
			BEGIN
				
				-- CHECK IF VALUE ALREADY EXISTS
				SELECT @FriendlyNameId = [FriendlyNameId] FROM FriendlyName WHERE [FriendlyName] = @FriendlyName

				-- VALUE WAS NOT FOUND SO ADD IT
				IF @FriendlyNameId IS NULL
					BEGIN
						INSERT INTO FriendlyName ([FriendlyName]) VALUES (@FriendlyName)
						SELECT @FriendlyNameId = SCOPE_IDENTITY()
					END
			END

		-- CHECK IF VALUE ALREADY EXISTS
		SELECT @PasswordId = [PasswordId] FROM PasswordTable WHERE [PasswordText] = @Password

		-- VALUE WAS NOT FOUND SO ADD IT
		IF @PasswordId IS NULL
			BEGIN
				INSERT INTO PasswordTable ([PasswordText]) VALUES (@Password)
				SELECT @PasswordId = SCOPE_IDENTITY()
			END

		-- ADD NEW ITEM TO USER TABLE
		INSERT INTO UserTable ([UserName], [PasswordId], [FriendlyNameId])
		VALUES (@UserName, @PasswordId, @FriendlyNameId)

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
GRANT EXECUTE ON [dbo].[usp_AddNewUser] TO PUBLIC AS [dbo]
GO


CREATE PROCEDURE [dbo].[usp_AddUserToGroup]
	@UserEmail NVARCHAR(256),
	@GroupId INT,
	@StatusName VARCHAR(128)
AS
/**************************************************************************
***************************************************************************
Date:		11/23/2016
Author:		Patrick Carlson - Based on example by Matt Dougal
Project:	White Elephant
Summary:	This procedure will add a user to a group.
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
	DECLARE @InvitedUserId INT
	DECLARE @bodyHTML  NVARCHAR(MAX)  

	BEGIN TRY
		-- MAKE SURE STATUS NAME EXISTS
		IF (SELECT COUNT(*) FROM StatusTable WHERE StatusName = @StatusName) = 0
		BEGIN	
			INSERT INTO StatusTable (StatusName)
			VALUES (@StatusName);
		END

		-- GET ID'S OF CORRESPONDING GROUP AND USER
		SELECT @UserId = [Id] FROM [AspNetUsers] WHERE Email = @UserEmail
		SELECT @InvitedUserId = InvitedId FROM InvitedTable WHERE Email = @UserEmail
		SELECT @StatusId = [StatusId] FROM StatusTable WHERE StatusName = @StatusName

		-- ENTER USER DATA INTO THE INVITED TABLE IF THEY ARE NOT ALREADY A USER
		IF (@UserId IS NULL AND @InvitedUserId IS NULL)
			BEGIN
				INSERT INTO InvitedTable (Email)
				VALUES (@UserEmail)
				SELECT @InvitedUserId =  SCOPE_IDENTITY()
			END

		-- INPUT USER AND GROUP DATA TO USERGROUPTABLE IF DOES NOT ALREADY EXIST
		IF (@UserId IS NOT NULL AND (SELECT COUNT(*) FROM UserGroupTable WHERE UserId = @UserId AND GroupId = @GroupId) = 0)
			BEGIN	
				INSERT INTO UserGroupTable (UserId, GroupId, StatusId)
				VALUES (@UserId, @GroupId, @StatusId);
			END
		ELSE IF (@InvitedUserId IS NOT NULL AND (SELECT COUNT(*) FROM UserGroupTable WHERE InvitedId = @InvitedUserId AND GroupId = @GroupId) = 0)
			BEGIN	
				INSERT INTO UserGroupTable (InvitedId, GroupId, StatusId)
				VALUES (@InvitedUserId, @GroupId, @StatusId);
			END
		ELSE
			BEGIN
				IF(@UserId IS NOT NULL)
					BEGIN
						UPDATE UserGroupTable
						SET StatusId = @StatusId
						WHERE UserId = @UserId AND GroupId = @GroupId
					END
			END

		---- Create HTML form for email
		--SET @bodyHTML =
		--	N'<H1>White Elephant Gift Exchange Group Invite</H1>' + N' <p>' +
		--	N' You have been invited to a White Elephant Gift Exchange group!' + N' <p>' +
		--	N' The Group you have been invited to is: ' +
		--	CAST (@bodyHTML AS nvarchar(MAX));


		---- SEND EMAIL TO INVITED
		--EXEC msdb.dbo.sp_send_dbmail
		--		@profile_name = 'WhiteElephantMail',  
		--		@recipients = 'oitjp2016@outlook.com',    --Replace with @UserEmail for production
		--		@body = @bodyHTML,  
		--		@subject = 'An invitation',
		--		@body_format = 'HTML'; 

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
GRANT EXECUTE ON [dbo].[usp_AddUserToGroup] TO PUBLIC AS [dbo]
GO

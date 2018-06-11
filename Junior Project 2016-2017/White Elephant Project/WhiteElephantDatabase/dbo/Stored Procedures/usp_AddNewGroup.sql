CREATE PROCEDURE [dbo].[usp_AddNewGroup]
	@GroupName VARCHAR(128),
	@UserId VARCHAR(128)
AS
/**************************************************************************
***************************************************************************
Date:		11/19/2016
Author:		Patrick Carlson - Based on example by Matt Dougal
Project:	White Elephant
Summary:	This procedure will add a group and group name to the Database.
Execution Rights granted to -- Public

***************************************************************************
**************************************************************************/
IF 1=0 BEGIN
SET FMTONLY OFF
END
BEGIN
	BEGIN TRANSACTION
	SET NOCOUNT ON;


	--DECLARE VARIABLES
	DECLARE @GroupId INT
	DECLARE @StatusId INT
	DECLARE @UserGroupId INT

	BEGIN TRY

		--PROCESS GROUP NAME IF EXISTS
		IF @GroupName IS NOT NULL	
			BEGIN
				-- MAKE SURE STATUS NAME ADNIN EXISTS
				IF (SELECT COUNT(*) FROM StatusTable WHERE StatusName = 'Admin') = 0
					BEGIN	
						INSERT INTO StatusTable (StatusName)
						VALUES ('Admin');
						SELECT @StatusId = SCOPE_IDENTITY()
					END
				ELSE
					SELECT @StatusId = [StatusId] FROM StatusTable WHERE StatusName = 'Admin'

				-- GET GROUP AND USER ID
				SELECT @GroupId = [GroupId] FROM GroupTable Where GroupName = @GroupName

				-- CHECK IF VALUE ALREADY EXISTS
				SELECT @UserGroupId = [UserGroupId] FROM UserGroupTable AS ugt JOIN GroupTable AS gt ON  ugt.GroupId = gt.GroupId
					WHERE @UserId = ugt.UserId  AND  @GroupName = gt.GroupName

				IF @UserGroupId IS NULL
					BEGIN							
						INSERT INTO GroupTable ([GroupName]) VALUES (@GroupName)
						SELECT @GroupId = SCOPE_IDENTITY()
						INSERT INTO UserGroupTable ([GroupId], [UserId], [StatusId]) 
						VALUES (@GroupId, @UserId, @StatusId)
						SELECT @UserGroupId = SCOPE_IDENTITY()
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
			  RETURN @UserGroupId
			END
		ELSE
			RETURN 0
END
GRANT EXECUTE ON [dbo].[usp_AddNewGroup] TO PUBLIC AS [dbo]
GO
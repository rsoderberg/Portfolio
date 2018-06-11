CREATE PROCEDURE [dbo].[usp_AddGiftToEvent]
	@UserID VARCHAR(128),
	@EventID INT,
	@GiftTitle NVARCHAR(128),
	@GiftDescription NVARCHAR(MAX),
	@GiftPrice DECIMAL(13,3),
	@GiftURL NVARCHAR(MAX)

AS
/**************************************************************************
***************************************************************************
Date:		3/07/2017
Author:		Patrick Carlson
Project:	White Elephant
Summary:	This procedure will add a gift to event.
Execution Rights granted to -- Public

***************************************************************************
**************************************************************************/
IF 1=0 BEGIN
SET FMTONLY OFF
END
BEGIN
	BEGIN TRANSACTION
	SET NOCOUNT ON;

	--DECLARE var type   Data I pull from the db
	DECLARE @GiftId INT
	DECLARE @UserEventID INT
	

	BEGIN TRY
		-- GET USEREVENTID
		SELECT @UserEventID = [UserEventId] FROM [UserEventTable] WHERE @UserID = [UserId] AND @EventID = [EventId]

		-- CHECK THAT USER DOES NOT HAVE GIFT INPUT ALREADY
		SELECT @GiftId = [GiftId] FROM [GiftTable] WHERE @UserEventID = [SubmitUserEventId]

		-- INPUT GIFT DATA IF USER HAS NOT ALREADY SUBMITTED GIFT
		IF (@GiftId IS NULL)
			BEGIN
				INSERT INTO GiftTable (Title, Description, Price, URL, SubmitUserEventId)
				VALUES (@GiftTitle, @GiftDescription, @GiftPrice, @GiftURL, @UserEventID)
				SELECT @GiftId = SCOPE_IDENTITY()
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
			  RETURN @GiftId
       END
END
GRANT EXECUTE ON [dbo].[usp_AddGiftToEvent] TO PUBLIC AS [dbo]
GO


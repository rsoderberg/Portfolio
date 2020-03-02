CREATE PROCEDURE [dbo].[usp_SetGiftClaimStatus]
@GiftId INT,
@UserId VARCHAR(128)

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

	--DECLARE LOCAL VARIABLES 
	--DECLARE @GiftId INT
	DECLARE @ClaimEventUserId INT
	DECLARE @UserEventId INT

	SELECT @ClaimEventUserId = gt.ClaimUserEventId FROM GiftTable AS gt 
	WHERE gt.GiftId = @GiftId

	SELECT @UserEventId = uet.UserEventId FROM UserEventTable AS uet
	WHERE @UserId = uet.UserId

	BEGIN TRY
		IF (@ClaimEventUserId IS NOT NULL)
			BEGIN
				UPDATE GiftTable
				SET ClaimUserEventId = NULL
				WHERE GiftId = @GiftId
			END
		--Check whether user has already claimed a gift NO OP if so--
		ELSE IF((SELECT ClaimUserEventId FROM GiftTable AS gt WHERE ClaimUserEventId = @UserEventId) IS NOT NULL)
			BEGIN
				WAITFOR DELAY '00:00:00'
			END
		ELSE 
			BEGIN
				UPDATE GiftTable
				SET ClaimUserEventId = @UserEventId
				WHERE GiftId = @GiftId
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
GRANT EXECUTE ON [dbo].[usp_SetGiftClaimStatus] TO PUBLIC AS [dbo]
GO
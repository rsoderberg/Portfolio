CREATE PROCEDURE [dbo].[usp_EditGift]
	@GiftID INT,
	@GiftTitle NVARCHAR(128),
	@GiftDescription NVARCHAR(MAX),
	@GiftPrice DECIMAL(13,3),
	@GiftURL NVARCHAR(MAX)

AS
/**************************************************************************
***************************************************************************
Date:		5/20/2017
Author:		Matt Dougal
Project:	White Elephant
Summary:	This procedure will edit a gift.
Execution Rights granted to -- Public

***************************************************************************
**************************************************************************/
IF 1=0 BEGIN
SET FMTONLY OFF
END
BEGIN
	BEGIN TRANSACTION
	SET NOCOUNT ON;
	

	BEGIN TRY
		-- INPUT GIFT DATA
			BEGIN
			    UPDATE GiftTable
				SET Title = @GiftTitle, Description = @GiftDescription, Price = @GiftPrice, URL = @GiftURL
				WHERE GiftId = @GiftID
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
GRANT EXECUTE ON [dbo].[usp_EditGift] TO PUBLIC AS [dbo]
GO


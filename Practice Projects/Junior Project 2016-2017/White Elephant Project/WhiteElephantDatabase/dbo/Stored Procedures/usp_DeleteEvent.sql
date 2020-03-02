CREATE PROCEDURE [dbo].[usp_DeleteEvent]
	@EventId INT
AS
/**************************************************************************
***************************************************************************
Date:		2/13/2017
Author:		Matt Dougal
Project:	White Elephant
Summary:	This procedure will delete an event from DB
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
	DECLARE @EventNameID int

	BEGIN TRY

		--PROCESS GROUP NAME IF EXISTS
		IF @EventId IS NOT NULL	
			BEGIN
			--SELECT @EventId = FROM Event
			SELECT @EventNameID = ent.EventNameId FROM EventNameTable AS ent JOIN EventTable AS et ON ent.EventNameId = et.EventNameId
			WHERE et.EventId = @EventId
								
					-- DELETE FROM GIFT TABLE WHERE USEREVENTID ASSOCIATED WITH EVENTID
					DELETE GiftTable FROM UserEventTable AS uet JOIN GiftTable AS gt ON uet.UserEventId = gt.SubmitUserEventId
					WHERE uet.EventId = @EventId					
						
					-- DELETE GROUPEVENTTABLE WHERE EVENTID MATCHES
					DELETE  FROM GroupEventTable
					WHERE @EventId = EventId	

					alter table dbo.UserEventTable
					nocheck constraint FK_UserEventTable_EventTable

					-- DELETE USEREVENTTABLE VALUES ASSOCIATED WITH EventId
					DELETE  FROM UserEventTable
					WHERE @EventId = EventId

					alter table dbo.UserEventTable
					check constraint FK_UserEventTable_EventTable

					-- DELETE EVENTTABLE WHERE EVENTID MATCHES
					DELETE  FROM EventTable
					WHERE @EventId = EventId

					-- DELETE EVENTNAMETABLE WHERE EVENTNAMEID MATCHES
					DELETE FROM EventNameTable
					WHERE EventNameId = @EventNameID

					

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
GRANT EXECUTE ON [dbo].[usp_DeleteEvent] TO PUBLIC AS [dbo]
GO

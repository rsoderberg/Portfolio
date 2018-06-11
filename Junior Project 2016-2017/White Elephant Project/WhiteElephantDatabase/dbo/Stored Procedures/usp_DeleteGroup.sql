CREATE PROCEDURE [dbo].[usp_DeleteGroup]
	@GroupId INT
AS
/**************************************************************************
***************************************************************************
Date:		11/19/2016
Author:		Patrick Carlson - Based on example by Matt Dougal
Project:	White Elephant
Summary:	This procedure will delete a group from DB
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
	DECLARE @EventId INT
	BEGIN TRY

		--PROCESS GROUP NAME IF EXISTS
		IF @GroupId IS NOT NULL	
			BEGIN
			--SELECT @EventId = FROM Event
					
					--DELETE GIFTTABLE VALUES ASSOCIATED WITH GROUPID
					DELETE GiftTable
					FROM GroupTable AS GrpTbl JOIN GroupEventTable AS GrpEvtTbl 
						ON GrpTbl.GroupId = GrpEvtTbl.GroupId JOIN EventTable AS EvTbl 
							ON GrpEvtTbl.EventId = EvTbl.EventId  JOIN UserEventTable AS UsEvTbl 
								ON EvTbl.EventId = UsEvTbl.EventId  JOIN GiftTable AS GftTbl 
									ON UsEvTbl.UserEventId = GftTbl.SubmitUserEventId
					WHERE GrpTbl.GroupId = @GroupId

					DELETE UserEventTable
					FROM GroupTable AS GrpTbl JOIN GroupEventTable AS GrpEvtTbl 
						ON GrpTbl.GroupId = GrpEvtTbl.GroupId JOIN EventTable AS EvTbl 
							ON GrpEvtTbl.EventId = EvTbl.EventId  JOIN UserEventTable AS UsEvTbl 
								ON EvTbl.EventId = UsEvTbl.EventId  
					WHERE GrpTbl.GroupId = @GroupId
					
					alter table dbo.EventTable
					nocheck constraint FK_Event_EventName

					DELETE EventNameTable
					FROM GroupTable AS GrpTbl JOIN GroupEventTable AS GrpEvtTbl 
						ON GrpTbl.GroupId = GrpEvtTbl.GroupId JOIN EventTable AS EvTbl 
							ON GrpEvtTbl.EventId = EvTbl.EventId JOIN EventNameTable AS EvNmTbl
								ON EvTbl.EventNameId = EvNmTbl.EventNameId
					WHERE GrpTbl.GroupId = @GroupId	 

					alter table dbo.EventTable
					check constraint FK_Event_EventName

					alter table dbo.GroupEventTable
					nocheck constraint FK_GroupEvent_Event

					DELETE EventTable
					FROM GroupTable AS GrpTbl JOIN GroupEventTable AS GrpEvtTbl 
						ON GrpTbl.GroupId = GrpEvtTbl.GroupId JOIN EventTable AS EvTbl 
							ON GrpEvtTbl.EventId = EvTbl.EventId  
					WHERE GrpTbl.GroupId = @GroupId					

					DELETE GroupEventTable
					FROM GroupTable AS GrpTbl JOIN GroupEventTable AS GrpEvtTbl 
						ON GrpTbl.GroupId = GrpEvtTbl.GroupId 
					WHERE GrpTbl.GroupId = @GroupId

					alter table dbo.GroupEventTable
					check constraint FK_GroupEvent_Event

					alter table dbo.UserGroupTable
					nocheck constraint FK_UserGroupTable_StatusTable

					DELETE StatusTable
					FROM UserGroupTable AS ugt JOIN GroupTable AS gt 
						ON  ugt.GroupId = gt.GroupId JOIN StatusTable AS st
							ON ugt.StatusId = st.StatusId
					WHERE @GroupId = gt.GroupId	

					alter table dbo.UserGroupTable
					check constraint FK_UserGroupTable_StatusTable

					-- DELETE USERGROUPTABLE VALUES ASSOCIATED WITH GROUPNAME
					DELETE UserGroupTable
					FROM UserGroupTable AS ugt JOIN GroupTable AS gt 
						ON  ugt.GroupId = gt.GroupId
					WHERE @GroupId = gt.GroupId						

					-- DELETE GROUPTABLE WHERE GROUPNAME MATCHES
					DELETE GroupTable
					WHERE [GroupId] = @GroupId


--TODO(Patrick): When group deleted, delete event. Need delete event SP
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
GRANT EXECUTE ON [dbo].[usp_DeleteGroup] TO PUBLIC AS [dbo]
GO
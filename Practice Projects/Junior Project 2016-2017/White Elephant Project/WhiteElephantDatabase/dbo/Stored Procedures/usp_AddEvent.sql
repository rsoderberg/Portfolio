CREATE PROCEDURE [dbo].[usp_AddEvent]
	@EventName VARCHAR(128),
	@EventDate DATETIME2(7),
	@MaxPrice DECIMAL(13,3),
	@GroupID INT,
	@UserId VARCHAR(128)
AS
/**************************************************************************
***************************************************************************
Date:		11/19/2016
Author:		Rachel Soderberg
Project:	White Elephant
Summary:	This procedure will add an event name to the database.
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
	DECLARE @EventNameId INT
	DECLARE @EventId INT
	DECLARE @StatusId INT

	BEGIN TRY

		-- PROCESS NAME IF EXISTS
		IF @EventName IS NOT NULL
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

				-- CHECK IF VALUE ALREADY EXISTS
				SELECT @EventNameId = [EventNameId] FROM EventNameTable WHERE [EventName] = @EventName

				-- VALUE NOT FOUND, ADD IT
				IF @EventNameId IS NULL
					BEGIN
						INSERT INTO EventNameTable ([EventName]) VALUES (@EventName)
						SELECT @EventNameId = SCOPE_IDENTITY()
					END

				-- ADD NEW ITEM TO EVENT TABLE
				BEGIN
					INSERT INTO EventTable ([EventNameId], [Date], [MaxPrice])
					VALUES (@EventNameId, @EventDate, @MaxPrice)
					SELECT @EventId = SCOPE_IDENTITY()
				END

				-- ADD EVENT TO GROUP EVENT TABLE
				BEGIN
					INSERT INTO GroupEventTable ([EventId], [GroupId])
					VALUES (@EventId, @GroupId)
					INSERT INTO UserEventTable ([EventId], [UserId], [StatusId]) 
					VALUES (@EventId, @UserId, @StatusId)
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
			  RETURN @EventId
			END
		ELSE
			RETURN 0
END
GRANT EXECUTE ON [dbo].[usp_AddEvent] TO PUBLIC AS [dbo]
GO
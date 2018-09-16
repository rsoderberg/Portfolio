-- Filter out Inventory quantities that are coming from Material Requests that are in "draft" status 9/5/18
IF OBJECT_ID('vMaterialInventory_Requested') IS NOT NULL
BEGIN
	DROP VIEW	dbo.vMaterialInventory_Requested
END
go
CREATE VIEW	dbo.vMaterialInventory_Requested
AS
	SELECT
		Material_ArtifactTypeID = MRAR.ArtifactTypeID
		,Material_ArtifactTypeName = MRAR.ArtifactTypeName
		,Material_QuantityRequested = SUM(ISNULL(MU.MaterialUnits,0))
	FROM
		MaterialRequest MR
		INNER JOIN Artifact MRA ON MRA.ArtifactID = MR.ArtifactID
		INNER JOIN vArtifactRelation MRAR ON MRAR.ArtifactIDParent = MR.ArtifactID
		INNER JOIN MaterialUsage MU ON MU.ArtifactID = MRAR.ArtifactID
	WHERE
		MU.StatusID = 4 -- Requested
		AND
		MR.StatusID != CASE WHEN EXISTS(SELECT 1 FROM Tenant WHERE TenantID = 2) THEN
			1 -- Draft
		ELSE
			-1 -- "Dummy" short-circuits, returns false
		END
	GROUP BY
		MRAR.ArtifactTypeID, MRAR.ArtifactTypeName
go

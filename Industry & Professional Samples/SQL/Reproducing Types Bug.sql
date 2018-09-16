-- Reproducing Types Bug 7/26/18

-- Union using Artifact with two different types (int and varchar)

--SELECT * FROM Artifact
--SELECT * FROM vArtifact
--SELECT * FROM vProjectBudgetItemAvailAssociatedArtifact


SELECT 
	*
INTO zz_ArtifactUnion
FROM (
	SELECT TOP 100
		art.ArtifactID,
		art.ArtifactCode
	FROM
		Artifact art
		INNER JOIN vArtifact vart ON vart.ArtifactID = art.ArtifactID

	UNION
		SELECT TOP 100
			art.ArtifactID,
			vp.Associated_ArtifactID
		FROM
			Artifact art
			INNER JOIN vProjectBudgetItemAvailAssociatedArtifact vp ON vp.Associated_ArtifactCode = art.ArtifactCode
)y


SELECT * FROM zz_ArtifactUnion -- Should error if it reaches the inconsistent type row


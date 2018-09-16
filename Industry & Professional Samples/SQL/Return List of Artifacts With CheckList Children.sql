-- Return a list of Artifacts with CheckList children (ClassID = 3) 7/9/18
SELECT
	ParentArtifactID = parArt.ArtifactID,
	ParentArtifactClass = parArt.ClassID,
	ParentArtifactType = parArt.ArtifactTypeID,
	ChildArtifactID = par.ArtifactID,
	ArtifactName = parArt.ArtifactShortName,
	DisplayName = parType.DisplayName,
	TableName = parClass.TableName
FROM
	Artifact parArt
	INNER JOIN ArtifactClass parClass ON parClass.ClassID = parArt.ClassID
	INNER JOIN ArtifactType parType ON parType.ArtifactTypeID = parArt.ArtifactTypeID
	INNER JOIN ArtifactArtifact par ON par.ArtifactIDParent = parArt.ArtifactID
	INNER JOIN Artifact chiArt ON chiArt.ArtifactID = par.ArtifactID
	INNER JOIN ArtifactClass chiClass ON chiClass.ClassID = chiArt.ClassID
	INNER JOIN ArtifactType chiType ON chiType.ArtifactTypeID = chiArt.ArtifactTypeID

WHERE chiClass.ClassID = 3 -- Checklist
ORDER BY parClass.TableName

-- Properties without associated Acquisitions 8/14/18
SELECT
	ID = prop.ArtifactID,
	ShortName = art.ArtifactShortName
FROM
	Acquisition acq
	INNER JOIN ArtifactArtifact parArt ON parArt.ArtifactIDParent = acq.ArtifactID
	RIGHT JOIN Property prop ON prop.ArtifactID = parArt.ArtifactID
	INNER JOIN Artifact art ON art.ArtifactID = prop.ArtifactID
WHERE acq.ArtifactID IS NULL


SELECT 
	ID = prop.ArtifactID,
	ShortName = art.ArtifactShortName
FROM 
	Property prop
	LEFT JOIN vArtifactRelation rel ON rel.ArtifactID = prop.ArtifactID AND rel.ArtifactClassIDParent = 21
	INNER JOIN Artifact art ON art.ArtifactID = prop.ArtifactID
WHERE
	rel.ArtifactIDParent IS NULL


-- Proof that properties are not a parent artifact of acquisitions 8/14/18
SELECT
	* 
FROM 
	Acquisition acq
	INNER JOIN ArtifactArtifact chiArt ON chiArt.ArtifactID = acq.ArtifactID -- 0 rows

SELECT
	*
FROM
	Property prop
	INNER JOIN ArtifactArtifact chiArt ON chiArt.ArtifactID = prop.ArtifactID -- 899 rows

SELECT
	ID = acq.ArtifactID,
	ChildID = parArt.ArtifactID,
	class.*
FROM
	Acquisition acq
	INNER JOIN ArtifactArtifact parArt ON parArt.ArtifactIDParent = acq.ArtifactID
	INNER JOIN Artifact art ON art.ArtifactID = parArt.ArtifactID
	INNER JOIN ArtifactClass class ON class.ClassID = art.ClassID
WHERE
	class.ClassID = 19 -- 432 Rows


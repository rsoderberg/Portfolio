-- Return list of Documents that are Well Logs (ArtifactTypeID 2014) 7/15/18
SELECT
	ArtifactID = Doc.ArtifactID,
	ArtifactClass = parClass.DisplayName,
	ArtifactType = parType.DisplayName,
	ArtifactName = Doc.ArtifactShortName,
	LongName = Doc.ArtifactName,
	ArtifactCode = Doc.ArtifactCode,
	DocumentType = chiType.DisplayName
FROM
	Artifact Doc
	INNER JOIN ArtifactArtifact DocParent ON DocParent.ArtifactIDParent = Doc.ArtifactID
	INNER JOIN ArtifactClass parClass ON parClass.ClassID = Doc.ClassID
	INNER JOIN ArtifactType parType ON parType.ArtifactTypeID = Doc.ArtifactTypeID
	INNER JOIN Artifact chiArt ON chiArt.ArtifactId  = DocParent.ArtifactID
	INNER JOIN ArtifactType chiType ON chiType.ArtifactTypeID = chiArt.ArtifactTypeID
WHERE
	chiArt.ClassID = 6 -- Document
	AND
	chiArt.ArtifactTypeID = 2014 -- Well Log
ORDER BY parClass.DisplayName, Doc.ArtifactShortName

-- Return list of Agreements (IGA, Lease, Land Agreement) 7/15/18
SELECT
	ArtifactID = Doc.ArtifactID,
	ArtifactClass = parClass.DisplayName,
	ArtifactType = parType.DisplayName,
	ArtifactName = Doc.ArtifactShortName,
	LongName = Doc.ArtifactName,
	ArtifactCode = Doc.ArtifactCode,
	DocumentType = chiType.DisplayName
FROM
	Artifact Doc
	INNER JOIN ArtifactArtifact DocParent ON DocParent.ArtifactIDParent = Doc.ArtifactID
	INNER JOIN ArtifactClass parClass ON parClass.ClassID = Doc.ClassID
	INNER JOIN ArtifactType parType ON parType.ArtifactTypeID = Doc.ArtifactTypeID
	INNER JOIN Artifact chiArt ON chiArt.ArtifactId  = DocParent.ArtifactID
	INNER JOIN ArtifactType chiType ON chiType.ArtifactTypeID = chiArt.ArtifactTypeID
WHERE
	parType.ClassID IN (19, 21, 33) -- Property, Acquisition, Disposition
	AND
	parType.DisplayName IN ('Property', 'Historic Property') -- Filter out other results
	AND
	chiArt.ClassID = 1 -- Agreements
	AND
	chiArt.ArtifactTypeID IN (7000,7006,7007) -- IGA, Lease, Land Agreement
ORDER BY parClass.DisplayName, Doc.ArtifactShortName, chiType.DisplayName

-- Return list of Structures 7/15/18
SELECT
	ArtifactID = Doc.ArtifactID,
	ArtifactClass = parClass.DisplayName,
	ArtifactType = parType.DisplayName,
	ArtifactName = Doc.ArtifactShortName,
	LongName = Doc.ArtifactName,
	ArtifactCode = Doc.ArtifactCode,
	DocumentType = chiType.DisplayName
FROM
	Artifact Doc
	INNER JOIN ArtifactArtifact DocParent ON DocParent.ArtifactIDParent = Doc.ArtifactID
	INNER JOIN ArtifactClass parClass ON parClass.ClassID = Doc.ClassID
	INNER JOIN ArtifactType parType ON parType.ArtifactTypeID = Doc.ArtifactTypeID
	INNER JOIN Artifact chiArt ON chiArt.ArtifactId  = DocParent.ArtifactID
	INNER JOIN ArtifactType chiType ON chiType.ArtifactTypeID = chiArt.ArtifactTypeID
WHERE
	chiArt.ClassID = 10 -- Structure
ORDER BY parClass.DisplayName, Doc.ArtifactShortName

-- Return list of Documents that are Title Policies (ArtifactTypeID 2017) 7/15/18
SELECT
	ArtifactID = Doc.ArtifactID,
	ArtifactClass = parClass.DisplayName,
	ArtifactType = parType.DisplayName,
	ArtifactName = Doc.ArtifactShortName,
	LongName = Doc.ArtifactName,
	ArtifactCode = Doc.ArtifactCode,
	DocumentType = chiType.DisplayName
FROM
	Artifact Doc
	INNER JOIN ArtifactArtifact DocParent ON DocParent.ArtifactIDParent = Doc.ArtifactID
	INNER JOIN ArtifactClass parClass ON parClass.ClassID = Doc.ClassID
	INNER JOIN ArtifactType parType ON parType.ArtifactTypeID = Doc.ArtifactTypeID
	INNER JOIN Artifact chiArt ON chiArt.ArtifactId  = DocParent.ArtifactID
	INNER JOIN ArtifactType chiType ON chiType.ArtifactTypeID = chiArt.ArtifactTypeID
WHERE
	chiArt.ClassID = 6 -- Document
	AND
	chiArt.ArtifactTypeID = 2017 -- Title Policy
ORDER BY parClass.DisplayName, Doc.ArtifactShortName

-- Return list of Documents that are Water Rights (ArtifactTypeID 2015) 7/15/18
SELECT
	ArtifactID = Doc.ArtifactID,
	ArtifactClass = parClass.DisplayName,
	ArtifactType = parType.DisplayName,
	ArtifactName = Doc.ArtifactShortName,
	LongName = Doc.ArtifactName,
	ArtifactCode = Doc.ArtifactCode,
	DocumentType = chiType.DisplayName
FROM
	Artifact Doc
	INNER JOIN ArtifactArtifact DocParent ON DocParent.ArtifactIDParent = Doc.ArtifactID
	INNER JOIN ArtifactClass parClass ON parClass.ClassID = Doc.ClassID
	INNER JOIN ArtifactType parType ON parType.ArtifactTypeID = Doc.ArtifactTypeID
	INNER JOIN Artifact chiArt ON chiArt.ArtifactId  = DocParent.ArtifactID
	INNER JOIN ArtifactType chiType ON chiType.ArtifactTypeID = chiArt.ArtifactTypeID
WHERE
	chiArt.ClassID = 6 -- Document
	AND
	chiArt.ArtifactTypeID = 2015 -- Water Rights
ORDER BY parClass.DisplayName, Doc.ArtifactShortName

-- Return list of Documents that are Surveys (ArtifactTypeID 2010) 7/15/18
SELECT
	ArtifactID = Doc.ArtifactID,
	ArtifactClass = parClass.DisplayName,
	ArtifactType = parType.DisplayName,
	ArtifactName = Doc.ArtifactShortName,
	LongName = Doc.ArtifactName,
	ArtifactCode = Doc.ArtifactCode,
	DocumentType = chiType.DisplayName
FROM
	Artifact Doc
	INNER JOIN ArtifactArtifact DocParent ON DocParent.ArtifactIDParent = Doc.ArtifactID
	INNER JOIN ArtifactClass parClass ON parClass.ClassID = Doc.ClassID
	INNER JOIN ArtifactType parType ON parType.ArtifactTypeID = Doc.ArtifactTypeID
	INNER JOIN Artifact chiArt ON chiArt.ArtifactId  = DocParent.ArtifactID
	INNER JOIN ArtifactType chiType ON chiType.ArtifactTypeID = chiArt.ArtifactTypeID
WHERE
	chiArt.ClassID = 6 -- Document
	AND
	chiArt.ArtifactTypeID = 2010 -- Survey
ORDER BY parClass.DisplayName, Doc.ArtifactShortName

-- Return list of Documents that are Title Reports (ArtifactTypeID 2006) 7/15/18
SELECT
	ArtifactID = Doc.ArtifactID,
	ArtifactClass = parClass.DisplayName,
	ArtifactType = parType.DisplayName,
	ArtifactName = Doc.ArtifactShortName,
	LongName = Doc.ArtifactName,
	ArtifactCode = Doc.ArtifactCode,
	DocumentType = chiType.DisplayName
FROM
	Artifact Doc
	INNER JOIN ArtifactArtifact DocParent ON DocParent.ArtifactIDParent = Doc.ArtifactID
	INNER JOIN ArtifactClass parClass ON parClass.ClassID = Doc.ClassID
	INNER JOIN ArtifactType parType ON parType.ArtifactTypeID = Doc.ArtifactTypeID
	INNER JOIN Artifact chiArt ON chiArt.ArtifactId  = DocParent.ArtifactID
	INNER JOIN ArtifactType chiType ON chiType.ArtifactTypeID = chiArt.ArtifactTypeID
WHERE
	chiArt.ClassID = 6 -- Document
	AND
	chiArt.ArtifactTypeID = 2006 -- Title Report
ORDER BY parClass.DisplayName, Doc.ArtifactShortName

-- Return list of Documents that are Appraisals (ArtifactTypeID 2008) 7/15/18
SELECT
	ArtifactID = Doc.ArtifactID,
	ArtifactClass = parClass.DisplayName,
	ArtifactType = parType.DisplayName,
	ArtifactName = Doc.ArtifactShortName,
	LongName = Doc.ArtifactName,
	ArtifactCode = Doc.ArtifactCode,
	DocumentType = chiType.DisplayName
FROM
	Artifact Doc
	INNER JOIN ArtifactArtifact DocParent ON DocParent.ArtifactIDParent = Doc.ArtifactID
	INNER JOIN ArtifactClass parClass ON parClass.ClassID = Doc.ClassID
	INNER JOIN ArtifactType parType ON parType.ArtifactTypeID = Doc.ArtifactTypeID
	INNER JOIN Artifact chiArt ON chiArt.ArtifactId  = DocParent.ArtifactID
	INNER JOIN ArtifactType chiType ON chiType.ArtifactTypeID = chiArt.ArtifactTypeID
WHERE
	chiArt.ClassID = 6 -- Document
	AND
	chiArt.ArtifactTypeID = 2008 -- Appraisal
ORDER BY parClass.DisplayName, Doc.ArtifactShortName

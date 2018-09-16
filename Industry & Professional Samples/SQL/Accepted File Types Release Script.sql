-- Add AutoCAD to upload options for Existing Surveys 7/27/18
-- Accepted File Types: AutoCAD, JPEG Image, Microsoft Word - 2007/2010, Microsoft Word - before 2007, Portable Document Format, TIFF Image
-- FormatID = 1, 2, 3, 6, 15, 16

-- Final Release Script:
SELECT * FROM FileFormat ff
INNER JOIN FileFormatValidExtension ffve ON ffve.FormatID = ff.FormatID

SELECT * FROM ArtifactTypeDocumentValidFileFormat WHERE ArtifactTypeID = 2010

DELETE
    FROM ArtifactTypeDocumentValidFileFormat 
WHERE
    ArtifactTypeID = 2010

INSERT INTO ArtifactTypeDocumentValidFileFormat
SELECT
    ArtifactTypeID = 2010,
	FormatID = 1
UNION ALL
SELECT
    ArtifactTypeID = 2010,
    FormatID = 2
UNION ALL
SELECT
    ArtifactTypeID = 2010,
    FormatID = 3
UNION ALL
SELECT
    ArtifactTypeID = 2010,
    FormatID = 6
UNION ALL
SELECT
    ArtifactTypeID = 2010,
    FormatID = 15
UNION ALL
SELECT
    ArtifactTypeID = 2010,
    FormatID = 16
GO

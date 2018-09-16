-- 1. Verify the ClassID of a Property
SELECT * FROM ArtifactType WHERE ClassID = 19 -- Property

-- 2. Create a new Property Artifact
INSERT INTO Artifact (ClassID, ArtifactTypeID, EventIDCreate, EventIDChange, LegacyArtifactID, IsActive, ArtifactTypeVersionID)
VALUES (19, 19000, 'FA538998-2298-4066-A132-0260A9824780', 'FA538998-2298-4066-A132-0260A9824780', 805054, 1, NULL)

-- 3. Get the ID of that new Artifact
SELECT MAX(ArtifactID)
FROM Artifact

-- 4. Create a new Property using the new ArtifactID
INSERT INTO Property (ArtifactID, CountAcres, OwnershipTypeID, WorkflowObjectID, ActualClosingDate, TargetAreaID)
VALUES (206381, 5, 1, NULL, '2018-08-16', 40)

-- 5. Test default PropertyStatusID value in Property
SELECT * FROM Property
WHERE ArtifactID = 206381

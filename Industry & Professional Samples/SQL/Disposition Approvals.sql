-- 8/13/18

-- Approval of Sale Price
--	WorkflowRequirementTypeApprovalGroup
--	RequirementID = 2086
--	ArtifactGroupType = 238
--	ArtifactTypeID = 6050

-- SalePrice
--	WorkflowRequirementTypeCustomControl
--	RequirementID = 5602
--	ArtifactTypeID = 8032


-- List of Listing Price Approvals under a Disposition
SELECT *
FROM Disposition disp
	INNER JOIN ArtifactArtifact parArt ON parArt.ArtifactIDParent = disp.ArtifactID -- Disp and children
	INNER JOIN Approval approve ON approve.ArtifactID = parArt.ArtifactID
	INNER JOIN Artifact approvalArt ON approvalArt.ArtifactID = approve.ArtifactID AND approvalArt.ArtifactTypeID = 6049


-- List of Sale Price Approvals under a Disposition
SELECT *
FROM Disposition disp
	INNER JOIN ArtifactArtifact parArt ON parArt.ArtifactIDParent = disp.ArtifactID -- Disp and children
	INNER JOIN Approval approve ON approve.ArtifactID = parArt.ArtifactID
	INNER JOIN Artifact approvalArt ON approvalArt.ArtifactID = approve.ArtifactID AND approvalArt.ArtifactTypeID = 6050

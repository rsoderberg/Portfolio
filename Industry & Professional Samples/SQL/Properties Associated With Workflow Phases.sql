-- Properties associated with Workflow Phases
SELECT
	*
FROM
	Acquisition acq
	INNER JOIN ArtifactArtifact parArt ON parArt.ArtifactIDParent = acq.ArtifactID
	INNER JOIN Property prop ON prop.ArtifactID = parArt.ArtifactID
	INNER JOIN WorkflowInstance inst ON inst.ArtifactID = acq.ArtifactID
	INNER JOIN WorkflowType wfType ON wfType.WorkflowTypeID = inst.WorkflowTypeID
	INNER JOIN WorkflowTypePhase wftPhase ON wftPhase.WorkflowTypePhaseID = inst.WorkflowTypePhaseID AND wftPhase.WorkflowTypeID = wfType.WorkflowTypeID
	INNER JOIN Artifact acqArt ON acqArt.ArtifactID = acq.ArtifactID -- To get Active status
WHERE wfType.WorkflowTypeID = 1 AND wftPhase.WorkflowTypePhaseID = 5 AND acqArt.IsActive = 1 -- Acquisition, Stabilization
-- 413 Properties

SELECT
	*
FROM
	Acquisition acq
	INNER JOIN ArtifactArtifact parArt ON parArt.ArtifactIDParent = acq.ArtifactID
	INNER JOIN Property prop ON prop.ArtifactID = parArt.ArtifactID
	INNER JOIN WorkflowInstance inst ON inst.ArtifactID = acq.ArtifactID
	INNER JOIN WorkflowType wfType ON wfType.WorkflowTypeID = inst.WorkflowTypeID
	INNER JOIN WorkflowTypePhase wftPhase ON wftPhase.WorkflowTypePhaseID = inst.WorkflowTypePhaseID AND wftPhase.WorkflowTypeID = wfType.WorkflowTypeID
	INNER JOIN Artifact acqArt ON acqArt.ArtifactID = acq.ArtifactID -- To get Active status
WHERE wfType.WorkflowTypeID = 1 AND wftPhase.WorkflowTypePhaseID = 6 AND acqArt.IsActive = 1 -- Acquisition, Complete
 -- 18 Properties

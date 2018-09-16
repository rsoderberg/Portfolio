-- Acquisition Current WorkflowPhase 8/30/18
SELECT
	ShortName = acq.Acquisition_ArtifactShortName,
	WFInstID = acq.Acquisition_WorkflowInstID,
	CurrentPhase = stat.CurrentPhaseID,
	CurrentPhaseName = stat.CurrentPhaseName
FROM vAcquisition acq
INNER JOIN vWorkflowInstanceStatus stat ON stat.ArtifactID = acq.ArtifactID

-- Disposition Current WorkflowPhase 8/30/18
SELECT
	ShortName = disp.Disposition_ShortName,
	WFInstID = disp.Disposition_WorkflowInstID,
	CurrentPhase = stat.CurrentPhaseID,
	CurrentPhaseName = stat.CurrentPhaseName
FROM
	vDisposition disp
	INNER JOIN vWorkflowInstanceStatus stat ON stat.ArtifactID = disp.ArtifactID

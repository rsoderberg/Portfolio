-- List of Disposition Requirements that currently have Overrides 8/2/18
SELECT
	WRT.RequirementID,
	C.DisplayName
FROM
	WorkflowRequirementType WRT
	INNER JOIN WorkflowRequirementTypeSecurityRoleAssignment RA ON WRT.RequirementID = RA.RequirementID
	INNER JOIN ArtifactClass C ON C.ClassID = WRT.ClassID
WHERE
	WRT.WorkflowTypeID = 5 -- Disposition
	AND RA.CanManuallyFulfill = 1
GROUP BY
	WRT.RequirementID, C.DisplayName
	
	
-- List of Acquisition Requirements that have Overrides 8/2/18
SELECT
	reqType.RequirementID,
	reqType.RequirementName,
	R.DisplayName
FROM
	WorkflowRequirementType reqType
	INNER JOIN WorkflowRequirementTypeSecurityRoleAssignment RA ON RA.RequirementID = reqType.RequirementID
	INNER JOIN ArtifactClass class ON class.ClassID = reqType.ClassID
	INNER JOIN WorkflowRequirementTypeSecurityRoleAssignment roleAssign ON roleAssign.RequirementID = reqType.RequirementID
	INNER JOIN Role R ON R.RoleID = roleAssign.RoleID
WHERE
	reqType.WorkflowTypeID = 1 -- Acquisition
	AND RA.CanManuallyFulfill = 1
GROUP BY
	reqType.RequirementID,
	reqType.RequirementName,
	R.DisplayName

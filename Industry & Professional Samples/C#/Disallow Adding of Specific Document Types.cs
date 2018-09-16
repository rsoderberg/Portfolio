//(DocumentCollectionViewModel.cs)   
// 7/23/18 RS     
	private const int REQUIREMENTTYPE_DOCUMENT_WELL_LOG = 6150;
	private const int REQUIREMENTTYPE_DOCUMENT_EXISTING_SURVEYS = 6120;


	private List<int> _requirementTypesWithNoUpload;
	private List<int> RequirementTypesWithNoUpload
	{
		get
		{
			if (_requirementTypesWithNoUpload == null)
			{
				_requirementTypesWithNoUpload = new List<int>
				{
					REQUIREMENTTYPE_DOCUMENT_WELL_LOG,
					REQUIREMENTTYPE_DOCUMENT_EXISTING_SURVEYS
				};
			}

			return _requirementTypesWithNoUpload;
		}
	}

	public override bool CanAdd
	{
		get
		{
			if (RequirementTypesWithNoUpload.Contains(_requirementModel.WorkflowInstanceRequirement.RequirementID))
			{
				return false;
			}

			return base.CanAdd;
		}
	}

//(RequirementBaseCollectionViewModel.cs)
	public virtual bool AllowAdd
	{
		get
		{
			if (IsLocked)        //Do not need to check IsReadOnly Because IsLocked does so
			{
				return false;
			}

			if (Requirement.CountMaxAllowed.HasValue && ArtifactCollectionModel.ArtifactModels.Count >= Requirement.CountMaxAllowed.Value)
			{
				return false;
			}

			if (Requirement.RequirementID == REQUIREMENTTYPE_DOCUMENT_WELL_LOG) // Disposition Well Logs
			{
				return false;
			}

			if (Requirement.RequirementID == REQUIREMENTTYPE_DOCUMENT_EXISTING_SURVEYS) // Disposition Existing Surveys
			{
				return false;
			}

			return true;
		}
	}


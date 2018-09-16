//(CreateDispositionViewModel.cs)
// Card #3126 7/7/18 RS - Add existing documents
	List<Document> attachedDocuments = new List<Document>();
	attachedDocuments.AddRange(property.WellLogs);
	attachedDocuments.AddRange(property.StoveCerts);
	attachedDocuments.AddRange(property.SupportingDocs);
	attachedDocuments.AddRange(property.WaterRights);
	attachedDocuments.AddRange(property.Surveys);
	attachedDocuments.AddRange(property.TitlePolicies);

	foreach (var docs in attachedDocuments)
	{
		var attachedDocumentModel = new AttachedDocumentModel(_disposition, docs);
		attachedDocumentModel.Save();
	}

//(Property.cs)
// Card #3126 7/7/18 RS - Carrying over agreements and documents
	private List<Agreement> agreements;
	public List<Agreement> Agreements
	{
		get { return agreements ?? (agreements = GetArtifactsOfClass<Agreement>()); }
	}

	private List<Document> acquisitionDocuments;
	public List<Document> AcquisitionDocuments
	{
		get { return acquisitionDocuments ?? (acquisitionDocuments = RelatedAcquisition.GetArtifactsOfClass<Document>()); }
	}

	private Acquisition _relatedAcquisition;
	public Acquisition RelatedAcquisition
	{
		// 7/12/18 RS - #3126: Avoid NullReferenceException by creating a new acquisition when a related acquisition does not already exist
		get { return _relatedAcquisition = _relatedAcquisition == null ? new Acquisition() : GetParentsOfClass<Acquisition>().FirstOrDefault(); }
	}

	private List<Document> wellLogs;
	public List<Document> WellLogs
	{
		get { return wellLogs ?? (wellLogs = AcquisitionDocuments.Where(well => well.ArtifactTypeID == ArtifactType.DocumentTypeWellLog.ArtifactTypeID).ToList()); }
	}

	private List<Document> stoveCerts;
	public List<Document> StoveCerts
	{
		get { return stoveCerts ?? (stoveCerts = AcquisitionDocuments.Where(stove => stove.ArtifactTypeID == ArtifactType.DocumentTypeDispositionStoveProofOfCertification.ArtifactTypeID).ToList()); }
	}

	private List<Document> supportingDocs;
	public List<Document> SupportingDocs
	{
		get { return supportingDocs ?? (supportingDocs = AcquisitionDocuments.Where(supp => supp.ArtifactTypeID == ArtifactType.DocumentTypeDispositionAdditionalSupportingDocumentation.ArtifactTypeID).ToList()); }
	}

	private List<Document> waterRights;
	public List<Document> WaterRights
	{
		get { return waterRights ?? (waterRights = AcquisitionDocuments.Where(wr => wr.ArtifactTypeID == ArtifactType.DocumentTypeWaterRightsDocumentation.ArtifactTypeID).ToList()); }
	}

	private List<Document> surveyDocs;
	public List<Document> Surveys
	{
		get { return surveyDocs ?? (surveyDocs = AcquisitionDocuments.Where(es => es.ArtifactTypeID == ArtifactType.DocumentTypeSurvey.ArtifactTypeID).ToList()); }
	}

	private List<Document> titlePolicies;
	public List<Document> TitlePolicies
	{
		get { return titlePolicies ?? (titlePolicies = AcquisitionDocuments.Where(es => es.ArtifactTypeID == ArtifactType.DocumentTypeTitlePolicy.ArtifactTypeID).ToList()); }
	}


// RS: 6/22/18 - Card #3123 - Disposition Basics Property Detail pane items
    public class DispositionPropertySummaryViewModel
    {
        public DispositionPropertySummaryViewModel()
        {
        }

        public static DispositionPropertySummaryViewModel GetDispositionPropertySummaryViewModel(int propertyId)
        {
            var prop = HttpRequestStorage.DatabaseEntities.vDispositionProperty.First(dp => dp.ArtifactID == propertyId);

            var map = TerraTrakModelMap.MapConfig.CreateMapper();
            return map.Map<vDispositionProperty, DispositionPropertySummaryViewModel>(prop);
        }

// RS: 6/22/18 - Card #3123 - Disposition Basics Property Detail pane items
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public int ArtifactID { get; set; }
        public decimal? CountAcres { get; set; }
        public string ArtifactCode { get; set; }
        public string AddressStreet { get; set; }
        public string AddressCity { get; set; }
        public string AddressCounty { get; set; }
        public string AddressZip { get; set; }
        public string TargetAreaResolutionCode { get; set; }
        public DateTime? TargetAreaResolutionApprovalDate { get; set; }
        public string TargetAreaName { get; set; }
        public byte OwnershipTypeID { get; set; }
        public string OwnershipTypeName { get; set; }
        public int SiteArtifactID { get; set; }
        public string SiteArtifactName { get; set; }
        public string SiteArtifactCode { get; set; }
        public string TaxLots { get; set; }
        public DateTime? ActualClosingDate { get; set; }
        public int Acquisition_WorkflowInstID { get; set; }
        public byte Acquisition_WorkflowPhaseID { get; set; }

        string _resolution;
        public string Resolution
        {
            get { return _resolution = ($"{TargetAreaResolutionCode} - {TargetAreaResolutionApprovalDate.ToStringDate()}"); }
            set { _targetArea = value; }
        }

        string _targetArea;
        public string TargetArea
        {
            get { return _targetArea = ($"{TargetAreaName} ({TargetAreaResolutionCode}\n - {TargetAreaResolutionApprovalDate.ToStringDate()})"); }
            set { _targetArea = value; }
        }

        string _siteArtifactName;
        public string SiteName
        {
            get
            {
                // Direct user to Site page
                return _siteArtifactName = SitkaRoute<SitesController>.BuildLinkFromExpression(sq =>
                    sq.Details(SiteArtifactID), ($"{SiteArtifactName} ({SiteArtifactCode})"));
            }
            set { _siteArtifactName = value; }
        }

        string _bondMeasure;
        public string BondMeasure
        {
            get { return _bondMeasure; }
            set { _bondMeasure = value == String.Empty ? "non" : value; }
        }

        string _property;
        public string Property
        {
            get { return _property = ($"{FullName} ({ArtifactCode})"); }
            set { _property = value; }
        }

        string _actualCloseDate;
        public string ActualCloseDate
        {
            get { return _actualCloseDate = ActualClosingDate.ToStringDate(); }
            set { _actualCloseDate = value; }
        }

        string _location;
        public string Location
        {
            get { return _location = ($"{AddressStreet} {AddressCity} {AddressZip}"); }
            set { _location = value; }
        }

        string _relatedAcquisition;
        public string RelatedAcquisition
        {
            get
            {
                // Direct user to Related Acquisition page
                return _relatedAcquisition = SitkaRoute<AcquisitionController>.BuildLinkFromExpression(aq =>
                    aq.Phase(Acquisition_WorkflowInstID, Acquisition_WorkflowPhaseID), ($"{ShortName} ({ArtifactCode})"));
            }
            set { _relatedAcquisition = value; }
        }
    }
}

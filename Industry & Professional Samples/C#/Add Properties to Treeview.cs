// 8/29/18 RS: Add Active and Inactive Properties folder to Treeview
        private List<Property> _activeProperties;

        public List<Property> ActiveProperties
        {
            get
            {
                return _activeProperties ?? (_activeProperties = GetArtifactsOfClass<Property>().OrderBy(x => x.ArtifactShortName).Where(y => y.PropertyStatusID == PropertyStatus.Active.ID || y.PropertyStatusID == PropertyStatus.Disposing.ID).ToList());
            }
        }

        private List<Property> _inactiveProperties;
        public List<Property> InactiveProperties
        {
            get
            {
                return _inactiveProperties ?? (_inactiveProperties = GetArtifactsOfClass<Property>().OrderBy(x => x.ArtifactShortName).Where(y => y.PropertyStatusID != PropertyStatus.Active.ID && y.PropertyStatusID != PropertyStatus.Disposing.ID).ToList());
            }
        }
// Card #3197 RS 7/27/18 - Leverage Property Status to update Dispose link
	private int? _propertyStatus;
	public int? PropertyStatus
	{
		get
		{
			if (_propertyStatus == null)
			{
				var prop = HttpRequestStorage.DatabaseEntities.vProperties.FirstOrDefault(ps => ps.Property_ArtifactID == Artifact.ArtifactID);

				if (prop != null)
				{
					_propertyStatus = prop.Property_StatusID;
				}
				else
				{
					_propertyStatus = 0;
				}
			}

			return _propertyStatus;

		}
	}

	private bool _canDispose;
	public bool CanDispose
	{
		get
		{
			_canDispose = PropertyStatus == Models.PropertyStatus.Active.ID;

			return _canDispose;
		}
	}


// Corresponding View:
    <%  if (Model.CanEdit) {%>
		<a class="process edit" href="javascript:void(0);" ng-click="getEditor('<%=SitkaRoute<PropertyController>.BuildUrlFromExpression(c => c.GetPropertyJson(Model.Artifact.ArtifactID)) %>')">edit</a>     
		<div fancybox="popupEditorTemplate" style="display: none;"></div>
	
		<% if (Model.CanDispose) { %>
			<a class="dispose property" href="javascript:TerraMetJS.FancyBox.Open('<%= SitkaRoute<DispositionController>.BuildUrlFromExpression(d => d.CreateWithProperty(Model.Artifact.ArtifactID)) %>')"><img border="0" alt="W3Schools" src="../../Content/img/For%20Sale%20icon.jpg"  width="16" height="16" /> Dispose</a>
		<% } %>
		<% else { %>
			<% if (Model.PropertyStatus == PropertyStatus.Disposing.ID) { %>
				<a class="dispose property" href="<%= Model.UrlForRelatedDisposition %>"><img border="0" alt="W3Schools" src="../../Content/img/For%20Sale%20icon.jpg"  width="16" height="16" /> Disposition in Progress</a>
			<% } %>
			<% if (Model.PropertyStatus == PropertyStatus.Disposed.ID) { %>
				<a class="dispose property" href="<%= Model.UrlForRelatedDisposition %>"><img border="0" alt="W3Schools" src="../../Content/img/For%20Sale%20icon.jpg"  width="16" height="16" /> Disposed</a>
			<% } %>
			<% if (Model.PropertyStatus == PropertyStatus.Split.ID) { %>
				<a class="dispose property"><img border="0" alt="W3Schools" src="../../Content/img/For%20Sale%20icon.jpg"  width="16" height="16" /> Split</a>
			<% } %>
			<% if (Model.PropertyStatus == PropertyStatus.Merged.ID) { %>
				<a class="dispose property"><img border="0" alt="W3Schools" src="../../Content/img/For%20Sale%20icon.jpg"  width="16" height="16" /> Merged</a>
			<% } %>
		<% } %>
    <%  } %>


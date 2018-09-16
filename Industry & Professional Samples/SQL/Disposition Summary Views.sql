-- Main View 9/10/18
IF OBJECT_ID('vDispositionSummary') IS NOT NULL
BEGIN
	DROP VIEW dbo.vDispositionSummary
END
go

CREATE VIEW	dbo.vDispositionSummary
AS
	SELECT
		DispositionArtifactID = D.ArtifactID
		,PropertyArtifactID = D.Property_ArtifactID
		,AccountingCode = D.Disposition_AccountingCode
		,ListingPriceNotes = D.Disposition_ListingPriceNotes
		,ContractCloseDate = D.Disposition_ContractCloseDate
		,AnticipatedCloseDate = D.Disposition_AnticipatedCloseDate
		,DispositionOwnershipTypeID = D.Disposition_OwnershipTypeID
		,DispositionOwnershipType = D.Disposition_OwnershipType
		,DispositionStatusID = D.Disposition_Code
		,DispositionStatus = D.Disposition_IsActive
		,ActualCloseDate = D.Disposition_ActualCloseDate
		,MetroResolutionNumber = D.Disposition_MetroResolutionNumber
		,MetroResolutionApprovalDate = D.Disposition_MetroApprovalDate
		,TargetAreaResolutionNumber = VD.TargetAreaResolutionCode
		,TargetAreaResolutionApprovalDate = VD.TargetAreaResolutionApprovalDate
		,ListingPrice = CASE WHEN listingPriceApproval.DateApproved IS NOT NULL
			THEN D.Disposition_ListingPrice
			ELSE NULL
			END
		,SalePrice = CASE WHEN salePriceApproval.DateApproved IS NOT NULL
			THEN D.Disposition_SalePrice
			ELSE NULL
			END
		,CountAcres = VD.CountAcres
		,AddressStreet = VD.AddressStreet
		,AddressCity = VD.AddressCity
		,AddressZip = VD.AddressZip
		,SiteArtifactID = VD.SiteArtifactID
		,SiteArtifactCode = VD.SiteArtifactCode
		,SiteArtifactName = VD.SiteArtifactName
		,TargetAreaID = VD.TargetAreaID
		,TargetAreaName = VD.TargetAreaName
		,TaxLot = VD.TaxLots
		,BuyerID = DRA.PartyID
		,BuyerName = DRA.PartyName
		,AgPolicyYesNo = DCL.DisplayName
		,EasementsRetained = CASE WHEN ( -- All Easements CheckBoxes are unchecked
			conservationEasements.SelectionID IS NULL
			AND
			agriculturalEasements.SelectionID IS NULL
			AND
			trailEasements.SelectionID IS NULL
			AND
			otherEasements.SelectionID IS NULL
			)
			THEN
				''
			ELSE
				CASE WHEN ( -- All Easements CheckBoxes are "No"
					conservationEasements.SelectionID = 90
					AND
					agriculturalEasements.SelectionID = 90
					AND
					trailEasements.SelectionID = 90
					AND
					otherEasements.SelectionID = 90
				)
				THEN
					'No'
				ELSE
					'Yes'
				END
			END
		,AcquisitionArtifactID = VD.Acquisition_ArtifactID
	FROM 
		vDisposition D
		INNER JOIN vDispositionProperty VD ON VD.ArtifactID = D.Property_ArtifactID
		LEFT JOIN vDispositionRoleAssignments DRA ON DRA.DispositionArtifactID = D.ArtifactID AND DRA.WorkflowRoleID = 1061 -- Buyer
		LEFT JOIN vDispositionCheckList DCL ON DCL.DispositionArtifactID = D.ArtifactID AND DCL.ArtifactTypeID = 4140 -- Ag Policy
		LEFT JOIN vDispositionApprovalOfSalePrice salePriceApproval ON salePriceApproval.DispositionID = D.ArtifactID
		LEFT JOIN vDispositionApprovalOfListingPrice listingPriceApproval ON listingPriceApproval.DispositionID = D.Disposition_ArtifactID
		LEFT JOIN vDispositionCheckListConservationEasements conservationEasements ON conservationEasements.DispositionArtifactID = D.Disposition_ArtifactID
		LEFT JOIN vDispositionCheckListAgriculturalEasements agriculturalEasements ON agriculturalEasements.DispositionArtifactID = D.Disposition_ArtifactID
		LEFT JOIN vDispositionCheckListTrailEasements trailEasements ON trailEasements.DispositionArtifactID = D.Disposition_ArtifactID
		LEFT JOIN vDispositionCheckListOtherEasements otherEasements ON otherEasements.DispositionArtifactID = D.Disposition_ArtifactID
GO

-- Supporting Easements Views 9/10/18

IF OBJECT_ID('vDispositionCheckListConservationEasements') IS NOT NULL
BEGIN
	DROP VIEW dbo.vDispositionCheckListConservationEasements
END
go

CREATE VIEW	dbo.vDispositionCheckListConservationEasements
AS
	SELECT 
		CheckListArtifactID = dispCL.CheckListArtifactID
		,DispositionArtifactID = D.ArtifactID
		,ArtifactTypeID = dispCl.ArtifactTypeID
		,DisplayName = dispCL.DisplayName
		,SelectionID = dispCL.SelectionID
		,OptionalCommentText = dispCL.OptionalCommentText
	FROM 
		Disposition D
		INNER JOIN vArtifactCheckList dispCL ON dispCL.ParentArtifactID = D.ArtifactID
	WHERE
		dispCL.ArtifactTypeID = 4141
GO

IF OBJECT_ID('vDispositionCheckListAgriculturalEasements') IS NOT NULL
BEGIN
	DROP VIEW dbo.vDispositionCheckListAgriculturalEasements
END
go

CREATE VIEW	dbo.vDispositionCheckListAgriculturalEasements
AS
	SELECT 
		CheckListArtifactID = dispCL.CheckListArtifactID
		,DispositionArtifactID = D.ArtifactID
		,ArtifactTypeID = dispCl.ArtifactTypeID
		,DisplayName = dispCL.DisplayName
		,SelectionID = dispCL.SelectionID
		,OptionalCommentText = dispCL.OptionalCommentText
	FROM 
		Disposition D
		INNER JOIN vArtifactCheckList dispCL ON dispCL.ParentArtifactID = D.ArtifactID
	WHERE
		dispCL.ArtifactTypeID = 4142
GO

IF OBJECT_ID('vDispositionCheckListTrailEasements') IS NOT NULL
BEGIN
	DROP VIEW dbo.vDispositionCheckListTrailEasements
END
go

CREATE VIEW	dbo.vDispositionCheckListTrailEasements
AS
	SELECT 
		CheckListArtifactID = dispCL.CheckListArtifactID
		,DispositionArtifactID = D.ArtifactID
		,ArtifactTypeID = dispCl.ArtifactTypeID
		,DisplayName = dispCL.DisplayName
		,SelectionID = dispCL.SelectionID
		,OptionalCommentText = dispCL.OptionalCommentText
	FROM 
		Disposition D
		INNER JOIN vArtifactCheckList dispCL ON dispCL.ParentArtifactID = D.ArtifactID
	WHERE
		dispCL.ArtifactTypeID = 4143
GO

IF OBJECT_ID('vDispositionCheckListOtherEasements') IS NOT NULL
BEGIN
	DROP VIEW dbo.vDispositionCheckListOtherEasements
END
go

CREATE VIEW	dbo.vDispositionCheckListOtherEasements
AS
	SELECT 
		CheckListArtifactID = dispCL.CheckListArtifactID
		,DispositionArtifactID = D.ArtifactID
		,ArtifactTypeID = dispCl.ArtifactTypeID
		,DisplayName = dispCL.DisplayName
		,SelectionID = dispCL.SelectionID
		,OptionalCommentText = dispCL.OptionalCommentText
	FROM 
		Disposition D
		INNER JOIN vArtifactCheckList dispCL ON dispCL.ParentArtifactID = D.ArtifactID
	WHERE
		dispCL.ArtifactTypeID = 4144
GO

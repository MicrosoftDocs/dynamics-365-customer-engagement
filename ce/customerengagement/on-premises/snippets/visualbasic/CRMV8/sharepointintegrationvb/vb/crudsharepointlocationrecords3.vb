' <snippetcrudsharepointlocationrecords3>


 ' Instantiate a SharePoint document location object.
 ' See the Entity Metadata topic in the SDK documentation to determine 
 ' which attributes must be set for each entity.
 Dim spDocLoc As SharePointDocumentLocation =
  New SharePointDocumentLocation With {
   .Name = "Sample SharePoint Document Location",
   .Description = "Sample SharePoint Document Location record",
   .ParentSiteOrLocation = New EntityReference(SharePointSite.EntityLogicalName, _spSiteId),
   .RelativeUrl = "spdocloc",
   .RegardingObjectId = New EntityReference(Account.EntityLogicalName, _account1Id)
  }
 ' Set the Sample SharePoint Site created earlier as the parent site.
 ' Associate this document location instance with the Fourth Coffee
 ' sample account record.

 ' Create a SharePoint document location record named Sample SharePoint Document Location.
 _spDocLocId = _serviceProxy.Create(spDocLoc)

' </snippetcrudsharepointlocationrecords3>
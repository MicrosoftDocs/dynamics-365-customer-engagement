// <snippetcrudsharepointlocationrecords3>


 // Instantiate a SharePoint document location object.
 // See the Entity Metadata topic in the SDK documentation to determine 
 // which attributes must be set for each entity.
 SharePointDocumentLocation spDocLoc = new SharePointDocumentLocation
 {
     Name = "Sample SharePoint Document Location",
     Description = "Sample SharePoint Document Location record",
     
     // Set the Sample SharePoint Site created earlier as the parent site.
     ParentSiteOrLocation = new EntityReference(SharePointSite.EntityLogicalName, _spSiteId),
     RelativeUrl = "spdocloc",

     // Associate this document location instance with the Fourth Coffee
     // sample account record.
     RegardingObjectId = new EntityReference(Account.EntityLogicalName, _account1Id)
 };

 // Create a SharePoint document location record named Sample SharePoint Document Location.
 _spDocLocId = _serviceProxy.Create(spDocLoc);

// </snippetcrudsharepointlocationrecords3>
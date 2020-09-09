// <snippetcrudsharepointlocationrecords2>


 // Instantiate a SharePoint site object.
 // See the Entity Metadata topic in the SDK documentation to determine 
 // which attributes must be set for each entity.
 SharePointSite spSite = new SharePointSite
 {
     Name = "Sample SharePoint Site",
     Description = "Sample SharePoint Site Location record",
     
     // TODO: Change this URL to a valid SharePoint URL.                        
     AbsoluteURL = "https://www.example.com",
 };

 // Create a SharePoint site record named Sample SharePoint Site.
 _spSiteId = _serviceProxy.Create(spSite);

// </snippetcrudsharepointlocationrecords2>
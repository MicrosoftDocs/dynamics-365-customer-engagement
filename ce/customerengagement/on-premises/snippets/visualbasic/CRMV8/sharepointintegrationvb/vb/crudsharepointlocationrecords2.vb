' <snippetcrudsharepointlocationrecords2>


 ' Instantiate a SharePoint site object.
 ' See the Entity Metadata topic in the SDK documentation to determine 
 ' which attributes must be set for each entity.
 Dim spSite As SharePointSite =
  New SharePointSite With {
   .Name = "Sample SharePoint Site",
   .Description = "Sample SharePoint Site Location record",
   .AbsoluteURL = "https://www.example.com"
  }
 ' TODO: Change this URL to a valid SharePoint URL.                        

 ' Create a SharePoint site record named Sample SharePoint Site.
 _spSiteId = _serviceProxy.Create(spSite)

' </snippetcrudsharepointlocationrecords2>
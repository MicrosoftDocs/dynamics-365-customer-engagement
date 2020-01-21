' <snippetcrudsharepointlocationrecords1>


 ' Connect to the Organization service. 
 ' The using statement assures that the service proxy will be properly disposed.
 _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
 Using _serviceProxy
  ' This statement is required to enable early-bound type support.
  _serviceProxy.EnableProxyTypes()

  CreateRequiredRecords()
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
  Console.WriteLine("{0} created.", spSite.Name)
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
  Console.WriteLine("{0} created.", spDocLoc.Name)

  ' Retrieve the SharePoint site and SharePoint document location containing several of its attributes.
  Dim colsSpSite As New ColumnSet("name", "absoluteurl")
  Dim retrievedSpSite As SharePointSite = 
   CType(_serviceProxy.Retrieve(SharePointSite.EntityLogicalName, _spSiteId, colsSpSite), SharePointSite)

  Dim colsSpDocLoc As New ColumnSet("name", "regardingobjectid")
  Dim retrievedSpDocLoc As SharePointDocumentLocation =
   CType(_serviceProxy.Retrieve(SharePointDocumentLocation.EntityLogicalName, _spDocLocId, colsSpDocLoc), SharePointDocumentLocation)
  Console.Write("Retrieved,")

  ' Update the URL of the SharePoint site.
  ' TODO: Change this URL to a valid SharePoint URL.
  retrievedSpSite.AbsoluteURL = "https://www.example.net"
  _serviceProxy.Update(retrievedSpSite)

  ' Update the SharePoint document location to associate it with the 
  ' Northwind Traders sample account.
  retrievedSpDocLoc.RegardingObjectId = New EntityReference(Account.EntityLogicalName, _account2Id)
  _serviceProxy.Update(retrievedSpDocLoc)

  Console.WriteLine(" and updated the records.")

  DeleteRequiredRecords(promptforDelete)
 End Using

' </snippetcrudsharepointlocationrecords1>
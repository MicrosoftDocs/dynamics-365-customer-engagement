' <snippetretrieveabsoluteandsitecollectionurls1>


 ' Connect to the Organization service. 
 ' The using statement assures that the service proxy will be properly disposed.
 _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
 Using _serviceProxy
  ' This statement is required to enable early-bound type support.
  _serviceProxy.EnableProxyTypes()

  CreateRequiredRecords()
  ' Retrieve the absolute URL and the Site Collection URL
  ' of the SharePoint document location record.
  Dim retrieveRequest As RetrieveAbsoluteAndSiteCollectionUrlRequest =
   New RetrieveAbsoluteAndSiteCollectionUrlRequest With {
    .Target = New EntityReference(SharePointDocumentLocation.EntityLogicalName, _spDocLocId)
   }
  Dim retriveResponse As RetrieveAbsoluteAndSiteCollectionUrlResponse =
   CType(_serviceProxy.Execute(retrieveRequest), RetrieveAbsoluteAndSiteCollectionUrlResponse)

  Console.WriteLine("Absolute URL of document location record is '{0}'.", retriveResponse.AbsoluteUrl.ToString())
  Console.WriteLine("Site Collection URL of document location record is '{0}'.", retriveResponse.SiteCollectionUrl.ToString())
  DeleteRequiredRecords(promptforDelete)
 End Using

' </snippetretrieveabsoluteandsitecollectionurls1>
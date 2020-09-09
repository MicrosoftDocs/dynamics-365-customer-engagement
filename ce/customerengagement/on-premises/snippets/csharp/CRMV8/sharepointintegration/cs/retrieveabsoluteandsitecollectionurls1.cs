// <snippetretrieveabsoluteandsitecollectionurls1>


 // Connect to the Organization service. 
 // The using statement assures that the service proxy will be properly disposed.
 using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
 {
     // This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes();

     CreateRequiredRecords();
     // Retrieve the absolute URL and the Site Collection URL
     // of the SharePoint document location record.
     RetrieveAbsoluteAndSiteCollectionUrlRequest retrieveRequest = new RetrieveAbsoluteAndSiteCollectionUrlRequest
     {
         Target = new EntityReference(SharePointDocumentLocation.EntityLogicalName, _spDocLocId)
     };
     RetrieveAbsoluteAndSiteCollectionUrlResponse retriveResponse = (RetrieveAbsoluteAndSiteCollectionUrlResponse)_serviceProxy.Execute(retrieveRequest);

     Console.WriteLine("Absolute URL of document location record is '{0}'.", retriveResponse.AbsoluteUrl.ToString());
     Console.WriteLine("Site Collection URL of document location record is '{0}'.", retriveResponse.SiteCollectionUrl.ToString());
     DeleteRequiredRecords(promptforDelete);
 }

// </snippetretrieveabsoluteandsitecollectionurls1>
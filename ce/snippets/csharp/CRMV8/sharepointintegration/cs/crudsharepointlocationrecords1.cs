// <snippetcrudsharepointlocationrecords1>


 // Connect to the Organization service. 
 // The using statement assures that the service proxy will be properly disposed.
 using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
 {
     // This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes();

     CreateRequiredRecords();
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
     Console.WriteLine("{0} created.", spSite.Name);
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
     Console.WriteLine("{0} created.", spDocLoc.Name);

     // Retrieve the SharePoint site and SharePoint document location containing several of its attributes.
     ColumnSet colsSpSite = new ColumnSet("name", "absoluteurl");
     SharePointSite retrievedSpSite = (SharePointSite)_serviceProxy.Retrieve(SharePointSite.EntityLogicalName, _spSiteId, colsSpSite);

     ColumnSet colsSpDocLoc = new ColumnSet("name", "regardingobjectid");
     SharePointDocumentLocation retrievedSpDocLoc = (SharePointDocumentLocation)_serviceProxy.Retrieve(SharePointDocumentLocation.EntityLogicalName, _spDocLocId, colsSpDocLoc);
     Console.Write("Retrieved,");

     // Update the URL of the SharePoint site.
     // TODO: Change this URL to a valid SharePoint URL.
     retrievedSpSite.AbsoluteURL = "https://www.example.net";
     _serviceProxy.Update(retrievedSpSite);

     // Update the SharePoint document location to associate it with the 
     // Northwind Traders sample account.
     retrievedSpDocLoc.RegardingObjectId = new EntityReference(Account.EntityLogicalName,_account2Id);
     _serviceProxy.Update(retrievedSpDocLoc);

     Console.WriteLine(" and updated the records.");

     DeleteRequiredRecords(promptforDelete);
 }

// </snippetcrudsharepointlocationrecords1>
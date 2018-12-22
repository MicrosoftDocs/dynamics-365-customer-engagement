// <snippetretrieveabsoluteandsitecollectionurls2>


 // Retrieve the absolute URL and the Site Collection URL
 // of the SharePoint document location record.
 RetrieveAbsoluteAndSiteCollectionUrlRequest retrieveRequest = new RetrieveAbsoluteAndSiteCollectionUrlRequest
 {
     Target = new EntityReference(SharePointDocumentLocation.EntityLogicalName, _spDocLocId)
 };
 RetrieveAbsoluteAndSiteCollectionUrlResponse retrieveResponse = (RetrieveAbsoluteAndSiteCollectionUrlResponse)_serviceProxy.Execute(retrieveRequest);

 Console.WriteLine("Absolute URL of document location record is '{0}'.", retrieveResponse.AbsoluteUrl.ToString());
 Console.WriteLine("Site Collection URL of document location record is '{0}'.", retrieveResponse.SiteCollectionUrl.ToString());

// </snippetretrieveabsoluteandsitecollectionurls2>
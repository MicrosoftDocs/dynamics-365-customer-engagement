' <snippetretrieveabsoluteandsitecollectionurls2>


 ' Retrieve the absolute URL and the Site Collection URL
 ' of the SharePoint document location record.
 Dim retrieveRequest As RetrieveAbsoluteAndSiteCollectionUrlRequest =
  New RetrieveAbsoluteAndSiteCollectionUrlRequest With {
   .Target = New EntityReference(SharePointDocumentLocation.EntityLogicalName, _spDocLocId)
  }
 Dim retrieveResponse As RetrieveAbsoluteAndSiteCollectionUrlResponse =
  CType(_serviceProxy.Execute(retrieveRequest), RetrieveAbsoluteAndSiteCollectionUrlResponse)

 Console.WriteLine("Absolute URL of document location record is '{0}'.", retrieveResponse.AbsoluteUrl.ToString())
 Console.WriteLine("Site Collection URL of document location record is '{0}'.", retrieveResponse.SiteCollectionUrl.ToString())

' </snippetretrieveabsoluteandsitecollectionurls2>
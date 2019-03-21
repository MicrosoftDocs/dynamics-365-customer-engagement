// <snippetexportribbonxml1>


 // Connect to the Organization service. 
 // The using statement assures that the service proxy will be properly disposed.
 using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
 {
  // This statement is required to enable early-bound type support.                  
  _serviceProxy.EnableProxyTypes();
  
  //Create export folder for ribbon xml files if not already exist.
  if (!Directory.Exists(exportFolder))
      Directory.CreateDirectory(exportFolder);

  //Retrieve the Application Ribbon
  RetrieveApplicationRibbonRequest appribReq = new RetrieveApplicationRibbonRequest();
  RetrieveApplicationRibbonResponse appribResp = (RetrieveApplicationRibbonResponse)_serviceProxy.Execute(appribReq);

  System.String applicationRibbonPath = Path.GetFullPath(exportFolder + "\\applicationRibbon.xml");
  File.WriteAllBytes(applicationRibbonPath, unzipRibbon(appribResp.CompressedApplicationRibbonXml));
  //Write the path where the file has been saved.
  Console.WriteLine(applicationRibbonPath);
  //Retrieve system Entity Ribbons
  RetrieveEntityRibbonRequest entRibReq = new RetrieveEntityRibbonRequest() { RibbonLocationFilter = RibbonLocationFilters.All };

  foreach (System.String entityName in entitiesWithRibbons)
  {
   entRibReq.EntityName = entityName;
   RetrieveEntityRibbonResponse entRibResp = (RetrieveEntityRibbonResponse)_serviceProxy.Execute(entRibReq);

   System.String entityRibbonPath = Path.GetFullPath(exportFolder + "\\" + entityName + "Ribbon.xml");
   File.WriteAllBytes(entityRibbonPath, unzipRibbon(entRibResp.CompressedEntityXml));
   //Write the path where the file has been saved.
   Console.WriteLine(entityRibbonPath);
  }

  //Check for custom entities
  RetrieveAllEntitiesRequest raer = new RetrieveAllEntitiesRequest() { EntityFilters = EntityFilters.Entity };

  RetrieveAllEntitiesResponse resp = (RetrieveAllEntitiesResponse)_serviceProxy.Execute(raer);

  foreach (EntityMetadata em in resp.EntityMetadata)
  {
   if (em.IsCustomEntity == true && em.IsIntersect == false)
   {
    entRibReq.EntityName = em.LogicalName;
    RetrieveEntityRibbonResponse entRibResp = (RetrieveEntityRibbonResponse)_serviceProxy.Execute(entRibReq);

    System.String entityRibbonPath = Path.GetFullPath(exportFolder + "\\" + em.LogicalName + "Ribbon.xml");
    File.WriteAllBytes(entityRibbonPath, unzipRibbon(entRibResp.CompressedEntityXml));
    //Write the path where the file has been saved.
    Console.WriteLine(entityRibbonPath);
   }
  }
 }

// </snippetexportribbonxml1>
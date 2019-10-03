// <snippetexportribbonxml5>


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

// </snippetexportribbonxml5>
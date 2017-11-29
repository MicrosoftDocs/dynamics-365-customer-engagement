// <snippetexportribbonxml4>


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

// </snippetexportribbonxml4>
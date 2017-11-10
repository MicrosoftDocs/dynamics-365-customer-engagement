' <snippetexportribbonxml4>


 'Retrieve system Entity Ribbons
 Dim entRibReq As New RetrieveEntityRibbonRequest() With {.RibbonLocationFilter = RibbonLocationFilters.All}

 For Each entityName As String In entitiesWithRibbons
  entRibReq.EntityName = entityName
  Dim entRibResp As RetrieveEntityRibbonResponse = CType(_serviceProxy.Execute(entRibReq), RetrieveEntityRibbonResponse)

  Dim entityRibbonPath As String = Path.GetFullPath(exportFolder &amp; "\" &amp; entityName &amp; "Ribbon.xml")
  File.WriteAllBytes(entityRibbonPath, unzipRibbon(entRibResp.CompressedEntityXml))
  'Write the path where the file has been saved.
  Console.WriteLine(entityRibbonPath)
 Next entityName

' </snippetexportribbonxml4>
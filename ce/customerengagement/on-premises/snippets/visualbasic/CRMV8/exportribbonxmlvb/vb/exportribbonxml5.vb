' <snippetexportribbonxml5>


  'Check for custom entities
  Dim raer As New RetrieveAllEntitiesRequest() With {.EntityFilters = EntityFilters.Entity}

  Dim resp As RetrieveAllEntitiesResponse = CType(_serviceProxy.Execute(raer), RetrieveAllEntitiesResponse)

  For Each em As EntityMetadata In resp.EntityMetadata
   If em.IsCustomEntity = True AndAlso em.IsIntersect = False Then
    entRibReq.EntityName = em.LogicalName
    Dim entRibResp As RetrieveEntityRibbonResponse = CType(_serviceProxy.Execute(entRibReq), RetrieveEntityRibbonResponse)

    Dim entityRibbonPath As String = Path.GetFullPath(exportFolder &amp; "\" &amp; em.LogicalName &amp; "Ribbon.xml")
    File.WriteAllBytes(entityRibbonPath, unzipRibbon(entRibResp.CompressedEntityXml))
    'Write the path where the file has been saved.
    Console.WriteLine(entityRibbonPath)
   End If
  Next em
 End Using

' </snippetexportribbonxml5>
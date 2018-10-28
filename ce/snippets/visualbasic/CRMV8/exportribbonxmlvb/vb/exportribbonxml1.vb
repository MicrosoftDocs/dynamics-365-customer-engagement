' <snippetexportribbonxml1>


 ' Connect to the Organization service. 
 ' The using statement assures that the service proxy will be properly disposed.
             _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
 Using _serviceProxy
  ' This statement is required to enable early-bound type support.                  
  _serviceProxy.EnableProxyTypes()

  'Create export folder for ribbon xml files if not already exist.
  If Not Directory.Exists(exportFolder) Then
      Directory.CreateDirectory(exportFolder)
  End If

  'Retrieve the Application Ribbon
  Dim appribReq As New RetrieveApplicationRibbonRequest()
  Dim appribResp As RetrieveApplicationRibbonResponse = CType(_serviceProxy.Execute(appribReq), RetrieveApplicationRibbonResponse)

  Dim applicationRibbonPath As String = Path.GetFullPath(exportFolder &amp; "\applicationRibbon.xml")
  File.WriteAllBytes(applicationRibbonPath, unzipRibbon(appribResp.CompressedApplicationRibbonXml))
  'Write the path where the file has been saved.
  Console.WriteLine(applicationRibbonPath)
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

' </snippetexportribbonxml1>
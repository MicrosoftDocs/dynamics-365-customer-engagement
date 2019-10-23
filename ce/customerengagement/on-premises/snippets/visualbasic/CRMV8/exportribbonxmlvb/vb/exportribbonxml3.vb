' <snippetexportribbonxml3>


 'Retrieve the Application Ribbon
 Dim appribReq As New RetrieveApplicationRibbonRequest()
 Dim appribResp As RetrieveApplicationRibbonResponse = CType(_serviceProxy.Execute(appribReq), RetrieveApplicationRibbonResponse)

 Dim applicationRibbonPath As String = Path.GetFullPath(exportFolder &amp; "\applicationRibbon.xml")
 File.WriteAllBytes(applicationRibbonPath, unzipRibbon(appribResp.CompressedApplicationRibbonXml))

' </snippetexportribbonxml3>
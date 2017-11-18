// <snippetexportribbonxml3>


 //Retrieve the Appliation Ribbon
 RetrieveApplicationRibbonRequest appribReq = new RetrieveApplicationRibbonRequest();
 RetrieveApplicationRibbonResponse appribResp = (RetrieveApplicationRibbonResponse)_serviceProxy.Execute(appribReq);

 System.String applicationRibbonPath = Path.GetFullPath(exportFolder + "\\applicationRibbon.xml");
 File.WriteAllBytes(applicationRibbonPath, unzipRibbon(appribResp.CompressedApplicationRibbonXml));

// </snippetexportribbonxml3>
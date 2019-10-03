// <snippetworkwithsolutions9>


 // Monitor import success
 byte[] fileBytesWithMonitoring = File.ReadAllBytes(ManagedSolutionLocation);

 ImportSolutionRequest impSolReqWithMonitoring = new ImportSolutionRequest()
 {
     CustomizationFile = fileBytes,
     ImportJobId = Guid.NewGuid()
 };
 
 _serviceProxy.Execute(impSolReqWithMonitoring);
 Console.WriteLine("Imported Solution with Monitoring from {0}", ManagedSolutionLocation);

 ImportJob job = (ImportJob)_serviceProxy.Retrieve(ImportJob.EntityLogicalName, impSolReqWithMonitoring.ImportJobId, new ColumnSet(new System.String[] { "data", "solutionname" }));
 

 System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
 doc.LoadXml(job.Data);

 String ImportedSolutionName = doc.SelectSingleNode("//solutionManifest/UniqueName").InnerText;
 String SolutionImportResult = doc.SelectSingleNode("//solutionManifest/result/@result").Value;

 Console.WriteLine("Report from the ImportJob data");
 Console.WriteLine("Solution Unique name: {0}", ImportedSolutionName);
 Console.WriteLine("Solution Import Result: {0}", SolutionImportResult);
 Console.WriteLine("");

 // This code displays the results for Global Option sets installed as part of a solution.

 System.Xml.XmlNodeList optionSets = doc.SelectNodes("//optionSets/optionSet");
 foreach (System.Xml.XmlNode node in optionSets)
 {
     string OptionSetName = node.Attributes["LocalizedName"].Value;
     string result = node.FirstChild.Attributes["result"].Value;

     if (result == "success")
     {
         Console.WriteLine("{0} result: {1}",OptionSetName, result);
     }
     else
     {
         string errorCode = node.FirstChild.Attributes["errorcode"].Value;
         string errorText = node.FirstChild.Attributes["errortext"].Value;

         Console.WriteLine("{0} result: {1} Code: {2} Description: {3}",OptionSetName, result, errorCode, errorText);
     }
 }

// </snippetworkwithsolutions9>
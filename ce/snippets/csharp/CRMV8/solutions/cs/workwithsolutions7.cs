// <snippetworkwithsolutions7>


 // Export or package a solution
 //Export an a solution
 
 ExportSolutionRequest exportSolutionRequest = new ExportSolutionRequest();
 exportSolutionRequest.Managed = false;
 exportSolutionRequest.SolutionName = solution.UniqueName;

 ExportSolutionResponse exportSolutionResponse = (ExportSolutionResponse)_serviceProxy.Execute(exportSolutionRequest);

 byte[] exportXml = exportSolutionResponse.ExportSolutionFile;
 string filename = solution.UniqueName + ".zip";
 File.WriteAllBytes(outputDir + filename, exportXml);

 Console.WriteLine("Solution exported to {0}.", outputDir + filename);

// </snippetworkwithsolutions7>
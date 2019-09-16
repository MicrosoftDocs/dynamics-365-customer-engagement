// <snippetworkwithsolutions8>


 // Install or Upgrade a Solution                  
 
 byte[] fileBytes = File.ReadAllBytes(ManagedSolutionLocation);

 ImportSolutionRequest impSolReq = new ImportSolutionRequest()
 {
     CustomizationFile = fileBytes
 };

 _serviceProxy.Execute(impSolReq);

 Console.WriteLine("Imported Solution from {0}", ManagedSolutionLocation);

// </snippetworkwithsolutions8>
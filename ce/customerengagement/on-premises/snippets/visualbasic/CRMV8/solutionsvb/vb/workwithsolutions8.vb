' <snippetworkwithsolutions8>


 ' Install or Upgrade a Solution                  

 Dim fileBytes() As Byte = File.ReadAllBytes(ManagedSolutionLocation)

 Dim impSolReq As New ImportSolutionRequest() With {
  .CustomizationFile = fileBytes
 }

 _serviceProxy.Execute(impSolReq)

 Console.WriteLine("Imported Solution from {0}", ManagedSolutionLocation)

' </snippetworkwithsolutions8>
' <snippetworkwithsolutions9>


 ' Monitor import success
 Dim fileBytesWithMonitoring() As Byte = File.ReadAllBytes(ManagedSolutionLocation)

 Dim impSolReqWithMonitoring As New ImportSolutionRequest() With {
  .CustomizationFile = fileBytes,
  .ImportJobId = Guid.NewGuid()
 }

 _serviceProxy.Execute(impSolReqWithMonitoring)
 Console.WriteLine("Imported Solution with Monitoring from {0}", ManagedSolutionLocation)

 Dim job As ImportJob =
  CType(_serviceProxy.Retrieve(ImportJob.EntityLogicalName,
                               impSolReqWithMonitoring.ImportJobId,
                               New ColumnSet(New String() {"data", "solutionname"})), 
                              ImportJob)


 Dim doc As New System.Xml.XmlDocument()
 doc.LoadXml(job.Data)

 Dim ImportedSolutionName As String = doc.SelectSingleNode("//solutionManifest/UniqueName").InnerText
 Dim SolutionImportResult As String = doc.SelectSingleNode("//solutionManifest/result/@result").Value

 Console.WriteLine("Report from the ImportJob data")
 Console.WriteLine("Solution Unique name: {0}", ImportedSolutionName)
 Console.WriteLine("Solution Import Result: {0}", SolutionImportResult)
 Console.WriteLine("")

 'This code displays the results for Global Option sets installed as part of a solution.
 Dim optionSets As System.Xml.XmlNodeList = doc.SelectNodes("//optionSets/optionSet")
 For Each node As System.Xml.XmlNode In optionSets
  Dim OptionSetName As String = node.Attributes("LocalizedName").Value
  Dim result As String = node.FirstChild.Attributes("result").Value

  If result = "success" Then
   Console.WriteLine("{0} result: {1}", OptionSetName, result)
  Else
   Dim errorCode As String = node.FirstChild.Attributes("errorcode").Value
   Dim errorText As String = node.FirstChild.Attributes("errortext").Value

   Console.WriteLine("{0} result: {1} Code: {2} Description: {3}", OptionSetName, result, errorCode, errorText)
  End If
 Next node

' </snippetworkwithsolutions9>
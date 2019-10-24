' <snippetworkwithsolutions7>


 ' Export or package a solution
 'Export an a solution
 Dim outputDir As String = "C:\temp\"

 Dim exportSolutionRequest As New ExportSolutionRequest()
 exportSolutionRequest.Managed = False
 exportSolutionRequest.SolutionName = solution.UniqueName

 Dim exportSolutionResponse As ExportSolutionResponse =
  CType(_serviceProxy.Execute(exportSolutionRequest), ExportSolutionResponse)

 Dim exportXml() As Byte = exportSolutionResponse.ExportSolutionFile
 Dim filename As String = solution.UniqueName &amp; ".zip"
 File.WriteAllBytes(outputDir &amp; filename, exportXml)

 Console.WriteLine("Solution exported to {0}.", outputDir &amp; filename)

' </snippetworkwithsolutions7>
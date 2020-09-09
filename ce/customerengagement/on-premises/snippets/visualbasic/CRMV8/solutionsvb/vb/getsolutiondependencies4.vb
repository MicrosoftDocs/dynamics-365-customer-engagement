' <snippetgetsolutiondependencies4>


 Dim exportRequest As ExportSolutionRequest =
  New ExportSolutionRequest With {
   .Managed = True,
   .SolutionName = _primarySolutionName
  }
 Dim exportResponse As ExportSolutionResponse =
  CType(_serviceProxy.Execute(exportRequest), ExportSolutionResponse)

' </snippetgetsolutiondependencies4>
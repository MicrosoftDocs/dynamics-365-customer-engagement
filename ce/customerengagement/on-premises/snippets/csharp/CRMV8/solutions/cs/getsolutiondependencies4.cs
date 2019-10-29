// <snippetgetsolutiondependencies4>


 ExportSolutionRequest exportRequest = new ExportSolutionRequest
 {
     Managed = true,
     SolutionName = _primarySolutionName
 };
 ExportSolutionResponse exportResponse =
     (ExportSolutionResponse)_serviceProxy.Execute(exportRequest);

// </snippetgetsolutiondependencies4>
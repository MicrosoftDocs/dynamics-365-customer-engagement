' <snippetgetsolutiondependencies5>


 Dim deleteOptionSetRequest As DeleteOptionSetRequest =
  New DeleteOptionSetRequest With {
   .Name = _globalOptionSetName
  }
 _serviceProxy.Execute(deleteOptionSetRequest)

' </snippetgetsolutiondependencies5>
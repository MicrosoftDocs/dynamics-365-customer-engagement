' <snippetworkwithglobaloptionsets.deleteoptionsetrequest>


 Dim deleteRequest As DeleteOptionSetRequest =
  New DeleteOptionSetRequest With {
   .Name = _globalOptionSetName
  }

 _serviceProxy.Execute(deleteRequest)

' </snippetworkwithglobaloptionsets.deleteoptionsetrequest>
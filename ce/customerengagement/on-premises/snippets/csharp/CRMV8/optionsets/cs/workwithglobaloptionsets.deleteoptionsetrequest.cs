// <snippetworkwithglobaloptionsets.deleteoptionsetrequest>


 DeleteOptionSetRequest deleteRequest = new DeleteOptionSetRequest
 {
     Name = _globalOptionSetName
 };

 _serviceProxy.Execute(deleteRequest);

// </snippetworkwithglobaloptionsets.deleteoptionsetrequest>
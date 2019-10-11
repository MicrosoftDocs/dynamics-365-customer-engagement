// <snippetcreateupdateentitymetadata10>


 DeleteEntityRequest request = new DeleteEntityRequest()
 {
  LogicalName = _customEntityName,
 };
 _serviceProxy.Execute(request);

// </snippetcreateupdateentitymetadata10>
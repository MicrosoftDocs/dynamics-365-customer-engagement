// <snippetgetmetadatachanges>


 protected RetrieveMetadataChangesResponse getMetadataChanges(
  EntityQueryExpression entityQueryExpression,
  String clientVersionStamp,
  DeletedMetadataFilters deletedMetadataFilter)
 {
  RetrieveMetadataChangesRequest retrieveMetadataChangesRequest = new RetrieveMetadataChangesRequest()
  {
   Query = entityQueryExpression,
   ClientVersionStamp = clientVersionStamp,
   DeletedMetadataFilters = deletedMetadataFilter
  };

  return (RetrieveMetadataChangesResponse)_service.Execute(retrieveMetadataChangesRequest);

 }

// </snippetgetmetadatachanges>
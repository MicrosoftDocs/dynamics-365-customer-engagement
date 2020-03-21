' <snippetgetmetadatachanges>


 Protected Function getMetadataChanges(ByVal entityQueryExpression_Renamed As EntityQueryExpression,
                                       ByVal clientVersionStamp As String,
                                       ByVal deletedMetadataFilter As DeletedMetadataFilters) As RetrieveMetadataChangesResponse
     Dim retrieveMetadataChangesRequest_Renamed As New RetrieveMetadataChangesRequest() With
         {
             .Query = entityQueryExpression_Renamed,
             .ClientVersionStamp = clientVersionStamp,
             .DeletedMetadataFilters = deletedMetadataFilter
         }

     Return CType(_service.Execute(retrieveMetadataChangesRequest_Renamed), RetrieveMetadataChangesResponse)

 End Function

' </snippetgetmetadatachanges>
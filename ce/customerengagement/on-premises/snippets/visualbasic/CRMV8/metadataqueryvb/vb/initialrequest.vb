' <snippetinitialrequest>


 'An entity query expression to combine the filter expressions and property expressions for the query.
                   Dim entityQueryExpression_Renamed As New EntityQueryExpression() With
                       {
                           .Criteria = EntityFilter,
                           .Properties = EntityProperties,
                           .AttributeQuery = New AttributeQueryExpression() With
                                             {
                                                 .Criteria = AttributeFilter,
                                                 .Properties = AttributeProperties
                                             },
                           .LabelQuery = labelQuery
                       }

 'Retrieve the metadata for the query without a ClientVersionStamp
                   Dim initialRequest As RetrieveMetadataChangesResponse =
                       getMetadataChanges(entityQueryExpression_Renamed, Nothing, DeletedMetadataFilters.OptionSet)

' </snippetinitialrequest>
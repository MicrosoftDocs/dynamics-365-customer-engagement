' <snippetupdateoptionlabellist>


 Protected Function updateOptionLabelList(ByVal entityQueryExpression_Renamed As EntityQueryExpression,
                                          ByVal clientVersionStamp As String) As String
     'Retrieve metadata changes and add them to the cache
     Dim updateResponse As RetrieveMetadataChangesResponse
     Try
         updateResponse = getMetadataChanges(entityQueryExpression_Renamed, clientVersionStamp, DeletedMetadataFilters.OptionSet)
         addOptionLabelsToCache(updateResponse.EntityMetadata, True)
         removeOptionLabelsFromCache(updateResponse.DeletedMetadata, True)

     Catch ex As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
         ' Check for ErrorCodes.ExpiredVersionStamp (0x80044352)
         ' Will occur when the timestamp exceeds the Organization.ExpireSubscriptionsInDays value, which is 90 by default.
         'INSTANT VB TODO TASK: There is no VB equivalent to 'unchecked' in this context:
         If ex.Detail.ErrorCode = CInt(&amp;H80044352) Then
             'reinitialize cache
             _optionLabelList.Clear()

             updateResponse = getMetadataChanges(entityQueryExpression_Renamed, Nothing, DeletedMetadataFilters.OptionSet)
             'Add them to the cache and display the changes
             addOptionLabelsToCache(updateResponse.EntityMetadata, True)

         Else
             Throw ex
         End If

     End Try
     Return updateResponse.ServerVersionStamp
 End Function

' </snippetupdateoptionlabellist>
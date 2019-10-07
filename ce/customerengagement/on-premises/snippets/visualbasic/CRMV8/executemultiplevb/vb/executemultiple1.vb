' <snippetexecutemultiple1>


 ' Get a reference to the organization service.
 _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)

 Using _serviceProxy
     ' Enable early-bound type support to add/update entity records required for this sample.
     _serviceProxy.EnableProxyTypes()

     '#Region "Execute Multiple with Results"
     ' Create an ExecuteMultipleRequest object.
     ' Assign settings that define execution behavior: continue on error, return responses.
     ' Create an empty organization request collection.
     requestWithResults = New ExecuteMultipleRequest() With
         {
             .Settings = New ExecuteMultipleSettings() With
                         {
                             .ContinueOnError = False,
                             .ReturnResponses = True
                         },
             .Requests = New OrganizationRequestCollection()
         }

     ' Create several (local, in memory) entities in a collection. 
     Dim input As EntityCollection = GetCollectionOfEntitiesToCreate()

     ' Add a CreateRequest for each entity to the request collection.
     For Each entity In input.Entities
         Dim createRequest_Renamed As CreateRequest = New CreateRequest With {.Target = entity}
         requestWithResults.Requests.Add(createRequest_Renamed)
     Next entity

     ' Execute all the requests in the request collection using a single web method call.
     Dim responseWithResults As ExecuteMultipleResponse =
         CType(_serviceProxy.Execute(requestWithResults), ExecuteMultipleResponse)

     ' Display the results returned in the responses.
     For Each responseItem In responseWithResults.Responses

         If responseItem.Response IsNot Nothing Then
             ' A valid response.
             DisplayResponse(requestWithResults.Requests(responseItem.RequestIndex),
                             responseItem.Response)

         ElseIf responseItem.Fault IsNot Nothing Then
             ' An error has occurred.
             DisplayFault(requestWithResults.Requests(responseItem.RequestIndex),
                          responseItem.RequestIndex, responseItem.Fault)
         End If
     Next responseItem

' </snippetexecutemultiple1>
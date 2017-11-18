' <snippetuserqueryandsavedquery1>


 ' Connect to the Organization service. 
 ' The using statement assures that the service proxy will be properly disposed.
 _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
 Using _serviceProxy
     ' This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes()

     CreateRequiredRecords()

     '					#Region "Validate saved query"

     ' Create the request
     Dim validateRequest As New ValidateSavedQueryRequest() With
         {
             .FetchXml = _savedQuery.FetchXml,
             .QueryType = _savedQuery.QueryType.Value
         }

     ' Send the request
     Console.WriteLine("  Validating Saved Query")
     Try
         ' executing the request will throw an exception if the fetch xml is invalid
         Dim validateResponse = CType(_serviceProxy.Execute(validateRequest), 
             ValidateSavedQueryResponse)
         Console.WriteLine("  Saved Query validated successfully")
     Catch e1 As Exception
         Console.WriteLine("  Invalid Saved Query")
         Throw
     End Try

     '					#End Region

     '					#Region "Execute saved query"

     ' Create the request
     Dim executeSavedQueryRequest As New ExecuteByIdSavedQueryRequest() With
         {
             .EntityId = _savedQuery.Id
         }

     ' Execute the request
     Console.WriteLine("  Executing Saved Query")
     Dim executeSavedQueryResponse As ExecuteByIdSavedQueryResponse =
         CType(_serviceProxy.Execute(executeSavedQueryRequest), 
             ExecuteByIdSavedQueryResponse)

     ' Check results
     If String.IsNullOrEmpty(executeSavedQueryResponse.String) Then
         Throw New Exception("Saved Query did not return any results")
     End If

     PrintResults(executeSavedQueryResponse.String)
     '					#End Region

     '					#Region "Execute user query"

     ' Create the request
     Dim executeUserQuery As New ExecuteByIdUserQueryRequest() With
         {
             .EntityId = _userQuery.ToEntityReference()
         }

     ' Send the request
     Console.WriteLine("  Executing User Query")
     Dim executeUserQueryResponse As ExecuteByIdUserQueryResponse =
         CType(_serviceProxy.Execute(executeUserQuery), 
             ExecuteByIdUserQueryResponse)
     If String.IsNullOrEmpty(executeUserQueryResponse.String) Then
         Throw New Exception("User Query did not return any results")
     End If

     ' validate results
     PrintResults(executeUserQueryResponse.String)

     '					#End Region

     DeleteRequiredRecords(promptforDelete)
 End Using

' </snippetuserqueryandsavedquery1>
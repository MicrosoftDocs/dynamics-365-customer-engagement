' <snippetbulkdetectduplicates1>


 ' Connect to the Organization service. 
 ' The using statement assures that the service proxy will be properly disposed.
 _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
 Using _serviceProxy
     ' This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes()

     CreateRequiredRecords()

     ' Create the BulkDetectDuplicatesRequest object
     Console.WriteLine("  Creating the BulkDetectDuplicatesRequest object")
     Dim request As New BulkDetectDuplicatesRequest() With
         {
             .JobName = "Detect Duplicate Accounts",
             .Query = New QueryExpression() With
                      {
                          .EntityName = Account.EntityLogicalName,
                          .ColumnSet = New ColumnSet(True)
                      },
             .RecurrencePattern = String.Empty,
             .RecurrenceStartTime = Date.Now,
             .ToRecipients = New Guid() {},
             .CCRecipients = New Guid() {}
         }

     ' Execute the request
     Console.WriteLine("  Executing BulkDetectDuplicatesRequest")
     _response = CType(_serviceProxy.Execute(request), 
         BulkDetectDuplicatesResponse)

     '					#Region "check success"

     Console.WriteLine("  Waiting for job to complete...")
     WaitForAsyncJobToFinish(_response.JobId, 120)

     Dim query As New QueryByAttribute() With
         {
             .ColumnSet = New ColumnSet(True),
             .EntityName = "duplicaterecord"
         }
     query.Attributes.Add("asyncoperationid")
     query.Values.Add(_response.JobId)
     Dim results As EntityCollection = _serviceProxy.RetrieveMultiple(query)

     ' check to make sure each id is found in the collection
     Dim duplicateIds = results.Entities.Select(Function(entity) (CType(entity, 
                                                                  DuplicateRecord)).BaseRecordId.Id)
     For Each id In _duplicateAccounts.Select(Function(account) account.Id)
         If Not duplicateIds.Contains(id) Then
             Throw New Exception(String.Format("Account with ID {0} was not detected as a duplicate", id))
         End If
     Next id
     Console.WriteLine("  All accounts detected as duplicates successfully")

     '					#End Region

     Console.WriteLine()

     DeleteRequiredRecords(promptforDelete)
 End Using

' </snippetbulkdetectduplicates1>
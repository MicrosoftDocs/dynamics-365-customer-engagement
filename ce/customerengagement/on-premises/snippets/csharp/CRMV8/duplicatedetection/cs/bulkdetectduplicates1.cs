// <snippetbulkdetectduplicates1>


 // Connect to the Organization service. 
 // The using statement assures that the service proxy will be properly disposed.
 using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,
                                                      serverConfig.Credentials, serverConfig.DeviceCredentials))
 {
     // This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes();

     CreateRequiredRecords();

     // Create the BulkDetectDuplicatesRequest object
     Console.WriteLine("  Creating the BulkDetectDuplicatesRequest object");
     BulkDetectDuplicatesRequest request = new BulkDetectDuplicatesRequest()
     {
         JobName = "Detect Duplicate Accounts",
         Query = new QueryExpression()
         {
             EntityName = Account.EntityLogicalName,
             ColumnSet = new ColumnSet(true)
         },
         RecurrencePattern = String.Empty,
         RecurrenceStartTime = DateTime.Now,
         ToRecipients = new Guid[0],
         CCRecipients = new Guid[0]
     };

     // Execute the request
     Console.WriteLine("  Executing BulkDetectDuplicatesRequest");
     _response = (BulkDetectDuplicatesResponse)_serviceProxy
         .Execute(request);

     #region check success

     Console.WriteLine("  Waiting for job to complete...");
     WaitForAsyncJobToFinish(_response.JobId, 120);

     QueryByAttribute query = new QueryByAttribute()
     {
         ColumnSet = new ColumnSet(true),
         EntityName = "duplicaterecord"
     };
     query.Attributes.Add("asyncoperationid");
     query.Values.Add(_response.JobId);
     EntityCollection results = _serviceProxy.RetrieveMultiple(query);

     // check to make sure each id is found in the collection
     var duplicateIds = results.Entities.Select((entity) => 
         ((DuplicateRecord)entity).BaseRecordId.Id);
     foreach (var id in _duplicateAccounts.Select((account) => account.Id))
     {
         if (!duplicateIds.Contains(id))
         {
             throw new Exception(String.Format(
                 "Account with ID {0} was not detected as a duplicate",
                 id));
         }
     }
     Console.WriteLine("  All accounts detected as duplicates successfully");

     #endregion

     Console.WriteLine();

     DeleteRequiredRecords(promptforDelete);
 }

// </snippetbulkdetectduplicates1>
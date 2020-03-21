// <snippetrollup1>


 // Create RollupRequest
 RollupRequest rollupRequest = new RollupRequest();
 rollupRequest.Query = query;
 rollupRequest.Target = new EntityReference("account", _accountId);
 rollupRequest.RollupType = RollupType.Extended;
 Console.WriteLine("Created RollupRequest.");
 #endregion Create RollupRequest

 #region Execute RollupRequest
 // Execute RollupRequest
 RollupResponse rollupResponse = (RollupResponse)_serviceProxy.Execute(rollupRequest);
 Console.WriteLine("Executed RollupRequest.");

// </snippetrollup1>
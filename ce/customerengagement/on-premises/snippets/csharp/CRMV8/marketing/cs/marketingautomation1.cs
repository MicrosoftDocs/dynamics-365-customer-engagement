// <snippetmarketingautomation1>


 // Connect to the Organization service. 
 // The using statement assures that the service proxy will be properly disposed.
 using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
 {
     // This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes();

     CreateRequiredRecords();

     #region Create Dynamic List

     // Create FetchXml for marketing list's query which locates accounts
     // in Seattle.
     String fetchXml = @"<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
                         <entity name='account'>
                         <attribute name='name' />
                         <attribute name='address1_city' />
                         <attribute name='primarycontactid' />
                         <attribute name='telephone1' />
                         <attribute name='accountid' />
                         <order attribute='name' descending='false' />
                         <filter type='and'>
                         <condition attribute='address1_city' operator='eq' value='seattle' />
                         </filter>
                         </entity>
                         </fetch>";
     // Create dynamic list. Set the type to true to declare a dynamic
     // list.
     List dynamicList = new List()
     {
         Type = true,
         ListName = "Dynamic List",
         CreatedFromCode = new OptionSetValue((int)ListCreatedFromCode.Account),
         Query = fetchXml
     };
     _dynamicListId = _serviceProxy.Create(dynamicList);
     dynamicList.Id = _dynamicListId;

     Console.WriteLine("Created dynamic list.");

     #endregion

     #region Associate dynamic list to campaign

     // Create a campaign.
     Campaign campaign = new Campaign()
     {
         Name = "Sample Campaign"
     };
     _campaignId = _serviceProxy.Create(campaign);
     campaign.Id = _campaignId;

     // Add the dynamic list to the campaign.
     AddItemCampaignRequest addListToCampaignRequest =
         new AddItemCampaignRequest()
         {
             CampaignId = _campaignId,
             EntityId = _dynamicListId,
             EntityName = List.EntityLogicalName,
         };
     _serviceProxy.Execute(addListToCampaignRequest);

     Console.WriteLine("Added dynamic list to the campaign.");

     // Create a campaign activity to distribute fax to the list members.
     CampaignActivity campaignActivity = new CampaignActivity()
     {
         Subject = "Sample Campaign Activity",
         ChannelTypeCode = new OptionSetValue((int)CampaignActivityChannelTypeCode.Fax),
         RegardingObjectId = campaign.ToEntityReference()
     };
     _campaignActivityId = _serviceProxy.Create(campaignActivity);

     // Add dynamic list to campaign activity.
     AddItemCampaignActivityRequest addListToCampaignActivityRequest = 
         new AddItemCampaignActivityRequest()
     {
         CampaignActivityId = _campaignActivityId,
         ItemId = _dynamicListId,
         EntityName = List.EntityLogicalName
     };
     _serviceProxy.Execute(addListToCampaignActivityRequest);

     Console.WriteLine("Added dynamic list to the campaign activity.");

     #endregion

     #region Associate static list to campaign

     // Copy the dynamic list to a static list.
     CopyDynamicListToStaticRequest copyRequest = 
         new CopyDynamicListToStaticRequest()
         {
             ListId = _dynamicListId
         };
     CopyDynamicListToStaticResponse copyResponse =
         (CopyDynamicListToStaticResponse)_serviceProxy.Execute(copyRequest);
     _staticListId = copyResponse.StaticListId;

     Console.WriteLine("Copied dynamic list to a static list.");

     // Add the static list to the campaign.
     AddItemCampaignRequest addStaticListToCampaignRequest =
         new AddItemCampaignRequest()
         {
             CampaignId = _campaignId,
             EntityId = _staticListId,
             EntityName = List.EntityLogicalName
         };
     _serviceProxy.Execute(addStaticListToCampaignRequest);

     Console.WriteLine("Added static list to the campaign.");

     // Add the static list to the campaign activity.
     AddItemCampaignActivityRequest addStaticListToCampaignActivityRequest = 
         new AddItemCampaignActivityRequest()
     {
         CampaignActivityId = _campaignActivityId,
         ItemId = _staticListId,
         EntityName = List.EntityLogicalName
     };
     _serviceProxy.Execute(addStaticListToCampaignActivityRequest);

     Console.WriteLine("Added static list to the campaign's activity.");

     #endregion

     #region Create fax for campaign's activity
     // Create a fax.
     Fax fax = new Fax()
     {
         Subject = "Example Fax"
     };

     Console.WriteLine("Created fax for campaign's activity.");
     #endregion Create fax for campaign's activity

     #region Distribute fax to the marketing list
     // Distribute the campaign activity to the marketing lists.
     DistributeCampaignActivityRequest distributeRequest = 
         new DistributeCampaignActivityRequest() 
         { 
             CampaignActivityId = _campaignActivityId,
             Activity = fax,
             Owner = new EntityReference("systemuser", _salesManagerId),
             Propagate = true,
             SendEmail = false,
             PostWorkflowEvent = true
         };
     _serviceProxy.Execute(distributeRequest);

     Console.WriteLine("Distributed fax to the marketing lists.");
     #endregion Distribute fax to the marketing list

     #region Retrieve collection of entities from marketing list
     // Retrieve a collection of entities that correspond 
     // to all of the members in a marketing list
     // This approach of retrieving list members allows you to dynamically
     // retrieve the members of a list programmatically without requiring 
     // knowledge of the member entity type.
     OrganizationServiceContext orgContext = 
         new OrganizationServiceContext(_serviceProxy);

     var member = (from mb in orgContext.CreateQuery<List>()
                   where mb.Id == _dynamicListId
                   select mb).FirstOrDefault();

     string fetchQuery = member.Query;

     RetrieveMultipleRequest memberRequest = new RetrieveMultipleRequest();
     FetchExpression fetch = new FetchExpression(fetchQuery);
     memberRequest.Query = fetch;
     RetrieveMultipleResponse memberResponse = 
         (RetrieveMultipleResponse)_serviceProxy.Execute(memberRequest);

     Console.WriteLine("Retrieved collection of entities from a marketing list.");
     #endregion Retrieve collection of entities from marketing list

     DeleteRequiredRecords(promptforDelete);
 }

// </snippetmarketingautomation1>
// <snippetadditemcampaign>


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

// </snippetadditemcampaign>
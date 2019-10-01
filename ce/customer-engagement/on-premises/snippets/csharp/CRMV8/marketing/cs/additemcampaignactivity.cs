// <snippetadditemcampaignactivity>


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

// </snippetadditemcampaignactivity>
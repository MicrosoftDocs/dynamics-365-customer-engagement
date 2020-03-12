// <snippetdistributecampaignfrommarketinglist10>


 // Remove the marketing list from the campaign activity.
 var removeFromCampaignActivity = new RemoveItemCampaignActivityRequest
 {
     CampaignActivityId = _campaignActivityId,
     ItemId = _copiedMarketingListId
 };

 _serviceProxy.Execute(removeFromCampaignActivity);
 Console.WriteLine("  Removed the marketing list from the campaign activity.");

// </snippetdistributecampaignfrommarketinglist10>
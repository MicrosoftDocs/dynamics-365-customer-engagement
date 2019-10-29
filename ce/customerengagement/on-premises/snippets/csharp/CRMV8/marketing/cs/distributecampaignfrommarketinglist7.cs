// <snippetdistributecampaignfrommarketinglist7>


 // Copy the marketing list.  First create a new one, and then copy over the
 // members.
 list.ListName = list.ListName + " Copy";
 _copiedMarketingListId = _serviceProxy.Create(list);
 var copyRequest = new CopyMembersListRequest
 {
     SourceListId = _marketingListId,
     TargetListId = _copiedMarketingListId
 };

 _serviceProxy.Execute(copyRequest);

// </snippetdistributecampaignfrommarketinglist7>
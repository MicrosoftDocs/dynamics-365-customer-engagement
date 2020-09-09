// <snippetdistributecampaignfrommarketinglist9>


 // Qualify the marketing list.
 var qualifyRequest = new QualifyMemberListRequest
 {
     OverrideorRemove = OverrideOrRemove.Override,
     MembersId = new[] { _contactIdList[0], _contactIdList[1] },
     ListId = _copiedMarketingListId
 };

 _serviceProxy.Execute(qualifyRequest);

 Console.WriteLine("  Qualified the copied marketing list so that it only\r\n    includes the first two members.");

// </snippetdistributecampaignfrommarketinglist9>
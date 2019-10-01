// <snippetdistributecampaignfrommarketinglist8>


 // Add a single contact to the copied marketing list.
 var addMemberReq = new AddMemberListRequest
 {
     EntityId = _contactIdList[1],
     ListId = _copiedMarketingListId
 };

 _serviceProxy.Execute(addMemberReq);

 Console.WriteLine("  Contact with GUID\r\n\t{{{0}}}\r\n  was added to the list.",
     _contactIdList[1]);

// </snippetdistributecampaignfrommarketinglist8>
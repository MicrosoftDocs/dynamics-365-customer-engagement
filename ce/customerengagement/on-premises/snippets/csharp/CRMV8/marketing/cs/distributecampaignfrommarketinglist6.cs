// <snippetdistributecampaignfrommarketinglist6>


 // Add a list of contacts to the marketing list.
 var addMemberListReq = new AddListMembersListRequest
 {
     MemberIds = new[] { _contactIdList[0], _contactIdList[2] },
     ListId = _marketingListId
 };

 _serviceProxy.Execute(addMemberListReq);

 Console.WriteLine("  Contacts with GUIDs \r\n\t{{{0}}}\r\n\tand {{{1}}}\r\n  were added to the list.",
     _contactIdList[0], _contactIdList[1]);

// </snippetdistributecampaignfrommarketinglist6>
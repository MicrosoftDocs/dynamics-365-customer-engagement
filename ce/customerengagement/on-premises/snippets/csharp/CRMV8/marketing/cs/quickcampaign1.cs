// <snippetquickcampaign1>



 List newList = new List()
 {
     ListName = "TestList", 
     CreatedFromCode = new OptionSetValue((int)ListCreatedFromCode.Account)
 };

 _newListId = _serviceProxy.Create(newList);

 for (int j = 0; j < 5; j++)
 {
     AddMemberListRequest addMemberListRequest = new AddMemberListRequest();
     addMemberListRequest.EntityId = _accountIdArray[j];
     addMemberListRequest.ListId = _newListId;
     AddMemberListResponse addMemberListResponse = 
         _serviceProxy.Execute(addMemberListRequest) as AddMemberListResponse;
 }

 Guid BOId = CreateAndRetrieveQuickCampaignForMarketingList(
     _templateLetterActivity, 
     _newListId, 
     PropagationOwnershipOptions.ListMemberOwner, 
     true);

// </snippetquickcampaign1>
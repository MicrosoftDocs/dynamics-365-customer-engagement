' <snippetquickcampaign1>



 Dim newList As New List() With
     {
         .ListName = "TestList",
         .CreatedFromCode =
         New OptionSetValue(CInt(Fix(ListCreatedFromCode.Account)))
     }

 _newListId = _serviceProxy.Create(newList)

 For j As Integer = 0 To 4
     Dim addMemberListRequest As New AddMemberListRequest()
     addMemberListRequest.EntityId = _accountIdArray(j)
     addMemberListRequest.ListId = _newListId
     Dim addMemberListResponse As AddMemberListResponse =
         TryCast(_serviceProxy.Execute(addMemberListRequest), 
             AddMemberListResponse)
 Next j

 Dim BOId As Guid = CreateAndRetrieveQuickCampaignForMarketingList(
     _templateLetterActivity,
     _newListId,
     PropagationOwnershipOptions.ListMemberOwner,
     True)

' </snippetquickcampaign1>
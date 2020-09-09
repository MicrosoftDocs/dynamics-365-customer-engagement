' <snippetdistributecampaignfrommarketinglist7>


          ' Copy the marketing list.  First create a new one, and then copy over the
	' members.
	list.ListName = list.ListName &amp; " Copy"
	_copiedMarketingListId = _serviceProxy.Create(list)
          Dim copyRequest = New CopyMembersListRequest With
                            {
                                .SourceListId = _marketingListId,
                                .TargetListId = _copiedMarketingListId
                            }

	_serviceProxy.Execute(copyRequest)

' </snippetdistributecampaignfrommarketinglist7>
' <snippetdistributecampaignfrommarketinglist8>


	' Add a single contact to the copied marketing list.
          Dim addMemberReq = New AddMemberListRequest With
                             {
                                 .EntityId = _contactIdList(1),
                                 .ListId = _copiedMarketingListId
                             }

	_serviceProxy.Execute(addMemberReq)

          Console.WriteLine("  Contact with GUID" &amp; vbCrLf &amp; vbTab &amp; "{{{0}}}" _
                            &amp; vbCrLf &amp; "  was added to the list.", _contactIdList(1))

' </snippetdistributecampaignfrommarketinglist8>
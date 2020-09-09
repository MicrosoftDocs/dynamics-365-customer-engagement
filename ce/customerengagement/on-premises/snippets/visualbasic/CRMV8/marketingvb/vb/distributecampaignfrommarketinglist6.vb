' <snippetdistributecampaignfrommarketinglist6>


	' Add a list of contacts to the marketing list.
          Dim addMemberListReq =
              New AddListMembersListRequest With
              {
                  .MemberIds = {_contactIdList(0), _contactIdList(2)},
                  .ListId = _marketingListId
              }

	_serviceProxy.Execute(addMemberListReq)

          Console.WriteLine("  Contacts with GUIDs " _
                            &amp; vbCrLf &amp; vbTab &amp; "{{{0}}}" _
                            &amp; vbCrLf &amp; vbTab &amp; "and {{{1}}}" _
                            &amp; vbCrLf &amp; "  were added to the list.",
                            _contactIdList(0),
                            _contactIdList(1))

' </snippetdistributecampaignfrommarketinglist6>
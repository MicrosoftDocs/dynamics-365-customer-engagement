' <snippetdistributecampaignfrommarketinglist9>


	' Qualify the marketing list.
          Dim qualifyRequest =
              New QualifyMemberListRequest With
              {
                  .OverrideorRemove = OverrideOrRemove.Override,
                  .MembersId = {_contactIdList(0), _contactIdList(1)},
                  .ListId = _copiedMarketingListId
              }

	_serviceProxy.Execute(qualifyRequest)

          Console.WriteLine("  Qualified the copied marketing list so that it only" _
                            &amp; vbCrLf &amp; "    includes the first two members.")

' </snippetdistributecampaignfrommarketinglist9>
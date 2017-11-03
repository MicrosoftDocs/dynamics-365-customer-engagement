' <snippetdistributecampaignfrommarketinglist2>


	' Add the marketing list created earlier to the campaign.
          Dim addListToCampaignRequest =
              New AddItemCampaignRequest With
              {
                  .CampaignId = _campaignId,
                  .EntityId = _copiedMarketingListId,
                  .EntityName = List.EntityLogicalName
              }

	_serviceProxy.Execute(addListToCampaignRequest)

	Console.WriteLine("  Added the marketing list to the campaign.")

' </snippetdistributecampaignfrommarketinglist2>
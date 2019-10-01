' <snippetdistributecampaignfrommarketinglist11>


	' Remove the marketing list from the campaign.
          Dim removeFromCampaign =
              New RemoveItemCampaignRequest With
              {
                  .CampaignId = _campaignId,
                  .EntityId = _copiedMarketingListId
              }

	_serviceProxy.Execute(removeFromCampaign)
	Console.WriteLine("  Removed the marketing list from the campaign.")

' </snippetdistributecampaignfrommarketinglist11>
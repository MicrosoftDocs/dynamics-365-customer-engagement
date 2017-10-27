' <snippetdistributecampaignfrommarketinglist3>


	' Add the marketing list created earlier to the campaign activity.
          Dim addListToActivityRequest =
              New AddItemCampaignActivityRequest With
              {
                  .CampaignActivityId = _campaignActivityId,
                  .ItemId = _copiedMarketingListId,
                  .EntityName = List.EntityLogicalName
              }

	_serviceProxy.Execute(addListToActivityRequest)

	Console.WriteLine("  Added the marketing list to the campaign activity.")

' </snippetdistributecampaignfrommarketinglist3>
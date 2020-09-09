' <snippetadditemcampaign>


 ' Create a campaign.
 Dim campaign As New Campaign() With {.Name = "Sample Campaign"}
 _campaignId = _serviceProxy.Create(campaign)
 campaign.Id = _campaignId

 ' Add the dynamic list to the campaign.
 Dim addListToCampaignRequest As New AddItemCampaignRequest() With
     {
         .CampaignId = _campaignId,
         .EntityId = _dynamicListId,
         .EntityName = List.EntityLogicalName
     }
 _serviceProxy.Execute(addListToCampaignRequest)

 Console.WriteLine("Added dynamic list to the campaign.")

' </snippetadditemcampaign>
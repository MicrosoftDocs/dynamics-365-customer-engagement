' <snippetadditemcampaignactivity>


 ' Create a campaign activity to distribute fax to the list members.
 Dim campaignActivity As New CampaignActivity() With
     {.Subject = "Sample Campaign Activity",
      .ChannelTypeCode = New OptionSetValue(CInt(CampaignActivityChannelTypeCode.Fax)),
      .RegardingObjectId = campaign.ToEntityReference()}
 _campaignActivityId = _serviceProxy.Create(campaignActivity)

 ' Add dynamic list to campaign activity.
 Dim addListToCampaignActivityRequest As _
     New AddItemCampaignActivityRequest() With
     {
         .CampaignActivityId = _campaignActivityId,
         .ItemId = _dynamicListId,
         .EntityName = List.EntityLogicalName
     }
 _serviceProxy.Execute(addListToCampaignActivityRequest)

 Console.WriteLine("Added dynamic list to the campaign activity.")

' </snippetadditemcampaignactivity>
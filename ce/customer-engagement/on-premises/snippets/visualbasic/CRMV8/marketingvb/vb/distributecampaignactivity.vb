' <snippetdistributecampaignactivity>


 ' Distribute the campaign activity to the marketing lists.
 Dim distributeRequest As New DistributeCampaignActivityRequest() With
     {
         .CampaignActivityId = _campaignActivityId,
         .Activity = fax,
         .Owner = New EntityReference("systemuser", _salesManagerId),
         .Propagate = True,
         .SendEmail = False,
         .PostWorkflowEvent = True
     }
 _serviceProxy.Execute(distributeRequest)

 Console.WriteLine("Distributed fax to the marketing lists.")

' </snippetdistributecampaignactivity>
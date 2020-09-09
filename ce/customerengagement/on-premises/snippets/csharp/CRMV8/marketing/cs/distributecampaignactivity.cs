// <snippetdistributecampaignactivity>


 // Distribute the campaign activity to the marketing lists.
 DistributeCampaignActivityRequest distributeRequest = 
     new DistributeCampaignActivityRequest() 
     { 
         CampaignActivityId = _campaignActivityId,
         Activity = fax,
         Owner = new EntityReference("systemuser", _salesManagerId),
         Propagate = true,
         SendEmail = false,
         PostWorkflowEvent = true
     };
 _serviceProxy.Execute(distributeRequest);

 Console.WriteLine("Distributed fax to the marketing lists.");

// </snippetdistributecampaignactivity>
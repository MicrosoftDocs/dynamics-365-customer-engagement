// <snippetdistributecampaignfrommarketinglist4>


 // Distribute and execute the campaign activity.
 // PostWorkflowEvent signals Microsoft Dynamics CRM to actually create the phone call activities.
 // Propagate also signals to Microsoft Dynamics CRM to create the phone call activities.
 // OwnershipOptions indicates whom the created activities should be assigned
 // to.
 var distributeRequest = new DistributeCampaignActivityRequest
 {
     Activity = phonecall,
     CampaignActivityId = _campaignActivityId,
     Owner = new EntityReference(
         SystemUser.EntityLogicalName, currentUser.UserId),
     OwnershipOptions = PropagationOwnershipOptions.Caller,
     PostWorkflowEvent = true,
     Propagate = true,
     SendEmail = false,
 };

 var distributeResponse = 
     (DistributeCampaignActivityResponse)_serviceProxy.Execute(distributeRequest);

 Console.WriteLine("  Distributed and executed the campaign activity to the marketing list.");

// </snippetdistributecampaignfrommarketinglist4>
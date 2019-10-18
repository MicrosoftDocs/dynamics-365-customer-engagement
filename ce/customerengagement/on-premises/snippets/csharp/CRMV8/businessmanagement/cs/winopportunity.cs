// <snippetwinopportunity>


 // Close the opportunity as won
 var winOppRequest = new WinOpportunityRequest
 {
     OpportunityClose = new OpportunityClose
     {
         OpportunityId = new EntityReference
             (Opportunity.EntityLogicalName, _opportunityId)
     },
     Status = new OptionSetValue((int)opportunity_statuscode.Won)
 };

 _serviceProxy.Execute(winOppRequest);

 Console.WriteLine("Opportunity closed as Won.");

// </snippetwinopportunity>
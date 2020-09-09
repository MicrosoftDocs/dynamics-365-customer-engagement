// <snippetloseopportunity>


 var loseOppRequest = new LoseOpportunityRequest
 {
     OpportunityClose = new OpportunityClose
     {
         OpportunityId = new EntityReference
             (Opportunity.EntityLogicalName, _loseOpportunityId)
     },
     Status = new OptionSetValue((int)opportunity_statuscode.Canceled)
 };

 _serviceProxy.Execute(loseOppRequest);

 Console.WriteLine("Opportunity closed as Lost.");

// </snippetloseopportunity>
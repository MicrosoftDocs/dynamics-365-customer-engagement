' <snippetwinopportunity>


 ' Close the opportunity as won
 Dim winOppRequest = New WinOpportunityRequest With
                     {
                         .OpportunityClose =
                         New OpportunityClose With
                         {
                             .OpportunityId =
                             New EntityReference(Opportunity.EntityLogicalName,
                                                 _opportunityId)},
                         .Status =
                         New OptionSetValue(
                             CInt(Fix(opportunity_statuscode.Won)))
                     }

 _serviceProxy.Execute(winOppRequest)

 Console.WriteLine("Opportunity closed as Won.")

' </snippetwinopportunity>
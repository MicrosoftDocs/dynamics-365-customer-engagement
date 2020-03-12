' <snippetloseopportunity>


 Dim loseOppRequest = New LoseOpportunityRequest With
                      {
                          .OpportunityClose =
                          New OpportunityClose With
                          {
                              .OpportunityId = New EntityReference(Opportunity.EntityLogicalName,
                                                                   _loseOpportunityId)},
                          .Status = New OptionSetValue(CInt(Fix(opportunity_statuscode.Canceled)))
                      }

 _serviceProxy.Execute(loseOppRequest)

 Console.WriteLine("Opportunity closed as Lost.")

' </snippetloseopportunity>
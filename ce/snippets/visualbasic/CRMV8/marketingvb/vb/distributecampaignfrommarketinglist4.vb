' <snippetdistributecampaignfrommarketinglist4>


	' Distribute and execute the campaign activity.
          ' PostWorkflowEvent signals Microsoft Dynamics CRM to actually create the phone call activities.
          ' Propagate also signals to Microsoft Dynamics CRM to create the phone call activities.
	' OwnershipOptions indicates whom the created activities should be assigned
	' to.
          Dim distributeRequest =
              New DistributeCampaignActivityRequest With
              {
                  .Activity = phonecall,
                  .CampaignActivityId = _campaignActivityId,
                  .Owner = New EntityReference(SystemUser.EntityLogicalName,
                                               currentUser.UserId),
                  .OwnershipOptions = PropagationOwnershipOptions.Caller,
                  .PostWorkflowEvent = True,
                  .Propagate = True,
                  .SendEmail = False
              }

          Dim distributeResponse =
              CType(_serviceProxy.Execute(distributeRequest), 
                  DistributeCampaignActivityResponse)

          Console.WriteLine(
              "  Distributed and executed the campaign activity to the marketing list.")

' </snippetdistributecampaignfrommarketinglist4>
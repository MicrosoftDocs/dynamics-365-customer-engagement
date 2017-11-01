' <snippetdistributecampaignfrommarketinglist5>


	' Retrieve the members that were distributed to.
          Dim retrieveMembersRequest =
              New RetrieveMembersBulkOperationRequest With
              {
                  .BulkOperationId = distributeResponse.BulkOperationId,
                  .BulkOperationSource = CInt(Fix(BulkOperationSource.CampaignActivity)),
                  .EntitySource = CInt(Fix(EntitySource.Contact)),
                  .Query = New QueryExpression(Contact.EntityLogicalName)
              }

          Dim retrieveMembersResponse =
              CType(_serviceProxy.Execute(retrieveMembersRequest), 
                  RetrieveMembersBulkOperationResponse)

	Console.WriteLine("  Contacts with the following GUIDs were distributed to:")

' </snippetdistributecampaignfrommarketinglist5>
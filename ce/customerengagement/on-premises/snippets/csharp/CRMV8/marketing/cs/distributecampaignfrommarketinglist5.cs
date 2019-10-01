// <snippetdistributecampaignfrommarketinglist5>


 // Retrieve the members that were distributed to.
 var retrieveMembersRequest = new RetrieveMembersBulkOperationRequest
 {
     BulkOperationId = distributeResponse.BulkOperationId,
     BulkOperationSource = (int)BulkOperationSource.CampaignActivity,
     EntitySource = (int)EntitySource.Contact,
     Query = new QueryExpression(Contact.EntityLogicalName)
 };

 var retrieveMembersResponse = (RetrieveMembersBulkOperationResponse)
     _serviceProxy.Execute(retrieveMembersRequest);

 Console.WriteLine("  Contacts with the following GUIDs were distributed to:");

// </snippetdistributecampaignfrommarketinglist5>
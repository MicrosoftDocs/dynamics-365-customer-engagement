// <snippetquickcampaign2>


 /// <summary>
 /// This method creates a Quick Campaign for a set of accounts selected by a query
 /// </summary>
 /// <param name="activityEntity">
 /// An object that indicates activity type for the quick campaign and 
 /// contains values for each of activity that will be created
 /// </param>
 /// <param name="query">
 /// A query that provides a list of accounts for which 
 /// the quick campaign is distributed.
 /// </param>
 /// <param name="ownershipOption">
 /// Specifies who will own the activities created by the Quick Campaign
 ///	The PropagationOwnershipOptions enum is used to specify value for this parameter
 ///	</param>
 /// <param name="isPropagate">
 /// Specifies whether the operation is to be executed. 
 /// This input is often 'true' for Quick Campaign
 /// </param>        
 /// <returns></returns>
 public Guid CreateAndRetrieveQuickCampaignForQueryExpression(Entity emailActivityEntity, 
     QueryExpression query, PropagationOwnershipOptions ownershipOption, bool isPropagate)
 {
     
     // create the bulkoperation
     PropagateByExpressionRequest request = new PropagateByExpressionRequest() {
         Activity = emailActivityEntity,
         ExecuteImmediately = false, // Default value.
         FriendlyName = "Query Based Quick Campaign",
         OwnershipOptions = ownershipOption,
         QueryExpression = query,
         Owner = new EntityReference("systemuser", _currentUser),
         PostWorkflowEvent = true,
         SendEmail = false,
         TemplateId = Guid.Empty
     };

     PropagateByExpressionResponse response = 
         (PropagateByExpressionResponse)_serviceProxy.Execute(request);

     Guid bulkOpId = response.BulkOperationId;
     System.Console.WriteLine(
         "Quick Campaign with following name has been created. "
         + "Please verify in Web app manually: \n" 
         + request.FriendlyName + "\nPress enter to continue....");
     System.Console.ReadLine();
     return bulkOpId;

 }

// </snippetquickcampaign2>
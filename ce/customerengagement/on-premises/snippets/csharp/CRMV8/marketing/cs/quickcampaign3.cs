// <snippetquickcampaign3>


 /// <summary>
 /// This method creates Quick Campaign for a given Marketing List and retruns the 
 /// Guid of the Quich Campaign which is modelled as bulk operation in CRM
 /// </summary>
 /// <param name="activityEntity">
 /// An object that indicates activity type for the quick campaign and 
 /// contains values for each activity that will be created
 /// </param>
 /// <param name="marketingListId">
 /// The ID of the marketing list to which quick campaign is distributed
 /// </param>
 /// <param name="ownershipOption">
 /// Specifies who will own the activities created by the Quick Campaign
 ///	The PropagationOwnershipOptions enum is used to specify value for this parameter
 ///	</param>
 /// <param name="isPropagate">
 /// Specifies whether the operation is to be executed. 
 /// This input is often 'true' for Quick Campaign
 /// </param>				
 public Guid CreateAndRetrieveQuickCampaignForMarketingList(
     Entity letterActivityEntity, 
     Guid marketingListId, 
     PropagationOwnershipOptions ownershipOption, 
     bool isPropagate)
 {
     //Create the request object from input parameters
     CreateActivitiesListRequest request = new CreateActivitiesListRequest() {
         Activity = letterActivityEntity,
         ListId = marketingListId,
         OwnershipOptions = ownershipOption,
         Propagate = isPropagate,
         TemplateId = Guid.Empty,
         FriendlyName = "Quick Campaign for My List",
         Owner = new EntityReference("systemuser", _currentUser),
         PostWorkflowEvent = true
     };

     //Execute the request
     CreateActivitiesListResponse response = 
         (CreateActivitiesListResponse)_serviceProxy.Execute(request);

     //On executing the request a BulkOperation record would be created in CRM. 
     //If isPropagate is true, a corresponding Async job is also created which runs and creates the required activities 
     //The response has BulkOperationId. This is the Id of the bulkoperation that mimics QuickCampaign in CRM
     Guid BOId = response.BulkOperationId;
     System.Console.WriteLine(
         "Quick Campaign with following name has been created. " 
         + "Please verify in Web app manually: \n" 
         + request.FriendlyName 
         + "\nPress enter to continue....");
     System.Console.ReadLine();

     return BOId;

 }

// </snippetquickcampaign3>
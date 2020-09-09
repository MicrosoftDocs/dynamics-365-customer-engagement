' <snippetquickcampaign3>


 ''' <summary>
 ''' This method creates Quick Campaign for a given Marketing List and retruns the 
 ''' Guid of the Quich Campaign which is modelled as bulk operation in CRM
 ''' </summary>
 ''' <param name="activityEntity">
 ''' An object that indicates activity type for the quick campaign and 
 ''' contains values for each activity that will be created
 ''' </param>
 ''' <param name="marketingListId">
 ''' The ID of the marketing list to which quick campaign is distributed
 ''' </param>
 ''' <param name="ownershipOption">
 ''' Specifies who will own the activities created by the Quick Campaign
 '''	The PropagationOwnershipOptions enum is used to specify value for this parameter
 '''	</param>
 ''' <param name="isPropagate">
 ''' Specifies whether the operation is to be executed. 
 ''' This input is often 'true' for Quick Campaign
 ''' </param>				
 Public Function CreateAndRetrieveQuickCampaignForMarketingList _
     (ByVal letterActivityEntity As Entity,
      ByVal marketingListId As Guid,
      ByVal ownershipOption As PropagationOwnershipOptions,
      ByVal isPropagate As Boolean) As Guid
     'Create the request object from input parameters
     Dim request As New CreateActivitiesListRequest() With
         {
             .Activity = letterActivityEntity,
             .ListId = marketingListId,
             .OwnershipOptions = ownershipOption,
             .Propagate = isPropagate, .TemplateId = Guid.Empty,
             .FriendlyName = "Quick Campaign for My List",
             .Owner = New EntityReference("systemuser", _currentUser),
             .PostWorkflowEvent = True
         }

     'Execute the request
     Dim response As CreateActivitiesListResponse =
         CType(_serviceProxy.Execute(request), CreateActivitiesListResponse)

     'On executing the request a BulkOperation record would be created in CRM. 
     'If isPropagate is true, a corresponding Async job is also created which runs and creates the required activities 
     'The response has BulkOperationId. This is the Id of the bulkoperation that mimics QuickCampaign in CRM
     Dim BOId As Guid = response.BulkOperationId
     System.Console.WriteLine(
         "Quick Campaign with following name has been created. " _
         &amp; "Please verify in Web app manually: " _
         &amp; vbLf &amp; request.FriendlyName &amp; vbLf _
         &amp; "Press enter to continue....")
     System.Console.ReadLine()

     Return BOId

 End Function

' </snippetquickcampaign3>
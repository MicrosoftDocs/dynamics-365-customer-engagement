' <snippetquickcampaign2>


 ''' <summary>
 ''' This method creates a Quick Campaign for a set of accounts selected by a query
 ''' </summary>
 ''' <param name="activityEntity">
 ''' An object that indicates activity type for the quick campaign and 
 ''' contains values for each of activity that will be created
 ''' </param>
 ''' <param name="query">
 ''' A query that provides a list of accounts for which 
 ''' the quick campaign is distributed.
 ''' </param>
 ''' <param name="ownershipOption">
 ''' Specifies who will own the activities created by the Quick Campaign
 '''	The PropagationOwnershipOptions enum is used to specify value for this parameter
 '''	</param>
 ''' <param name="isPropagate">
 ''' Specifies whether the operation is to be executed. 
 ''' This input is often 'true' for Quick Campaign
 ''' </param>        
 ''' <returns></returns>
 Public Function CreateAndRetrieveQuickCampaignForQueryExpression _
     (ByVal emailActivityEntity As Entity,
      ByVal query As QueryExpression,
      ByVal ownershipOption As PropagationOwnershipOptions,
      ByVal isPropagate As Boolean) As Guid

     ' create the bulkoperation
     Dim request As New PropagateByExpressionRequest() With
         {
             .Activity = emailActivityEntity,
             .ExecuteImmediately = False,
             .FriendlyName = "Query Based Quick Campaign",
             .OwnershipOptions = ownershipOption,
             .QueryExpression = query,
             .Owner = New EntityReference("systemuser", _currentUser),
             .PostWorkflowEvent = True,
             .SendEmail = False,
             .TemplateId = Guid.Empty
         }

     Dim response As PropagateByExpressionResponse =
         CType(_serviceProxy.Execute(request), PropagateByExpressionResponse)

     Dim bulkOpId As Guid = response.BulkOperationId
     System.Console.WriteLine(
         "Quick Campaign with following name has been created. " _
         &amp; "Please verify in Web app manually: " _
         &amp; vbLf &amp; request.FriendlyName &amp; vbLf _
         &amp; "Press enter to continue....")
     System.Console.ReadLine()
     Return bulkOpId

 End Function

' </snippetquickcampaign2>
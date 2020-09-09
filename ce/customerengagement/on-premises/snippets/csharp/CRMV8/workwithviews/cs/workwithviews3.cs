// <snippetworkwithviews3>


 System.String SavedQueryName = "Closed Opportunities in Current Fiscal Year";
 QueryExpression ClosedOpportunitiesViewQuery = new QueryExpression
 {
     ColumnSet = new ColumnSet("savedqueryid", "statecode", "statuscode"),
     EntityName = SavedQuery.EntityLogicalName,
     Criteria = new FilterExpression
     {
         Conditions =
         {
             new ConditionExpression
             {
                 AttributeName = "querytype",
                 Operator = ConditionOperator.Equal,
                 Values = {0}
             },
             new ConditionExpression
             {
                 AttributeName = "returnedtypecode",
                 Operator = ConditionOperator.Equal,
                 Values = {Opportunity.EntityTypeCode}
             },
                             new ConditionExpression
             {
                 AttributeName = "name",
                 Operator = ConditionOperator.Equal,
                 Values = {SavedQueryName}
             }
         }
     }
 };

 RetrieveMultipleRequest retrieveOpportuntiesViewRequest = new RetrieveMultipleRequest { Query = ClosedOpportunitiesViewQuery };

 RetrieveMultipleResponse retrieveOpportuntiesViewResponse = (RetrieveMultipleResponse)_serviceProxy.Execute(retrieveOpportuntiesViewRequest);

 SavedQuery OpportunityView = (SavedQuery)retrieveOpportuntiesViewResponse.EntityCollection.Entities[0];
 _viewOriginalState = (SavedQueryState)OpportunityView.StateCode;
 _viewOriginalStatus = OpportunityView.StatusCode;
 

 SetStateRequest ssreq = new SetStateRequest
 {
     EntityMoniker = new EntityReference(SavedQuery.EntityLogicalName, (Guid)OpportunityView.SavedQueryId),
     State = new OptionSetValue((int)SavedQueryState.Inactive),
     Status = new OptionSetValue(2)
 };
 _serviceProxy.Execute(ssreq);

// </snippetworkwithviews3>
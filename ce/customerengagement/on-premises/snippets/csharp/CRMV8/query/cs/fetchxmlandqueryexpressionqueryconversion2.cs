// <snippetfetchxmlandqueryexpressionqueryconversion2>


 // Build a query expression that we will turn into FetchXML.
 var queryExpression = new QueryExpression()
 {
     Distinct = false,
     EntityName = Contact.EntityLogicalName,
     ColumnSet = new ColumnSet("fullname", "address1_telephone1"),
     LinkEntities = 
         {
             new LinkEntity 
             {
                 JoinOperator = JoinOperator.LeftOuter,
                 LinkFromAttributeName = "parentcustomerid",
                 LinkFromEntityName = Contact.EntityLogicalName,
                 LinkToAttributeName = "accountid",
                 LinkToEntityName = Account.EntityLogicalName,
                 LinkCriteria = 
                 {
                     Conditions = 
                     {
                         new ConditionExpression("name", ConditionOperator.Equal, "Litware, Inc.")
                     }
                 }
             }
         },
     Criteria =
     {
         Filters = 
             {
                 new FilterExpression
                 {
                     FilterOperator = LogicalOperator.And,
                     Conditions = 
                     {
                         new ConditionExpression("address1_stateorprovince", ConditionOperator.Equal, "WA"),
                         new ConditionExpression("address1_city", ConditionOperator.In, new String[] {"Redmond", "Bellevue" , "Kirkland", "Seattle"}),
                         new ConditionExpression("createdon", ConditionOperator.LastXDays, 30),
                         new ConditionExpression("emailaddress1", ConditionOperator.NotNull)
                     },
                 },
                 new FilterExpression
                 {
                     FilterOperator = LogicalOperator.Or,
                     Conditions =
                     {
                         new ConditionExpression("address1_telephone1", ConditionOperator.Like, "(206)%"),
                         new ConditionExpression("address1_telephone1", ConditionOperator.Like, "(425)%")
                     }
                 }
             }
     }
 };

 // Run the query as a query expression.
 EntityCollection queryExpressionResult =
     _serviceProxy.RetrieveMultiple(queryExpression);
 Console.WriteLine("Output for query as QueryExpression:");
 DisplayContactQueryResults(queryExpressionResult);

 // Convert the query expression to FetchXML.
 var conversionRequest = new QueryExpressionToFetchXmlRequest
 {
     Query = queryExpression
 };
 var conversionResponse =
     (QueryExpressionToFetchXmlResponse)_serviceProxy.Execute(conversionRequest);

 // Use the converted query to make a retrieve multiple request to Microsoft Dynamics CRM.
 String fetchXml = conversionResponse.FetchXml;
 var fetchQuery = new FetchExpression(fetchXml);
 EntityCollection result = _serviceProxy.RetrieveMultiple(fetchQuery);

 // Display the results.
 Console.WriteLine("\nOutput for query after conversion to FetchXML:");
 DisplayContactQueryResults(result);

// </snippetfetchxmlandqueryexpressionqueryconversion2>
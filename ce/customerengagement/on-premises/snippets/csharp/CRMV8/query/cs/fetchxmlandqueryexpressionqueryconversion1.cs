// <snippetfetchxmlandqueryexpressionqueryconversion1>


 // Create a Fetch query that we will convert into a query expression.
 var fetchXml =
     @"<fetch mapping='logical' version='1.0'>
      <entity name='opportunity'>
       <attribute name='name' />
       <filter>
        <condition attribute='estimatedclosedate' operator='next-x-fiscal-years' value='3' />
       </filter>
       <link-entity name='account' from='accountid' to='customerid'>
        <link-entity name='contact' from='parentcustomerid' to='accountid'>
         <attribute name='fullname' />
         <filter>
          <condition attribute='address1_city' operator='eq' value='Bellevue' />
          <condition attribute='address1_stateorprovince' operator='eq' value='WA' />
         </filter>
        </link-entity>
       </link-entity>
      </entity>
     </fetch>";

 // Run the query with the FetchXML.
 var fetchExpression = new FetchExpression(fetchXml);
 EntityCollection fetchResult =
     _serviceProxy.RetrieveMultiple(fetchExpression);
 Console.WriteLine("\nOutput for query as FetchXML:");
 DisplayOpportunityQueryResults(fetchResult);

 // Convert the FetchXML into a query expression.
 var conversionRequest = new FetchXmlToQueryExpressionRequest
 {
     FetchXml = fetchXml
 };

 var conversionResponse =
     (FetchXmlToQueryExpressionResponse)_serviceProxy.Execute(conversionRequest);

 // Use the newly converted query expression to make a retrieve multiple
 // request to Microsoft Dynamics CRM.
 QueryExpression queryExpression = conversionResponse.Query;

 EntityCollection result = _serviceProxy.RetrieveMultiple(queryExpression);

 // Display the results.
 Console.WriteLine("\nOutput for query after conversion to QueryExpression:");
 DisplayOpportunityQueryResults(result);

// </snippetfetchxmlandqueryexpressionqueryconversion1>
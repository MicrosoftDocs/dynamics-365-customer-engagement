' <snippetfetchxmlandqueryexpressionqueryconversion1>


          ' Create a Fetch query that we will convert into a query expression.
          Dim fetchXml = "<fetch mapping='logical' version='1.0'>" _
                         &amp; "  <entity name='opportunity'>" _
                         &amp; "      <attribute name='name' />" _
                         &amp; "      <filter>" _
                         &amp; "          <condition attribute='estimatedclosedate' operator='next-x-fiscal-years' value='3' />" _
                         &amp; "      </filter>" _
                         &amp; "      <link-entity name='account' from='accountid' to='customerid'>" _
                         &amp; "          <link-entity name='contact' from='parentcustomerid' to='accountid'>" _
                         &amp; "              <attribute name='fullname' />" _
                         &amp; "              <filter>" _
                         &amp; "                <condition attribute='address1_city' operator='eq' value='Bellevue' />" _
                         &amp; "                <condition attribute='address1_stateorprovince' operator='eq' value='WA' />" _
                         &amp; "              </filter>" _
                         &amp; "          </link-entity>" _
                         &amp; "      </link-entity>" _
                         &amp; "  </entity>" _
                         &amp; "</fetch>"

          ' Run the query with the FetchXML.
	Dim fetchExpression = New FetchExpression(fetchXml)
	Dim fetchResult As EntityCollection = _serviceProxy.RetrieveMultiple(fetchExpression)
	Console.WriteLine(vbLf &amp; "Output for query as FetchXML:")
	DisplayOpportunityQueryResults(fetchResult)

          ' Convert the FetchXML into a query expression.
          Dim conversionRequest = New FetchXmlToQueryExpressionRequest With
                                  {
                                      .FetchXml = fetchXml
                                  }

          Dim conversionResponse = CType(_serviceProxy.Execute(conversionRequest), 
              FetchXmlToQueryExpressionResponse)

	' Use the newly converted query expression to make a retrieve multiple
          ' request to Microsoft Dynamics CRM.
	Dim queryExpression As QueryExpression = conversionResponse.Query

	Dim result As EntityCollection = _serviceProxy.RetrieveMultiple(queryExpression)

	' Display the results.
	Console.WriteLine(vbLf &amp; "Output for query after conversion to QueryExpression:")
	DisplayOpportunityQueryResults(result)

' </snippetfetchxmlandqueryexpressionqueryconversion1>
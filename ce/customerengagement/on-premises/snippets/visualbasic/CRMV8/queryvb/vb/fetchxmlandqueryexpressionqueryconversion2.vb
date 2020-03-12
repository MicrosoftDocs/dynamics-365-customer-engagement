' <snippetfetchxmlandqueryexpressionqueryconversion2>


          ' Build a query expression that we will turn into FetchXML.
          Dim queryExpressionObj As QueryExpression =
              New QueryExpression() With
              {
                  .Distinct = False,
                  .EntityName = Contact.EntityLogicalName,
                  .ColumnSet = New ColumnSet("fullname", "address1_telephone1")
              }
          Dim queryLink As New LinkEntity() With
              {
                  .JoinOperator = JoinOperator.LeftOuter,
                  .LinkFromAttributeName = "parentcustomerid",
                  .LinkFromEntityName = Contact.EntityLogicalName,
                  .LinkToAttributeName = "accountid",
                  .LinkToEntityName = Account.EntityLogicalName
              }
          queryLink.LinkCriteria().AddCondition("name",
                                                ConditionOperator.Equal,
                                                "Litware, Inc.")
          queryExpressionObj.LinkEntities().Add(queryLink)

          Dim queryCriteriaFilter1 As New FilterExpression() With
              {
                  .FilterOperator = LogicalOperator.And
              }
          queryCriteriaFilter1.AddCondition(
              New ConditionExpression("address1_stateorprovince",
                                      ConditionOperator.Equal,
                                      "WA"))
          queryCriteriaFilter1.AddCondition(
              New ConditionExpression("address1_city",
                                      ConditionOperator.In,
                                      New String() {"Redmond",
                                                    "Bellevue",
                                                    "Kirkland",
                                                    "Seattle"}))
          queryCriteriaFilter1.AddCondition(
              New ConditionExpression("createdon",
                                      ConditionOperator.LastXDays,
                                      30))
          queryCriteriaFilter1.AddCondition(
              New ConditionExpression("emailaddress1",
                                      ConditionOperator.NotNull))
          Dim queryCriteriaFilter2 As New FilterExpression() With
              {
                  .FilterOperator = LogicalOperator.Or
              }
          queryCriteriaFilter2.AddCondition(
              New ConditionExpression("address1_telephone1",
                                      ConditionOperator.Like,
                                      "(206)%"))
          queryCriteriaFilter2.AddCondition(
              New ConditionExpression("address1_telephone1",
                                      ConditionOperator.Like,
                                      "(425)%"))
          queryExpressionObj.Criteria.Filters.AddRange(queryCriteriaFilter1,
                                                    queryCriteriaFilter2)

          ' Run the query as a query expression.
          Dim queryExpressionResult As EntityCollection =
              _serviceProxy.RetrieveMultiple(queryExpressionObj)
          Console.WriteLine("Output for query as QueryExpression:")
          DisplayContactQueryResults(queryExpressionResult)

          ' Convert the query expression to FetchXML.
          Dim conversionRequest As QueryExpressionToFetchXmlRequest =
              New QueryExpressionToFetchXmlRequest With {.Query = queryExpressionObj}
          Dim conversionResponse = CType(_serviceProxy.Execute(conversionRequest), 
              QueryExpressionToFetchXmlResponse)

          ' Use the converted query to make a retrieve multiple request to Microsoft Dynamics CRM.
	Dim fetchXml As String = conversionResponse.FetchXml
	Dim fetchQuery = New FetchExpression(fetchXml)
	Dim result As EntityCollection = _serviceProxy.RetrieveMultiple(fetchQuery)

	' Display the results.
	Console.WriteLine(vbLf &amp; "Output for query after conversion to FetchXML:")
	DisplayContactQueryResults(result)

' </snippetfetchxmlandqueryexpressionqueryconversion2>
' <snippetretrievemultipleconditionoperatorsqe1>


 ' Build the following SQL query using QueryExpression:
 '
 '		SELECT contact.fullname, contact.address1_telephone1
 '		FROM contact
 '			LEFT OUTER JOIN account
 '				ON contact.parentcustomerid = account.accountid
 '				AND
 '				account.name = 'Litware, Inc.'
 '		WHERE (contact.address1_stateorprovince = 'WA'
 '		AND
 '			contact.address1_city in ('Redmond', 'Bellevue', 'Kirkland', 'Seattle')
 '		AND 
 '			contact.address1_telephone1 like '(206)%'
 '			OR
 '			contact.address1_telephone1 like '(425)%'
 '		AND
 '			DATEDIFF(DAY, contact.createdon, GETDATE()) > 0
 '		AND
 '			DATEDIFF(DAY, contact.createdon, GETDATE()) < 30
 '		AND
 '			contact.emailaddress1 Not NULL
 '			   )

 Dim query As New QueryExpression() With
     {
         .Distinct = False,
         .EntityName = Contact.EntityLogicalName,
         .ColumnSet = New ColumnSet("fullname", "address1_telephone1")
     }

 Dim queryLink As New LinkEntity With
     {
         .LinkToEntityName = Account.EntityLogicalName,
         .LinkFromAttributeName = "parentcustomerid",
         .LinkToAttributeName = "accountid",
         .JoinOperator = JoinOperator.LeftOuter
     }
 queryLink.LinkCriteria().AddCondition("name",
                                       ConditionOperator.Equal,
                                       "Litware, Inc.")
 query.LinkEntities().Add(queryLink)
 Dim queryCriteraFilter1 As New FilterExpression()
 queryCriteraFilter1.FilterOperator = LogicalOperator.And
 queryCriteraFilter1.AddCondition(
     New ConditionExpression("address1_stateorprovince",
                             ConditionOperator.Equal, "WA"))
 queryCriteraFilter1.AddCondition(
     New ConditionExpression("address1_city",
                             ConditionOperator.In,
                             New String() {"Redmond",
                                           "Bellevue",
                                           "Kirkland",
                                           "Seattle"}))
 queryCriteraFilter1.AddCondition(
     New ConditionExpression("createdon",
                             ConditionOperator.LastXDays,
                             30))
 queryCriteraFilter1.AddCondition(
     New ConditionExpression("emailaddress1",
                             ConditionOperator.NotNull))
 Dim queryCriteraFilter2 As New FilterExpression()
 queryCriteraFilter2.FilterOperator = LogicalOperator.Or
 queryCriteraFilter2.AddCondition(
     New ConditionExpression("address1_telephone1",
                             ConditionOperator.Like,
                             "(206)%"))
 queryCriteraFilter2.AddCondition(
     New ConditionExpression("address1_telephone1",
                             ConditionOperator.Like,
                             "(425)%"))
 query.Criteria.Filters.AddRange(queryCriteraFilter1,
                                 queryCriteraFilter2)

 Dim entityCollection As DataCollection(Of Entity) =
     _service.RetrieveMultiple(query).Entities

 ' Display the results.
 Console.WriteLine("List all contacts matching specified parameters")
 Console.WriteLine("===============================================")
 For Each contact As Contact In entityCollection
     Console.WriteLine("Contact ID: {0}", contact.Id)
     Console.WriteLine("Contact Name: {0}", contact.FullName)
     Console.WriteLine("Contact Phone: {0}", contact.Address1_Telephone1)
 Next contact
 Console.WriteLine("<End of Listing>")
 Console.WriteLine()

' </snippetretrievemultipleconditionoperatorsqe1>
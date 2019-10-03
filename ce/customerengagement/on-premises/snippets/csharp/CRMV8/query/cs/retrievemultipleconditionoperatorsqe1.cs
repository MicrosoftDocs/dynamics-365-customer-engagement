// <snippetretrievemultipleconditionoperatorsqe1>


 // Build the following SQL query using QueryExpression:
 //
 //		SELECT contact.fullname, contact.address1_telephone1
 //		FROM contact
 //			LEFT OUTER JOIN account
 //				ON contact.parentcustomerid = account.accountid
 //				AND
 //				account.name = 'Litware, Inc.'
 //		WHERE (contact.address1_stateorprovince = 'WA'
 //		AND
 //			contact.address1_city in ('Redmond', 'Bellevue', 'Kirkland', 'Seattle')
 //		AND 
 //			contact.address1_telephone1 like '(206)%'
 //			OR
 //			contact.address1_telephone1 like '(425)%'
 //		AND
 //			DATEDIFF(DAY, contact.createdon, GETDATE()) > 0
 //		AND
 //			DATEDIFF(DAY, contact.createdon, GETDATE()) < 30
 //		AND
 //			contact.emailaddress1 Not NULL
 //			   )

 QueryExpression query = new QueryExpression()
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

 DataCollection<Entity> entityCollection = _service.RetrieveMultiple(query).Entities;

 // Display the results.
 Console.WriteLine("List all contacts matching specified parameters");
 Console.WriteLine("===============================================");
 foreach (Contact contact in entityCollection)
 {
     Console.WriteLine("Contact ID: {0}", contact.Id);
     Console.WriteLine("Contact Name: {0}", contact.FullName);
     Console.WriteLine("Contact Phone: {0}", contact.Address1_Telephone1);
 }
 Console.WriteLine("<End of Listing>");
 Console.WriteLine();

// </snippetretrievemultipleconditionoperatorsqe1>
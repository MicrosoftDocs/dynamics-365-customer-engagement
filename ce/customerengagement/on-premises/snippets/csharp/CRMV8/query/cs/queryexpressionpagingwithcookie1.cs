// <snippetqueryexpressionpagingwithcookie1>


 // Query using the paging cookie.
 // Define the paging attributes.
 // The number of records per page to retrieve.
 int queryCount = 3;
 
 // Initialize the page number.
 int pageNumber = 1;
 
 // Initialize the number of records.
 int recordCount = 0;
 
 // Define the condition expression for retrieving records.
 ConditionExpression pagecondition = new ConditionExpression();
 pagecondition.AttributeName = "parentaccountid";
 pagecondition.Operator = ConditionOperator.Equal;
 pagecondition.Values.Add(_parentAccountId);

 // Define the order expression to retrieve the records.
 OrderExpression order = new OrderExpression();
 order.AttributeName = "name";
 order.OrderType = OrderType.Ascending;

 // Create the query expression and add condition.
 QueryExpression pagequery = new QueryExpression();
 pagequery.EntityName = "account";
 pagequery.Criteria.AddCondition(pagecondition);
 pagequery.Orders.Add(order);
 pagequery.ColumnSet.AddColumns("name", "emailaddress1");                   

 // Assign the pageinfo properties to the query expression.
 pagequery.PageInfo = new PagingInfo();
 pagequery.PageInfo.Count = queryCount;
 pagequery.PageInfo.PageNumber = pageNumber;

 // The current paging cookie. When retrieving the first page, 
 // pagingCookie should be null.
 pagequery.PageInfo.PagingCookie = null;
 Console.WriteLine("Retrieving sample account records in pages...\n");
 Console.WriteLine("#\tAccount Name\t\tEmail Address"); 
 
 while (true)
 {
     // Retrieve the page.
     EntityCollection results = _serviceProxy.RetrieveMultiple(pagequery);
     if (results.Entities != null)
     {
         // Retrieve all records from the result set.
         foreach (Account acct in results.Entities)
         {
             Console.WriteLine("{0}.\t{1}\t{2}", ++recordCount, acct.Name,
                                acct.EMailAddress1);
         }
     }

     // Check for more records, if it returns true.
     if (results.MoreRecords)
     {
         Console.WriteLine("\n****************\nPage number {0}\n****************", pagequery.PageInfo.PageNumber);
         Console.WriteLine("#\tAccount Name\t\tEmail Address");

         // Increment the page number to retrieve the next page.
         pagequery.PageInfo.PageNumber++;
         
         // Set the paging cookie to the paging cookie returned from current results.
         pagequery.PageInfo.PagingCookie = results.PagingCookie;
     }
     else
     {
         // If no more records are in the result nodes, exit the loop.
         break;
     }
 }

// </snippetqueryexpressionpagingwithcookie1>
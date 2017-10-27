// <snippetretrievemultipleconditionoperatorsqe2>


 query = new QueryExpression()
 {
     EntityName = SalesOrder.EntityLogicalName,
     ColumnSet = new ColumnSet("name"),
     Criteria =
     {
         Conditions = 
         {
             new ConditionExpression ("datefulfilled", ConditionOperator.LastFiscalPeriod)
         }
     }
 };

 entityCollection = _service.RetrieveMultiple(query).Entities;

 // Display the results.
 Console.WriteLine("List all orders fulfilled in the last fiscal period");
 Console.WriteLine("===================================================");
 foreach (SalesOrder order in entityCollection)
 {
     Console.WriteLine("Order ID: {0}", order.Id);
     Console.WriteLine("Order Name: {0}", order.Name);
 }
 Console.WriteLine("<End of Listing>");
 Console.WriteLine();

// </snippetretrievemultipleconditionoperatorsqe2>
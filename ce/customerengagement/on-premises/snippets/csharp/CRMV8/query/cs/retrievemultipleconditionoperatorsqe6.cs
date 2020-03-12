// <snippetretrievemultipleconditionoperatorsqe6>


 query = new QueryExpression()
 {
     EntityName = SalesOrder.EntityLogicalName,
     ColumnSet = new ColumnSet("name"),
     Criteria =
     {
         Conditions =
         {
             new ConditionExpression ("datefulfilled", ConditionOperator.InFiscalPeriodAndYear, new int[] {3, 2008})
         }
     }
 };

 entityCollection = _service.RetrieveMultiple(query).Entities;

 // Display the results.
 Console.WriteLine("List all orders fulfilled in period 3 of fiscal year 2008");
 Console.WriteLine("=========================================================");
 foreach (SalesOrder order in entityCollection)
 {
     Console.WriteLine("Order ID: {0}", order.Id);
     Console.WriteLine("Order Name: {0}", order.Name);
 }
 Console.WriteLine("<End of Listing>");
 Console.WriteLine();

// </snippetretrievemultipleconditionoperatorsqe6>
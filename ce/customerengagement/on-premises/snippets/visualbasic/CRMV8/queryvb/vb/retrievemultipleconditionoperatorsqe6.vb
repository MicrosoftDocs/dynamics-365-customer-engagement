' <snippetretrievemultipleconditionoperatorsqe6>


 query = New QueryExpression() With
         {
             .EntityName = SalesOrder.EntityLogicalName,
             .ColumnSet = New ColumnSet("name")
         }
 query.Criteria.AddCondition(
     New ConditionExpression("datefulfilled",
                             ConditionOperator.InFiscalPeriodAndYear,
                             New Integer() {3, 2008}))

 entityCollection = _service.RetrieveMultiple(query).Entities

 ' Display the results.
 Console.WriteLine("List all orders fulfilled in period 3 of fiscal year 2008")
 Console.WriteLine("=========================================================")
 For Each order As SalesOrder In entityCollection
     Console.WriteLine("Order ID: {0}", order.Id)
     Console.WriteLine("Order Name: {0}", order.Name)
 Next order
 Console.WriteLine("<End of Listing>")
 Console.WriteLine()

' </snippetretrievemultipleconditionoperatorsqe6>
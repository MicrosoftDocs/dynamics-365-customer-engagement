// <snippetretrievemultipleconditionoperatorsqe3>


 query = new QueryExpression()
 {
     EntityName = Opportunity.EntityLogicalName,
     ColumnSet = new ColumnSet("name"),
     Criteria =
     {
         Conditions =
         {
             new ConditionExpression ("estimatedclosedate", ConditionOperator.NextXFiscalYears, 3)
         }
     }
 };

 entityCollection = _service.RetrieveMultiple(query).Entities;

 // Display the results.
 Console.WriteLine("List all opportunities with estimated close date in the next 3 fiscal years");
 Console.WriteLine("===========================================================================");
 foreach (Opportunity opportunity in entityCollection)
 {
     Console.WriteLine("Opportunity ID: {0}", opportunity.Id);
     Console.WriteLine("Opportunity: {0}", opportunity.Name);
 }
 Console.WriteLine("<End of Listing>");
 Console.WriteLine();

// </snippetretrievemultipleconditionoperatorsqe3>
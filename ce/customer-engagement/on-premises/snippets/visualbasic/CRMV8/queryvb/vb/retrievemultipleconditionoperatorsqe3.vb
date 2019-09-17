' <snippetretrievemultipleconditionoperatorsqe3>


 query = New QueryExpression() With
         {
             .EntityName = Opportunity.EntityLogicalName,
             .ColumnSet = New ColumnSet("name")
         }
 query.Criteria.AddCondition(
     New ConditionExpression("estimatedclosedate",
                             ConditionOperator.NextXFiscalYears,
                             3))

 entityCollection = _service.RetrieveMultiple(query).Entities

 ' Display the results.
 Console.WriteLine("List all opportunities with estimated close date in the next 3 fiscal years")
 Console.WriteLine("===========================================================================")
 For Each opportunity As Opportunity In entityCollection
     Console.WriteLine("Opportunity ID: {0}", opportunity.Id)
     Console.WriteLine("Opportunity: {0}", opportunity.Name)
 Next opportunity
 Console.WriteLine("<End of Listing>")
 Console.WriteLine()

' </snippetretrievemultipleconditionoperatorsqe3>
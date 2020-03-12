// <snippetfetchaggregationandgroupby7>


 // *****************************************************************************************************************
 //                FetchXML      estimatedvalue_sum   Aggregate 7
 // *****************************************************************************************************************
 // Fetch the sum of estimatedvalue for all opportunities.  This is the equivalent of 
 // SELECT SUM(estimatedvalue) AS estimatedvalue_sum ... in SQL.
 string estimatedvalue_sum = @" 
 <fetch distinct='false' mapping='logical' aggregate='true'> 
     <entity name='opportunity'> 
        <attribute name='estimatedvalue' alias='estimatedvalue_sum' aggregate='sum' /> 
     </entity> 
 </fetch>";

 EntityCollection estimatedvalue_sum_result = _serviceProxy.RetrieveMultiple(new FetchExpression(estimatedvalue_sum));

 foreach (var c in estimatedvalue_sum_result.Entities)
 {
     decimal aggregate7 = ((Money)((AliasedValue)c["estimatedvalue_sum"]).Value).Value;
     System.Console.WriteLine("Sum of estimated value of all opportunities: " + aggregate7);

 }
 System.Console.WriteLine("===============================");

// </snippetfetchaggregationandgroupby7>
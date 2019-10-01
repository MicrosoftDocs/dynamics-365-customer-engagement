// <snippetfetchaggregationandgroupby5>


 // *****************************************************************************************************************
 //                FetchXML      estimatedvalue_max   Aggregate 5
 // *****************************************************************************************************************
 // Fetch the maximum estimatedvalue of all opportunities.  This is the equivalent of 
 // SELECT MAX(estimatedvalue) AS estimatedvalue_max ... in SQL.
 string estimatedvalue_max = @" 
 <fetch distinct='false' mapping='logical' aggregate='true'> 
     <entity name='opportunity'> 
        <attribute name='estimatedvalue' alias='estimatedvalue_max' aggregate='max' /> 
     </entity> 
 </fetch>";

 EntityCollection estimatedvalue_max_result = _serviceProxy.RetrieveMultiple(new FetchExpression(estimatedvalue_max));

 foreach (var c in estimatedvalue_max_result.Entities)
 {
     decimal aggregate5 = ((Money)((AliasedValue)c["estimatedvalue_max"]).Value).Value;
     System.Console.WriteLine("Max estimated value of all opportunities: " + aggregate5);

 }
 System.Console.WriteLine("===============================");

// </snippetfetchaggregationandgroupby5>
// <snippetfetchaggregationandgroupby6>


 // *****************************************************************************************************************
 //                FetchXML      estimatedvalue_min   Aggregate 6
 // *****************************************************************************************************************
 // Fetch the minimum estimatedvalue of all opportunities.  This is the equivalent of 
 // SELECT MIN(estimatedvalue) AS estimatedvalue_min ... in SQL.
 string estimatedvalue_min = @" 
 <fetch distinct='false' mapping='logical' aggregate='true'> 
     <entity name='opportunity'> 
        <attribute name='estimatedvalue' alias='estimatedvalue_min' aggregate='min' /> 
     </entity> 
 </fetch>";

 EntityCollection estimatedvalue_min_result = _serviceProxy.RetrieveMultiple(new FetchExpression(estimatedvalue_min));

 foreach (var c in estimatedvalue_min_result.Entities)
 {
     decimal aggregate6 = ((Money)((AliasedValue)c["estimatedvalue_min"]).Value).Value;
     System.Console.WriteLine("Minimum estimated value of all opportunities: " + aggregate6);

 }
 System.Console.WriteLine("===============================");

// </snippetfetchaggregationandgroupby6>
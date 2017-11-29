// <snippetfetchaggregationandgroupby8>


 // *****************************************************************************************************************
 //                FetchXML      estimatedvalue_avg, estimatedvalue_sum   Aggregate 8
 // *****************************************************************************************************************
 // Fetch multiple aggregate values within a single query.
 string estimatedvalue_avg2 = @" 
 <fetch distinct='false' mapping='logical' aggregate='true'> 
     <entity name='opportunity'> 
        <attribute name='opportunityid' alias='opportunity_count' aggregate='count'/> 
        <attribute name='estimatedvalue' alias='estimatedvalue_sum' aggregate='sum'/> 
        <attribute name='estimatedvalue' alias='estimatedvalue_avg' aggregate='avg'/> 
     </entity> 
 </fetch>";

 EntityCollection estimatedvalue_avg2_result = _serviceProxy.RetrieveMultiple(new FetchExpression(estimatedvalue_avg2));

 foreach (var c in estimatedvalue_avg2_result.Entities)
 {
     Int32 aggregate8a = (Int32)((AliasedValue)c["opportunity_count"]).Value;
     System.Console.WriteLine("Count of all opportunities: " + aggregate8a);
     decimal aggregate8b = ((Money)((AliasedValue)c["estimatedvalue_sum"]).Value).Value;
     System.Console.WriteLine("Sum of estimated value of all opportunities: " + aggregate8b);
     decimal aggregate8c = ((Money)((AliasedValue)c["estimatedvalue_avg"]).Value).Value;
     System.Console.WriteLine("Average of estimated value of all opportunities: " + aggregate8c);

 }
 System.Console.WriteLine("===============================");

// </snippetfetchaggregationandgroupby8>
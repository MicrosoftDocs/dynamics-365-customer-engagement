// <snippetfetchaggregationandgroupby15>


 // *****************************************************************************************************************
 //                FetchXML      byday   Aggregate 15           
 // *****************************************************************************************************************
 // Fetch aggregate information about the opportunities that have 
 // been won by day. (Returns 1-31)
 string byday = @" 
 <fetch distinct='false' mapping='logical' aggregate='true'> 
     <entity name='opportunity'> 
        <attribute name='opportunityid' alias='opportunity_count' aggregate='count'/> 
        <attribute name='estimatedvalue' alias='estimatedvalue_sum' aggregate='sum'/> 
        <attribute name='estimatedvalue' alias='estimatedvalue_avg' aggregate='avg'/> 
        <attribute name='actualclosedate' groupby='true' dategrouping='day' alias='day' />
        <filter type='and'>
            <condition attribute='statecode' operator='eq' value='Won' />
        </filter>
     </entity> 
 </fetch>";

 EntityCollection byday_result = _serviceProxy.RetrieveMultiple(new FetchExpression(byday));

 foreach (var c in byday_result.Entities)
 {
     Int32 aggregate15 = (Int32)((AliasedValue)c["day"]).Value;
     System.Console.WriteLine("Day: " + aggregate15);
     Int32 aggregate15a = (Int32)((AliasedValue)c["opportunity_count"]).Value;
     System.Console.WriteLine("Count of all opportunities: " + aggregate15a);
     decimal aggregate15b = ((Money)((AliasedValue)c["estimatedvalue_sum"]).Value).Value;
     System.Console.WriteLine("Sum of estimated value of all opportunities: " + aggregate15b);
     decimal aggregate15c = ((Money)((AliasedValue)c["estimatedvalue_avg"]).Value).Value;
     System.Console.WriteLine("Average of estimated value of all opportunities: " + aggregate15c);
     System.Console.WriteLine("----------------------------------------------");
 }
 System.Console.WriteLine("===============================");

// </snippetfetchaggregationandgroupby15>
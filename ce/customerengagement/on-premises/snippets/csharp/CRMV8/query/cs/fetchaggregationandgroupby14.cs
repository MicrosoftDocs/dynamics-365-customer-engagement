// <snippetfetchaggregationandgroupby14>


 // *****************************************************************************************************************
 //                FetchXML      byweek   Aggregate 14           
 // *****************************************************************************************************************
 // Fetch aggregate information about the opportunities that have 
 // been won by week. (Returns 1-52)
 string byweek = @" 
 <fetch distinct='false' mapping='logical' aggregate='true'> 
     <entity name='opportunity'> 
        <attribute name='opportunityid' alias='opportunity_count' aggregate='count'/> 
        <attribute name='estimatedvalue' alias='estimatedvalue_sum' aggregate='sum'/> 
        <attribute name='estimatedvalue' alias='estimatedvalue_avg' aggregate='avg'/> 
        <attribute name='actualclosedate' groupby='true' dategrouping='week' alias='week' />
        <filter type='and'>
            <condition attribute='statecode' operator='eq' value='Won' />
        </filter>
     </entity> 
 </fetch>";

 EntityCollection byweek_result = _serviceProxy.RetrieveMultiple(new FetchExpression(byweek));

 foreach (var c in byweek_result.Entities)
 {
     Int32 aggregate14 = (Int32)((AliasedValue)c["week"]).Value;
     System.Console.WriteLine("Week: " + aggregate14);
     Int32 aggregate14a = (Int32)((AliasedValue)c["opportunity_count"]).Value;
     System.Console.WriteLine("Count of all opportunities: " + aggregate14a);
     decimal aggregate14b = ((Money)((AliasedValue)c["estimatedvalue_sum"]).Value).Value;
     System.Console.WriteLine("Sum of estimated value of all opportunities: " + aggregate14b);
     decimal aggregate14c = ((Money)((AliasedValue)c["estimatedvalue_avg"]).Value).Value;
     System.Console.WriteLine("Average of estimated value of all opportunities: " + aggregate14c);
     System.Console.WriteLine("----------------------------------------------");
 }
 System.Console.WriteLine("===============================");

// </snippetfetchaggregationandgroupby14>
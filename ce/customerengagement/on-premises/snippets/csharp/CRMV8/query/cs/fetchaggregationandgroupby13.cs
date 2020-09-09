// <snippetfetchaggregationandgroupby13>


 // *****************************************************************************************************************
 //                FetchXML      bymonth   Aggregate 13           
 // *****************************************************************************************************************
 // Fetch aggregate information about the opportunities that have 
 // been won by month. (returns 1-12)
 string bymonth = @" 
 <fetch distinct='false' mapping='logical' aggregate='true'> 
     <entity name='opportunity'> 
        <attribute name='opportunityid' alias='opportunity_count' aggregate='count'/> 
        <attribute name='estimatedvalue' alias='estimatedvalue_sum' aggregate='sum'/> 
        <attribute name='estimatedvalue' alias='estimatedvalue_avg' aggregate='avg'/> 
        <attribute name='actualclosedate' groupby='true' dategrouping='month' alias='month' />
        <filter type='and'>
            <condition attribute='statecode' operator='eq' value='Won' />
        </filter>
     </entity> 
 </fetch>";

 EntityCollection bymonth_result = _serviceProxy.RetrieveMultiple(new FetchExpression(bymonth));

 foreach (var c in bymonth_result.Entities)
 {
     Int32 aggregate13 = (Int32)((AliasedValue)c["month"]).Value;
     System.Console.WriteLine("Month: " + aggregate13);
     Int32 aggregate13a = (Int32)((AliasedValue)c["opportunity_count"]).Value;
     System.Console.WriteLine("Count of all opportunities: " + aggregate13a);
     decimal aggregate13b = ((Money)((AliasedValue)c["estimatedvalue_sum"]).Value).Value;
     System.Console.WriteLine("Sum of estimated value of all opportunities: " + aggregate13b);
     decimal aggregate13c = ((Money)((AliasedValue)c["estimatedvalue_avg"]).Value).Value;
     System.Console.WriteLine("Average of estimated value of all opportunities: " + aggregate13c);
     System.Console.WriteLine("----------------------------------------------");
 }
 System.Console.WriteLine("===============================");

// </snippetfetchaggregationandgroupby13>
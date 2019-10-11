// <snippetfetchaggregationandgroupby11>


 // *****************************************************************************************************************
 //                FetchXML      byyear   Aggregate 11           
 // *****************************************************************************************************************
 // Fetch aggregate information about the opportunities that have 
 // been won by year.
 string byyear = @" 
 <fetch distinct='false' mapping='logical' aggregate='true'> 
     <entity name='opportunity'> 
        <attribute name='opportunityid' alias='opportunity_count' aggregate='count'/> 
        <attribute name='estimatedvalue' alias='estimatedvalue_sum' aggregate='sum'/> 
        <attribute name='estimatedvalue' alias='estimatedvalue_avg' aggregate='avg'/> 
        <attribute name='actualclosedate' groupby='true' dategrouping='year' alias='year' />
        <filter type='and'>
            <condition attribute='statecode' operator='eq' value='Won' />
        </filter>
     </entity> 
 </fetch>";

 EntityCollection byyear_result = _serviceProxy.RetrieveMultiple(new FetchExpression(byyear));

 foreach (var c in byyear_result.Entities)
 {
     Int32 aggregate11 = (Int32)((AliasedValue)c["year"]).Value;
     System.Console.WriteLine("Year: " + aggregate11);                      
     Int32 aggregate11a = (Int32)((AliasedValue)c["opportunity_count"]).Value;
     System.Console.WriteLine("Count of all opportunities: " + aggregate11a);
     decimal aggregate11b = ((Money)((AliasedValue)c["estimatedvalue_sum"]).Value).Value;
     System.Console.WriteLine("Sum of estimated value of all opportunities: " + aggregate11b);
     decimal aggregate11c = ((Money)((AliasedValue)c["estimatedvalue_avg"]).Value).Value;
     System.Console.WriteLine("Average of estimated value of all opportunities: " + aggregate11c);
     System.Console.WriteLine("----------------------------------------------");
 }
 System.Console.WriteLine("===============================");

// </snippetfetchaggregationandgroupby11>
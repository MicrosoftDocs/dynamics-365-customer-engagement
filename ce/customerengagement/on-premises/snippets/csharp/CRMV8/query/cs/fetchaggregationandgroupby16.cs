// <snippetfetchaggregationandgroupby16>


 // *****************************************************************************************************************
 //                FetchXML      byyrqtr   Aggregate 16           
 // *****************************************************************************************************************
 // Fetch aggregate information about the opportunities that have 
 // been won by year and quarter.
 string byyrqtr = @" 
 <fetch distinct='false' mapping='logical' aggregate='true'> 
     <entity name='opportunity'> 
        <attribute name='opportunityid' alias='opportunity_count' aggregate='count'/> 
        <attribute name='estimatedvalue' alias='estimatedvalue_sum' aggregate='sum'/> 
        <attribute name='estimatedvalue' alias='estimatedvalue_avg' aggregate='avg'/> 
        <attribute name='actualclosedate' groupby='true' dategrouping='quarter' alias='quarter' />
        <attribute name='actualclosedate' groupby='true' dategrouping='year' alias='year' />
        <filter type='and'>
            <condition attribute='statecode' operator='eq' value='Won' />
        </filter>
     </entity> 
 </fetch>";

 EntityCollection byyrqtr_result = _serviceProxy.RetrieveMultiple(new FetchExpression(byyrqtr));

 foreach (var c in byyrqtr_result.Entities)
 {
     Int32 aggregate16d = (Int32)((AliasedValue)c["year"]).Value;
     System.Console.WriteLine("Year: " + aggregate16d);
     Int32 aggregate16 = (Int32)((AliasedValue)c["quarter"]).Value;
     System.Console.WriteLine("Quarter: " + aggregate16);
     Int32 aggregate16a = (Int32)((AliasedValue)c["opportunity_count"]).Value;
     System.Console.WriteLine("Count of all opportunities: " + aggregate16a);
     decimal aggregate16b = ((Money)((AliasedValue)c["estimatedvalue_sum"]).Value).Value;
     System.Console.WriteLine("Sum of estimated value of all opportunities: " + aggregate16b);
     decimal aggregate16c = ((Money)((AliasedValue)c["estimatedvalue_avg"]).Value).Value;
     System.Console.WriteLine("Average of estimated value of all opportunities: " + aggregate16c);
     System.Console.WriteLine("----------------------------------------------");
 }
 System.Console.WriteLine("===============================");

// </snippetfetchaggregationandgroupby16>
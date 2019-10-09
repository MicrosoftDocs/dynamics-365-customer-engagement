// <snippetfetchaggregationandgroupby17>


 // *****************************************************************************************************************
 //                FetchXML      byyrqtr2   Aggregate 17           
 // *****************************************************************************************************************
 // Specify the result order for the previous sample.  Order by year, then quarter.
 string byyrqtr2 = @" 
 <fetch distinct='false' mapping='logical' aggregate='true'> 
     <entity name='opportunity'> 
        <attribute name='opportunityid' alias='opportunity_count' aggregate='count'/> 
        <attribute name='estimatedvalue' alias='estimatedvalue_sum' aggregate='sum'/> 
        <attribute name='estimatedvalue' alias='estimatedvalue_avg' aggregate='avg'/> 
        <attribute name='actualclosedate' groupby='true' dategrouping='quarter' alias='quarter' />
        <attribute name='actualclosedate' groupby='true' dategrouping='year' alias='year' />
        <order alias='year' descending='false' />
        <order alias='quarter' descending='false' />
        <filter type='and'>
            <condition attribute='statecode' operator='eq' value='Won' />
        </filter>
     </entity> 
 </fetch>";

 EntityCollection byyrqtr2_result = _serviceProxy.RetrieveMultiple(new FetchExpression(byyrqtr2));

 foreach (var c in byyrqtr2_result.Entities)
 {
     Int32 aggregate17 = (Int32)((AliasedValue)c["quarter"]).Value;
     System.Console.WriteLine("Quarter: " + aggregate17);
     Int32 aggregate17d = (Int32)((AliasedValue)c["year"]).Value;
     System.Console.WriteLine("Year: " + aggregate17d);
     Int32 aggregate17a = (Int32)((AliasedValue)c["opportunity_count"]).Value;
     System.Console.WriteLine("Count of all opportunities: " + aggregate17a);
     decimal aggregate17b = ((Money)((AliasedValue)c["estimatedvalue_sum"]).Value).Value;
     System.Console.WriteLine("Sum of estimated value of all opportunities: " + aggregate17b);
     decimal aggregate17c = ((Money)((AliasedValue)c["estimatedvalue_avg"]).Value).Value;
     System.Console.WriteLine("Average of estimated value of all opportunities: " + aggregate17c);
     System.Console.WriteLine("----------------------------------------------");
 }
 System.Console.WriteLine("===============================");

// </snippetfetchaggregationandgroupby17>
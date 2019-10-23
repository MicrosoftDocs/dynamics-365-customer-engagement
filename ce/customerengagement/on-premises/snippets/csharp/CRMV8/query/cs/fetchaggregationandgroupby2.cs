// <snippetfetchaggregationandgroupby2>


 // *****************************************************************************************************************
 //                FetchXML      opportunity_count   Aggregate 2
 // *****************************************************************************************************************
 // Fetch the count of all opportunities.  This is the equivalent of
 // SELECT COUNT(*) AS opportunity_count ... in SQL.
 string opportunity_count = @" 
 <fetch distinct='false' mapping='logical' aggregate='true'> 
     <entity name='opportunity'> 
        <attribute name='name' alias='opportunity_count' aggregate='count'/> 
     </entity> 
 </fetch>";

 EntityCollection opportunity_count_result = _serviceProxy.RetrieveMultiple(new FetchExpression(opportunity_count));

 foreach (var c in opportunity_count_result.Entities)
 {
     Int32 aggregate2 = (Int32)((AliasedValue)c["opportunity_count"]).Value;
     System.Console.WriteLine("Count of all opportunities: " + aggregate2); 

 }
 System.Console.WriteLine("===============================");

// </snippetfetchaggregationandgroupby2>
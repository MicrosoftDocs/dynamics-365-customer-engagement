// <snippetfetchaggregationandgroupby3>


 // *****************************************************************************************************************
 //                FetchXML      opportunity_colcount   Aggregate 3
 // *****************************************************************************************************************
 // Fetch the count of all opportunities.  This is the equivalent of 
 // SELECT COUNT(name) AS opportunity_count ... in SQL.
 string opportunity_colcount = @" 
 <fetch distinct='false' mapping='logical' aggregate='true'> 
     <entity name='opportunity'> 
        <attribute name='name' alias='opportunity_colcount' aggregate='countcolumn'/> 
     </entity> 
 </fetch>";

 EntityCollection opportunity_colcount_result = _serviceProxy.RetrieveMultiple(new FetchExpression(opportunity_colcount));

 foreach (var c in opportunity_colcount_result.Entities)
 {
     Int32 aggregate3 = (Int32)((AliasedValue)c["opportunity_colcount"]).Value;
     System.Console.WriteLine("Column count of all opportunities: " + aggregate3);

 }
 System.Console.WriteLine("===============================");

// </snippetfetchaggregationandgroupby3>
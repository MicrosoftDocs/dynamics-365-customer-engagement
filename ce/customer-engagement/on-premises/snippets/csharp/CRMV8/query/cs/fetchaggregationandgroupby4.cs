// <snippetfetchaggregationandgroupby4>


 // *****************************************************************************************************************
 //                FetchXML      opportunity_distcount   Aggregate 4
 // *****************************************************************************************************************
 // Fetch the count of distinct names for opportunities.  This is the equivalent of 
 // SELECT COUNT(DISTINCT name) AS opportunity_count ... in SQL.
 string opportunity_distcount = @" 
 <fetch distinct='false' mapping='logical' aggregate='true'> 
     <entity name='opportunity'> 
        <attribute name='name' alias='opportunity_distcount' aggregate='countcolumn' distinct='true'/> 
     </entity> 
 </fetch>";

 EntityCollection opportunity_distcount_result = _serviceProxy.RetrieveMultiple(new FetchExpression(opportunity_distcount));

 foreach (var c in opportunity_distcount_result.Entities)
 {
     Int32 aggregate4 = (Int32)((AliasedValue)c["opportunity_distcount"]).Value;
     System.Console.WriteLine("Distinct name count of all opportunities: " + aggregate4);

 }
 System.Console.WriteLine("===============================");

// </snippetfetchaggregationandgroupby4>
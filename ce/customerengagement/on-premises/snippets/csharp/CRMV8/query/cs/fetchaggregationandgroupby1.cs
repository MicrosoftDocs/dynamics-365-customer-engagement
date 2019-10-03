// <snippetfetchaggregationandgroupby1>


 // Fetch the average of estimatedvalue for all opportunities.  This is the equivalent of 
 // SELECT AVG(estimatedvalue) AS estimatedvalue_avg ... in SQL.
 System.Console.WriteLine("===============================");
 string estimatedvalue_avg = @" 
 <fetch distinct='false' mapping='logical' aggregate='true'> 
     <entity name='opportunity'> 
        <attribute name='estimatedvalue' alias='estimatedvalue_avg' aggregate='avg' /> 
     </entity> 
 </fetch>";

 EntityCollection estimatedvalue_avg_result = _serviceProxy.RetrieveMultiple(new FetchExpression(estimatedvalue_avg));

 foreach (var c in estimatedvalue_avg_result.Entities)
 {
     decimal aggregate1 = ((Money)((AliasedValue)c["estimatedvalue_avg"]).Value).Value;
     System.Console.WriteLine("Average estimated value: " + aggregate1);

 }
 System.Console.WriteLine("===============================");

// </snippetfetchaggregationandgroupby1>
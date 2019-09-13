// <snippetfetchaggregationandgroupby9>


 // *****************************************************************************************************************
 //                FetchXML      groupby1   Aggregate 9
 // *****************************************************************************************************************
 // Fetch a list of users with a count of all the opportunities they own using groupby.
 string groupby1 = @" 
 <fetch distinct='false' mapping='logical' aggregate='true'> 
     <entity name='opportunity'> 
        <attribute name='name' alias='opportunity_count' aggregate='countcolumn' /> 
        <attribute name='ownerid' alias='ownerid' groupby='true' /> 
     </entity> 
 </fetch>";

 EntityCollection groupby1_result = _serviceProxy.RetrieveMultiple(new FetchExpression(groupby1));

 foreach (var c in groupby1_result.Entities)
 {
     Int32 aggregate9a = (Int32)((AliasedValue)c["opportunity_count"]).Value;
     System.Console.WriteLine("Count of all opportunities: " + aggregate9a + "\n");
     string aggregate9b = ((EntityReference)((AliasedValue)c["ownerid"]).Value).Name;
     System.Console.WriteLine("Owner: " + aggregate9b);
     string aggregate9c = (string)((AliasedValue)c["ownerid_owneridyominame"]).Value;
     System.Console.WriteLine("Owner: " + aggregate9c);
     string aggregate9d = (string)((AliasedValue)c["ownerid_owneridyominame"]).Value;
     System.Console.WriteLine("Owner: " + aggregate9d);
 }
 System.Console.WriteLine("===============================");

// </snippetfetchaggregationandgroupby9>
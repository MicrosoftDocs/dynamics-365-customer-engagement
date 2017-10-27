// <snippetfetchaggregationandgroupby10>


 // *****************************************************************************************************************
 //                FetchXML      groupby2   Aggregate 10
 // *****************************************************************************************************************
 // Fetch the number of opportunities each manager's direct reports 
 // own using a groupby within a link-entity.
 string groupby2 = @" 
 <fetch distinct='false' mapping='logical' aggregate='true'> 
     <entity name='opportunity'> 
        <attribute name='name' alias='opportunity_count' aggregate='countcolumn' /> 
        <link-entity name='systemuser' from='systemuserid' to='ownerid'>
            <attribute name='parentsystemuserid' alias='managerid' groupby='true' />
        </link-entity> 
     </entity> 
 </fetch>";

 EntityCollection groupby2_result = _serviceProxy.RetrieveMultiple(new FetchExpression(groupby2));

 foreach (var c in groupby2_result.Entities)
 {

       int? aggregate10a = (int?)((AliasedValue)c["opportunity_count"]).Value;
       System.Console.WriteLine("Count of all opportunities: " + aggregate10a + "\n");
 }
 System.Console.WriteLine("===============================");

// </snippetfetchaggregationandgroupby10>
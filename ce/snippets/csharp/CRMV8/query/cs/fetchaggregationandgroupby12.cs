// <snippetfetchaggregationandgroupby12>


  // *****************************************************************************************************************
  //                FetchXML      byquarter   Aggregate 12           
  // *****************************************************************************************************************
 // Fetch aggregate information about the opportunities that have 
  // been won by quarter.(returns 1-4)
  string byquarter = @" 
  <fetch distinct='false' mapping='logical' aggregate='true'> 
      <entity name='opportunity'> 
         <attribute name='opportunityid' alias='opportunity_count' aggregate='count'/> 
         <attribute name='estimatedvalue' alias='estimatedvalue_sum' aggregate='sum'/> 
         <attribute name='estimatedvalue' alias='estimatedvalue_avg' aggregate='avg'/> 
         <attribute name='actualclosedate' groupby='true' dategrouping='quarter' alias='quarter' />
         <filter type='and'>
             <condition attribute='statecode' operator='eq' value='Won' />
         </filter>
      </entity> 
  </fetch>";

  EntityCollection byquarter_result = _serviceProxy.RetrieveMultiple(new FetchExpression(byquarter));

  foreach (var c in byquarter_result.Entities)
  {
      Int32 aggregate12 = (Int32)((AliasedValue)c["quarter"]).Value;
      System.Console.WriteLine("Quarter: " + aggregate12);
      Int32 aggregate12a = (Int32)((AliasedValue)c["opportunity_count"]).Value;
      System.Console.WriteLine("Count of all opportunities: " + aggregate12a);
      decimal aggregate12b = ((Money)((AliasedValue)c["estimatedvalue_sum"]).Value).Value;
      System.Console.WriteLine("Sum of estimated value of all opportunities: " + aggregate12b);
      decimal aggregate12c = ((Money)((AliasedValue)c["estimatedvalue_avg"]).Value).Value;
      System.Console.WriteLine("Average of estimated value of all opportunities: " + aggregate12c);
      System.Console.WriteLine("----------------------------------------------");
  }
  System.Console.WriteLine("===============================");

// </snippetfetchaggregationandgroupby12>
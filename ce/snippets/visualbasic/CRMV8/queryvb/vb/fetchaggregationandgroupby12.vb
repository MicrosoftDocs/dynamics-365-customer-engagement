' <snippetfetchaggregationandgroupby12>


  ' *****************************************************************************************************************
  '                FetchXML      byquarter   Aggregate 12           
  ' *****************************************************************************************************************
 ' Fetch aggregate information about the opportunities that have 
  ' been won by quarter.(returns 1-4)
  Dim byquarter As String = " " &amp; ControlChars.CrLf &amp; _
      "                    <fetch distinct='false' mapping='logical' aggregate='true'> " &amp; ControlChars.CrLf &amp; _
      "                        <entity name='opportunity'> " &amp; ControlChars.CrLf &amp; _
      "                           <attribute name='opportunityid' alias='opportunity_count' aggregate='count'/> " &amp; ControlChars.CrLf &amp; _
      "                           <attribute name='estimatedvalue' alias='estimatedvalue_sum' aggregate='sum'/> " &amp; ControlChars.CrLf &amp; _
      "                           <attribute name='estimatedvalue' alias='estimatedvalue_avg' aggregate='avg'/> " &amp; ControlChars.CrLf &amp; _
      "                           <attribute name='actualclosedate' groupby='true' dategrouping='quarter' alias='quarter' />" &amp; ControlChars.CrLf &amp; _
      "                           <filter type='and'>" &amp; ControlChars.CrLf &amp; _
      "                               <condition attribute='statecode' operator='eq' value='Won' />" &amp; ControlChars.CrLf &amp; _
      "                           </filter>" &amp; ControlChars.CrLf &amp; _
      "                        </entity> " &amp; ControlChars.CrLf &amp; _
      "                    </fetch>"

  Dim byquarter_result As EntityCollection = _serviceProxy.RetrieveMultiple(New FetchExpression(byquarter))

  For Each c In byquarter_result.Entities
      Dim aggregate12 As Int32 = CInt(Fix((CType(c("quarter"), AliasedValue)).Value))
      Console.WriteLine("Quarter: " &amp; aggregate12)
      Dim aggregate12a As Int32 = CInt(Fix((CType(c("opportunity_count"), AliasedValue)).Value))
      Console.WriteLine("Count of all opportunities: " &amp; aggregate12a)
      Dim aggregate12b As Decimal = (CType((CType(c("estimatedvalue_sum"), AliasedValue)).Value, Money)).Value
      Console.WriteLine("Sum of estimated value of all opportunities: " &amp; aggregate12b)
      Dim aggregate12c As Decimal = (CType((CType(c("estimatedvalue_avg"), AliasedValue)).Value, Money)).Value
      Console.WriteLine("Average of estimated value of all opportunities: " &amp; aggregate12c)
      Console.WriteLine("----------------------------------------------")
  Next c
  Console.WriteLine("===============================")

' </snippetfetchaggregationandgroupby12>
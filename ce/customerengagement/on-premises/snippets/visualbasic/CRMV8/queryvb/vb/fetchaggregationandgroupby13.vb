' <snippetfetchaggregationandgroupby13>


 ' *****************************************************************************************************************
 '                FetchXML      bymonth   Aggregate 13           
 ' *****************************************************************************************************************
 ' Fetch aggregate information about the opportunities that have 
 ' been won by month. (returns 1-12)
 Dim bymonth As String = " " &amp; ControlChars.CrLf &amp; _
     "                    <fetch distinct='false' mapping='logical' aggregate='true'> " &amp; ControlChars.CrLf &amp; _
     "                        <entity name='opportunity'> " &amp; ControlChars.CrLf &amp; _
     "                           <attribute name='opportunityid' alias='opportunity_count' aggregate='count'/> " &amp; ControlChars.CrLf &amp; _
     "                           <attribute name='estimatedvalue' alias='estimatedvalue_sum' aggregate='sum'/> " &amp; ControlChars.CrLf &amp; _
     "                           <attribute name='estimatedvalue' alias='estimatedvalue_avg' aggregate='avg'/> " &amp; ControlChars.CrLf &amp; _
     "                           <attribute name='actualclosedate' groupby='true' dategrouping='month' alias='month' />" &amp; ControlChars.CrLf &amp; _
     "                           <filter type='and'>" &amp; ControlChars.CrLf &amp; _
     "                               <condition attribute='statecode' operator='eq' value='Won' />" &amp; ControlChars.CrLf &amp; _
     "                           </filter>" &amp; ControlChars.CrLf &amp; _
     "                        </entity> " &amp; ControlChars.CrLf &amp; _
     "                    </fetch>"

 Dim bymonth_result As EntityCollection = _serviceProxy.RetrieveMultiple(New FetchExpression(bymonth))

 For Each c In bymonth_result.Entities
     Dim aggregate13 As Int32 = CInt(Fix((CType(c("month"), AliasedValue)).Value))
     Console.WriteLine("Month: " &amp; aggregate13)
     Dim aggregate13a As Int32 = CInt(Fix((CType(c("opportunity_count"), AliasedValue)).Value))
     Console.WriteLine("Count of all opportunities: " &amp; aggregate13a)
     Dim aggregate13b As Decimal = (CType((CType(c("estimatedvalue_sum"), AliasedValue)).Value, Money)).Value
     Console.WriteLine("Sum of estimated value of all opportunities: " &amp; aggregate13b)
     Dim aggregate13c As Decimal = (CType((CType(c("estimatedvalue_avg"), AliasedValue)).Value, Money)).Value
     Console.WriteLine("Average of estimated value of all opportunities: " &amp; aggregate13c)
     Console.WriteLine("----------------------------------------------")
 Next c
 Console.WriteLine("===============================")

' </snippetfetchaggregationandgroupby13>
' <snippetfetchaggregationandgroupby15>


 ' *****************************************************************************************************************
 '                FetchXML      byday   Aggregate 15           
 ' *****************************************************************************************************************
 ' Fetch aggregate information about the opportunities that have 
 ' been won by day. (Returns 1-31)
 Dim byday As String = " " &amp; ControlChars.CrLf &amp; _
     "                    <fetch distinct='false' mapping='logical' aggregate='true'> " &amp; ControlChars.CrLf &amp; _
     "                        <entity name='opportunity'> " &amp; ControlChars.CrLf &amp; _
     "                           <attribute name='opportunityid' alias='opportunity_count' aggregate='count'/> " &amp; ControlChars.CrLf &amp; _
     "                           <attribute name='estimatedvalue' alias='estimatedvalue_sum' aggregate='sum'/> " &amp; ControlChars.CrLf &amp; _
     "                           <attribute name='estimatedvalue' alias='estimatedvalue_avg' aggregate='avg'/> " &amp; ControlChars.CrLf &amp; _
     "                           <attribute name='actualclosedate' groupby='true' dategrouping='day' alias='day' />" &amp; ControlChars.CrLf &amp; _
     "                           <filter type='and'>" &amp; ControlChars.CrLf &amp; _
     "                               <condition attribute='statecode' operator='eq' value='Won' />" &amp; ControlChars.CrLf &amp; _
     "                           </filter>" &amp; ControlChars.CrLf &amp; _
     "                        </entity> " &amp; ControlChars.CrLf &amp; _
     "                    </fetch>"

 Dim byday_result As EntityCollection = _serviceProxy.RetrieveMultiple(New FetchExpression(byday))

 For Each c In byday_result.Entities
     Dim aggregate15 As Int32 = CInt(Fix((CType(c("day"), AliasedValue)).Value))
     Console.WriteLine("Day: " &amp; aggregate15)
     Dim aggregate15a As Int32 = CInt(Fix((CType(c("opportunity_count"), AliasedValue)).Value))
     Console.WriteLine("Count of all opportunities: " &amp; aggregate15a)
     Dim aggregate15b As Decimal = (CType((CType(c("estimatedvalue_sum"), AliasedValue)).Value, Money)).Value
     Console.WriteLine("Sum of estimated value of all opportunities: " &amp; aggregate15b)
     Dim aggregate15c As Decimal = (CType((CType(c("estimatedvalue_avg"), AliasedValue)).Value, Money)).Value
     Console.WriteLine("Average of estimated value of all opportunities: " &amp; aggregate15c)
     Console.WriteLine("----------------------------------------------")
 Next c
 Console.WriteLine("===============================")

' </snippetfetchaggregationandgroupby15>
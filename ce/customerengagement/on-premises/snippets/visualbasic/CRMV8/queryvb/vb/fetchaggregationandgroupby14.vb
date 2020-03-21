' <snippetfetchaggregationandgroupby14>


 ' *****************************************************************************************************************
 '                FetchXML      byweek   Aggregate 14           
 ' *****************************************************************************************************************
 ' Fetch aggregate information about the opportunities that have 
 ' been won by week. (Returns 1-52)
 Dim byweek As String = " " &amp; ControlChars.CrLf &amp; _
     "                    <fetch distinct='false' mapping='logical' aggregate='true'> " &amp; ControlChars.CrLf &amp; _
     "                        <entity name='opportunity'> " &amp; ControlChars.CrLf &amp; _
     "                           <attribute name='opportunityid' alias='opportunity_count' aggregate='count'/> " &amp; ControlChars.CrLf &amp; _
     "                           <attribute name='estimatedvalue' alias='estimatedvalue_sum' aggregate='sum'/> " &amp; ControlChars.CrLf &amp; _
     "                           <attribute name='estimatedvalue' alias='estimatedvalue_avg' aggregate='avg'/> " &amp; ControlChars.CrLf &amp; _
     "                           <attribute name='actualclosedate' groupby='true' dategrouping='week' alias='week' />" &amp; ControlChars.CrLf &amp; _
     "                           <filter type='and'>" &amp; ControlChars.CrLf &amp; _
     "                               <condition attribute='statecode' operator='eq' value='Won' />" &amp; ControlChars.CrLf &amp; _
     "                           </filter>" &amp; ControlChars.CrLf &amp; "                        </entity> " &amp; ControlChars.CrLf &amp; _
     "                    </fetch>"

 Dim byweek_result As EntityCollection = _serviceProxy.RetrieveMultiple(New FetchExpression(byweek))

 For Each c In byweek_result.Entities
     Dim aggregate14 As Int32 = CInt(Fix((CType(c("week"), AliasedValue)).Value))
     Console.WriteLine("Week: " &amp; aggregate14)
     Dim aggregate14a As Int32 = CInt(Fix((CType(c("opportunity_count"), AliasedValue)).Value))
     Console.WriteLine("Count of all opportunities: " &amp; aggregate14a)
     Dim aggregate14b As Decimal = (CType((CType(c("estimatedvalue_sum"), AliasedValue)).Value, Money)).Value
     Console.WriteLine("Sum of estimated value of all opportunities: " &amp; aggregate14b)
     Dim aggregate14c As Decimal = (CType((CType(c("estimatedvalue_avg"), AliasedValue)).Value, Money)).Value
     Console.WriteLine("Average of estimated value of all opportunities: " &amp; aggregate14c)
     Console.WriteLine("----------------------------------------------")
 Next c
 Console.WriteLine("===============================")

' </snippetfetchaggregationandgroupby14>
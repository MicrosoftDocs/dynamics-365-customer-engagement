' <snippetfetchaggregationandgroupby11>


 ' *****************************************************************************************************************
 '                FetchXML      byyear   Aggregate 11           
 ' *****************************************************************************************************************
 ' Fetch aggregate information about the opportunities that have 
 ' been won by year.
 Dim byyear As String = " " &amp; ControlChars.CrLf &amp; _
     "                    <fetch distinct='false' mapping='logical' aggregate='true'> " &amp; ControlChars.CrLf &amp; _
     "                        <entity name='opportunity'> " &amp; ControlChars.CrLf &amp; _
     "                           <attribute name='opportunityid' alias='opportunity_count' aggregate='count'/> " &amp; ControlChars.CrLf &amp; _
     "                           <attribute name='estimatedvalue' alias='estimatedvalue_sum' aggregate='sum'/> " &amp; ControlChars.CrLf &amp; _
     "                           <attribute name='estimatedvalue' alias='estimatedvalue_avg' aggregate='avg'/> " &amp; ControlChars.CrLf &amp; _
     "                           <attribute name='actualclosedate' groupby='true' dategrouping='year' alias='year' />" &amp; ControlChars.CrLf &amp; _
     "                           <filter type='and'>" &amp; ControlChars.CrLf &amp; _
     "                               <condition attribute='statecode' operator='eq' value='Won' />" &amp; ControlChars.CrLf &amp; _
     "                           </filter>" &amp; ControlChars.CrLf &amp; "                        </entity> " &amp; ControlChars.CrLf &amp; _
     "                    </fetch>"

 Dim byyear_result As EntityCollection = _serviceProxy.RetrieveMultiple(New FetchExpression(byyear))

 For Each c In byyear_result.Entities
     Dim aggregate11 As Int32 = CInt(Fix((CType(c("year"), AliasedValue)).Value))
     Console.WriteLine("Year: " &amp; aggregate11)
     Dim aggregate11a As Int32 = CInt(Fix((CType(c("opportunity_count"), AliasedValue)).Value))
     Console.WriteLine("Count of all opportunities: " &amp; aggregate11a)
     Dim aggregate11b As Decimal = (CType((CType(c("estimatedvalue_sum"), AliasedValue)).Value, Money)).Value
     Console.WriteLine("Sum of estimated value of all opportunities: " &amp; aggregate11b)
     Dim aggregate11c As Decimal = (CType((CType(c("estimatedvalue_avg"), AliasedValue)).Value, Money)).Value
     Console.WriteLine("Average of estimated value of all opportunities: " &amp; aggregate11c)
     Console.WriteLine("----------------------------------------------")
 Next c
 Console.WriteLine("===============================")

' </snippetfetchaggregationandgroupby11>
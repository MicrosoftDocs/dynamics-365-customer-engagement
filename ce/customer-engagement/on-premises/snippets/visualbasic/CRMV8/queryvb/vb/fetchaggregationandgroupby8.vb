' <snippetfetchaggregationandgroupby8>


 ' *****************************************************************************************************************
 '                FetchXML      estimatedvalue_avg, estimatedvalue_sum   Aggregate 8
 ' *****************************************************************************************************************
 ' Fetch multiple aggregate values within a single query.
 Dim estimatedvalue_avg2 As String = " " &amp; ControlChars.CrLf &amp; _
     "                    <fetch distinct='false' mapping='logical' aggregate='true'> " &amp; ControlChars.CrLf &amp; _
     "                        <entity name='opportunity'> " &amp; ControlChars.CrLf &amp; _
     "                           <attribute name='opportunityid' alias='opportunity_count' aggregate='count'/> " &amp; ControlChars.CrLf &amp; _
     "                           <attribute name='estimatedvalue' alias='estimatedvalue_sum' aggregate='sum'/> " &amp; ControlChars.CrLf &amp; _
     "                           <attribute name='estimatedvalue' alias='estimatedvalue_avg' aggregate='avg'/> " &amp; ControlChars.CrLf &amp; _
     "                        </entity> " &amp; ControlChars.CrLf &amp; _
     "                    </fetch>"

 Dim estimatedvalue_avg2_result As EntityCollection = _serviceProxy.RetrieveMultiple(New FetchExpression(estimatedvalue_avg2))

 For Each c In estimatedvalue_avg2_result.Entities
     Dim aggregate8a As Int32 = CInt(Fix((CType(c("opportunity_count"), AliasedValue)).Value))
     Console.WriteLine("Count of all opportunities: " &amp; aggregate8a)
     Dim aggregate8b As Decimal = (CType((CType(c("estimatedvalue_sum"), AliasedValue)).Value, Money)).Value
     Console.WriteLine("Sum of estimated value of all opportunities: " &amp; aggregate8b)
     Dim aggregate8c As Decimal = (CType((CType(c("estimatedvalue_avg"), AliasedValue)).Value, Money)).Value
     Console.WriteLine("Average of estimated value of all opportunities: " &amp; aggregate8c)

 Next c
 Console.WriteLine("===============================")

' </snippetfetchaggregationandgroupby8>
' <snippetfetchaggregationandgroupby2>


 ' *****************************************************************************************************************
 '                FetchXML      opportunity_count   Aggregate 2
 ' *****************************************************************************************************************
 ' Fetch the count of all opportunities.  This is the equivalent of
 ' SELECT COUNT(*) AS opportunity_count ... in SQL.
 Dim opportunity_count As String = " " &amp; ControlChars.CrLf &amp; _
     "                    <fetch distinct='false' mapping='logical' aggregate='true'> " &amp; ControlChars.CrLf &amp; _
     "                        <entity name='opportunity'> " &amp; ControlChars.CrLf &amp; _
     "                           <attribute name='name' alias='opportunity_count' aggregate='count'/> " &amp; ControlChars.CrLf &amp; _
     "                        </entity> " &amp; ControlChars.CrLf &amp; _
     "                    </fetch>"

 Dim opportunity_count_result As EntityCollection = _serviceProxy.RetrieveMultiple(New FetchExpression(opportunity_count))

 For Each c In opportunity_count_result.Entities
     Dim aggregate2 As Int32 = CInt(Fix((CType(c("opportunity_count"), AliasedValue)).Value))
     Console.WriteLine("Count of all opportunities: " &amp; aggregate2)

 Next c
 Console.WriteLine("===============================")

' </snippetfetchaggregationandgroupby2>
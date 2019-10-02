' <snippetfetchaggregationandgroupby4>


 ' *****************************************************************************************************************
 '                FetchXML      opportunity_distcount   Aggregate 4
 ' *****************************************************************************************************************
 ' Fetch the count of distinct names for opportunities.  This is the equivalent of 
 ' SELECT COUNT(DISTINCT name) AS opportunity_count ... in SQL.
 Dim opportunity_distcount As String = " " &amp; ControlChars.CrLf &amp; _
     "                    <fetch distinct='false' mapping='logical' aggregate='true'> " &amp; ControlChars.CrLf &amp; _
     "                        <entity name='opportunity'> " &amp; ControlChars.CrLf &amp; _
     "                           <attribute name='name' alias='opportunity_distcount' aggregate='countcolumn' distinct='true'/> " &amp; ControlChars.CrLf &amp; _
     "                        </entity> " &amp; ControlChars.CrLf &amp; _
     "                    </fetch>"

 Dim opportunity_distcount_result As EntityCollection = _serviceProxy.RetrieveMultiple(New FetchExpression(opportunity_distcount))

 For Each c In opportunity_distcount_result.Entities
     Dim aggregate4 As Int32 = CInt(Fix((CType(c("opportunity_distcount"), AliasedValue)).Value))
     Console.WriteLine("Distinct name count of all opportunities: " &amp; aggregate4)

 Next c
 Console.WriteLine("===============================")

' </snippetfetchaggregationandgroupby4>
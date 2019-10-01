' <snippetfetchaggregationandgroupby3>


 ' *****************************************************************************************************************
 '                FetchXML      opportunity_colcount   Aggregate 3
 ' *****************************************************************************************************************
 ' Fetch the count of all opportunities.  This is the equivalent of 
 ' SELECT COUNT(name) AS opportunity_count ... in SQL.
 Dim opportunity_colcount As String = " " &amp; ControlChars.CrLf &amp; _
     "                    <fetch distinct='false' mapping='logical' aggregate='true'> " &amp; ControlChars.CrLf &amp; _
     "                        <entity name='opportunity'> " &amp; ControlChars.CrLf &amp; _
     "                           <attribute name='name' alias='opportunity_colcount' aggregate='countcolumn'/> " &amp; ControlChars.CrLf &amp; _
     "                        </entity> " &amp; ControlChars.CrLf &amp; _
     "                    </fetch>"

 Dim opportunity_colcount_result As EntityCollection = _serviceProxy.RetrieveMultiple(New FetchExpression(opportunity_colcount))

 For Each c In opportunity_colcount_result.Entities
     Dim aggregate3 As Int32 = CInt(Fix((CType(c("opportunity_colcount"), AliasedValue)).Value))
     Console.WriteLine("Column count of all opportunities: " &amp; aggregate3)

 Next c
 Console.WriteLine("===============================")

' </snippetfetchaggregationandgroupby3>
' <snippetfetchaggregationandgroupby1>


 ' Fetch the average of estimatedvalue for all opportunities.  This is the equivalent of 
 ' SELECT AVG(estimatedvalue) AS estimatedvalue_avg ... in SQL.
 Console.WriteLine("===============================")
 Dim estimatedvalue_avg As String = " " &amp; ControlChars.CrLf &amp; _
     "                    <fetch distinct='false' mapping='logical' aggregate='true'> " &amp; ControlChars.CrLf &amp; _
     "                        <entity name='opportunity'> " &amp; ControlChars.CrLf &amp; _
     "                           <attribute name='estimatedvalue' alias='estimatedvalue_avg' aggregate='avg' /> " &amp; ControlChars.CrLf &amp; _
     "                        </entity> " &amp; ControlChars.CrLf &amp; _
     "                    </fetch>"

 Dim estimatedvalue_avg_result As EntityCollection = _serviceProxy.RetrieveMultiple(New FetchExpression(estimatedvalue_avg))

 For Each c In estimatedvalue_avg_result.Entities
     Dim aggregate1 As Decimal = (CType((CType(c("estimatedvalue_avg"), AliasedValue)).Value, Money)).Value
     Console.WriteLine("Average estimated value: " &amp; aggregate1)

 Next c
 Console.WriteLine("===============================")

' </snippetfetchaggregationandgroupby1>
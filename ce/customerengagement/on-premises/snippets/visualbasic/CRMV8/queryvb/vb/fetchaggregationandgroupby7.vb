' <snippetfetchaggregationandgroupby7>


 ' *****************************************************************************************************************
 '                FetchXML      estimatedvalue_sum   Aggregate 7
 ' *****************************************************************************************************************
 ' Fetch the sum of estimatedvalue for all opportunities.  This is the equivalent of 
 ' SELECT SUM(estimatedvalue) AS estimatedvalue_sum ... in SQL.
 Dim estimatedvalue_sum As String = " " &amp; ControlChars.CrLf &amp; _
     "                    <fetch distinct='false' mapping='logical' aggregate='true'> " &amp; ControlChars.CrLf &amp; _
     "                        <entity name='opportunity'> " &amp; ControlChars.CrLf &amp; _
     "                           <attribute name='estimatedvalue' alias='estimatedvalue_sum' aggregate='sum' /> " &amp; ControlChars.CrLf &amp; _
     "                        </entity> " &amp; ControlChars.CrLf &amp; _
     "                    </fetch>"

 Dim estimatedvalue_sum_result As EntityCollection = _serviceProxy.RetrieveMultiple(New FetchExpression(estimatedvalue_sum))

 For Each c In estimatedvalue_sum_result.Entities
     Dim aggregate7 As Decimal = (CType((CType(c("estimatedvalue_sum"), AliasedValue)).Value, Money)).Value
     Console.WriteLine("Sum of estimated value of all opportunities: " &amp; aggregate7)

 Next c
 Console.WriteLine("===============================")

' </snippetfetchaggregationandgroupby7>
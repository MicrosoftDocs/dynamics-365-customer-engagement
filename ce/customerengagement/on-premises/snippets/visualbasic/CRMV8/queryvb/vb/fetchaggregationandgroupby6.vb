' <snippetfetchaggregationandgroupby6>


 ' *****************************************************************************************************************
 '                FetchXML      estimatedvalue_min   Aggregate 6
 ' *****************************************************************************************************************
 ' Fetch the minimum estimatedvalue of all opportunities.  This is the equivalent of 
 ' SELECT MIN(estimatedvalue) AS estimatedvalue_min ... in SQL.
 Dim estimatedvalue_min As String = " " &amp; ControlChars.CrLf &amp; _
     "                    <fetch distinct='false' mapping='logical' aggregate='true'> " &amp; ControlChars.CrLf &amp; _
     "                        <entity name='opportunity'> " &amp; ControlChars.CrLf &amp; _
     "                           <attribute name='estimatedvalue' alias='estimatedvalue_min' aggregate='min' /> " &amp; ControlChars.CrLf &amp; _
     "                        </entity> " &amp; ControlChars.CrLf &amp; _
     "                    </fetch>"

 Dim estimatedvalue_min_result As EntityCollection = _serviceProxy.RetrieveMultiple(New FetchExpression(estimatedvalue_min))

 For Each c In estimatedvalue_min_result.Entities
     Dim aggregate6 As Decimal = (CType((CType(c("estimatedvalue_min"), AliasedValue)).Value, Money)).Value
     Console.WriteLine("Minimum estimated value of all opportunities: " &amp; aggregate6)

 Next c
 Console.WriteLine("===============================")

' </snippetfetchaggregationandgroupby6>
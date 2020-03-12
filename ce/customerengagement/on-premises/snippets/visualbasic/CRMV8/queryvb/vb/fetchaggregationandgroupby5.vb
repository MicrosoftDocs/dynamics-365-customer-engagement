' <snippetfetchaggregationandgroupby5>


 ' *****************************************************************************************************************
 '                FetchXML      estimatedvalue_max   Aggregate 5
 ' *****************************************************************************************************************
 ' Fetch the maximum estimatedvalue of all opportunities.  This is the equivalent of 
 ' SELECT MAX(estimatedvalue) AS estimatedvalue_max ... in SQL.
 Dim estimatedvalue_max As String = " " &amp; ControlChars.CrLf &amp; _
     "                    <fetch distinct='false' mapping='logical' aggregate='true'> " &amp; ControlChars.CrLf &amp; _
     "                        <entity name='opportunity'> " &amp; ControlChars.CrLf &amp; _
     "                           <attribute name='estimatedvalue' alias='estimatedvalue_max' aggregate='max' /> " &amp; ControlChars.CrLf &amp; _
     "                        </entity> " &amp; ControlChars.CrLf &amp; _
     "                    </fetch>"

 Dim estimatedvalue_max_result As EntityCollection = _serviceProxy.RetrieveMultiple(New FetchExpression(estimatedvalue_max))

 For Each c In estimatedvalue_max_result.Entities
     Dim aggregate5 As Decimal = (CType((CType(c("estimatedvalue_max"), AliasedValue)).Value, Money)).Value
     Console.WriteLine("Max estimated value of all opportunities: " &amp; aggregate5)

 Next c
 Console.WriteLine("===============================")

' </snippetfetchaggregationandgroupby5>
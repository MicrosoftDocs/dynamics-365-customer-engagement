' <snippetfetchaggregationandgroupby9>


 ' *****************************************************************************************************************
 '                FetchXML      groupby1   Aggregate 9
 ' *****************************************************************************************************************
 ' Fetch a list of users with a count of all the opportunities they own using groupby.
 Dim groupby1 As String = " " &amp; ControlChars.CrLf &amp; _
     "                    <fetch distinct='false' mapping='logical' aggregate='true'> " &amp; ControlChars.CrLf &amp; _
     "                        <entity name='opportunity'> " &amp; ControlChars.CrLf &amp; _
     "                           <attribute name='name' alias='opportunity_count' aggregate='countcolumn' /> " &amp; ControlChars.CrLf &amp; _
     "                           <attribute name='ownerid' alias='ownerid' groupby='true' /> " &amp; ControlChars.CrLf &amp; _
     "                        </entity> " &amp; ControlChars.CrLf &amp; _
     "                    </fetch>"

 Dim groupby1_result As EntityCollection = _serviceProxy.RetrieveMultiple(New FetchExpression(groupby1))

 For Each c In groupby1_result.Entities
     Dim aggregate9a As Int32 = CInt(Fix((CType(c("opportunity_count"), AliasedValue)).Value))
     Console.WriteLine("Count of all opportunities: " &amp; aggregate9a &amp; vbLf)
     Dim aggregate9b As String = (CType((CType(c("ownerid"), AliasedValue)).Value, EntityReference)).Name
     Console.WriteLine("Owner: " &amp; aggregate9b)
     Dim aggregate9c As String = CStr((CType(c("ownerid_owneridyominame"), AliasedValue)).Value)
     Console.WriteLine("Owner: " &amp; aggregate9c)
     Dim aggregate9d As String = CStr((CType(c("ownerid_owneridyominame"), AliasedValue)).Value)
     Console.WriteLine("Owner: " &amp; aggregate9d)
 Next c
 Console.WriteLine("===============================")

' </snippetfetchaggregationandgroupby9>
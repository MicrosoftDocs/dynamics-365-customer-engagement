' <snippetfetchaggregationandgroupby10>


 ' *****************************************************************************************************************
 '                FetchXML      groupby2   Aggregate 10
 ' *****************************************************************************************************************
 ' Fetch the number of opportunities each manager's direct reports 
 ' own using a groupby within a link-entity.
 Dim groupby2 As String = " " &amp; ControlChars.CrLf &amp; _
     "                    <fetch distinct='false' mapping='logical' aggregate='true'> " &amp; ControlChars.CrLf &amp; _
     "                        <entity name='opportunity'> " &amp; ControlChars.CrLf &amp; _
     "                           <attribute name='name' alias='opportunity_count' aggregate='countcolumn' /> " &amp; ControlChars.CrLf &amp; _
     "                           <link-entity name='systemuser' from='systemuserid' to='ownerid'>" &amp; ControlChars.CrLf &amp; _
     "                               <attribute name='parentsystemuserid' alias='managerid' groupby='true' />" &amp; ControlChars.CrLf &amp; _
     "                           </link-entity> " &amp; ControlChars.CrLf &amp; _
     "                        </entity> " &amp; ControlChars.CrLf &amp; _
     "                    </fetch>"

 Dim groupby2_result As EntityCollection = _serviceProxy.RetrieveMultiple(New FetchExpression(groupby2))

 For Each c In groupby2_result.Entities

       Dim aggregate10a? As Integer = CType((CType(c("opportunity_count"), AliasedValue)).Value, Integer?)
       Console.WriteLine("Count of all opportunities: " &amp; aggregate10a &amp; vbLf)
 Next c
 Console.WriteLine("===============================")

' </snippetfetchaggregationandgroupby10>
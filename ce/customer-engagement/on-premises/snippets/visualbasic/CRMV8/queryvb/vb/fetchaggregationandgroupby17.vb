' <snippetfetchaggregationandgroupby17>


 ' *****************************************************************************************************************
 '                FetchXML      byyrqtr2   Aggregate 17           
 ' *****************************************************************************************************************
 ' Specify the result order for the previous sample.  Order by year, then quarter.
 Dim byyrqtr2 As String = " " &amp; ControlChars.CrLf &amp; _
     "                    <fetch distinct='false' mapping='logical' aggregate='true'> " &amp; ControlChars.CrLf &amp; _
     "                        <entity name='opportunity'> " &amp; ControlChars.CrLf &amp; _
     "                           <attribute name='opportunityid' alias='opportunity_count' aggregate='count'/> " &amp; ControlChars.CrLf &amp; _
     "                           <attribute name='estimatedvalue' alias='estimatedvalue_sum' aggregate='sum'/> " &amp; ControlChars.CrLf &amp; _
     "                           <attribute name='estimatedvalue' alias='estimatedvalue_avg' aggregate='avg'/> " &amp; ControlChars.CrLf &amp; _
     "                           <attribute name='actualclosedate' groupby='true' dategrouping='quarter' alias='quarter' />" &amp; ControlChars.CrLf &amp; _
     "                           <attribute name='actualclosedate' groupby='true' dategrouping='year' alias='year' />" &amp; ControlChars.CrLf &amp; _
     "                           <order alias='year' descending='false' />" &amp; ControlChars.CrLf &amp; _
     "                           <order alias='quarter' descending='false' />" &amp; ControlChars.CrLf &amp; _
     "                           <filter type='and'>" &amp; ControlChars.CrLf &amp; _
     "                               <condition attribute='statecode' operator='eq' value='Won' />" &amp; ControlChars.CrLf &amp; _
     "                           </filter>" &amp; ControlChars.CrLf &amp; _
     "                        </entity> " &amp; ControlChars.CrLf &amp; _
     "                    </fetch>"

 Dim byyrqtr2_result As EntityCollection = _serviceProxy.RetrieveMultiple(New FetchExpression(byyrqtr2))

 For Each c In byyrqtr2_result.Entities
     Dim aggregate17 As Int32 = CInt(Fix((CType(c("quarter"), AliasedValue)).Value))
     Console.WriteLine("Quarter: " &amp; aggregate17)
     Dim aggregate17d As Int32 = CInt(Fix((CType(c("year"), AliasedValue)).Value))
     Console.WriteLine("Year: " &amp; aggregate17d)
     Dim aggregate17a As Int32 = CInt(Fix((CType(c("opportunity_count"), AliasedValue)).Value))
     Console.WriteLine("Count of all opportunities: " &amp; aggregate17a)
     Dim aggregate17b As Decimal = (CType((CType(c("estimatedvalue_sum"), AliasedValue)).Value, Money)).Value
     Console.WriteLine("Sum of estimated value of all opportunities: " &amp; aggregate17b)
     Dim aggregate17c As Decimal = (CType((CType(c("estimatedvalue_avg"), AliasedValue)).Value, Money)).Value
     Console.WriteLine("Average of estimated value of all opportunities: " &amp; aggregate17c)
     Console.WriteLine("----------------------------------------------")
 Next c
 Console.WriteLine("===============================")

' </snippetfetchaggregationandgroupby17>
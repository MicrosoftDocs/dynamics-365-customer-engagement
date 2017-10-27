' <snippetfetchaggregationandgroupby16>


 ' *****************************************************************************************************************
 '                FetchXML      byyrqtr   Aggregate 16           
 ' *****************************************************************************************************************
 ' Fetch aggregate information about the opportunities that have 
 ' been won by year and quarter.
 Dim byyrqtr As String = " " &amp; ControlChars.CrLf &amp; _
     "                    <fetch distinct='false' mapping='logical' aggregate='true'> " &amp; ControlChars.CrLf &amp; _
     "                        <entity name='opportunity'> " &amp; ControlChars.CrLf &amp; _
     "                           <attribute name='opportunityid' alias='opportunity_count' aggregate='count'/> " &amp; ControlChars.CrLf &amp; _
     "                           <attribute name='estimatedvalue' alias='estimatedvalue_sum' aggregate='sum'/> " &amp; ControlChars.CrLf &amp; _
     "                           <attribute name='estimatedvalue' alias='estimatedvalue_avg' aggregate='avg'/> " &amp; ControlChars.CrLf &amp; _
     "                           <attribute name='actualclosedate' groupby='true' dategrouping='quarter' alias='quarter' />" &amp; ControlChars.CrLf &amp; _
     "                           <attribute name='actualclosedate' groupby='true' dategrouping='year' alias='year' />" &amp; ControlChars.CrLf &amp; _
     "                           <filter type='and'>" &amp; ControlChars.CrLf &amp; _
     "                               <condition attribute='statecode' operator='eq' value='Won' />" &amp; ControlChars.CrLf &amp; _
     "                           </filter>" &amp; ControlChars.CrLf &amp; _
     "                        </entity> " &amp; ControlChars.CrLf &amp; _
     "                    </fetch>"

 Dim byyrqtr_result As EntityCollection = _serviceProxy.RetrieveMultiple(New FetchExpression(byyrqtr))

 For Each c In byyrqtr_result.Entities
     Dim aggregate16d As Int32 = CInt(Fix((CType(c("year"), AliasedValue)).Value))
     Console.WriteLine("Year: " &amp; aggregate16d)
     Dim aggregate16 As Int32 = CInt(Fix((CType(c("quarter"), AliasedValue)).Value))
     Console.WriteLine("Quarter: " &amp; aggregate16)
     Dim aggregate16a As Int32 = CInt(Fix((CType(c("opportunity_count"), AliasedValue)).Value))
     Console.WriteLine("Count of all opportunities: " &amp; aggregate16a)
     Dim aggregate16b As Decimal = (CType((CType(c("estimatedvalue_sum"), AliasedValue)).Value, Money)).Value
     Console.WriteLine("Sum of estimated value of all opportunities: " &amp; aggregate16b)
     Dim aggregate16c As Decimal = (CType((CType(c("estimatedvalue_avg"), AliasedValue)).Value, Money)).Value
     Console.WriteLine("Average of estimated value of all opportunities: " &amp; aggregate16c)
     Console.WriteLine("----------------------------------------------")
 Next c
 Console.WriteLine("===============================")

' </snippetfetchaggregationandgroupby16>
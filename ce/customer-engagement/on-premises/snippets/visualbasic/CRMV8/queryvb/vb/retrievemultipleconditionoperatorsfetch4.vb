' <snippetretrievemultipleconditionoperatorsfetch4>


 fetchXml = "<fetch>" &amp; ControlChars.CrLf &amp; _
     "                                    <entity name='opportunity'>" &amp; ControlChars.CrLf &amp; _
     "                                            <attribute name='name'/>" &amp; ControlChars.CrLf &amp; _
     "                                            <filter type='and'>" &amp; ControlChars.CrLf &amp; _
     "                                                    <condition attribute='estimatedclosedate'" &amp; ControlChars.CrLf &amp; _
     "                                                               operator='next-x-fiscal-years'" &amp; ControlChars.CrLf &amp; _
     "                                                               value='3'/>" &amp; ControlChars.CrLf &amp; _
     "                                            </filter>" &amp; ControlChars.CrLf &amp; _
     "                                    </entity>" &amp; ControlChars.CrLf &amp; _
     "                                </fetch>"

 ' Build fetch request and obtain results.
 efr = New RetrieveMultipleRequest() With {.Query = New FetchExpression(fetchXml)}
 entityResults = (CType(_service.Execute(efr), RetrieveMultipleResponse)).EntityCollection

                     ' Display results.
 Console.WriteLine("List all opportunities with estimated close date in next 3 fiscal years")
 Console.WriteLine("=======================================================================")
 For Each e In entityResults.Entities
     Console.WriteLine("Fetch Retrieved: {0}", e.Attributes("name"))
 Next e

 Console.WriteLine("<End of Listing>")
 Console.WriteLine()

' </snippetretrievemultipleconditionoperatorsfetch4>
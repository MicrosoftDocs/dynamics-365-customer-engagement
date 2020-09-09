' <snippetretrievemultipleconditionoperatorsfetch5>


 fetchXml = "<fetch>" &amp; ControlChars.CrLf &amp; _
     "                                    <entity name='salesorder'>" &amp; ControlChars.CrLf &amp; _
     "                                            <attribute name='name'/>" &amp; ControlChars.CrLf &amp; _
     "                                            <filter type='and'>" &amp; ControlChars.CrLf &amp; "                                                    <condition attribute='datefulfilled'" &amp; ControlChars.CrLf &amp; "                                                               operator='in-fiscal-year'" &amp; ControlChars.CrLf &amp; "                                                               value='2008'/>" &amp; ControlChars.CrLf &amp; "                                            </filter>" &amp; ControlChars.CrLf &amp; "                                    </entity>" &amp; ControlChars.CrLf &amp; "                                </fetch>"

 ' Build fetch request and obtain results.
 efr = New RetrieveMultipleRequest() With {.Query = New FetchExpression(fetchXml)}
 entityResults = (CType(_service.Execute(efr), RetrieveMultipleResponse)).EntityCollection


 ' Display results.
 Console.WriteLine("List all orders fulfilled in fiscal year 2008")
 Console.WriteLine("=============================================")
 For Each e In entityResults.Entities
     Console.WriteLine("Fetch Retrieved: {0}", e.Attributes("name"))
 Next e
 Console.WriteLine("<End of Listing>")
 Console.WriteLine()

' </snippetretrievemultipleconditionoperatorsfetch5>
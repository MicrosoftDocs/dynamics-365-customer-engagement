' <snippetretrievemultipleconditionoperatorsfetch3>


 fetchXml = "<fetch>" &amp; ControlChars.CrLf &amp; _
     "                                    <entity name='salesorder'>" &amp; ControlChars.CrLf &amp; _
     "                                        <attribute name='name'/>" &amp; ControlChars.CrLf &amp; _
     "                                        <filter type='and'>" &amp; ControlChars.CrLf &amp; _
     "                                            <condition attribute='datefulfilled' " &amp; ControlChars.CrLf &amp; _
     "                                                operator='last-fiscal-period'/>" &amp; ControlChars.CrLf &amp; _
     "                                        </filter>" &amp; ControlChars.CrLf &amp; _
     "                                    </entity>" &amp; ControlChars.CrLf &amp; _
     "                                </fetch>"

 ' Build fetch request and obtain results.
 efr = New RetrieveMultipleRequest() With {.Query = New FetchExpression(fetchXml)}
 entityResults = (CType(_service.Execute(efr), RetrieveMultipleResponse)).EntityCollection

 ' Display results.
 Console.WriteLine("List all orders fulfilled in the last fiscal period")
 Console.WriteLine("===================================================")
 For Each e In entityResults.Entities
     Console.WriteLine("Fetch Retrieved: {0}", e.Attributes("name"))
 Next e

 Console.WriteLine("<End of Listing>")
 Console.WriteLine()

' </snippetretrievemultipleconditionoperatorsfetch3>
' <snippetretrievemultipleconditionoperatorsfetch2>


 ' Build the following SQL query using QueryExpression:
 '
 '        SELECT contact.fullname, contact.address1_telephone1
 '        FROM contact
 '            LEFT OUTER JOIN account
 '                ON contact.parentcustomerid = account.accountid
 '                AND
 '                account.name = 'Litware, Inc.'
 '        WHERE (contact.address1_stateorprovince = 'WA'
 '        AND
 '            contact.address1_city in ('Redmond', 'Bellevue', 'Kirkland', 'Seattle')
 '        AND 
 '            contact.address1_telephone1 like '(206)%'
 '            OR
 '            contact.address1_telephone1 like '(425)%'
 '        AND
 '            DATEDIFF(DAY, contact.createdon, GETDATE()) > 0
 '        AND
 '            DATEDIFF(DAY, contact.createdon, GETDATE()) < 30
 '        AND
 '            contact.emailaddress1 Not NULL
 '               )

 Dim fetchXml As String = "<fetch mapping=""logical"" count=""50"" version=""1.0"">" &amp; ControlChars.CrLf &amp; _
     "                                            <entity name=""contact"">" &amp; ControlChars.CrLf &amp; _
     "                                                <attribute name=""address1_telephone1"" />" &amp; ControlChars.CrLf &amp; _
     "                                                <attribute name=""contactid"" />" &amp; ControlChars.CrLf &amp; _
     "                                                <attribute name=""firstname"" />" &amp; ControlChars.CrLf &amp; _
     "                                                <attribute name=""lastname"" />" &amp; ControlChars.CrLf &amp; _
     "                                                <filter>" &amp; ControlChars.CrLf &amp; _
     "                                                    <condition attribute=""address1_stateorprovince"" operator=""eq"" " &amp; _
     "                                                       value=""WA"" />" &amp; ControlChars.CrLf &amp; _
     "                                                    <condition attribute=""address1_city"" operator=""in"">" &amp; ControlChars.CrLf &amp; _
     "                                                        <value>Redmond</value>" &amp; ControlChars.CrLf &amp; _
     "                                                        <value>Bellevue</value>" &amp; ControlChars.CrLf &amp; _
     "                                                        <value>Kirkland</value>" &amp; ControlChars.CrLf &amp; _
     "                                                        <value>Seattle</value>" &amp; ControlChars.CrLf &amp; _
     "                                                    </condition>" &amp; ControlChars.CrLf &amp; _
     "                                                    <condition attribute=""createdon"" operator=""last-x-days"" value=""30"" />" &amp; ControlChars.CrLf &amp; _
     "                                                    <condition attribute=""emailaddress1"" operator=""not-null"" />" &amp; ControlChars.CrLf &amp; _
     "                                                    <filter type=""or"">" &amp; ControlChars.CrLf &amp; _
     "                                                        <condition attribute=""address1_telephone1"" operator=""like"" value=""(206)%"" />" &amp; ControlChars.CrLf &amp; _
     "                                                        <condition attribute=""address1_telephone1"" operator=""like"" value=""(425)%"" />" &amp; ControlChars.CrLf &amp; _
     "                                                    </filter>" &amp; ControlChars.CrLf &amp; _
     "                                                </filter>" &amp; ControlChars.CrLf &amp; _
     "                                                <link-entity name=""account"" from=""accountid"" to=""parentcustomerid"">" &amp; ControlChars.CrLf &amp; _
     "                                                    <filter>" &amp; ControlChars.CrLf &amp; _
     "                                                        <condition attribute=""name"" operator=""eq"" value=""Litware, Inc."" />" &amp; ControlChars.CrLf &amp; _
     "                                                    </filter>" &amp; ControlChars.CrLf &amp; _
     "                                                </link-entity>" &amp; ControlChars.CrLf &amp; _
     "                                            </entity>" &amp; ControlChars.CrLf &amp; _
     "                                        </fetch>"

 ' Build fetch request and obtain results.
 Dim efr As New RetrieveMultipleRequest() With {.Query = New FetchExpression(fetchXml)}

 Dim entityResults As EntityCollection = (CType(_service.Execute(efr), RetrieveMultipleResponse)).EntityCollection


 ' Display the results.
 Console.WriteLine("List all contacts matching specified parameters")
 Console.WriteLine("===============================================")
 For Each e In entityResults.Entities
     Console.WriteLine("Contact ID: {0}", e.Id)
 Next e


 Console.WriteLine("<End of Listing>")
 Console.WriteLine()

' </snippetretrievemultipleconditionoperatorsfetch2>
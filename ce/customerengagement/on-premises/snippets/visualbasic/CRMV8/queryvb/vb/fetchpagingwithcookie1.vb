' <snippetfetchpagingwithcookie1>


 ' Define the fetch attributes.
 ' Set the number of records per page to retrieve.
 Dim fetchCount As Integer = 3
 ' Initialize the page number.
 Dim pageNumber As Integer = 1
 ' Initialize the number of records.
 Dim recordCount As Integer = 0
 ' Specify the current paging cookie. For retrieving the first page, 
 ' pagingCookie should be null.
 Dim pagingCookie As String = Nothing



 ' Create the FetchXml string for retrieving all child accounts to a parent account.
 ' This fetch query is using 1 placeholder to specify the parent account id 
 ' for filtering out required accounts. Filter query is optional.
 ' Fetch query also includes optional order criteria that, in this case, is used 
 ' to order the results in ascending order on the name data column.
 Dim fetchXml As String = String.Format("<fetch version='1.0' " &amp; ControlChars.CrLf &amp; "                                                    mapping='logical' " &amp; ControlChars.CrLf &amp; "                                                    output-format='xml-platform'>" &amp; ControlChars.CrLf &amp; "                                                    <entity name='account'>" &amp; ControlChars.CrLf &amp; "                                                        <attribute name='name' />" &amp; ControlChars.CrLf &amp; "                                                        <attribute name='emailaddress1' />" &amp; ControlChars.CrLf &amp; "                                                        <order attribute='name' descending='false'/>" &amp; ControlChars.CrLf &amp; "                                                        <filter type='and'>" &amp; ControlChars.CrLf &amp; "                                                            <condition attribute='parentaccountid' " &amp; ControlChars.CrLf &amp; "                                                                operator='eq' value='{0}' uiname='' uitype='' />" &amp; ControlChars.CrLf &amp; "                                                        </filter>" &amp; ControlChars.CrLf &amp; "                                                    </entity>" &amp; ControlChars.CrLf &amp; "                                                </fetch>", _parentAccountId)


 Console.WriteLine("#" &amp; vbTab &amp; "Account Name" &amp; vbTab &amp; vbTab &amp; vbTab &amp; "Email Address")

 Do
     ' Build fetchXml string with the placeholders.
     Dim xml As String = CreateXml(fetchXml, pagingCookie, pageNumber, fetchCount)

     ' Excute the fetch query and get the xml result.
     Dim fetchRequest1 As RetrieveMultipleRequest = New RetrieveMultipleRequest With {.Query = New FetchExpression(xml)}

     Dim returnCollection As EntityCollection = _
         (CType(_service.Execute(fetchRequest1), RetrieveMultipleResponse)).EntityCollection

     For Each c In returnCollection.Entities

         recordCount += 1
         Console.WriteLine("{0}." &amp; vbTab &amp; "{1}" &amp; vbTab &amp; vbTab &amp; "{2}", recordCount, c.Attributes("name"), _
                           c.Attributes("emailaddress1"))

     Next c

     ' Check for morerecords, if it returns 1.
     If returnCollection.MoreRecords Then
         ' Increment the page number to retrieve the next page.
         pageNumber += 1
     Else
         ' If no more records in the result nodes, exit the loop.
         Exit Do
     End If
 Loop

' </snippetfetchpagingwithcookie1>
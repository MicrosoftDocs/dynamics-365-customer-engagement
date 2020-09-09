' <snippetfetchpagingwithcookie>


Imports System.ServiceModel
Imports System.ServiceModel.Description
Imports System.Text
Imports System.Xml
Imports System.IO

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Query
Imports Microsoft.Xrm.Sdk.Discovery

' This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Crm.Sdk.Messages
Imports Microsoft.Xrm.Sdk.Messages


Namespace Microsoft.Crm.Sdk.Samples
    ''' <summary>
    ''' Demonstrates how to use the Fetch XML method with a paging
    ''' cookie to retrieve a batch of records.
    ''' If you want to run this sample repeatedly, you have the option to 
    ''' delete all the records created at the end of execution.
    ''' </summary>
    Friend Class FetchPagingWithCookie
        #Region "Class Level Members"

        ''' <summary>
        ''' Stores the organization service proxy.
        ''' </summary>
        Private _serviceProxy As OrganizationServiceProxy
        Private _service As IOrganizationService

        ' Define the IDs needed for this sample.
        Public _parentAccountId As Guid
        Public _childAccountIds() As Guid

        #End Region ' Class Level Members

        #Region "How To Sample Code"
        ''' <summary>
        ''' Create and configure the organization service proxy.
        ''' Create a parent account record and subsequent 10 child account records.
        ''' Retrieve batch of records using RetrieveMultiple message with paging cookie.
        ''' Optionally delete any entity records that were created for this sample.
        ''' </summary>
        ''' <param name="serverConfig">Contains server connection information.</param>
        ''' <param name="promptForDelete">When True, the user will be prompted to delete all
        ''' created entities.</param>
        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration, ByVal promptForDelete As Boolean)
            Try

                ' Connect to the Organization service. 
                ' The using statement assures that the service proxy will be properly disposed.
                _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
                Using _serviceProxy
                    ' This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes()

                    _service = CType(_serviceProxy, IOrganizationService)

                    ' Call the method to create any data that this sample requires.
                    CreateRequiredRecords()

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

                    Console.WriteLine("Retrieved record data.")

                    DeleteRequiredRecords(promptForDelete)

                End Using
            ' Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            Catch fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                ' You can handle an exception here or pass it back to the calling method.
                Throw
            End Try
            Return
        End Sub


        Public Function ExtractNodeValue(ByVal parentNode As XmlNode, ByVal name As String) As String
            Dim childNode As XmlNode = parentNode.SelectSingleNode(name)

            If Nothing Is childNode Then
                Return Nothing
            End If
            Return childNode.InnerText
        End Function

        Public Function ExtractAttribute(ByVal doc As XmlDocument, ByVal name As String) As String
            Dim attrs As XmlAttributeCollection = doc.DocumentElement.Attributes
            Dim attr As XmlAttribute = CType(attrs.GetNamedItem(name), XmlAttribute)
            If Nothing Is attr Then
                Return Nothing
            End If
            Return attr.Value
        End Function

        Public Function CreateXml(ByVal xml As String, ByVal cookie As String, ByVal page As Integer, ByVal count As Integer) As String
            Dim stringReader As New StringReader(xml)
            Dim reader As New XmlTextReader(stringReader)

            ' Load document
            Dim doc As New XmlDocument()
            doc.Load(reader)

            Return CreateXml(doc, cookie, page, count)
        End Function

        Public Function CreateXml(ByVal doc As XmlDocument, ByVal cookie As String, ByVal page As Integer, ByVal count As Integer) As String
            Dim attrs As XmlAttributeCollection = doc.DocumentElement.Attributes

            If cookie IsNot Nothing Then
                Dim pagingAttr As XmlAttribute = doc.CreateAttribute("paging-cookie")
                pagingAttr.Value = cookie
                attrs.Append(pagingAttr)
            End If

            Dim pageAttr As XmlAttribute = doc.CreateAttribute("page")
            pageAttr.Value = Convert.ToString(page)
            attrs.Append(pageAttr)

            Dim countAttr As XmlAttribute = doc.CreateAttribute("count")
            countAttr.Value = Convert.ToString(count)
            attrs.Append(countAttr)

            Dim sb As New StringBuilder(1024)
            Dim stringWriter As New StringWriter(sb)

            Dim writer As New XmlTextWriter(stringWriter)
            doc.WriteTo(writer)
            writer.Close()

            Return sb.ToString()
        End Function

        ''' <summary>
        ''' This method creates any entity records that this sample requires.
        ''' Create a parent account record.
        ''' Create 10 child accounts to the parent account record.
        ''' </summary>
        Public Sub CreateRequiredRecords()
            ' Instantiate a account entity record and set its property values.
            ' See the Entity Metadata topic in the SDK documentation
            ' to determine which attributes must be set for each entity.
            ' Create the parent account.
            Dim parentAccount As Account = New Account With {.Name = "Root Test Account", .EMailAddress1 = "root@root.com"}


            _parentAccountId = _service.Create(parentAccount)

            ' Create 10 child accounts.
            _childAccountIds = New Guid(9){}
            Dim count As Integer = 1
            Do
                Dim childAccount As Account = New Account With {.Name = "Child Test Account " &amp; count.ToString(), _
                                                                .EMailAddress1 = "child" &amp; count.ToString() &amp; "@root.com", .EMailAddress2 = "same@root.com", .ParentAccountId = New EntityReference(Account.EntityLogicalName, _parentAccountId)}

                _childAccountIds(count - 1) = _service.Create(childAccount)

                ' Jump out of the loop after creating 10 child accounts.
                If count = 10 Then
                    Exit Do
                End If
                ' Increment the count.
                count += 1
            Loop

            Return
        End Sub

        ''' <summary>
        ''' Deletes any entity records that were created for this sample.
        ''' <param name="prompt">Indicates whether to prompt the user to delete the records created in this sample.</param>
        ''' </summary>
        Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
            Dim deleteRecords As Boolean = True

            If prompt Then
                Console.WriteLine(vbLf &amp; "Do you want these entity records deleted? (y/n)")
                Dim answer As String = Console.ReadLine()

                deleteRecords = (answer.StartsWith("y") OrElse answer.StartsWith("Y"))
            End If

            If deleteRecords Then
                ' Remove the test parent account.
                _service.Delete(Account.EntityLogicalName, _parentAccountId)

                ' Remove 10 test child accounts.
                Dim deleteCount As Integer = 0
                Do While deleteCount < 10
                    _service.Delete(Account.EntityLogicalName, _childAccountIds(deleteCount))
                    deleteCount += 1
                Loop

                Console.WriteLine("Entity records have been deleted.")
            End If
        End Sub

        #End Region ' How To Sample Code

        #Region "Main"

        ''' <summary>
        ''' Standard Main() method used by most SDK samples.
        ''' </summary>
        ''' <param name="args"></param>
        Public Shared Sub Main(ByVal args() As String)
            Try
                ' Obtain the target organization's Web address and client logon 
                ' credentials from the user.
                Dim serverConnect As New ServerConnection()
                Dim config As ServerConnection.Configuration = serverConnect.GetServerConfiguration()

                Dim app As New FetchPagingWithCookie()
                app.Run(config, True)
            Catch ex As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                Console.WriteLine("The application terminated with an error.")
                Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp)
                Console.WriteLine("Code: {0}", ex.Detail.ErrorCode)
                Console.WriteLine("Message: {0}", ex.Detail.Message)
                Console.WriteLine("Plugin Trace: {0}", ex.Detail.TraceText)
                Console.WriteLine("Inner Fault: {0}", If(Nothing Is ex.Detail.InnerFault, "No Inner Fault", "Has Inner Fault"))
            Catch ex As TimeoutException
                Console.WriteLine("The application terminated with an error.")
                Console.WriteLine("Message: {0}", ex.Message)
                Console.WriteLine("Stack Trace: {0}", ex.StackTrace)
                Console.WriteLine("Inner Fault: {0}", If(Nothing Is ex.InnerException.Message, "No Inner Fault", ex.InnerException.Message))
            Catch ex As Exception
                Console.WriteLine("The application terminated with an error.")
                Console.WriteLine(ex.Message)

                ' Display the details of the inner exception.
                If ex.InnerException IsNot Nothing Then
                    Console.WriteLine(ex.InnerException.Message)

                    Dim fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault) = _
                        TryCast(ex.InnerException, FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault))
                    If fe IsNot Nothing Then
                        Console.WriteLine("Timestamp: {0}", fe.Detail.Timestamp)
                        Console.WriteLine("Code: {0}", fe.Detail.ErrorCode)
                        Console.WriteLine("Message: {0}", fe.Detail.Message)
                        Console.WriteLine("Plugin Trace: {0}", fe.Detail.TraceText)
                        Console.WriteLine("Inner Fault: {0}", If(Nothing Is fe.Detail.InnerFault, "No Inner Fault", "Has Inner Fault"))
                    End If
                End If
            ' Additional exceptions to catch: SecurityTokenValidationException, ExpiredSecurityTokenException,
            ' SecurityAccessDeniedException, MessageSecurityException, and SecurityNegotiationException.

            Finally
                Console.WriteLine("Press <Enter> to exit.")
                Console.ReadLine()
            End Try

        End Sub
        #End Region ' Main

    End Class
End Namespace

' </snippetfetchpagingwithcookie>
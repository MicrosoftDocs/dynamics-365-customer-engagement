' <snippetdumpsdkmessagetofilede>


Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports System.ServiceModel.Description
Imports System.IO
Imports System.Xml

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Query
Imports Microsoft.Xrm.Sdk.Discovery

' This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Crm.Sdk


Namespace Microsoft.Crm.Sdk.Samples
    ''' <summary>
    ''' Demonstrates how to assign a queue to a team.
    ''' If you want to run this sample repeatedly, you have the option to 
    ''' delete all the records created at the end of execution.
    ''' </summary>
    Public Class DumpSdkMessageToFileDE
        #Region "Class Level Members"

        ''' <summary>
        ''' Stores the organization service proxy.
        ''' </summary>
        Private _serviceProxy As OrganizationServiceProxy
        Private _service As IOrganizationService

        #End Region ' Class Level Members

        #Region "How To Sample Code"
        ''' <summary>
        ''' Create and configure the organization service proxy.
        ''' Create a team, a queue and a role.
        ''' Add read queue privileges to the role.
        ''' Assign the role to the team so that they can read the queue.
        ''' Assign the queue to the team.
        ''' Optionally delete any entity records that were created for this sample.
        ''' </summary>
        ''' <param name="serverConfig">Contains server connection information.</param>
        ''' <param name="promptForDelete">When True, the user will be prompted to delete
        ''' all created entities.</param>
        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration, ByVal promptForDelete As Boolean)
            Try

                ' Connect to the Organization service. 
                ' The using statement assures that the service proxy will be properly disposed.
                _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
                Using _serviceProxy
                    _service = CType(_serviceProxy, IOrganizationService)

                    ' Retrieve all SDK Message Records.
                    Dim sdkMessageQuery As QueryExpression = New QueryExpression With { _
                        .EntityName = "sdkmessage", .ColumnSet = New ColumnSet("categoryname", "name", "isprivate", "availability", _
                                                                               "customizationlevel", "expand", "template", "sdkmessageid")}
                        'Criteria = new FilterExpression(),

                    Dim sdkMessages As EntityCollection = _service.RetrieveMultiple(sdkMessageQuery)

                    ' Write out SDK messages to an XML file.
                    ' Create an instance of StreamWriter to write text to a file.
                    ' The using statement also closes the StreamWriter.

                    Dim filename As String = "sdkmessages.xml"
                    Using sw As New StreamWriter(filename)
                        ' Create Xml Writer.
                        Dim metadataWriter As New XmlTextWriter(sw)

                        ' Start Xml File.
                        metadataWriter.WriteStartDocument()

                        ' Metadata Xml Node.
                        metadataWriter.WriteStartElement("Messages")

                        For j As Integer = 0 To sdkMessages.Entities.Count - 1

                            Dim currentRecord As Entity = sdkMessages(j)

                            metadataWriter.WriteStartElement("Message")

                            ' Write the message information.
                            metadataWriter.WriteElementString("message-name", CType(currentRecord.Attributes("name"), String))
                            metadataWriter.WriteElementString("categoryname", CType(currentRecord.Attributes("categoryname"), String))
                            If CBool(currentRecord.Attributes("isprivate")) Then
                                metadataWriter.WriteElementString("isprivate", "Yes")
                            End If
                            metadataWriter.WriteElementString("message-availability", currentRecord.Attributes("availability").ToString())
                            If CBool(currentRecord.Attributes("expand")) Then
                                metadataWriter.WriteElementString("expand", "Yes")
                            End If
                            If CBool(currentRecord.Attributes("template")) Then
                                metadataWriter.WriteElementString("template", "Yes")
                            End If


'                            #Region "filters"

                            ' Retrieve all SDK Message filter records for that entity.
                            Dim sdkMessageFilterQuery As QueryByAttribute = New QueryByAttribute With { _
                                .EntityName = "sdkmessagefilter", _
                                .ColumnSet = New ColumnSet("iscustomprocessingstepallowed", "availability", "primaryobjecttypecode", _
                                                           "secondaryobjecttypecode")}
                            sdkMessageFilterQuery.AddAttributeValue("sdkmessageid", currentRecord.Attributes("sdkmessageid"))
                            Dim sdkFilters As EntityCollection = _service.RetrieveMultiple(sdkMessageFilterQuery)
                            metadataWriter.WriteStartElement("Filters")

                            For i As Integer = 0 To sdkFilters.Entities.Count - 1

                                Dim currentFilter As Entity = sdkFilters(i)

                                metadataWriter.WriteStartElement("Filter")

                                ' Write the message information.
                                metadataWriter.WriteElementString("filter-availability", _
                                                                  currentFilter.Attributes("availability").ToString())
                                metadataWriter.WriteElementString("primaryobjecttypecode", _
                                                                  currentFilter.Attributes("primaryobjecttypecode").ToString())
                                metadataWriter.WriteElementString("secondaryobjecttypecode", _
                                                                  currentFilter.Attributes("secondaryobjecttypecode").ToString())
                                metadataWriter.WriteEndElement()

                            Next i
                            metadataWriter.WriteEndElement()


'                            #End Region ' filters

                            metadataWriter.WriteEndElement()
                        Next j


                        ' End Metadata Xml Node
                        metadataWriter.WriteEndElement()
                        metadataWriter.WriteEndDocument()

                        ' Close xml writer.
                        metadataWriter.Close()
                    End Using


                    Console.WriteLine("Retrieved all SDK messages.")



                    ' There are no entity records to delete.
                    'DeleteRequiredRecords(promptForDelete);
                End Using

            ' Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            Catch fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                ' You can handle an exception here or pass it back to the calling method.
                Throw
            End Try
        End Sub

        ''' <summary>
        ''' This method creates any entity records that this sample requires.
        ''' Create a team, a queue and a role.
        ''' Add read queue privileges to the role.
        ''' Assign the role to the team so that they can read the queue.
        ''' Assign the queue to the team.
        ''' </summary>
        Public Sub CreateRequiredRecords()


            Return
        End Sub

        ''' <summary>
        ''' Deletes any entity records that were created for this sample.
        ''' <param name="prompt">Indicates whether to prompt the user 
        ''' to delete the records created in this sample.</param>
        ''' </summary>
        Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
            Dim deleteRecords As Boolean = True

            If prompt Then
                Console.WriteLine(vbLf &amp; "Do you want these entity records deleted? (y/n) [y]: ")
                Dim answer As String = Console.ReadLine()

                deleteRecords = (answer.StartsWith("y") OrElse answer.StartsWith("Y") OrElse answer = String.Empty)
            End If

            If deleteRecords Then

                Console.WriteLine("No entity records need to be deleted.")

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

                Dim app As New AssignQueueToTeamDE()
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

' </snippetdumpsdkmessagetofilede>
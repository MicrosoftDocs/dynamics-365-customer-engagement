' <snippetremovequeueitemworker>


Imports System.ServiceModel
Imports System.ServiceModel.Description

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Query
Imports Microsoft.Xrm.Sdk.Discovery

' This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Crm.Sdk.Messages
Imports Microsoft.Xrm.Sdk.Client

Namespace Microsoft.Crm.Sdk.Samples
    ''' <summary>
    ''' This sample shows how to release queued object from worker's queue.
    ''' </summary>
    Public Class RemoveQueueItemWorker
        #Region "Class Level Members"


        ' Define the IDs needed for this sample.
        Private _queueItemId As Guid
        Private _letterId As Guid
        Private _queueId As Guid
        Private _serviceProxy As OrganizationServiceProxy

        #End Region ' Class Level Members

        #Region "How To Sample Code"
        ''' <summary>
        ''' Create and configure the organization service proxy.
        ''' Initiate method to create any entity records that this sample requires.
        ''' Remove worker from queue item to release queued object
        ''' which user is working on.
        ''' Optionally delete any entity records that were created for this sample.
        ''' <para name="organizationFriendlyName">The friendly name of the 
        ''' target organization.</para>
        ''' <para name="discoveryServer">The name of the discovery server.</para>
        ''' <param name="promptForDelete">Indicates whether to prompt the user to delete
        ''' the records created in this sample.</param>
        ''' </summary>
        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration, ByVal promptForDelete As Boolean)
            Try


                ' Connect to the Organization service. 
                ' The using statement assures that the service proxy will be properly disposed.
                _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
                Using _serviceProxy
                    ' This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes()

                    CreateRequiredRecords()


                    ' Remove worker from queue item to release queued object
                    ' from worker's queue.
                    Dim queueItem As QueueItem = New QueueItem With {.QueueItemId = _queueItemId, .WorkerId = Nothing}
                    _serviceProxy.Update(queueItem)

                    Console.WriteLine("Released the queued object from worker queue.")

                    DeleteRequiredRecords(promptForDelete)

                End Using
            ' Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            Catch fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                ' You can handle an exception here or pass it back to the calling method.
                Throw
            End Try
        End Sub

        ''' <summary>
        ''' This method creates any entity records that this sample requires.
        ''' Create a queue record.
        ''' Create a letter record.
        ''' Create a queue item for queue record.
        ''' Retrieves new owner's details. 
        ''' Update the queue item record to assign it to new owner.
        ''' </summary>
        Public Sub CreateRequiredRecords()
            ' Create a queue instance and set its property values.
            Dim newQueue As Queue = New Queue With {.Name = "Example Queue.", .Description = "This is an example queue."}

            ' Create a new queue and store its returned GUID in a variable 
            ' for later use.
            _queueId = _serviceProxy.Create(newQueue)

            Console.WriteLine("Created {0}.", newQueue.Name)

            Dim newLetter As Letter = New Letter With {.Description = "Example Letter"}

           _letterId = _serviceProxy.Create(newLetter)

           Console.WriteLine("Created {0}.", newLetter.Description)

            ' Create a new instance of a queueitem and initialize its 
            ' properties.
            Dim item As QueueItem = New QueueItem With {.QueueId = New EntityReference(Queue.EntityLogicalName, _queueId), _
                                                        .ObjectId = New EntityReference(Letter.EntityLogicalName, _letterId)}

            ' Create the queueitem on the server, which will associate 
            ' the letter with the queue.
            _queueItemId = _serviceProxy.Create(item)

            Console.WriteLine("Created the letter queue item for the queue.")

            ' Retrieve the user information.
            Dim whoAmIRequest As New WhoAmIRequest()
            Dim whoAmIResponse As WhoAmIResponse = CType(_serviceProxy.Execute(whoAmIRequest), WhoAmIResponse)

            Dim columnSet As New ColumnSet("fullname")
            Dim currentUser As SystemUser = CType(_serviceProxy.Retrieve(SystemUser.EntityLogicalName, _
                                                                         whoAmIResponse.UserId, columnSet), SystemUser)
            Dim currentUserName As String = currentUser.FullName

            ' Create an instance of an existing queueitem in order to specify 
            ' the user that will be working on it.
            Dim queueItem As QueueItem = New QueueItem With {.QueueItemId = _queueItemId, _
                                                             .WorkerId = New EntityReference(SystemUser.EntityLogicalName, _
                                                             whoAmIResponse.UserId)}

            _serviceProxy.Update(queueItem)

            Console.WriteLine("The letter queue item is queued for new owner {0}.", currentUserName)

            Return
        End Sub

        ''' <summary>
        ''' Deletes any entity records that were created for this sample.
        ''' <param name="prompt">Indicates whether to prompt the user to 
        ''' delete the records created in this sample.</param>
        ''' </summary>
        Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
            Dim deleteRecords As Boolean = True

            If prompt Then
                Console.WriteLine(vbLf &amp; "Do you want these entity records deleted? (y/n)")
                Dim answer As String = Console.ReadLine()

                deleteRecords = (answer.StartsWith("y") OrElse answer.StartsWith("Y"))
            End If

            If deleteRecords Then
                _serviceProxy.Delete(QueueItem.EntityLogicalName, _queueItemId)
                _serviceProxy.Delete(Letter.EntityLogicalName, _letterId)
                _serviceProxy.Delete(Queue.EntityLogicalName, _queueId)

                Console.WriteLine("Entity records have been deleted.")
            End If
        End Sub

        #End Region ' How To Sample Code

        #Region "Main"
        ''' <summary>
        ''' Main. Runs the sample and provides error output.
        ''' <param name="args">Array of arguments to Main method.</param>
        ''' </summary>
        Public Shared Sub Main(ByVal args() As String)
            Try
                ' Obtain the target organization's Web address and client logon 
                ' credentials from the user.
                Dim serverConnect As New ServerConnection()
                Dim config As ServerConnection.Configuration = serverConnect.GetServerConfiguration()

                Dim app As New RemoveQueueItemWorker()
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

' </snippetremovequeueitemworker>
' <snippetaddtoqueue>


Imports Microsoft.VisualBasic
Imports System
Imports System.ServiceModel

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Xrm.Sdk

' This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Crm.Sdk.Messages
Imports Microsoft.Xrm.Sdk.Client

Namespace Microsoft.Crm.Sdk.Samples
	''' <summary>
	''' This Sample shows how to move a record from one queue to another.
	''' </summary>
	Public Class AddToQueue
		#Region "Class Level Members"

		' Define the IDs needed for this sample.
		Private _sourceQueueId As Guid
		Private _destinationQueueId As Guid
		Private _letterId As Guid
		Private _userId As Guid
		Private _serviceProxy As OrganizationServiceProxy

		#End Region ' Class Level Members

		#Region "How To Sample Code"
		''' <summary>
		''' Create and configure the organization service proxy.
		''' Initiate the method to create any data that this sample requires.
		''' Move a record from a source queue to a destination queue.
		''' Optionally delete any entity records that were created for this sample.
		''' <para name="organizationFriendlyName">The friendly name of the target 
		''' organization.</para>
		''' <para name="discoveryServer">The name of the discovery server.</para>
		''' <param name="promptForDelete">Indicates whether to prompt the user to 
		''' delete the records created in this sample.</param>
		''' </summary>
        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration,
                       ByVal promptForDelete As Boolean)
            Try
                ' Connect to the Organization service. 
                ' The using statement assures that the service proxy will be properly disposed.
                _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
                Using _serviceProxy
                    ' This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes()

                    CreateRequiredRecords()


                    ' Move a record from a source queue to a destination queue
                    ' by using the AddToQueue request message.
                    Dim routeRequest As AddToQueueRequest =
                        New AddToQueueRequest With
                        {
                            .SourceQueueId = _sourceQueueId,
                            .Target = New EntityReference(Letter.EntityLogicalName,
                                                          _letterId),
                            .DestinationQueueId = _destinationQueueId
                        }

                    ' Set the WorkerId of the QueueItemProperties to indicate who is working
                    ' on this particular queue item. If there were any custom attributes
                    ' defined for the QueueItem Entity, it would be possible to set
                    ' those here, as well.
                    routeRequest.QueueItemProperties =
                        New QueueItem With
                        {
                            .WorkerId = New EntityReference("systemuser", _userId)
                        }

                    ' Execute the Request
                    _serviceProxy.Execute(routeRequest)

                    Console.WriteLine(
                        "The letter record has been moved to a new queue.")

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
		''' Create source queue and destination queue.
		''' Create a letter  entity.
		''' Add letter  entity to source queue.
		''' </summary>
		Public Sub CreateRequiredRecords()
			'Create new queues and store their returned GUIDs in variables for later use.
            Dim sourceQueue As Queue =
                New Queue With
                {
                    .Name = "Example Queue 1",
                    .Description = "This is an example queue."
                }

			_sourceQueueId = _serviceProxy.Create(sourceQueue)
			Console.WriteLine("Created {0}", sourceQueue.Name)

            Dim destinationQueue As Queue =
                New Queue With
                {
                    .Name = "Example Queue 2",
                    .Description = "This is an example queue."
                }

			_destinationQueueId = _serviceProxy.Create(destinationQueue)
			Console.WriteLine("Created {0}", destinationQueue.Name)


			' Create a letter  entity.
            Dim newLetter As Letter = New Letter With
                                      {
                                          .Description = "Example Letter"
                                      }

			_letterId = _serviceProxy.Create(newLetter)
			Console.WriteLine("Created {0}", newLetter.Description)

			' Use AddToQueue message to add an  entity into a queue, which will associate
			' the letter with the first queue.
            Dim addToSourceQueue As AddToQueueRequest =
                New AddToQueueRequest With
                {
                    .DestinationQueueId = _sourceQueueId,
                    .Target = New EntityReference(Letter.EntityLogicalName, _letterId)
                }

			_serviceProxy.Execute(addToSourceQueue)
			Console.WriteLine("Added letter record to {0}", sourceQueue.Name)

			' Retrieve/create a user record for assigning the queue item to the user's
			' queue.
			_userId = SystemUserProvider.RetrieveSalesManager(_serviceProxy)

			Return
		End Sub

		''' <summary>
		''' Deletes any entity records that were created for this sample.
		''' <param name="prompt">Indicates whether to prompt the user to delete 
		''' the records created in this sample.</param>
		''' </summary>
		Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
			Dim toBeDeleted As Boolean = True

			If prompt Then
				' Ask the user if the created entities should be deleted.
                Console.Write(vbLf &amp;
                              "Do you want these entity records deleted? (y/n) [y]: ")
				Dim answer As String = Console.ReadLine()
                If answer.StartsWith("y") _
                    OrElse answer.StartsWith("Y") _
                    OrElse answer = String.Empty Then
                    toBeDeleted = True
                Else
                    toBeDeleted = False
                End If
			End If

			If toBeDeleted Then
				_serviceProxy.Delete(Letter.EntityLogicalName, _letterId)
				_serviceProxy.Delete(Queue.EntityLogicalName, _sourceQueueId)
				_serviceProxy.Delete(Queue.EntityLogicalName, _destinationQueueId)

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
                Dim config As ServerConnection.Configuration =
                    serverConnect.GetServerConfiguration()

				Dim app As New AddToQueue()
				app.Run(config, True)

			Catch ex As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
				Console.WriteLine("The application terminated with an error.")
				Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp)
				Console.WriteLine("Code: {0}", ex.Detail.ErrorCode)
				Console.WriteLine("Message: {0}", ex.Detail.Message)
				Console.WriteLine("Plugin Trace: {0}", ex.Detail.TraceText)
                Console.WriteLine("Inner Fault: {0}", If(Nothing Is ex.Detail.InnerFault, "No Inner Fault", "Has Inner Fault"))
			Catch ex As System.TimeoutException
				Console.WriteLine("The application terminated with an error.")
				Console.WriteLine("Message: {0}", ex.Message)
				Console.WriteLine("Stack Trace: {0}", ex.StackTrace)
                Console.WriteLine("Inner Fault: {0}", If(Nothing Is ex.InnerException.Message, "No Inner Fault", ex.InnerException.Message))
			Catch ex As System.Exception
				Console.WriteLine("The application terminated with an error.")
				Console.WriteLine(ex.Message)

				' Display the details of the inner exception.
				If ex.InnerException IsNot Nothing Then
					Console.WriteLine(ex.InnerException.Message)

                    Dim fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault) =
                        TryCast(ex.InnerException, 
                            FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault))
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

' </snippetaddtoqueue>
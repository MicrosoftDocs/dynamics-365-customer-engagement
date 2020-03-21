' <snippetdeliverpromoteemail>


Imports System.ServiceModel
Imports System.ServiceModel.Description
Imports System.Text

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Query
Imports Microsoft.Xrm.Sdk.Discovery
Imports Microsoft.Xrm.Sdk.Messages
Imports Microsoft.Xrm.Sdk.Client


' This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Crm.Sdk.Messages

Namespace Microsoft.Crm.Sdk.Samples
    ''' <summary>
    ''' Create an e-mail activity instance from the specified e-mail message.
    ''' </summary>
    ''' <remarks>This sample requires that the user account running the program have
    ''' a primary e-mail address defined in Microsoft Dynamics CRM.</remarks>
    Public Class DeliverPromoteEmail
        #Region "Class Level Members"

        ''' <summary>
        ''' Stores the organization service proxy.
        ''' </summary>
        Private _serviceProxy As OrganizationServiceProxy

        ' Define the IDs needed for this sample.
        Private _contactId As Guid
        Private _emailId As Guid

        #End Region ' Class Level Members

        #Region "How To Sample Code"
        ''' <summary>
        ''' Create an e-mail activity instance from the specified e-mail message.
        ''' <param name="serverConfig">Contains server connection information.</param>
        ''' <param name="promptforDelete">When True, the user will be prompted to delete all
        ''' created entities.</param>
        ''' </summary>
        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration, ByVal promptForDelete As Boolean)
            Try
                ' Connect to the Organization service. 
                ' The using statement assures that the service proxy will be properly disposed.
                _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
                Using _serviceProxy
                    ' This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes()

                    ' Create a contact to send an email to (To: field)
                    Dim emailContact As New Contact() With {.FirstName = "Lisa", .LastName = "Andrews", .EMailAddress1 = "lisa@contoso.com"}
                    _contactId = _serviceProxy.Create(emailContact)
                    Console.WriteLine("Created a sample contact.")

                    ' Get a system user to send the email (From: field)
                    Dim systemUserRequest As New WhoAmIRequest()
                    Dim systemUserResponse As WhoAmIResponse = CType(_serviceProxy.Execute(systemUserRequest), WhoAmIResponse)

                    Dim cols As New ColumnSet("internalemailaddress")
                    Dim emailSender As SystemUser = _
                        CType(_serviceProxy.Retrieve(SystemUser.EntityLogicalName, systemUserResponse.UserId, cols), SystemUser)


                    ' Create the request.
                    Dim deliverEmailRequest As DeliverPromoteEmailRequest = New DeliverPromoteEmailRequest With {.Subject = "SDK Sample Email", _
                        .To = emailContact.EMailAddress1, .From = emailSender.InternalEMailAddress, .Bcc = String.Empty, .Cc = String.Empty, _
                        .Importance = "high", .Body = "This message will create an email activity.", .MessageId = Guid.NewGuid().ToString(), _
                        .SubmittedBy = "", .ReceivedOn = Date.Now}

                    ' We won't attach a file to the email, but the Attachments property is required.
                    deliverEmailRequest.Attachments = New EntityCollection(New ActivityMimeAttachment(){})
                    deliverEmailRequest.Attachments.EntityName = ActivityMimeAttachment.EntityLogicalName

                    ' Execute the request.
                    Dim deliverEmailResponse As DeliverPromoteEmailResponse = CType(_serviceProxy.Execute(deliverEmailRequest),  _
                                                                                    DeliverPromoteEmailResponse)

                    ' Verify the success.

                    ' Define an anonymous type to define the possible values for
                    ' email status
                    Dim EmailStatus = New With {Key .Draft = 1, Key .Completed = 2, Key .Sent = 3, Key .Received = 3, Key .Canceled = 5, _
                                                Key .PendingSend = 6, Key .Sending = 7, Key .Failed = 8}

                    ' Query for the delivered email, and verify the status code is "Sent".
                    Dim deliveredMailColumns As New ColumnSet("statuscode")
                    Dim deliveredEmail As Email = CType(_serviceProxy.Retrieve(Email.EntityLogicalName, deliverEmailResponse.EmailId, _
                                                                               deliveredMailColumns), Email)

                    _emailId = deliveredEmail.ActivityId.Value

                    If deliveredEmail.StatusCode.Value = EmailStatus.Sent Then
                        Console.WriteLine("Successfully created and delivered the e-mail message.")
                    End If


                    DeleteRequiredRecords(promptForDelete)
                End Using

            ' Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            Catch fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                ' You can handle an exception here or pass it back to the calling method.
                Throw
            End Try
        End Sub


        ''' <summary>
        ''' Deletes the custom entity record that was created for this sample.
        ''' <param name="prompt">Indicates whether to prompt the user 
        ''' to delete the entity created in this sample.</param>
        ''' </summary>
        Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
            Dim deleteRecords As Boolean = True

            If prompt Then
                Console.WriteLine(vbLf &amp; "Do you want these entity records deleted? (y/n)")
                Dim answer As String = Console.ReadLine()

                deleteRecords = (answer.StartsWith("y") OrElse answer.StartsWith("Y"))
            End If

            If deleteRecords Then
                ''' Delete the sent emails 
                _serviceProxy.Delete(Email.EntityLogicalName, _emailId)

                ' Delete the contacts created for emails
                _serviceProxy.Delete(Contact.EntityLogicalName, _contactId)

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

                Dim app As New DeliverPromoteEmail()
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

                    Dim fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault) = TryCast(ex.InnerException,  _
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

' </snippetdeliverpromoteemail>
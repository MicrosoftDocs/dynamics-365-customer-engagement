' <snippetsendemail>


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
    Public Class SendEmail
        #Region "Class Level Members"
        ' Define the IDs needed for this sample.
        Private _emailId As Guid
        Private _contactId As Guid
        Private _userId As Guid
        Private _serviceProxy As OrganizationServiceProxy

        #End Region ' Class Level Members

        #Region "How To Sample Code"
        ''' <summary>
        ''' Send an e-mail message.
        ''' </summary>
        ''' <param name="serverConfig">Contains server connection information.</param>
        ''' <param name="promptforDelete">When True, the user will be prompted to delete all
        ''' created entities.</param>
        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration, ByVal promptforDelete As Boolean)
            Try
                ' Connect to the Organization service. 
                ' The using statement assures that the service proxy will be properly disposed.
                _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
                Using _serviceProxy
                    ' This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes()

                    ' Call the method to create any data that this sample requires.
                    CreateRequiredRecords()


                    ' Use the SendEmail message to send an e-mail message.
                    Dim sendEmailreq As SendEmailRequest = New SendEmailRequest With {.EmailId = _emailId, .TrackingToken = "", .IssueSend = True}

                    Dim sendEmailresp As SendEmailResponse = CType(_serviceProxy.Execute(sendEmailreq), SendEmailResponse)
                    Console.WriteLine("Sent the e-mail message.")


                    DeleteRequiredRecords(promptforDelete)
                End Using

            ' Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            Catch fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                ' You can handle an exception here or pass it back to the calling method.
                Throw
            End Try
        End Sub

        ''' <summary>
        ''' This method creates any entity records that this sample requires.        
        ''' </summary>
        Public Sub CreateRequiredRecords()
            ' Create a contact to send an email to (To: field)
            Dim emailContact As Contact = New Contact With {.FirstName = "Nancy", .LastName = "Anderson", .EMailAddress1 = "nancy@contoso.com"}
            _contactId = _serviceProxy.Create(emailContact)
            Console.WriteLine("Created a contact: {0}.", emailContact.FirstName &amp; " " &amp; emailContact.LastName)

            ' Get a system user to send the email (From: field)
            Dim systemUserRequest As New WhoAmIRequest()
            Dim systemUserResponse As WhoAmIResponse = CType(_serviceProxy.Execute(systemUserRequest), WhoAmIResponse)
            _userId = systemUserResponse.UserId

            ' Create the 'From:' activity party for the email
            Dim fromParty As ActivityParty = New ActivityParty With {.PartyId = New EntityReference(SystemUser.EntityLogicalName, _userId)}

            ' Create the 'To:' activity party for the email
            Dim toParty As ActivityParty = New ActivityParty With {.PartyId = New EntityReference(Contact.EntityLogicalName, _contactId)}
            Console.WriteLine("Created activity parties.")

            ' Create an e-mail message.
            Dim email As Email = New Email With {.To = New ActivityParty() {toParty}, .From = New ActivityParty() {fromParty}, _
                                                 .Subject = "SDK Sample e-mail", .Description = "SDK Sample for SendEmail Message.", _
                                                 .DirectionCode = True}
            _emailId = _serviceProxy.Create(email)
            Console.WriteLine("Create {0}.", email.Subject)
        End Sub


        ''' <summary>
        ''' Deletes the custom entity record that was created for this sample.
        ''' <param name="prompt">Indicates whether to prompt the user 
        ''' to delete the entity created in this sample.</param>
        ''' </summary>
        Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
            Dim toBeDeleted As Boolean = True

            If prompt Then
                ' Ask the user if the created entities should be deleted.
                Console.Write(vbLf &amp; "Do you want these entity records deleted? (y/n) [y]: ")
                Dim answer As String = Console.ReadLine()
                If answer.StartsWith("y") OrElse answer.StartsWith("Y") OrElse answer = String.Empty Then
                    toBeDeleted = True
                Else
                    toBeDeleted = False
                End If
            End If

            If toBeDeleted Then
                _serviceProxy.Delete(Email.EntityLogicalName, _emailId)
                _serviceProxy.Delete(Contact.EntityLogicalName, _contactId)


                Console.WriteLine("Entity records have been deleted.")
            End If
        End Sub

        #End Region ' How To Sample Code

        #Region "Main method"
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

                Dim app As New SendEmail()
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
            ' Additonal exceptions to catch: SecurityTokenValidationException, ExpiredSecurityTokenException,
            ' SecurityAccessDeniedException, MessageSecurityException, and SecurityNegotiationException.

            Finally
                Console.WriteLine("Press <Enter> to exit.")
                Console.ReadLine()
            End Try

        End Sub
        #End Region ' Main method

    End Class
End Namespace

' </snippetsendemail>
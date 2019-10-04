' <snippetworkingwithrelatedattributesfornto1relationships>


Imports System.ServiceModel

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Messages

Namespace Microsoft.Crm.Sdk.Samples
    ''' <summary>
    ''' Demonstrates how to do work with related attributes for N:1 
    ''' relationships (Lookups) using strong types.</summary>
    ''' <remarks>
    ''' At run-time, you will be given the option to delete all the
    ''' database records created by this program.</remarks>
    Friend Class WorkingWithRelatedAttributesforNto1Relationships
        #Region "Class Level Members"

        Private _leadId As Guid
        Private _contactId As Guid
        Private _phoneCallId As Guid
        Private _serviceProxy As OrganizationServiceProxy
        Private _service As IOrganizationService

        #End Region ' Class Level Members

        #Region "How To Sample Code"
        ''' <summary>
        ''' This method first connects to the Organization service. Afterwards,
        ''' a phone call is created to a contact regarding a lead.
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

                    _service = CType(_serviceProxy, IOrganizationService)

                    ' Create a lead.
                    Dim lead As New Lead() With {.CompanyName = "Litware, Inc."}
                    _leadId = _service.Create(lead)

                    Console.Write("Lead created, ")

                    ' Create a contact.
                    Dim contact As New Contact() With {.FirstName = "Dan", .LastName = "Park", .Address1_Line1 = "23 Market St.", _
                                                       .Address1_City = "Sammamish", .Address1_StateOrProvince = "MT", _
                                                       .Address1_PostalCode = "99999", .Telephone1 = "12345678", _
                                                       .EMailAddress1 = "dan@litwareinc.com"}
                    _contactId = _service.Create(contact)
                    contact.ContactId = _contactId

                    Console.Write("contact created, ")

                    ' Create a blank phone call.
                    Dim phoneCall As New PhoneCall()
                    _phoneCallId = _service.Create(phoneCall)

                    Console.Write("phone call created, ")

                    ' Create an ActivityParty for the phone call's "to" field.
                    Dim activityParty As New ActivityParty() With {.PartyId = New EntityReference With { _
                            .Id = _contactId, .LogicalName = contact.EntityLogicalName}, _
                            .ActivityId = New EntityReference With { _
                                .Id = _phoneCallId, .LogicalName = phoneCall.EntityLogicalName}, _
                                .ParticipationTypeMask = New OptionSetValue(9)}

                    ' Create a phone call and add the properties we are updating.
                    Dim updatePhoneCall As New PhoneCall() With { _
                        .Id = _phoneCallId, .Subject = "Test Phone Call", .RegardingObjectId = New EntityReference With { _
                            .Id = _leadId, .LogicalName = lead.EntityLogicalName}, .To = New ActivityParty() {activityParty}}

                    ' Update the phone call.
                    Dim updateRequest As New UpdateRequest() With {.Target = updatePhoneCall}
                    _service.Execute(updateRequest)

                    Console.Write("phone call updated." &amp; vbLf)

                    DeleteRequiredRecords(promptforDelete)
                End Using

            ' Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            Catch fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                ' You can handle an exception here or pass it back to the calling method.
                Throw
            End Try
        End Sub

        ''' <summary>
        ''' Deletes any entity records that were created for this sample.
        ''' <param name="prompt">Indicates whether to prompt the user 
        ''' to delete the records created in this sample.</param>
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
                ' Delete all records created in this sample.

                _service.Delete(Lead.EntityLogicalName, _leadId)
                _service.Delete(Contact.EntityLogicalName, _contactId)

                Console.WriteLine("Entity record(s) have been deleted.")
            End If
        End Sub

        #End Region ' How To Sample Code

        #Region "Main method"

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

                Dim app As New WorkingWithRelatedAttributesforNto1Relationships()
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
        #End Region ' Main method
    End Class
End Namespace

' </snippetworkingwithrelatedattributesfornto1relationships>
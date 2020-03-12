' <snippetworkingwithactivityparties>


Imports System.ServiceModel

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client

Namespace Microsoft.Crm.Sdk.Samples
	''' <summary>
	''' Demonstrates how to programmatically work with Activity Party records.</summary>
	''' <remarks>
	''' At run-time, you will be given the option to delete all the
	''' database records created by this program.</remarks>
	Public Class WorkingWithActivityParties
		#Region "Class Level Members"

		Private _contactIds(2) As Guid
		Private _recordIds As New Dictionary(Of Guid, String)()
		Private _serviceProxy As OrganizationServiceProxy

		#End Region ' Class Level Members

		#Region "How To Sample Code"
		''' <summary>
		''' This method first connects to the Organization service. Afterwards,
		''' activity party records are created and associated with an activity.
		''' </summary>
		''' <param name="serverConfig">Contains server connection information.</param>
		''' <param name="promptforDelete">When True, the user will be prompted to delete
		''' all created entities.</param>
        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration,
                       ByVal promptforDelete As Boolean)
            Try
                ' Connect to the Organization service. 
                ' The using statement assures that the service proxy will be properly disposed.
                _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
                Using _serviceProxy
                    ' This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes()

                    CreateRequiredRecords()

                    Dim orgContext As New OrganizationServiceContext(_serviceProxy)

                    ' Retrieve the Contact records that we created previously.
                    Dim contacts As List(Of Contact) = ( _
                        From c In orgContext.CreateQuery(Of Contact)() _
                        Where c.Address1_City.Equals("Sammamish") _
                        Select New Contact With
                               {
                                   .ContactId = c.ContactId,
                                   .FirstName = c.FirstName,
                                   .LastName = c.LastName
                               }).ToList()
                    Console.Write("Contacts retrieved, ")

                    ' Create an Activity Party record for each Contact.
                    Dim activityParty1 =
                        New ActivityParty With
                            {
                                .PartyId =
                                New EntityReference(Contact.EntityLogicalName,
                                                    contacts(0).ContactId.Value)
                            }

                    Dim activityParty2 = New ActivityParty With
                                         {
                                             .PartyId =
                                             New EntityReference(
                                                 Contact.EntityLogicalName,
                                                 contacts(1).ContactId.Value)
                                         }

                    Dim activityParty3 =
                        New ActivityParty With
                        {
                            .PartyId = New EntityReference(Contact.EntityLogicalName,
                                                           contacts(2).ContactId.Value)
                        }

                    Console.Write("ActivityParty instances created, ")

                    ' Create Letter Activity and set From and To fields to the
                    ' respective Activity Party entities.
                    Dim letter = New Letter With
                                 {
                                     .RegardingObjectId =
                                     New EntityReference(
                                         Contact.EntityLogicalName,
                                         contacts(2).ContactId.Value),
                                     .Subject = "Sample Letter Activity",
                                     .ScheduledEnd = Date.Now.Add(TimeSpan.FromDays(5)),
                                     .Description = "Greetings, Mr. Andreshak, " _
                                                    &amp; "This is a sample letter activity " _
                                                    &amp; "as part of the " _
                                                    &amp; "Microsoft Dynamics CRM SDK. " _
                                                    &amp; "Sincerely, Mary Kay Andersen " _
                                                    &amp; "cc: Denise Smith",
                                     .From = New ActivityParty() {activityParty1},
                                     .To = New ActivityParty() {
                                         activityParty3,
                                         activityParty2}
                                 }
                    orgContext.AddObject(letter)
                    orgContext.SaveChanges()

                    Console.WriteLine("and Letter Activity created.")

                    DeleteRequiredRecords(promptforDelete)
                End Using

                ' Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            Catch fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                ' You can handle an exception here or pass it back to the calling method.
                Throw
            End Try
        End Sub

		''' <summary>
		''' Creates any entity records that this sample requires.
		''' </summary>
		Public Sub CreateRequiredRecords()
			' Create 3 Contact records to use in the Run() method.
            Dim contact1 As New Contact() With
                {
                    .FirstName = "Mary Kay",
                    .LastName = "Andersen",
                    .Address1_Line1 = "23 Market St.",
                    .Address1_City = "Sammamish",
                    .Address1_StateOrProvince = "MT",
                    .Address1_PostalCode = "99999",
                    .Telephone1 = "12345678",
                    .EMailAddress1 = "marykay@contoso.com"
                }
			_contactIds(0) = _serviceProxy.Create(contact1)

            Dim contact2 As New Contact() With
                {
                    .FirstName = "Joe",
                    .LastName = "Andreshak",
                    .Address1_Line1 = "23 Market St.",
                    .Address1_City = "Sammamish",
                    .Address1_StateOrProvince = "MT",
                    .Address1_PostalCode = "99999",
                    .Telephone1 = "12345678",
                    .EMailAddress1 = "joe@contoso.com"
                }
			_contactIds(1) = _serviceProxy.Create(contact2)

            Dim contact3 As New Contact() With
                {
                    .FirstName = "Denise",
                    .LastName = "Smith",
                    .Address1_Line1 = "23 Market St.",
                    .Address1_City = "Sammamish",
                    .Address1_StateOrProvince = "MT",
                    .Address1_PostalCode = "99999",
                    .Telephone1 = "12345678",
                    .EMailAddress1 = "denise@contoso.com"
                }
			_contactIds(2) = _serviceProxy.Create(contact3)

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
                Console.Write(vbLf _
                              &amp; "Do you want these entity records deleted? (y/n) [y]: ")
				Dim answer As String = Console.ReadLine()
                If answer.StartsWith("y") OrElse answer.StartsWith("Y") _
                    OrElse answer = String.Empty Then
                    toBeDeleted = True
                Else
                    toBeDeleted = False
                End If
			End If

			If toBeDeleted Then
				' Delete all records created in this sample.
				For Each contactId As Guid In _contactIds
					_serviceProxy.Delete(Contact.EntityLogicalName, contactId)
				Next contactId
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
                Dim config As ServerConnection.Configuration =
                    serverConnect.GetServerConfiguration()

				Dim app As New WorkingWithActivityParties()
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
                Console.WriteLine("Inner Fault: {0}",
                                  If(Nothing Is ex.InnerException.Message, "No Inner Fault", ex.InnerException.Message))
			Catch ex As Exception
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
                        Console.WriteLine("Inner Fault: {0}",
                                          If(Nothing Is fe.Detail.InnerFault, "No Inner Fault", "Has Inner Fault"))
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

' </snippetworkingwithactivityparties>
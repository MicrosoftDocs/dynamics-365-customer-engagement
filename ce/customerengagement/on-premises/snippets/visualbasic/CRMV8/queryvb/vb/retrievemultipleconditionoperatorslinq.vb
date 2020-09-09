' <snippetretrievemultipleconditionoperatorslinq>


Imports System.ServiceModel

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client

Namespace Microsoft.Crm.Sdk.Samples
	''' <summary>
	''' Demonstrates how to do use retrieve multiple condition operators for all
	''' query types.</summary>
	''' <remarks>
	''' At run-time, you will be given the option to delete all the
	''' database records created by this program.</remarks>
	Public Class RetrieveMultipleConditionOperatorsLinq
		#Region "Class Level Members"

		Private _accountId As Guid
		Private _contactIdList As New List(Of Guid)()
		Private _serviceProxy As OrganizationServiceProxy
		Private _service As IOrganizationService

		#End Region ' Class Level Members

		#Region "How To Sample Code"
		''' <summary>
		''' This method first connects to the Organization service. Afterwards,
		''' basic LINQ queries are performed.
		''' </summary>
		''' <param name="serverConfig">Contains server connection information.</param>
        ''' <param name="promptforDelete">When True, the user will be prompted to 
        ''' delete all created entities.</param>
        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration,
                       ByVal promptforDelete As Boolean)
            Try

                ' Connect to the Organization service. 
                ' The using statement assures that the service proxy will be properly disposed.
                _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
                Using _serviceProxy
                    ' This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes()

                    _service = CType(_serviceProxy, IOrganizationService)

                    CreateRequiredRecords()

                    ' Create the OrganizationServiceContext object that will generate
                    ' the IQueryable collections for LINQ calls.
                    Dim orgContext As New OrganizationServiceContext(_service)


                    ' Build the following SQL query using QueryExpression:
                    '
                    '		SELECT contact.fullname, contact.address1_telephone1
                    '		FROM contact
                    '			LEFT OUTER JOIN account
                    '				ON contact.parentcustomerid = account.accountid
                    '				AND
                    '				account.name = 'Litware, Inc.'
                    '		WHERE (contact.address1_stateorprovince = 'WA'
                    '		AND
                    '			contact.address1_city in ('Redmond', 'Bellevue', 'Kirkland', 'Seattle')
                    '		AND 
                    '			contact.address1_telephone1 like '(206)%'
                    '			OR
                    '			contact.address1_telephone1 like '(425)%'
                    '		AND
                    '			contact.emailaddress1 Not NULL
                    '			   )
                    Dim contacts = ( _
                        From c In orgContext.CreateQuery(Of Contact)() _
                        Join a In orgContext.CreateQuery(Of Account)() _
                        On c.ParentCustomerId.Id Equals a.AccountId _
                        Where (a.Name.Equals("Litware, Inc.")) _
                        Where (c.Address1_StateOrProvince.Equals("WA") _
                               AndAlso (c.Address1_Telephone1.StartsWith("(206)") _
                                OrElse c.Address1_Telephone1.StartsWith("(425)")) _
                            AndAlso (c.Address1_City.Equals("Redmond") _
                                     OrElse c.Address1_City.Equals("Bellevue") _
                                     OrElse c.Address1_City.Equals("Kirkland") _
                                     OrElse c.Address1_City.Equals("Seattle")) _
                                 AndAlso (c.EMailAddress1 IsNot Nothing _
                                          AndAlso c.EMailAddress1 IsNot "")) _
                        Select New Contact With
                               {
                                   .ContactId = c.ContactId,
                                   .FirstName = c.FirstName,
                                   .LastName = c.LastName,
                                   .Address1_Telephone1 = c.Address1_Telephone1
                               })

                    ' Display the results.
                    Console.WriteLine("List all contacts matching specified parameters")
                    Console.WriteLine("===============================================")
                    For Each contact As Contact In contacts
                        Console.WriteLine("Contact ID: {0}", contact.Id)
                        Console.WriteLine("Contact Name: {0}", contact.FullName)
                        Console.WriteLine("Contact Phone: {0}",
                                          contact.Address1_Telephone1)
                    Next contact
                    Console.WriteLine("<End of Listing>")
                    Console.WriteLine()


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
			' Create an account.
			Dim account As Account = New Account With {.Name = "Litware, Inc."}
			_accountId = _service.Create(account)

			' Create the 2 contacts.
            Dim contact As New Contact() With
                {
                    .FirstName = "Ben",
                    .LastName = "Andrews",
                    .EMailAddress1 = "sample@example.com",
                    .Address1_City = "Redmond",
                    .Address1_StateOrProvince = "WA",
                    .Address1_Telephone1 = "(206)555-5555",
                    .ParentCustomerId = New EntityReference With
                                        {
                                            .Id = _accountId,
                                            .LogicalName = account.LogicalName
                                        }
                }
			_contactIdList.Add(_service.Create(contact))

            contact = New Contact() With
                      {
                          .FirstName = "Colin",
                          .LastName = "Wilcox",
                          .EMailAddress1 = "sample@example.com",
                          .Address1_City = "Bellevue",
                          .Address1_StateOrProvince = "WA",
                          .Address1_Telephone1 = "(425)555-5555",
                          .ParentCustomerId = New EntityReference With
                                              {
                                                  .Id = _accountId,
                                                  .LogicalName = account.LogicalName
                                              }
                      }
			_contactIdList.Add(_service.Create(contact))
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
                If answer.StartsWith("y") OrElse answer.StartsWith("Y") _
                    OrElse answer = String.Empty Then
                    toBeDeleted = True
                Else
                    toBeDeleted = False
                End If
			End If

			If toBeDeleted Then
				' Delete all records created in this sample.
				For Each contactId As Guid In _contactIdList
					_service.Delete(Contact.EntityLogicalName, contactId)
				Next contactId

				_service.Delete(Account.EntityLogicalName, _accountId)

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
                Dim config As ServerConnection.Configuration = _
                    serverConnect.GetServerConfiguration()

				Dim app As New RetrieveMultipleConditionOperatorsLinq()
				app.Run(config, True)
			Catch ex As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
				Console.WriteLine("The application terminated with an error.")
				Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp)
				Console.WriteLine("Code: {0}", ex.Detail.ErrorCode)
				Console.WriteLine("Message: {0}", ex.Detail.Message)
				Console.WriteLine("Plugin Trace: {0}", ex.Detail.TraceText)
                Console.WriteLine("Inner Fault: {0}",
                                  If(Nothing Is ex.Detail.InnerFault, "No Inner Fault", "Has Inner Fault"))
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

' </snippetretrievemultipleconditionoperatorslinq>
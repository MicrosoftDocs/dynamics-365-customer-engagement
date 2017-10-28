' <snippetuselinqquery>


Imports System.ServiceModel

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client


Namespace Microsoft.Crm.Sdk.Samples
	''' <summary>
	''' Demonstrates how to make LINQ queries with the OrganizationServiceContext
	''' object and strongly-typed entities.</summary>
	''' <remarks>
	''' At run-time, you will be given the option to delete all the
	''' database records created by this program.</remarks>
	Public Class UseLinqQuery
		#Region "Class Level Members"

		Private _accountIds As New List(Of Guid)()
		Private _contactIds As New List(Of Guid)()
		Private _leadIds As New List(Of Guid)()
        Private _taskIds As New List(Of Guid)()
        Private _serviceProxy As OrganizationServiceProxy
        Private _service As IOrganizationService

#End Region ' Class Level Members

#Region "How To Sample Code"
        ''' <summary>
        ''' This method first connects to the Organization service and service context.
        ''' Afterwards, several LINQ query techniques are demonstrated.
        ''' </summary>
        ''' <param name="serverConfig">Contains server connection information.</param>
        ''' <param name="promptForDelete">When True, the user will be prompted to delete
        ''' all created entities.</param>
        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration,
                       ByVal promptForDelete As Boolean)
            Try

                ' Connect to the Organization service. 
                ' The using statement assures that the service proxy will be properly disposed.
                _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
                Using _serviceProxy
                    ' This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes()

                    _service = CType(_serviceProxy, IOrganizationService)

                    CreateRequiredRecords()

                    Dim svcContext As New ServiceContext(_service)

                    ' Retrieve records with Skip/Take record paging. Setting a page size
                    ' can help you manage your Skip and Take calls, since Skip must be
                    ' passed a multiple of Take's parameter value.
                    Dim pageSize As Integer = 5

                    Dim accountsByPage = ( _
                        From a In svcContext.CreateQuery(Of Account)() _
                        Select New Account With {.Name = a.Name})
                    Console.WriteLine("Skip 10 accounts, then Take 5 accounts")
                    Console.WriteLine("======================================")
                    For Each a In accountsByPage.Skip(2 * pageSize).Take(pageSize)
                        Console.WriteLine(a.Name)
                    Next a
                    Console.WriteLine()
                    Console.WriteLine("<End of Listing>")
                    Console.WriteLine()

                    ' Use orderBy to order items retrieved.
                    Dim orderedAccounts = From a In svcContext.CreateQuery(Of Account)() _
                                          Order By a.Name _
                                          Select New Account With {.Name = a.Name}
                    Console.WriteLine("Display accounts ordered by name")
                    Console.WriteLine("================================")
                    For Each a In orderedAccounts
                        Console.WriteLine(a.Name)
                    Next a
                    Console.WriteLine()
                    Console.WriteLine("<End of Listing>")
                    Console.WriteLine()

                    ' Filter multiple entities using LINQ.
                    Dim query = From c In svcContext.CreateQuery(Of Contact)() _
                                Join a In svcContext.CreateQuery(Of Account)() _
                                On c.ContactId Equals a.PrimaryContactId.Id _
                                Where c.LastName.Equals("Wilcox") _
                                    OrElse c.LastName.Equals("Andrews") _
                                Where a.Address1_Telephone1.Contains("(206)") _
                                    OrElse a.Address1_Telephone1.Contains("(425)") _
                                Select New With
                                       {
                                           Key .Contact =
                                           New Contact With
                                           {
                                               .FirstName = c.FirstName,
                                               .LastName = c.LastName
                                           },
                                           Key .Account =
                                           New Account With
                                           {
                                               .Address1_Telephone1 =
                                               a.Address1_Telephone1
                                           }
                                        }

                    Console.WriteLine("Join account and contact")
                    Console.WriteLine("List all records matching specified parameters")
                    Console.WriteLine("Contact name: Wilcox or Andrews")
                    Console.WriteLine("Account area code: 206 or 425")
                    Console.WriteLine("==============================================")
                    For Each record In query
                        Console.WriteLine("Contact Name: {0} {1}",
                                          record.Contact.FirstName,
                                          record.Contact.LastName)
                        Console.WriteLine("Account Phone: {0}",
                                          record.Account.Address1_Telephone1)
                    Next record
                    Console.WriteLine("<End of Listing>")
                    Console.WriteLine()

                    ' Build a complex query with LINQ. 
                    'This query includes multiple JOINs.
                    'Note: Where statements are not working with the below multiple join query.
                    '       Refer equivalent C# snippet for full complex query.
                    'TODO: Fix issue to include where statements as shown in C# sample.
                    Dim complexQuery = From c In svcContext.CreateQuery(Of Contact)() _
                                       Join a In svcContext.CreateQuery(Of Account)() _
                                            On c.ContactId Equals a.PrimaryContactId.Id _
                                        Join l In svcContext.CreateQuery(Of Lead)() _
                                            On a.OriginatingLeadId.Id Equals l.LeadId _
                                        Select New With
                                              {
                                                  Key .Contact =
                                                  New Contact With
                                                  {
                                                      .FirstName = c.FirstName,
                                                      .LastName = c.LastName
                                                  },
                                                  Key .Account =
                                                  New Account With
                                                  {
                                                      .Address1_Telephone1 =
                                                      a.Address1_Telephone1
                                                  },
                                                  Key .Lead =
                                                  New Lead With
                                                  {
                                                      .LeadId = l.LeadId
                                                  }
                                              }
                    Console.WriteLine("Join account, contact and lead")
                    Console.WriteLine("List all records matching specified parameters")
                    Console.WriteLine("==============================================")
                    For Each record In complexQuery
                        Console.WriteLine("Lead ID: {0}", record.Lead.LeadId)
                        Console.WriteLine("Contact Name: {0} {1}",
                                          record.Contact.FirstName,
                                          record.Contact.LastName)
                        Console.WriteLine("Account Phone: {0}",
                                          record.Account.Address1_Telephone1)
                    Next record
                    Console.WriteLine("<End of Listing>")
                    Console.WriteLine()

                    'Retrieve a related Task for a Contact
                    'Shows requirement that LoadProperty must be used to access the related record.
                    Dim benAndrews As Contact = (From c In svcContext.ContactSet
                                                Where c.FullName.Equals("Ben Andrews")).FirstOrDefault()
                    If benAndrews IsNot Nothing Then
                        'benAndrews.Contact_Tasks is null until LoadProperty is used.
                        svcContext.LoadProperty(benAndrews, "Contact_Tasks")
                        Dim benAndrewsFirstTask As Task = benAndrews.Contact_Tasks.FirstOrDefault()
                        If benAndrewsFirstTask IsNot Nothing Then
                            Console.WriteLine("Ben Andrews first task with Subject: '{0}' retrieved.",
                                              benAndrewsFirstTask.Subject)
                        End If
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
        ''' Creates any entity records that this sample requires.
        ''' </summary>
        Public Sub CreateRequiredRecords()
            ' Create 3 contacts.
            Dim contact As New Contact() With
                {
                    .FirstName = "Ben",
                    .LastName = "Andrews",
                    .EMailAddress1 = "sample@example.com",
                    .Address1_City = "Redmond",
                    .Address1_StateOrProvince = "WA"
                }
            Dim benAndrewsContactId As Guid = _service.Create(contact)
            _contactIds.Add(benAndrewsContactId)

            'Create a task associated with Ben Andrews
            Dim task_Renamed As New Task() With
                {
                    .Subject = "Sample Task",
                    .RegardingObjectId = New EntityReference() With
                                         {
                                             .LogicalName = contact.EntityLogicalName,
                                             .Id = benAndrewsContactId,
                                             .Name = contact.FullName
                                         }
                }
            _taskIds.Add(_service.Create(task_Renamed))

            contact = New Contact() With
                      {
                          .FirstName = "Colin",
                          .LastName = "Wilcox",
                          .EMailAddress1 = "sample@example.com",
                          .Address1_City = "Bellevue",
                          .Address1_StateOrProvince = "WA"
                      }
            _contactIds.Add(_service.Create(contact))

            contact = New Contact() With
                      {
                          .FirstName = "Ben",
                          .LastName = "Smith",
                          .EMailAddress1 = "sample@example.com",
                          .Address1_City = "Bellevue",
                          .Address1_StateOrProvince = "WA"
                      }
            _contactIds.Add(_service.Create(contact))

            ' Create 3 leads.
            Dim lead As New Lead() With
                {
                    .FirstName = "Dan",
                    .LastName = "Wilson",
                    .EMailAddress1 = "sample@example.com",
                    .Address1_City = "Redmond",
                    .Address1_StateOrProvince = "WA"
                }
            _leadIds.Add(_service.Create(lead))

            lead = New Lead() With
                   {
                       .FirstName = "Jim",
                       .LastName = "Wilson",
                       .EMailAddress1 = "sample@example.com",
                       .Address1_City = "Bellevue",
                       .Address1_StateOrProvince = "WA"
                   }
            _leadIds.Add(_service.Create(lead))

            lead = New Lead() With
                   {
                       .FirstName = "Denise",
                       .LastName = "Smith",
                       .EMailAddress1 = "sample@example.com",
                       .Address1_City = "Bellevue",
                       .Address1_StateOrProvince = "WA"
                   }
            _leadIds.Add(_service.Create(lead))

            ' Create 5 customized Accounts for the LINQ samples.
            Dim account As Account =
                New Account With
                    {
                        .Name = "A. Datum Corporation",
                        .Address1_StateOrProvince = "Colorado",
                        .Address1_Telephone1 = "(206)555-5555",
                        .PrimaryContactId =
                        New EntityReference(contact.EntityLogicalName,
                                            _contactIds(0))
                    }
            _accountIds.Add(_service.Create(account))

            account =
                New Account With
                {
                    .Name = "Adventure Works",
                    .Address1_StateOrProvince = "Illinois",
                    .Address1_County = "Lake County",
                    .Address1_Telephone1 = "(206)555-5555",
                    .OriginatingLeadId = New EntityReference(lead.EntityLogicalName,
                                                             _leadIds(0))
                }
            _accountIds.Add(_service.Create(account))

            account =
                New Account With
                {
                    .Name = "Coho Vineyard",
                    .Address1_StateOrProvince = "Washington",
                    .Address1_County = "King County",
                    .Address1_Telephone1 = "(425)555-5555",
                    .PrimaryContactId = New EntityReference(contact.EntityLogicalName,
                                                            _contactIds(1)),
                    .OriginatingLeadId = New EntityReference(lead.EntityLogicalName,
                                                             _leadIds(0))
                }
            _accountIds.Add(_service.Create(account))

            account =
                New Account With
                {
                    .Name = "Fabrikam",
                    .Address1_StateOrProvince = "Washington",
                    .Address1_Telephone1 = "(425)555-5555",
                    .PrimaryContactId = New EntityReference(contact.EntityLogicalName,
                                                            _contactIds(0))
                }
            _accountIds.Add(_service.Create(account))

            account =
                New Account With
                {
                    .Name = "Humongous Insurance",
                    .Address1_StateOrProvince = "Missouri",
                    .Address1_County = "Saint Louis County",
                    .Address1_Telephone1 = "(314)555-5555",
                    .PrimaryContactId = New EntityReference(contact.EntityLogicalName,
                                                            _contactIds(1))
                }
            _accountIds.Add(_service.Create(account))

            ' Create 10 basic Account records.
            For i As Integer = 1 To 10
                account =
                    New Account With
                    {
                        .Name = "Fourth Coffee " &amp; i,
                        .Address1_StateOrProvince = "California"
                    }
                _accountIds.Add(_service.Create(account))
            Next i
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

                For Each taskId As Guid In _taskIds
                    _service.Delete(Task.EntityLogicalName, taskId)
                Next taskId
                For Each accountId As Guid In _accountIds
                    _service.Delete(Account.EntityLogicalName, accountId)
                Next accountId
                For Each contactId As Guid In _contactIds
                    _service.Delete(Contact.EntityLogicalName, contactId)
                Next contactId
                For Each leadId As Guid In _leadIds
                    _service.Delete(Lead.EntityLogicalName, leadId)
                Next leadId
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

				Dim app As New UseLinqQuery()
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

' </snippetuselinqquery>
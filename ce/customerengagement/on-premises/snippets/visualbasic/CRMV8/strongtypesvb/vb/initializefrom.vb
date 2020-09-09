' <snippetinitializefrom>


Imports Microsoft.VisualBasic
Imports System
Imports System.ServiceModel

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Xrm.Sdk.Client

' This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Crm.Sdk.Messages

Namespace Microsoft.Crm.Sdk.Samples
	''' <summary>
	''' This sample shows how to use the InitializeFrom message to create new records
	''' from existing records
	''' </summary>
	''' <param name="serverConfig">Contains server connection information.</param>
	''' <param name="promptforDelete">When True, the user will be prompted to delete all
	''' created entities.</param>
	Public Class InitializeFrom
		#Region "Class Level Members"

		Private _serviceProxy As OrganizationServiceProxy

		Private _initialAccount As Account
		Private _initialLead As Lead

		#End Region ' Class Level Members

		#Region "How To Sample Code"
		''' <summary>
		''' This method first creates an account and a lead, then initializes a new
		''' account from the already existing account and a new opportunity from the
		''' already existing lead.
		''' </summary>
		''' <param name="serverConfig">Contains server connection information.</param>
		''' <param name="promptforDelete">When True, the user will be prompted to delete all
		''' created entities.</param>

        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration,
                       ByVal promptforDelete As Boolean)
            Try
                ' Connect to the Organization service. 
                ' The using statement assures that the service proxy will be properly 
                ' disposed.
                _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
                Using _serviceProxy
                    ' This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes()

                    CreateRequiredRecords()

                    '					#Region "Initialize Account from Account"
                    Console.WriteLine()
                    Console.WriteLine("  Initializing new Account from the initial Account")

                    ' Create the request object
                    Dim initialize As New InitializeFromRequest()

                    ' Set the properties of the request object
                    initialize.TargetEntityName = Account.EntityLogicalName.ToString()

                    ' Create the EntityMoniker
                    initialize.EntityMoniker = _initialAccount.ToEntityReference()

                    ' Execute the request
                    Dim initialized As InitializeFromResponse =
                        CType(_serviceProxy.Execute(initialize), InitializeFromResponse)

                    If initialized.Entity IsNot Nothing Then
                        Console.WriteLine("  New Account initialized successfully")
                    End If

                    Console.WriteLine()
                    '					#End Region

                    '					#Region "Initialize Opportunity from Lead"
                    Console.WriteLine("  Initializing an Opportunity from the initial Lead")

                    ' Create the request object
                    initialize.TargetEntityName = Opportunity.EntityLogicalName.ToString()

                    ' Create the EntityMoniker
                    initialize.EntityMoniker = _initialLead.ToEntityReference()

                    ' Execute the request
                    initialized = CType(_serviceProxy.Execute(initialize), InitializeFromResponse)

                    If initialized.Entity IsNot Nothing AndAlso
                        initialized.Entity.LogicalName = Opportunity.EntityLogicalName Then
                        Dim opportunity = CType(initialized.Entity, Opportunity)
                        Console.WriteLine("  New Opportunity initialized successfully (Name={0})",
                                          opportunity.Name)
                    End If
                    '					#End Region

                    DeleteRequiredRecords(promptforDelete)
                End Using

                ' Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            Catch fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                ' You can handle an exception here or pass it back to the calling method.
                Throw
            End Try
        End Sub

		#Region "Public methods"

		''' <summary>
		''' Creates any entity records that this sample requires.
		''' </summary>
		Public Sub CreateRequiredRecords()
			_initialAccount = New Account() With {.Name = "Contoso, Ltd"}
			_initialAccount.Id = _serviceProxy.Create(_initialAccount)
            Console.WriteLine("  Created initial Account (Name={0})",
                              _initialAccount.Name)

            _initialLead = New Lead() With
                           {
                               .Subject = "A Sample Lead",
                               .LastName = "Wilcox",
                               .FirstName = "Colin"
                           }
			_initialLead.Id = _serviceProxy.Create(_initialLead)
            Console.WriteLine("  Created initial Lead (Subject={0}, Name={1} {2})",
                              _initialLead.Subject,
                              _initialLead.FirstName,
                              _initialLead.LastName)
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
                If answer.StartsWith("y") OrElse
                    answer.StartsWith("Y") OrElse
                    answer = String.Empty Then
                    toBeDeleted = True
                Else
                    toBeDeleted = False
                End If
			End If

			If toBeDeleted Then
				_serviceProxy.Delete(Account.EntityLogicalName, _initialAccount.Id)
				_serviceProxy.Delete(Lead.EntityLogicalName, _initialLead.Id)
                Console.WriteLine("Entity records have been deleted.")
            End If
		End Sub
		#End Region ' Public Methods

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

				Dim app As New InitializeFrom()
				app.Run(config, True)
			Catch ex As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
				Console.WriteLine("The application terminated with an error.")
				Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp)
				Console.WriteLine("Code: {0}", ex.Detail.ErrorCode)
				Console.WriteLine("Message: {0}", ex.Detail.Message)
				Console.WriteLine("Plugin Trace: {0}", ex.Detail.TraceText)
                Console.WriteLine("Inner Fault: {0}",
                                  If(Nothing Is ex.Detail.InnerFault, "No Inner Fault", "Has Inner Fault"))
			Catch ex As System.TimeoutException
				Console.WriteLine("The application terminated with an error.")
				Console.WriteLine("Message: {0}", ex.Message)
				Console.WriteLine("Stack Trace: {0}", ex.StackTrace)
                Console.WriteLine("Inner Fault: {0}",
                                  If(Nothing Is ex.InnerException.Message, "No Inner Fault", ex.InnerException.Message))
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

' </snippetinitializefrom>
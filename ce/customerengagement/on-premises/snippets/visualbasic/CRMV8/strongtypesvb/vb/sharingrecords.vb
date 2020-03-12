' <snippetsharingrecords>


Imports System.ServiceModel

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client

' This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Crm.Sdk.Messages


Namespace Microsoft.Crm.Sdk.Samples

	''' <summary>
	''' Demonstrates sharing records via access messages.
	''' </summary>
	Public Class SharingRecords

		#Region "Class Level Members"

		Private _userId As Guid
		Private _accountId As Guid
		Private _serviceProxy As OrganizationServiceProxy
		Private _service As IOrganizationService

		#End Region ' Class Level Members

		#Region "How-To Sample Code"
		''' <summary>
		''' Demonstrates sharing records by exercising various access messages including:
		''' Grant, Modify, Revoke, RetrievePrincipalAccess, and 
		''' RetrievePrincipalsAndAccess.
		''' </summary>
		''' <param name="serverConfig">Contains server connection information.</param>
		''' <param name="promptforDelete">When True, the user will be prompted to delete all
		''' created entities.</param>
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

                    '					#Region "GrantAccess Message"

                    ' Create the request object and set the target and principal access
                    ' object.
                    Dim grantRequest As New GrantAccessRequest() With
                        {
                            .Target = New EntityReference(Account.EntityLogicalName,
                                                          _accountId),
                            .PrincipalAccess =
                            New PrincipalAccess() With
                            {
                                .Principal =
                                New EntityReference(SystemUser.EntityLogicalName,
                                                    _userId),
                                .AccessMask = AccessRights.WriteAccess _
                                                Or AccessRights.ReadAccess _
                                                Or AccessRights.ShareAccess
                            }
                        }

                    ' Execute the request.
                    Dim grantResponse As GrantAccessResponse =
                        CType(_service.Execute(grantRequest), GrantAccessResponse)

                    Console.Write("Access Granted ")

                    '					#End Region

                    '					#Region "ModifyAccess Message"

                    ' Create the request object and set the target and principal access
                    ' object.
                    Dim modifyRequest As New ModifyAccessRequest() With
                        {
                            .Target = New EntityReference(Account.EntityLogicalName,
                                                          _accountId),
                            .PrincipalAccess =
                            New PrincipalAccess() With
                            {
                                .Principal =
                                New EntityReference(SystemUser.EntityLogicalName,
                                                    _userId),
                                .AccessMask = AccessRights.ReadAccess _
                                                Or AccessRights.ShareAccess
                            }
                        }

                    ' Execute the request.
                    Dim modifyResponse As ModifyAccessResponse =
                        CType(_service.Execute(modifyRequest), ModifyAccessResponse)

                    Console.Write("and Modified. ")

                    '					#End Region

                    '					#Region "RetrievePrincipalAccess Message"

                    ' Create the request object and set the target and principal.
                    Dim retrieveRequest As New RetrievePrincipalAccessRequest() With
                        {
                            .Target = New EntityReference(Account.EntityLogicalName,
                                                          _accountId),
                            .Principal = New EntityReference(SystemUser.EntityLogicalName,
                                                             _userId)
                        }

                    ' Execute the request.
                    Dim retrieveResponse As RetrievePrincipalAccessResponse =
                        CType(_service.Execute(retrieveRequest), 
                            RetrievePrincipalAccessResponse)

                    Console.Write("Retrieved principal access. ")

                    '					#End Region

                    '					#Region "RetrieveSharedPrincipalsAndAccess Message"

                    ' Create the request object and set the target.
                    Dim retrieveSharedRequest As _
                        New RetrieveSharedPrincipalsAndAccessRequest() With
                        {
                            .Target = New EntityReference(Account.EntityLogicalName,
                                                          _accountId)
                        }

                    ' Execute the request.
                    Dim retrieveSharedResponse As  _
                        RetrieveSharedPrincipalsAndAccessResponse =
                        CType(_service.Execute(retrieveSharedRequest), 
                            RetrieveSharedPrincipalsAndAccessResponse)

                    Console.Write("Retrieved principals and access. ")

                    '					#End Region

                    '					#Region "RevokeAccess Message"

                    ' Create the request object and set the target and revokee.
                    Dim revokeRequest As _
                        New RevokeAccessRequest() With
                        {
                            .Target = New EntityReference(Account.EntityLogicalName,
                                                          _accountId),
                            .Revokee = New EntityReference(SystemUser.EntityLogicalName,
                                                           _userId)
                        }

                    ' Execute the request.
                    Dim revokeResponse As RevokeAccessResponse =
                        CType(_service.Execute(revokeRequest), 
                            RevokeAccessResponse)

                    Console.Write("Revoked Access.")

                    '					#End Region

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
			' Get the GUID of the Marketing Manager
			_userId = SystemUserProvider.RetrieveMarketingManager(_serviceProxy)

			' Instantiate an Account object.
			' See the Entity Metadata topic in the SDK documentation to determine
			' which attributes must be set for each entity.
			Dim setupAccount As New Account() With {.Name = "Fourth Coffee"}
			_accountId = _service.Create(setupAccount)
		End Sub

		''' <summary>
		''' Deletes any entity records and files that were created for this sample.
		''' <param name="prompt">Indicates whether to prompt the user 
		''' to delete the records created in this sample.</param>
		''' </summary>
		Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
			' The system user named "Samantha Smith" that was created by this sample will
			' continue to exist on your system because system users cannot be deleted
			' in Microsoft Dynamics CRM.  They can only be enabled or disabled.
			' If not prompting the user, go ahead and clean up.

			If Not prompt Then
				_service.Delete(Account.EntityLogicalName, _accountId)
				Console.WriteLine("Entity record(s) have been deleted.")
				Return
			End If

			' Ask the user if the created entities should be deleted.
			Console.Write(vbLf &amp; "Do you want these entity records deleted? (y/n) [y]: ")
			Dim answer As String = Console.ReadLine()

            If answer.StartsWith("y") OrElse answer.StartsWith("Y") _
                OrElse answer = String.Empty Then
                _service.Delete(Account.EntityLogicalName, _accountId)
                Console.WriteLine("Entity record(s) have been deleted.")
            End If
		End Sub

		#End Region ' How-To Sample Code

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

				Dim app As New SharingRecords()
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

' </snippetsharingrecords>
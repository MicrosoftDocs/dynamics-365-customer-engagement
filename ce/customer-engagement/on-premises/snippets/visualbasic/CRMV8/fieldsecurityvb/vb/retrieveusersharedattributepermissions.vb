' <snippetretrieveusersharedattributepermissions>


Imports Microsoft.VisualBasic
Imports System
Imports System.ServiceModel
Imports System.Linq

' This namespace is in the Microsoft.Crm.Sdk.Proxy.dll assembly
' located in the SDK\bin folder.
Imports Microsoft.Crm.Sdk.Messages

' These namespaces are in the Microsoft.Xrm.Sdk.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Messages
Imports Microsoft.Xrm.Sdk.Query
Imports Microsoft.Xrm.Sdk.Metadata

Namespace Microsoft.Crm.Sdk.Samples
	''' <summary>
    ''' Currently, users must have prvReadPOAA permissions to access any
    ''' PrincipleObjectAttributeAccess (POAA) records. However, in an upcoming 
    ''' release, users who do not have prvReadPOAA permissions will be able 
    ''' to access POAA records by using the RetrieveMultiple method. Users  
    ''' will be able to retrieve attribute permissions for attributes shared
    ''' directly or indirectly (through teams) with themselves.
	''' </summary>
	''' <remarks>
    ''' At run time, you will be given the option to delete all the
	''' database records created by this program.
	''' </remarks>
	Public Class RetrieveUserSharedAttributePermissions
		#Region "Class Level Members"

		Private _accountRecordId As Guid
		Private _secretPhoneId As Guid
		Private _secretHomeId As Guid
		Private _serviceProxy As OrganizationServiceProxy

		#End Region ' Class Level Members

		#Region "How To Sample Code"
		''' <summary>
        ''' This method first checks if the logged on user has prvReadPOAA permissions. 
        ''' Afterwards, the method creates the secure custom fields required for this sample,
        ''' an account record for testing purposes, and POAA records for the user
		''' and those custom fields.
        ''' Finally, the method retrieves the User Shared Attribute permissions for that user.
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

                    CreateRequiredRecords()

                    '					#Region "Check if this user has prvReadPOAA"
                    ' Get the GUID of the current user.
                    Dim whoAmI As New WhoAmIRequest()
                    Dim userLoggedId As Guid = (CType(_serviceProxy.Execute(whoAmI), 
                                                WhoAmIResponse)).UserId
                    Console.WriteLine("User logged: " &amp; userLoggedId.ToString())

                    ' Check if this user has prvReadPOAA.
                    Dim userPrivilegesRequest As New RetrieveUserPrivilegesRequest()
                    userPrivilegesRequest.UserId = userLoggedId
                    Dim userPrivilegesResponse As RetrieveUserPrivilegesResponse =
                        CType(_serviceProxy.Execute(userPrivilegesRequest), RetrieveUserPrivilegesResponse)

                    ' Fixed the GUID for prvReadPOAA.
                    Dim prvReadPOAA As New Guid("{68564CD5-2B2E-11DF-80A6-00137299E1C2}")

                    If userPrivilegesResponse.RolePrivileges.Any(Function(r) r.PrivilegeId.Equals(prvReadPOAA)) Then
                        Console.WriteLine("This user DOES have prvReadPOAA")
                    Else
                        Console.WriteLine("This user DOESN'T have prvReadPOAA")
                    End If
                    Console.WriteLine()
                    '					#End Region ' Check if this user has prvReadPOAA

                    '					#Region "Create an account record"

                    ' Create an account record.
                    Dim accountRecord As New Account()
                    accountRecord.Name = "Ane"
                    accountRecord("secret_phone") = "123456"
                    _accountRecordId = _serviceProxy.Create(accountRecord)
                    Console.WriteLine("Account record created.")

                    '					#End Region ' Create an account record

                    '					#Region "Create POAA entity for field #1"

                    ' Create the POAA entity for field #1.
                    Dim poaa As PrincipalObjectAttributeAccess =
                        New PrincipalObjectAttributeAccess With
                        {
                            .AttributeId = _secretHomeId,
                            .ObjectId = New EntityReference(Account.EntityLogicalName, _accountRecordId),
                            .PrincipalId = New EntityReference(SystemUser.EntityLogicalName, userLoggedId),
                            .ReadAccess = True,
                            .UpdateAccess = True
                        }

                    _serviceProxy.Create(poaa)
                    Console.WriteLine("POAA record for custom field Secret_Home created.")

                    '					#End Region ' Create POAA entity for field #1

                    '					#Region "Create POAA entity for field #2"

                    ' Create the POAA entity for field #2.
                    poaa = New PrincipalObjectAttributeAccess With
                           {
                               .AttributeId = _secretPhoneId,
                               .ObjectId = New EntityReference(Account.EntityLogicalName, _accountRecordId),
                               .PrincipalId = New EntityReference(SystemUser.EntityLogicalName, userLoggedId),
                               .ReadAccess = True,
                               .UpdateAccess = True
                           }

                    _serviceProxy.Create(poaa)
                    Console.WriteLine("POAA record for custom field Secret_Phone created.")

                    '					#End Region ' Create POAA entity for field #2

                    '					#Region "Retrieve User Shared Attribute Permissions"
                    ' Create the query for retrieve User Shared Attribute permissions.
                    Dim queryPOAA As New QueryExpression("principalobjectattributeaccess")
                    queryPOAA.ColumnSet = New ColumnSet(New String() {"attributeid", "readaccess",
                                                                      "updateaccess", "principalid"})
                    queryPOAA.Criteria.FilterOperator = LogicalOperator.And
                    queryPOAA.Criteria.Conditions.Add(New ConditionExpression("objectid",
                                                                              ConditionOperator.Equal,
                                                                              _accountRecordId))
                    queryPOAA.Criteria.Conditions.Add(New ConditionExpression("principalid",
                                                                              ConditionOperator.EqualUserId))

                    Console.WriteLine()
                    Console.WriteLine("POAA for user: " &amp; userLoggedId.ToString())
                    Console.WriteLine()

                    Try
                        ' Execute the query.
                        Dim responsePOAA As EntityCollection = _serviceProxy.RetrieveMultiple(queryPOAA)

                        For Each entity In responsePOAA.Entities
                            Console.WriteLine("  principalid: " &amp; _
                                              (CType(entity("principalid"), EntityReference)).Id.ToString())
                            Console.WriteLine("  attributeid: " &amp; _
                                              entity("attributeid").ToString())
                            Console.WriteLine("  readaccess: " &amp; entity("readaccess").ToString())
                            Console.WriteLine("  updateaccess: " &amp; entity("updateaccess").ToString())
                            Console.WriteLine()
                        Next entity
                    Catch exc As Exception
                        Console.WriteLine("Error: " &amp; exc.Message)
                    End Try

                    '					#End Region ' Retrieve User Shared Attribute Permissions

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
'			#Region "Create custom fields in account entity"

            ' Create secure custom field #1.
            Dim attrReq As New CreateAttributeRequest() With
                {
                    .Attribute = New StringAttributeMetadata() With
                                 {
                                     .LogicalName = "secret_home",
                                     .DisplayName = New Label("SecretHome", 1033),
                                     .SchemaName = "Secret_Home", .MaxLength = 500,
                                     .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
                                     .IsSecured = True
                                 },
                    .EntityName = Account.EntityLogicalName
                }
			Dim attributeResponse As CreateAttributeResponse = CType(_serviceProxy.Execute(attrReq), CreateAttributeResponse)
			_secretHomeId = attributeResponse.AttributeId
			Console.WriteLine("Secret_Home custom field created.")

            ' Create secure custom field #2.
            attrReq = New CreateAttributeRequest() With
                      {
                          .Attribute = New StringAttributeMetadata() With
                                       {
                                           .LogicalName = "secret_phone",
                                           .DisplayName = New Label("SecretPhone", 1033),
                                           .SchemaName = "Secret_Phone",
                                           .MaxLength = 500,
                                           .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
                                           .IsSecured = True
                                       },
                          .EntityName = Account.EntityLogicalName
                      }
			attributeResponse = CType(_serviceProxy.Execute(attrReq), CreateAttributeResponse)
			_secretPhoneId = attributeResponse.AttributeId
			Console.WriteLine("Secret_Phone custom field created.")

'			#End Region ' Create custom fields in account entity

			Console.WriteLine()
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
				' Delete all records created in this sample.
                ' Delete secured custom field #1.
                Dim deleteRequest As New DeleteAttributeRequest() With
                    {
                        .EntityLogicalName = Account.EntityLogicalName,
                        .LogicalName = "secret_phone",
                        .RequestId = _secretPhoneId
                    }
				_serviceProxy.Execute(deleteRequest)
                ' Delete secured custom field #2.
                deleteRequest = New DeleteAttributeRequest() With
                                {
                                    .EntityLogicalName = Account.EntityLogicalName,
                                    .LogicalName = "secret_home",
                                    .RequestId = _secretHomeId
                                }
				_serviceProxy.Execute(deleteRequest)

                ' Delete the account record.
				_serviceProxy.Delete(Account.EntityLogicalName, _accountRecordId)

				' We don't need to delete POAA records, 
                ' because they were already deleted when we deleted the account record.

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
                ' Obtain the target organization's web address and client logon 
				' credentials from the user.
				Dim serverConnect As New ServerConnection()
				Dim config As ServerConnection.Configuration = serverConnect.GetServerConfiguration()

				Dim app As New RetrieveUserSharedAttributePermissions()
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

' </snippetretrieveusersharedattributepermissions>
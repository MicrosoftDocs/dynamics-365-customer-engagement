' <snippetretrievesecuredfieldsforauser>


Imports System.ServiceModel

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Messages
Imports Microsoft.Xrm.Sdk.Metadata
Imports Microsoft.Xrm.Sdk.Query

' This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Crm.Sdk.Messages

Namespace Microsoft.Crm.Sdk.Samples
	''' <summary>
	''' Demonstrates how to retrieve secured fields for a user.
	''' </summary>
	''' <remarks>
	''' At run-time, you will be given the option to delete all the
	''' database records created by this program.</remarks>
	Public Class RetrieveSecuredFieldsForAUser

		#Region "Class Level Members"

		Private _roleId As Guid
		Private _teamId As Guid
		Private _userId As Guid
		Private _profileId As Guid
		Private _identityId As Guid
		Private _messageId As Guid
		Private _identityPermissionId As Guid
		Private _serviceProxy As OrganizationServiceProxy

		#End Region ' Class Level Members

		#Region "How-To Sample Code"
		''' <summary>
		''' This method first connects to the Organization service. Afterwards, an 
		''' authorization profile is created, and associated to a team. Then an entity
		''' is created and permissions for the entity are assigned to the profile. These
		''' permissions are then retrieved.
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

                    ' Create Field Security Profile.
                    Dim managersProfile As New FieldSecurityProfile()
                    managersProfile.Name = "Managers"
                    _profileId = _serviceProxy.Create(managersProfile)
                    Console.Write("Created Profile, ")

                    ' Add team to profile.
                    Dim teamToProfile As New AssociateRequest() With
                        {
                            .Target = New EntityReference(
                                FieldSecurityProfile.EntityLogicalName,
                                _profileId),
                            .RelatedEntities = New EntityReferenceCollection() From
                            {
                                New EntityReference(Team.EntityLogicalName, _teamId)
                            },
                            .Relationship = New Relationship("teamprofiles_association")}
                    _serviceProxy.Execute(teamToProfile)

                    ' Add user to the profile.
                    Dim userToProfile As New AssociateRequest() With
                        {
                            .Target = New EntityReference(
                                FieldSecurityProfile.EntityLogicalName,
                                _profileId),
                            .RelatedEntities = New EntityReferenceCollection() From
                            {
                                New EntityReference(SystemUser.EntityLogicalName, _userId)
                            },
                            .Relationship =
                            New Relationship("systemuserprofiles_association")
                        }
                    _serviceProxy.Execute(userToProfile)

                    ' Create custom activity entity.
                    Dim req As New CreateEntityRequest() With
                        {
                            .Entity = New EntityMetadata With
                                      {
                                          .LogicalName = "new_tweet",
                                          .DisplayName = New Label("Tweet", 1033),
                                          .DisplayCollectionName = New Label("Tweet",
                                                                             1033),
                                          .OwnershipType = OwnershipTypes.UserOwned,
                                          .SchemaName = "New_Tweet",
                                          .IsActivity = True,
                                          .IsAvailableOffline = True,
                                          .IsAuditEnabled =
                                          New BooleanManagedProperty(True),
                                          .IsMailMergeEnabled =
                                          New BooleanManagedProperty(False)
                                      },
                            .HasActivities = False,
                            .HasNotes = True,
                            .PrimaryAttribute =
                            New StringAttributeMetadata() With
                            {
                                .SchemaName = "Subject",
                                .LogicalName = "subject",
                                .RequiredLevel =
                                New AttributeRequiredLevelManagedProperty(
                                    AttributeRequiredLevel.None),
                                .MaxLength = 100,
                                .DisplayName = New Label("Subject", 1033)
                            }
                        }
                    _serviceProxy.Execute(req)
                    Console.Write("Entity Created, ")

                    ' Add privileges for the Tweet entity to the Marketing Role.
                    Dim privileges(2) As RolePrivilege

                    ' SDK: prvCreateActivity
                    privileges(0) = New RolePrivilege()
                    privileges(0).PrivilegeId = New Guid(
                        "{091DF793-FE5E-44D4-B4CA-7E3F580C4664}")
                    privileges(0).Depth = PrivilegeDepth.Global

                    ' SDK: prvReadActivity
                    privileges(1) = New RolePrivilege()
                    privileges(1).PrivilegeId = New Guid(
                        "{650C14FE-3521-45FE-A000-84138688E45D}")
                    privileges(1).Depth = PrivilegeDepth.Global

                    ' SDK: prvWriteActivity
                    privileges(2) = New RolePrivilege()
                    privileges(2).PrivilegeId = New Guid(
                        "{0DC8F72C-57D5-4B4D-8892-FE6AAC0E4B81}")
                    privileges(2).Depth = PrivilegeDepth.Global

                    ' Create and execute the request.
                    Dim request As New AddPrivilegesRoleRequest() With
                        {
                            .RoleId = _roleId,
                            .Privileges = privileges
                        }
                    Dim response As AddPrivilegesRoleResponse =
                        CType(_serviceProxy.Execute(request), 
                            AddPrivilegesRoleResponse)

                    ' Create custom identity attribute.
                    Dim attrReq As New CreateAttributeRequest() With
                        {
                            .Attribute = New StringAttributeMetadata() With
                                         {
                                             .LogicalName = "new_identity",
                                             .DisplayName = New Label("Identity", 1033),
                                             .SchemaName = "New_Identity",
                                             .MaxLength = 500,
                                             .RequiredLevel = New AttributeRequiredLevelManagedProperty(
                                                 AttributeRequiredLevel.Recommended),
                                             .IsSecured = True
                                         },
                            .EntityName = "new_tweet"
                        }
                    Dim identityAttributeResponse As CreateAttributeResponse =
                        CType(_serviceProxy.Execute(attrReq), 
                            CreateAttributeResponse)
                    _identityId = identityAttributeResponse.AttributeId
                    Console.Write("Identity Created, ")

                    ' Create custom message attribute.
                    attrReq = New CreateAttributeRequest() With
                              {
                                  .Attribute = New StringAttributeMetadata() With
                                               {
                                                   .LogicalName = "new_message",
                                                   .DisplayName = New Label("Message",
                                                                            1033),
                                                   .SchemaName = "New_Message",
                                                   .MaxLength = 140,
                                                   .RequiredLevel =
                                                   New AttributeRequiredLevelManagedProperty(
                                                       AttributeRequiredLevel.Recommended),
                                                   .IsSecured = True
                                               },
                                  .EntityName = "new_tweet"
                              }
                    Dim messageAttributeResponse As CreateAttributeResponse =
                        CType(_serviceProxy.Execute(attrReq), CreateAttributeResponse)
                    _messageId = messageAttributeResponse.AttributeId
                    Console.Write("Message Created, ")

                    ' Create field permission object for Identity.
                    Dim identityPermission As New FieldPermission()
                    identityPermission.AttributeLogicalName = "new_identity"
                    identityPermission.EntityName = "new_tweet"
                    identityPermission.CanRead =
                        New OptionSetValue(FieldPermissionType.Allowed)
                    identityPermission.FieldSecurityProfileId =
                        New EntityReference(FieldSecurityProfile.EntityLogicalName,
                                            _profileId)
                    _identityPermissionId = _serviceProxy.Create(identityPermission)
                    Console.Write("Permission Created, ")

                    ' Create list for storing retrieved profiles.
                    Dim profileIds As New List(Of Guid)()

                    ' Build query to obtain the field security profiles.
                    Dim qe As New QueryExpression() With
                        {
                            .EntityName = FieldSecurityProfile.EntityLogicalName,
                            .ColumnSet = New ColumnSet("fieldsecurityprofileid")
                        }
                    Dim qeLink As New LinkEntity With
                        {
                            .LinkFromEntityName = FieldSecurityProfile.EntityLogicalName,
                            .LinkToEntityName = SystemUser.EntityLogicalName
                        }
                    qeLink.LinkCriteria.AddCondition("systemuserid",
                                                ConditionOperator.Equal,
                                                _userId)
                    qe.LinkEntities.Add(qeLink)
                    
                    ' Execute the query and obtain the results.
                    Dim rmRequest As New RetrieveMultipleRequest() With {.Query = qe}

                    Dim bec As EntityCollection =
                        (CType(_serviceProxy.Execute(rmRequest), 
                         RetrieveMultipleResponse)).EntityCollection

                    ' Extract profiles from query result.
                    For Each profileEnt As FieldSecurityProfile In bec.Entities
                        profileIds.Add(profileEnt.FieldSecurityProfileId.Value)
                    Next profileEnt
                    Console.Write("Profiles Retrieved, ")

                    ' Retrieve attribute permissions of a FieldSecurityProfile.
                    Dim dc As DataCollection(Of Entity)

                    ' Retrieve the attributes.
                    Dim qba As New QueryByAttribute(FieldPermission.EntityLogicalName)
                    qba.AddAttributeValue("fieldsecurityprofileid", _profileId)
                    qba.ColumnSet = New ColumnSet("attributelogicalname")

                    dc = _serviceProxy.RetrieveMultiple(qba).Entities
                    Console.Write("Attributes Retrieved. ")

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
			' Get the user from the Helper.
			_userId = SystemUserProvider.RetrieveMarketingManager(_serviceProxy)
			Console.Write("User retrieved, ")

			' Retrieve the security role needed to assign to the user.
            Dim roleQuery As QueryExpression =
                New QueryExpression With
                {
                    .EntityName = Role.EntityLogicalName,
                    .ColumnSet = New ColumnSet("roleid")
                }
            roleQuery.Criteria.AddCondition(
                New ConditionExpression("name",
                                        ConditionOperator.Equal,
                                        "Marketing Manager"))

            Dim role_renamed As Role =
                CType(_serviceProxy.RetrieveMultiple(roleQuery).Entities(0), 
                    Role)
            _roleId = role_renamed.Id

			' Retrieve the default business unit needed to create the team.
            Dim queryDefaultBusinessUnit As QueryExpression =
                New QueryExpression With
                {
                    .EntityName = BusinessUnit.EntityLogicalName,
                    .ColumnSet = New ColumnSet("businessunitid")
                }
            queryDefaultBusinessUnit.Criteria.AddCondition(
                New ConditionExpression("parentbusinessunitid",
                                        ConditionOperator.Null))

			' Execute the query.
            Dim defaultBusinessUnit As BusinessUnit =
                CType(_serviceProxy.RetrieveMultiple(queryDefaultBusinessUnit).Entities(0), 
                    BusinessUnit)

			' Instantiate a team entity record and set its property values.
			' See the Entity Metadata topic in the SDK documentation to determine
			' which attributes must be set for each entity.
            Dim setupTeam As Team =
                New Team With
                {
                    .Name = "ABC Management Team",
                    .BusinessUnitId = New EntityReference(BusinessUnit.EntityLogicalName,
                                                          defaultBusinessUnit.Id)
                }

			' Create a team record.
			_teamId = _serviceProxy.Create(setupTeam)
			Console.Write("Created Team, ")
		End Sub

		''' <summary>
		''' Deletes any entity records and files that were created for this sample.
		''' <param name="prompt">Indicates whether to prompt the user 
		''' to delete the records created in this sample.</param>
		''' </summary>
		Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
			Dim deleteRecords As Boolean = True

			If prompt Then
				Console.WriteLine(vbLf &amp; "Do you want these entity records deleted? (y/n) [y]: ")
				Dim answer As String = Console.ReadLine()

                deleteRecords = (answer.StartsWith("y") OrElse answer.StartsWith("Y") _
                                 OrElse answer = String.Empty)
			End If

			If deleteRecords Then
				Dim del As New DeleteEntityRequest() With {.LogicalName = "new_tweet"}
				_serviceProxy.Execute(del)
				_serviceProxy.Delete(FieldSecurityProfile.EntityLogicalName, _profileId)
				_serviceProxy.Delete(Team.EntityLogicalName, _teamId)
				Console.WriteLine("Entity records have been deleted.")
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
				Dim config As ServerConnection.Configuration = serverConnect.GetServerConfiguration()

				Dim app As New RetrieveSecuredFieldsForAUser()
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

' </snippetretrievesecuredfieldsforauser>
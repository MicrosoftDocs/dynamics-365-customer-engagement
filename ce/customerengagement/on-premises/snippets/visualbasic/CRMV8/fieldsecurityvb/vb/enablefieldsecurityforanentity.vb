' <snippetenablefieldsecurityforanentity>


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
    ''' Demonstrates how to create enable field security for an entity.</summary>
    ''' <remarks>
    ''' At run-time, you will be given the option to delete all the
    ''' database records created by this program.</remarks>
    Public Class EnableFieldSecurityForAnEntity

        #Region "Class Level Members"

        Private _teamId As Guid
        Private _profileId As Guid
        Private _identityId As Guid
        Private _messageId As Guid
        Private _identityPermissionId As Guid
        Private _serviceProxy As OrganizationServiceProxy

        #End Region ' Class Level Members

        #Region "How-To Sample Code"
        ''' <summary>
        ''' This method first connects to the Organization service. Afterwards,
        ''' a FieldSecurityProfile object is created and tied to an existing team. Then a
        ''' custom entity and several attributes are created and FieldPermission is 
        ''' assigned to the Identity attribute of the new entity.
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

                    CreateRequiredRecords()

                    ' Create Field Security Profile.
                    Dim managersProfile As New FieldSecurityProfile()
                    managersProfile.Name = "Managers"
                    _profileId = _serviceProxy.Create(managersProfile)
                    Console.Write("Created Profile, ")

                    ' Create the request object and set the monikers with the
                    ' teamprofiles_association relationship.
                    Dim teamToProfile As AssociateRequest = New AssociateRequest With { _
                        .Target = New EntityReference(FieldSecurityProfile.EntityLogicalName, _profileId), _
                        .RelatedEntities = New EntityReferenceCollection From {New EntityReference(Team.EntityLogicalName, _teamId)}, _
                        .Relationship = New Relationship("teamprofiles_association")}

                    ' Execute the request.
                    _serviceProxy.Execute(teamToProfile)


                    ' Create custom activity entity.
                    Dim req As New CreateEntityRequest() With {.Entity = New EntityMetadata With { _
                            .LogicalName = "new_tweet", .DisplayName = New Label("Tweet", 1033), _
                            .DisplayCollectionName = New Label("Tweet", 1033), .OwnershipType = OwnershipTypes.UserOwned, _
                            .SchemaName = "New_Tweet", .IsActivity = True, .IsAvailableOffline = True, _
                            .IsAuditEnabled = New BooleanManagedProperty(True), .IsMailMergeEnabled = New BooleanManagedProperty(False)}, _
                            .HasActivities = False, .HasNotes = True, .PrimaryAttribute = New StringAttributeMetadata() With { _
                                .SchemaName = "Subject", .LogicalName = "subject", _
                                .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None), _
                                .MaxLength = 100, .DisplayName = New Label("Subject", 1033)}}

                    ' Execute the request.
                    _serviceProxy.Execute(req)
                    Console.Write("Entity Created, ")

                    ' Create custom attributes.
                    Dim attrReq As New CreateAttributeRequest() With {.Attribute = New StringAttributeMetadata() With { _
                            .LogicalName = "new_identity", .DisplayName = New Label("Identity", 1033), .SchemaName = "New_Identity", _
                            .MaxLength = 500, .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended), _
                            .IsSecured = True}, .EntityName = "new_tweet"}

                    ' Execute the request.
                    Dim identityAttributeResponse As CreateAttributeResponse = CType(_serviceProxy.Execute(attrReq), CreateAttributeResponse)
                    _identityId = identityAttributeResponse.AttributeId
                    Console.Write("Identity Created, ")

                    attrReq = New CreateAttributeRequest() With {.Attribute = New StringAttributeMetadata() With { _
                            .LogicalName = "new_message", .DisplayName = New Label("Message", 1033), .SchemaName = "New_Message", _
                            .MaxLength = 140, .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended), _
                            .IsSecured = True}, .EntityName = "new_tweet"}

                    ' Execute the request.
                    Dim messageAttributeResponse As CreateAttributeResponse = CType(_serviceProxy.Execute(attrReq), CreateAttributeResponse)
                    _messageId = messageAttributeResponse.AttributeId
                    Console.Write("Message Created, ")

                    ' Create the field permission for the Identity attribute.
                    Dim identityPermission As New FieldPermission() With {.AttributeLogicalName = "new_identity", .EntityName = "new_tweet", _
                        .CanRead = New OptionSetValue(FieldPermissionType.Allowed), _
                        .FieldSecurityProfileId = New EntityReference(FieldSecurityProfile.EntityLogicalName, _profileId)}

                    ' Execute the request
                    _identityPermissionId = _serviceProxy.Create(identityPermission)
                    Console.Write("Permission Created. ")

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
            ' Retrieve the default business unit needed to create the team.
            Dim queryDefaultBusinessUnit As QueryExpression = New QueryExpression With { _
                .EntityName = BusinessUnit.EntityLogicalName, .ColumnSet = New ColumnSet("businessunitid")}
            queryDefaultBusinessUnit.Criteria.AddCondition(New ConditionExpression("parentbusinessunitid", ConditionOperator.Null))

            Dim defaultBusinessUnit As BusinessUnit = CType(_serviceProxy.RetrieveMultiple(queryDefaultBusinessUnit).Entities(0), BusinessUnit)

            ' Instantiate a team entity record and set its property values.
            ' See the Entity Metadata topic in the SDK documentation to determine
            ' which attributes must be set for each entity.
            Dim setupTeam As Team = New Team With { _
                .Name = "ABC Management Team", .BusinessUnitId = New EntityReference(BusinessUnit.EntityLogicalName, defaultBusinessUnit.Id)}

            'Create a team record.
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

                deleteRecords = (answer.StartsWith("y") OrElse answer.StartsWith("Y") OrElse answer = String.Empty)
            End If

            If deleteRecords Then
                _serviceProxy.Delete(FieldSecurityProfile.EntityLogicalName, _profileId)
                _serviceProxy.Delete(Team.EntityLogicalName, _teamId)
                Dim del As New DeleteEntityRequest() With {.LogicalName = "new_tweet"}
                _serviceProxy.Execute(del)
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

                Dim app As New EnableFieldSecurityForAnEntity()
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

' </snippetenablefieldsecurityforanentity>
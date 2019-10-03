' <snippetqueryconnectionrolesbyreciprocalrole>


Imports System.ServiceModel
Imports System.ServiceModel.Description

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Query
Imports Microsoft.Xrm.Sdk.Discovery
Imports Microsoft.Xrm.Sdk.Messages

' This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Crm.Sdk.Messages

Namespace Microsoft.Crm.Sdk.Samples
    ''' <summary>
    ''' This sample shows how to find connection roles by a reciprocal connectionrole.
    ''' </summary>
    Public Class QueryConnectionRolesByReciprocalRole
        #Region "Class Level Members"

        ''' <summary>
        ''' Stores the organization service proxy.
        ''' </summary>
        Private _serviceProxy As OrganizationServiceProxy

        ' Define the IDs needed for this sample.
        Public _primaryConnectionRoleId As Guid
        Public _reciprocalConnectionRoleId As Guid

        #End Region ' Class Level Members

        #Region "How To Sample Code"
        ''' <summary>
        ''' Create and configure the organization service proxy.
        ''' Call the method to create any data that this sample requires.
        ''' Query all connection roles that have this role listed as a reciprocal role.
        ''' Optionally delete any entity records that were created for this sample.
        ''' </summary>
        ''' <param name="serverConfig">Contains server connection information.</param>
        ''' <param name="promptforDelete">When True, the user will be prompted to delete all
        ''' created entities.</param>
        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration, ByVal promptForDelete As Boolean)
            Try
                ' Connect to the Organization service. 
                ' The using statement assures that the service proxy will be properly disposed.
                _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
                Using _serviceProxy
                    ' This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes()

                    ' Call the method to create any data that this sample requires.
                    CreateRequiredRecords()

                    ' This query retrieves all connection roles that have this role
                    ' listed as a reciprocal role.
                    Dim query As QueryExpression = New QueryExpression With { _
                        .EntityName = ConnectionRole.EntityLogicalName, .ColumnSet = New ColumnSet("connectionroleid")}

                    query.AddLink("connectionroleassociation", "connectionroleid", "connectionroleid", JoinOperator.Inner).LinkCriteria = _
                        New FilterExpression()
                    query.LinkEntities(0).LinkCriteria.AddCondition("associatedconnectionroleid", ConditionOperator.Equal, _
                                                                    {_reciprocalConnectionRoleId})
                    query.LinkEntities(0).LinkCriteria.FilterOperator = LogicalOperator.And

                    Dim results As EntityCollection = _serviceProxy.RetrieveMultiple(query)

                    ' TODO: Here you would perform some operation on the retrieved
                    ' roles. 

                    Console.WriteLine("Retrieved {0} connectionrole instance.", results.Entities.Count)

                    DeleteRequiredRecords(promptForDelete)

                End Using
            ' Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            Catch fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                ' You can handle an exception here or pass it back to the calling method.
                Throw
            End Try
        End Sub

        ''' <summary>
        ''' This method creates any entity records that this sample requires.
        ''' Create a primary connection role instance. 
        ''' Create a reciprocal connection role instance.
        ''' Associate the connection roles.
        ''' </summary>
        Public Sub CreateRequiredRecords()
            ' Define some anonymous types to define the range 
            ' of possible connection property values.
            Dim Categories = New With {Key .Business = 1, Key .Family = 2, Key .Social = 3, Key .Sales = 4, Key .Other = 5}

            ' Create the Connection Roles. 
            ' Create the primary connection Role instance.
            Dim setupPrimaryConnectionRole As ConnectionRole = New ConnectionRole With { _
                .Name = "Example Primary Connection Role", .Category = New OptionSetValue(Categories.Business)}

            _primaryConnectionRoleId = _serviceProxy.Create(setupPrimaryConnectionRole)
            Console.WriteLine("Created {0}.", setupPrimaryConnectionRole.Name)

            ' Create a related Connection Role Object Type Code record for Account
            ' on the primary role.
            Dim accountPrimaryConnectionRoleTypeCode As ConnectionRoleObjectTypeCode = _
                New ConnectionRoleObjectTypeCode With {.ConnectionRoleId = _
                    New EntityReference(ConnectionRole.EntityLogicalName, _primaryConnectionRoleId), _
                                                       .AssociatedObjectTypeCode = Account.EntityLogicalName}

            _serviceProxy.Create(accountPrimaryConnectionRoleTypeCode)
            Console.WriteLine("Created a related Connection Role Object Type Code " &amp; _
                              ControlChars.CrLf &amp; "                                record for Account on the primary role.")

            ' Create another Connection Role.
            Dim setupReciprocalConnectionRole As ConnectionRole = _
                New ConnectionRole With {.Name = "Example Reciprocal Connection Role", .Category = _
                    New OptionSetValue(Categories.Business)}

            _reciprocalConnectionRoleId = _serviceProxy.Create(setupReciprocalConnectionRole)
            Console.WriteLine("Created {0}.", setupReciprocalConnectionRole.Name)

            ' Create a related Connection Role Object Type Code record for Account
            ' on the related role.
            Dim accountReciprocalConnectionRoleTypeCode As ConnectionRoleObjectTypeCode = _
                New ConnectionRoleObjectTypeCode With {.ConnectionRoleId = _
                    New EntityReference(ConnectionRole.EntityLogicalName, _reciprocalConnectionRoleId), _
                                                       .AssociatedObjectTypeCode = Account.EntityLogicalName}

            _serviceProxy.Create(accountReciprocalConnectionRoleTypeCode)
            Console.WriteLine("Created a related Connection Role Object Type Code " &amp; _
                              ControlChars.CrLf &amp; "                                record for Account on the related role.")

            ' Associate the connection roles.
            Dim associateConnectionRoles As AssociateRequest = _
                New AssociateRequest With {.Target = New EntityReference(ConnectionRole.EntityLogicalName, _primaryConnectionRoleId), _
                            .RelatedEntities = New EntityReferenceCollection() From _
                            {New EntityReference(ConnectionRole.EntityLogicalName, _reciprocalConnectionRoleId)}, _
                            .Relationship = New Relationship() With _
                            {.PrimaryEntityRole = EntityRole.Referencing, .SchemaName = "connectionroleassociation_association"}}
                    ' The name of the relationship connection role association 
                    ' relationship in MS CRM

            _serviceProxy.Execute(associateConnectionRoles)

            Return
        End Sub

        ''' <summary>
        ''' Deletes any entity records that were created for this sample.
        ''' <param name="prompt">Indicates whether to prompt the user 
        ''' to delete the records created in this sample.</param>
        ''' </summary>
        Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
            Dim deleteRecords As Boolean = True

            If prompt Then
                Console.WriteLine(vbLf &amp; "Do you want these entity records deleted? (y/n)")
                Dim answer As String = Console.ReadLine()

                deleteRecords = (answer.StartsWith("y") OrElse answer.StartsWith("Y"))
            End If

            If deleteRecords Then
                _serviceProxy.Delete(ConnectionRole.EntityLogicalName, _primaryConnectionRoleId)
                _serviceProxy.Delete(ConnectionRole.EntityLogicalName, _reciprocalConnectionRoleId)

                Console.WriteLine("Entity records have been deleted.")
            End If
        End Sub

        #End Region ' How To Sample Code

        #Region "Main"
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

                Dim app As New QueryConnectionRolesByReciprocalRole()
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
        #End Region ' Main
    End Class
End Namespace

' </snippetqueryconnectionrolesbyreciprocalrole>
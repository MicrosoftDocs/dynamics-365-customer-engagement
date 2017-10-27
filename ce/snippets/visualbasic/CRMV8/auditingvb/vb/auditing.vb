' <snippetauditing>


Imports Microsoft.VisualBasic
Imports System
Imports System.ServiceModel
Imports System.Collections.Generic
Imports System.Linq

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Query
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Messages
Imports Microsoft.Xrm.Sdk.Metadata

' These namespaces are found in the Microsoft.Crm.Sdk.Proxy.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Crm.Sdk.Messages

Namespace Microsoft.Crm.Sdk.Samples
    Public Class Auditing

#Region "Class Level Members"

        Private _serviceProxy As OrganizationServiceProxy
        Private _service As IOrganizationService

        Private _newAccountId As Guid

#End Region ' Class Level Members

        ''' <summary>
        ''' This method first connects to the organization service. Next, auditing 
        ''' is enabled on the organization and an account entity. The account record
        ''' is updated and the audit history printed out.
        ''' </summary>
        ''' <param name="serverConfig">Contains server connection information.</param>
        ''' <param name="promptforDelete">When True, the user will be prompted to delete all
        ''' created entities.</param>
        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration, ByVal promptforDelete As Boolean)
            _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)

            Using _serviceProxy
                ' Enable early-bound type support.
                _serviceProxy.EnableProxyTypes()

                ' You can access the service through the proxy, but this sample uses the interface instead.
                _service = _serviceProxy

                '#Region "Enable Auditing for an Account"
                Console.WriteLine("Enabling auditing on the organization and account entities.")

                ' Enable auditing on the organization.
                ' First, get the organization's ID from the system user record.
                Dim orgId As Guid = (CType(_service.Execute(New WhoAmIRequest()), WhoAmIResponse)).OrganizationId

                ' Next, retrieve the organization's record.
                Dim org As Organization = TryCast(_service.Retrieve(Organization.EntityLogicalName, orgId, New ColumnSet(New String() {"organizationid", "isauditenabled"})), Organization)

                ' Finally, enable auditing on the organization.
                Dim organizationAuditingFlag As Boolean = org.IsAuditEnabled.Value
                org.IsAuditEnabled = True
                _service.Update(org)

                ' Enable auditing on account entities.
                Dim accountAuditingFlag As Boolean = EnableEntityAuditing(Account.EntityLogicalName, True)
                '#End Region ' Enable Auditing for an Account

                CreateRequiredRecords()

                '#Region "Retrieve the Record Change History"
                Console.WriteLine("Retrieving the account change history." &amp; vbLf)

                ' Retrieve the audit history for the account and display it.
                Dim changeRequest As New RetrieveRecordChangeHistoryRequest()
                changeRequest.Target = New EntityReference(Account.EntityLogicalName, _newAccountId)

                Dim changeResponse As RetrieveRecordChangeHistoryResponse = CType(_service.Execute(changeRequest), RetrieveRecordChangeHistoryResponse)

                Dim details As AuditDetailCollection = changeResponse.AuditDetailCollection

                For Each detail As AttributeAuditDetail In details.AuditDetails
                    ' Display some of the detail information in each audit record. 
                    DisplayAuditDetails(detail)
                Next detail
                '#End Region ' Retrieve the Record Change History

                '#Region "Retrieve the Attribute Change History"

                ' Update the Telephone1 attribute in the Account entity record.
                Dim accountToUpdate As New Account()
                accountToUpdate.AccountId = _newAccountId
                accountToUpdate.Telephone1 = "123-555-5555"
                _serviceProxy.Update(accountToUpdate)
                Console.WriteLine("Updated the Telephone1 field in the Account entity.")

                ' Retrieve the attribute change history.
                Console.WriteLine("Retrieving the attribute change history for Telephone1.")

                Dim attributeChangeHistoryRequest = New RetrieveAttributeChangeHistoryRequest With {.Target = New EntityReference(Account.EntityLogicalName, _newAccountId), .AttributeLogicalName = "telephone1"}

                Dim attributeChangeHistoryResponse = CType(_service.Execute(attributeChangeHistoryRequest), RetrieveAttributeChangeHistoryResponse)

                ' Display the attribute change history.
                details = attributeChangeHistoryResponse.AuditDetailCollection

                For Each detail In details.AuditDetails
                    DisplayAuditDetails(detail)
                Next detail

                ' Save an Audit record ID for later use.
                Dim auditSampleId As Guid = details.AuditDetails.First().AuditRecord.Id
                '#End Region ' Retrieve the Attribute Change History

                '#Region "Retrieve the Audit Details"
                Console.WriteLine("Retrieving audit details for an audit record.")

                ' Retrieve the audit details and display them.
                Dim auditDetailsRequest = New RetrieveAuditDetailsRequest With {.AuditId = auditSampleId}

                Dim auditDetailsResponse = CType(_service.Execute(auditDetailsRequest), RetrieveAuditDetailsResponse)
                DisplayAuditDetails(auditDetailsResponse.AuditDetail)

                '#End Region ' Retrieve the Audit Details

                '#Region "Revert Auditing"
                ' Set the organization and account auditing flags back to the old values
                org.IsAuditEnabled = organizationAuditingFlag
                _service.Update(org)

                EnableEntityAuditing(Account.EntityLogicalName, accountAuditingFlag)

                '#End Region ' Revert Auditing

                DeleteRequiredRecords(promptforDelete)
            End Using
        End Sub

#Region "Class methods"
        ''' <summary>
        ''' Displays audit change history details on the console.
        ''' </summary>
        ''' <param name="detail"></param>
        Private Shared Sub DisplayAuditDetails(ByVal detail As AuditDetail)
            ' Write out some of the change history information in the audit record. 
            Dim record As Audit = CType(detail.AuditRecord, Audit)

            Console.WriteLine(vbLf &amp; "Audit record created on: {0}", record.CreatedOn.Value.ToLocalTime())
            Console.WriteLine("Entity: {0}, Action: {1}, Operation: {2}", record.ObjectId.LogicalName, record.FormattedValues("action"), record.FormattedValues("operation"))

            ' Show additional details for certain AuditDetail sub-types.
            Dim detailType = detail.GetType()
            If detailType Is GetType(AttributeAuditDetail) Then
                Dim attributeDetail = CType(detail, AttributeAuditDetail)

                ' Display the old and new attribute values.
                For Each attribute As KeyValuePair(Of String, Object) In attributeDetail.NewValue.Attributes
                    Dim oldValue As String = "(no value)", newValue As String = "(no value)"

                    'TODO Display the lookup values of those attributes that do not contain strings.
                    If attributeDetail.OldValue.Contains(attribute.Key) Then
                        oldValue = attributeDetail.OldValue(attribute.Key).ToString()
                    End If

                    newValue = attributeDetail.NewValue(attribute.Key).ToString()

                    Console.WriteLine("Attribute: {0}, old value: {1}, new value: {2}", attribute.Key, oldValue, newValue)
                Next attribute

                For Each attribute As KeyValuePair(Of String, Object) In attributeDetail.OldValue.Attributes
                    If Not attributeDetail.NewValue.Contains(attribute.Key) Then
                        Dim newValue As String = "(no value)"

                        'TODO Display the lookup values of those attributes that do not contain strings.
                        Dim oldValue As String = attributeDetail.OldValue(attribute.Key).ToString()

                        Console.WriteLine("Attribute: {0}, old value: {1}, new value: {2}", attribute.Key, oldValue, newValue)
                    End If
                Next attribute
            End If
            Console.WriteLine()
        End Sub

        ''' <summary>
        ''' Enable auditing on an entity.
        ''' </summary>
        ''' <param name="entityLogicalName">The logical name of the entity.</param>
        ''' <param name="flag">True to enable auditing, otherwise false.</param>
        ''' <returns>The previous value of the IsAuditEnabled attribute.</returns>
        Private Function EnableEntityAuditing(ByVal entityLogicalName As String, ByVal flag As Boolean) As Boolean
            ' Retrieve the entity metadata.
            Dim entityRequest As RetrieveEntityRequest = New RetrieveEntityRequest With {.LogicalName = entityLogicalName, .EntityFilters = EntityFilters.Attributes}

            Dim entityResponse As RetrieveEntityResponse = CType(_service.Execute(entityRequest), RetrieveEntityResponse)

            ' Enable auditing on the entity. By default, this also enables auditing
            ' on all the entity's attributes.
            Dim entityMetadata As EntityMetadata = entityResponse.EntityMetadata

            Dim oldValue As Boolean = entityMetadata.IsAuditEnabled.Value
            entityMetadata.IsAuditEnabled = New BooleanManagedProperty(flag)

            Dim updateEntityRequest As UpdateEntityRequest = New UpdateEntityRequest With {.Entity = entityMetadata}

            Dim updateEntityResponse As UpdateEntityResponse = CType(_service.Execute(updateEntityRequest), UpdateEntityResponse)

            Return oldValue
        End Function

        ''' <summary>
        ''' Creates any entity records that this sample requires.
        ''' </summary>
        Public Sub CreateRequiredRecords()
            Console.Write("Creating an account, ")

            ' Account entity category codes.
            Dim Categories = New With {Key .PreferredCustomer = 1, Key .Standard = 2}

            ' Create a new account entity. 
            Dim newAccount As Account = New Account With {.Name = "Example Account"}
            _newAccountId = _service.Create(newAccount)

            Console.WriteLine("then updating the account.")

            ' Set the values of some other attributes.
            newAccount.AccountId = _newAccountId
            newAccount.AccountNumber = "1-A"
            newAccount.AccountCategoryCode = New OptionSetValue(Categories.PreferredCustomer)
            newAccount.Telephone1 = "555-555-5555"

            _service.Update(newAccount)
        End Sub

        ''' <summary>
        ''' Deletes any entity records that were created for this sample.
        ''' <param name="prompt">Indicates whether to prompt the user 
        ''' to delete the records created in this sample.</param>
        ''' </summary>
        Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
            Dim deleteRecords As Boolean = True

            If prompt Then
                Console.WriteLine(vbLf &amp; "Do you want to delete the account record? (y/n) [y]: ")
                Dim answer As String = Console.ReadLine()

                deleteRecords = (answer.StartsWith("y") OrElse answer.StartsWith("Y") OrElse answer = String.Empty)
            End If

            If deleteRecords Then
                _service.Delete(Account.EntityLogicalName, _newAccountId)
                Console.WriteLine("The account record has been deleted.")
            End If

            If prompt Then
                Console.WriteLine(vbLf &amp; "Do you want to delete ALL audit records? (y/n) [n]: ")
                Dim answer As String = Console.ReadLine()

                deleteRecords = (answer.StartsWith("y") OrElse answer.StartsWith("Y"))
            End If

            If deleteRecords Then
                ' Get the list of audit partitions.
                Dim partitionRequest As RetrieveAuditPartitionListResponse = CType(_service.Execute(New RetrieveAuditPartitionListRequest()), RetrieveAuditPartitionListResponse)
                Dim partitions As AuditPartitionDetailCollection = partitionRequest.AuditPartitionDetailCollection

                ' Create a delete request with an end date earlier than possible.
                Dim deleteRequest As New DeleteAuditDataRequest()
                deleteRequest.EndDate = New Date(2000, 1, 1)

                ' Check if partitions are not supported as is the case with SQL Server Standard edition.
                If partitions.IsLogicalCollection Then
                    ' Delete all audit records created up until now.
                    deleteRequest.EndDate = Date.Now

                    ' Otherwise, delete all partitions that are older than the current partition.
                    ' Hint: The partitions in the collection are returned in sorted order where the 
                    ' partition with the oldest end date is at index 0.
                Else
                    For n As Integer = partitions.Count - 1 To 0 Step -1
                        If partitions(n).EndDate <= Date.Now AndAlso partitions(n).EndDate > deleteRequest.EndDate Then
                            deleteRequest.EndDate = CDate(partitions(n).EndDate)
                            Exit For
                        End If
                    Next n
                End If

                ' Delete the audit records.
                If deleteRequest.EndDate <> New Date(2000, 1, 1) Then
                    _service.Execute(deleteRequest)
                    Console.WriteLine("Audit records have been deleted.")
                Else
                    Console.WriteLine("There were no audit records that could be deleted.")
                End If
            End If
        End Sub
#End Region ' Class methods

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

                Dim app As New Auditing()
                app.Run(config, True)

            Catch ex As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                Console.WriteLine("The application terminated with an error.")
                Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp)
                Console.WriteLine("Code: {0}", ex.Detail.ErrorCode)
                Console.WriteLine("Message: {0}", ex.Detail.Message)
                Console.WriteLine("Trace: {0}", ex.Detail.TraceText)
                Console.WriteLine("Inner Fault: {0}", If(Nothing Is ex.Detail.InnerFault, "No Inner Fault", "Has Inner Fault"))
            Catch ex As System.TimeoutException
                Console.WriteLine("The application terminated with an error.")
                Console.WriteLine("Message: {0}", ex.Message)
                Console.WriteLine("Stack Trace: {0}", ex.StackTrace)
                Console.WriteLine("Inner Fault: {0}", If(Nothing Is ex.InnerException.Message, "No Inner Fault", ex.InnerException.Message))
            Catch ex As System.Exception
                Console.WriteLine("The application terminated with an error.")
                Console.WriteLine(ex.Message)

                ' Display the details of the inner exception.
                If ex.InnerException IsNot Nothing Then
                    Console.WriteLine(ex.InnerException.Message)

                    Dim fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault) = TryCast(ex.InnerException, FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault))
                    If fe IsNot Nothing Then
                        Console.WriteLine("Timestamp: {0}", fe.Detail.Timestamp)
                        Console.WriteLine("Code: {0}", fe.Detail.ErrorCode)
                        Console.WriteLine("Message: {0}", fe.Detail.Message)
                        Console.WriteLine("Trace: {0}", fe.Detail.TraceText)
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

' </snippetauditing>
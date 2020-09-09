' <snippetcreateupdateentitymetadata>


Imports System.ServiceModel
Imports System.ServiceModel.Description

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Query
Imports Microsoft.Xrm.Sdk.Discovery
Imports Microsoft.Xrm.Sdk.Messages
Imports Microsoft.Xrm.Sdk.Metadata

' This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Crm.Sdk.Messages

Namespace Microsoft.Crm.Sdk.Samples
 Public Class CreateUpdateEntityMetadata
#Region "Class Level Members"
  ''' <summary>
  ''' Stores the organization service proxy.
  ''' </summary>
  Private _serviceProxy As OrganizationServiceProxy

  Private Const _customEntityName As String = "new_bankaccount"

#End Region ' Class Level Members

#Region "How To Sample Code"
  ''' <summary>
  ''' Create a custom entity.
  ''' Update the custom entity.
  ''' Optionally delete the custom entity.
  ''' </summary>
  ''' <param name="serverConfig">Contains server connection information.</param>
  ''' <param name="promptForDelete">When True, the user will be prompted to delete all
  ''' created entities.</param>
  Public Sub Run(ByVal serverConfig As ServerConnection.Configuration, ByVal promptForDelete As Boolean)
   Try

    ' Connect to the Organization service. 
    ' The using statement assures that the service proxy will be properly disposed.
    _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
    Using _serviceProxy
     ' This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes()


     ' Create the custom entity.
     Dim createrequest As CreateEntityRequest = New CreateEntityRequest With {
      .Entity = New EntityMetadata With {
       .SchemaName = _customEntityName,
       .DisplayName = New Label("Bank Account", 1033),
       .DisplayCollectionName = New Label("Bank Accounts", 1033),
       .Description = New Label("An entity to store information about customer bank accounts", 1033),
       .OwnershipType = OwnershipTypes.UserOwned,
       .IsActivity = False},
      .PrimaryAttribute = New StringAttributeMetadata With {
       .SchemaName = "new_accountname",
       .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
       .MaxLength = 100,
       .Format = StringFormat.Text,
       .DisplayName = New Label("Account Name", 1033),
       .Description = New Label("The primary attribute for the Bank Account entity.", 1033)
      }
     }
     'Define the entity
     ' Define the primary attribute for the entity
     _serviceProxy.Execute(createrequest)
     Console.WriteLine("The bank account entity has been created.")


     ' Add some attributes to the Bank Account entity
     Dim createBankNameAttributeRequest As CreateAttributeRequest = New CreateAttributeRequest With {
      .EntityName = _customEntityName,
      .Attribute = New StringAttributeMetadata With {
       .SchemaName = "new_bankname",
       .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
       .MaxLength = 100,
       .Format = StringFormat.Text,
       .DisplayName = New Label("Bank Name", 1033),
       .Description = New Label("The name of the bank.", 1033)
      }
     }

     _serviceProxy.Execute(createBankNameAttributeRequest)
     Console.WriteLine("An bank name attribute has been added to the bank account entity.")

     Dim createBalanceAttributeRequest As CreateAttributeRequest = New CreateAttributeRequest With {
      .EntityName = _customEntityName,
      .Attribute = New MoneyAttributeMetadata With {
       .SchemaName = "new_balance",
       .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
       .PrecisionSource = 2,
       .DisplayName = New Label("Balance", 1033),
       .Description = New Label("Account Balance at the last known date", 1033)
      }
     }

     _serviceProxy.Execute(createBalanceAttributeRequest)
     Console.WriteLine("An account balance attribute has been added to the bank account entity.")

     Dim createCheckedDateRequest As CreateAttributeRequest = New CreateAttributeRequest With {
      .EntityName = _customEntityName,
      .Attribute = New DateTimeAttributeMetadata With {
       .SchemaName = "new_checkeddate",
       .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
       .Format = DateTimeFormat.DateOnly,
       .DisplayName = New Label("Date", 1033),
       .Description = New Label("The date the account balance was last confirmed", 1033)
      }
     }

     _serviceProxy.Execute(createCheckedDateRequest)
     Console.WriteLine("An date attribute has been added to the bank account entity.")
     'Create a lookup attribute to link the bank account with a contact record.

     Dim req As New CreateOneToManyRequest() With {
      .Lookup = New LookupAttributeMetadata() With {
       .Description = New Label("The owner of the bank account", 1033),
       .DisplayName = New Label("Account Owner", 1033),
       .LogicalName = "new_parent_contactid",
       .SchemaName = "New_Parent_ContactId",
       .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.ApplicationRequired)},
      .OneToManyRelationship = New OneToManyRelationshipMetadata() With {
       .AssociatedMenuConfiguration = New AssociatedMenuConfiguration() With {
        .Behavior = AssociatedMenuBehavior.UseCollectionName,
        .Group = AssociatedMenuGroup.Details,
        .Label = New Label("Bank Accounts", 1033),
        .Order = 10000},
       .CascadeConfiguration = New CascadeConfiguration() With {
        .Assign = CascadeType.Cascade,
        .Delete = CascadeType.Cascade,
        .Merge = CascadeType.Cascade,
        .Reparent = CascadeType.Cascade,
        .Share = CascadeType.Cascade,
        .Unshare = CascadeType.Cascade},
       .ReferencedEntity = Contact.EntityLogicalName,
       .ReferencedAttribute = "contactid",
       .ReferencingEntity = _customEntityName,
       .SchemaName = "new_contact_new_bankaccount"
      }
     }
     _serviceProxy.Execute(req)
     Console.WriteLine("A lookup attribute has been added to the bank account entity to link it with the Contact entity.")




     Dim retrieveBankAccountEntityRequest As RetrieveEntityRequest = New RetrieveEntityRequest With {
      .EntityFilters = EntityFilters.Entity,
      .LogicalName = _customEntityName
     }
     Dim retrieveBankAccountEntityResponse As RetrieveEntityResponse = CType(_serviceProxy.Execute(retrieveBankAccountEntityRequest), RetrieveEntityResponse)
     Dim BankAccountEntity As EntityMetadata = retrieveBankAccountEntityResponse.EntityMetadata

     ' Disable Mail merge
     BankAccountEntity.IsMailMergeEnabled = New BooleanManagedProperty(False)
     ' Enable Notes
     Dim updateBankAccountRequest As UpdateEntityRequest = New UpdateEntityRequest With {
      .Entity = BankAccountEntity,
      .HasNotes = True
     }
     _serviceProxy.Execute(updateBankAccountRequest)

     Console.WriteLine("The bank account entity has been updated")

     ' Customizations must be published after an entity is updated.
     Dim publishRequest As New PublishAllXmlRequest()
     _serviceProxy.Execute(publishRequest)
     Console.WriteLine("Customizations were published.")

     DeleteRequiredRecords(promptForDelete)
    End Using

    ' Catch any service fault exceptions that Microsoft Dynamics CRM throws.
   Catch fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
    ' You can handle an exception here or pass it back to the calling method.
    Throw
   End Try
  End Sub

  ''' <summary>
  ''' Deletes the custom entity that was created for this sample.
  ''' <param name="prompt">Indicates whether to prompt the user to delete the records created in this sample.</param>
  ''' </summary>
  Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
   Dim deleteEntity As Boolean = True

   If prompt Then
    Console.WriteLine(vbLf &amp; "Do you want this custom entity deleted? (y/n)")
    Dim answer As String = Console.ReadLine()

    deleteEntity = (answer.StartsWith("y") OrElse answer.StartsWith("Y"))
   End If

   If deleteEntity Then
    Dim request As New DeleteEntityRequest() With {.LogicalName = _customEntityName}
    _serviceProxy.Execute(request)
    Console.WriteLine("The records have been deleted.")
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

    Dim app As New CreateUpdateEntityMetadata()
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

     Dim fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault) = TryCast(ex.InnerException, FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault))
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

' </snippetcreateupdateentitymetadata>
' <snippetworkwithrelationships>


Imports System.ServiceModel
Imports System.ServiceModel.Description

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Query
Imports Microsoft.Xrm.Sdk.Metadata
Imports Microsoft.Xrm.Sdk.Messages

' This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Crm.Sdk.Messages

Namespace Microsoft.Crm.Sdk.Samples
 ''' <summary>
 ''' This sample shows how to create one to many, many to many relationship.
 ''' </summary>
 Public Class WorkWithRelationships
#Region "Class Level Members"

  ''' <summary>
  ''' Stores the organization service proxy.
  ''' </summary>
  Private _serviceProxy As OrganizationServiceProxy

  ' Define the IDs needed for this sample.
  Private _oneToManyRelationshipId As Guid
  Private _oneToManyRelationshipName As String

  Private _manyToManyRelationshipId As Guid
  Private _manyToManyRelationshipName As String

#End Region ' Class Level Members

#Region "How To Sample Code"
  ''' <summary>
  ''' Create and configure the organization service proxy.
  ''' Create one-to-many relationship.
  ''' Create many-to-many relationship.
  ''' Optionally delete any entity records that were created for this sample.
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


     Dim eligibleCreateOneToManyRelationship As Boolean =
      Me.EligibleCreateOneToManyRelationship("account", "campaign")

     If eligibleCreateOneToManyRelationship Then
      Dim createOneToManyRelationshipRequest As CreateOneToManyRequest =
       New CreateOneToManyRequest With {
        .OneToManyRelationship = New OneToManyRelationshipMetadata With {
         .ReferencedEntity = "account",
         .ReferencingEntity = "campaign",
         .SchemaName = "new_account_campaign",
         .AssociatedMenuConfiguration =
         New AssociatedMenuConfiguration With {
          .Behavior = AssociatedMenuBehavior.UseLabel,
          .Group = AssociatedMenuGroup.Details,
          .Label = New Label("Account", 1033),
          .Order = 10000},
         .CascadeConfiguration =
         New CascadeConfiguration With {
          .Assign = CascadeType.Cascade,
          .Delete = CascadeType.Cascade,
          .Merge = CascadeType.Cascade,
          .Reparent = CascadeType.Cascade,
          .Share = CascadeType.Cascade,
          .Unshare = CascadeType.Cascade
         }
        },
        .Lookup = New LookupAttributeMetadata With {
         .SchemaName = "new_parent_accountid",
         .DisplayName = New Label("Account Lookup", 1033),
         .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
         .Description = New Label("Sample Lookup", 1033)
        }
       }


      Dim createOneToManyRelationshipResponse As CreateOneToManyResponse =
       CType(_serviceProxy.Execute(createOneToManyRelationshipRequest), CreateOneToManyResponse)

      _oneToManyRelationshipId = createOneToManyRelationshipResponse.RelationshipId
      _oneToManyRelationshipName = createOneToManyRelationshipRequest.OneToManyRelationship.SchemaName

      Console.WriteLine("The one-to-many relationship has been created between {0} and {1}.", "account", "campaign")
     End If



     Dim accountEligibleParticipate As Boolean = EligibleCreateManyToManyRelationship("account")
     Dim campaignEligibleParticipate As Boolean = EligibleCreateManyToManyRelationship("campaign")

     If accountEligibleParticipate AndAlso campaignEligibleParticipate Then

      Dim createManyToManyRelationshipRequest As CreateManyToManyRequest =
       New CreateManyToManyRequest With {
        .IntersectEntitySchemaName = "new_accounts_campaigns",
        .ManyToManyRelationship = New ManyToManyRelationshipMetadata With {
         .SchemaName = "new_accounts_campaigns",
         .Entity1LogicalName = "account",
         .Entity1AssociatedMenuConfiguration =
         New AssociatedMenuConfiguration With {
          .Behavior = AssociatedMenuBehavior.UseLabel,
          .Group = AssociatedMenuGroup.Details,
          .Label = New Label("Account", 1033),
          .Order = 10000
         },
         .Entity2LogicalName = "campaign",
         .Entity2AssociatedMenuConfiguration =
         New AssociatedMenuConfiguration With {
          .Behavior = AssociatedMenuBehavior.UseLabel,
          .Group = AssociatedMenuGroup.Details,
          .Label = New Label("Campaign", 1033),
          .Order = 10000
         }
        }
       }

      Dim createManytoManyRelationshipResponse As CreateManyToManyResponse =
       CType(_serviceProxy.Execute(createManyToManyRelationshipRequest), CreateManyToManyResponse)


      _manyToManyRelationshipId = createManytoManyRelationshipResponse.ManyToManyRelationshipId
      _manyToManyRelationshipName = createManyToManyRelationshipRequest.ManyToManyRelationship.SchemaName

      Console.WriteLine("The many-to-many relationship has been created between {0} and {1}.", "account", "campaign")
     End If


     ' Publish the customization changes.
     _serviceProxy.Execute(New PublishAllXmlRequest())



     'You can use either the Name or the MetadataId of the relationship.

     'Retrieve the One-to-many relationship using the MetadataId.
     Dim retrieveOneToManyRequest As RetrieveRelationshipRequest =
      New RetrieveRelationshipRequest With {.MetadataId = _oneToManyRelationshipId}
     Dim retrieveOneToManyResponse As RetrieveRelationshipResponse =
      CType(_serviceProxy.Execute(retrieveOneToManyRequest), RetrieveRelationshipResponse)

     Console.WriteLine("Retrieved {0} One-to-many relationship by id",
                       retrieveOneToManyResponse.RelationshipMetadata.SchemaName)

     'Retrieve the Many-to-many relationship using the Name.
     Dim retrieveManyToManyRequest As RetrieveRelationshipRequest =
      New RetrieveRelationshipRequest With {
       .Name = _manyToManyRelationshipName
      }
     Dim retrieveManyToManyResponse As RetrieveRelationshipResponse =
      CType(_serviceProxy.Execute(retrieveManyToManyRequest), RetrieveRelationshipResponse)

     Console.WriteLine("Retrieved {0} Many-to-Many relationship by Name",
                       retrieveManyToManyResponse.RelationshipMetadata.MetadataId)


     DeleteRequiredRecords(promptForDelete)


    End Using

    ' Catch any service fault exceptions that Microsoft Dynamics CRM throws.
   Catch fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
    ' You can handle an exception here or pass it back to the calling method.
    Throw
   End Try
  End Sub

  ''' <summary>
  ''' Determines whether the entity can participate in a many-to-many relationship.
  ''' </summary>
  ''' <param name="entity">Entity</param>
  ''' <returns></returns>
  Public Function EligibleCreateManyToManyRelationship(ByVal entity As String) As Boolean
   Dim canManyToManyRequest As CanManyToManyRequest =
    New CanManyToManyRequest With {.EntityName = entity}

   Dim canManyToManyResponse As CanManyToManyResponse =
    CType(_serviceProxy.Execute(canManyToManyRequest), CanManyToManyResponse)

   If Not canManyToManyResponse.CanManyToMany Then
    Console.WriteLine("Entity {0} can't participate in a many-to-many relationship.", entity)
   End If

   Return canManyToManyResponse.CanManyToMany
  End Function
  ''' <summary>
  ''' Determines whether two entities are eligible to participate in a relationship
  ''' </summary>
  ''' <param name="referencedEntity">Primary Entity</param>
  ''' <param name="referencingEntity">Referencing Entity</param>
  ''' <returns></returns>
  Public Function EligibleCreateOneToManyRelationship(ByVal referencedEntity As String, ByVal referencingEntity As String) As Boolean
   'Checks whether the specified entity can be the primary entity in one-to-many
   'relationship.
   Dim canBeReferencedRequest As CanBeReferencedRequest =
    New CanBeReferencedRequest With {.EntityName = referencedEntity}

   Dim canBeReferencedResponse As CanBeReferencedResponse =
    CType(_serviceProxy.Execute(canBeReferencedRequest), CanBeReferencedResponse)

   If Not canBeReferencedResponse.CanBeReferenced Then
    Console.WriteLine("Entity {0} can't be the primary entity in this one-to-many relationship", referencedEntity)
   End If

   'Checks whether the specified entity can be the referencing entity in one-to-many
   'relationship.
   Dim canBereferencingRequest As CanBeReferencingRequest =
    New CanBeReferencingRequest With {.EntityName = referencingEntity}

   Dim canBeReferencingResponse As CanBeReferencingResponse =
    CType(_serviceProxy.Execute(canBereferencingRequest), CanBeReferencingResponse)

   If Not canBeReferencingResponse.CanBeReferencing Then
    Console.WriteLine("Entity {0} can't be the referencing entity in this one-to-many relationship", referencingEntity)
   End If


   If canBeReferencedResponse.CanBeReferenced = True AndAlso canBeReferencingResponse.CanBeReferencing = True Then
    Return True
   Else
    Return False
   End If
  End Function
  ''' <summary>
  ''' Deletes the relationships that was created for this sample.
  ''' <param name="prompt">Indicates whether to prompt the user to delete 
  ''' the records created in this sample.</param>
  ''' </summary>
  Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
   Dim deleteRecords As Boolean = True

   If prompt Then
    Console.WriteLine(vbLf &amp; "Do you want these entity relationships to be deleted? (y/n)")
    Dim answer As String = Console.ReadLine()

    deleteRecords = (answer.StartsWith("y") OrElse answer.StartsWith("Y"))
   End If

   If deleteRecords Then
    Dim deleteOneToManyRelationshipRequest As DeleteRelationshipRequest =
     New DeleteRelationshipRequest With {
      .Name = "new_account_campaign"
     }

    _serviceProxy.Execute(deleteOneToManyRelationshipRequest)

    Dim deleteManyToManyRelationshipRequest As DeleteRelationshipRequest =
     New DeleteRelationshipRequest With {
      .Name = "new_accounts_campaigns"
     }

    _serviceProxy.Execute(deleteManyToManyRelationshipRequest)

    Console.WriteLine("Entity Relationships have been deleted.")
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

    Dim app As New WorkWithRelationships()
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

     Dim fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault) =
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

' </snippetworkwithrelationships>
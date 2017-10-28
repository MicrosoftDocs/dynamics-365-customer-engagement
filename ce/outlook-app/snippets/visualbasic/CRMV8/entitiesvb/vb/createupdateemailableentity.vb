' <snippetcreateupdateemailableentity>


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
 Public Class CreateUpdateEmailableEntity
#Region "Class Level Members"
  ''' <summary>
  ''' Stores the organization service proxy.
  ''' </summary>
  Private _serviceProxy As OrganizationServiceProxy

  Private Const _customEntityName As String = "new_agent"

#End Region ' Class Level Members

#Region "How To Sample Code"
  ''' <summary>
  ''' Create a custom entity that can be used in the To field of an email activity.
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
     Dim createrequest As CreateEntityRequest = New CreateEntityRequest With {.Entity = New EntityMetadata With {
       .SchemaName = _customEntityName,
       .DisplayName = New Label("Agent", 1033),
       .DisplayCollectionName = New Label("Agents", 1033),
       .Description = New Label("Insurance Agents", 1033),
       .OwnershipType = OwnershipTypes.UserOwned,
       .IsActivity = False, .IsActivityParty = True},
       .PrimaryAttribute = New StringAttributeMetadata With {
        .SchemaName = "new_fullname",
        .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
        .MaxLength = 100,
        .Format = StringFormat.Text,
        .DisplayName = New Label("Agent Name", 1033),
        .Description = New Label("Agent Name", 1033)
        }
       }
     ' Define an entity to enable for emailing. In order to do so,
     ' IsActivityParty must be set.
     ' Unless this flag is set, this entity cannot be party to an
     ' activity.
     ' As with built-in emailable entities, the Primary Attribute will
     ' be used in the activity party screens. Be sure to choose descriptive
     ' attributes.

     _serviceProxy.Execute(createrequest)
     Console.WriteLine("The emailable entity has been created.")

     ' The entity will not be selectable as an activity party until its customizations
     ' have been published. Otherwise, the e-mail activity dialog cannot find
     ' a correct default view.
     Dim publishRequest As New PublishAllXmlRequest()
     _serviceProxy.Execute(publishRequest)

     ' Before any emails can be created for this entity, an Email attribute
     ' must be defined.
     Dim createFirstEmailAttributeRequest As CreateAttributeRequest = New CreateAttributeRequest With {
      .EntityName = _customEntityName,
      .Attribute = New StringAttributeMetadata With {
       .SchemaName = "new_emailaddress",
       .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
       .MaxLength = 100,
       .Format = StringFormat.Email,
       .DisplayName = New Label("Email Address", 1033),
       .Description = New Label("Email Address", 1033)
      }
     }

     _serviceProxy.Execute(createFirstEmailAttributeRequest)
     Console.WriteLine("An email attribute has been added to the emailable entity.")

     ' Create a second, alternate email address. Since there is already one 
     ' email attribute on the entity, this will never be used for emailing
     ' even if the first one is not populated.
     Dim createSecondEmailAttributeRequest As CreateAttributeRequest = New CreateAttributeRequest With {
      .EntityName = _customEntityName,
      .Attribute = New StringAttributeMetadata With {
       .SchemaName = "new_secondaryaddress",
       .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
       .MaxLength = 100,
       .Format = StringFormat.Email,
       .DisplayName = New Label("Secondary Email Address", 1033),
       .Description = New Label("Secondary Email Address", 1033)
      }
     }

     _serviceProxy.Execute(createSecondEmailAttributeRequest)

     Console.WriteLine("A second email attribute has been added to the emailable entity.")

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

    Dim app As New CreateUpdateEmailableEntity()
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

' </snippetcreateupdateemailableentity>
' <snippetenabledocumentmanagement>


Imports System.ServiceModel
Imports System.ServiceModel.Description

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Query
Imports Microsoft.Xrm.Sdk.Messages
Imports Microsoft.Xrm.Sdk.Metadata

' This namespace is found in the Microsoft.Crm.Sdk.Proxy.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Crm.Sdk.Messages

Namespace Microsoft.Crm.Sdk.Samples
 ''' <summary>
 ''' Demonstrates how to enable document management
 ''' for an entity.</summary>
 ''' <remarks>
 ''' At run-time, you will be given the option to revert
 ''' the changes done by this program.</remarks>
 Public Class EnableDocumentManagement
#Region "Class Level Members"

  Private _serviceProxy As OrganizationServiceProxy

#End Region ' Class Level Members

#Region "How-To Sample Code"
  ''' <summary>
  ''' This method first connects to the Organization service. Afterwards,
  ''' retrieves the Contact entity record, and then enables the document management 
  ''' for the entity.
  ''' </summary>
  ''' <param name="serverConfig">Contains server connection information.</param>
  ''' <param name="promptforRevert">When True, the user will be prompted to revert all
  ''' the changes done in this sample.</param>
  Public Sub Run(ByVal serverConfig As ServerConnection.Configuration,
                 ByVal promptforRevert As Boolean)
   Try

    ' Connect to the Organization service. 
    ' The using statement assures that the service proxy will be properly disposed.
    _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
    Using _serviceProxy
     ' This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes()

     CreateRequiredRecords()

     ' Retrieve an entity for which you want to enable document management.
     ' In this sample, we will retrieve and enable document management
     ' for the Contact entity because by default, document management is
     ' not enabled for this entity.                    

     Dim entityRequest As RetrieveEntityRequest =
      New RetrieveEntityRequest With {
       .EntityFilters = EntityFilters.All,
       .LogicalName = Contact.EntityLogicalName,
       .RetrieveAsIfPublished = False
      }
     ' Retrieve only the currently published changes, ignoring the changes 
     ' that have not been published.
     Dim entityResponse As RetrieveEntityResponse =
      CType(_serviceProxy.Execute(entityRequest), RetrieveEntityResponse)
     Console.WriteLine("Retrieved the contact entity.")

     ' Get the entity from the response.
     Dim contactEntity As EntityMetadata = entityResponse.EntityMetadata

     ' Enable document management for the retrieved entity.
     contactEntity.IsDocumentManagementEnabled = True

     ' Create an update request.                    
     Dim updateRequest As UpdateEntityRequest =
      New UpdateEntityRequest With {
       .Entity = contactEntity
      }
     _serviceProxy.Execute(updateRequest)

     ' Publish the entity.
     ' All customizations must be published before they can be used.
     Dim enableRequest As New PublishAllXmlRequest()
     _serviceProxy.Execute(enableRequest)

     ' Retrieve the contact entity, and verify that document management is enabled.
     entityResponse = CType(_serviceProxy.Execute(entityRequest), RetrieveEntityResponse)
     contactEntity = entityResponse.EntityMetadata
     If contactEntity.IsDocumentManagementEnabled.Value = True Then
      Console.WriteLine("Enabled document management for the contact entity.")
     End If

     RevertChanges(promptforRevert)
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
   ' For this sample, no entities are created.
  End Sub

  ''' <summary>
  ''' Reverts any changes that were done by this sample.
  ''' <param name="prompt">Indicates whether to prompt the user 
  ''' to revert the changes done by this sample.</param>
  ''' </summary>
  Public Sub RevertChanges(ByVal prompt As Boolean)
   Dim revertChanges As Boolean = True

   If prompt Then
    Console.WriteLine(vbLf &amp; "Do you want these changes reverted? (y/n) [y]: ")
    Dim answer As String = Console.ReadLine()

    revertChanges = (answer.StartsWith("y") OrElse answer.StartsWith("Y") OrElse answer = String.Empty)
   End If

   If revertChanges Then
    Dim entityRequest As RetrieveEntityRequest =
     New RetrieveEntityRequest With {
      .EntityFilters = EntityFilters.All,
      .LogicalName = Contact.EntityLogicalName,
      .RetrieveAsIfPublished = False
     }
    Dim entityResponse As RetrieveEntityResponse =
     CType(_serviceProxy.Execute(entityRequest), RetrieveEntityResponse)

    Dim contactEntity As EntityMetadata = entityResponse.EntityMetadata

    ' Disable document management for the retrieved entity.
    contactEntity.IsDocumentManagementEnabled = False

    Dim updateRequest As UpdateEntityRequest =
     New UpdateEntityRequest With {
      .Entity = contactEntity
     }
    _serviceProxy.Execute(updateRequest)

    ' Publish the customizations to the entity.                
    Dim disableRequest As New PublishAllXmlRequest()
    _serviceProxy.Execute(disableRequest)

    Console.WriteLine("Changes have been reverted.")
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

    Dim app As New EnableDocumentManagement()
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
   Finally
    Console.WriteLine("Press <Enter> to exit.")
    Console.ReadLine()
   End Try
  End Sub
#End Region ' Main method
 End Class
End Namespace

' </snippetenabledocumentmanagement>
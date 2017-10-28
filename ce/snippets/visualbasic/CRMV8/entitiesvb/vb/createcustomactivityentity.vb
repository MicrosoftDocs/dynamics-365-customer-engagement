' <snippetcreatecustomactivityentity>


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
 ''' This sample shows how to create a custom activity.
 ''' </summary>
 Public Class CreateCustomActivityEntity
#Region "Class Level Members"
  ''' <summary>
  ''' Stores the organization service proxy.
  ''' </summary>
  Private _serviceProxy As OrganizationServiceProxy

#End Region ' Class Level Members

#Region "How To Sample Code"
  ''' <summary>
  ''' Create the custom entity.
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

     ' The custom prefix would typically be passed in as an argument or 
     ' determined by the publisher of the custom solution.
     Dim prefix As String = "new_"

     Dim customEntityName As String = prefix &amp; "instantmessage"

     ' Create the custom activity entity.
     Dim request As CreateEntityRequest = New CreateEntityRequest With {
      .HasNotes = True,
      .HasActivities = False,
      .PrimaryAttribute = New StringAttributeMetadata With {
       .SchemaName = "Subject",
       .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
       .MaxLength = 100,
       .DisplayName = New Label("Subject", 1033)},
      .Entity = New EntityMetadata With {
       .IsActivity = True,
       .SchemaName = customEntityName,
       .DisplayName = New Label("Instant Message", 1033),
       .DisplayCollectionName = New Label("Instant Messages", 1033),
       .OwnershipType = OwnershipTypes.UserOwned,
       .IsAvailableOffline = True}}

     _serviceProxy.Execute(request)

     'Entity must be published

     ' Add few attributes to the custom activity entity.
     Dim fontFamilyAttributeRequest As CreateAttributeRequest = New CreateAttributeRequest With {
      .EntityName = customEntityName,
      .Attribute = New StringAttributeMetadata With {
       .SchemaName = prefix &amp; "fontfamily",
       .DisplayName = New Label("Font Family", 1033),
       .MaxLength = 100}}
     Dim fontFamilyAttributeResponse As CreateAttributeResponse = CType(_serviceProxy.Execute(fontFamilyAttributeRequest), CreateAttributeResponse)

     Dim fontColorAttributeRequest As CreateAttributeRequest = New CreateAttributeRequest With {
      .EntityName = customEntityName,
      .Attribute = New StringAttributeMetadata With {
       .SchemaName = prefix &amp; "fontcolor",
       .DisplayName = New Label("Font Color", 1033),
       .MaxLength = 50}}
     Dim fontColorAttributeResponse As CreateAttributeResponse = CType(_serviceProxy.Execute(fontColorAttributeRequest), CreateAttributeResponse)

     Dim fontSizeAttributeRequest As CreateAttributeRequest = New CreateAttributeRequest With {
      .EntityName = customEntityName,
      .Attribute = New IntegerAttributeMetadata With {
       .SchemaName = prefix &amp; "fontSize",
       .DisplayName = New Label("Font Size", 1033)}}
     Dim fontSizeAttributeResponse As CreateAttributeResponse = CType(_serviceProxy.Execute(fontSizeAttributeRequest), CreateAttributeResponse)

     Console.WriteLine("The custom activity has been created.")

     DeleteCustomEntity(prefix, promptForDelete)
    End Using

    ' Catch any service fault exceptions that Microsoft Dynamics CRM throws.
   Catch fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
    ' You can handle an exception here or pass it back to the calling method.
    Throw
   End Try
  End Sub

  ''' <summary>
  ''' Deletes the custom entity that was created for this sample.
  ''' <param name="prompt">Indicates whether to prompt the user 
  ''' to delete the entity created in this sample.</param>
  ''' </summary>
  Public Sub DeleteCustomEntity(ByVal prefix As String, ByVal prompt As Boolean)
   Dim deleteEntity As Boolean = True

   If prompt Then
    Console.WriteLine(vbLf &amp; "Do you want this custom entity deleted? (y/n)")
    Dim answer As Char = Convert.ToChar(Console.ReadLine().Substring(0, 1))

    deleteEntity = (answer = "y"c OrElse answer = "Y"c)
   End If

   If deleteEntity Then
    Dim request As New DeleteEntityRequest() With {.LogicalName = prefix &amp; "instantmessage"}
    _serviceProxy.Execute(request)

    Console.WriteLine("Entity has been deleted.")
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

    Dim app As New CreateCustomActivityEntity()
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

' </snippetcreatecustomactivityentity>
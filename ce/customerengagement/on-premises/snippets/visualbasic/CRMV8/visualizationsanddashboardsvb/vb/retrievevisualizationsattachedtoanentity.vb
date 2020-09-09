' <snippetretrievevisualizationsattachedtoanentity>


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
 ''' This sample shows how to retrieve organization-owned visualizations attached to
 ''' an entity. This sample specifically retrieves organization-owned visualizations
 ''' that are attached to the 'Account' entity.
 ''' </summary>
 Public Class RetrieveVisualizationsAttachedToAnEntity
#Region "Class Level Members"
  ''' <summary>
  ''' Stores the organization service proxy.
  ''' </summary>
  Private _serviceProxy As OrganizationServiceProxy

#End Region ' Class Level Members

#Region "How To Sample Code"
  ''' <summary>
  ''' Create and configure the organization service proxy.
  ''' Retrieve organization-owned visualizations.
  ''' Optionally delete any entity records that were created for this sample.
  ''' </summary>
  ''' <param name="serverConfig">Contains server connection information.</param>
  ''' <param name="promptforDelete">When True, the user will be prompted to delete all
  ''' created entities.</param>

  Public Sub Run(ByVal serverConfig As ServerConnection.Configuration,
                 ByVal promptForDelete As Boolean)
   Try
    ' Connect to the Organization service. 
    ' The using statement assures that the service proxy will be properly disposed.
    _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
    Using _serviceProxy
     ' This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes()

     ' Create a query for retrieving all organization-owned visualizations 
     ' that are attached to the account entity.
     Dim mySavedQuery As QueryExpression =
      New QueryExpression With {
       .EntityName = SavedQueryVisualization.EntityLogicalName,
       .ColumnSet = New ColumnSet("name")
      }
     mySavedQuery.Criteria = New FilterExpression()
     mySavedQuery.Criteria.AddCondition("primaryentitytypecode", ConditionOperator.Equal, {Account.EntityLogicalName})

     ' Retrieve a collection of organization-owned visualizations that are attached to the account entity.
     Dim results As DataCollection(Of Entity) =
      _serviceProxy.RetrieveMultiple(mySavedQuery).Entities

     ' Display the names of the retrieved organization-owned visualizations.
     Console.WriteLine("Retrieved the following visualizations for the Account entity:")
     For Each entity As Entity In results
      Dim orgVisualization As SavedQueryVisualization = CType(entity, SavedQueryVisualization)
      Console.WriteLine("{0}", orgVisualization.Name)
     Next entity
    End Using
    ' Catch any service fault exceptions that Microsoft Dynamics CRM throws.
   Catch fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
    ' You can handle an exception here or pass it back to the calling method.
    Throw
   End Try
  End Sub

#End Region ' How To Sample Code

#Region "Main"
  ''' <summary>
  ''' Main. Runs the sample and provides error output.
  ''' <param name="args">Array of arguments to Main method.</param>
  ''' </summary>
  Public Shared Sub Main(ByVal args() As String)
   Try
    ' Obtain the target organization's Web address and client logon 
    ' credentials from the user.
    Dim serverConnect As New ServerConnection()
    Dim config As ServerConnection.Configuration = serverConnect.GetServerConfiguration()

    Dim app As New RetrieveVisualizationsAttachedToAnEntity()
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

' </snippetretrievevisualizationsattachedtoanentity>
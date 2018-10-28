' <snippetcreateoptionset>


Imports System.ServiceModel
Imports System.ServiceModel.Description

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Metadata
Imports Microsoft.Xrm.Sdk.Query
Imports Microsoft.Xrm.Sdk.Discovery
Imports Microsoft.Xrm.Sdk.Messages

Namespace Microsoft.Crm.Sdk.Samples

 ''' <summary>
 ''' Demonstrates how to create an option set in CRM.
 ''' </summary>
 Public Class CreateOptionSet
#Region "Class Level Members"

  ''' <summary>
  ''' Stores the organization service proxy.
  ''' </summary>
  Private _serviceProxy As OrganizationServiceProxy


  ' Specify which language code to use in the sample. If you are using a language
  ' other than US English, you will need to modify this value accordingly.
  ' See http://msdn.microsoft.com/library/0h88fahh.aspx
  Private Const _languageCode As Integer = 1033

  Private Const _optionSetName As String = "new_exampleoptionset"

#End Region ' Class Level Members

#Region "How To Sample Code"
  ''' <summary>
  ''' Shows how to create an Option Set.
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


     ' Define the option set to create.
     Dim setupOptionSetMetadata As New OptionSetMetadata() With {
      .Name = _optionSetName,
      .DisplayName = New Label("Example Option Set", _languageCode),
      .Description = New Label("An Example Option Set", _languageCode),
      .IsGlobal = True,
      .OptionSetType = OptionSetType.Picklist
     }
     setupOptionSetMetadata.Options.AddRange(
      {
       New OptionMetadata(New Label("Option 1", _languageCode), Nothing),
       New OptionMetadata(New Label("Option 2", _languageCode), Nothing)
      }
     )
     ' The name will be used to uniquely identify the option set.
     ' Normally you should generate this identifier using the publisher's
     ' prefix and double-check that the name is not in use.
     ' Define the list of options that populate the option set
     ' The order here determines the order shown in the option set.
     ' Options accepts any number of OptionMetadata instances, which
     ' are simply pairs of Labels and integer values.

     ' Wrap the OptionSetMetadata in the appropriate request.
     Dim createOptionSetRequest As CreateOptionSetRequest = New CreateOptionSetRequest With {
      .OptionSet = setupOptionSetMetadata
     }

     ' Pass the execute statement to the CRM service.
     _serviceProxy.Execute(createOptionSetRequest)
     Console.WriteLine("Option Set created")


     DeleteRequiredRecords(promptForDelete)
    End Using

    ' Catch any service fault exceptions that Microsoft Dynamics CRM throws.
   Catch fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
    ' You can handle an exception here or pass it back to the calling method.
    Throw
   End Try
  End Sub

  ''' <summary>
  ''' Deletes any entity records that were created for this sample.
  ''' <param name="prompt">Indicates whether to prompt the user to delete the records created in this sample.</param>
  ''' </summary>
  Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
   Dim deleteRecords As Boolean = True

   If prompt Then
    Console.WriteLine(vbLf &amp; "Do you want these entity records deleted? (y/n)")
    Dim answer As String = Console.ReadLine()

    deleteRecords = (answer.StartsWith("y") OrElse answer.StartsWith("Y"))
   End If

   If deleteRecords Then

    Dim deleteRequest As DeleteOptionSetRequest = New DeleteOptionSetRequest With {
     .Name = _optionSetName
    }
    _serviceProxy.Execute(deleteRequest)


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

    Dim app As New CreateOptionSet()
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

' </snippetcreateoptionset>
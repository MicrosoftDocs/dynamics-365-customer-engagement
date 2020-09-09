' <snippetdownloadreportdefinition>


Imports System.IO
Imports System.Xml
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
 ''' This sample shows how to download the report definition (RDL) file.
 ''' </summary>
 Public Class DownloadReportDefinition
#Region "Class Level Members"

  ''' <summary>
  ''' Stores the organization service proxy.
  ''' </summary>
  Private _serviceProxy As OrganizationServiceProxy

  ' Define the variables needed for this sample.
  Private _currentDirectoryPath As String

#End Region ' Class Level Members

#Region "How To Sample Code"
  ''' <summary>
  ''' Create and configure the organization service proxy.        
  ''' Download the report definition.        
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


     ' Query for an existing report: Account Overview. This is a default report in Microsoft Dynamics CRM.                    
     Dim reportQuery As New QueryByAttribute(Report.EntityLogicalName)
     reportQuery.AddAttributeValue("name", "Account Overview")
     reportQuery.ColumnSet = New ColumnSet("reportid")

     ' Get the report.
     Dim retrieveReports As EntityCollection =
      _serviceProxy.RetrieveMultiple(reportQuery)

     ' Convert retrieved Entity to a report
     Dim retrievedReport As Report = CType(retrieveReports.Entities(0), Report)
     Console.WriteLine("Retrieved the 'Account Overview' report.")

     ' Use the Download Report Definition message.
     Dim rdlRequest As DownloadReportDefinitionRequest =
      New DownloadReportDefinitionRequest With {
       .ReportId = retrievedReport.ReportId.Value
      }

     Dim rdlResponse As DownloadReportDefinitionResponse =
      CType(_serviceProxy.Execute(rdlRequest), DownloadReportDefinitionResponse)

     ' Get the current directory path.
     _currentDirectoryPath = Directory.GetCurrentDirectory()

     ' Access the xml data and save to disk
     Dim reportDefinitionFile As New XmlTextWriter(_currentDirectoryPath &amp; "\NewReport.rdl", System.Text.Encoding.UTF8)
     reportDefinitionFile.WriteRaw(rdlResponse.BodyText)
     reportDefinitionFile.Close()

     If File.Exists(_currentDirectoryPath &amp; "\NewReport.rdl") Then
      Console.WriteLine("Downloaded the report definition (NewReport.rdl) to '{0}'.", _currentDirectoryPath.ToString())
     End If


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
  ''' </summary>
  Public Sub CreateRequiredRecords()
   ' All the entity records in this sample are created in the Run() method.
  End Sub

  ''' <summary>
  ''' Deletes any entity records that were created for this sample.
  ''' <param name="prompt">Indicates whether to prompt the user to delete 
  ''' the records created in this sample.</param>
  ''' </summary>
  Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
   Dim deleteRecords As Boolean = True

   If prompt Then
    Console.WriteLine(vbLf &amp; "Do you want the records to be deleted? (y/n)")
    Dim answer As String = Console.ReadLine()

    deleteRecords = (answer.StartsWith("y") OrElse answer.StartsWith("Y"))
   End If

   If deleteRecords Then
    File.Delete(_currentDirectoryPath &amp; "\NewReport.rdl")
    Console.WriteLine("The downloaded report definition has been deleted.")
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

    Dim app As New DownloadReportDefinition()
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

' </snippetdownloadreportdefinition>
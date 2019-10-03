' <snippetpublishreport>


Imports System.Xml
Imports System.ServiceModel
Imports System.ServiceModel.Description
Imports System.IO

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
 ''' This sample shows how to retrieve the history limit of a report.
 ''' </summary>
 Public Class PublishReport
#Region "Class Level Members"

  ''' <summary>
  ''' Stores the organization service proxy.
  ''' </summary>
  Private _serviceProxy As OrganizationServiceProxy

  Private _reportId As Guid
  Private _reportCategoryId As Guid
  Private _reportVisibilityId1 As Guid
  Private _reportVisibilityId2 As Guid
  Private _reportVisibilityId3 As Guid
  Private _reportEntityId As Guid
  'Guid _reportLinkId;

#End Region ' Class Level Members

#Region "How To Sample Code"
  ''' <summary>
  ''' Create and configure the organization service proxy.        
  ''' Retrieve the history limit of a report.
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

     ' Call the method to create any data that this sample requires.
     CreateRequiredRecords()


     ' Define an anonymous type to define the possible values for
     ' report type.
     Dim ReportTypeCode = New With {
          Key .ReportingServicesReport = 1,
          Key .OtherReport = 2,
          Key .LinkedReport = 3}

     ' Define an anonymous type to define the possible values for
     ' report category.
     Dim ReportCategoryCode = New With {
          Key .SalesReports = 1,
          Key .ServiceReports = 2,
          Key .MarketingReports = 3,
          Key .AdministrativeReports = 4}

     ' Define an anonymous type to define the possible values for
     ' report visibility
     Dim ReportVisibilityCode = New With {
          Key .ReportsGrid = 1,
          Key .Form = 2,
          Key .Grid = 3}

     ' Instantiate a report object.
     ' See the Entity Metadata topic in the SDK documentation to determine
     ' which attributes must be set for each entity.

     Dim sampleReport As Report =
      New Report With {
       .Name = "Sample Report",
       .BodyText = File.ReadAllText("SampleReport.rdl"),
       .FileName = "SampleReport.rdl",
       .LanguageCode = 1033,
       .ReportTypeCode = New OptionSetValue(ReportTypeCode.ReportingServicesReport)
      }
     ' Create a report record named Sample Report.
     _reportId = _serviceProxy.Create(sampleReport)


     ' Set the report category.
     Dim sampleReportCategory As ReportCategory =
      New ReportCategory With {
       .ReportId = New EntityReference(Report.EntityLogicalName, _reportId),
       .CategoryCode = New OptionSetValue(ReportCategoryCode.AdministrativeReports)
      }
     _reportCategoryId = _serviceProxy.Create(sampleReportCategory)

     ' Define which entity this report uses.
     Dim reportEntity As ReportEntity =
      New ReportEntity With {
       .ReportId = New EntityReference(Report.EntityLogicalName, _reportId),
       .ObjectTypeCode = Account.EntityLogicalName
      }
     _reportEntityId = _serviceProxy.Create(reportEntity)


     ' Set the report visibility.
     Dim rv As ReportVisibility =
      New ReportVisibility With {
       .ReportId = New EntityReference(Report.EntityLogicalName, _reportId),
       .VisibilityCode = New OptionSetValue(ReportVisibilityCode.Form)
      }
     _reportVisibilityId1 = _serviceProxy.Create(rv)

     rv = New ReportVisibility With {
      .ReportId = New EntityReference(Report.EntityLogicalName, _reportId),
      .VisibilityCode = New OptionSetValue(ReportVisibilityCode.Grid)
     }
     _reportVisibilityId2 = _serviceProxy.Create(rv)

     rv = New ReportVisibility With {
      .ReportId = New EntityReference(Report.EntityLogicalName, _reportId),
      .VisibilityCode = New OptionSetValue(ReportVisibilityCode.ReportsGrid)
     }
     _reportVisibilityId3 = _serviceProxy.Create(rv)

     Console.WriteLine("{0} published in Microsoft Dynamics CRM.", sampleReport.Name)



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
   ' No entity records are required for this sample.
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
    _serviceProxy.Delete(Report.EntityLogicalName, _reportId)
    'There is no need to delete these records because deleting the report will delete all related records.
    '_serviceProxy.Delete(ReportCategory.EntityLogicalName, _reportCategoryId);
    '_serviceProxy.Delete(ReportEntity.EntityLogicalName, _reportEntityId);
    '_serviceProxy.Delete(ReportLink.EntityLogicalName, _reportLinkId);
    '_serviceProxy.Delete(ReportVisibility.EntityLogicalName, _reportVisibilityId1);
    '_serviceProxy.Delete(ReportVisibility.EntityLogicalName, _reportVisibilityId2);
    '_serviceProxy.Delete(ReportVisibility.EntityLogicalName, _reportVisibilityId3);
    '                
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

    Dim app As New PublishReport()
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

' </snippetpublishreport>
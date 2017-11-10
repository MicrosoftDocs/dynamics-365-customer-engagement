' <snippetmakereportavailableorunavailabletoorganization>


Imports Microsoft.VisualBasic
Imports System
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
    ''' This sample shows how to make a report available and 
    ''' unavailable to the organization.
    ''' </summary>
    Public Class MakeReportAvailableOrUnavailableToOrganization
#Region "Class Level Members"

        ''' <summary>
        ''' Stores the organization service proxy.
        ''' </summary>
        Private _serviceProxy As OrganizationServiceProxy

        ' Define the IDs needed for this sample.
        Private _reportId As Guid

#End Region ' Class Level Members

#Region "How To Sample Code"
        ''' <summary>
        ''' Create and configure the organization service proxy.        
        ''' Set the report to be available and then unavailable for the organization.        
        ''' Optionally delete any entity records that were created for this sample.
        ''' </summary>
        ''' <param name="serverConfig">Contains server connection information.</param>
        ''' <param name="promptforDelete">When True, the user will be prompted to delete all
        ''' created entities.</param>
        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration,
                       ByVal promptforDelete As Boolean)
            Try
                ' Connect to the Organization service. 
                ' The using statement assures that the service proxy will be properly disposed.
                _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
                Using _serviceProxy
                    ' This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes()

                    ' Call the method to create any data that this sample requires.
                    CreateRequiredRecords()

                    ' Retrieve existing personal report.
                    Dim existingPersonalReport As Report =
                        CType(_serviceProxy.Retrieve(Report.EntityLogicalName,
                                                     _reportId,
                                                     New ColumnSet("ispersonal")), 
                                                 Report)

                    ' Set IsPersonal property to false. 
                    existingPersonalReport.IsPersonal = False

                    ' Make the report available to the organization.
                    _serviceProxy.Update(existingPersonalReport)

                    ' Retrieve the report and verify that the report is available to the organization
                    Dim Cols1 As New ColumnSet("ispersonal")
                    Dim retrieveAvailableReport As Report =
                        CType(_serviceProxy.Retrieve(Report.EntityLogicalName,
                                                     _reportId, Cols1), 
                                                 Report)
                    If retrieveAvailableReport.IsPersonal.Value = False Then
                        Console.WriteLine("Report is available to the organization.")
                    End If

                    ' Now make the retrieved report unavailable to the organization
                    retrieveAvailableReport.IsPersonal = True
                    _serviceProxy.Update(retrieveAvailableReport)

                    ' Retrieve the report, and verify that the report is unavailable to the organization
                    Dim Cols2 As New ColumnSet("ispersonal")
                    Dim retrieveUnavailableReport As Report =
                        CType(_serviceProxy.Retrieve(Report.EntityLogicalName,
                                                     _reportId, Cols2), 
                                                 Report)
                    If retrieveUnavailableReport.IsPersonal.Value = True Then
                        Console.WriteLine("Report is unavailable to the organization.")
                    End If


                    DeleteRequiredRecords(promptforDelete)
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
            ' Define an anonymous type to define the possible values for
            ' report type
            Dim ReportTypeCode = New With
                                 {
                                     Key .ReportingServicesReport = 1,
                                     Key .OtherReport = 2,
                                     Key .LinkedReport = 3
                                 }

            ' Create a report 
            Dim newReport As Report =
                New Report With
                {
                    .Name = "Sample Report",
                    .Description = "Report created by the SDK code sample.",
                    .ReportTypeCode =
                    New OptionSetValue(CInt(Fix(ReportTypeCode.OtherReport))),
                    .BodyBinary = "SGVsbG8sIEkgYW0gYSB0ZXh0IGZpbGUu",
                    .FileName = "textfile.txt",
                    .IsPersonal = True}
            'Base64-encoded "Hello, I am a text file."
            _reportId = _serviceProxy.Create(newReport)
            Console.WriteLine("Created {0}.", newReport.Name)
        End Sub

        ''' <summary>
        ''' Deletes any entity records that were created for this sample.
        ''' <param name="prompt">Indicates whether to prompt the user to delete 
        ''' the records created in this sample.</param>
        ''' </summary>
        Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
            Dim toBeDeleted As Boolean = True

            If prompt Then
                ' Ask the user if the created entities should be deleted.
                Console.Write(vbLf &amp;
                              "Do you want these entity records deleted? (y/n) [y]: ")
                Dim answer As String = Console.ReadLine()
                If answer.StartsWith("y") _
                    OrElse answer.StartsWith("Y") _
                    OrElse answer = String.Empty Then
                    toBeDeleted = True
                Else
                    toBeDeleted = False
                End If
            End If

            If toBeDeleted Then
                ' Delete all records created in this sample.
                _serviceProxy.Delete(Report.EntityLogicalName, _reportId)
                Console.WriteLine("Entity record(s) have been deleted.")
            End If
        End Sub

#End Region ' How To Sample Code

#Region "Main method"
        ''' <summary>
        ''' Main. Runs the sample and provides error output.
        ''' <param name="args">Array of arguments to Main method.</param>
        ''' </summary>
        Public Shared Sub Main(ByVal args() As String)
            Try
                ' Obtain the target organization's Web address and client logon 
                ' credentials from the user.
                Dim serverConnect As New ServerConnection()
                Dim config As ServerConnection.Configuration =
                    serverConnect.GetServerConfiguration()

                Dim app As New MakeReportAvailableOrUnavailableToOrganization()
                app.Run(config, True)

            Catch ex As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                Console.WriteLine("The application terminated with an error.")
                Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp)
                Console.WriteLine("Code: {0}", ex.Detail.ErrorCode)
                Console.WriteLine("Message: {0}", ex.Detail.Message)
                Console.WriteLine("Plugin Trace: {0}", ex.Detail.TraceText)
                Console.WriteLine("Inner Fault: {0}",
                                  If(Nothing Is ex.Detail.InnerFault, "No Inner Fault", "Has Inner Fault"))
            Catch ex As System.TimeoutException
                Console.WriteLine("The application terminated with an error.")
                Console.WriteLine("Message: {0}", ex.Message)
                Console.WriteLine("Stack Trace: {0}", ex.StackTrace)
                Console.WriteLine("Inner Fault: {0}",
                                  If(Nothing Is ex.InnerException.Message, "No Inner Fault", ex.InnerException.Message))
            Catch ex As System.Exception
                Console.WriteLine("The application terminated with an error.")
                Console.WriteLine(ex.Message)

                ' Display the details of the inner exception.
                If ex.InnerException IsNot Nothing Then
                    Console.WriteLine(ex.InnerException.Message)

                    Dim fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault) =
                        TryCast(ex.InnerException, 
                            FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault))
                    If fe IsNot Nothing Then
                        Console.WriteLine("Timestamp: {0}", fe.Detail.Timestamp)
                        Console.WriteLine("Code: {0}", fe.Detail.ErrorCode)
                        Console.WriteLine("Message: {0}", fe.Detail.Message)
                        Console.WriteLine("Plugin Trace: {0}", fe.Detail.TraceText)
                        Console.WriteLine("Inner Fault: {0}",
                                          If(Nothing Is fe.Detail.InnerFault, "No Inner Fault", "Has Inner Fault"))
                    End If
                End If
                ' Additonal exceptions to catch: SecurityTokenValidationException, ExpiredSecurityTokenException,
                ' SecurityAccessDeniedException, MessageSecurityException, and SecurityNegotiationException.

            Finally

                Console.WriteLine("Press <Enter> to exit.")
                Console.ReadLine()
            End Try

        End Sub
#End Region ' Main method
    End Class
End Namespace

' </snippetmakereportavailableorunavailabletoorganization>
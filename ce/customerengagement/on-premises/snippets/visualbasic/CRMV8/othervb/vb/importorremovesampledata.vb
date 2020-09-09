' <snippetimportorremovesampledata>


Imports System.ServiceModel

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Xrm.Sdk.Client

' This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Crm.Sdk.Messages

Namespace Microsoft.Crm.Sdk.Samples
    ''' <summary>
    ''' Install or uninstall the Microsoft Dynamics CRM sample data records.
    ''' </summary>
    Public Class ImportOrRemoveSampleData

        #Region "Class Level Members"

        Private _serviceProxy As OrganizationServiceProxy

        #End Region ' Class Level Members

        #Region "How-To Sample Code"
        ''' <summary>
        ''' Demonstrates how to programmatically install and uninstall the Microsoft
        ''' Dynamics CRM sample data records.
        ''' </summary>
        ''' <param name="serverConfig">Contains server connection information.</param>
        ''' <param name="promptforDelete">Not applicable for this sample.</param>
        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration, ByVal promptforDelete As Boolean)
            Try
                ' Connect to the Organization service. 
                ' The using statement assures that the service proxy will be properly disposed.
                _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
                Using _serviceProxy
                    ' This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes()

                    ' Prompt user to install/uninstall sample data.
                    Console.WriteLine("Would you like to:")
                    Console.WriteLine("1) Install sample data for Microsoft Dynamics CRM?")
                    Console.WriteLine("2) Uninstall sample data for Microsoft Dynamics CRM?")
                    Console.Write("Press [1] to Install, [2] to Uninstall: ")
                    Dim answer As String = Console.ReadLine()

                    ' Update the sample data based on the user's response.
                    Select Case answer
                        Case "1"
                            Console.WriteLine("Installing sample data...")
                            Dim request As New InstallSampleDataRequest()
                            Dim response As InstallSampleDataResponse = CType(_serviceProxy.Execute(request), InstallSampleDataResponse)
                            Console.WriteLine("Sample data successfully installed.")
                        Case "2"
                            Console.WriteLine("Uninstalling sample data...")
                            Dim request2 As New UninstallSampleDataRequest()
                            Dim response2 As UninstallSampleDataResponse = CType(_serviceProxy.Execute(request2), UninstallSampleDataResponse)
                            Console.WriteLine("Sample data successfully uninstalled.")
                        Case Else
                            Console.WriteLine("Neither option was selected. No changes have been made to your records.")
                    End Select

                End Using

            ' Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            Catch fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                ' You can handle an exception here or pass it back to the calling method.
                Throw
            End Try
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

                Dim app As New ImportOrRemoveSampleData()
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

                    Dim fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault) = _
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
        #End Region ' Main method
    End Class
End Namespace

' </snippetimportorremovesampledata>
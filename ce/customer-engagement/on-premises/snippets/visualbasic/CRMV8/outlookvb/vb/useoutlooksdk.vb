' <snippetuseoutlooksdk>


Imports System.ServiceModel

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Xrm.Sdk.Client

' This namespace is found in Microsoft.Crm.Outlook.Sdk.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Crm.Outlook.Sdk

Namespace Microsoft.Crm.Sdk.Samples
    ''' <summary>
    ''' Shows how to use the methods of the CrmOutlookService located in the
    ''' Microsoft.Crm.Outlook.Sdk.dll assembly.</summary>
    ''' <remarks>
    ''' NOTE: Before running this sample, you should start the Outlook client.</remarks>
    Public Class UseOutlookSdk
        #Region "How To Sample Code"
        ''' <summary>
        ''' This method first connects to the Outlook service. Afterwards,
        ''' client information is retrieved and the client state is changed.
        ''' </summary>
        ''' <param name="serverConfig">Contains server connection information.</param>
        ''' <param name="promptforDelete">When True, the user will be prompted to delete all
        ''' created entities.</param>
        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration, ByVal promptforDelete As Boolean)
            Try
                ' Set up the CRM Service.  
                Dim outlookService As New CrmOutlookService()

                ' Determine if the Outlook client is running
                If outlookService.IsCrmClientLoaded Then
                    If outlookService.IsCrmDesktopClient Then
                        ' The desktop client cannot go offline
                        Console.WriteLine("CRM Client Desktop URL: " &amp; outlookService.ServerUri.AbsoluteUri)
                        Console.WriteLine("CRM Client state: " &amp; outlookService.State.ToString())
                    Else
                        ' See if laptop client is offline
                        If outlookService.IsCrmClientOffline Then
                            Console.WriteLine("CRM Client Offline URL: " &amp; outlookService.ServerUri.AbsoluteUri)
                            Console.WriteLine("CRM Client state: " &amp; outlookService.State.ToString())

                            ' Take client online
                            ' NOTE: GoOnline() will automatically Sync up with CRM
                            ' database, no need to call Sync() manually
                            Console.WriteLine("Going Online...")
                            outlookService.GoOnline()

                            Console.WriteLine("CRM Client state: " &amp; outlookService.State.ToString())
                        Else
                            Console.WriteLine("CRM Client Online URL: " &amp; outlookService.ServerUri.AbsoluteUri)
                            Console.WriteLine("CRM Client state: " &amp; outlookService.State.ToString())

                            ' Take client offline 
                            ' NOTE: GoOffline triggers a synchronization of the
                            ' offline database with the online server.
                            ' If a sync is not required, you can use SetOffline().
                            Console.WriteLine("Going Offline...")
                            outlookService.GoOffline()

                            Console.WriteLine("CRM Client state: " &amp; outlookService.State.ToString())
                        End If
                    End If
                End If

            ' Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            Catch fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                ' You can handle an exception here or pass it back to the calling method.
                Throw
            End Try
        End Sub

        #End Region ' How To Sample Code

        #Region "Main method"

        ''' <summary>
        ''' Standard Main() method used by most SDK samples.
        ''' </summary>
        ''' <param name="args"></param>
        <MTAThread()> Public Shared Sub Main(ByVal args() As String)
            Try
                ' Obtain the target organization's Web address and client logon 
                ' credentials from the user.
                Dim serverConnect As New ServerConnection()
                Dim config As ServerConnection.Configuration = serverConnect.GetServerConfiguration()

                Dim app As New UseOutlookSdk()
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

' </snippetuseoutlooksdk>
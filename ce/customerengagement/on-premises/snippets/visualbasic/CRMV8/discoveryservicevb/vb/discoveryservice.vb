' <snippetdiscoveryservice>


Imports System.ServiceModel

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Discovery

Namespace Microsoft.Crm.Sdk.Samples
    ''' <summary>
    ''' Demonstrates useful messages of the Discovery service.
    ''' </summary>
    Public Class DiscoveryService

        #Region "Class Level Members"

        Private _serviceProxy As DiscoveryServiceProxy

        #End Region ' Class Level Members

        #Region "How-To Sample Code"
        ''' <summary>
        ''' Demonstrates the RetrieveOrganization and RetrieveOrganizations messages
        ''' of the Discovery service.
        ''' </summary>
        ''' <param name="serverConfig">Contains server connection information.</param>
        ''' <param name="promptforDelete">When True, the user will be prompted to delete all
        ''' created entities.</param>
        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration, ByVal promptforDelete As Boolean)
            Try
                ' Connect to the Discovery service. 
                ' The using statement assures that the service proxy will be properly disposed.
                _serviceProxy = New DiscoveryServiceProxy(serverConfig.DiscoveryUri, serverConfig.HomeRealmUri, _
                                                          serverConfig.Credentials, serverConfig.DeviceCredentials)
                Using _serviceProxy
                    ' You can choose to use the interface instead of the proxy.
                    Dim service As IDiscoveryService = _serviceProxy

'                    #Region "RetrieveOrganizations Message"

                    ' Retrieve details about all organizations discoverable via the
                    ' Discovery service.
                    Dim orgsRequest As New RetrieveOrganizationsRequest() With { _
                        .AccessType = EndpointAccessType.Default, .Release = OrganizationRelease.Current}
                    Dim organizations As RetrieveOrganizationsResponse = _
                        CType(service.Execute(orgsRequest), RetrieveOrganizationsResponse)

                    ' Print each organization's friendly name, unique name and URLs
                    ' for each of its endpoints.
                    Console.WriteLine()
                    Console.WriteLine("Retrieving details of each organization:")
                    For Each organization As OrganizationDetail In organizations.Details
                        Console.WriteLine("Organization Name: {0}", organization.FriendlyName)
                        Console.WriteLine("Unique Name: {0}", organization.UniqueName)
                        Console.WriteLine("Endpoints:")
                        For Each endpoint In organization.Endpoints
                            Console.WriteLine("  Name: {0}", endpoint.Key)
                            Console.WriteLine("  URL: {0}", endpoint.Value)
                        Next endpoint
                    Next organization
                    Console.WriteLine("End of listing")
                    Console.WriteLine()

'                    #End Region ' RetrieveOrganizations Message

'                    #Region "RetrieveOrganization Message"

                    ' Retrieve details about a single organization discoverable via the
                    ' Discovery service.
                    Dim orgRequest As New RetrieveOrganizationRequest() With { _
                        .UniqueName = organizations.Details(organizations.Details.Count - 1).UniqueName, _
                        .AccessType = EndpointAccessType.Default, .Release = OrganizationRelease.Current}
                    Dim org As RetrieveOrganizationResponse = CType(service.Execute(orgRequest), RetrieveOrganizationResponse)

                    ' Print the organization's friendly name, unique name and URLs
                    ' for each of its endpoints.
                    Console.WriteLine()
                    Console.WriteLine("Retrieving details of specific organization:")
                    Console.WriteLine("Organization Name: {0}", org.Detail.FriendlyName)
                    Console.WriteLine("Unique Name: {0}", org.Detail.UniqueName)
                    Console.WriteLine("Endpoints:")
                    For Each endpoint As KeyValuePair(Of EndpointType, String) In org.Detail.Endpoints
                        Console.WriteLine("  Name: {0}", endpoint.Key)
                        Console.WriteLine("  URL: {0}", endpoint.Value)
                    Next endpoint
                    Console.WriteLine("End of listing")
                    Console.WriteLine()

'                    #End Region ' RetrieveOrganization Message

                End Using

            ' Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            Catch fe As FaultException(Of Microsoft.Xrm.Sdk.DiscoveryServiceFault)
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

                Dim app As New DiscoveryService()
                app.Run(config, True)
            Catch ex As FaultException(Of Microsoft.Xrm.Sdk.DiscoveryServiceFault)
                Console.WriteLine("The application terminated with an error.")
                Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp)
                Console.WriteLine("Code: {0}", ex.Detail.ErrorCode)
                Console.WriteLine("Message: {0}", ex.Detail.Message)
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

                    Dim fe As FaultException(Of Microsoft.Xrm.Sdk.DiscoveryServiceFault) = TryCast(ex.InnerException,  _
                        FaultException(Of Microsoft.Xrm.Sdk.DiscoveryServiceFault))
                    If fe IsNot Nothing Then
                        Console.WriteLine("Timestamp: {0}", fe.Detail.Timestamp)
                        Console.WriteLine("Code: {0}", fe.Detail.ErrorCode)
                        Console.WriteLine("Message: {0}", fe.Detail.Message)
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

' </snippetdiscoveryservice>
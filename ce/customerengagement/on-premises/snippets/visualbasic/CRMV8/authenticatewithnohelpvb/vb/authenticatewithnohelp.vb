' <snippetauthenticatewithnohelp>


Imports System
Imports System.ServiceModel
Imports System.ServiceModel.Description
Imports System.Reflection

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Query
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Discovery
Imports Microsoft.Crm.Sdk.Messages

Namespace Microsoft.Crm.Sdk.Samples
	''' <summary>
	''' Demonstrate how to do basic authentication using IServiceManagement and SecurityTokenResponse.
	''' </summary>
	Friend Class AuthenticateWithNoHelp
		#Region "Class Level Members"
		' To get discovery service address and organization unique name, 
		' Sign in to your CRM org and click Settings, Customization, Developer Resources.
        ' On Developer Resource page, find the discovery service address under Service Endpoints 
        ' and organization unique name under Your Organization Information.
        Private _discoveryServiceAddress As String = "https://dev.crm.dynamics.com/XRMServices/2011/Discovery.svc"
        Private _organizationUniqueName As String = "OrganizationUniqueName"
		' Provide your user name and password.
        Private _userName As String = "username@mydomain.com"
		Private _password As String = "password"

		' Provide domain name for the On-Premises org.
		Private _domain As String = "mydomain"

		#End Region ' Class Level Members

		#Region "How To Sample Code"
		''' <summary>
		''' 
		''' </summary>
		Public Sub Run()
            Dim serviceManagement As IServiceManagement(Of IDiscoveryService) =
                ServiceConfigurationFactory.CreateManagement(Of IDiscoveryService)(New Uri(_discoveryServiceAddress))
            Dim endpointType_renamed As AuthenticationProviderType = serviceManagement.AuthenticationType

            ' Set the credentials.
            Dim authCredentials As AuthenticationCredentials = GetCredentials(endpointType_renamed)


            Dim organizationUri As String = String.Empty
            ' Get the discovery service proxy.
            Using discoveryProxy As DiscoveryServiceProxy =
                GetProxy(Of IDiscoveryService, DiscoveryServiceProxy)(serviceManagement, authCredentials)
                ' Obtain organization information from the Discovery service. 
                If discoveryProxy IsNot Nothing Then
                    ' Obtain information about the organizations that the system user belongs to.
                    Dim orgs As OrganizationDetailCollection = DiscoverOrganizations(discoveryProxy)
                    ' Obtains the Web address (Uri) of the target organization.
                    organizationUri = FindOrganization(_organizationUniqueName,
                                                       orgs.ToArray()).Endpoints(EndpointType.OrganizationService)

                End If
            End Using


            If Not String.IsNullOrWhiteSpace(organizationUri) Then
                Dim orgServiceManagement As IServiceManagement(Of IOrganizationService) =
                    ServiceConfigurationFactory.CreateManagement(Of IOrganizationService)(New Uri(organizationUri))

                ' Set the credentials.
                Dim credentials As AuthenticationCredentials = GetCredentials(endpointType_renamed)

                ' Get the organization service proxy.
                Using organizationProxy As OrganizationServiceProxy =
                    GetProxy(Of IOrganizationService, OrganizationServiceProxy)(orgServiceManagement, credentials)
                    ' This statement is required to enable early-bound type support.
                    organizationProxy.EnableProxyTypes()

                    ' Now make an SDK call with the organization service proxy.
                    ' Display information about the logged on user.
                    Dim userid As Guid = (CType(organizationProxy.Execute(New WhoAmIRequest()), 
                                          WhoAmIResponse)).UserId
                    Dim systemUser_renamed As SystemUser =
                        organizationProxy.Retrieve("systemuser",
                                                   userid,
                                                   New ColumnSet(New String() {"firstname",
                                                                               "lastname"})).ToEntity(Of SystemUser)()
                    Console.WriteLine("Logged on user is {0} {1}.",
                                      systemUser_renamed.FirstName, systemUser_renamed.LastName)
                End Using
            End If

		End Sub

		''' <summary>
		''' Obtain the AuthenticationCredentials based on AuthenticationProviderType.
		''' </summary>
		''' <param name="endpointType">An AuthenticationProviderType of the CRM environment.</param>
		''' <returns>Get filled credentials.</returns>
		Private Function GetCredentials(ByVal endpointType As AuthenticationProviderType) As AuthenticationCredentials

			Dim authCredentials As New AuthenticationCredentials()
			Select Case endpointType
				Case AuthenticationProviderType.ActiveDirectory
                    authCredentials.ClientCredentials.Windows.ClientCredential =
                        New System.Net.NetworkCredential(_userName, _password, _domain)
				Case AuthenticationProviderType.LiveId
					authCredentials.ClientCredentials.UserName.UserName = _userName
					authCredentials.ClientCredentials.UserName.Password = _password
					authCredentials.SupportingCredentials = New AuthenticationCredentials()
                    authCredentials.SupportingCredentials.ClientCredentials =
                        Microsoft.Crm.Services.Utility.DeviceIdManager.LoadOrRegisterDevice()
				Case Else ' For Federated and OnlineFederated environments.
					authCredentials.ClientCredentials.UserName.UserName = _userName
					authCredentials.ClientCredentials.UserName.Password = _password
					' For OnlineFederated single-sign on, you could just use current UserPrincipalName instead of passing user name and password.
					' authCredentials.UserPrincipalName = UserPrincipal.Current.UserPrincipalName;  //Windows/Kerberos
			End Select

			Return authCredentials
		End Function

		''' <summary>
		''' Discovers the organizations that the calling user belongs to.
		''' </summary>
		''' <param name="service">A Discovery service proxy instance.</param>
		''' <returns>Array containing detailed information on each organization that 
		''' the user belongs to.</returns>
		Public Function DiscoverOrganizations(ByVal service As IDiscoveryService) As OrganizationDetailCollection
			If service Is Nothing Then
				Throw New ArgumentNullException("service")
			End If
			Dim orgRequest As New RetrieveOrganizationsRequest()
            Dim orgResponse As RetrieveOrganizationsResponse = CType(service.Execute(orgRequest), 
                RetrieveOrganizationsResponse)

			Return orgResponse.Details
		End Function

		''' <summary>
		''' Finds a specific organization detail in the array of organization details
		''' returned from the Discovery service.
		''' </summary>
        ''' <param name="orgUniqueName">The unique name of the organization to find.</param>
        ''' <param name="orgDetails">Array of organization detail object returned from the discovery service.</param>
        ''' <returns>Organization details or null if the organization was not found.</returns>
        ''' <seealso cref="DiscoveryOrganizations"/>
        Public Function FindOrganization(ByVal orgUniqueName As String,
                                         ByVal orgDetails() As OrganizationDetail) As OrganizationDetail
            If String.IsNullOrWhiteSpace(orgUniqueName) Then
                Throw New ArgumentNullException("orgUniqueName")
            End If
            If orgDetails Is Nothing Then
                Throw New ArgumentNullException("orgDetails")
            End If
            Dim orgDetail As OrganizationDetail = Nothing

            For Each detail As OrganizationDetail In orgDetails
                If String.Compare(detail.UniqueName, orgUniqueName,
                                  StringComparison.InvariantCultureIgnoreCase) = 0 Then
                    orgDetail = detail
                    Exit For
                End If
            Next detail
            Return orgDetail
        End Function

		''' <summary>
		''' Generic method to obtain discovery/organization service proxy instance.
		''' </summary>
		''' <typeparam name="TService">
		''' Set IDiscoveryService or IOrganizationService type to request respective service proxy instance.
		''' </typeparam>
		''' <typeparam name="TProxy">
		''' Set the return type to either DiscoveryServiceProxy or OrganizationServiceProxy type based on TService type.
		''' </typeparam>
		''' <param name="serviceManagement">An instance of IServiceManagement</param>
		''' <param name="authCredentials">The user's Microsoft Dynamics CRM logon credentials.</param>
        ''' <returns></returns>
        Private Function GetProxy(Of TService As Class,
                                      TProxy As ServiceProxy(Of TService)) _
                                  (ByVal serviceManagement As IServiceManagement(Of TService),
                                   ByVal authCredentials As AuthenticationCredentials) As TProxy
            Dim classType As Type = GetType(TProxy)

            If serviceManagement.AuthenticationType <>
                AuthenticationProviderType.ActiveDirectory Then
                Dim tokenCredentials As AuthenticationCredentials =
                    serviceManagement.Authenticate(authCredentials)
                ' Obtain discovery/organization service proxy for Federated, LiveId and OnlineFederated environments. 
                ' Instantiate a new class of type using the 2 parameter constructor of type IServiceManagement and SecurityTokenResponse.
                Return CType(classType _
                .GetConstructor(New Type() {GetType(IServiceManagement(Of TService)), GetType(SecurityTokenResponse)}) _
                .Invoke(New Object() {serviceManagement, tokenCredentials.SecurityTokenResponse}), TProxy)
            End If

            ' Obtain discovery/organization service proxy for ActiveDirectory environment.
            ' Instantiate a new class of type using the 2 parameter constructor of type IServiceManagement and ClientCredentials.
            Return CType(classType _
                .GetConstructor(New Type() {GetType(IServiceManagement(Of TService)), GetType(ClientCredentials)}) _
                .Invoke(New Object() {serviceManagement, authCredentials.ClientCredentials}), TProxy)
        End Function

		#End Region ' How To Sample Code

		#Region "Main method"

		''' <summary>
		''' Standard Main() method used by most SDK samples.
		''' </summary>
		''' <param name="args"></param>
		Public Shared Sub Main(ByVal args() As String)
			Try
				Dim app As New AuthenticateWithNoHelp()
				app.Run()
			Catch ex As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
				Console.WriteLine("The application terminated with an error.")
				Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp)
				Console.WriteLine("Code: {0}", ex.Detail.ErrorCode)
				Console.WriteLine("Message: {0}", ex.Detail.Message)
				Console.WriteLine("Trace: {0}", ex.Detail.TraceText)
                Console.WriteLine("Inner Fault: {0}",
                                  If(Nothing Is ex.Detail.InnerFault,
                                     "No Inner Fault", "Has Inner Fault"))
			Catch ex As System.TimeoutException
				Console.WriteLine("The application terminated with an error.")
				Console.WriteLine("Message: {0}", ex.Message)
				Console.WriteLine("Stack Trace: {0}", ex.StackTrace)
                Console.WriteLine("Inner Fault: {0}",
                                  If(Nothing Is ex.InnerException.Message,
                                     "No Inner Fault", ex.InnerException.Message))
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
						Console.WriteLine("Trace: {0}", fe.Detail.TraceText)
                        Console.WriteLine("Inner Fault: {0}",
                                          If(Nothing Is fe.Detail.InnerFault,
                                             "No Inner Fault", "Has Inner Fault"))
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

' </snippetauthenticatewithnohelp>
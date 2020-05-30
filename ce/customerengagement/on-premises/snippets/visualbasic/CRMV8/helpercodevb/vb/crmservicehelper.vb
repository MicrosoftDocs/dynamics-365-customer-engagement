' <snippetcrmservicehelper>


Option Explicit On
Option Strict On
Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics.CodeAnalysis
Imports System.DirectoryServices.AccountManagement
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Security
Imports System.ServiceModel
Imports System.ServiceModel.Description
Imports System.Text
Imports System.Xml
Imports System.Xml.Linq

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Discovery
Imports Microsoft.Crm.Services.Utility


Namespace Microsoft.Crm.Sdk.Samples
    ''' <summary>
    ''' Provides server connection information.
    ''' </summary>
    Public Class ServerConnection
        #Region "Inner classes" 
        ''' <summary>
        ''' Stores Microsoft Dynamics CRM server configuration information.
        ''' </summary>
        Public Class Configuration
            Public ServerAddress As String
            Public OrganizationName As String
            Public DiscoveryUri As Uri
            Public OrganizationUri As Uri
            Public HomeRealmUri As Uri = Nothing
            Public DeviceCredentials As ClientCredentials = Nothing
            Public Credentials As ClientCredentials = Nothing
            Public EndpointType As AuthenticationProviderType
			Public UserPrincipalName As String
#Region "internal members of the class"
            Friend OrganizationServiceManagement As IServiceManagement(Of IOrganizationService)
            Friend OrganizationTokenResponse As SecurityTokenResponse
            Friend AuthFailureCount As Int16 = 0
#End Region

            Public Overrides Overloads Function Equals(ByVal obj As Object) As Boolean
                'Check for null and compare run-time types.
                If obj Is Nothing OrElse Me.GetType() IsNot obj.GetType() Then
                    Return False
                End If

                Dim c As Configuration = CType(obj, Configuration)

                If Not Me.ServerAddress.Equals(c.ServerAddress, StringComparison.InvariantCultureIgnoreCase) Then
                    Return False
                End If
                If Not Me.OrganizationName.Equals(c.OrganizationName, StringComparison.InvariantCultureIgnoreCase) Then
                    Return False
                End If
                If Me.EndpointType <> c.EndpointType Then
                    Return False
                End If
                If Nothing IsNot Me.Credentials AndAlso Nothing IsNot c.Credentials Then
                    If Me.EndpointType = AuthenticationProviderType.ActiveDirectory Then
                        If Not Me.Credentials.Windows.ClientCredential.Domain.Equals(c.Credentials.Windows.ClientCredential.Domain,
                                                                                     StringComparison.InvariantCultureIgnoreCase) Then
                            Return False
                        End If
                        If Not Me.Credentials.Windows.ClientCredential.UserName.Equals(c.Credentials.Windows.ClientCredential.UserName,
                                                                                       StringComparison.InvariantCultureIgnoreCase) Then
                            Return False
                        End If
                    ElseIf Me.EndpointType = AuthenticationProviderType.LiveId Then
                        If Not Me.Credentials.UserName.UserName.Equals(c.Credentials.UserName.UserName,
                                                                       StringComparison.InvariantCultureIgnoreCase) Then
                            Return False
                        End If
                        If Not Me.DeviceCredentials.UserName.UserName.Equals(c.DeviceCredentials.UserName.UserName,
                                                                             StringComparison.InvariantCultureIgnoreCase) Then
                            Return False
                        End If
                        If Not Me.DeviceCredentials.UserName.Password.Equals(c.DeviceCredentials.UserName.Password,
                                                                             StringComparison.InvariantCultureIgnoreCase) Then
                            Return False
                        End If
                    Else
                        If Not Me.Credentials.UserName.UserName.Equals(c.Credentials.UserName.UserName,
                                                                       StringComparison.InvariantCultureIgnoreCase) Then
                            Return False
                        End If

                    End If
                End If
                Return True
            End Function

            Public Overrides Function GetHashCode() As Integer
                Dim returnHashCode As Integer = Me.ServerAddress.GetHashCode() _
                                                Xor Me.OrganizationName.GetHashCode() _
                                                Xor Me.EndpointType.GetHashCode()
				If Nothing IsNot Me.Credentials Then
                If Me.EndpointType = AuthenticationProviderType.ActiveDirectory Then
                    returnHashCode = returnHashCode _
                        Xor Me.Credentials.Windows.ClientCredential.UserName.GetHashCode() _
                        Xor Me.Credentials.Windows.ClientCredential.Domain.GetHashCode()
                ElseIf Me.EndpointType = AuthenticationProviderType.LiveId Then
                    returnHashCode = returnHashCode _
                        Xor Me.Credentials.UserName.UserName.GetHashCode() _
                        Xor Me.DeviceCredentials.UserName.UserName.GetHashCode() _
                        Xor Me.DeviceCredentials.UserName.Password.GetHashCode()
                Else
                    returnHashCode = returnHashCode _
                        Xor Me.Credentials.UserName.UserName.GetHashCode()
                End If
				End If
                Return returnHashCode
            End Function

        End Class
#End Region ' Inner classes

#Region "Public properties"

        Public configurations As List(Of Configuration) = Nothing

#End Region ' Public properties

#Region "Private properties"

        Private config As New Configuration()

#End Region ' Private properties

		#Region "Static methods"
		''' <summary>
		''' Obtains the organization service proxy.
		''' This would give a better performance than directly calling GetProxy() generic method
		''' as it uses cached OrganizationServiceManagement in case it is present.
		''' </summary>
		''' <param name="serverConfiguration">An instance of ServerConnection.Configuration</param>
		''' <returns>An instance of organization service proxy</returns>
		Public Shared Function GetOrganizationProxy(ByVal serverConfiguration As ServerConnection.Configuration) As OrganizationServiceProxy
			' If organization service management exists, then use it. 
			' Otherwise generate organization service proxy from scratch.
			If Nothing IsNot serverConfiguration.OrganizationServiceManagement Then
                ' Obtain the organization service proxy for the Federated, Microsoft account, and OnlineFederated environments. 
                If serverConfiguration.EndpointType <> AuthenticationProviderType.ActiveDirectory Then
                    ' get the organization service proxy.
                    Return GetProxy(Of IOrganizationService, OrganizationServiceProxy)(serverConfiguration)

                    ' Obtain organization service proxy for ActiveDirectory environment 
                    ' using existing organization service management.
                Else
                    Return New ManagedTokenOrganizationServiceProxy(serverConfiguration.OrganizationServiceManagement, serverConfiguration.Credentials)
                End If
			End If

			' Obtain the organization service proxy for all type of environments.
			Return GetProxy(Of IOrganizationService, OrganizationServiceProxy)(serverConfiguration)

		End Function
		#End Region ' Static methods

#Region "Public methods"
        ''' <summary>
        ''' Obtains the server connection information including the target organization's
        ''' Uri and user logon credentials from the user.
        ''' </summary>
        Public Overridable Function GetServerConfiguration() As Configuration
            Dim ssl As Boolean
            Dim addConfig As Boolean
            Dim configNumber As Integer
			' Read the configuration from the disk, if it exists, at C:\Users\<username>\AppData\Roaming\CrmServer\Credentials.xml.
            Dim isConfigExist As Boolean = ReadConfigurations()

			' Check if server configuration settings are already available on the disk.
            If isConfigExist Then
				' List of server configurations that are available from earlier saved settings.
                Console.Write(vbLf &amp; "(0) Add New Server Configuration (Maximum number up to 9)" &amp; vbTab)
                For n As Integer = 0 To configurations.Count - 1
                    Dim user As String

                    Select Case configurations(n).EndpointType
                        Case AuthenticationProviderType.ActiveDirectory
                            If configurations(n).Credentials IsNot Nothing Then
                                user = configurations(n).Credentials.Windows.ClientCredential.Domain &amp; "\" &amp; _
                                    configurations(n).Credentials.Windows.ClientCredential.UserName
                            Else
                                user = "default"
                            End If
                        Case Else
                            If configurations(n).Credentials IsNot Nothing Then
                                user = configurations(n).Credentials.UserName.UserName
                            Else
                                user = "default"
                            End If
                    End Select

                    Console.Write(vbLf &amp; "({0}) Server: {1},  Org: {2},  User: {3}" &amp; vbTab, n + 1, configurations(n).ServerAddress, _
                                  configurations(n).OrganizationName, user)
                Next n

                Console.WriteLine()

                Console.Write(vbLf &amp; "Specify the saved server configuration number (1-{0}) [{0}] : ", configurations.Count)
                Dim input As String = Console.ReadLine()
                Console.WriteLine()
                If input = String.Empty Then
                    input = configurations.Count.ToString()
                End If
                If Not Int32.TryParse(input, configNumber) Then
                    configNumber = -1
                End If

                If configNumber = 0 Then
                    addConfig = True
                ElseIf configNumber > 0 AndAlso configNumber <= configurations.Count Then
                    ' Return the organization Uri.
                    config = configurations(configNumber - 1)
					' Reorder the configuration list and save it to file to save the recent configuration as a latest one. 
                    If configNumber <> configurations.Count Then
                        Dim temp As Configuration = configurations(configurations.Count - 1)
                        configurations(configurations.Count - 1) = configurations(configNumber - 1)
                        configurations(configNumber - 1) = temp
                    End If
                    addConfig = False
                Else
                    Throw New InvalidOperationException("The specified server configuration does not exist.")
                End If
            Else
                addConfig = True
            End If

            If addConfig Then
                ' Get the server address. If no value is entered, default to Microsoft Dynamics
                ' CRM Online in the North American data center.
                config.ServerAddress = GetServerAddress(ssl)
                If String.IsNullOrWhiteSpace(config.ServerAddress) Then
                    config.ServerAddress = "crm.dynamics.com"
                End If


                ' One of the Microsoft Dynamics CRM Online data centers.
                If config.ServerAddress.EndsWith(".dynamics.com", StringComparison.InvariantCultureIgnoreCase) Then
                    ' Check if the organization is provisioned in Microsoft Office 365.
                    If GetOrgType(config.ServerAddress) Then
                        config.DiscoveryUri = New Uri(String.Format("https://disco.{0}/XRMServices/2011/Discovery.svc", config.ServerAddress))
                    Else
                        config.DiscoveryUri = New Uri(String.Format("https://dev.{0}/XRMServices/2011/Discovery.svc", config.ServerAddress))

                        ' Get or set the device credentials. This is required for Microsoft account authentication. 
                        config.DeviceCredentials = GetDeviceCredentials()
                    End If
                    ' Check if the server uses Secure Socket Layer (https).
                ElseIf ssl Then
                    config.DiscoveryUri = New Uri(String.Format("https://{0}/XRMServices/2011/Discovery.svc", config.ServerAddress))
                Else
                    config.DiscoveryUri = New Uri(String.Format("https://{0}/XRMServices/2011/Discovery.svc", config.ServerAddress))
                End If

                ' Get the target organization.
                config.OrganizationUri = GetOrganizationAddress()
                configurations.Add(config)
                Dim length As Integer = configurations.Count
                Dim i As Integer = length - 2
                ' Check if a new configuration already exists. 
                ' If found, reorder list to show latest in use.                                   
                Do While i > 0

                    If configurations(configurations.Count - 1).Equals(configurations(i)) Then
                        configurations.RemoveAt(i)
                    End If
                    i -= 1
                Loop
                ' Set max configurations to 9 otherwise overwrite existing one.
                If configurations.Count > 9 Then
                    configurations.RemoveAt(0)
                End If
            Else
                ' Get the existing user's logon credentials.
                config.Credentials = GetUserLogonCredentials(config)
            End If
            SaveConfigurations()
            Return config
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
            Dim orgResponse As RetrieveOrganizationsResponse = CType(service.Execute(orgRequest), RetrieveOrganizationsResponse)

            Return orgResponse.Details
        End Function

        ''' <summary>
        ''' Finds a specific organization detail in the array of organization details
        ''' returned from the Discovery service.
        ''' </summary>
        ''' <param name=orgFriendlyName">The friendly name of the organization to find.</param>
        ''' <param name="orgDetails">Array of organization detail object returned from the discovery service.</param>
        ''' <returns>Organization details or null if the organization was not found.</returns>
        ''' <seealso cref="DiscoveryOrganizations"/>
        Public Function FindOrganization(ByVal orgFriendlyName As String, ByVal orgDetails() As OrganizationDetail) As OrganizationDetail
            If String.IsNullOrWhiteSpace(orgFriendlyName) Then
                Throw New ArgumentNullException("orgFriendlyName")
            End If
            If orgDetails Is Nothing Then
                Throw New ArgumentNullException("orgDetails")
            End If
            Dim orgDetail As OrganizationDetail = Nothing

            For Each detail As OrganizationDetail In orgDetails
                If String.Compare(detail.FriendlyName, orgFriendlyName, StringComparison.InvariantCultureIgnoreCase) = 0 Then
                    orgDetail = detail
                    Exit For
                End If
            Next detail
            Return orgDetail
        End Function

        ''' <summary>
        ''' Reads a server configuration file.
        ''' Read the configuration from disk, if it exists, at C:\Users\YourUserName\AppData\Roaming\CrmServer\Credentials.xml.
        ''' </summary>
        ''' <returns>Is configuration settings already available on disk.</returns>
        Public Function ReadConfigurations() As Boolean
            Dim isConfigExist As Boolean = False

            If configurations Is Nothing Then
                configurations = New List(Of Configuration)()
            End If

            If File.Exists(CrmServiceHelperConstants.ServerCredentialsFile) Then
                Dim configurationsFromFile As XElement = XElement.Load(CrmServiceHelperConstants.ServerCredentialsFile)
                For Each config As XElement In configurationsFromFile.Nodes()
                    Dim newConfig As New Configuration()
                    Dim serverAddress = config.Element("ServerAddress")
                    If serverAddress IsNot Nothing Then
                        If Not String.IsNullOrEmpty(serverAddress.Value) Then
                            newConfig.ServerAddress = serverAddress.Value
                        End If
                    End If
                    Dim organizationName = config.Element("OrganizationName")
                    If organizationName IsNot Nothing Then
                        If Not String.IsNullOrEmpty(organizationName.Value) Then
                            newConfig.OrganizationName = organizationName.Value
                        End If
                    End If
                    Dim discoveryUri = config.Element("DiscoveryUri")
                    If discoveryUri IsNot Nothing Then
                        If Not String.IsNullOrEmpty(discoveryUri.Value) Then
                            newConfig.DiscoveryUri = New Uri(discoveryUri.Value)
                        End If
                    End If
                    Dim organizationUri = config.Element("OrganizationUri")
                    If organizationUri IsNot Nothing Then
                        If Not String.IsNullOrEmpty(organizationUri.Value) Then
                            newConfig.OrganizationUri = New Uri(organizationUri.Value)
                        End If
                    End If
                    Dim homeRealmUri = config.Element("HomeRealmUri")
                    If homeRealmUri IsNot Nothing Then
                        If Not String.IsNullOrEmpty(homeRealmUri.Value) Then
                            newConfig.HomeRealmUri = New Uri(homeRealmUri.Value)
                        End If
                    End If

                    Dim vendpointType = config.Element("EndpointType")
                    If vendpointType IsNot Nothing Then
                        newConfig.EndpointType = RetrieveAuthenticationType(vendpointType.Value)
                    End If
                    If config.Element("Credentials").HasElements Then
                        newConfig.Credentials =
                            ParseInCredentials(config.Element("Credentials"),
                                               newConfig.EndpointType,
                                               newConfig.ServerAddress + ":" + newConfig.OrganizationName + ":" + config.Element("Credentials").Element("UserName").Value)
                    End If
                    If newConfig.EndpointType = AuthenticationProviderType.LiveId Then
                        newConfig.DeviceCredentials = GetDeviceCredentials()
                    End If
                    Dim userPrincipalName = config.Element("UserPrincipalName")
                    If userPrincipalName IsNot Nothing Then
                        If Not String.IsNullOrWhiteSpace(userPrincipalName.Value) Then
                            newConfig.UserPrincipalName = userPrincipalName.Value
                        End If
                    End If
                    configurations.Add(newConfig)
                Next config
            End If

            If configurations.Count > 0 Then
                isConfigExist = True
            End If

            Return isConfigExist
        End Function

        ''' <summary>
        ''' Writes all server configurations to a file.
        ''' </summary>
        ''' <remarks>If the file exists, it is overwritten.</remarks>
        Public Sub SaveConfigurations()
            If configurations Is Nothing Then
                Throw New NullReferenceException("No server connection configurations were found.")
            End If

            Dim file As New FileInfo(CrmServiceHelperConstants.ServerCredentialsFile)

            ' Create directory if it does not exist.
            If Not file.Directory.Exists Then
                file.Directory.Create()
            End If

            ' Replace file if it exists.
            Using fs As FileStream = file.Open(FileMode.Create, FileAccess.Write, FileShare.None)
                Using writer As New XmlTextWriter(fs, Encoding.UTF8)
                    writer.Formatting = Formatting.Indented
                    writer.WriteStartDocument()
                    writer.WriteStartElement("Configurations")
                    writer.WriteFullEndElement()
                    writer.WriteEndDocument()
                End Using
            End Using

            For Each config As Configuration In configurations
                SaveConfiguration(CrmServiceHelperConstants.ServerCredentialsFile, config, True)
            Next config
        End Sub

        ''' <summary>
        ''' Writes a server configuration to a file.
        ''' </summary>
        ''' <param name="pathname">The file name and system path of the output configuration file.</param>
        ''' <param name="config">A server connection configuration.</param>
        ''' <param name="append">If true, the configuration is appended to the file, otherwise a new file
        ''' is created.</param>
        Public Sub SaveConfiguration(ByVal pathname As String, ByVal config As Configuration, ByVal append As Boolean)
            If String.IsNullOrWhiteSpace(pathname) Then
                Throw New ArgumentNullException("pathname")
            End If
            If config Is Nothing Then
                Throw New ArgumentNullException("config")
            End If
            ' Target is the key with which associated credentials can be fetched from windows credentials manager.
            Dim target As String = config.ServerAddress &amp; ":" &amp; config.OrganizationName
            If Nothing IsNot config.Credentials Then
                Select Case config.EndpointType
                    Case AuthenticationProviderType.ActiveDirectory
                        target = target &amp; ":" &amp; config.Credentials.Windows.ClientCredential.UserName
                    Case AuthenticationProviderType.LiveId,
                        AuthenticationProviderType.Federation,
                        AuthenticationProviderType.OnlineFederation
                        target = target &amp; ":" &amp; config.Credentials.UserName.UserName
                    Case Else
                        target = String.Empty
                End Select
            End If

            Dim configurationsFromFile As XElement = XElement.Load(pathname)
            Dim newConfig As New XElement("Configuration",
                                          New XElement("ServerAddress",
                                                       config.ServerAddress),
                                          New XElement("OrganizationName",
                                                       config.OrganizationName),
                                          New XElement("DiscoveryUri",
                                                       If(config.DiscoveryUri IsNot Nothing,
                                                          config.DiscoveryUri.OriginalString,
                                                          String.Empty)),
                                          New XElement("OrganizationUri",
                                                       If(config.OrganizationUri IsNot Nothing,
                                                          config.OrganizationUri.OriginalString,
                                                          String.Empty)),
                                          New XElement("HomeRealmUri",
                                                       If(config.HomeRealmUri IsNot Nothing,
                                                          config.HomeRealmUri.OriginalString,
                                                          String.Empty)),
                                          ParseOutCredentials(config.Credentials,
                                                              config.EndpointType,
                                                              target),
                                          New XElement("EndpointType",
                                                       config.EndpointType.ToString()),
                                          New XElement("UserPrincipalName",
                                                       If(config.UserPrincipalName IsNot Nothing,
                                                          config.UserPrincipalName, String.Empty)
                                                      )
                                         )

            If append Then
                configurationsFromFile.Add(newConfig)
            Else
                configurationsFromFile.ReplaceAll(newConfig)
            End If

            Using writer As New XmlTextWriter(pathname, Encoding.UTF8)
                writer.Formatting = Formatting.Indented
                configurationsFromFile.Save(writer)
            End Using
        End Sub

        ''' <summary>
        ''' Obtains the user's logon credentials for the target server.
        ''' </summary>
        ''' <param name="config">An instance of the Configuration.</param>
        ''' <returns>Logon credentials of the user.</returns>
        Public Shared Function GetUserLogonCredentials(ByVal config As ServerConnection.Configuration) As ClientCredentials
            Dim credentials As New ClientCredentials()
            Dim userName As String
            Dim password As SecureString
            Dim domain As String
            Dim isCredentialExist As Boolean = If(config.Credentials IsNot Nothing, True, False)
            Select Case config.EndpointType
                ' An on-premises Microsoft Dynamics CRM server deployment. 
                Case AuthenticationProviderType.ActiveDirectory
                    ' Uses credentials from windows credential manager for earlier saved configuration.
                    If isCredentialExist AndAlso (Not String.IsNullOrWhiteSpace(config.OrganizationName)) Then
                        domain = config.Credentials.Windows.ClientCredential.Domain
                        userName = config.Credentials.Windows.ClientCredential.UserName
                        If String.IsNullOrWhiteSpace(config.Credentials.Windows.ClientCredential.Password) Then
                            Console.Write(vbLf &amp; "Enter domain\username: ")
                            Console.WriteLine(config.Credentials.Windows.ClientCredential.Domain _
                                              &amp; "\" &amp; config.Credentials.Windows.ClientCredential.UserName)

                            Console.Write("       Enter Password: ")
                            password = ReadPassword()
                        Else
                            password = config.Credentials.Windows.ClientCredential.SecurePassword
                        End If
                        ' Uses default credentials saved in windows credential manager for current organization.
                    ElseIf (Not isCredentialExist) AndAlso (Not String.IsNullOrWhiteSpace(config.OrganizationName)) Then
                        Return Nothing
                        ' Prompts users to enter credential for current organization.
                    Else
                        Dim domainAndUserName() As String
                        Do
                            Console.Write(vbLf &amp; "Enter domain\username: ")
                            domainAndUserName = Console.ReadLine().Split("\"c)

                            ' If user do not choose to enter user name, 
                            ' then try to use default credential from windows credential manager.
                            If domainAndUserName.Length = 1 AndAlso
                                String.IsNullOrWhiteSpace(domainAndUserName(0)) Then
                                Return Nothing
                            End If
                        Loop While domainAndUserName.Length <> 2 OrElse
                            String.IsNullOrWhiteSpace(domainAndUserName(0)) OrElse
                            String.IsNullOrWhiteSpace(domainAndUserName(1))

                        domain = domainAndUserName(0)
                        userName = domainAndUserName(1)

                        Console.Write("       Enter Password: ")
                        password = ReadPassword()
                    End If
                    If Nothing IsNot password Then
                        credentials.Windows.ClientCredential =
                            New System.Net.NetworkCredential(userName, password, domain)
                    Else
                        credentials.Windows.ClientCredential = Nothing
                    End If

                    ' A Microsoft Dynamics CRM Online server deployment. 
                Case AuthenticationProviderType.LiveId,
                    AuthenticationProviderType.Federation,
                    AuthenticationProviderType.OnlineFederation
                    ' An internet-facing deployment (IFD) of Microsoft Dynamics CRM.          
                    ' Managed Identity/Federated Identity users using Microsoft Office 365.
                    ' Use saved credentials.
                    If isCredentialExist Then
                        userName = config.Credentials.UserName.UserName
                        If String.IsNullOrWhiteSpace(config.Credentials.UserName.Password) Then
                            Console.Write(vbLf &amp; " Enter Username: ")
                            Console.WriteLine(config.Credentials.UserName.UserName)

                            Console.Write(" Enter Password: ")
                            password = ReadPassword()
                        Else
                            password = ConvertToSecureString(config.Credentials.UserName.Password)
                        End If
                        ' For OnlineFederation environments, initially try to authenticate with the current UserPrincipalName
                        ' for single sign-on scenario.
                    ElseIf config.EndpointType = AuthenticationProviderType.OnlineFederation AndAlso
                        config.AuthFailureCount = 0 AndAlso
                        (Not String.IsNullOrWhiteSpace(UserPrincipal.Current.UserPrincipalName)) Then
                        config.UserPrincipalName = UserPrincipal.Current.UserPrincipalName
                        Return Nothing
                        ' Otherwise request username and password.
                    Else
                        config.UserPrincipalName = String.Empty
                        If config.EndpointType = AuthenticationProviderType.LiveId Then
                            Console.Write(vbLf &amp; " Enter Microsoft account: ")
                        Else
                            Console.Write(vbLf &amp; " Enter Username: ")
                        End If
                        userName = Console.ReadLine()
                        If String.IsNullOrWhiteSpace(userName) Then
                            Return Nothing
                        End If

                        Console.Write(" Enter Password: ")
                        password = ReadPassword()
                    End If
                    credentials.UserName.UserName = userName
                    credentials.UserName.Password = ConvertToUnsecureString(password)
                Case Else
                    credentials = Nothing
            End Select
            Return credentials
        End Function

        ''' <summary>
        ''' Prompts user to enter password in console window 
        ''' and capture the entered password into SecureString.
        ''' </summary>
        ''' <returns>Password stored in a secure string.</returns>
        Public Shared Function ReadPassword() As SecureString
            Dim ssPassword As New SecureString()

            Dim info As ConsoleKeyInfo = Console.ReadKey(True)
            Do While info.Key <> ConsoleKey.Enter
                If info.Key = ConsoleKey.Backspace Then
                    If ssPassword.Length <> 0 Then
                        ssPassword.RemoveAt(ssPassword.Length - 1)
                        Console.Write(vbBack &amp; " " &amp; vbBack) ' erase last char
                    End If
                ElseIf info.KeyChar >= " "c Then ' no control chars
                    ssPassword.AppendChar(info.KeyChar)
                    Console.Write("*")
                End If
                info = Console.ReadKey(True)
            Loop

            Console.WriteLine()
            Console.WriteLine()

            ' Lock the secure string password.
            ssPassword.MakeReadOnly()

            Return ssPassword
        End Function

        ''' <summary>
        ''' Generic method to obtain discovery/organization service proxy instance.
        ''' </summary>
        ''' <typeparam name="TService">
        ''' Set IDiscoveryService or IOrganizationService type 
        ''' to request respective service proxy instance.
        ''' </typeparam>
        ''' <typeparam name="TProxy">
        ''' Set the return type to either DiscoveryServiceProxy 
        ''' or OrganizationServiceProxy type based on TService type.
        ''' </typeparam>
        ''' <param name="currentConfig">An instance of existing Configuration</param>
        ''' <returns>An instance of TProxy 
        ''' i.e. DiscoveryServiceProxy or OrganizationServiceProxy</returns>
        Public Shared Function GetProxy(Of TService As Class,
                                            TProxy As ServiceProxy(Of TService))(ByVal currentConfig As ServerConnection.Configuration) As TProxy
            ' Check if it is organization service proxy request.
            Dim isOrgServiceRequest As Boolean = GetType(TService).Equals(GetType(IOrganizationService))

            ' Get appropriate Uri from Configuration.
            Dim serviceUri As Uri = If(isOrgServiceRequest,
                                       currentConfig.OrganizationUri,
                                       currentConfig.DiscoveryUri)

            ' Set service management for either organization service Uri or discovery service Uri.
            ' For organization service Uri, if service management exists 
            ' then use it from cache. Otherwise create new service management for current organization.
            Dim serviceManagement As IServiceManagement(Of TService) =
                If(isOrgServiceRequest AndAlso Nothing IsNot currentConfig.OrganizationServiceManagement,
                   CType(currentConfig.OrganizationServiceManagement, IServiceManagement(Of TService)),
                   ServiceConfigurationFactory.CreateManagement(Of TService)(serviceUri))

            If isOrgServiceRequest Then
                If currentConfig.OrganizationTokenResponse Is Nothing Then
                    currentConfig.OrganizationServiceManagement =
                        CType(serviceManagement, IServiceManagement(Of IOrganizationService))
                End If
                ' Set the EndpointType in the current Configuration object 
                ' while adding new configuration using discovery service proxy.
            Else
                ' Get the EndpointType.
                currentConfig.EndpointType = serviceManagement.AuthenticationType
                ' Get the logon credentials.
                currentConfig.Credentials = GetUserLogonCredentials(currentConfig)
            End If

            ' Set the credentials.
            Dim authCredentials As New AuthenticationCredentials()

            ' If UserPrincipalName exists, use it. Otherwise, set the logon credentials from the configuration.
            If Not String.IsNullOrWhiteSpace(currentConfig.UserPrincipalName) Then
                ' Single sing-on with the Federated Identity organization using current UserPrinicipalName.
                authCredentials.UserPrincipalName = currentConfig.UserPrincipalName
            Else
                authCredentials.ClientCredentials = currentConfig.Credentials
            End If

            Dim classType As Type

            ' Obtain discovery/organization service proxy for Federated,
            ' Microsoft account and OnlineFederated environments. 
            If currentConfig.EndpointType <> AuthenticationProviderType.ActiveDirectory Then
                If currentConfig.EndpointType = AuthenticationProviderType.LiveId Then
                    authCredentials.SupportingCredentials = New AuthenticationCredentials()
                    authCredentials.SupportingCredentials.ClientCredentials = currentConfig.DeviceCredentials
                End If

                Dim tokenCredentials As AuthenticationCredentials = serviceManagement.Authenticate(authCredentials)

                If isOrgServiceRequest Then
                    ' Set SecurityTokenResponse for the current organization.
                    currentConfig.OrganizationTokenResponse = tokenCredentials.SecurityTokenResponse
                    ' Set classType to ManagedTokenOrganizationServiceProxy.
                    classType = GetType(ManagedTokenOrganizationServiceProxy)

                Else
                    ' Set classType to ManagedTokenDiscoveryServiceProxy.
                    classType = GetType(ManagedTokenDiscoveryServiceProxy)
                End If

                ' Invokes ManagedTokenOrganizationServiceProxy or ManagedTokenDiscoveryServiceProxy 
                ' (IServiceManagement<TService>, SecurityTokenResponse) constructor.
                Return CType(classType.GetConstructor(New Type() {GetType(IServiceManagement(Of TService)), GetType(SecurityTokenResponse)}).Invoke(New Object() {serviceManagement, tokenCredentials.SecurityTokenResponse}), TProxy)
            End If

            ' Obtain discovery/organization service proxy for ActiveDirectory environment.
            If isOrgServiceRequest Then
                classType = GetType(ManagedTokenOrganizationServiceProxy)
            Else
                classType = GetType(ManagedTokenDiscoveryServiceProxy)
            End If

            ' Invokes ManagedTokenDiscoveryServiceProxy or ManagedTokenOrganizationServiceProxy 
            ' (IServiceManagement<TService>, ClientCredentials) constructor.
            Return CType(classType.GetConstructor(New Type() {GetType(IServiceManagement(Of TService)), GetType(ClientCredentials)}).Invoke(New Object() {serviceManagement, authCredentials.ClientCredentials}), TProxy)
        End Function

        ''' <summary>
        ''' Convert SecureString to unsecure string.
        ''' </summary>
        ''' <param name="securePassword">Pass SecureString for conversion.</param>
        ''' <returns>unsecure string</returns>
        Public Shared Function ConvertToUnsecureString(ByVal securePassword As SecureString) As String
            If securePassword Is Nothing Then
                Throw New ArgumentNullException("securePassword")
            End If

            Dim unmanagedString As IntPtr = IntPtr.Zero
            Try
                unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(securePassword)
                Return Marshal.PtrToStringUni(unmanagedString)
            Finally
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString)
            End Try
        End Function

        ''' <summary>
        ''' Convert unsecure string to SecureString.
        ''' </summary>
        ''' <param name="password">Pass unsecure string for conversion.</param>
        ''' <returns>SecureString</returns>
        Public Shared Function ConvertToSecureString(ByVal password As String) As SecureString
            If password Is Nothing Then
                Throw New ArgumentNullException("password")
            End If

            Dim securePassword = New SecureString()
            For Each c As Char In password
                securePassword.AppendChar(c)
            Next c
            securePassword.MakeReadOnly()
            Return securePassword
        End Function
#End Region ' Public methods

#Region "Protected methods"

        ''' <summary>
        ''' Obtains the name and port of the server running the Microsoft Dynamics CRM
        ''' Discovery service.
        ''' </summary>
        ''' <returns>The server's network name and optional TCP/IP port.</returns>
        Protected Overridable Function GetServerAddress(<System.Runtime.InteropServices.Out()> ByRef ssl As Boolean) As String
            ssl = False

            Console.Write("Enter a CRM server name and port [crm.dynamics.com]: ")
            Dim server As String = Console.ReadLine()

            If server.EndsWith(".dynamics.com") OrElse String.IsNullOrWhiteSpace(server) Then
                ssl = True
            Else
                Console.Write("Is this server configured for Secure Socket Layer (https) (y/n) [n]: ")
                Dim answer As String = Console.ReadLine()

                If answer = "y" OrElse answer = "Y" Then
                    ssl = True
                End If
            End If

            Return server
        End Function

        ''' <summary>
        ''' Is this organization provisioned in Microsoft Office 365?
        ''' </summary>
        ''' <param name="server">The server's network name.</param>
        Protected Overridable Function GetOrgType(ByVal server As String) As Boolean
            Dim isO365Org As Boolean = False
            If String.IsNullOrWhiteSpace(server) Then
                Return isO365Org
            End If
            If server.IndexOf("."c) = -1 Then
                Return isO365Org
            End If

            Console.Write("Is this organization provisioned in Microsoft Office 365 (y/n) [n]: ")
            Dim answer As String = Console.ReadLine()

            If answer = "y" OrElse answer = "Y" Then
                isO365Org = True
            End If

            Return isO365Org
        End Function

        ''' <summary>
        ''' Obtains the web address (Uri) of the target organization.
        ''' </summary>
        ''' <returns>Uri of the organization service or an empty string.</returns>
        Protected Overridable Function GetOrganizationAddress() As Uri
            Using serviceProxy As DiscoveryServiceProxy = GetDiscoveryProxy()
                ' Obtain organization information from the Discovery service. 
                If serviceProxy IsNot Nothing Then
                    ' Obtain information about the organizations that the system user belongs to.
                    Dim orgs As OrganizationDetailCollection = DiscoverOrganizations(serviceProxy)

                    If orgs.Count > 0 Then
                        Console.WriteLine(vbLf &amp; "List of organizations that you belong to:")
                        For n As Integer = 0 To orgs.Count - 1
                            Console.Write(vbLf &amp; "({0}) {1} ({2})" &amp; vbTab, n + 1, orgs(n).FriendlyName, orgs(n).UrlName)
                        Next n

                        Console.Write(vbLf &amp; vbLf &amp; "Specify an organization number (1-{0}) [1]: ", orgs.Count)
                        Dim input As String = Console.ReadLine()
                        If input = String.Empty Then
                            input = "1"
                        End If
                        Dim orgNumber As Integer
                        Int32.TryParse(input, orgNumber)
                        If orgNumber > 0 AndAlso orgNumber <= orgs.Count Then
                            config.OrganizationName = orgs(orgNumber - 1).FriendlyName
                            ' Return the organization Uri.
                            Return New Uri(orgs(orgNumber - 1).Endpoints(EndpointType.OrganizationService))
                        Else
                            Throw New InvalidOperationException("The specified organization does not exist.")
                        End If
                    Else
                        Console.WriteLine(vbLf &amp; "You do not belong to any organizations on the specified server.")
                        Return New Uri(String.Empty)
                    End If
                Else
                    Throw New InvalidOperationException("An invalid server name was specified.")
                End If
            End Using
        End Function

        ''' <summary>
        ''' Get the device credentials by either loading from the local cache 
        ''' or request new device credentials by registering the device.
        ''' </summary>
        ''' <returns>Device Credentials.</returns>
        Protected Overridable Function GetDeviceCredentials() As ClientCredentials
            Return Microsoft.Crm.Services.Utility.DeviceIdManager.LoadOrRegisterDevice()
        End Function

        ''' <summary>
        ''' Get the discovery service proxy based on existing configuration data.
        ''' Added new way of getting discovery proxy.
        ''' Also preserving old way of getting discovery proxy to support old scenarios.
        ''' </summary>
        ''' <returns>An instance of DiscoveryServiceProxy</returns>
        Private Function GetDiscoveryProxy() As DiscoveryServiceProxy
            Try
                ' Obtain the discovery service proxy.
                Dim discoveryProxy As DiscoveryServiceProxy =
                    GetProxy(Of IDiscoveryService, DiscoveryServiceProxy)(Me.config)
                ' Checking authentication by invoking some SDK methods.
                discoveryProxy.Execute(New RetrieveOrganizationsRequest())
                Return discoveryProxy
            Catch ex As System.ServiceModel.Security.SecurityAccessDeniedException
                ' If authentication failed using current UserPrincipalName, 
                ' request UserName and Password to try to authenticate using user credentials.
                If (Not String.IsNullOrWhiteSpace(config.UserPrincipalName)) AndAlso
                    ex.Message.Contains("Access is denied.") Then
                    config.AuthFailureCount = CShort(config.AuthFailureCount + 1)
                Else
                    Throw ex
                End If
            End Try
            ' You can also catch other exceptions to handle a specific situation in your code, for example, 
            '      System.ServiceModel.Security.ExpiredSecurityTokenException
            '      System.ServiceModel.Security.MessageSecurityException
            '      System.ServiceModel.Security.SecurityNegotiationException                

            ' Second trial to obtain the discovery service proxy in case of single sign-on failure.
            Return GetProxy(Of IDiscoveryService, DiscoveryServiceProxy)(Me.config)

        End Function

        ''' <summary>
        ''' Verify passed strings with the supported AuthenticationProviderType.
        ''' </summary>
        ''' <param name="authType">String AuthenticationType</param>
        ''' <returns>Supported AuthenticatoinProviderType</returns>
        Private Function RetrieveAuthenticationType(ByVal authType As String) As AuthenticationProviderType
            Select Case authType
                Case "ActiveDirectory"
                    Return AuthenticationProviderType.ActiveDirectory
                Case "LiveId"
                    Return AuthenticationProviderType.LiveId
                Case "Federation"
                    Return AuthenticationProviderType.Federation
                Case "OnlineFederation"
                    Return AuthenticationProviderType.OnlineFederation
                Case Else
                    Throw New ArgumentException(String.Format("{0} is not a valid authentication type", authType))
            End Select
        End Function

        ''' <summary>
        ''' Parse credentials from an XML node to required ClientCredentials data type 
        ''' based on passed AuthenticationProviderType.
        ''' </summary>
        ''' <param name="credentials">Credential XML node.</param>
        ''' <param name="endpointType">AuthenticationProviderType of the credential.</param>
        ''' <param name="target">Target is the key with which associated credentials can be fetched.</param>
        ''' <returns>Required ClientCredentials type.</returns>
        Private Function ParseInCredentials(ByVal credentials As XElement, ByVal endpointType As AuthenticationProviderType, ByVal target As String) As ClientCredentials
            Dim result As New ClientCredentials()
            If credentials.HasElements Then
                Dim cred As Credential = CredentialManager.ReadCredentials(target)
                Select Case endpointType
                    Case AuthenticationProviderType.ActiveDirectory
                        If Nothing IsNot cred AndAlso cred.UserName.Contains("\") Then
                            Dim domainAndUser() As String = cred.UserName.Split("\"c)
                            result.Windows.ClientCredential = New System.Net.NetworkCredential() With {.UserName = domainAndUser(1), .Domain = domainAndUser(0), .Password = cred.Password}
                        Else
                            result.Windows.ClientCredential = New System.Net.NetworkCredential() With {.UserName = credentials.Element("UserName").Value, .Domain = credentials.Element("Domain").Value}
                        End If
                    Case AuthenticationProviderType.LiveId, AuthenticationProviderType.Federation, AuthenticationProviderType.OnlineFederation
                        If Nothing IsNot cred Then
                            result.UserName.UserName = cred.UserName
                            result.UserName.Password = cred.Password
                        Else
                            result.UserName.UserName = credentials.Element("UserName").Value
                        End If
                    Case Else
                End Select
            Else
                Return Nothing
            End If

            Return result
        End Function

        ''' <summary>
        ''' Parse ClientCredentials into XML node. 
        ''' </summary>
        ''' <param name="clientCredentials_Renamed">ClientCredentials type.</param>
        ''' <param name="endpointType">AuthenticationProviderType of the credentials.</param>
        ''' <param name="target">Target is the key with which associated credentials can be fetched.</param>
        ''' <returns>XML node containing credentials data.</returns>
        Private Function ParseOutCredentials(ByVal clientCredentials_Renamed As ClientCredentials, ByVal endpointType As AuthenticationProviderType, ByVal target As String) As XElement
            If clientCredentials_Renamed IsNot Nothing Then
                Dim cred As Credential = CredentialManager.ReadCredentials(target)
                Select Case endpointType
                    Case AuthenticationProviderType.ActiveDirectory
                        If cred Is Nothing Then
                            ' Add entry in windows credential manager for future use.
                            If Not String.IsNullOrWhiteSpace(clientCredentials_Renamed.Windows.ClientCredential.Password) Then
                                CredentialManager.WriteCredentials(target, New Credential(clientCredentials_Renamed.Windows.ClientCredential.Domain &amp; "\" &amp; clientCredentials_Renamed.Windows.ClientCredential.UserName, clientCredentials_Renamed.Windows.ClientCredential.Password), True)
                            End If
                        Else
                            ' Replace if the password has been changed.
                            If Not clientCredentials_Renamed.Windows.ClientCredential.Password.Equals(cred.Password) Then
                                CredentialManager.DeleteCredentials(target, False)
                                CredentialManager.WriteCredentials(target, New Credential(clientCredentials_Renamed.Windows.ClientCredential.Domain &amp; "\" &amp; clientCredentials_Renamed.Windows.ClientCredential.UserName, clientCredentials_Renamed.Windows.ClientCredential.Password), True)
                            End If
                        End If
                        Return New XElement("Credentials", New XElement("UserName", clientCredentials_Renamed.Windows.ClientCredential.UserName), New XElement("Domain", clientCredentials_Renamed.Windows.ClientCredential.Domain))
                    Case AuthenticationProviderType.LiveId, AuthenticationProviderType.Federation, AuthenticationProviderType.OnlineFederation
                        If cred Is Nothing Then
                            ' Add entry in windows credential manager for future use.
                            If Not String.IsNullOrWhiteSpace(clientCredentials_Renamed.UserName.Password) Then
                                CredentialManager.WriteCredentials(target, New Credential(clientCredentials_Renamed.UserName.UserName, clientCredentials_Renamed.UserName.Password), True)
                            End If
                        Else
                            ' Replace if the password has been changed.
                            If Not clientCredentials_Renamed.UserName.Password.Equals(cred.Password) Then
                                CredentialManager.DeleteCredentials(target, False)
                                CredentialManager.WriteCredentials(target, New Credential(clientCredentials_Renamed.UserName.UserName, clientCredentials_Renamed.UserName.Password), True)
                            End If
                        End If
                        Return New XElement("Credentials", New XElement("UserName", clientCredentials_Renamed.UserName.UserName))
                    Case Else
                End Select
            End If

            Return New XElement("Credentials", "")
        End Function
#End Region ' Private methods

		#Region "Private Classes"
		''' <summary>
		''' private static class to store constants required by the CrmServiceHelper class.
		''' </summary>
		Private NotInheritable Class CrmServiceHelperConstants
			''' <summary>
			''' Credentials file path.
			''' </summary>
			Public Shared ReadOnly ServerCredentialsFile As String = Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "CrmServer"), "Credentials.xml")
		End Class
		#End Region        
	End Class
	#Region "Other Classes"
	
    Friend NotInheritable Class Credential
        Private _userName As SecureString
        Private _password As SecureString

        Friend Sub New(ByVal cred As CREDENTIAL_STRUCT)
            _userName = ConvertToSecureString(cred.userName)
            Dim size As Integer = CInt(cred.credentialBlobSize)
            If size <> 0 Then
                Dim bpassword(size - 1) As Byte
                Marshal.Copy(cred.credentialBlob, bpassword, 0, size)
                _password = ConvertToSecureString(Encoding.Unicode.GetString(bpassword))
            Else
                _password = ConvertToSecureString(String.Empty)
            End If
        End Sub

        Public Sub New(ByVal userName As String, ByVal password As String)
            If (String.IsNullOrWhiteSpace(userName)) Then
                Throw New ArgumentNullException("userName")
            End If

            If (String.IsNullOrWhiteSpace(password)) Then
                Throw New ArgumentNullException("password")
            End If

            _userName = ConvertToSecureString(userName)
            _password = ConvertToSecureString(password)
        End Sub

        Public ReadOnly Property UserName() As String
            Get
                Return ConvertToUnsecureString(_userName)
            End Get
        End Property

        Public ReadOnly Property Password() As String
            Get
                Return ConvertToUnsecureString(_password)
            End Get
        End Property

        ''' <summary>
        ''' This converts a SecureString password to plain text
        ''' </summary>
        ''' <param name="securePassword">SecureString password</param>
        ''' <returns>plain text password</returns>
        Private Function ConvertToUnsecureString(ByVal secret As SecureString) As String
            If secret Is Nothing Then
                Return String.Empty
            End If

            Dim unmanagedString As IntPtr = IntPtr.Zero
            Try
                unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(secret)
                Return Marshal.PtrToStringUni(unmanagedString)
            Finally
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString)
            End Try
        End Function

        ''' <summary>
        ''' This converts a string to SecureString
        ''' </summary>
        ''' <param name="password">plain text password</param>
        ''' <returns>SecureString password</returns>
        Private Function ConvertToSecureString(ByVal secret As String) As SecureString
            If String.IsNullOrEmpty(secret) Then
                Return Nothing
            End If

            Dim securePassword As New SecureString()
            Dim passwordChars() As Char = secret.ToCharArray()
            For Each pwdChar As Char In passwordChars
                securePassword.AppendChar(pwdChar)
            Next pwdChar
            securePassword.MakeReadOnly()
            Return securePassword
        End Function

        ''' <summary>
        ''' This structure maps to the CREDENTIAL structure used by native code. We can use this to marshal our values.
        ''' </summary>
		<StructLayout(LayoutKind.Sequential, CharSet := CharSet.Unicode)> _
        Friend Structure CREDENTIAL_STRUCT
            Public flags As UInt32
            Public type As UInt32
            Public targetName As String
            Public comment As String
            Public lastWritten As System.Runtime.InteropServices.ComTypes.FILETIME
            Public credentialBlobSize As UInt32
            Public credentialBlob As IntPtr
            Public persist As UInt32
            Public attributeCount As UInt32
            Public credAttribute As IntPtr
            Public targetAlias As String
            Public userName As String
        End Structure


    End Class

    ''' <summary>
    ''' This class exposes methods to read, write and delete user credentials
    ''' </summary>
    Friend NotInheritable Class CredentialManager
        ''' <summary>
        ''' Target Name against which all credentials are stored on the disk.
        ''' </summary>
        Public Const TargetName As String = "Microsoft_CRMSDK:"

        ''' <summary>
        ''' Cache containing secrets in-memory (used to improve performance and avoid IO operations).
        ''' </summary>
        Private Shared credentialCache As New Dictionary(Of String, Credential)()

        Private Sub New()
        End Sub
        Public Shared Function GetCredentialTarget(ByVal target As Uri) As Uri
            If target Is Nothing Then
                Throw New ArgumentNullException("target")
            End If

            Return New Uri(target.GetLeftPart(UriPartial.Authority))
        End Function

        Private Enum CRED_TYPE As Integer
            GENERIC = 1
            DOMAIN_PASSWORD = 2
            DOMAIN_CERTIFICATE = 3
            DOMAIN_VISIBLE_PASSWORD = 4
            MAXIMUM = 5
        End Enum

        Friend Enum CRED_PERSIST As UInteger
            SESSION = 1
            LOCAL_MACHINE = 2
            ENTERPRISE = 3
        End Enum

        Private NotInheritable Class NativeMethods
            <DllImport("advapi32.dll", SetLastError:=True, EntryPoint:="CredReadW", CharSet:=CharSet.Unicode)> _
            Public Shared Function CredRead(ByVal target As String, ByVal type As CRED_TYPE, ByVal reservedFlag As Integer, <System.Runtime.InteropServices.Out(), MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef:=GetType(CredentialMarshaler))> ByRef credential As Credential) As <MarshalAs(UnmanagedType.Bool)> Boolean
            End Function

            <DllImport("Advapi32.dll", SetLastError:=True, EntryPoint:="CredWriteW", CharSet:=CharSet.Unicode)> _
            Public Shared Function CredWrite(ByRef credential As Credential.CREDENTIAL_STRUCT, ByVal flags As UInt32) As <MarshalAs(UnmanagedType.Bool)> Boolean
            End Function

            <DllImport("Advapi32.dll", EntryPoint:="CredFree", SetLastError:=True)> _
            Public Shared Function CredFree(ByVal cred As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
            End Function

            <DllImport("advapi32.dll", EntryPoint:="CredDeleteW", CharSet:=CharSet.Unicode)> _
            Public Shared Function CredDelete(ByVal target As String, ByVal type As Integer, ByVal flags As Integer) As <MarshalAs(UnmanagedType.Bool)> Boolean
            End Function
        End Class

        Private NotInheritable Class CredentialMarshaler
            Implements ICustomMarshaler
            Private Shared _instance As CredentialMarshaler

            Public Sub CleanUpManagedData(ByVal ManagedObj As Object) Implements ICustomMarshaler.CleanUpManagedData
                ' Nothing to do since all data can be garbage collected.
            End Sub

            Public Sub CleanUpNativeData(ByVal pNativeData As IntPtr) Implements ICustomMarshaler.CleanUpNativeData
                If pNativeData = IntPtr.Zero Then
                    Return
                End If
                NativeMethods.CredFree(pNativeData)
            End Sub

            Public Function GetNativeDataSize() As Integer Implements ICustomMarshaler.GetNativeDataSize
                Throw New NotImplementedException("The method or operation is not implemented.")
            End Function

            Public Function MarshalManagedToNative(ByVal obj As Object) As IntPtr Implements ICustomMarshaler.MarshalManagedToNative
                Throw New NotImplementedException("Not implemented yet")
            End Function

            Public Function MarshalNativeToManaged(ByVal pNativeData As IntPtr) As Object Implements ICustomMarshaler.MarshalNativeToManaged
                If pNativeData = IntPtr.Zero Then
                    Return Nothing
                End If
                Return New Credential(CType(Marshal.PtrToStructure(pNativeData, GetType(Credential.CREDENTIAL_STRUCT)), Credential.CREDENTIAL_STRUCT))
            End Function


            Public Shared Function GetInstance(ByVal cookie As String) As ICustomMarshaler
                If Nothing Is _instance Then
                    _instance = New CredentialMarshaler()
                End If
                Return _instance
            End Function
        End Class

        Public Shared Function ReadCredentials(ByVal target As String) As Credential
            Dim cachedCredential As Credential = Nothing

            ' Try to read the username from cache
            If credentialCache.TryGetValue(TargetName &amp; target, cachedCredential) Then
                Return cachedCredential
            End If

            Dim credential_Renamed As Credential = Nothing
	    Dim bSuccess As Boolean = NativeMethods.CredRead(TargetName &amp; target, CRED_TYPE.GENERIC, 0, credential_Renamed)
            ' No match found.
            If Not bSuccess Then
                Return Nothing
            End If

            credentialCache(TargetName &amp; target.ToString()) = credential_Renamed
            Return credential_Renamed
        End Function

        Public Shared Function ReadWindowsCredential(ByVal target As Uri) As Credential
            Dim credential_Renamed As Credential = Nothing
            Dim bSuccess As Boolean = NativeMethods.CredRead(target.Host, CRED_TYPE.DOMAIN_PASSWORD, 0, credential_Renamed)
            If Not bSuccess Then
                Throw New InvalidOperationException("Unable to read windows credentials for Uri {0}. ErrorCode {1}",
                                    New System.ComponentModel.Win32Exception(Marshal.GetLastWin32Error()))
            End If
			Return credential_Renamed
        End Function
        ''' <summary>
        ''' Fetches the credentials.
        ''' </summary>
        ''' <param name="target">Target is the key with which associated credentials can be fetched</param>
        ''' <param name="userCredentials">It is the in parameter which contains the username and password</param>
        ''' <param name="allowPhysicalStore">If allowPhysicalStore is true then the credentials are stored on disk</param>
        Public Shared Sub WriteCredentials(ByVal target As String, ByVal userCredentials As Credential, ByVal allowPhysicalStore As Boolean)
            If String.IsNullOrWhiteSpace(target) Then
                Throw New ArgumentNullException("target")
            End If
            If userCredentials Is Nothing Then
                Throw New ArgumentNullException("userCredentials")
            End If
            If allowPhysicalStore = Nothing Then
                Throw New ArgumentNullException("allowPhysicalStore")
            End If
            ' Cache the username and password in memory
            credentialCache(TargetName &amp; target) = userCredentials

            ' Store the credentials if allowed
            Dim passwordToStore As String = If(allowPhysicalStore, userCredentials.Password, String.Empty)
            Dim credential As New Credential.CREDENTIAL_STRUCT()
            Try
                credential.targetName = TargetName &amp; target
                credential.type = CUInt(CRED_TYPE.GENERIC)
                credential.userName = userCredentials.UserName
                credential.attributeCount = 0
                credential.persist = CUInt(CRED_PERSIST.LOCAL_MACHINE)
                Dim bpassword() As Byte = Encoding.Unicode.GetBytes(passwordToStore)
                credential.credentialBlobSize = CUInt(bpassword.Length)
                credential.credentialBlob = Marshal.AllocCoTaskMem(bpassword.Length)
                Marshal.Copy(bpassword, 0, credential.credentialBlob, bpassword.Length)
                If Not NativeMethods.CredWrite(credential, 0) Then
                    Throw New System.ComponentModel.Win32Exception(Marshal.GetLastWin32Error())
                End If
            Finally
                If IntPtr.Zero <> credential.credentialBlob Then
                    Marshal.FreeCoTaskMem(credential.credentialBlob)
                End If
            End Try
        End Sub

        ''' <summary>
        ''' Deletes the credentials.
        ''' </summary>
        ''' <param name="target">Target is the key with which associated credentials can be fetched</param>
        ''' <param name="softDelete">If a softDelete is done then credentials are deleted only from memory. 
        ''' They are completely removed otherwise.</param>
        Public Shared Sub DeleteCredentials(ByVal target As String, ByVal softDelete As Boolean)
			If String.IsNullOrWhiteSpace(target) Then
				Throw New ArgumentNullException("target")
			End If
            If Nothing = softDelete Then
                Throw New ArgumentNullException("softDelete")
            End If
            If softDelete Then
                ' Removes only the password
                Try
                    Dim tempCredential As Credential = ReadCredentials(target)
                    WriteCredentials(target, New Credential(tempCredential.UserName, String.Empty), True)
                Catch e1 As Exception
                    ' Do nothing
                End Try
            Else
                ' Removes the entry completely
                NativeMethods.CredDelete(TargetName &amp; target, CInt(CRED_TYPE.GENERIC), 0)
                credentialCache.Remove(TargetName &amp; target)
            End If
        End Sub
    End Class

    ''' <summary>
    ''' Wrapper class for DiscoveryServiceProxy to support auto refresh security token.
    ''' </summary>
    Friend NotInheritable Class ManagedTokenDiscoveryServiceProxy
        Inherits DiscoveryServiceProxy
        Private _proxyManager As AutoRefreshSecurityToken(Of DiscoveryServiceProxy, IDiscoveryService)

        Public Sub New(ByVal serviceUri As Uri, ByVal userCredentials As ClientCredentials)
            MyBase.New(serviceUri, Nothing, userCredentials, Nothing)
            Me._proxyManager = New AutoRefreshSecurityToken(Of DiscoveryServiceProxy, IDiscoveryService)(Me)
        End Sub

        Public Sub New(ByVal serviceManagement As IServiceManagement(Of IDiscoveryService), ByVal securityTokenRes As SecurityTokenResponse)
            MyBase.New(serviceManagement, securityTokenRes)
            Me._proxyManager = New AutoRefreshSecurityToken(Of DiscoveryServiceProxy, IDiscoveryService)(Me)
        End Sub

        Public Sub New(ByVal serviceManagement As IServiceManagement(Of IDiscoveryService), ByVal userCredentials As ClientCredentials)
            MyBase.New(serviceManagement, userCredentials)
            Me._proxyManager = New AutoRefreshSecurityToken(Of DiscoveryServiceProxy, IDiscoveryService)(Me)
        End Sub

        Protected Overrides Function AuthenticateDeviceCore() As SecurityTokenResponse
            Return Me._proxyManager.AuthenticateDevice()
        End Function

        Protected Overrides Sub AuthenticateCore()
            Me._proxyManager.PrepareCredentials()
            MyBase.AuthenticateCore()
        End Sub

        Protected Overrides Sub ValidateAuthentication()
            Me._proxyManager.RenewTokenIfRequired()
            MyBase.ValidateAuthentication()
        End Sub
    End Class

    ''' <summary>
    ''' Wrapper class for OrganizationServiceProxy to support auto refresh security token
    ''' </summary>
    Friend NotInheritable Class ManagedTokenOrganizationServiceProxy
        Inherits OrganizationServiceProxy
        Private _proxyManager As AutoRefreshSecurityToken(Of OrganizationServiceProxy, IOrganizationService)

        Public Sub New(ByVal serviceUri As Uri, ByVal userCredentials As ClientCredentials)
            MyBase.New(serviceUri, Nothing, userCredentials, Nothing)
            Me._proxyManager = New AutoRefreshSecurityToken(Of OrganizationServiceProxy, IOrganizationService)(Me)
        End Sub

        Public Sub New(ByVal serviceManagement As IServiceManagement(Of IOrganizationService), ByVal securityTokenRes As SecurityTokenResponse)
            MyBase.New(serviceManagement, securityTokenRes)
            Me._proxyManager = New AutoRefreshSecurityToken(Of OrganizationServiceProxy, IOrganizationService)(Me)
        End Sub

        Public Sub New(ByVal serviceManagement As IServiceManagement(Of IOrganizationService), ByVal userCredentials As ClientCredentials)
            MyBase.New(serviceManagement, userCredentials)
            Me._proxyManager = New AutoRefreshSecurityToken(Of OrganizationServiceProxy, IOrganizationService)(Me)
        End Sub

        Protected Overrides Function AuthenticateDeviceCore() As SecurityTokenResponse
            Return Me._proxyManager.AuthenticateDevice()
        End Function

        Protected Overrides Sub AuthenticateCore()
            Me._proxyManager.PrepareCredentials()
            MyBase.AuthenticateCore()
        End Sub

        Protected Overrides Sub ValidateAuthentication()
            Me._proxyManager.RenewTokenIfRequired()
            MyBase.ValidateAuthentication()
        End Sub
    End Class

    ''' <summary>
    ''' Class that wraps acquiring the security token for a service
    ''' </summary>
    Public NotInheritable Class AutoRefreshSecurityToken(Of TProxy As ServiceProxy(Of TService), TService As Class)
        Private _deviceCredentials As ClientCredentials
        Private _proxy As TProxy

        ''' <summary>
        ''' Instantiates an instance of the proxy class
        ''' </summary>
        ''' <param name="proxy">Proxy that will be used to authenticate the user</param>
        Public Sub New(ByVal proxy As TProxy)
            If Nothing Is proxy Then
                Throw New ArgumentNullException("proxy")
            End If

            Me._proxy = proxy
        End Sub

        ''' <summary>
        ''' Prepares authentication before authen6ticated
        ''' </summary>
        Public Sub PrepareCredentials()
            If Nothing Is Me._proxy.ClientCredentials Then
                Return
            End If

            Select Case Me._proxy.ServiceConfiguration.AuthenticationType
                Case AuthenticationProviderType.ActiveDirectory
                    Me._proxy.ClientCredentials.UserName.UserName = Nothing
                    Me._proxy.ClientCredentials.UserName.Password = Nothing
                Case AuthenticationProviderType.Federation, AuthenticationProviderType.LiveId
                    Me._proxy.ClientCredentials.Windows.ClientCredential = Nothing
                Case Else
                    Return
            End Select
        End Sub

        ''' <summary>
        ''' Authenticates the device token
        ''' </summary>
        ''' <returns>Generated SecurityTokenResponse for the device</returns>
        Public Function AuthenticateDevice() As SecurityTokenResponse
            If Nothing Is Me._deviceCredentials Then
                Me._deviceCredentials = DeviceIdManager.LoadOrRegisterDevice(Me._proxy.ServiceConfiguration.CurrentIssuer.IssuerAddress.Uri)
            End If

            Return Me._proxy.ServiceConfiguration.AuthenticateDevice(Me._deviceCredentials)
        End Function

        ''' <summary>
        ''' Renews the token (if it is near expiration or has expired)
        ''' </summary>
        Public Sub RenewTokenIfRequired()
            If Nothing IsNot Me._proxy.SecurityTokenResponse AndAlso Date.UtcNow.AddMinutes(15) >= Me._proxy.SecurityTokenResponse.Response.Lifetime.Expires Then
                Try
                    Me._proxy.Authenticate()
                Catch e1 As CommunicationException
                    If Nothing Is Me._proxy.SecurityTokenResponse OrElse Date.UtcNow >= Me._proxy.SecurityTokenResponse.Response.Lifetime.Expires Then
                        Throw
                    End If

                    ' Ignore the exception 
                End Try
            End If
        End Sub
    End Class
#End Region
End Namespace

' </snippetcrmservicehelper>
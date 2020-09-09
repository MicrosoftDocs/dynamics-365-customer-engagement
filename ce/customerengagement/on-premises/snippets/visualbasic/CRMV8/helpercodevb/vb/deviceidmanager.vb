' <snippetdeviceidmanager>


Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics.CodeAnalysis
Imports System.Globalization
Imports System.IO
Imports System.Net
Imports System.Runtime.Serialization
Imports System.Security.Cryptography
Imports System.ServiceModel.Description
Imports System.Text
Imports System.Xml
Imports System.Xml.Serialization

Namespace Microsoft.Crm.Services.Utility
    ''' <summary>
    ''' Management utility for the Device Id
    ''' </summary>
    Public NotInheritable Class DeviceIdManager
        #Region "Fields"
        Private Shared ReadOnly RandomInstance As New Random()

        Public Const MaxDeviceNameLength As Integer = 24
        Public Const MaxDevicePasswordLength As Integer = 24
        #End Region

        #Region "Constructor"
        Private Sub New()
        End Sub
        Shared Sub New()
            PersistToFile = True
        End Sub
        #End Region

        #Region "Properties"
        ''' <summary>
        ''' Indicates whether the registered device credentials should be persisted to the database
        ''' </summary>
        Public Shared Property PersistToFile() As Boolean

		''' <summary>
		''' Indicates that the credentials should be persisted to the disk if registration fails with DeviceAlreadyExists.
		''' </summary>
		''' <remarks>
		''' If the device already exists, there is a possibility that the credentials are the same as the current credentials that
		''' are being registered. This is especially true in automated environments where the same credentials are used continually (to avoid
		''' registering spurious device credentials.
		''' </remarks>
		Public Shared Property PersistIfDeviceAlreadyExists() As Boolean
        #End Region

        #Region "Methods"
        ''' <summary>
        ''' Loads the device credentials (if they exist).
        ''' </summary>
        ''' <returns></returns>
        Public Shared Function LoadOrRegisterDevice() As ClientCredentials
            Return LoadOrRegisterDevice(Nothing)
        End Function

        ''' <summary>
        ''' Loads the device credentials (if they exist).
        ''' </summary>
        ''' <param name="deviceName">Device name that should be registered</param>
        ''' <param name="devicePassword">Device password that should be registered</param>
        Public Shared Function LoadOrRegisterDevice(ByVal deviceName As String, ByVal devicePassword As String) As ClientCredentials
            Return LoadOrRegisterDevice(Nothing, deviceName, devicePassword)
        End Function

        ''' <summary>
        ''' Loads the device credentials (if they exist).
        ''' </summary>
        ''' <param name="issuerUri">URL for the current token issuer</param>
        ''' <remarks>
        ''' The issuerUri can be retrieved from the IServiceConfiguration interface's CurrentIssuer property.
        ''' </remarks>
        Public Shared Function LoadOrRegisterDevice(ByVal issuerUri As Uri) As ClientCredentials
            Return LoadOrRegisterDevice(issuerUri, Nothing, Nothing)
        End Function

        ''' <summary>
        ''' Loads the device credentials (if they exist).
        ''' </summary>
        ''' <param name="issuerUri">URL for the current token issuer</param>
        ''' <param name="deviceName">Device name that should be registered</param>
        ''' <param name="devicePassword">Device password that should be registered</param>
        ''' <remarks>
        ''' The issuerUri can be retrieved from the IServiceConfiguration interface's CurrentIssuer property.
        ''' </remarks>
        Public Shared Function LoadOrRegisterDevice(ByVal issuerUri As Uri, ByVal deviceName As String, ByVal devicePassword As String) _
               As ClientCredentials
            Dim credentials As ClientCredentials = LoadDeviceCredentials(issuerUri)
            If Nothing Is credentials Then
                credentials = RegisterDevice(Guid.NewGuid(), issuerUri, deviceName, devicePassword)
            End If

            Return credentials
        End Function

        ''' <summary>
        ''' Registers the given device with Microsoft account with a random application ID
        ''' </summary>
        ''' <returns>ClientCredentials that were registered</returns>
        Public Shared Function RegisterDevice() As ClientCredentials
            Return RegisterDevice(Guid.NewGuid())
        End Function

        ''' <summary>
        ''' Registers the given device with Microsoft account
        ''' </summary>
        ''' <param name="applicationId">ID for the application</param>
        ''' <returns>ClientCredentials that were registered</returns>
        Public Shared Function RegisterDevice(ByVal applicationId As Guid) As ClientCredentials
            Return RegisterDevice(applicationId, CType(Nothing, Uri))
        End Function

        ''' <summary>
        ''' Registers the given device with Microsoft account
        ''' </summary>
        ''' <param name="applicationId">ID for the application</param>
        ''' <param name="issuerUri">URL for the current token issuer</param>
        ''' <returns>ClientCredentials that were registered</returns>
        ''' <remarks>
        ''' The issuerUri can be retrieved from the IServiceConfiguration interface's CurrentIssuer property.
        ''' </remarks>
        Public Shared Function RegisterDevice(ByVal applicationId As Guid, ByVal issuerUri As Uri) As ClientCredentials
            Return RegisterDevice(applicationId, issuerUri, Nothing, Nothing)
        End Function

        ''' <summary>
        ''' Registers the given device with Microsoft account
        ''' </summary>
        ''' <param name="applicationId">ID for the application</param>
        ''' <param name="deviceName">Device name that should be registered</param>
        ''' <param name="devicePassword">Device password that should be registered</param>
        ''' <returns>ClientCredentials that were registered</returns>
        Public Shared Function RegisterDevice(ByVal applicationId As Guid, ByVal deviceName As String, ByVal devicePassword As String) _
               As ClientCredentials
            Return RegisterDevice(applicationId, CType(Nothing, Uri), deviceName, devicePassword)
        End Function

        ''' <summary>
        ''' Registers the given device with Microsoft account
        ''' </summary>
        ''' <param name="applicationId">ID for the application</param>
        ''' <param name="issuerUri">URL for the current token issuer</param>
        ''' <param name="deviceName">Device name that should be registered</param>
        ''' <param name="devicePassword">Device password that should be registered</param>
        ''' <returns>ClientCredentials that were registered</returns>
        ''' <remarks>
        ''' The issuerUri can be retrieved from the IServiceConfiguration interface's CurrentIssuer property.
        ''' </remarks>
        Public Shared Function RegisterDevice(ByVal applicationId As Guid, ByVal issuerUri As Uri, ByVal deviceName As String, _
                                              ByVal devicePassword As String) As ClientCredentials
            If String.IsNullOrEmpty(deviceName) AndAlso (Not PersistToFile) Then
                Throw New ArgumentNullException("deviceName", "If PersistToFile is false, then deviceName must be specified.")
            ElseIf String.IsNullOrEmpty(deviceName) <> String.IsNullOrEmpty(devicePassword) Then
                Throw New ArgumentNullException("deviceName", _
                                                "Either deviceName/devicePassword should both be specified or they should be null.")
            End If

			Dim device As LiveDevice = GenerateDevice(deviceName, devicePassword)
			Return RegisterDevice(applicationId, issuerUri, device)
        End Function

        ''' <summary>
        ''' Loads the device's credentials from the file system
        ''' </summary>
        ''' <returns>Device Credentials (if set) or null</returns>
        Public Shared Function LoadDeviceCredentials() As ClientCredentials
            Return LoadDeviceCredentials(Nothing)
        End Function

        ''' <summary>
        ''' Loads the device's credentials from the file system
        ''' </summary>
        ''' <param name="issuerUri">URL for the current token issuer</param>
        ''' <returns>Device Credentials (if set) or null</returns>
        ''' <remarks>
        ''' The issuerUri can be retrieved from the IServiceConfiguration interface's CurrentIssuer property.
        ''' </remarks>
        Public Shared Function LoadDeviceCredentials(ByVal issuerUri As Uri) As ClientCredentials
            'If the credentials should not be persisted to a file, then they won't be present on the disk.
            If Not PersistToFile Then
                Return Nothing
            End If

			Dim environment As EnvironmentConfiguration = DiscoverEnvironmentInternal(issuerUri)

            Dim device As LiveDevice = ReadExistingDevice(environment)
            If Nothing Is device OrElse Nothing Is device.User Then
                Return Nothing
            End If

            Return device.User.ToClientCredentials()
        End Function

        ''' <summary>
        ''' Discovers the Windows Live environment based on the Token Issuer
        ''' </summary>
        Public Shared Function DiscoverEnvironment(ByVal issuerUri As Uri) As String
			Return DiscoverEnvironmentInternal(issuerUri).Environment
		End Function
		#End Region

		#Region "Private Methods"
		Private Shared Function DiscoverEnvironmentInternal(ByVal issuerUri As Uri) As EnvironmentConfiguration
            If Nothing Is issuerUri Then
				Return New EnvironmentConfiguration(EnvironmentType.LiveDeviceID, "login.live.com", Nothing)
            End If

			Dim searchList As New Dictionary(Of EnvironmentType, String)()
			searchList.Add(EnvironmentType.LiveDeviceID, "login.live")
			searchList.Add(EnvironmentType.OrgDeviceID, "login.microsoftonline")

			For Each searchPair As KeyValuePair(Of EnvironmentType, String) In searchList
				If issuerUri.Host.Length > searchPair.Value.Length AndAlso issuerUri.Host.StartsWith(searchPair.Value, StringComparison.OrdinalIgnoreCase) Then
					Dim environment As String = issuerUri.Host.Substring(searchPair.Value.Length)

					'Parse out the environment
                If "-"c = environment.Chars(0) Then
                    Dim separatorIndex As Integer = environment.IndexOf("."c, 1)
                    If -1 <> separatorIndex Then
							environment = environment.Substring(1, separatorIndex - 1)
						Else
							environment = Nothing
						End If
					Else
						environment = Nothing
					End If

					Return New EnvironmentConfiguration(searchPair.Key, issuerUri.Host, environment)
				End If
			Next searchPair

            'In all other cases the environment is either not applicable or it is a production system
			Return New EnvironmentConfiguration(EnvironmentType.LiveDeviceID, issuerUri.Host, Nothing)
        End Function

        Private Shared Sub Serialize(Of T)(ByVal stream As Stream, ByVal value As T)
            Dim serializer As New XmlSerializer(GetType(T), String.Empty)

            Dim xmlNamespaces As New XmlSerializerNamespaces()
            xmlNamespaces.Add(String.Empty, String.Empty)

            serializer.Serialize(stream, value, xmlNamespaces)
        End Sub

		Private Shared Function Deserialize(Of T)(ByVal operationName As String, ByVal stream As Stream) As T
			'Read the XML into memory so that the data can be used in an exception if necessary
			Using reader As New StreamReader(stream)
				Return Deserialize(Of T)(operationName, reader.ReadToEnd())
			End Using
		End Function

		Private Shared Function Deserialize(Of T)(ByVal operationName As String, ByVal xml As String) As T
			'Attempt to deserialize the data. If deserialization fails, include the XML in the exception that is thrown for further
			'investigation
			Using reader As New StringReader(xml)
				Try
					Dim serializer As New XmlSerializer(GetType(T), String.Empty)
					Return CType(serializer.Deserialize(reader), T)
				Catch ex As InvalidOperationException
					Throw New InvalidOperationException(String.Format(CultureInfo.InvariantCulture, "Unable to Deserialize XML (Operation = {0}):{1}{2}", operationName, Environment.NewLine, xml), ex)
				End Try
			End Using
        End Function

		Private Shared Function GetDeviceFile(ByVal environment As EnvironmentConfiguration) As FileInfo
			Return New FileInfo(String.Format(CultureInfo.InvariantCulture, LiveIdConstants.FileNameFormat, environment.Type,If(String.IsNullOrEmpty(environment.Environment), Nothing, "-" &amp; environment.Environment.ToUpperInvariant())))
		End Function

		Private Shared Function RegisterDevice(ByVal applicationId As Guid, ByVal issuerUri As Uri, ByVal device As LiveDevice) As ClientCredentials
			Dim environment As EnvironmentConfiguration = DiscoverEnvironmentInternal(issuerUri)

            Dim request As New DeviceRegistrationRequest(applicationId, device)

			Dim url As String = String.Format(CultureInfo.InvariantCulture, LiveIdConstants.RegistrationEndpointUriFormat, environment.HostName)

            Dim response As DeviceRegistrationResponse = ExecuteRegistrationRequest(url, request)
            If Not response.IsSuccess Then
				Dim throwException As Boolean = True
				If DeviceRegistrationErrorCode.DeviceAlreadyExists = response.Error.RegistrationErrorCode Then
					If Not PersistToFile Then
						'If the file is not persisted, the registration will always occur (since the credentials are not
						'persisted to the disk. However, the credentials may already exist. To avoid an exception being continually
						'processed by the calling user, DeviceAlreadyExists will be ignored if the credentials are not persisted to the disk.
						Return device.User.ToClientCredentials()
					ElseIf PersistIfDeviceAlreadyExists Then
						' This flag indicates that the 
						throwException = False
					End If
                End If

				If throwException Then
					Throw New DeviceRegistrationFailedException(response.Error.RegistrationErrorCode, response.ErrorSubCode)
				End If
			End If

			If PersistToFile OrElse PersistIfDeviceAlreadyExists Then
                WriteDevice(environment, device)
            End If

            Return device.User.ToClientCredentials()
        End Function

		Private Shared Function GenerateDevice(ByVal deviceName As String, ByVal devicePassword As String) As LiveDevice
			' If the deviceName hasn't been specified, it should be generated using random characters.
			Dim userNameCredentials As DeviceUserName
			If String.IsNullOrEmpty(deviceName) Then
				userNameCredentials = GenerateDeviceUserName()
			Else
				userNameCredentials = New DeviceUserName() With {.DeviceName = deviceName, .DecryptedPassword = devicePassword}
			End If

			Return New LiveDevice() With {.User = userNameCredentials, .Version = 1}
		End Function

		Private Shared Function ReadExistingDevice(ByVal environment As EnvironmentConfiguration) As LiveDevice
            'Retrieve the file info
            Dim file As FileInfo = GetDeviceFile(environment)
            If Not file.Exists Then
                Return Nothing
            End If

            Using stream As FileStream = file.Open(FileMode.Open, FileAccess.Read, FileShare.Read)
				Return Deserialize(Of LiveDevice)("Loading Device Credentials from Disk", stream)
            End Using
        End Function

		Private Shared Sub WriteDevice(ByVal environment As EnvironmentConfiguration, ByVal device As LiveDevice)
            Dim file As FileInfo = GetDeviceFile(environment)
            If Not file.Directory.Exists Then
                file.Directory.Create()
            End If

            Using stream As FileStream = file.Open(FileMode.CreateNew, FileAccess.Write, FileShare.None)
                Serialize(stream, device)
            End Using
        End Sub

        Private Shared Function ExecuteRegistrationRequest(ByVal url As String, ByVal registrationRequest As DeviceRegistrationRequest) _
               As DeviceRegistrationResponse
            'Create the request that will submit the request to the server
            Dim request As WebRequest = WebRequest.Create(url)
            request.ContentType = "application/soap+xml; charset=UTF-8"
            request.Method = "POST"
            request.Timeout = 180000

            'Write the envelope to the RequestStream
            Using stream As Stream = request.GetRequestStream()
                Serialize(stream, registrationRequest)
            End Using

            ' Read the response into an XmlDocument and return that doc
            Try
                Using response As WebResponse = request.GetResponse()
                    Using stream As Stream = response.GetResponseStream()
						Return Deserialize(Of DeviceRegistrationResponse)("Deserializing Registration Response", stream)
                    End Using
                End Using
            Catch ex As WebException
				System.Diagnostics.Trace.TraceError("Live ID Device Registration Failed (HTTP Code: {0}): {1}", ex.Status, ex.Message)
                If Nothing IsNot ex.Response Then
                    Using stream As Stream = ex.Response.GetResponseStream()
						Return Deserialize(Of DeviceRegistrationResponse)("Deserializing Failed Registration Response", stream)
                    End Using
                End If

                Throw
            End Try
        End Function

        Private Shared Function GenerateDeviceUserName() As DeviceUserName
            Dim userName As New DeviceUserName()
            userName.DeviceName = GenerateRandomString(LiveIdConstants.ValidDeviceNameCharacters, MaxDeviceNameLength)
            userName.DecryptedPassword = GenerateRandomString(LiveIdConstants.ValidDevicePasswordCharacters, MaxDevicePasswordLength)

            Return userName
        End Function

        Private Shared Function GenerateRandomString(ByVal characterSet As String, ByVal count As Integer) As String
            'Create an array of the characters that will hold the final list of random characters
            Dim value(count - 1) As Char

            'Convert the character set to an array that can be randomly accessed
            Dim [set]() As Char = characterSet.ToCharArray()

            SyncLock RandomInstance
                'Populate the array with random characters from the character set
                For i As Integer = 0 To count - 1
                    value(i) = [set](RandomInstance.Next(0, [set].Length))
                Next i
            End SyncLock

            Return New String(value)
        End Function
        #End Region

        #Region "Private Classes"
		Private Enum EnvironmentType
			LiveDeviceID
			OrgDeviceID
		End Enum

		Private NotInheritable Class EnvironmentConfiguration
			Public Sub New(ByVal type As EnvironmentType, ByVal hostName As String, ByVal environment As String)
				If String.IsNullOrWhiteSpace(hostName) Then
					Throw New ArgumentNullException("hostName")
				End If

				Me.Type = type
				Me.HostName = hostName
				Me.Environment = environment
			End Sub

			#Region "Properties"
			Private privateType As EnvironmentType
			Public Property Type() As EnvironmentType
				Get
					Return privateType
				End Get
				Private Set(ByVal value As EnvironmentType)
					privateType = value
				End Set
			End Property

			Private privateHostName As String
			Public Property HostName() As String
				Get
					Return privateHostName
				End Get
				Private Set(ByVal value As String)
					privateHostName = value
				End Set
			End Property

			Private privateEnvironment As String
			Public Property Environment() As String
				Get
					Return privateEnvironment
				End Get
				Private Set(ByVal value As String)
					privateEnvironment = value
				End Set
			End Property
			#End Region
		End Class

		Private NotInheritable Class LiveIdConstants
			Public Const RegistrationEndpointUriFormat As String = "https://{0}/ppsecure/DeviceAddCredential.srf"

			Public Shared ReadOnly FileNameFormat As String = Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "LiveDeviceID"), "{0}{1}.xml")

            Public Const ValidDeviceNameCharacters As String = "0123456789abcdefghijklmnopqrstuvqxyz"

            'Consists of the list of characters specified in the documentation
            Public Const ValidDevicePasswordCharacters As String = _
                "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^*()-_=+;,./?`~"
        End Class
        #End Region
    End Class

    #Region "Public Classes &amp; Enums"
    ''' <summary>
    ''' Indicates an error during registration
    ''' </summary>
    Public Enum DeviceRegistrationErrorCode
        ''' <summary>
        ''' Unspecified or Unknown Error occurred
        ''' </summary>
        Unknown = 0

        ''' <summary>
        ''' Interface Disabled
        ''' </summary>
        InterfaceDisabled = 1

        ''' <summary>
        ''' Invalid Request Format
        ''' </summary>
        InvalidRequestFormat = 3

        ''' <summary>
        ''' Unknown Client Version
        ''' </summary>
        UnknownClientVersion = 4

        ''' <summary>
        ''' Blank Password
        ''' </summary>
        BlankPassword = 6

        ''' <summary>
        ''' Missing Device User Name or Password
        ''' </summary>
        MissingDeviceUserNameOrPassword = 7

        ''' <summary>
        ''' Invalid Parameter Syntax
        ''' </summary>
        InvalidParameterSyntax = 8

        ''' <summary>
        ''' Invalid Characters are used in the device credentials.
        ''' </summary>
        InvalidCharactersInCredentials = 9

        ''' <summary>
        ''' Internal Error
        ''' </summary>
        InternalError = 11

        ''' <summary>
        ''' Device Already Exists
        ''' </summary>
        DeviceAlreadyExists = 13
    End Enum

    ''' <summary>
    ''' Indicates that Device Registration failed
    ''' </summary>
    <Serializable> _
    Public NotInheritable Class DeviceRegistrationFailedException
        Inherits Exception
        ''' <summary>
        ''' Construct an instance of the DeviceRegistrationFailedException class
        ''' </summary>
        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' Construct an instance of the DeviceRegistrationFailedException class
        ''' </summary>
        ''' <param name="message">Message to pass</param>
        Public Sub New(ByVal message As String)
            MyBase.New(message)
        End Sub

        ''' <summary>
        ''' Construct an instance of the DeviceRegistrationFailedException class
        ''' </summary>
        ''' <param name="message">Message to pass</param>
        ''' <param name="innerException">Exception to include</param>
        Public Sub New(ByVal message As String, ByVal innerException As Exception)
            MyBase.New(message, innerException)
        End Sub

        ''' <summary>
        ''' Construct an instance of the DeviceRegistrationFailedException class
        ''' </summary>
        ''' <param name="code">Error code that occurred</param>
        ''' <param name="subCode">Subcode that occurred</param>
        Public Sub New(ByVal code As DeviceRegistrationErrorCode, ByVal subCode As String)
            Me.New(code, subCode, Nothing)
        End Sub

        ''' <summary>
        ''' Construct an instance of the DeviceRegistrationFailedException class
        ''' </summary>
        ''' <param name="code">Error code that occurred</param>
        ''' <param name="subCode">Subcode that occurred</param>
        ''' <param name="innerException">Inner exception</param>
        Public Sub New(ByVal code As DeviceRegistrationErrorCode, ByVal subCode As String, ByVal innerException As Exception)
            MyBase.New(String.Concat(code.ToString(), ": ", subCode), innerException)
            Me.RegistrationErrorCode = code
        End Sub

        ''' <summary>
        ''' Construct an instance of the DeviceRegistrationFailedException class
        ''' </summary>
        ''' <param name="si"></param>
        ''' <param name="sc"></param>
        Private Sub New(ByVal si As SerializationInfo, ByVal sc As StreamingContext)
            MyBase.New(si, sc)
        End Sub

        #Region "Properties"
        ''' <summary>
        ''' Error code that occurred during registration
        ''' </summary>
        Private privateRegistrationErrorCode As DeviceRegistrationErrorCode
        Public Property RegistrationErrorCode() As DeviceRegistrationErrorCode
            Get
                Return privateRegistrationErrorCode
            End Get
            Private Set(ByVal value As DeviceRegistrationErrorCode)
                privateRegistrationErrorCode = value
            End Set
        End Property
        #End Region

        #Region "Methods"
        Public Overrides Sub GetObjectData(ByVal info As SerializationInfo, ByVal context As StreamingContext)
            MyBase.GetObjectData(info, context)
        End Sub
        #End Region
    End Class

    #Region "Serialization Classes"
    #Region "DeviceRegistrationRequest Class"
    <EditorBrowsable(EditorBrowsableState.Never), XmlRoot("DeviceAddRequest")> _
    Public NotInheritable Class DeviceRegistrationRequest
        #Region "Constructors"
        Public Sub New()
        End Sub

        Public Sub New(ByVal applicationId As Guid, ByVal device As LiveDevice)
            Me.New()
            If Nothing Is device Then
                Throw New ArgumentNullException("device")
            End If

            Me.ClientInfo = New DeviceRegistrationClientInfo() With {.ApplicationId = applicationId, .Version = "1.0"}
            Me.Authentication = New DeviceRegistrationAuthentication() With {.MemberName = device.User.DeviceId, _
                                                                             .Password = device.User.DecryptedPassword}
        End Sub
        #End Region

        #Region "Properties"
        <XmlElement("ClientInfo")> _
        Public Property ClientInfo() As DeviceRegistrationClientInfo

        <XmlElement("Authentication")> _
        Public Property Authentication() As DeviceRegistrationAuthentication
        #End Region
    End Class
    #End Region

    #Region "DeviceRegistrationClientInfo Class"
    <EditorBrowsable(EditorBrowsableState.Never), XmlRoot("ClientInfo")> _
    Public NotInheritable Class DeviceRegistrationClientInfo
        #Region "Properties"
        <XmlAttribute("name")> _
        Public Property ApplicationId() As Guid

        <XmlAttribute("version")> _
        Public Property Version() As String
        #End Region
    End Class
    #End Region

    #Region "DeviceRegistrationAuthentication Class"
    <EditorBrowsable(EditorBrowsableState.Never), XmlRoot("Authentication")> _
    Public NotInheritable Class DeviceRegistrationAuthentication
        #Region "Properties"
        <XmlElement("Membername")> _
        Public Property MemberName() As String

        <XmlElement("Password")> _
        Public Property Password() As String
        #End Region
    End Class
    #End Region

    #Region "DeviceRegistrationResponse Class"
    <EditorBrowsable(EditorBrowsableState.Never), XmlRoot("DeviceAddResponse")> _
    Public NotInheritable Class DeviceRegistrationResponse
        #Region "Properties"
        <XmlElement("success")> _
        Public Property IsSuccess() As Boolean

        <XmlElement("puid")> _
        Public Property Puid() As String

        <XmlElement("Error")> _
        Public Property [Error]() As DeviceRegistrationResponseError

        <XmlElement("ErrorSubcode")> _
        Public Property ErrorSubCode() As String
        #End Region
    End Class
    #End Region

    #Region "DeviceRegistrationResponse Class"
    <EditorBrowsable(EditorBrowsableState.Never), XmlRoot("Error")> _
    Public NotInheritable Class DeviceRegistrationResponseError
        Private _code As String

        #Region "Properties"
        <XmlAttribute("Code")> _
        Public Property Code() As String
            Get
                Return Me._code
            End Get

            Set(ByVal value As String)
                Me._code = value

                'Parse the error code
                If Not String.IsNullOrEmpty(value) Then
                    'Parse the error code
                    If value.StartsWith("dc", StringComparison.Ordinal) Then
                        Dim code_Renamed As Integer
                        If Integer.TryParse(value.Substring(2), NumberStyles.Integer, CultureInfo.InvariantCulture, code_Renamed) _
                               AndAlso System.Enum.IsDefined(GetType(DeviceRegistrationErrorCode), code_Renamed) Then
                            Me.RegistrationErrorCode = CType(System.Enum.ToObject(GetType(DeviceRegistrationErrorCode), code_Renamed), DeviceRegistrationErrorCode)
                        End If
                    End If
                End If
            End Set
        End Property

        Private privateRegistrationErrorCode As DeviceRegistrationErrorCode
        <XmlIgnore> _
        Public Property RegistrationErrorCode() As DeviceRegistrationErrorCode
            Get
                Return privateRegistrationErrorCode
            End Get
            Private Set(ByVal value As DeviceRegistrationErrorCode)
                privateRegistrationErrorCode = value
            End Set
        End Property
        #End Region
    End Class
    #End Region

    #Region "LiveDevice Class"
    <EditorBrowsable(EditorBrowsableState.Never), XmlRoot("Data")> _
    Public NotInheritable Class LiveDevice
        #Region "Properties"
        <XmlAttribute("version")> _
        Public Property Version() As Integer

        <XmlElement("User")> _
        Public Property User() As DeviceUserName

        <SuppressMessage("Microsoft.Design", "CA1059:MembersShouldNotExposeCertainConcreteTypes", _
            MessageId:="System.Xml.XmlNode", Justification:="This is required for proper XML Serialization"), XmlElement("Token")> _
        Public Property Token() As XmlNode

        <XmlElement("Expiry")> _
        Public Property Expiry() As String

        <XmlElement("ClockSkew")> _
        Public Property ClockSkew() As String
        #End Region
    End Class
    #End Region

    #Region "DeviceUserName Class"
    <EditorBrowsable(EditorBrowsableState.Never)> _
    Public NotInheritable Class DeviceUserName
        Private _encryptedPassword As String
		Private _decryptedPassword As String
        Private _encryptedValueIsUpdated As Boolean

        #Region "Constants"
        Private Const UserNamePrefix As String = "11"
        #End Region

        #Region "Constructors"
        Public Sub New()
            Me.UserNameType = "Logical"
        End Sub
        #End Region

        #Region "Properties"
        <XmlAttribute("username")> _
        Public Property DeviceName() As String

        <XmlAttribute("type")> _
        Public Property UserNameType() As String

        <XmlElement("Pwd")> _
        Public Property EncryptedPassword() As String
            Get
                Me.ThrowIfNoEncryption()

                If Not Me._encryptedValueIsUpdated Then
					Me._encryptedPassword = Me.Encrypt(Me._decryptedPassword)
                    Me._encryptedValueIsUpdated = True
                End If

                Return Me._encryptedPassword
            End Get

            Set(ByVal value As String)
                Me.ThrowIfNoEncryption()
                Me.UpdateCredentials(value, Nothing)
            End Set
        End Property

        Public ReadOnly Property DeviceId() As String
            Get
                Return UserNamePrefix &amp; DeviceName
            End Get
        End Property

        <XmlIgnore> _
        Public Property DecryptedPassword() As String
            Get
				Return Me._decryptedPassword
            End Get

            Set(ByVal value As String)
                Me.UpdateCredentials(Nothing, value)
            End Set
        End Property

        Private ReadOnly Property IsEncryptionEnabled() As Boolean
            Get
                'If the object is not going to be persisted to a file, then the value does not need to be encrypted. This is extra
                'overhead and will not function in partial trust.
                Return DeviceIdManager.PersistToFile
            End Get
        End Property
        #End Region

        #Region "Methods"
        Public Function ToClientCredentials() As ClientCredentials
            Dim credentials As New ClientCredentials()
            credentials.UserName.UserName = Me.DeviceId
            credentials.UserName.Password = Me.DecryptedPassword

            Return credentials
        End Function

        Private Sub ThrowIfNoEncryption()
            If Not Me.IsEncryptionEnabled Then
                Throw New NotSupportedException("Not supported when DeviceIdManager.UseEncryptionApis is false.")
            End If
        End Sub

        Private Sub UpdateCredentials(ByVal encryptedValue As String, ByVal decryptedValue As String)
            Dim isValueUpdated As Boolean = False
            If String.IsNullOrEmpty(encryptedValue) AndAlso String.IsNullOrEmpty(decryptedValue) Then
                isValueUpdated = True
            ElseIf String.IsNullOrEmpty(encryptedValue) Then
                If Me.IsEncryptionEnabled Then
                    encryptedValue = Me.Encrypt(decryptedValue)
                    isValueUpdated = True
                Else
                    encryptedValue = Nothing
                    isValueUpdated = False
                End If
            Else
                Me.ThrowIfNoEncryption()

                decryptedValue = Me.Decrypt(encryptedValue)
                isValueUpdated = True
            End If

            Me._encryptedPassword = encryptedValue
			Me._decryptedPassword = decryptedValue
            Me._encryptedValueIsUpdated = isValueUpdated
        End Sub

        Private Function Encrypt(ByVal value As String) As String
            If String.IsNullOrEmpty(value) Then
                Return value
            End If

            Dim encryptedBytes() As Byte = ProtectedData.Protect(Encoding.UTF8.GetBytes(value), Nothing, DataProtectionScope.CurrentUser)
            Return Convert.ToBase64String(encryptedBytes)
        End Function

        Private Function Decrypt(ByVal value As String) As String
            If String.IsNullOrEmpty(value) Then
                Return value
            End If

            Dim decryptedBytes() As Byte = ProtectedData.Unprotect(Convert.FromBase64String(value), Nothing, DataProtectionScope.CurrentUser)
            If Nothing Is decryptedBytes OrElse 0 = decryptedBytes.Length Then
                Return Nothing
            End If

            Return Encoding.UTF8.GetString(decryptedBytes, 0, decryptedBytes.Length)
        End Function
        #End Region
    End Class
    #End Region
    #End Region
    #End Region
End Namespace

' </snippetdeviceidmanager>
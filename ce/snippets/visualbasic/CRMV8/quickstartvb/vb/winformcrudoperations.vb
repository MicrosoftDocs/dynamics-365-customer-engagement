' <snippetwinformcrudoperations>


Imports System.Configuration
Imports System.ServiceModel

' These namespaces are found in the Microsoft.Crm.Sdk.Proxy.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Crm.Sdk.Messages

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Query

' These namespaces are found in the Microsoft.Xrm.Client.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Xrm.Client
Imports Microsoft.Xrm.Client.Services

Namespace Microsoft.Crm.Sdk.Samples
	''' <summary>
	''' This Windows Forms application sample uses the CrmConnection class found in the
	''' Microsoft.Xrm.Client namespace to connect to and authenticate with the 
	''' organization web service.
	''' 
	''' Next, the sample demonstrates how to do basic entity operations like create,
	''' retrieve, update, and delete on account entity.
	'''
	''' Prior to running this sample you must edit the app.config file to add your Microsoft
	''' CRM server and user logon information. Several examples are provided in the file.</summary>
	''' <remarks>
	''' At run-time, you will be given the option to delete all the database
	''' records created by this program.
	''' 
	''' No helper code from CrmServiceHelpers.cs is used in this sample.</remarks>
	''' <see cref="http://msdn.microsoft.com/library/gg695810.aspx"/>

	Partial Public Class WinCRUDOperations
		Inherits Form
		#Region "Class Level Members"

		Private _accountId As Guid
		Private _orgService As OrganizationService
		Private _strexit As Boolean = True

		#End Region ' Class Level Members

		''' <summary>
		''' Initialize the form controls.
		''' </summary>
		Public Sub New()
			InitializeComponent()

			' Read the server configurations from app.config.
			GetServiceConfiguration()

			'Show the form.
			Me.Show()
		End Sub

		#Region "Public Methods"

		''' <summary>
		''' The Run() method first connects to the organization service. Afterwards,
		''' basic create, retrieve, update, and delete entity operations are performed.
		''' </summary>
		''' <param name="connectionString">Provides service connection information.</param>
		''' <param name="promptforDelete">When True, the user will be prompted to delete all
		''' created entities.</param>
		Public Sub Run(ByVal connectionString As String, ByVal promptforDelete As Boolean)
			Try
				' Establish a connection to the organization web service.
				Print("Connecting to the server ...")
				Dim connection As Microsoft.Xrm.Client.CrmConnection = CrmConnection.Parse(connectionString)

				' Obtain an organization service proxy.
				' The using statement assures that the service proxy will be properly disposed.
				_orgService = New OrganizationService(connection)
				Using _orgService
					Print("connected")
					Print("Authenticating the user ...")

					' Create any entity records this sample requires.
					CreateRequiredRecords()

					' Obtain information about the logged on user from the web service.
					Dim userid As Guid = (CType(_orgService.Execute(New WhoAmIRequest()), WhoAmIResponse)).UserId
					Dim systemUser As SystemUser = CType(_orgService.Retrieve("systemuser", userid, New ColumnSet(New String() { "firstname", "lastname" })), SystemUser)
					Println("Logged on user is " &amp; systemUser.FirstName &amp; " " &amp; systemUser.LastName &amp; ".")

					' Retrieve the version of Microsoft Dynamics CRM.
					Dim versionRequest As New RetrieveVersionRequest()
					Dim versionResponse As RetrieveVersionResponse = CType(_orgService.Execute(versionRequest), RetrieveVersionResponse)
					Println("Microsoft Dynamics CRM version " &amp; versionResponse.Version &amp; ".")

					' Instantiate an account object. Note the use of option set enumerations defined in OptionSets.cs.
					' Refer to the Entity Metadata topic in the SDK documentation to determine which attributes must
					' be set for each entity.
					Dim account As Account = New Account With {.Name = "Fourth Coffee"}
					account.AccountCategoryCode = New OptionSetValue(CInt(Fix(AccountAccountCategoryCode.PreferredCustomer)))
					account.CustomerTypeCode = New OptionSetValue(CInt(Fix(AccountCustomerTypeCode.Investor)))

					' Create an account record named Fourth Coffee.
					_accountId = _orgService.Create(account)

					Println(account.LogicalName &amp; " " &amp; account.Name &amp; " created, ")

					' Retrieve several attributes from the new account.
					Dim cols As New ColumnSet(New String() { "name", "address1_postalcode", "lastusedincampaign" })

					Dim retrievedAccount As Account = CType(_orgService.Retrieve("account", _accountId, cols), Account)
					Print("retrieved, ")

					' Update the postal code attribute.
					retrievedAccount.Address1_PostalCode = "98052"

					' The address 2 postal code was set accidentally, so set it to null.
					retrievedAccount.Address2_PostalCode = Nothing

					' Shows use of a Money value.
					retrievedAccount.Revenue = New Money(5000000)

					' Shows use of a Boolean value.
					retrievedAccount.CreditOnHold = False

					' Update the account record.
					_orgService.Update(retrievedAccount)
					Print("and updated.")

					' Delete any entity records this sample created.
					DeleteRequiredRecords(promptforDelete)
				End Using

			' Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            Catch fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                ' You can handle an exception here or pass it back to the calling method.
                Throw
			End Try
		End Sub

		''' <summary>
		''' Creates any entity records this sample requires.
		''' </summary>
		Public Sub CreateRequiredRecords()
			' For this sample, all required entities are created in the Run() method.
		End Sub

		''' <summary>
		''' Deletes any entity records that were created for this sample.
		''' <param name="prompt">Indicates whether to prompt the user 
		''' to delete the records created in this sample.</param>
		''' </summary>
		Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
			Dim deleteRecords As Boolean = True

			If prompt Then
				Println("")
				Dim dialogResult As DialogResult = MessageBox.Show("Do you want the created entity records deleted?", "Delete Records", MessageBoxButtons.YesNoCancel)
				If dialogResult = DialogResult.Yes OrElse dialogResult = DialogResult.Cancel Then
					deleteRecords = True
				Else
					deleteRecords = False
				End If
			End If

			If deleteRecords Then
				_orgService.Delete(Account.EntityLogicalName, _accountId)
				Println("Entity records have been deleted.")
			End If
		End Sub

		''' <summary>
		''' Displays a message string in the form with newline.
		''' </summary>
		Public Sub Println(ByVal _sPrintlntext As String)
			If lblOutMsg.Text <> String.Empty Then
				lblOutMsg.Text = lblOutMsg.Text &amp; vbLf &amp; _sPrintlntext
			Else
				lblOutMsg.Text = _sPrintlntext
			End If

			lblOutMsg.Update()
		End Sub

		''' <summary>
		''' Displays a message string in the form.   
		''' </summary>
		Public Sub Print(ByVal _sPrintlntext As String)
			lblOutMsg.Text = lblOutMsg.Text &amp; _sPrintlntext
			lblOutMsg.Update()
		End Sub

		#End Region ' Public Methods

		#Region "Private Methods"

		''' <summary>
		''' Gets web service connection information from the app.config file.
		''' If there is more than one available, providing an option to the user to select
		''' the desired connection configuration by name.
		''' </summary>
		''' <returns>A string containing web service connection configuration information.</returns>
		Private Function GetServiceConfiguration() As String
			' Get available connection strings from app.config.
			Dim count As Integer = ConfigurationManager.ConnectionStrings.Count

			' Create a filter list of connection strings so that we have a list of valid
			' connection strings for Microsoft Dynamics CRM only.
			Dim filteredConnectionStrings As New List(Of KeyValuePair(Of String, String))()

			For a As Integer = 0 To count - 1
				If isValidConnectionString(ConfigurationManager.ConnectionStrings(a).ConnectionString) Then
					filteredConnectionStrings.Add (New KeyValuePair(Of String, String) (ConfigurationManager.ConnectionStrings(a).Name, ConfigurationManager.ConnectionStrings(a).ConnectionString))
				End If
			Next a

			' No valid connections strings found. Write out an error message.
			If filteredConnectionStrings.Count = 0 Then
				Println("An app.config file containing at least one valid Microsoft Dynamics CRM " &amp; "server connection configuration must exist in the run-time folder.")
				Println(vbLf &amp; "There are several commented out example server connection configurations in " &amp; "the provided app.config file. Uncomment one or more of them, modify the configuration according " &amp; "to your Microsoft Dynamics CRM installation, and then re-run the sample.")

				' Disable the Connect button.
				btnConnect.Enabled = False
				Return Nothing

			' If at least one valid connection string is found, display the list of valid connection strings.
			Else
				_strexit = False
				For i As Integer = 0 To filteredConnectionStrings.Count - 1
					cbxServerList.Items.Add(filteredConnectionStrings(i).Key)

				Next i
				cbxServerList.SelectedIndex = 0
			End If

			' Return a non-null which in this case is the first string in the list. 
			Return ConfigurationManager.ConnectionStrings(0).ConnectionString
		End Function


		''' <summary>
		''' Verifies if a connection string is valid for Microsoft Dynamics CRM.
		''' </summary>
		''' <returns>True for a valid string, otherwise False.</returns>
		Private Shared Function isValidConnectionString(ByVal connectionString As String) As Boolean
			' At a minimum, a connection string must contain one of these arguments.
			If connectionString.Contains("Url=") OrElse connectionString.Contains("Server=") OrElse connectionString.Contains("ServiceUri=") Then
				Return True
			End If

			Return False
		End Function


		''' <summary>
		''' Let the user choose which connection string to use.
		''' Gets the user selected  web service connection  from the app.config file.      
		''' </summary>
		''' <returns></returns>      
		Private Sub btnConnect_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnConnect.Click
			Try
				Dim connectionString As String = ConfigurationManager.ConnectionStrings(cbxServerList.SelectedItem.ToString()).ConnectionString

				lblOutMsg.Text = String.Empty

				If connectionString IsNot Nothing Then
					Run(connectionString, True)
				End If

			Catch ex As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
				Println("The application terminated with an error.")
				Println("Timestamp: " &amp; ex.Detail.Timestamp)
				Println("Code: " &amp; ex.Detail.ErrorCode)
				Println("Message: " &amp; ex.Detail.Message)
				Println("Trace: " &amp; ex.Detail.TraceText)
				Println("Inner Fault: {0}" &amp; (If(Nothing Is ex.Detail.InnerFault, "No Inner Fault", "Has Inner Fault")))
			Catch ex As TimeoutException
				Println("The application terminated with an error.")
				Println("Message: " &amp; ex.Message)
				Println("Stack Trace: " &amp; ex.StackTrace)
				Println("Inner Fault: " &amp; (If(Nothing Is ex.InnerException.Message, "No Inner Fault", ex.InnerException.Message)))
			Catch ex As Exception
				Println("The application terminated with an error.")
				Println(ex.Message)

				' Display the details of the inner exception.
				If ex.InnerException IsNot Nothing Then
					Println(ex.InnerException.Message)

					Dim fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault) = TryCast(ex.InnerException, FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault))
					If fe IsNot Nothing Then
						Println("Timestamp: " &amp; fe.Detail.Timestamp)
						Println("Code: " &amp; fe.Detail.ErrorCode)
						Println("Message: " &amp; fe.Detail.Message)
						Println("Trace: " &amp; fe.Detail.TraceText)
						Println("Inner Fault: " &amp; (If(Nothing Is fe.Detail.InnerFault, "No Inner Fault", "Has Inner Fault")))
					End If
				End If

			' Additional exceptions to catch: SecurityTokenValidationException, ExpiredSecurityTokenException,
			' SecurityAccessDeniedException, MessageSecurityException, and SecurityNegotiationException.

			Finally
				Println("Choose [Exit] to quit the application.")
			End Try
		End Sub


		''' <summary>
		''' Quit the application.   
		''' </summary>
		Private Sub btnExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExit.Click
			Me.Hide()
			Dispose()
		End Sub

		#End Region ' Private Methods             
	End Class
End Namespace

' </snippetwinformcrudoperations>
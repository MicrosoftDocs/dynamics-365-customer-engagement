' <snippetsimplifiedconnection>


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
	''' This sample uses the CrmConnection class found in the Microsoft.Xrm.Client
	''' namespace to connect to and authenticate with the organization web service.
	''' 
	''' Next, the sample demonstrates how to do basic entity operations like create,
	''' retrieve, update, and delete.</summary>
	''' <remarks>
	''' At run-time, you will be given the option to delete all the database
	''' records created by this program.
	''' 
	''' No helper code from CrmServiceHelpers.cs is used in this sample.</remarks>
	''' <see cref="https://msdn.microsoft.com/library/gg695810.aspx"/>
	Public Class SimplifiedConnection
		#Region "Class Level Members"

		Private _accountId As Guid
		Private _orgService As OrganizationService

		#End Region ' Class Level Members

		 ''' <summary>
		''' The Run() method first connects to the Organization service. Afterwards,
		''' basic create, retrieve, update, and delete entity operations are performed.
		''' </summary>
		''' <param name="connectionString">Provides service connection information.</param>
		''' <param name="promptforDelete">When True, the user will be prompted to delete all
		''' created entities.</param>
		Public Sub Run(ByVal connectionString As String, ByVal promptforDelete As Boolean)
			Try
				' Establish a connection to the organization web service using CrmConnection.
                Dim connection As Microsoft.Xrm.Client.CrmConnection =
                    CrmConnection.Parse(connectionString)

				' Obtain an organization service proxy.
				' The using statement assures that the service proxy will be properly disposed.
				_orgService = New OrganizationService(connection)
				Using _orgService
					'Create any entity records this sample requires.
					CreateRequiredRecords()

					' Obtain information about the logged on user from the web service.
                    Dim userid As Guid = (CType(_orgService.Execute(New WhoAmIRequest()), 
                                          WhoAmIResponse)).UserId
                    Dim systemUser_Renamed As SystemUser =
                        _orgService.Retrieve("systemuser",
                                             userid,
                                             New ColumnSet(New String() {"firstname",
                                                                         "lastname"})) _
                                         .ToEntity(Of SystemUser)()
                    Console.WriteLine("Logged on user is {0} {1}.",
                                      systemUser_Renamed.FirstName,
                                      systemUser_Renamed.LastName)

					' Retrieve the version of Microsoft Dynamics CRM.
					Dim versionRequest As New RetrieveVersionRequest()
                    Dim versionResponse As RetrieveVersionResponse =
                        CType(_orgService.Execute(versionRequest), RetrieveVersionResponse)
                    Console.WriteLine("Microsoft Dynamics CRM version {0}.",
                                      versionResponse.Version)

					' Instantiate an account object. Note the use of option set enumerations defined in OptionSets.cs.
					' Refer to the Entity Metadata topic in the SDK documentation to determine which attributes must
					' be set for each entity.
					Dim account_Renamed As Account = New Account With {.Name = "Fourth Coffee"}
                    account_Renamed.AccountCategoryCode =
                        New OptionSetValue(CInt(Fix(AccountAccountCategoryCode.PreferredCustomer)))
                    account_Renamed.CustomerTypeCode =
                        New OptionSetValue(CInt(Fix(AccountCustomerTypeCode.Investor)))

					' Create an account record named Fourth Coffee.
					_accountId = _orgService.Create(account_Renamed)

                    Console.Write("{0} {1} created, ", account_Renamed.LogicalName,
                                  account_Renamed.Name)

					' Retrieve the several attributes from the new account.
                    Dim cols As New ColumnSet(New String() {"name",
                                                            "address1_postalcode",
                                                            "lastusedincampaign"})

                    Dim retrievedAccount As Account = _orgService.Retrieve("account",
                                                                           _accountId,
                                                                           cols).ToEntity(Of Account)()
					Console.Write("retrieved, ")

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
					Console.WriteLine("and updated.")

					' Delete any entity records this sample created.
					DeleteRequiredRecords(promptforDelete)
				End Using

			' Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            Catch fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                ' You can handle an exception here or pass it back to the calling method.
                Throw
			End Try
		End Sub

		#Region "Public Methods"
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
                Console.Write(vbLf &amp; "Do you want these entity records deleted? (y/n) [y]: ")
				Dim answer As String = Console.ReadLine()

                deleteRecords = (answer.StartsWith("y") OrElse
                                 answer.StartsWith("Y") OrElse
                                 answer = String.Empty)
			End If

			If deleteRecords Then
				_orgService.Delete(Account.EntityLogicalName, _accountId)
				Console.WriteLine("Entity records have been deleted.")
			End If
		End Sub

		#End Region ' Public Methods

		#Region "Private Methods"

		''' <summary>
		''' Gets web service connection information from the app.config file.
		''' If there is more than one available, the user is prompted to select
		''' the desired connection configuration by name.
		''' </summary>
		''' <returns>A string containing web service connection configuration information.</returns>
		Private Shared Function GetServiceConfiguration() As String
			' Get available connection strings from app.config.
			Dim count As Integer = ConfigurationManager.ConnectionStrings.Count

			' Create a filter list of connection strings so that we have a list of valid
			' connection strings for Microsoft Dynamics CRM only.
			Dim filteredConnectionStrings As New List(Of KeyValuePair(Of String, String))()

			For a As Integer = 0 To count - 1
				If isValidConnectionString(ConfigurationManager.ConnectionStrings(a).ConnectionString) Then
                    filteredConnectionStrings.Add(New KeyValuePair(Of String, String) _
                                                   (ConfigurationManager.ConnectionStrings(a).Name,
                                                    ConfigurationManager.ConnectionStrings(a).ConnectionString))
				End If
			Next a

			' No valid connections strings found. Write out and error message.
			If filteredConnectionStrings.Count = 0 Then
                Console.WriteLine("An app.config file containing at least one valid Microsoft Dynamics CRM " _
                                  &amp; "connection string configuration must exist in the run-time folder.")
                Console.WriteLine(vbLf &amp; "There are several commented out example connection strings in " _
                                  &amp; "the provided app.config file. Uncomment one of them and modify the string according " _
                                  &amp; "to your Microsoft Dynamics CRM installation. Then re-run the sample.")
				Return Nothing
			End If

			' If one valid connection string is found, use that.
			If filteredConnectionStrings.Count = 1 Then
				Return filteredConnectionStrings(0).Value
			End If

			' If more than one valid connection string is found, let the user decide which to use.
			If filteredConnectionStrings.Count > 1 Then
				Console.WriteLine("The following connections are available:")
				Console.WriteLine("------------------------------------------------")

				For i As Integer = 0 To filteredConnectionStrings.Count - 1
					Console.Write(vbLf &amp; "({0}) {1}" &amp; vbTab, i + 1, filteredConnectionStrings(i).Key)
				Next i

				Console.WriteLine()

                Console.Write(vbLf &amp; "Type the number of the connection to use (1-{0}) [{0}] : ",
                              filteredConnectionStrings.Count)
				Dim input As String = Console.ReadLine()
                Dim configNumber As Integer
                If (input Is String.Empty) Then
                    input = filteredConnectionStrings.Count.ToString()
                End If
                If (Not Int32.TryParse(input, configNumber)) OrElse
                    configNumber > count OrElse
                    configNumber = 0 Then
                    Console.WriteLine("Option not valid.")
                    Return Nothing
                End If

                Return filteredConnectionStrings(configNumber - 1).Value

            End If
            Return Nothing

		End Function


		''' <summary>
		''' Verifies if a connection string is valid for Microsoft Dynamics CRM.
		''' </summary>
		''' <returns>True for a valid string, otherwise False.</returns>
		Private Shared Function isValidConnectionString(ByVal connectionString As String) As Boolean
			' At a minimum, a connection string must contain one of these arguments.
            If connectionString.Contains("Url=") OrElse
                connectionString.Contains("Server=") OrElse
                connectionString.Contains("ServiceUri=") Then
                Return True
            End If

			Return False
		End Function

		#End Region ' Private Methods

		#Region "Main method"

		''' <summary>
		''' Standard Main() method used by most SDK samples.
		''' </summary>
		''' <param name="args"></param>
		Public Shared Sub Main(ByVal args() As String)
			Try
				' Obtain connection configuration information for the Microsoft Dynamics
				' CRM organization web service.
				Dim connectionString As String = GetServiceConfiguration()

				If connectionString IsNot Nothing Then
					Dim app As New SimplifiedConnection()
					app.Run(connectionString, True)
				End If

			Catch ex As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
				Console.WriteLine("The application terminated with an error.")
				Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp)
				Console.WriteLine("Code: {0}", ex.Detail.ErrorCode)
				Console.WriteLine("Message: {0}", ex.Detail.Message)
				Console.WriteLine("Trace: {0}", ex.Detail.TraceText)
                Console.WriteLine("Inner Fault: {0}",
                                  If(Nothing Is ex.Detail.InnerFault,
                                     "No Inner Fault",
                                     "Has Inner Fault"))
			Catch ex As TimeoutException
				Console.WriteLine("The application terminated with an error.")
				Console.WriteLine("Message: {0}", ex.Message)
				Console.WriteLine("Stack Trace: {0}", ex.StackTrace)
                Console.WriteLine("Inner Fault: {0}",
                                  If(Nothing Is ex.InnerException.Message,
                                     "No Inner Fault",
                                     ex.InnerException.Message))
			Catch ex As Exception
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
                                             "No Inner Fault",
                                             "Has Inner Fault"))
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

' </snippetsimplifiedconnection>
' <snippetuserqueryandsavedquery>


Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.ServiceModel
Imports System.Text
Imports System.Xml

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Xrm.Sdk.Client

' This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Crm.Sdk.Messages

Namespace Microsoft.Crm.Sdk.Samples
	''' <summary>
	''' Demonstrates how to execute saved and user queries by id, and how to validate 
	''' a saved query.
	''' </summary>
	''' <param name="serverConfig">Contains server connection information.</param>
	''' <param name="promptforDelete">When True, the user will be prompted to delete all
	''' created entities.</param>
	Public Class UserQueryAndSavedQuery
		#Region "Class Level Members"

		Private _serviceProxy As OrganizationServiceProxy
		Private _accounts As New List(Of Account)()
		Private _savedQuery As SavedQuery
		Private _userQuery As UserQuery

		#End Region ' Class Level Members

		#Region "How To Sample Code"
		''' <summary>
		''' This method first creates a series of Accounts to query over, a user query 
		''' that retrieves the names of all Accounts with a name of 'Coho Winery' and 
		''' a system query that retrieves all Account names. Then it validates the system 
		''' query, executes the system query and displays the results, and finally 
		''' executes the user query and displays the results.
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

                    CreateRequiredRecords()

                    '					#Region "Validate saved query"

                    ' Create the request
                    Dim validateRequest As New ValidateSavedQueryRequest() With
                        {
                            .FetchXml = _savedQuery.FetchXml,
                            .QueryType = _savedQuery.QueryType.Value
                        }

                    ' Send the request
                    Console.WriteLine("  Validating Saved Query")
                    Try
                        ' executing the request will throw an exception if the fetch xml is invalid
                        Dim validateResponse = CType(_serviceProxy.Execute(validateRequest), 
                            ValidateSavedQueryResponse)
                        Console.WriteLine("  Saved Query validated successfully")
                    Catch e1 As Exception
                        Console.WriteLine("  Invalid Saved Query")
                        Throw
                    End Try

                    '					#End Region

                    '					#Region "Execute saved query"

                    ' Create the request
                    Dim executeSavedQueryRequest As New ExecuteByIdSavedQueryRequest() With
                        {
                            .EntityId = _savedQuery.Id
                        }

                    ' Execute the request
                    Console.WriteLine("  Executing Saved Query")
                    Dim executeSavedQueryResponse As ExecuteByIdSavedQueryResponse =
                        CType(_serviceProxy.Execute(executeSavedQueryRequest), 
                            ExecuteByIdSavedQueryResponse)

                    ' Check results
                    If String.IsNullOrEmpty(executeSavedQueryResponse.String) Then
                        Throw New Exception("Saved Query did not return any results")
                    End If

                    PrintResults(executeSavedQueryResponse.String)
                    '					#End Region

                    '					#Region "Execute user query"

                    ' Create the request
                    Dim executeUserQuery As New ExecuteByIdUserQueryRequest() With
                        {
                            .EntityId = _userQuery.ToEntityReference()
                        }

                    ' Send the request
                    Console.WriteLine("  Executing User Query")
                    Dim executeUserQueryResponse As ExecuteByIdUserQueryResponse =
                        CType(_serviceProxy.Execute(executeUserQuery), 
                            ExecuteByIdUserQueryResponse)
                    If String.IsNullOrEmpty(executeUserQueryResponse.String) Then
                        Throw New Exception("User Query did not return any results")
                    End If

                    ' validate results
                    PrintResults(executeUserQueryResponse.String)

                    '					#End Region

                    DeleteRequiredRecords(promptforDelete)
                End Using

                ' Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            Catch fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                ' You can handle an exception here or pass it back to the calling method.
                Throw
            End Try
        End Sub

		#Region "Public methods"

		''' <summary>
		''' Creates any entity records that this sample requires.
		''' </summary>
		Public Sub CreateRequiredRecords()
'			#Region "Create Accounts to query over"

			Console.WriteLine("  Creating some sample accounts")

			Dim account_Renamed As New Account() With {.Name = "Coho Vineyard"}
			account_Renamed.Id = _serviceProxy.Create(account_Renamed)
			_accounts.Add(account_Renamed)
			Console.WriteLine("    Created Account {0}", account_Renamed.Name)

			account_Renamed = New Account() With {.Name = "Coho Winery"}
			account_Renamed.Id = _serviceProxy.Create(account_Renamed)
			_accounts.Add(account_Renamed)
			Console.WriteLine("    Created Account {0}", account_Renamed.Name)

			account_Renamed = New Account() With {.Name = "Coho Vineyard &amp; Winery"}
			account_Renamed.Id = _serviceProxy.Create(account_Renamed)
			_accounts.Add(account_Renamed)
			Console.WriteLine("    Created Account {0}", account_Renamed.Name)

'			#End Region

'			#Region "Create a Saved Query"

			Console.WriteLine("  Creating a Saved Query that retrieves all Account ids")

            _savedQuery = New SavedQuery() With
                          {
                              .Name = "Fetch all Account ids",
                              .ReturnedTypeCode = Account.EntityLogicalName,
                              .FetchXml = " <fetch mapping='logical'> <entity name='account'> <attribute name='name' /> </entity> </fetch>",
                              .QueryType = 0
                          }
			_savedQuery.Id = _serviceProxy.Create(_savedQuery)

'			#End Region

'			#Region "Create a User Query"

			Console.WriteLine("  Creating a User Query that retrieves all Account ids for Accounts with name 'Coho Winery'")

            _userQuery = New UserQuery() With
                         {
                             .Name = "Fetch Coho Winery",
                             .ReturnedTypeCode = Account.EntityLogicalName,
                             .FetchXml = " <fetch mapping='logical'> <entity name='account'> <attribute name='name' /> <filter> <condition attribute='name' operator='eq' value='Coho Winery' /> </filter> </entity> </fetch>",
                             .QueryType = 0
                         }
			_userQuery.Id = _serviceProxy.Create(_userQuery)

'			#End Region
		End Sub

		''' <summary>
		''' Deletes any entity records that were created for this sample.
		''' <param name="prompt">Indicates whether to prompt the user 
		''' to delete the records created in this sample.</param>
		''' </summary>
		Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
			Dim toBeDeleted As Boolean = True

			If prompt Then
				' Ask the user if the created entities should be deleted.
				Console.Write(vbLf &amp; "Do you want these entity records deleted? (y/n) [y]: ")
				Dim answer As String = Console.ReadLine()
                If answer.StartsWith("y") OrElse
                    answer.StartsWith("Y") OrElse
                    answer = String.Empty Then
                    toBeDeleted = True
                Else
                    toBeDeleted = False
                End If
			End If

			If toBeDeleted Then
				_serviceProxy.Delete(SavedQuery.EntityLogicalName, _savedQuery.Id)

				_serviceProxy.Delete(UserQuery.EntityLogicalName, _userQuery.Id)

				For Each a As Account In _accounts
					_serviceProxy.Delete(Account.EntityLogicalName, a.Id)
				Next a

				Console.WriteLine("Entity records have been deleted.")
			End If
		End Sub
		#End Region ' Public Methods

		#Region "Helper methods"

		Private Sub PrintResults(ByVal response As String)
			' Using XmlReader to format output
			Dim output As New StringBuilder()
			Using reader As XmlReader = XmlReader.Create(New StringReader(response))
                Dim settings As XmlWriterSettings =
                    New XmlWriterSettings With {.Indent = True, .OmitXmlDeclaration = True}
				Using writer As XmlWriter = XmlWriter.Create(output, settings)
					' Parse the file and display each of the nodes.
					Do While reader.Read()
						Select Case reader.NodeType
							Case XmlNodeType.Element
								writer.WriteStartElement(reader.Name)
							Case XmlNodeType.Text
								writer.WriteString(reader.Value)
							Case XmlNodeType.XmlDeclaration, XmlNodeType.ProcessingInstruction
								writer.WriteProcessingInstruction(reader.Name, reader.Value)
							Case XmlNodeType.Comment
								writer.WriteComment(reader.Value)
							Case XmlNodeType.EndElement
								writer.WriteFullEndElement()
						End Select
					Loop
				End Using
			End Using

			Console.WriteLine("  Result of query:" &amp; vbCrLf &amp; " {0}", output.ToString())
			Console.WriteLine()
		End Sub

		#End Region

		#End Region ' How To Sample Code

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
                Dim config As ServerConnection.Configuration =
                    serverConnect.GetServerConfiguration()

				Dim app As New UserQueryAndSavedQuery()
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

' </snippetuserqueryandsavedquery>
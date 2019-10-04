' <snippetmerge>



Imports System
Imports System.ServiceModel
Imports Microsoft.Crm.Sdk.Messages
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Query

Namespace Microsoft.Crm.Sdk.Samples
	''' <summary>
    ''' This sample shows how to merge two records.
	''' </summary>
	''' <remarks>
	''' At run-time, you will be given the option to delete all the
	''' database records created by this program.
	''' </remarks>
	Public Class Merge
		#Region "Class Level Members"
		Private _serviceProxy As OrganizationServiceProxy
		Private _account1Id As Guid
		Private _account2Id As Guid
		#End Region

		''' <summary>
		''' This method shows how to merge two entity records with the Merge message.
		''' </summary>
		''' <param name="serverConfig">Contains server connection information.</param>
		''' <param name="promptForDelete">When True, the user will be prompted to delete
		''' all created entities.</param>
        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration,
                       ByVal promptForDelete As Boolean)
            _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
            Using _serviceProxy
                ' This statement is required to enable early-bound type support.
                _serviceProxy.EnableProxyTypes()

                'Create the Contact and Incident required for this sample.
                CreateRequiredRecords()

                ' Create the target for the request.
                Dim target As New EntityReference()

                ' Id is the GUID of the account that is being merged into.
                ' LogicalName is the type of the entity being merged to, as a string
                target.Id = _account1Id
                target.LogicalName = Account.EntityLogicalName

                ' Create the request.
                Dim merge As New MergeRequest()
                ' SubordinateId is the GUID of the account merging.
                merge.SubordinateId = _account2Id
                merge.Target = target
                merge.PerformParentingChecks = False

                Console.WriteLine(vbLf &amp; "Merging account2 into account1 and adding " _
                                  &amp; """test"" as Address 1 Line 1")

                ' Create another account to hold new data to merge into the entity.
                ' If you use the subordinate account object, its data will be merged.
                Dim updateContent As New Account()
                updateContent.Address1_Line1 = "test"

                ' Set the content you want updated on the merged account
                merge.UpdateContent = updateContent

                ' Execute the request.
                Dim merged As MergeResponse = CType(_serviceProxy.Execute(merge), MergeResponse)

                Dim mergeeAccount As Account =
                    CType(_serviceProxy.Retrieve(Account.EntityLogicalName,
                                                 _account2Id,
                                                 New ColumnSet(allColumns:=True)), 
                                             Account)

                If mergeeAccount.Merged = True Then
                    Dim mergedAccount As Account =
                        CType(_serviceProxy.Retrieve(Account.EntityLogicalName,
                                                     _account1Id,
                                                     New ColumnSet(allColumns:=True)), 
                                                 Account)

                    Console.WriteLine(vbLf &amp; "Accounts merged successfully into account1")
                    Console.WriteLine("  Name: {0}", mergedAccount.Name)
                    Console.WriteLine("  Description: {0}", mergedAccount.Description)
                    Console.WriteLine("  Number of Employees: {0}", mergedAccount.NumberOfEmployees)
                    Console.WriteLine("  Address 1 Line 1: {0}", mergedAccount.Address1_Line1)
                End If

                DeleteRequiredRecords(promptForDelete)
            End Using
        End Sub

		''' <summary>
		''' Creates any entity records that this sample requires.
		''' </summary>
		Public Sub CreateRequiredRecords()
			' Create the first account, which will be merged into
			Dim account1 As New Account()
			account1.Name = "Fourth Coffee"
			account1.Description = "Coffee House"

			_account1Id = _serviceProxy.Create(account1)
			Console.WriteLine("Account 1 created with GUID {{{0}}}", _account1Id)
			Console.WriteLine("  Name: {0}", account1.Name)
			Console.WriteLine("  Description: {0}", account1.Description)

			' Create the second account, which will be merged from
			Dim account2 As New Account()

			account2.Name = "Fourth Coffee"
			account2.NumberOfEmployees = 55

			_account2Id = _serviceProxy.Create(account2)
			Console.WriteLine("Account 2 created with GUID {{{0}}}", _account2Id)
			Console.WriteLine("  Name: {0}", account2.Name)
			Console.WriteLine("  Number of Employees: {0}", account2.NumberOfEmployees)
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
				Console.WriteLine()

                deleteRecords = (answer.StartsWith("y") OrElse
                                 answer.StartsWith("Y") OrElse
                                 answer = String.Empty)
			End If

			If deleteRecords Then
				_serviceProxy.Delete(Account.EntityLogicalName, _account1Id)
				_serviceProxy.Delete(Account.EntityLogicalName, _account2Id)
				Console.WriteLine("Entity records have been deleted.")
			End If
		End Sub

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

				Dim app = New Merge()
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
			' Additional exceptions to catch: SecurityTokenValidationException, 
			' ExpiredSecurityTokenException, SecurityAccessDeniedException, 
			' MessageSecurityException, and SecurityNegotiationException.

			Finally
				Console.WriteLine("Press <Enter> to exit.")
				Console.ReadLine()
			End Try
		End Sub
		#End Region ' Main method
	End Class
End Namespace

' </snippetmerge>
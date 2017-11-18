' <snippetrollupbyobject>


Imports Microsoft.VisualBasic
Imports System
Imports System.ServiceModel

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Query

' This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Crm.Sdk.Messages

Namespace Microsoft.Crm.Sdk.Samples
	''' <summary>
	''' Demonstrates how to roll up opportunities by their parent account.</summary>
	''' </summary>
	Public Class RollupByObject
		#Region "Class Level Members"

		Private _accountId As Guid
		Private _opportunityId As Guid
		Private _serviceProxy As OrganizationServiceProxy

		#End Region ' Class Level Members

		#Region "How To Sample Code"
		''' <summary>
		''' This sample demonstrates how to roll up opportunities by their parent account.
		''' The sample first creates the Rollup Request. Next, it executes that request.
		''' Finally, the sample displays the results of the Rollup Response.
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

                    '					#Region "Create QueryExpression"
                    ' Create QueryExpression
                    Dim query As New QueryExpression() With
                        {
                            .EntityName = Opportunity.EntityLogicalName,
                            .ColumnSet = New ColumnSet("name", "accountid")
                        }
                    Dim queryFilter As FilterExpression = New FilterExpression()
                    queryFilter.Conditions.Add(New ConditionExpression("name",
                                                                       ConditionOperator.Equal,
                                                                       "Opportunity 1"))
                    queryFilter.FilterOperator() = LogicalOperator.And
                    query.Criteria().AddFilter(queryFilter)


                    Console.WriteLine("Created QueryExpression.")
                    '					#End Region ' Create QueryExpression

                    '					#Region "Create RollupRequest"
                    ' Create RollupRequest
                    Dim rollupRequest As New RollupRequest()
                    rollupRequest.Query = query
                    rollupRequest.Target = New EntityReference("account", _accountId)
                    rollupRequest.RollupType = RollupType.Extended
                    Console.WriteLine("Created RollupRequest.")
                    '					#End Region ' Create RollupRequest

                    '					#Region "Execute RollupRequest"
                    ' Execute RollupRequest
                    Dim rollupResponse As RollupResponse = CType(_serviceProxy.Execute(rollupRequest), 
                        RollupResponse)
                    Console.WriteLine("Executed RollupRequest.")
                    '					#End Region ' Execute RollupRequest

                    '					#Region "Show RollupResponse results"
                    ' Show RollupResponse results
                    Console.WriteLine("RollupResponse Results:")
                    Console.WriteLine("--------------------------------------------------")
                    Console.WriteLine("Count: " &amp; rollupResponse.Results.Count)
                    For i As Integer = 0 To rollupResponse.Results.Count - 1
                        Console.WriteLine()
                        Console.WriteLine("LogicalName: " &amp; rollupResponse.EntityCollection.Entities(i).LogicalName)
                        Console.WriteLine("Id: " &amp; rollupResponse.EntityCollection.Entities(i).Id.ToString())
                    Next i
                    '					#End Region ' Show RollupResponse results

                    DeleteRequiredRecords(promptforDelete)
                End Using

                ' Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            Catch fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                ' You can handle an exception here or pass it back to the calling method.
                Throw
            End Try
        End Sub

		Public Sub CreateRequiredRecords()
			' Create an account
			Dim account As Account = New Account With {.Name = "Fourth Coffee"}
			_accountId = _serviceProxy.Create(account)

			' Create an opportunity
            Dim newOpportunity As Opportunity =
                New Opportunity With
                {
                    .Name = "Opportunity 1",
                    .CustomerId = New EntityReference With
                                  {
                                      .Id = _accountId,
                                      .LogicalName = account.LogicalName
                                  }
                }
			_opportunityId = _serviceProxy.Create(newOpportunity)
		End Sub

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
				' Delete all records created in this sample.
				_serviceProxy.Delete(Account.EntityLogicalName, _accountId)

				Console.WriteLine("Entity record(s) have been deleted.")
			End If

		End Sub

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

				Dim app As New RollupByObject()
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

' </snippetrollupbyobject>
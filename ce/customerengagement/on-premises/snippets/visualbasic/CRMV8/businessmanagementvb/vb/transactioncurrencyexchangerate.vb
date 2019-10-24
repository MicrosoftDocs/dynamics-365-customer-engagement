' <snippettransactioncurrencyexchangerate>


Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports System.ServiceModel

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Discovery

' This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Crm.Sdk.Messages

Namespace Microsoft.Crm.Sdk.Samples
	''' <summary>
	''' Demonstrates how to retrieve a currency's exchange rates.
	''' </summary>
	''' <param name="serverConfig">Contains server connection information.</param>
	''' <param name="promptforDelete">When True, the user will be prompted to delete all
	''' created entities.</param>
	Public Class TransactionCurrencyExchangeRate
		#Region "Class Level Members"

		Private _serviceProxy As OrganizationServiceProxy
		Private _context As ServiceContext

		Private _currency As TransactionCurrency

		#End Region ' Class Level Members

		#Region "How To Sample Code"
		''' <summary>
		''' This method first creates a new currency within the system, setting its 
		''' exchange rate to a pre-defined value. It then issues a 
		''' RetrieveExchangeRateRequest to get the exchange rate from the created 
		''' currency to the organization's base currency. Finally, it retrieves the 
		''' organization's base currency and displays the conversion rate.
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
                    ' using the service context makes retrieving entities easier
                    _context = New ServiceContext(_serviceProxy)
                    Using _context
                        ' This statement is required to enable early-bound type support.
                        _serviceProxy.EnableProxyTypes()

                        Dim currentOrganizatoinUniqueName As String = GetCurrentOrganizationUniqueName(serverConfig)

                        CreateRequiredRecords()

                        Dim request As New RetrieveExchangeRateRequest() With
                            {
                                .TransactionCurrencyId = _currency.Id
                            }
                        Dim response As RetrieveExchangeRateResponse =
                            CType(_serviceProxy.Execute(request), 
                                RetrieveExchangeRateResponse)
                        Console.WriteLine("  Retrieved exchange rate for created currency")

                        ' get the base currency for the current org
                        Dim baseCurrencyName = ( _
                            From currency In _context.TransactionCurrencySet _
                            Join org In _context.OrganizationSet On currency.Id Equals org.BaseCurrencyId.Id _
                            Where org.Name.Equals(serverConfig.OrganizationName) _
                            Select currency.CurrencyName).First()
                        Console.WriteLine("  This organization's base currency is {0}", baseCurrencyName)

                        Console.WriteLine("  The conversion from {0} -> {1} is {2}",
                                          _currency.CurrencyName, baseCurrencyName, response.ExchangeRate)

                        DeleteRequiredRecords(promptforDelete)
                    End Using
                End Using

                ' Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            Catch fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                ' You can handle an exception here or pass it back to the calling method.
                Throw
            End Try
        End Sub

		#Region "Public Methods"

		Public Sub CreateRequiredRecords()
			Console.WriteLine("  Creating currency 'Canadian Dollar'")
			' Create another currency
            _currency = New TransactionCurrency() With
                        {
                            .CurrencyName = "Canadian Dollar",
                            .CurrencyPrecision = 2,
                            .ExchangeRate = CDec(0.9755),
                            .ISOCurrencyCode = "CAD",
                            .CurrencySymbol = "$"
                        }
			_currency.Id = _serviceProxy.Create(_currency)
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
				_serviceProxy.Delete(TransactionCurrency.EntityLogicalName, _currency.Id)
				Console.WriteLine("Entity records have been deleted.")
			End If
		End Sub

		#End Region

        Private Function GetCurrentOrganizationUniqueName(ByVal serverConfig As ServerConnection.Configuration) As String
            Using _discoveryProxy As New DiscoveryServiceProxy(serverConfig.DiscoveryUri, serverConfig.HomeRealmUri, serverConfig.Credentials, serverConfig.DeviceCredentials)
                Dim orgsRequest As New RetrieveOrganizationsRequest() With {.AccessType = EndpointAccessType.Default, .Release = OrganizationRelease.Current}
                Dim organizations As RetrieveOrganizationsResponse = CType(_discoveryProxy.Execute(orgsRequest), RetrieveOrganizationsResponse)

                For Each organization As OrganizationDetail In organizations.Details
                    For Each endpoint In organization.Endpoints
                        If endpoint.Value.ToLowerInvariant() = serverConfig.OrganizationUri.ToString().ToLowerInvariant() Then
                            Return organization.UniqueName
                        End If
                    Next endpoint
                Next organization
            End Using
            Return String.Empty
        End Function

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

				Dim app As New TransactionCurrencyExchangeRate()
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

' </snippettransactioncurrencyexchangerate>
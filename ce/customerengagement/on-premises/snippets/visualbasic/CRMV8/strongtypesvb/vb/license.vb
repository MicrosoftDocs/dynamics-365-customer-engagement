' <snippetlicense>


Imports System
Imports System.Linq
Imports System.ServiceModel

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Query
Imports Microsoft.Xrm.Sdk.Client

' This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Crm.Sdk.Messages

Namespace Microsoft.Crm.Sdk.Samples
	''' <summary>
	''' Demonstrates how to issue the RetrieveDeploymentLicenseTypeRequest and
	''' RetrieveLicenseInfoRequest.
	''' </summary>
	''' <param name="serverConfig">Contains server connection information.</param>
	''' <param name="promptforDelete">When True, the user will be prompted to delete all
	''' created entities.</param>
	Public Class License
		#Region "Class Level Members"

		Private _serviceProxy As OrganizationServiceProxy

		#End Region ' Class Level Members

		#Region "How To Sample Code"
		''' <summary>
		''' This method first executes a RetrieveDeploymentLicenseTypeRequest and 
		''' displays the type of license for this deployment to the console, then 
		''' executes a RetrieveLicenseInfoRequest and displays the number of used 
		''' and available Read-Write licenses there are.
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

                    '					#Region "RetrieveDeploymentLicenseTypeRequest"

                    ' Create the request
                    Dim deploymentTypeRequest = New RetrieveDeploymentLicenseTypeRequest()

                    ' Execute the request
                    Console.WriteLine("  Fetching the license type for this deployment")
                    Dim deploymentTypeResponse =
                        CType(_serviceProxy.Execute(deploymentTypeRequest), 
                            RetrieveDeploymentLicenseTypeResponse)

                    ' Validate results
                    If String.IsNullOrEmpty(deploymentTypeResponse.licenseType) Then
                        Throw New Exception("The request did not return any results")
                    End If

                    Dim licenseId As String =
                        New Guid(deploymentTypeResponse.licenseType).ToString().ToUpper()
                    Select Case licenseId
                        Case "9436EA66-8262-4168-9B6C-21DF47D1D121"
                            Console.WriteLine("  License type: SmallBusiness")
                        Case "5BEEA2E8-8F82-40E8-AE0F-6D8C135E1397"
                            Console.WriteLine("  License type: Professional")
                        Case "CB96BDD5-5F74-4EA5-8323-9D7E20079002"
                            Console.WriteLine("  License type: Enterprise")
                        Case "66AE2919-DD58-40CA-A980-AEF7330B2745"
                            Console.WriteLine("  License type: Live")
                        Case "722E9E15-62DC-48A7-95CF-93131BE27273"
                            Console.WriteLine("  License type: SPLA (Service Provider)")
                        Case Else
                            Console.WriteLine("  Unknown license type with id {0}", licenseId)
                    End Select

                    '					#End Region

                    '					#Region "RetrieveLicenseInfoRequest"

                    ' create the request
                    Dim licenseInfoRequest = New RetrieveLicenseInfoRequest()

                    ' execute the request
                    Console.WriteLine("  Fetching license info")
                    Dim licenseInfoResponse = CType(_serviceProxy.Execute(licenseInfoRequest), 
                        RetrieveLicenseInfoResponse)

                    ' output the results
                    Console.WriteLine("  Number of licenses available: {0}",
                                      licenseInfoResponse.AvailableCount)
                    Console.WriteLine("  Number of licenses used: {0}",
                                      licenseInfoResponse.GrantedLicenseCount)

                    '					#End Region

                End Using

                ' Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            Catch fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                ' You can handle an exception here or pass it back to the calling method.
                Throw
            End Try
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

				Dim app As New License()
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

' </snippetlicense>
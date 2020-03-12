' <snippetfulfillsalesorder>


Imports System
Imports System.Linq
Imports System.ServiceModel
Imports Microsoft.Crm.Sdk.Messages
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Messages
Imports Microsoft.Xrm.Sdk.Metadata
Imports Microsoft.Xrm.Sdk.Query

Namespace Microsoft.Crm.Sdk.Samples
	''' <summary>
	''' This sample creates a SalesOrder record and demonstrates how to use the
	''' FulfillSalesOrderRequest to deactivate the record.
	''' </summary>
	''' <remarks>
	''' At run-time, you will be given the option to delete all the
	''' database records created by this program.
	''' </remarks>
	Public Class FulfillSalesOrder
		#Region "Class Level Members"
		Private _serviceProxy As OrganizationServiceProxy
		Private _salesOrderId? As Guid
		Private _accountId? As Guid
		#End Region

		#Region "How To Sample Code"

		''' <summary>
		''' Creates a sales order and shows how to close using the FulfillSalesOrderRequest 
		''' </summary>
		''' <param name="serverConfig">Contains server connection information.</param>
		''' <param name="promptforDelete">When True, the user will be prompted to delete all
		''' created entities.</param>
        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration,
                       ByVal promptforDelete As Boolean)
            _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
            Using _serviceProxy
                ' This statement is required to enable early-bound type support.
                _serviceProxy.EnableProxyTypes()

                CreateCustomer()
                CreateSalesOrder()
                CloseSalesOrder()
                DeleteRequiredRecords(promptforDelete)
            End Using
        End Sub

		''' <summary>
		''' Creates a customer for the sales order
		''' </summary>
		Private Sub CreateCustomer()
			' Create an account to be used with the sales account.
			_accountId = _serviceProxy.Create(New Account With {.Name = "Microsoft"})

            Console.WriteLine(String.Concat("Created account for sales order: ",
                                            _accountId.Value))
		End Sub

		''' <summary>
		''' Creates the sales order to close 
		''' </summary>
		Private Sub CreateSalesOrder()
			' Create a sales order with an account
            _salesOrderId = _serviceProxy.Create(
                New SalesOrder With
                {
                    .CustomerId = New EntityReference With
                                  {
                                      .LogicalName = Account.EntityLogicalName,
                                      .Id = _accountId.Value
                                  },
                    .Description = "Sales Order Description"
                })

            Console.WriteLine(String.Concat("Created sales order: ",
                                            _salesOrderId.Value))
		End Sub

		''' <summary>
		''' Calls the FulfillSalesOrderRequest and closes it as completed
		''' </summary>
		Private Sub CloseSalesOrder()
			If Not _salesOrderId.HasValue Then
				Return
			End If

			' Close the sales order with a status of Complete
			Dim newStatus As Integer = CInt(Fix(salesorder_statuscode.Complete))
            Dim request = New FulfillSalesOrderRequest With
                          {
                              .OrderClose = New OrderClose With
                                            {
                                                .SalesOrderId = New EntityReference With
                                                                {
                                                                    .LogicalName =
                                                                    SalesOrder.EntityLogicalName,
                                                                    .Id = _salesOrderId.Value
                                                                }
                                            },
                              .Status = New OptionSetValue(newStatus)
                          }

            Console.WriteLine(String.Concat("Executing FullfillSalesOrderRequest on sales order: ",
                                            _salesOrderId.Value,
                                            "," &amp; vbLf &amp; vbTab &amp; " new status: ",
                                            GetLabelForStatus(SalesOrder.EntityLogicalName,
                                                              "statuscode",
                                                              newStatus)))

            _serviceProxy.Execute(request)

            ' Validate that the sales order is complete
            Dim mySalesOrder = _serviceProxy.Retrieve(SalesOrder.EntityLogicalName,
                                                      _salesOrderId.Value,
                                                      New ColumnSet("statuscode")).ToEntity(Of SalesOrder)()

            Console.WriteLine(String.Concat("Validation of closed sales order: ",
                                            _salesOrderId.Value,
                                            "," &amp; vbLf &amp; vbTab &amp; " status: ",
                                            mySalesOrder.FormattedValues("statuscode")))
		End Sub

		''' <summary>
		''' Returns the label for a status option
		''' </summary>
		''' <param name="entity">entity logical name</param>
		''' <param name="attribute">statuscode </param>
		''' <param name="value">numeric value</param>
		''' <returns>user label</returns>
        Private Function GetLabelForStatus(ByVal entity As String,
                                           ByVal attribute As String,
                                           ByVal value As Integer) As String
            ' Retrieve the attribute metadata
            Dim attributeMD = (CType(_serviceProxy.Execute(
                               New RetrieveAttributeRequest With
                               {
                                   .EntityLogicalName = entity,
                                   .LogicalName = attribute,
                                   .RetrieveAsIfPublished = True
                               }), RetrieveAttributeResponse)).AttributeMetadata

            ' find the option based on the numeric value and return the label
            If attributeMD.AttributeType = AttributeTypeCode.Status Then
                Dim options = (CType(attributeMD, StatusAttributeMetadata)).OptionSet.Options

                Dim crmOption = options.FirstOrDefault(Function(x) x.Value.Value = value)
                If crmOption IsNot Nothing Then
                    Return crmOption.Label.UserLocalizedLabel.Label
                End If
            End If

            Return String.Empty
        End Function

		''' <summary>
		''' 
		''' </summary>
		''' <param name="prompt"></param>
		Private Sub DeleteRequiredRecords(ByVal prompt As Boolean)
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
				' Delete records created in this sample.  Delete the sales order first
				' or there will be an error due to restrict delete.
				If _salesOrderId.HasValue Then
                    Console.WriteLine(String.Concat("Deleting sales order: ",
                                                    _salesOrderId.Value))
                    _serviceProxy.Delete(SalesOrder.EntityLogicalName,
                                         _salesOrderId.Value)
				End If
				If _accountId.HasValue Then
                    Console.WriteLine(String.Concat("Deleting account: ",
                                                    _accountId.Value))
                    _serviceProxy.Delete(Account.EntityLogicalName,
                                         _accountId.Value)
				End If

				Console.WriteLine("Entity records have been deleted.")
			End If
		End Sub

		#End Region

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

				Dim app = New FulfillSalesOrder()
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
		#End Region
	End Class
End Namespace

' </snippetfulfillsalesorder>
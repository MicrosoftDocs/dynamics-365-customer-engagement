' <snippetconvertsalesordertoinvoice>


'                    #Region "Convert SalesOrder to Invoice"

                    ' Define columns to be retrieved after creating the invoice
                    Dim invoiceColumns As New ColumnSet("invoiceid", "totalamount")

                    ' Convert the order to an invoice
                    Dim convertOrderRequest As New ConvertSalesOrderToInvoiceRequest() With
                        {
                            .SalesOrderId = _salesOrderId,
                            .ColumnSet = invoiceColumns
                        }
                    Dim convertOrderResponse As ConvertSalesOrderToInvoiceResponse =
                        CType(_serviceProxy.Execute(convertOrderRequest), 
                            ConvertSalesOrderToInvoiceResponse)
					Dim invoice_Renamed As Invoice = CType(convertOrderResponse.Entity, Invoice)
					_invoiceId = invoice_Renamed.Id

                    Console.WriteLine("Converted SalesOrder to Invoice.")

' </snippetconvertsalesordertoinvoice>
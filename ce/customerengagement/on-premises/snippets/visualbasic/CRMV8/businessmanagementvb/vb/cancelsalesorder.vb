' <snippetcancelsalesorder>


 ' Define columns to be retrieved after creating the order
 salesOrderColumns = New ColumnSet("salesorderid", "totalamount")

 ' Convert the quote to a sales order
 convertQuoteRequest = New ConvertQuoteToSalesOrderRequest() With
                       {
                           .QuoteId = _quoteId,
                           .ColumnSet = salesOrderColumns
                       }
 convertQuoteResponse = CType(_serviceProxy.Execute(convertQuoteRequest), 
     ConvertQuoteToSalesOrderResponse)
 Dim closeSalesOrder As SalesOrder = CType(convertQuoteResponse.Entity, 
     SalesOrder)
 _closeSalesOrderId = closeSalesOrder.Id

 Dim cancelRequest As New CancelSalesOrderRequest() With
     {
         .OrderClose = New OrderClose() With
                       {
                           .SalesOrderId = closeSalesOrder.ToEntityReference(),
                           .Subject = "Close Sales Order " &amp; Date.Now
                       },
         .Status = New OptionSetValue(-1)
     }
 _serviceProxy.Execute(cancelRequest)

 Console.WriteLine("Canceled sales order")

' </snippetcancelsalesorder>
// <snippetcancelsalesorder>



 // Define columns to be retrieved after creating the order
 salesOrderColumns = new ColumnSet("salesorderid", "totalamount");

 // Convert the quote to a sales order
 convertQuoteRequest =
     new ConvertQuoteToSalesOrderRequest()
     {
         QuoteId = _quoteId,
         ColumnSet = salesOrderColumns
     };
 convertQuoteResponse =
     (ConvertQuoteToSalesOrderResponse)_serviceProxy.Execute(convertQuoteRequest);
 SalesOrder closeSalesOrder = (SalesOrder)convertQuoteResponse.Entity;
 _closeSalesOrderId = closeSalesOrder.Id;

 CancelSalesOrderRequest cancelRequest = new CancelSalesOrderRequest()
 {
     OrderClose = new OrderClose()
     {
         SalesOrderId = closeSalesOrder.ToEntityReference(),
         Subject = "Close Sales Order " + DateTime.Now
     },
     Status = new OptionSetValue(-1)
 };
 _serviceProxy.Execute(cancelRequest);

 Console.WriteLine("Canceled sales order");

// </snippetcancelsalesorder>
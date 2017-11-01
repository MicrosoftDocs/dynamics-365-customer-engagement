// <snippetconvertquotetosalesorder>


 // Define columns to be retrieved after creating the order
 ColumnSet salesOrderColumns =
     new ColumnSet("salesorderid", "totalamount");

 // Convert the quote to a sales order
 ConvertQuoteToSalesOrderRequest convertQuoteRequest =
     new ConvertQuoteToSalesOrderRequest()
     {
         QuoteId = _quoteId,
         ColumnSet = salesOrderColumns
     };
 ConvertQuoteToSalesOrderResponse convertQuoteResponse =
     (ConvertQuoteToSalesOrderResponse)_serviceProxy.Execute(convertQuoteRequest);
 SalesOrder salesOrder = (SalesOrder)convertQuoteResponse.Entity;
 _salesOrderId = salesOrder.Id;

// </snippetconvertquotetosalesorder>
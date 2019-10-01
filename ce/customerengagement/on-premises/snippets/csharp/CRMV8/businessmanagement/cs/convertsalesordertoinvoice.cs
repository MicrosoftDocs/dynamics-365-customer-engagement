// <snippetconvertsalesordertoinvoice>


 #region Convert SalesOrder to Invoice

 // Define columns to be retrieved after creating the invoice
 ColumnSet invoiceColumns =
     new ColumnSet("invoiceid", "totalamount");

 // Convert the order to an invoice
 ConvertSalesOrderToInvoiceRequest convertOrderRequest =
     new ConvertSalesOrderToInvoiceRequest()
     {
         SalesOrderId = _salesOrderId,
         ColumnSet = invoiceColumns
     };
 ConvertSalesOrderToInvoiceResponse convertOrderResponse =
     (ConvertSalesOrderToInvoiceResponse)_serviceProxy.Execute(convertOrderRequest);
 Invoice invoice = (Invoice)convertOrderResponse.Entity;
 _invoiceId = invoice.Id;

// </snippetconvertsalesordertoinvoice>
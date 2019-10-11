' <snippetconvertquotetosalesorder>


 ' Define columns to be retrieved after creating the order
 Dim salesOrderColumns As New ColumnSet("salesorderid", "totalamount")

 ' Convert the quote to a sales order
 Dim convertQuoteRequest As New ConvertQuoteToSalesOrderRequest() With
     {
         .QuoteId = _quoteId,
         .ColumnSet = salesOrderColumns
     }
 Dim convertQuoteResponse As ConvertQuoteToSalesOrderResponse =
     CType(_serviceProxy.Execute(convertQuoteRequest), 
         ConvertQuoteToSalesOrderResponse)
 Dim salesOrder_Renamed As SalesOrder = CType(convertQuoteResponse.Entity, 
     SalesOrder)
 _salesOrderId = salesOrder_Renamed.Id

 Console.WriteLine("Converted Quote to SalesOrder.")

' </snippetconvertquotetosalesorder>
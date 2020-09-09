' <snippetlocksalesorderpricing>


 ' Relock the order pricing
 Dim lockOrderRequest As New LockSalesOrderPricingRequest() With
     {
         .SalesOrderId = _salesOrderId
     }
 _serviceProxy.Execute(lockOrderRequest)

' </snippetlocksalesorderpricing>
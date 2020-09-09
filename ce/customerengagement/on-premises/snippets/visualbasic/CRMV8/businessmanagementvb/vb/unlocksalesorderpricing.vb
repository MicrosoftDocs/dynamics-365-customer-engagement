' <snippetunlocksalesorderpricing>


 ' Unlock the order pricing
 Dim unlockOrderRequest As New UnlockSalesOrderPricingRequest() With
     {.SalesOrderId = _salesOrderId}
 _serviceProxy.Execute(unlockOrderRequest)

' </snippetunlocksalesorderpricing>
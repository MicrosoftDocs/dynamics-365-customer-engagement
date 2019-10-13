// <snippetunlocksalesorderpricing>


 // Unlock the order pricing
 UnlockSalesOrderPricingRequest unlockOrderRequest =
     new UnlockSalesOrderPricingRequest()
     {
         SalesOrderId = _salesOrderId
     };
 _serviceProxy.Execute(unlockOrderRequest);

// </snippetunlocksalesorderpricing>
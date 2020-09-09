// <snippetlocksalesorderpricing>


 // Relock the order pricing
 LockSalesOrderPricingRequest lockOrderRequest =
     new LockSalesOrderPricingRequest()
     {
         SalesOrderId = _salesOrderId
     };
 _serviceProxy.Execute(lockOrderRequest);

// </snippetlocksalesorderpricing>
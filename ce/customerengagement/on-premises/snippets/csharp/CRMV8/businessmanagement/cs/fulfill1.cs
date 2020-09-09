// <snippetfulfill1>


 
   // Close the sales order with a status of Complete
   int newStatus = (int)salesorder_statuscode.Complete;
   var request = new FulfillSalesOrderRequest
   {
       OrderClose = new OrderClose
       {
           SalesOrderId = new EntityReference 
               { LogicalName = SalesOrder.EntityLogicalName, Id = _salesOrderId.Value }
           
       },
       Status = new OptionSetValue(newStatus)
   };

   Console.WriteLine(String.Concat("Executing FullfillSalesOrderRequest on sales order: ",
       _salesOrderId.Value, ",\n\t new status: ", 
       GetLabelForStatus(SalesOrder.EntityLogicalName, "statuscode", newStatus))); 
   
   _serviceProxy.Execute(request);

// </snippetfulfill1>
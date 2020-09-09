// <snippetupdaterequest>



 // Retrieve current price list
 ProductPriceLevel priceListItem =
     (ProductPriceLevel)_serviceProxy.Retrieve(
         ProductPriceLevel.EntityLogicalName,
         _priceListItemId,
         new ColumnSet("productpricelevelid", "amount")
     );

 Console.WriteLine("Current price list retrieved.");
 Console.WriteLine();

 Console.WriteLine("Details before update:");
 Console.WriteLine("----------------");
 Console.WriteLine("Current order total: {0}",
     salesOrder.TotalAmount.Value);
 Console.WriteLine("Current price per item: {0}",
     priceListItem.Amount.Value);
 Console.WriteLine("</End of Listing>");
 Console.WriteLine();

 // Update the price list
 priceListItem.Amount = new Money(30.0M);

 UpdateRequest updatePriceListItem = new UpdateRequest()
 {
     Target = priceListItem,
 };
 _serviceProxy.Execute(updatePriceListItem);

 Console.WriteLine("Price list updated.");

// </snippetupdaterequest>
// <snippetupdatepricelist>


 // Update the price list
 priceListItem.Amount = new Money(40.0M);

 updatePriceListItem = new UpdateRequest()
 {
     Target = priceListItem
 };
 _serviceProxy.Execute(updatePriceListItem);

 Console.WriteLine("Price list updated.");

// </snippetupdatepricelist>
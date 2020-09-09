' <snippetupdaterequest>



 ' Retrieve current price list
 Dim priceListItem As ProductPriceLevel =
     CType(_serviceProxy.Retrieve(ProductPriceLevel.EntityLogicalName,
                                  _priceListItemId,
                                  New ColumnSet("productpricelevelid", "amount")), 
                              ProductPriceLevel)

 Console.WriteLine("Current price list retrieved.")
 Console.WriteLine()

 Console.WriteLine("Details before update:")
 Console.WriteLine("----------------")
 Console.WriteLine("Current order total: {0}",
                   salesOrder_Renamed.TotalAmount.Value)
 Console.WriteLine("Current price per item: {0}",
                   priceListItem.Amount.Value)
 Console.WriteLine("</End of Listing>")
 Console.WriteLine()

 ' Update the price list
 priceListItem.Amount = New Money(30D)

 Dim updatePriceListItem As New UpdateRequest() With {.Target = priceListItem}
 _serviceProxy.Execute(updatePriceListItem)

 Console.WriteLine("Price list updated.")

' </snippetupdaterequest>
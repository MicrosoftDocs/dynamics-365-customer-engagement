' <snippetlockinvoicepricing>


 ' Lock the invoice pricing
 Dim lockInvoiceRequest As New LockInvoicePricingRequest() With {.InvoiceId = _invoiceId}
 _serviceProxy.Execute(lockInvoiceRequest)

 Console.WriteLine("Invoice pricing locked.")

 ' Update the price list
 priceListItem.Amount = New Money(40D)

 updatePriceListItem = New UpdateRequest() With {.Target = priceListItem}
 _serviceProxy.Execute(updatePriceListItem)

 Console.WriteLine("Price list updated.")

' </snippetlockinvoicepricing>
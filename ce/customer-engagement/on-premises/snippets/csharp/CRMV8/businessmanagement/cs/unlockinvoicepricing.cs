// <snippetunlockinvoicepricing>



 // Retrieve the invoice
 Invoice updatedInvoice = (Invoice)_serviceProxy.Retrieve(
         Invoice.EntityLogicalName,
         _invoiceId,
         new ColumnSet("invoiceid", "totalamount")
     );

 Console.WriteLine("Updated invoice retrieved.");
 Console.WriteLine();

 Console.WriteLine("Details after lock and update:");
 Console.WriteLine("----------------");
 Console.WriteLine("Current invoice total: {0}",
     updatedInvoice.TotalAmount.Value);
 Console.WriteLine("Current price per item: {0}",
     priceListItem.Amount.Value);
 Console.WriteLine("</End of Listing>");
 Console.WriteLine();

 // Unlock the invoice pricing
 UnlockInvoicePricingRequest unlockInvoiceRequest =
     new UnlockInvoicePricingRequest()
     {
         InvoiceId = _invoiceId
     };
 _serviceProxy.Execute(unlockInvoiceRequest);

 Console.WriteLine("Invoice pricing unlocked.");

// </snippetunlockinvoicepricing>
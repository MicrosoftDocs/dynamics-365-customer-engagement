// <snippetlockinvoicepricing>


 // Relock the invoice pricing
 LockInvoicePricingRequest lockInvoiceRequest =
     new LockInvoicePricingRequest()
     {
         InvoiceId = _invoiceId
     };
 _serviceProxy.Execute(lockInvoiceRequest);

 Console.WriteLine("Invoice pricing relocked.");

// </snippetlockinvoicepricing>
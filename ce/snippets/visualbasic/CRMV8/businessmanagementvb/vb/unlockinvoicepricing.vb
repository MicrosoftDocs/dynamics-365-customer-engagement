' <snippetunlockinvoicepricing>


 ' Unlock the invoice pricing
 Dim unlockInvoiceRequest As New UnlockInvoicePricingRequest() With
     {
         .InvoiceId = _invoiceId
     }
 _serviceProxy.Execute(unlockInvoiceRequest)

 Console.WriteLine("Invoice pricing unlocked.")

' </snippetunlockinvoicepricing>
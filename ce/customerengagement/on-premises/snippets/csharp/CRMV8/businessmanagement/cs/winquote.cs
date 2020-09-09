// <snippetwinquote>



 // Mark the quote as won
 // Note: this is necessary in order to convert a quote into a 
 // SalesOrder.
 WinQuoteRequest winQuoteRequest = new WinQuoteRequest()
 {
     QuoteClose = new QuoteClose()
     {
         Subject = "Quote Close" + DateTime.Now.ToString(),
         QuoteId = quote.ToEntityReference()
     },
     Status = new OptionSetValue(-1)
 };
 _serviceProxy.Execute(winQuoteRequest);

 Console.WriteLine("Quote won.");

// </snippetwinquote>
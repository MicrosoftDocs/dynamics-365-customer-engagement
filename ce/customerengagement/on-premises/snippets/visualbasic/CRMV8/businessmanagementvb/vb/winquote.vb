' <snippetwinquote>


 ' Mark the quote as won
 ' Note: this is necessary in order to convert a quote into a 
 ' SalesOrder.
 Dim winQuoteRequest_Renamed As New WinQuoteRequest() With
     {
         .QuoteClose =
         New QuoteClose() With
         {
             .Subject = "Quote Close" &amp; Date.Now.ToString(),
             .QuoteId = quote_Renamed.ToEntityReference()
         },
         .Status = New OptionSetValue(-1)
     }
 _serviceProxy.Execute(winQuoteRequest_Renamed)

 Console.WriteLine("Quote won.")

' </snippetwinquote>
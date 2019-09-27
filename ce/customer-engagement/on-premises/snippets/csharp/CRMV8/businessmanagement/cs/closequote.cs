// <snippetclosequote>


 // convert the opportunity to a quote
 genQuoteFromOppRequest = new GenerateQuoteFromOpportunityRequest
 {
     OpportunityId = _opportunityId,
     ColumnSet = new ColumnSet("quoteid", "name")
 };
 genQuoteFromOppResponse = (GenerateQuoteFromOpportunityResponse)
     _serviceProxy.Execute(genQuoteFromOppRequest);

 Quote closeQuote = genQuoteFromOppResponse.Entity.ToEntity<Quote>();
 _closeQuoteId = closeQuote.Id;

 // Activate the quote
 SetStateRequest activateQuote = new SetStateRequest()
 {
     EntityMoniker = closeQuote.ToEntityReference(),
     State = new OptionSetValue((int)QuoteState.Active),
     Status = new OptionSetValue((int)quote_statuscode.InProgress)
 };
 _serviceProxy.Execute(activateQuote);

 // Close the quote
 CloseQuoteRequest closeQuoteRequest = new CloseQuoteRequest()
 {
     QuoteClose = new QuoteClose()
     {
         QuoteId = closeQuote.ToEntityReference(),
         Subject = "Quote Close " + DateTime.Now.ToString()
     },
     Status = new OptionSetValue(-1)
 };
 _serviceProxy.Execute(closeQuoteRequest);

 Console.WriteLine("Quote Closed");

// </snippetclosequote>
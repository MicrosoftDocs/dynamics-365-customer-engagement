// <snippetgeneratequotefromopportunity>


 // Convert the opportunity to a quote
 var genQuoteFromOppRequest = new GenerateQuoteFromOpportunityRequest
 {
     OpportunityId = _opportunityId,
     ColumnSet = new ColumnSet("quoteid", "name")
 };

 var genQuoteFromOppResponse = (GenerateQuoteFromOpportunityResponse)
     _serviceProxy.Execute(genQuoteFromOppRequest);

 Quote quote = genQuoteFromOppResponse.Entity.ToEntity<Quote>();
 _quoteId = quote.Id;

 Console.WriteLine("Quote generated from the Opportunity.");

// </snippetgeneratequotefromopportunity>
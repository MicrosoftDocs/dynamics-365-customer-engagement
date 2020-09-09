// <snippetconvertopportunitytoquote1>


 // Convert an opportunity to quote.
 GenerateQuoteFromOpportunityRequest quoteRequest = new GenerateQuoteFromOpportunityRequest()
 {
     // Columns that will be transferred
     ColumnSet = new ColumnSet("name", "customerid"),
     OpportunityId = _opportunityId
 };

 GenerateQuoteFromOpportunityResponse quoteResponse =
     (GenerateQuoteFromOpportunityResponse)_serviceProxy.Execute(quoteRequest);

 _quoteId = quoteResponse.Entity.Id;

// </snippetconvertopportunitytoquote1>
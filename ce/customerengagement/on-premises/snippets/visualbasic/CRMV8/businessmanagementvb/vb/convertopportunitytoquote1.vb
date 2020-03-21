' <snippetconvertopportunitytoquote1>


 ' Convert an opportunity to quote.
 Dim quoteRequest As New GenerateQuoteFromOpportunityRequest() With { _
     .ColumnSet = New ColumnSet("name", "customerid"), .OpportunityId = _opportunityId}
     ' Columns that will be transferred

 Dim quoteResponse As GenerateQuoteFromOpportunityResponse = _
     CType(_serviceProxy.Execute(quoteRequest), GenerateQuoteFromOpportunityResponse)

 _quoteId = quoteResponse.Entity.Id

' </snippetconvertopportunitytoquote1>
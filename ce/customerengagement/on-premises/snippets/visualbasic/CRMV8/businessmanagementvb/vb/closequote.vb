' <snippetclosequote>


 ' convert the opportunity to a quote
 genQuoteFromOppRequest =
     New GenerateQuoteFromOpportunityRequest With
     {
         .OpportunityId = _opportunityId,
         .ColumnSet = New ColumnSet("quoteid", "name")
     }
 genQuoteFromOppResponse = CType(_serviceProxy.Execute(genQuoteFromOppRequest), 
     GenerateQuoteFromOpportunityResponse)

 Dim closeQuote As Quote = genQuoteFromOppResponse.Entity.ToEntity(Of Quote)()
 _closeQuoteId = closeQuote.Id

 ' Activate the quote
 Dim activateQuote As New SetStateRequest() With
     {
         .EntityMoniker = closeQuote.ToEntityReference(),
         .State = New OptionSetValue(CInt(Fix(QuoteState.Active))),
         .Status = New OptionSetValue(CInt(Fix(quote_statuscode.InProgress)))
     }
 _serviceProxy.Execute(activateQuote)

 ' Close the quote
 Dim closeQuoteRequest_Renamed As New CloseQuoteRequest() With
     {
         .QuoteClose = New QuoteClose() With
                       {
                           .QuoteId = closeQuote.ToEntityReference(),
                           .Subject = "Quote Close " &amp; Date.Now.ToString()
                       },
         .Status = New OptionSetValue(-1)
     }
 _serviceProxy.Execute(closeQuoteRequest_Renamed)

 Console.WriteLine("Quote Closed")

' </snippetclosequote>
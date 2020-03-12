' <snippetgeneratequotefromopportunity>


 ' Convert the opportunity to a quote
 Dim genQuoteFromOppRequest =
     New GenerateQuoteFromOpportunityRequest With
     {
         .OpportunityId = _opportunityId,
         .ColumnSet = New ColumnSet("quoteid", "name")
     }

 Dim genQuoteFromOppResponse = CType(
     _serviceProxy.Execute(genQuoteFromOppRequest), 
     GenerateQuoteFromOpportunityResponse)

 Dim quote_Renamed As Quote = genQuoteFromOppResponse.Entity.ToEntity(Of Quote)()
 _quoteId = quote_Renamed.Id

 Console.WriteLine("Quote generated from the Opportunity.")

' </snippetgeneratequotefromopportunity>
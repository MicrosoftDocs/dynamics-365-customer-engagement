// <snippetretrievemultipleconditionoperatorsfetch8>


	fetchXml = @"<fetch aggregate='true'>
					<entity name='salesorder'>
						<attribute name='totalamount' aggregate='sum' alias='total'/>
						<attribute name='datefulfilled' groupby='true' dategrouping='fiscal-year' alias='datefulfilled'/>
					</entity>
				 </fetch>";

	// Build fetch request and obtain results.
                efr = new RetrieveMultipleRequest()
                {
                    Query = new FetchExpression(fetchXml)
                };
                entityResults = ((RetrieveMultipleResponse)_service.Execute(efr)).EntityCollection;

	// Display results.
	Console.WriteLine("List totals of all orders grouped by year");
	Console.WriteLine("=========================================");
                foreach (var e in entityResults.Entities)
                {
                    Console.WriteLine("Fetch Retrieved Total: {0}", e.FormattedValues["total"]);
                } 
                
		Console.WriteLine("<End of Listing>");
                Console.WriteLine();

// </snippetretrievemultipleconditionoperatorsfetch8>
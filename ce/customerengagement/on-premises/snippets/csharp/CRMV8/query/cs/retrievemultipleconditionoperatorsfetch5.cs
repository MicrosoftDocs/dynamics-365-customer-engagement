// <snippetretrievemultipleconditionoperatorsfetch5>


	fetchXml = @"<fetch>
					<entity name='salesorder'>
							<attribute name='name'/>
							<filter type='and'>
									<condition attribute='datefulfilled'
											   operator='in-fiscal-year'
											   value='2008'/>
							</filter>
					</entity>
				</fetch>";

	// Build fetch request and obtain results.
                efr = new RetrieveMultipleRequest()
                {
                    Query = new FetchExpression(fetchXml)
                };
                entityResults = ((RetrieveMultipleResponse)_service.Execute(efr)).EntityCollection;

	
	// Display results.
	Console.WriteLine("List all orders fulfilled in fiscal year 2008");
	Console.WriteLine("=============================================");
                foreach (var e in entityResults.Entities)
                {
                    Console.WriteLine("Fetch Retrieved: {0}", e.Attributes["name"]);
                }
	Console.WriteLine("<End of Listing>");
                Console.WriteLine();

// </snippetretrievemultipleconditionoperatorsfetch5>
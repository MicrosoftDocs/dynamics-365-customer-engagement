// <snippetretrievemultipleconditionoperatorsfetch4>


	fetchXml = @"<fetch>
					<entity name='opportunity'>
							<attribute name='name'/>
							<filter type='and'>
									<condition attribute='estimatedclosedate'
											   operator='next-x-fiscal-years'
											   value='3'/>
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
	Console.WriteLine("List all opportunities with estimated close date in next 3 fiscal years");
	Console.WriteLine("=======================================================================");
                foreach (var e in entityResults.Entities)
                {
                    Console.WriteLine("Fetch Retrieved: {0}", e.Attributes["name"]);
                };
                
	Console.WriteLine("<End of Listing>");
                Console.WriteLine();

// </snippetretrievemultipleconditionoperatorsfetch4>
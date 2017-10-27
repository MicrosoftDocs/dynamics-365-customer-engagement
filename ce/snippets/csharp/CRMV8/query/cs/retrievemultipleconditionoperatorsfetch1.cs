// <snippetretrievemultipleconditionoperatorsfetch1>


				// Connect to the Organization service. 
				// The using statement assures that the service proxy will be properly disposed.
				using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
				{
					// This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes();

                    _service = (IOrganizationService)_serviceProxy;

					CreateRequiredRecords();

					#region SQL Query Translated to Fetch
					// Build the following SQL query using QueryExpression:
					//
					//		SELECT contact.fullname, contact.address1_telephone1
					//		FROM contact
					//			LEFT OUTER JOIN account
					//				ON contact.parentcustomerid = account.accountid
					//				AND
					//				account.name = 'Litware, Inc.'
					//		WHERE (contact.address1_stateorprovince = 'WA'
					//		AND
					//			contact.address1_city in ('Redmond', 'Bellevue', 'Kirkland', 'Seattle')
					//		AND 
					//			contact.address1_telephone1 like '(206)%'
					//			OR
					//			contact.address1_telephone1 like '(425)%'
					//		AND
					//			DATEDIFF(DAY, contact.createdon, GETDATE()) > 0
					//		AND
					//			DATEDIFF(DAY, contact.createdon, GETDATE()) < 30
					//		AND
					//			contact.emailaddress1 Not NULL
					//			   )

					String fetchXml = @"<fetch mapping=""logical"" count=""50"" version=""1.0"">
											<entity name=""contact"">
												<attribute name=""address1_telephone1"" />
												<attribute name=""contactid"" />
												<attribute name=""firstname"" />
												<attribute name=""lastname"" />
												<filter>
													<condition attribute=""address1_stateorprovince"" operator=""eq"" value=""WA"" />
													<condition attribute=""address1_city"" operator=""in"">
														<value>Redmond</value>
														<value>Bellevue</value>
														<value>Kirkland</value>
														<value>Seattle</value>
													</condition>
													<condition attribute=""createdon"" operator=""last-x-days"" value=""30"" />
													<condition attribute=""emailaddress1"" operator=""not-null"" />
													<filter type=""or"">
														<condition attribute=""address1_telephone1"" operator=""like"" value=""(206)%"" />
														<condition attribute=""address1_telephone1"" operator=""like"" value=""(425)%"" />
													</filter>
												</filter>
												<link-entity name=""account"" from=""accountid"" to=""parentcustomerid"">
													<filter>
														<condition attribute=""name"" operator=""eq"" value=""Litware, Inc."" />
													</filter>
												</link-entity>
											</entity>
										</fetch>";

					// Build fetch request and obtain results.
                    RetrieveMultipleRequest efr = new RetrieveMultipleRequest()
                    {
                        Query = new FetchExpression(fetchXml)
                    };

                    EntityCollection entityResults = ((RetrieveMultipleResponse)_service.Execute(efr)).EntityCollection;
 

					// Display the results.
					Console.WriteLine("List all contacts matching specified parameters");
					Console.WriteLine("===============================================");
                    foreach (var e in entityResults.Entities)
                    {
                        Console.WriteLine("Contact ID: {0}", e.Id);
                    }


					Console.WriteLine("<End of Listing>");
                    Console.WriteLine();
					#endregion

					#region Find all orders fulfilled in the last fiscal period
					fetchXml = @"<fetch>
									<entity name='salesorder'>
										<attribute name='name'/>
										<filter type='and'>
											<condition attribute='datefulfilled' 
												operator='last-fiscal-period'/>
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
					Console.WriteLine("List all orders fulfilled in the last fiscal period");
					Console.WriteLine("===================================================");
                    foreach (var e in entityResults.Entities)
                    {
                        Console.WriteLine("Fetch Retrieved: {0}", e.Attributes["name"]);
                    }

					Console.WriteLine("<End of Listing>");
                    Console.WriteLine();
					#endregion

					#region Find all Opportunities with estimated close date in next 3 fiscal years
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
					#endregion

					#region Find all Orders fulfilled in fiscal year 2008
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
					#endregion

					#region Find all Orders fulfilled in period 3 of any fiscal year
					fetchXml = @"<fetch>
									<entity name='salesorder'>
											<attribute name='name'/>
											<filter type='and'>
													<condition attribute='datefulfilled'
															   operator='in-fiscal-period'
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
					Console.WriteLine("List all orders fulfilled in period 3 of any fiscal year");
					Console.WriteLine("========================================================");
                    foreach (var e in entityResults.Entities)
                    {
                        Console.WriteLine("Fetch Retrieved: {0}", e.Attributes["name"]);
                    }
					Console.WriteLine("<End of Listing>");
                    Console.WriteLine();
					#endregion

					#region Find all Orders fulfilled in period 3 of fiscal year 2008
					fetchXml = @"<fetch>
									<entity name='salesorder'>
											<attribute name='name'/>
											<filter type='and'>
													<condition attribute='datefulfilled' operator='in-fiscal-period-and-year'>
															<value>3</value>
															<value>2008</value>
													</condition>
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
					Console.WriteLine("List all orders fulfilled in period 3 of fiscal year 2008");
					Console.WriteLine("=========================================================");
                    foreach (var e in entityResults.Entities)
                    {
                        Console.WriteLine("Fetch Retrieved: {0}", e.Attributes["name"]);
                    }
					Console.WriteLine("<End of Listing>");
                    Console.WriteLine();
					#endregion

					// Note: the following two queries use aggregation which is only
					// possible to perform in Fetch, not in QueryExpression or LINQ.

					#region Sum the total amount of all orders, grouped by year
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
					#endregion

					#region Sum the total amount of all Orders grouped by period and year
					fetchXml = @"<fetch aggregate='true'>
									<entity name='salesorder'>
										<attribute name='totalamount' aggregate='sum' alias='total'/>
										<attribute name='datefulfilled' groupby='true' dategrouping='fiscal-period' alias='datefulfilled'/>
									</entity>
								 </fetch>";

					// Build fetch request and obtain results.
                    efr = new RetrieveMultipleRequest()
                    {
                        Query = new FetchExpression(fetchXml)
                    };
                    entityResults = ((RetrieveMultipleResponse)_service.Execute(efr)).EntityCollection;

					
					// Display results.
					Console.WriteLine("List total of all orders grouped by period and year");
					Console.WriteLine("===================================================");
                    foreach (var e in entityResults.Entities)
                    {
                        Console.WriteLine("Fetch Retrieved: {0}", e.FormattedValues["total"]);
                    }
					Console.WriteLine("<End of Listing>");
                    Console.WriteLine();
					#endregion

					DeleteRequiredRecords(promptforDelete);
				}

// </snippetretrievemultipleconditionoperatorsfetch1>
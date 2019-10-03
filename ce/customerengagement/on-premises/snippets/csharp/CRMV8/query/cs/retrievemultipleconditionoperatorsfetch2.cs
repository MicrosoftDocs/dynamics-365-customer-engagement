// <snippetretrievemultipleconditionoperatorsfetch2>


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

// </snippetretrievemultipleconditionoperatorsfetch2>
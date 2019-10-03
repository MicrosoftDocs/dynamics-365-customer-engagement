// <snippetretrievemultipleconditionoperatorsfetch>


using System;
using System.Linq;
using System.Xml.Linq;
using System.ServiceModel;
using System.Collections.Generic;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Xrm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
	/// <summary>
	/// Demonstrates how to do use retrieve multiple condition operators for all
	/// query types.</summary>
	/// <remarks>
	/// At run-time, you will be given the option to delete all the
	/// database records created by this program.</remarks>
	public class RetrieveMultipleConditionOperatorsFetch
	{
		#region Class Level Members

		private Guid _accountId;
		private Guid _productId;
		private Guid _priceLevelId;
		private Guid _productPriceId;
		private Guid _unitGroupId;
		private List<Guid> _contactIdList = new List<Guid>();
		private List<Guid> _opportunityIdList = new List<Guid>();
		private List<Guid> _orderIdList = new List<Guid>();
		private OrganizationServiceProxy _serviceProxy;
        private IOrganizationService _service;

		#endregion Class Level Members

		#region How To Sample Code
		/// <summary>
		/// This method first connects to the Organization service. Afterwards,
		/// basic Fetch queries are performed.
		/// </summary>
		/// <param name="serverConfig">Contains server connection information.</param>
		/// <param name="promptforDelete">When True, the user will be prompted to delete all
		/// created entities.</param>
		public void Run(ServerConnection.Configuration serverConfig, bool promptforDelete)
		{
			try
			{
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
			}

			// Catch any service fault exceptions that Microsoft Dynamics CRM throws.
			catch (FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault>)
			{
				// You can handle an exception here or pass it back to the calling method.
				throw;
			}
		}

		/// <summary>
		/// Creates any entity records that this sample requires.
		/// </summary>
		public void CreateRequiredRecords()
		{
			// Create a unit group.
			UoMSchedule unitGroup = new UoMSchedule
			{
				Name = "Example Unit Group",
				BaseUoMName = "Example Primary Unit"
			};
			_unitGroupId = _service.Create(unitGroup);

			// Retrieve the unit.
			QueryExpression unitQuery = new QueryExpression()
			{
				EntityName = UoM.EntityLogicalName,
				ColumnSet = new ColumnSet("uomid", "name"),
				Criteria =
				{
					Conditions = 
					{
						new ConditionExpression ("uomscheduleid", ConditionOperator.Equal, _unitGroupId)
					}
				},
				PageInfo = new PagingInfo
				{
					PageNumber = 1,
					Count = 1
				}
			};
			UoM unit = (UoM)_service.RetrieveMultiple(unitQuery).Entities[0];

			// Create an account.
			Account account = new Account
			{
				Name = "Litware, Inc.",
				Address1_StateOrProvince = "Colorado"
			};
			_accountId = (_service.Create(account));

			// Create the 2 contacts.
			Contact contact = new Contact()
			{
				FirstName = "Ben",
				LastName = "Andrews",
				EMailAddress1 = "sample@example.com",
				Address1_City = "Redmond",
				Address1_StateOrProvince = "WA",
				Address1_Telephone1 = "(206)555-5555",
				ParentCustomerId = new EntityReference
				{
					Id = _accountId,
					LogicalName = account.LogicalName
				}
			};
			_contactIdList.Add(_service.Create(contact));

			contact = new Contact()
			{
				FirstName = "Colin",
				LastName = "Wilcox",
				EMailAddress1 = "sample@example.com",
				Address1_City = "Bellevue",
				Address1_StateOrProvince = "WA",
				Address1_Telephone1 = "(425)555-5555",
				ParentCustomerId = new EntityReference
				{
					Id = _accountId,
					LogicalName = account.LogicalName
				}
			};
			_contactIdList.Add(_service.Create(contact));

			// Create pricing and product objects.
			PriceLevel priceLevel = new PriceLevel()
			{
				Name = "Faux Price List"
			};
			_priceLevelId = _service.Create(priceLevel);

			Product product = new Product()
			{
				ProductNumber = "1",
				QuantityDecimal = 4,
				Name = "Faux Product",
				Price = new Money(20.0M),
				DefaultUoMId = new EntityReference
				{
					Id = unit.Id,
					LogicalName = UoM.EntityLogicalName
				},
				DefaultUoMScheduleId = new EntityReference
				{
					Id = _unitGroupId,
					LogicalName = UoMSchedule.EntityLogicalName
				}
			};
			_productId = _service.Create(product);

			ProductPriceLevel productPrice = new ProductPriceLevel()
			{
				PriceLevelId = new EntityReference()
				{
					Id = _priceLevelId,
					LogicalName = PriceLevel.EntityLogicalName
				},
				ProductId = new EntityReference()
				{
					Id = _productId,
					LogicalName = Product.EntityLogicalName
				},
				UoMId = new EntityReference
				{
					Id = unit.Id,
					LogicalName = UoM.EntityLogicalName
				},
				Amount = new Money(20.0M),
			};
			_productPriceId = _service.Create(productPrice);

			// Create 3 orders.
			SalesOrder order = new SalesOrder()
			{
				Name = "Faux Order",
				DateFulfilled = new DateTime(2010, 8, 1),
				PriceLevelId = new EntityReference
				{
					Id = _priceLevelId,
					LogicalName = PriceLevel.EntityLogicalName
				},
				CustomerId = new EntityReference
				{
					Id = _accountId,
					LogicalName = account.LogicalName
				},
				FreightAmount = new Money(20.0M)
			};
			_orderIdList.Add(_service.Create(order));

			order = new SalesOrder()
			{
				Name = "Old Faux Order",
				DateFulfilled = new DateTime(2010, 4, 1),
				PriceLevelId = new EntityReference
				{
					Id = _priceLevelId,
					LogicalName = PriceLevel.EntityLogicalName
				},
				CustomerId = new EntityReference
				{
					Id = _accountId,
					LogicalName = account.LogicalName
				},
				FreightAmount = new Money(20.0M)
			};
			_orderIdList.Add(_service.Create(order));

			order = new SalesOrder()
			{
				Name = "Oldest Faux Order",
				DateFulfilled = new DateTime(2008, 8, 1),
				PriceLevelId = new EntityReference
				{
					Id = _priceLevelId,
					LogicalName = PriceLevel.EntityLogicalName
				},
				CustomerId = new EntityReference
				{
					Id = _accountId,
					LogicalName = account.LogicalName
				},
				FreightAmount = new Money(20.0M)
			};
			_orderIdList.Add(_service.Create(order));

			// Create 2 opportunities.
			Opportunity opportunity = new Opportunity()
			{
				Name = "Litware, Inc. Opportunity 1",
				EstimatedCloseDate = new DateTime(2011, 1, 1),
				CustomerId = new EntityReference
				{
					Id = _accountId,
					LogicalName = account.LogicalName
				}
			};
			_opportunityIdList.Add(_service.Create(opportunity));

			opportunity = new Opportunity()
			{
				Name = "Litware, Inc. Opportunity 2",
				EstimatedCloseDate = new DateTime(2020, 1, 1),
				CustomerId = new EntityReference
				{
					Id = _accountId,
					LogicalName = account.LogicalName
				}
			};
			_opportunityIdList.Add(_service.Create(opportunity));
		}

		/// <summary>
		/// Deletes any entity records that were created for this sample.
		/// <param name="prompt">Indicates whether to prompt the user 
		/// to delete the records created in this sample.</param>
		/// </summary>
		public void DeleteRequiredRecords(bool prompt)
		{
			bool toBeDeleted = true;

			if (prompt)
			{
				// Ask the user if the created entities should be deleted.
				Console.Write("\nDo you want these entity records deleted? (y/n) [y]: ");
				String answer = Console.ReadLine();
				if (answer.StartsWith("y") ||
					answer.StartsWith("Y") ||
					answer == String.Empty)
				{
					toBeDeleted = true;
				}
				else
				{
					toBeDeleted = false;
				}
			}

			if (toBeDeleted)
			{
				// Delete all records created in this sample.
				foreach (Guid contactId in _contactIdList)
				{
					_service.Delete(Contact.EntityLogicalName, contactId);
				}

				foreach (Guid opportunityId in _opportunityIdList)
				{
					_service.Delete(Opportunity.EntityLogicalName, opportunityId);
				}

				foreach (Guid orderId in _orderIdList)
				{
					_service.Delete(SalesOrder.EntityLogicalName, orderId);
				}

				_service.Delete(Account.EntityLogicalName, _accountId);

				_service.Delete(Product.EntityLogicalName, _productId);

				_service.Delete(PriceLevel.EntityLogicalName, _priceLevelId);

				_service.Delete(UoMSchedule.EntityLogicalName, _unitGroupId);

				Console.WriteLine("Entity record(s) have been deleted.");
			}
		}

		#endregion How To Sample Code

		#region Main method

		/// <summary>
		/// Standard Main() method used by most SDK samples.
		/// </summary>
		/// <param name="args"></param>
		static public void Main(string[] args)
		{
			try
			{
				// Obtain the target organization's Web address and client logon 
				// credentials from the user.
				ServerConnection serverConnect = new ServerConnection();
				ServerConnection.Configuration config = serverConnect.GetServerConfiguration();

				RetrieveMultipleConditionOperatorsFetch app = new RetrieveMultipleConditionOperatorsFetch();
				app.Run(config, true);
			}
			catch (FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> ex)
			{
				Console.WriteLine("The application terminated with an error.");
				Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp);
				Console.WriteLine("Code: {0}", ex.Detail.ErrorCode);
				Console.WriteLine("Message: {0}", ex.Detail.Message);
				Console.WriteLine("Plugin Trace: {0}", ex.Detail.TraceText);
				Console.WriteLine("Inner Fault: {0}",
					null == ex.Detail.InnerFault ? "No Inner Fault" : "Has Inner Fault");
			}
			catch (System.TimeoutException ex)
			{
				Console.WriteLine("The application terminated with an error.");
				Console.WriteLine("Message: {0}", ex.Message);
				Console.WriteLine("Stack Trace: {0}", ex.StackTrace);
				Console.WriteLine("Inner Fault: {0}",
					null == ex.InnerException.Message ? "No Inner Fault" : ex.InnerException.Message);
			}
			catch (System.Exception ex)
			{
				Console.WriteLine("The application terminated with an error.");
				Console.WriteLine(ex.Message);

				// Display the details of the inner exception.
				if (ex.InnerException != null)
				{
					Console.WriteLine(ex.InnerException.Message);

					FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> fe = ex.InnerException
						as FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault>;
					if (fe != null)
					{
						Console.WriteLine("Timestamp: {0}", fe.Detail.Timestamp);
						Console.WriteLine("Code: {0}", fe.Detail.ErrorCode);
						Console.WriteLine("Message: {0}", fe.Detail.Message);
						Console.WriteLine("Plugin Trace: {0}", fe.Detail.TraceText);
						Console.WriteLine("Inner Fault: {0}",
							null == fe.Detail.InnerFault ? "No Inner Fault" : "Has Inner Fault");
					}
				}
			}
			// Additional exceptions to catch: SecurityTokenValidationException, ExpiredSecurityTokenException,
			// SecurityAccessDeniedException, MessageSecurityException, and SecurityNegotiationException.

			finally
			{
				Console.WriteLine("Press <Enter> to exit.");
				Console.ReadLine();
			}
		}
		#endregion Main method
	}
}

// </snippetretrievemultipleconditionoperatorsfetch>
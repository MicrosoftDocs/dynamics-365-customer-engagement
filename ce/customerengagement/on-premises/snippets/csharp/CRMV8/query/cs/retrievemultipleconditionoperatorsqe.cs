// <snippetretrievemultipleconditionoperatorsqe>


using System;
using System.ServiceModel;
using System.Collections.Generic;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// Demonstrates how to do use retrieve multiple condition operators for all
    /// query types.</summary>
    /// <remarks>
    /// At run-time, you will be given the option to delete all the
    /// database records created by this program.</remarks>
    public class RetrieveMultipleConditionOperatorsQE
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
        /// This method first connects to the Organization service. Afterwards, various
        /// QueryExpressions are performed that demonstrate the use of special
        /// condition operators.
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

                    #region SQL Query Translated to QueryExpression
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

                    QueryExpression query = new QueryExpression()
                    {
                        Distinct = false,
                        EntityName = Contact.EntityLogicalName,
                        ColumnSet = new ColumnSet("fullname", "address1_telephone1"),
                        LinkEntities = 
                        {
                            new LinkEntity 
                            {
                                JoinOperator = JoinOperator.LeftOuter,
                                LinkFromAttributeName = "parentcustomerid",
                                LinkFromEntityName = Contact.EntityLogicalName,
                                LinkToAttributeName = "accountid",
                                LinkToEntityName = Account.EntityLogicalName,
                                LinkCriteria = 
                                {
                                    Conditions = 
                                    {
                                        new ConditionExpression("name", ConditionOperator.Equal, "Litware, Inc.")
                                    }
                                }
                            }
                        },
                        Criteria =
                        {
                            Filters = 
                            {
                                new FilterExpression
                                {
                                    FilterOperator = LogicalOperator.And,
                                    Conditions = 
                                    {
                                        new ConditionExpression("address1_stateorprovince", ConditionOperator.Equal, "WA"),
                                        new ConditionExpression("address1_city", ConditionOperator.In, new String[] {"Redmond", "Bellevue" , "Kirkland", "Seattle"}),
                                        new ConditionExpression("createdon", ConditionOperator.LastXDays, 30),
                                        new ConditionExpression("emailaddress1", ConditionOperator.NotNull)
                                    },
                                },
                                new FilterExpression
                                {
                                    FilterOperator = LogicalOperator.Or,
                                    Conditions =
                                    {
                                        new ConditionExpression("address1_telephone1", ConditionOperator.Like, "(206)%"),
                                        new ConditionExpression("address1_telephone1", ConditionOperator.Like, "(425)%")
                                    }
                                }
                            }
                        }
                    };

                    DataCollection<Entity> entityCollection = _service.RetrieveMultiple(query).Entities;

                    // Display the results.
                    Console.WriteLine("List all contacts matching specified parameters");
                    Console.WriteLine("===============================================");
                    foreach (Contact contact in entityCollection)
                    {
                        Console.WriteLine("Contact ID: {0}", contact.Id);
                        Console.WriteLine("Contact Name: {0}", contact.FullName);
                        Console.WriteLine("Contact Phone: {0}", contact.Address1_Telephone1);
                    }
                    Console.WriteLine("<End of Listing>");
                    Console.WriteLine();
                    #endregion

                    #region Find all orders fulfilled in the last fiscal period
                    query = new QueryExpression()
                    {
                        EntityName = SalesOrder.EntityLogicalName,
                        ColumnSet = new ColumnSet("name"),
                        Criteria =
                        {
                            Conditions = 
                            {
                                new ConditionExpression ("datefulfilled", ConditionOperator.LastFiscalPeriod)
                            }
                        }
                    };

                    entityCollection = _service.RetrieveMultiple(query).Entities;

                    // Display the results.
                    Console.WriteLine("List all orders fulfilled in the last fiscal period");
                    Console.WriteLine("===================================================");
                    foreach (SalesOrder order in entityCollection)
                    {
                        Console.WriteLine("Order ID: {0}", order.Id);
                        Console.WriteLine("Order Name: {0}", order.Name);
                    }
                    Console.WriteLine("<End of Listing>");
                    Console.WriteLine();
                    #endregion

                    #region Find all Opportunities with estimated close date in next 3 fiscal years
                    query = new QueryExpression()
                    {
                        EntityName = Opportunity.EntityLogicalName,
                        ColumnSet = new ColumnSet("name"),
                        Criteria =
                        {
                            Conditions =
                            {
                                new ConditionExpression ("estimatedclosedate", ConditionOperator.NextXFiscalYears, 3)
                            }
                        }
                    };

                    entityCollection = _service.RetrieveMultiple(query).Entities;

                    // Display the results.
                    Console.WriteLine("List all opportunities with estimated close date in the next 3 fiscal years");
                    Console.WriteLine("===========================================================================");
                    foreach (Opportunity opportunity in entityCollection)
                    {
                        Console.WriteLine("Opportunity ID: {0}", opportunity.Id);
                        Console.WriteLine("Opportunity: {0}", opportunity.Name);
                    }
                    Console.WriteLine("<End of Listing>");
                    Console.WriteLine();
                    #endregion

                    #region Find all Orders fulfilled in fiscal year 2008
                    query = new QueryExpression()
                    {
                        EntityName = SalesOrder.EntityLogicalName,
                        ColumnSet = new ColumnSet("name"),
                        Criteria =
                        {
                            Conditions =
                            {
                                new ConditionExpression ("datefulfilled", ConditionOperator.InFiscalYear, 2008)
                            }
                        }
                    };

                    entityCollection = _service.RetrieveMultiple(query).Entities;

                    // Display the results.
                    Console.WriteLine("List all orders fulfilled in fiscal year 2008");
                    Console.WriteLine("=============================================");
                    foreach (SalesOrder order in entityCollection)
                    {
                        Console.WriteLine("Order ID: {0}", order.Id);
                        Console.WriteLine("Order Name: {0}", order.Name);
                    }
                    Console.WriteLine("<End of Listing>");
                    Console.WriteLine();
                    #endregion

                    #region Find all Orders fulfilled in period 3 of any fiscal year
                    query = new QueryExpression()
                    {
                        EntityName = SalesOrder.EntityLogicalName,
                        ColumnSet = new ColumnSet("name"),
                        Criteria =
                        {
                            Conditions =
                            {
                                new ConditionExpression ("datefulfilled", ConditionOperator.InFiscalPeriod, 3)
                            }
                        }
                    };

                    entityCollection = _service.RetrieveMultiple(query).Entities;

                    // Display the results.
                    Console.WriteLine("List all orders fulfilled in period 3 of any fiscal year");
                    Console.WriteLine("========================================================");
                    foreach (SalesOrder order in entityCollection)
                    {
                        Console.WriteLine("Order ID: {0}", order.Id);
                        Console.WriteLine("Order Name: {0}", order.Name);
                    }
                    Console.WriteLine("<End of Listing>");
                    Console.WriteLine();
                    #endregion

                    #region Find all Orders fulfilled in period 3 of fiscal year 2008
                    query = new QueryExpression()
                    {
                        EntityName = SalesOrder.EntityLogicalName,
                        ColumnSet = new ColumnSet("name"),
                        Criteria =
                        {
                            Conditions =
                            {
                                new ConditionExpression ("datefulfilled", ConditionOperator.InFiscalPeriodAndYear, new int[] {3, 2008})
                            }
                        }
                    };

                    entityCollection = _service.RetrieveMultiple(query).Entities;

                    // Display the results.
                    Console.WriteLine("List all orders fulfilled in period 3 of fiscal year 2008");
                    Console.WriteLine("=========================================================");
                    foreach (SalesOrder order in entityCollection)
                    {
                        Console.WriteLine("Order ID: {0}", order.Id);
                        Console.WriteLine("Order Name: {0}", order.Name);
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
                Amount = new Money(20)
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
                }
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
                }
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
                }
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

                RetrieveMultipleConditionOperatorsQE app = new RetrieveMultipleConditionOperatorsQE();
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

// </snippetretrievemultipleconditionoperatorsqe>
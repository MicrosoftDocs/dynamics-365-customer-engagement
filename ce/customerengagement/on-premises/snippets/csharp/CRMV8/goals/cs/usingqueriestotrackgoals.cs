// <snippetusingqueriestotrackgoals>


using System;
using System.ServiceModel;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Client;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// Demonstrates how to use queries to track goals.</summary>
    /// <remarks>
    /// At run-time, you will be given the option to delete all the
    /// database records created by this program.</remarks>
    public class UsingQueriesToTrackGoals
    {
        #region Class Level Members

        private Guid _salesManagerId;
        private Guid _unitGroupId;
        private Guid _defaultUnitId;
        private Guid _productId;
        private Guid _priceListId;
        private Guid _priceListItemId;
        private Guid _orderDetailId;
        private Guid _metricId;
        private Guid _actualId;
        private Guid _parentGoalId;
        private Guid _firstChildGoalId;
        private Guid _accountId;
        private Guid _rollupQueryId;
        private Guid _salesRepresentativeId;
        private Guid _orderId;

        private OrganizationServiceProxy _serviceProxy;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// This method first connects to the Organization service. Afterwards, a 
        /// rollup field and rollup query are created. The rollup query is only
        /// associated with the child goal. Then a parent goal and child goal
        /// are created. The goals are both rolled up and their results are displayed. 
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

                    CreateRequiredRecords();

                    // Create the revenue metric, setting the Amount Data Type to 'Money'
                    // and the Metric Type to 'Amount'.
                    Metric sampleMetric = new Metric()
                    {
                        Name = "Sample Revenue Metric",
                        AmountDataType = new OptionSetValue(0),
                        IsAmount = true,
                    };
                    _metricId = _serviceProxy.Create(sampleMetric);
                    sampleMetric.Id = _metricId;

                    Console.Write("Created revenue metric, ");

                    #region Create RollupFields

                    // Create RollupField which targets the actual totals.
                    RollupField actual = new RollupField()
                    {
                        SourceEntity = SalesOrder.EntityLogicalName,
                        SourceAttribute = "totalamount",
                        GoalAttribute = "actualmoney",
                        SourceState = 1,
                        EntityForDateAttribute = SalesOrder.EntityLogicalName,
                        DateAttribute = "datefulfilled",
                        MetricId = sampleMetric.ToEntityReference()
                    };
                    _actualId = _serviceProxy.Create(actual);

                    Console.Write("created actual revenue RollupField, ");

                    #endregion

                    #region Create the goal rollup query

                    // The query locates sales orders in the first sales 
                    // representative's area (zip code: 60661) and with a value
                    // greater than $1,000.
                    GoalRollupQuery goalRollupQuery = new GoalRollupQuery()
                    {
                        Name = "First Example Goal Rollup Query",
                        QueryEntityType = SalesOrder.EntityLogicalName,
                        FetchXml = @"<fetch mapping=""logical"" version=""1.0""><entity name=""salesorder""><attribute name=""customerid"" /><attribute name=""name"" /><attribute name=""salesorderid"" /><attribute name=""statuscode"" /><attribute name=""totalamount"" /><order attribute=""name"" /><filter><condition attribute=""totalamount"" operator=""gt"" value=""1000"" /><condition attribute=""billto_postalcode"" operator=""eq"" value=""60661"" /></filter></entity></fetch>"
                    };
                    _rollupQueryId = _serviceProxy.Create(goalRollupQuery);
                    goalRollupQuery.Id = _rollupQueryId;

                    Console.Write("created rollup query.");
                    Console.WriteLine();

                    #endregion

                    #region Create two goals: one parent and one child goal

                    // Create the parent goal.
                    Goal parentGoal = new Goal()
                    {
                        Title = "Parent Goal Example",
                        RollupOnlyFromChildGoals = true,
                        TargetMoney = new Money(1000.0M),
                        IsFiscalPeriodGoal = false,
                        MetricId = sampleMetric.ToEntityReference(),
                        GoalOwnerId = new EntityReference
                        {
                            Id = _salesManagerId,
                            LogicalName = SystemUser.EntityLogicalName
                        },
                        OwnerId = new EntityReference
                        {
                            Id = _salesManagerId,
                            LogicalName = SystemUser.EntityLogicalName
                        },
                        GoalStartDate = DateTime.Today.AddDays(-1),
                        GoalEndDate = DateTime.Today.AddDays(30)
                    };
                    _parentGoalId = _serviceProxy.Create(parentGoal);
                    parentGoal.Id = _parentGoalId;

                    Console.WriteLine("Created parent goal");
                    Console.WriteLine("-------------------");
                    Console.WriteLine("Target: {0}", parentGoal.TargetMoney.Value);
                    Console.WriteLine("Goal owner: {0}", parentGoal.GoalOwnerId.Id);
                    Console.WriteLine("Goal Start Date: {0}", parentGoal.GoalStartDate);
                    Console.WriteLine("Goal End Date: {0}", parentGoal.GoalEndDate);
                    Console.WriteLine("<End of Listing>");
                    Console.WriteLine();

                    // Create the child goal.
                    Goal firstChildGoal = new Goal()
                    {
                        Title = "First Child Goal Example",
                        ConsiderOnlyGoalOwnersRecords = true,
                        TargetMoney = new Money(1000.0M),
                        IsFiscalPeriodGoal = false,
                        MetricId = sampleMetric.ToEntityReference(),
                        ParentGoalId = parentGoal.ToEntityReference(),
                        GoalOwnerId = new EntityReference
                        {
                            Id = _salesRepresentativeId,
                            LogicalName = SystemUser.EntityLogicalName
                        },
                        OwnerId = new EntityReference
                        {
                            Id = _salesManagerId,
                            LogicalName = SystemUser.EntityLogicalName
                        },
                        RollUpQueryActualMoneyId = goalRollupQuery.ToEntityReference(),
                        GoalStartDate = DateTime.Today.AddDays(-1),
                        GoalEndDate = DateTime.Today.AddDays(30)
                    };
                    _firstChildGoalId = _serviceProxy.Create(firstChildGoal);

                    Console.WriteLine("First child goal");
                    Console.WriteLine("----------------");
                    Console.WriteLine("Target: {0}", firstChildGoal.TargetMoney.Value);
                    Console.WriteLine("Goal owner: {0}", firstChildGoal.GoalOwnerId.Id);
                    Console.WriteLine("Goal Start Date: {0}", firstChildGoal.GoalStartDate);
                    Console.WriteLine("Goal End Date: {0}", firstChildGoal.GoalEndDate);
                    Console.WriteLine("<End of Listing>");
                    Console.WriteLine();

                    #endregion

                    // Calculate roll-up of goals.
                    // Note: Recalculate can be run against any goal in the tree to cause
                    // a rollup of the whole tree.
                    RecalculateRequest recalculateRequest = new RecalculateRequest()
                    {
                        Target = parentGoal.ToEntityReference()
                    };
                    _serviceProxy.Execute(recalculateRequest);

                    Console.WriteLine("Calculated roll-up of goals.");
                    Console.WriteLine();

                    // Retrieve and report 3 different computed values for the goals
                    // - Percentage
                    // - ComputedTargetAsOfTodayPercentageAchieved
                    // - ComputedTargetAsOfTodayMoney
                    QueryExpression retrieveValues = new QueryExpression()
                    {
                        EntityName = Goal.EntityLogicalName,
                        ColumnSet = new ColumnSet(
                            "title",
                            "computedtargetasoftodaypercentageachieved",
                            "computedtargetasoftodaymoney")
                    };
                    EntityCollection ec = _serviceProxy.RetrieveMultiple(retrieveValues);

                    // Compute and display the results
                    for (int i = 0; i < ec.Entities.Count; i++)
                    {
                        Goal temp = (Goal)ec.Entities[i];
                        Console.WriteLine("Roll-up details for goal: {0}", temp.Title);
                        Console.WriteLine("---------------");
                        Console.WriteLine("ComputedTargetAsOfTodayPercentageAchieved: {0}",
                            temp.ComputedTargetAsOfTodayPercentageAchieved);
                        Console.WriteLine("ComputedTargetAsOfTodayMoney: {0}",
                            temp.ComputedTargetAsOfTodayMoney.Value);
                        Console.WriteLine("<End of Listing>");
                    }

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

            #region Create or Retrieve the necessary system users

            // Retrieve the ldapPath
            String ldapPath = String.Empty;
            // Retrieve the sales team - 1 sales manager and 2 sales representatives.
            _salesManagerId =
                SystemUserProvider.RetrieveSalesManager(_serviceProxy, ref ldapPath);
            _salesRepresentativeId =
                SystemUserProvider.RetrieveSalespersons(_serviceProxy, ref ldapPath)[0];

            #endregion

            #region Create records to support SalesOrder records
            // Create a unit group
            UoMSchedule newUnitGroup = new UoMSchedule
            {
                Name = "Example Unit Group",
                BaseUoMName = "Example Primary Unit"
            };
            _unitGroupId = _serviceProxy.Create(newUnitGroup);

            // Retrieve the default unit id that was automatically created
            // when we created the Unit Group
            QueryExpression unitQuery = new QueryExpression
            {
                EntityName = UoM.EntityLogicalName,
                ColumnSet = new ColumnSet("uomid", "name"),
                Criteria = new FilterExpression
                {
                    Conditions = 
                        {
                            new ConditionExpression 
                            {
                                AttributeName = "uomscheduleid",
                                Operator = ConditionOperator.Equal,
                                Values = { _unitGroupId }
                            }
                        }
                },
                PageInfo = new PagingInfo
                {
                    PageNumber = 1,
                    Count = 1
                }
            };

            // Retrieve the unit.
            UoM unit = (UoM)_serviceProxy.RetrieveMultiple(unitQuery).Entities[0];
            _defaultUnitId = unit.UoMId.Value;

            // Create a few products
            Product newProduct = new Product
            {
                ProductNumber = "1",
                Name = "Example Product",
                ProductStructure = new OptionSetValue(1),
                QuantityDecimal = 2,
                DefaultUoMScheduleId =
                    new EntityReference(UoMSchedule.EntityLogicalName, _unitGroupId),
                DefaultUoMId = new EntityReference(UoM.EntityLogicalName, _defaultUnitId)
            };
            _productId = _serviceProxy.Create(newProduct);
            newProduct.Id = _productId;
            Console.WriteLine("Created {0}", newProduct.Name);

            // Create a price list
            PriceLevel newPriceList = new PriceLevel
            {
                Name = "Example Price List"
            };
            _priceListId = _serviceProxy.Create(newPriceList);

            // Create a price list item for the first product and apply volume discount
            ProductPriceLevel newPriceListItem = new ProductPriceLevel
            {
                PriceLevelId =
                    new EntityReference(PriceLevel.EntityLogicalName, _priceListId),
                ProductId =
                    new EntityReference(Product.EntityLogicalName, _productId),
                UoMId =
                    new EntityReference(UoM.EntityLogicalName, _defaultUnitId),
                Amount = new Money(20),
            };
            _priceListItemId = _serviceProxy.Create(newPriceListItem);

            // Publish the product
            SetStateRequest publishRequest = new SetStateRequest
            {
                EntityMoniker = new EntityReference(Product.EntityLogicalName, _productId),
                State = new OptionSetValue((int)ProductState.Active),
                Status = new OptionSetValue(1)
            };
            _serviceProxy.Execute(publishRequest);
            Console.WriteLine("Published {0}", newProduct.Name);


            // Create an account record for the sales order's potential customerid 
            Account newAccount = new Account
            {
                Name = "Litware, Inc.",
                Address1_PostalCode = "60661"
            };
            _accountId = _serviceProxy.Create(newAccount);
            newAccount.Id = _accountId;

            #endregion Create records to support SalesOrder

            #region Create SalesOrder record

            // Create the sales order.
            SalesOrder order = new SalesOrder()
            {
                Name = "Faux Order",
                DateFulfilled = new DateTime(2010, 8, 1),
                PriceLevelId =
                    new EntityReference(PriceLevel.EntityLogicalName, _priceListId),
                CustomerId =
                    new EntityReference(Account.EntityLogicalName, _accountId),
                FreightAmount = new Money(20.0M)
            };
            _orderId = _serviceProxy.Create(order);
            order.Id = _orderId;

            // Add the product to the order with the price overriden with a
            // negative value.
            SalesOrderDetail orderDetail = new SalesOrderDetail()
            {
                ProductId = newProduct.ToEntityReference(),
                Quantity = 4,
                SalesOrderId = order.ToEntityReference(),
                IsPriceOverridden = true,
                PricePerUnit = new Money(1000.0M),
                UoMId = new EntityReference(UoM.EntityLogicalName, _defaultUnitId)
            };
            _orderDetailId = _serviceProxy.Create(orderDetail);

            #endregion Create SalesOrder record
        }

        /// <summary>
        /// Deletes any entity records that were created for this sample.
        /// <param name="prompt">Indicates whether to prompt the user 
        /// to delete the records created in this sample.</param>
        /// </summary>
        public void DeleteRequiredRecords(bool prompt)
        {
            // The three system users that were created by this sample will continue to 
            // exist on your system because system users cannot be deleted in Microsoft
            // Dynamics CRM.  They can only be enabled or disabled.

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
                _serviceProxy.Delete("goal", _firstChildGoalId);
                _serviceProxy.Delete("goal", _parentGoalId);
                _serviceProxy.Delete("goalrollupquery", _rollupQueryId);
                _serviceProxy.Delete("salesorderdetail", _orderDetailId);
                _serviceProxy.Delete("salesorder", _orderId);
                _serviceProxy.Delete("account", _accountId);
                _serviceProxy.Delete("productpricelevel", _priceListItemId);
                _serviceProxy.Delete("pricelevel", _priceListId);
                _serviceProxy.Delete("product", _productId);
                _serviceProxy.Delete("uomschedule", _unitGroupId);
                _serviceProxy.Delete("rollupfield", _actualId);
                _serviceProxy.Delete("metric", _metricId);

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

                UsingQueriesToTrackGoals app = new UsingQueriesToTrackGoals();
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

// </snippetusingqueriestotrackgoals>
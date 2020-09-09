// <snippetrollupallgoalsforcustomperiodagainsttargetrevenue>


using System;
using System.ServiceModel;
using System.Collections.Generic;

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
    /// Demonstrates how to work with Goals and related entities.</summary>
    /// <remarks>
    /// At run-time, you will be given the option to delete all the
    /// database records created by this program.</remarks>
    public class RollupAllGoalsForCustomPeriodAgainstTargetRevenue
    {
        #region Class Level Members

        private Guid _salesManagerId;
        private Guid _unitGroupId;
        private Guid _defaultUnitId;
        private Guid _product1Id;
        private Guid _product2Id;
        private Guid _discountTypeId;
        private Guid _discountId;
        private Guid _priceListId;
        private Guid _priceListItem1Id;
        private Guid _priceListItem2Id;
        private Guid _catalogProductId;
        private Guid _catalogProductPriceOverrideId;
        private Guid _writeInProductId;
        private Guid _metricId;
        private Guid _inProgressId;
        private Guid _actualId;
        private Guid _parentGoalId;
        private Guid _firstChildGoalId;
        private Guid _secondChildGoalId;
        private List<Guid> _accountIds = new List<Guid>();
        private List<Guid> _rollupQueryIds = new List<Guid>();
        private List<Guid> _salesRepresentativeIds = new List<Guid>();
        private List<Guid> _opportunityIds = new List<Guid>();

        private OrganizationServiceProxy _serviceProxy;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// This method first connects to the Organization service. Afterwards,
        /// several actions on Goal records are executed.
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

                    Console.Write("Created revenue metric, ");

                    // Create first RollupField which targets the estimated values.
                    RollupField inProgress = new RollupField()
                    {
                        SourceEntity = Opportunity.EntityLogicalName,
                        SourceAttribute = "estimatedvalue",
                        GoalAttribute = "inprogressmoney",
                        SourceState = 0,
                        EntityForDateAttribute = Opportunity.EntityLogicalName,
                        DateAttribute = "estimatedclosedate",
                        MetricId = new EntityReference(Metric.EntityLogicalName, _metricId),
                    };
                    _inProgressId = _serviceProxy.Create(inProgress);

                    Console.Write("created in-progress RollupField, ");

                    // Create second RollupField which targets the actual values.
                    RollupField actual = new RollupField()
                    {
                        SourceEntity = Opportunity.EntityLogicalName,
                        SourceAttribute = "actualvalue",
                        GoalAttribute = "actualmoney",
                        SourceState = 1,
                        EntityForDateAttribute = Opportunity.EntityLogicalName,
                        DateAttribute = "actualclosedate",
                        MetricId = new EntityReference(Metric.EntityLogicalName, _metricId)
                    };
                    _actualId = _serviceProxy.Create(actual);

                    Console.Write("created actual revenue RollupField, ");

                    // Create the goal rollup queries.
                    // Note: Formatting the FetchXml onto multiple lines in the following 
                    // rollup queries causes the lenth property to be greater than 1,000
                    // chars and will cause an exception.

                    // The first query locates opportunities in the first sales 
                    // representative's area (zip code: 60661).
                    GoalRollupQuery goalRollupQuery = new GoalRollupQuery()
                    {
                        Name = "First Example Goal Rollup Query",
                        QueryEntityType = Opportunity.EntityLogicalName,
                        FetchXml = @"<fetch version=""1.0"" output-format=""xml-platform"" mapping=""logical"" distinct=""false""><entity name=""opportunity""><attribute name=""totalamount""/><attribute name=""name""/><attribute name=""customerid""/><attribute name=""estimatedvalue""/><attribute name=""statuscode""/><attribute name=""opportunityid""/><order attribute=""name"" descending=""false""/><link-entity name=""account"" from=""accountid"" to=""customerid"" alias=""aa""><filter type=""and""><condition attribute=""address1_postalcode"" operator=""eq"" value=""60661""/></filter></link-entity></entity></fetch>"
                    };
                    _rollupQueryIds.Add(_serviceProxy.Create(goalRollupQuery));

                    Console.Write("created first rollup query for zip code 60661, ");

                    // The second query locates opportunities in the second sales 
                    // representative's area (zip code: 99999).
                    goalRollupQuery = new GoalRollupQuery()
                    {
                        Name = "Second Example Goal Rollup Query",
                        QueryEntityType = Opportunity.EntityLogicalName,
                        FetchXml = @"<fetch version=""1.0"" output-format=""xml-platform"" mapping=""logical"" distinct=""false""><entity name=""opportunity""><attribute name=""totalamount""/><attribute name=""customerid""/><attribute name=""estimatedvalue""/><attribute name=""statuscode""/><attribute name=""opportunityid""/><order attribute=""name"" descending=""false""/><link-entity name=""account"" from=""accountid"" to=""customerid"" alias=""aa""><filter type=""and""><condition attribute=""address1_postalcode"" operator=""eq"" value=""99999""/></filter></link-entity></entity></fetch>"
                    };
                    _rollupQueryIds.Add(_serviceProxy.Create(goalRollupQuery));

                    Console.WriteLine("created second rollup query for zip code 99999.");
                    Console.WriteLine();

                    // Create three goals: one parent goal and two child goals.
                    Goal parentGoal = new Goal()
                    {
                        Title = "Parent Goal Example",
                        RollupOnlyFromChildGoals = true,
                        ConsiderOnlyGoalOwnersRecords = true,
                        TargetMoney = new Money(300.0M),
                        IsFiscalPeriodGoal = false,
                        MetricId = new EntityReference
                        {
                            Id = _metricId,
                            LogicalName = Metric.EntityLogicalName
                        },
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

                    Console.WriteLine("Created parent goal");
                    Console.WriteLine("-------------------");
                    Console.WriteLine("Target: {0}", parentGoal.TargetMoney.Value);
                    Console.WriteLine("Goal owner: {0}", parentGoal.GoalOwnerId.Id);
                    Console.WriteLine("Goal Start Date: {0}", parentGoal.GoalStartDate);
                    Console.WriteLine("Goal End Date: {0}", parentGoal.GoalEndDate);
                    Console.WriteLine("<End of Listing>");
                    Console.WriteLine();

                    Goal firstChildGoal = new Goal()
                    {
                        Title = "First Child Goal Example",
                        ConsiderOnlyGoalOwnersRecords = true,
                        TargetMoney = new Money(100.0M),
                        IsFiscalPeriodGoal = false,
                        MetricId = new EntityReference
                        {
                            Id = _metricId,
                            LogicalName = Metric.EntityLogicalName
                        },
                        ParentGoalId = new EntityReference
                        {
                            Id = _parentGoalId,
                            LogicalName = Goal.EntityLogicalName
                        },
                        GoalOwnerId = new EntityReference
                        {
                            Id = _salesRepresentativeIds[0],
                            LogicalName = SystemUser.EntityLogicalName
                        },
                        OwnerId = new EntityReference
                        {
                            Id = _salesManagerId,
                            LogicalName = SystemUser.EntityLogicalName
                        },
                        RollUpQueryActualMoneyId = new EntityReference
                        {
                            Id = _rollupQueryIds[0],
                            LogicalName = GoalRollupQuery.EntityLogicalName
                        },
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
                    Console.WriteLine();

                    Goal secondChildGoal = new Goal()
                    {
                        Title = "Second Child Goal Example",
                        ConsiderOnlyGoalOwnersRecords = true,
                        TargetMoney = new Money(200.0M),
                        IsFiscalPeriodGoal = false,
                        MetricId = new EntityReference
                        {
                            Id = _metricId,
                            LogicalName = Metric.EntityLogicalName
                        },
                        ParentGoalId = new EntityReference
                        {
                            Id = _parentGoalId,
                            LogicalName = Goal.EntityLogicalName
                        },
                        GoalOwnerId = new EntityReference
                        {
                            Id = _salesRepresentativeIds[1],
                            LogicalName = SystemUser.EntityLogicalName
                        },
                        OwnerId = new EntityReference
                        {
                            Id = _salesManagerId,
                            LogicalName = SystemUser.EntityLogicalName
                        },
                        RollUpQueryActualMoneyId = new EntityReference
                        {
                            Id = _rollupQueryIds[1],
                            LogicalName = GoalRollupQuery.EntityLogicalName
                        },
                        GoalStartDate = DateTime.Today.AddDays(-1),
                        GoalEndDate = DateTime.Today.AddDays(30)
                    };
                    _secondChildGoalId = _serviceProxy.Create(secondChildGoal);

                    Console.WriteLine("Second child goal");
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Target: {0}", secondChildGoal.TargetMoney.Value);
                    Console.WriteLine("Goal owner: {0}", secondChildGoal.GoalOwnerId.Id);
                    Console.WriteLine("Goal Start Date: {0}", secondChildGoal.GoalStartDate);
                    Console.WriteLine("Goal End Date: {0}", secondChildGoal.GoalEndDate);
                    Console.WriteLine();

                    // Calculate roll-up of goals.
                    RecalculateRequest recalculateRequest = new RecalculateRequest()
                    {
                        Target = new EntityReference(Goal.EntityLogicalName, _parentGoalId)
                    };
                    _serviceProxy.Execute(recalculateRequest);

                    Console.WriteLine("Calculated roll-up of goals.");

                    // Retrieve and report 3 different computed values for the goals
                    // - Percentage
                    // - ComputedTargetAsOfTodayPercentageAchieved
                    // - ComputedTargetAsOfTodayMoney
                    QueryExpression retrieveValues = new QueryExpression()
                    {
                        EntityName = Goal.EntityLogicalName,
                        ColumnSet = new ColumnSet(
                            "title", 
                            "percentage", 
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
                        Console.WriteLine("Percentage: {0}", temp.Percentage);
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
            _salesManagerId = SystemUserProvider.RetrieveSalesManager(_serviceProxy, ref ldapPath);
            _salesRepresentativeIds = SystemUserProvider.RetrieveSalespersons(_serviceProxy, ref ldapPath);

            #endregion

            #region Create records to support Opportunity records
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
            Product newProduct1 = new Product
            {
                ProductNumber = "1",
                Name = "Example Product 1",
                ProductStructure = new OptionSetValue(1),
                QuantityDecimal = 2,
                DefaultUoMScheduleId = new EntityReference(UoMSchedule.EntityLogicalName,
                    _unitGroupId),
                DefaultUoMId = new EntityReference(UoM.EntityLogicalName, _defaultUnitId)
            };
            _product1Id = _serviceProxy.Create(newProduct1);
            Console.WriteLine("Created {0}", newProduct1.Name);


            Product newProduct2 = new Product
            {
                ProductNumber = "2",
                Name = "Example Product 2",
                ProductStructure = new OptionSetValue(1),
                QuantityDecimal = 3,
                DefaultUoMScheduleId = new EntityReference(UoMSchedule.EntityLogicalName,
                    _unitGroupId),
                DefaultUoMId = new EntityReference(UoM.EntityLogicalName, _defaultUnitId)
            };
            _product2Id = _serviceProxy.Create(newProduct2);
            Console.WriteLine("Created {0}", newProduct2.Name);

            // Create a new discount list
            DiscountType newDiscountType = new DiscountType
            {
                Name = "Example Discount List",
                IsAmountType = false
            };
            _discountTypeId = _serviceProxy.Create(newDiscountType);

            // Create a new discount
            Discount newDiscount = new Discount
            {
                DiscountTypeId = new EntityReference(DiscountType.EntityLogicalName,
                    _discountTypeId),
                LowQuantity = 5,
                HighQuantity = 10,
                Percentage = 3
            };
            _discountId = _serviceProxy.Create(newDiscount);

            // Create a price list
            PriceLevel newPriceList = new PriceLevel
            {
                Name = "Example Price List"
            };
            _priceListId = _serviceProxy.Create(newPriceList);

            // Create a price list item for the first product and apply volume discount
            ProductPriceLevel newPriceListItem1 = new ProductPriceLevel
            {
                PriceLevelId = new EntityReference(PriceLevel.EntityLogicalName, _priceListId),
                ProductId = new EntityReference(Product.EntityLogicalName, _product1Id),
                UoMId = new EntityReference(UoM.EntityLogicalName, _defaultUnitId),
                Amount = new Money(20),
                DiscountTypeId = new EntityReference(DiscountType.EntityLogicalName,
                    _discountTypeId)
            };
            _priceListItem1Id = _serviceProxy.Create(newPriceListItem1);

            // Create a price list item for the second product
            ProductPriceLevel newPriceListItem2 = new ProductPriceLevel
            {
                PriceLevelId = new EntityReference(PriceLevel.EntityLogicalName, _priceListId),
                ProductId = new EntityReference(Product.EntityLogicalName, _product2Id),
                UoMId = new EntityReference(UoM.EntityLogicalName, _defaultUnitId),
                Amount = new Money(15)
            };
            _priceListItem2Id = _serviceProxy.Create(newPriceListItem2);

            // Publish Product 1
            SetStateRequest publishRequest1 = new SetStateRequest
            {
                EntityMoniker = new EntityReference(Product.EntityLogicalName, _product1Id),
                State = new OptionSetValue((int)ProductState.Active),
                Status = new OptionSetValue(1)
            };
            _serviceProxy.Execute(publishRequest1);            

            // Publish Product 2
            SetStateRequest publishRequest2 = new SetStateRequest
            {
                EntityMoniker = new EntityReference(Product.EntityLogicalName, _product2Id),
                State = new OptionSetValue((int)ProductState.Active),
                Status = new OptionSetValue(1)
            };
            _serviceProxy.Execute(publishRequest2);
            Console.WriteLine("Published {0} and {1}", newProduct1.Name, newProduct2.Name);

            // Create an account record for the opportunity's potential customerid 
            Account newAccount = new Account
            {
                Name = "Litware, Inc.",
                Address1_PostalCode = "60661"
            };
            _accountIds.Add(_serviceProxy.Create(newAccount));

            newAccount = new Account
            {
                Name = "Margie's Travel",
                Address1_PostalCode = "99999"
            };
            _accountIds.Add(_serviceProxy.Create(newAccount));

            #endregion Create records to support Opportunity records

            #region Create Opportunity records
            // Create a new opportunity with user specified estimated revenue
            Opportunity newOpportunity = new Opportunity
            {
                Name = "Example Opportunity",
                CustomerId = new EntityReference(Account.EntityLogicalName,
                    _accountIds[0]),
                PriceLevelId = new EntityReference(PriceLevel.EntityLogicalName,
                    _priceListId),
                IsRevenueSystemCalculated = false,
                EstimatedValue = new Money(400.00m),
                FreightAmount = new Money(10.00m),
                DiscountAmount = new Money(0.10m),
                DiscountPercentage = 0.20m,
                ActualValue = new Money(400.00m),
                OwnerId = new EntityReference
                {
                    Id = _salesRepresentativeIds[0],
                    LogicalName = SystemUser.EntityLogicalName
                }
            };
            _opportunityIds.Add(_serviceProxy.Create(newOpportunity));

            Opportunity secondOpportunity = new Opportunity
            {
                Name = "Example Opportunity 2",
                CustomerId = new EntityReference(Account.EntityLogicalName,
                    _accountIds[1]),
                PriceLevelId = new EntityReference(PriceLevel.EntityLogicalName,
                    _priceListId),
                IsRevenueSystemCalculated = false,
                EstimatedValue = new Money(400.00m),
                FreightAmount = new Money(10.00m),
                DiscountAmount = new Money(0.10m),
                DiscountPercentage = 0.20m,
                ActualValue = new Money(400.00m),
                OwnerId = new EntityReference
                {
                    Id = _salesRepresentativeIds[1],
                    LogicalName = SystemUser.EntityLogicalName
                }
            };
            _opportunityIds.Add(_serviceProxy.Create(secondOpportunity));

            // Create a catalog product
            OpportunityProduct catalogProduct = new OpportunityProduct
            {
                OpportunityId = new EntityReference(Opportunity.EntityLogicalName,
                    _opportunityIds[0]),
                ProductId = new EntityReference(Product.EntityLogicalName,
                    _product1Id),
                UoMId = new EntityReference(UoM.EntityLogicalName, _defaultUnitId),
                Quantity = 8,
                Tax = new Money(12.42m),
            };
            _catalogProductId = _serviceProxy.Create(catalogProduct);
 
            // Create another catalog product and override the list price
            OpportunityProduct catalogProductPriceOverride = new OpportunityProduct
            {
                OpportunityId = new EntityReference(Opportunity.EntityLogicalName,
                    _opportunityIds[1]),
                ProductId = new EntityReference(Product.EntityLogicalName,
                    _product2Id),
                UoMId = new EntityReference(UoM.EntityLogicalName, _defaultUnitId),
                Quantity = 3,
                Tax = new Money(2.88m),
                IsPriceOverridden = true,
                PricePerUnit = new Money(12)
            };
            _catalogProductPriceOverrideId = _serviceProxy.Create(
                catalogProductPriceOverride);

            // create a new write-in opportunity product with a manual discount applied
            OpportunityProduct writeInProduct = new OpportunityProduct
            {
                OpportunityId = new EntityReference(Opportunity.EntityLogicalName,
                    _opportunityIds[1]),
                IsProductOverridden = true,
                ProductDescription = "Example Write-in Product",
                PricePerUnit = new Money(20.00m),
                Quantity = 5,
                ManualDiscountAmount = new Money(10.50m),
                Tax = new Money(7.16m)
            };
            _writeInProductId = _serviceProxy.Create(writeInProduct);

            // Close the opportunities as 'Won'
            WinOpportunityRequest winRequest = new WinOpportunityRequest()
            {
                OpportunityClose = new OpportunityClose()
                {
                    OpportunityId = new EntityReference
                    {
                        Id = _opportunityIds[0],
                        LogicalName = Opportunity.EntityLogicalName
                    },
                    ActualRevenue = new Money(400.00M),
                    ActualEnd = DateTime.Today
                },
                Status = new OptionSetValue(3)
            };
            _serviceProxy.Execute(winRequest);

            winRequest = new WinOpportunityRequest()
            {
                OpportunityClose = new OpportunityClose()
                {
                    OpportunityId = new EntityReference
                    {
                        Id = _opportunityIds[1],
                        LogicalName = Opportunity.EntityLogicalName
                    },
                    ActualRevenue = new Money(400.00M),
                    ActualEnd = DateTime.Today
                },
                Status = new OptionSetValue(3)
            };
            _serviceProxy.Execute(winRequest);

            #endregion Create Opportunity records
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
                _serviceProxy.Delete("goal", _secondChildGoalId);
                _serviceProxy.Delete("goal", _parentGoalId);
                _serviceProxy.Delete("goalrollupquery", _rollupQueryIds[0]);
                _serviceProxy.Delete("goalrollupquery", _rollupQueryIds[1]);
                _serviceProxy.Delete("opportunityproduct", _writeInProductId);
                _serviceProxy.Delete("opportunityproduct", _catalogProductPriceOverrideId);
                _serviceProxy.Delete("opportunityproduct", _catalogProductId);
                _serviceProxy.Delete("opportunity", _opportunityIds[0]);
                _serviceProxy.Delete("opportunity", _opportunityIds[1]);
                _serviceProxy.Delete("account", _accountIds[0]);
                _serviceProxy.Delete("account", _accountIds[1]);
                _serviceProxy.Delete("productpricelevel", _priceListItem1Id);
                _serviceProxy.Delete("productpricelevel", _priceListItem2Id);
                _serviceProxy.Delete("pricelevel", _priceListId);
                _serviceProxy.Delete("product", _product1Id);
                _serviceProxy.Delete("product", _product2Id);
                _serviceProxy.Delete("discount", _discountId);
                _serviceProxy.Delete("discounttype", _discountTypeId);
                _serviceProxy.Delete("uomschedule", _unitGroupId);
                _serviceProxy.Delete("rollupfield", _inProgressId);
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

                RollupAllGoalsForCustomPeriodAgainstTargetRevenue app = new RollupAllGoalsForCustomPeriodAgainstTargetRevenue();
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

// </snippetrollupallgoalsforcustomperiodagainsttargetrevenue>
// <snippetretrieveopportunity>


using System;
using System.ServiceModel;
using System.ServiceModel.Description;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// found in the SDK\bin folder.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Discovery;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
	/// <summary>
    /// This Sample shows how to retrieve an opportunity with 
    /// related opportunity products.
	/// </summary>
	public class RetrieveOpportunity
	{    
        #region Class Level Members
       
        /// <summary>
        /// Stores the organization service proxy.
        /// </summary>
        OrganizationServiceProxy _serviceProxy;

        // Define the IDs needed for this sample.
        public Guid _unitGroupId;
        public Guid _defaultUnitId;
        public Guid _product1Id;
        public Guid _product2Id;
        public Guid _discountTypeId;
        public Guid _discountId;
        public Guid _priceListId;
        public Guid _priceListItem1Id;
        public Guid _priceListItem2Id;
        public Guid _accountId;
        public Guid _opportunityId;
        public Guid _opportunityProduct1Id;
        public Guid _opportunityProduct2Id;
        
        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// Create and configure the organization service proxy.
        /// Initiate method to create any data that this sample requires.
        /// Retrieve opportunity and opportunity products.
        /// Optionally delete any entity records that were created for this sample.
        /// </summary>
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptforDelete">When True, the user will be prompted to delete all
        /// created entities.</param>
        public void Run(ServerConnection.Configuration serverConfig, bool promptForDelete)
        {
            try
            {
                 
                // Connect to the Organization service. 
                // The using statement assures that the service proxy will be properly disposed.
                using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
                {
                    // This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes();


                    // Call the method to create any data that this sample requires.
                    CreateRequiredRecords();

                    // Retrieve Opportunity record.                
                    Opportunity checkOpportunity = (Opportunity)_serviceProxy.Retrieve(
                        Opportunity.EntityLogicalName,
                        _opportunityId,
                        new ColumnSet("name"));

                    Console.WriteLine("Retrieved {0}", checkOpportunity.Name);

                    // Retrieve the related opportunity products
                    QueryExpression opportunityProductsQuery = new QueryExpression
                    {
                        EntityName = OpportunityProduct.EntityLogicalName,
                        ColumnSet = new ColumnSet("opportunityproductid", "volumediscountamount"),
                        Criteria = new FilterExpression
                        {
                            Conditions = 
                        {
                            new ConditionExpression 
                            {
                                AttributeName = "opportunityid",
                                Operator = ConditionOperator.Equal,
                                Values = { _opportunityId }
                            }
                        }
                        }
                    };

                    DataCollection<Entity> opportunityProducts = _serviceProxy.RetrieveMultiple(
                        opportunityProductsQuery).Entities;

                    foreach (Entity entity in opportunityProducts)
                    {
                        OpportunityProduct opportunityProduct = (OpportunityProduct)entity;
                        Console.WriteLine("Retrieved Opportunity Product {0}",
                            opportunityProduct.OpportunityProductId.Value);
                    }

                    DeleteRequiredRecords(promptForDelete);
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
        /// This method creates any entity records that this sample requires.
        /// Create a unit group.
        /// Retrieve the default unit.
        /// Create few products.
        /// Create new discount list and discount.
        /// Create new price list and few price list items.
        /// Create an account record.
        /// Create a new opportunity and few opportunity products.
        /// </summary>
        public void CreateRequiredRecords()
        {
            // Create a unit group
            UoMSchedule newUnitGroup = new UoMSchedule
            {
                Name = "Example Unit Group",
                BaseUoMName = "Example Primary Unit"
            };

            _unitGroupId = _serviceProxy.Create(newUnitGroup);
            Console.WriteLine("Created {0}", newUnitGroup.Name);

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

            Console.WriteLine("Retrieved {0}", unit.Name);
          
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
            Console.WriteLine("Created {0}", newDiscountType.Name);

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

            Console.WriteLine("Created new discount for the {0}.", newDiscountType.Name);

            // Create a price list
            PriceLevel newPriceList = new PriceLevel
            {
                Name = "Example Price List"
            };

            _priceListId = _serviceProxy.Create(newPriceList);
            Console.WriteLine("Created {0}", newPriceList.Name);

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
            Console.WriteLine(@"Created price list item for the {0} and applied 
                volume discount.", newProduct1.Name);

            // Create a price list item for the second product
            ProductPriceLevel newPriceListItem2 = new ProductPriceLevel
            {
                PriceLevelId = new EntityReference(PriceLevel.EntityLogicalName, _priceListId),
                ProductId = new EntityReference(Product.EntityLogicalName, _product2Id),
                UoMId = new EntityReference(UoM.EntityLogicalName, _defaultUnitId),
                Amount = new Money(20)
            };

            _priceListItem2Id = _serviceProxy.Create(newPriceListItem2);
            Console.WriteLine("Created price list item for the {0}.", newProduct1.Name);

            //Publish Product1
            SetStateRequest publishRequest1 = new SetStateRequest
            {
                EntityMoniker = new EntityReference(Product.EntityLogicalName, _product1Id),
                State = new OptionSetValue((int)ProductState.Active),
                Status = new OptionSetValue(1)
            };
            _serviceProxy.Execute(publishRequest1);

            //Publish Product2
            SetStateRequest publishRequest2 = new SetStateRequest
            {
                EntityMoniker = new EntityReference(Product.EntityLogicalName, _product2Id),
                State = new OptionSetValue((int)ProductState.Active),
                Status = new OptionSetValue(1)
            };
            _serviceProxy.Execute(publishRequest2);
            Console.WriteLine("Published both the products");

            // Create an account record for the opporutnity's potential customerid 
            Account newAccount = new Account
            {
                Name = "Example Account"
            };
            _accountId = _serviceProxy.Create(newAccount);

            Console.WriteLine("Created {0}", newAccount.Name);

            // Create a new opportunity
            Opportunity newOpportunity = new Opportunity
            {
                Name = "Example Opportunity",
                CustomerId = new EntityReference(Account.EntityLogicalName,
                    _accountId),
                PriceLevelId = new EntityReference(PriceLevel.EntityLogicalName,
                    _priceListId)
            };

            _opportunityId = _serviceProxy.Create(newOpportunity);
            Console.WriteLine("Created {0}.", newOpportunity.Name);

            // Create some opportunity products
            OpportunityProduct newOpportunityProduct1 = new OpportunityProduct
            {
                OpportunityId = new EntityReference(Opportunity.EntityLogicalName,
                    _opportunityId),
                ProductId = new EntityReference(Product.EntityLogicalName,
                    _product1Id),
                UoMId = new EntityReference(UoM.EntityLogicalName, _defaultUnitId),
                Quantity = 8
            };

            _opportunityProduct1Id = _serviceProxy.Create(newOpportunityProduct1);

            OpportunityProduct newOpportunityProduct2 = new OpportunityProduct
            {
                OpportunityId = new EntityReference(Opportunity.EntityLogicalName,
                    _opportunityId),
                ProductId = new EntityReference(Product.EntityLogicalName,
                    _product2Id),
                UoMId = new EntityReference(UoM.EntityLogicalName, _defaultUnitId),
                Quantity = 1
            };

            _opportunityProduct2Id = _serviceProxy.Create(
                newOpportunityProduct2);

            Console.WriteLine("Created few opportunity products.");

            return;
        }
        
        /// <summary>
        /// Deletes any entity records that were created for this sample.
        /// <param name="prompt">Indicates whether to prompt the user to delete 
        /// the records created in this sample.</param>
        /// </summary>
        public void DeleteRequiredRecords(bool prompt)
        {
            bool deleteRecords = true;

            if (prompt)
            {
                Console.WriteLine("\nDo you want these entity records deleted? (y/n)");
                String answer = Console.ReadLine();
                
                deleteRecords = (answer.StartsWith("y") || answer.StartsWith("Y"));
            }

            if (deleteRecords)
            {
                _serviceProxy.Delete("opportunityproduct", _opportunityProduct1Id);
                _serviceProxy.Delete("opportunityproduct", _opportunityProduct2Id);
				_serviceProxy.Delete("opportunity", _opportunityId);
				_serviceProxy.Delete("account", _accountId);
                _serviceProxy.Delete("productpricelevel", _priceListItem1Id);
                _serviceProxy.Delete("productpricelevel", _priceListItem2Id);
				_serviceProxy.Delete("pricelevel", _priceListId);
                _serviceProxy.Delete("product", _product1Id);
                _serviceProxy.Delete("product", _product2Id);
				_serviceProxy.Delete("discount", _discountId);
				_serviceProxy.Delete("discounttype", _discountTypeId);
				_serviceProxy.Delete("uomschedule", _unitGroupId);               

                Console.WriteLine("Entity records have been deleted.");
            }
        }
        
        #endregion How To Sample Code

        #region Main
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

                RetrieveOpportunity app = new RetrieveOpportunity();
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

                    FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> fe 
                        = ex.InnerException 
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
        #endregion Main
	}
}

// </snippetretrieveopportunity>
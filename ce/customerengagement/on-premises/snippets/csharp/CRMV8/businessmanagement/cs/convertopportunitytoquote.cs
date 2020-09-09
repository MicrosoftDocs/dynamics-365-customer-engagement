// <snippetconvertopportunitytoquote>


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
	/// This sample shows how to convert an opporutnity to a quote.
	/// </summary>
	public class ConvertOpportunityToQuote
	{
        #region Class Level Members
        
        /// <summary>
        /// Stores the organization service proxy.
        /// </summary>
        private OrganizationServiceProxy _serviceProxy;

        // Define the IDs needed for this sample.
        public Guid _unitGroupId;
        public Guid _product1Id;
        public Guid _product2Id;
        public Guid _priceListId;
        public Guid _priceListItem1Id;
        public Guid _priceListItem2Id;
        public Guid _accountId;
        public Guid _opportunityId;
        public Guid _opportunityProduct1Id;
        public Guid _opportunityProduct2Id;
        public Guid _writeInProductId;
        public Guid _quoteId;
        
        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// Create and configure the organization service proxy.
        /// Initiate creating all entity records that this sample requires.
        /// Convert an opportunity to quote
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
                using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,
                                                                     serverConfig.Credentials, serverConfig.DeviceCredentials))
                {
                    // This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes();

                    // Call the method to create any data that this sample requires.
                    CreateRequiredRecords();

                    // Convert an opportunity to quote.
                    GenerateQuoteFromOpportunityRequest quoteRequest = new GenerateQuoteFromOpportunityRequest()
                    {
                        // Columns that will be transferred
                        ColumnSet = new ColumnSet("name", "customerid"),
                        OpportunityId = _opportunityId
                    };

                    GenerateQuoteFromOpportunityResponse quoteResponse =
                        (GenerateQuoteFromOpportunityResponse)_serviceProxy.Execute(quoteRequest);

                    _quoteId = quoteResponse.Entity.Id;
                    Console.WriteLine("Created the quote from an opportunity.");

                    DeleteRequiredRecords(promptForDelete);
                }
            }
            catch
            {
                // You can handle an exception here or pass it back to the calling method.
                throw;
            }
		}

        /// <summary>
        /// This method creates any entity records that this sample requires.
        /// Create a unit group, few products, price list and price list items.
        /// Create an account record.
        /// Create few opportunities, opportunity products and a write-in product.
        /// </summary>
        public void CreateRequiredRecords()
        {
            // Create a unit group.
            UoMSchedule newUnitGroup = new UoMSchedule
            {
                Name = "Example Unit Group",
                BaseUoMName = "Example Primary Unit"
            };

            _unitGroupId = _serviceProxy.Create(newUnitGroup);

            Console.WriteLine("Created {0}", newUnitGroup.Name);

            // retrieve the unit id.
            QueryExpression unitQuery = new QueryExpression
            {
                EntityName = UoM.EntityLogicalName,
                ColumnSet = new ColumnSet("uomid", "name"),
                Criteria = new FilterExpression(),
                PageInfo = new PagingInfo
                {
                    PageNumber = 1,
                    Count = 1
                }
            };
            unitQuery.Criteria.AddCondition("uomscheduleid", ConditionOperator.Equal, _unitGroupId);

            // Retrieve the unit.
            UoM unit = (UoM)_serviceProxy.RetrieveMultiple(unitQuery).Entities[0];

            Console.WriteLine("Retrieved {0}", unit.Name);

            
            // Create a few products
            Product newProduct1 = new Product
            {
                ProductNumber = "1",
                Name = "Example Product 1",
                ProductStructure = new OptionSetValue(1),
                QuantityDecimal = 2,
                DefaultUoMScheduleId = new EntityReference(UoMSchedule.EntityLogicalName, _unitGroupId),
                DefaultUoMId = new EntityReference(UoM.EntityLogicalName, unit.Id)
            };
           _product1Id = _serviceProxy.Create(newProduct1);

           Console.WriteLine("Created {0}", newProduct1.Name);

            Product newProduct2 = new Product
            {
                ProductNumber = "2",
                Name = "Example Product 2",
                ProductStructure = new OptionSetValue(1),
                QuantityDecimal = 2,
                DefaultUoMScheduleId = new EntityReference(UoMSchedule.EntityLogicalName, _unitGroupId),
                DefaultUoMId = new EntityReference(UoM.EntityLogicalName, unit.Id)
            };
            _product2Id = _serviceProxy.Create(newProduct2);

            Console.WriteLine("Created {0}", newProduct2.Name);

            // Create a price list
            PriceLevel newPriceList = new PriceLevel
            {
                Name = "Example Price List"
            };
            _priceListId = _serviceProxy.Create(newPriceList);

            Console.WriteLine("Created {0}", newPriceList.Name);

            // Create a price list items for the products
            ProductPriceLevel newPriceListItem1 = new ProductPriceLevel
            {
                PriceLevelId = new EntityReference(PriceLevel.EntityLogicalName, _priceListId),
                ProductId = new EntityReference(Product.EntityLogicalName, _product1Id),
                UoMId = new EntityReference(UoM.EntityLogicalName, unit.Id),
                Amount = new Money(20)
            };
            _priceListItem1Id = _serviceProxy.Create(newPriceListItem1);

            Console.WriteLine("Created price list for {0}", newProduct1.Name);

            ProductPriceLevel newPriceListItem2 = new ProductPriceLevel
            {
                PriceLevelId = new EntityReference(PriceLevel.EntityLogicalName, _priceListId),
                ProductId = new EntityReference(Product.EntityLogicalName, _product2Id),
                UoMId = new EntityReference(UoM.EntityLogicalName, unit.Id),
                Amount = new Money(20)
            };
            _priceListItem2Id = _serviceProxy.Create(newPriceListItem2);

            Console.WriteLine("Created price list for {0}", newProduct2.Name);

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


            // Create an account record for the opportunity's potential customerid
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
                CustomerId = new EntityReference(Account.EntityLogicalName, _accountId),
                PriceLevelId = new EntityReference(PriceLevel.EntityLogicalName, _priceListId),
                FreightAmount = new Money(10.00m)
            };
            _opportunityId = _serviceProxy.Create(newOpportunity);

            Console.WriteLine("Created {0}", newOpportunity.Name);

            // Create an opportunity product 
            OpportunityProduct newOpportunityProduct1 = new OpportunityProduct
            {
                OpportunityId = new EntityReference(Opportunity.EntityLogicalName, _opportunityId),
                ProductId = new EntityReference(Product.EntityLogicalName, _product1Id),
                UoMId = new EntityReference(UoM.EntityLogicalName, unit.Id),
                Quantity = 3,
                Tax = new Money(4.80m)
            };
            _opportunityProduct1Id = _serviceProxy.Create(newOpportunityProduct1);

            Console.WriteLine("Created opportunity product for {0} and {1}", newOpportunity.Name, newProduct1.Name);

            // Create a catalog product and override the price per unit
            OpportunityProduct newOpportunityProduct2 = new OpportunityProduct
            {
               OpportunityId = new EntityReference(Opportunity.EntityLogicalName, _opportunityId),
               ProductId = new EntityReference(Product.EntityLogicalName, _product2Id),
               UoMId = new EntityReference(UoM.EntityLogicalName, unit.Id),
               Quantity = 1,
               IsPriceOverridden = true,
               PricePerUnit = new Money(12),
               Tax = new Money(0.96m)
            };
            _opportunityProduct2Id = _serviceProxy.Create(newOpportunityProduct2);

            Console.WriteLine("Created opportunity product for {0} and {1}", newOpportunity.Name, newProduct2.Name);

            // Create a write-in product with a manual discount
            OpportunityProduct newWriteInProduct = new OpportunityProduct
            {
                OpportunityId = new EntityReference(Opportunity.EntityLogicalName, _opportunityId),
                // set this attribute to make it a write-in product
                IsProductOverridden = true,
                ProductDescription = "Example Write-in Product",
                PricePerUnit = new Money(20.00m),
                Quantity = 5,
                ManualDiscountAmount = new Money(10.50m),
                Tax = new Money(7.16m)
            };
            _writeInProductId = _serviceProxy.Create(newWriteInProduct);

            Console.WriteLine("Created {0}", newWriteInProduct.ProductDescription);

            return;
        }
        
        /// <summary>
        /// Deletes any entity records that were created for this sample.
        /// <param name="prompt">Indicates whether to prompt the user to delete the records created in this sample.</param>
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
                _serviceProxy.Delete(Quote.EntityLogicalName, _quoteId);
                _serviceProxy.Delete(OpportunityProduct.EntityLogicalName, _writeInProductId);
                _serviceProxy.Delete(OpportunityProduct.EntityLogicalName, _opportunityProduct1Id);
                _serviceProxy.Delete(OpportunityProduct.EntityLogicalName, _opportunityProduct2Id);
                _serviceProxy.Delete(Opportunity.EntityLogicalName, _opportunityId);
                _serviceProxy.Delete(Account.EntityLogicalName, _accountId);
                _serviceProxy.Delete(ProductPriceLevel.EntityLogicalName, _priceListItem1Id);
                _serviceProxy.Delete(ProductPriceLevel.EntityLogicalName, _priceListItem2Id);
                _serviceProxy.Delete(Product.EntityLogicalName, _product1Id);
                _serviceProxy.Delete(Product.EntityLogicalName, _product2Id);
                _serviceProxy.Delete(PriceLevel.EntityLogicalName, _priceListId);
                _serviceProxy.Delete(UoMSchedule.EntityLogicalName, _unitGroupId);

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

                ConvertOpportunityToQuote  app = new ConvertOpportunityToQuote();
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
        #endregion Main
	}
}

// </snippetconvertopportunitytoquote>
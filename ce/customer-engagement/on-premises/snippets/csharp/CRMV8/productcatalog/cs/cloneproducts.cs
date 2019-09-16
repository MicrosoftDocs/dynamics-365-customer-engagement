// <snippetcloneproducts>


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
    /// This sample shows how to clone a product record.
    /// </summary>
    public class CloneProducts
    {
        #region Class Level Members

        /// <summary>
        /// Stores the organization service proxy.
        /// </summary>
        private OrganizationServiceProxy _serviceProxy;

        // Define the IDs needed for this sample.
        public Guid _unitGroupId;
        public Guid _productId;
        public Guid _productCloneId;        
        public Guid _priceListId;
        public Guid _priceListItemId;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// Create and configure the organization service proxy.
        /// Initiate creating all entity records that this sample requires.
        /// Create a product record.
        /// Clone the product record.
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
                using (_serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig))
                {
                    // This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes();

                    // Call the method to create any data that this sample requires.
                    CreateRequiredRecords();


                    CloneProductRequest cloneReq = new CloneProductRequest
                    {
                        Source = new EntityReference(Product.EntityLogicalName, _productId)
                    };
                    
                    CloneProductResponse cloned = (CloneProductResponse)_serviceProxy.Execute(cloneReq);                                     
                    _productCloneId = cloned.ClonedProduct.Id;
                   
                    // Retrieve the cloned product record
                    Product retrievedProduct = (Product)_serviceProxy.Retrieve(Product.EntityLogicalName, _productCloneId, new ColumnSet(true));
                    Console.WriteLine("\nCreated clone product: {0}", retrievedProduct.Name);
                    

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
        /// Create a unit group and price list.
        /// </summary>
        public void CreateRequiredRecords()
        {
            Console.WriteLine("Creating required records for the sample:");
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


            // Create a price list
            PriceLevel newPriceList = new PriceLevel
            {
                Name = "Example Price List"
            };
            _priceListId = _serviceProxy.Create(newPriceList);

            Console.WriteLine("Created {0}", newPriceList.Name);

            // Create a product record to be cloned.
            Product newProduct = new Product
            {
                Name = "Example Product",
                ProductNumber = "P001",
                ProductStructure = new OptionSetValue(1),                
                QuantityDecimal = 2,
                DefaultUoMScheduleId = new EntityReference(UoMSchedule.EntityLogicalName, _unitGroupId),
                DefaultUoMId = new EntityReference(UoM.EntityLogicalName, unit.Id)
            };
            _productId = _serviceProxy.Create(newProduct);

            Console.WriteLine("\nCreated {0}", newProduct.Name);

            // Create a price list item for the product
            ProductPriceLevel newPriceListItem = new ProductPriceLevel
            {
                PriceLevelId = new EntityReference(PriceLevel.EntityLogicalName, _priceListId),
                ProductId = new EntityReference(Product.EntityLogicalName, _productId),
                UoMId = new EntityReference(UoM.EntityLogicalName, unit.Id),
                Amount = new Money(20)
            };
            _priceListItemId = _serviceProxy.Create(newPriceListItem);

            Console.WriteLine("Created price list for {0}", newProduct.Name);

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
                Console.WriteLine("Deleting entity records... please wait!");

                _serviceProxy.Delete(Product.EntityLogicalName, _productCloneId);
                _serviceProxy.Delete(ProductPriceLevel.EntityLogicalName, _priceListItemId);               
                _serviceProxy.Delete(Product.EntityLogicalName, _productId);
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

                CloneProducts app = new CloneProducts();
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

// </snippetcloneproducts>
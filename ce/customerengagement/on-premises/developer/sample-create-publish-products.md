---
title: "Sample: Create and publish products (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Sample demonstrates how to create a product family, override a product property, publish a product hierarchy, and revise a overridden property."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 0f70898c-c451-47e5-afc8-224e25f32c69
caps.latest.revision: 12
author: KumarVivek
ms.author: kvivek
manager: amyla
search.audienceType: 
  - developer

---
# Sample: Create and publish products

This sample code is for Dynamics 365 Customer Engagement(on-premises). [Download the Product Catalog samples](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/ProductCatalog).    

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to:  
  
-   Create a product family, product property, and child products.  
  
-   Override a product property at a child product level.  
  
-   Publish the product hierarchy.  
  
-   Revise a child product to overwrite the overridden property.  
  
## Example  
  
```csharp  
using System;  
using System.ServiceModel;  
using System.ServiceModel.Description;  
  
// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly  
// found in the SDK\bin folder.  
using Microsoft.Xrm.Sdk;  
using Microsoft.Xrm.Sdk.Messages;  
using Microsoft.Xrm.Sdk.Client;  
using Microsoft.Xrm.Sdk.Query;  
using Microsoft.Xrm.Sdk.Discovery;  
  
// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly  
// found in the SDK\bin folder.  
using Microsoft.Crm.Sdk.Messages;  
  
namespace Microsoft.Crm.Sdk.Samples  
{  
    /// <summary>  
    /// This sample shows how to:  
    /// - Create a product family, product property, and child products.   
    /// - Override a product property at a child product level.  
    /// - Publish the product hierarchy.   
    /// - Revise a child product to overwrite the overridden property.  
    /// </summary>  
    public class CreateAndPublishProducts  
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
        public Guid _productFamilyId;  
        public Guid _productPropertyId;  
        public Guid _productOverridenPropertyId;  
        public Guid _productOverwrittenPropertyId;  
        public Guid _priceListId;  
        public Guid _priceListItem1Id;  
        public Guid _priceListItem2Id;  
        public Guid _productRelationId;  
        public UoM _unit;  
  
        #endregion Class Level Members  
  
        #region How To Sample Code  
        /// <summary>  
        /// Create and configure the organization service proxy.  
        /// Initiate creating all entity records that this sample requires.  
        /// Create a product family with a product property and two child product records.  
        /// Create a substitute relation between the two products.  
        /// Override the product property for one of the child products.  
        /// Publish the product family hierarchy, including the child records.  
        /// Revise a child product to overwrite the overridden property.  
        /// Publish the child product.  
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
  
                    //<snippetCreateandublishProducts1>  
                    // Create a product family  
                    Product newProductFamily = new Product  
                    {  
                        Name = "Example Product Family",  
                        ProductNumber = "PF001",  
                        ProductStructure = new OptionSetValue(2)  
                    };  
                    _productFamilyId = _serviceProxy.Create(newProductFamily);  
                    Console.WriteLine("\nCreated '{0}'", newProductFamily.Name);  
  
                    // Create a product property  
                    DynamicProperty newProperty = new DynamicProperty  
                    {  
                        Name = "Example Property",  
                        RegardingObjectId = new EntityReference(Product.EntityLogicalName,   
                                            _productFamilyId),  
                        IsReadOnly = true,  
                        IsRequired = true,  
                        IsHidden = false,  
                        DataType = new OptionSetValue(3), //Single line of text  
                        DefaultValueString = "Default Value"                                                  
                    };  
                    _productPropertyId = _serviceProxy.Create(newProperty);  
                    Console.WriteLine("\nCreated '{0}' for the product family", newProperty.Name);  
  
                    // Create couple of product records under the product family  
                    Product newProduct1 = new Product  
                    {  
                        Name = "Example Product 1",  
                        ProductNumber = "P001",  
                        ProductStructure = new OptionSetValue(1),  
                        ParentProductId = new EntityReference(Product.EntityLogicalName, _productFamilyId),  
                        QuantityDecimal = 2,  
                        DefaultUoMScheduleId = new EntityReference(UoMSchedule.EntityLogicalName, _unitGroupId),  
                        DefaultUoMId = new EntityReference(UoM.EntityLogicalName, _unit.Id)  
                    };  
                    _product1Id = _serviceProxy.Create(newProduct1);  
  
                    Console.WriteLine("\nCreated '{0}' under the product family", newProduct1.Name);  
  
                    Product newProduct2 = new Product  
                    {  
                        Name = "Example Product 2",  
                        ProductNumber = "P002",  
                        ProductStructure = new OptionSetValue(1),  
                        ParentProductId = new EntityReference(Product.EntityLogicalName, _productFamilyId),  
                        QuantityDecimal = 2,  
                        DefaultUoMScheduleId = new EntityReference(UoMSchedule.EntityLogicalName, _unitGroupId),  
                        DefaultUoMId = new EntityReference(UoM.EntityLogicalName, _unit.Id)                          
                    };  
                    _product2Id = _serviceProxy.Create(newProduct2);  
  
                    Console.WriteLine("Created '{0}' under the product family", newProduct2.Name);  
  
                    // Create a price list items for the products  
                    ProductPriceLevel newPriceListItem1 = new ProductPriceLevel  
                    {  
                        PriceLevelId = new EntityReference(PriceLevel.EntityLogicalName, _priceListId),  
                        ProductId = new EntityReference(Product.EntityLogicalName, _product1Id),  
                        UoMId = new EntityReference(UoM.EntityLogicalName, _unit.Id),  
                        Amount = new Money(20)  
                    };  
                    _priceListItem1Id = _serviceProxy.Create(newPriceListItem1);  
  
                    Console.WriteLine("\nCreated price list for '{0}'", newProduct1.Name);  
  
                    ProductPriceLevel newPriceListItem2 = new ProductPriceLevel  
                    {  
                        PriceLevelId = new EntityReference(PriceLevel.EntityLogicalName, _priceListId),  
                        ProductId = new EntityReference(Product.EntityLogicalName, _product2Id),  
                        UoMId = new EntityReference(UoM.EntityLogicalName, _unit.Id),  
                        Amount = new Money(20)  
                    };  
                    _priceListItem2Id = _serviceProxy.Create(newPriceListItem2);  
  
                    Console.WriteLine("Created price list for '{0}'", newProduct2.Name);  
  
                    // Set the product relationship  
                    // Set Example Product 1 and Example Product 2 as substitute of each other (bi-directional)  
                    ProductSubstitute newProductRelation = new ProductSubstitute  
                    {  
                        SalesRelationshipType = new OptionSetValue(3),  
                        Direction = new OptionSetValue(1),  
                        ProductId = new EntityReference(Product.EntityLogicalName, _product1Id),  
                        SubstitutedProductId = new EntityReference(Product.EntityLogicalName, _product2Id)  
                    };  
                    _productRelationId = _serviceProxy.Create(newProductRelation);  
  
                    Console.WriteLine("\nCreated a substitute relation between the two products.");  
                    //</snippetCreateandublishProducts1>  
  
                    // Override a product property at the product level  
                    // In this case we will override the property for 'Example Product 1'  
                    DynamicProperty newOverrideProperty = new DynamicProperty();  
                    newOverrideProperty.BaseDynamicPropertyId = new EntityReference(DynamicProperty.EntityLogicalName,  
                                               _productPropertyId);  
                    newOverrideProperty.RegardingObjectId = new EntityReference(Product.EntityLogicalName, _product1Id);  
                    _productOverridenPropertyId = _serviceProxy.Create(newOverrideProperty);  
  
                    // Retrieve the attributes of the cloned property you want to update                      
                    ColumnSet columns = new ColumnSet();  
                    columns.AddColumns("name", "isreadonly", "isrequired");  
                    DynamicProperty retrievedOverridenProperty = (DynamicProperty)_serviceProxy.Retrieve(  
                                               DynamicProperty.EntityLogicalName, _productOverridenPropertyId,  
                                               columns);  
  
                    // Update the attributes  
                    retrievedOverridenProperty.Name = "Overridden Example Property";  
                    retrievedOverridenProperty.IsReadOnly = true;  
                    retrievedOverridenProperty.IsRequired = false;  
                    _serviceProxy.Update(retrievedOverridenProperty);  
                    Console.WriteLine("\nOverridden the product property for 'Example Product 1'.");  
  
                    // Prompt the user whether to publish the product family and products  
                    bool publishRecords = true;                    
                    Console.WriteLine("\nDo you want the product records published? (y/n)");  
                    String answer = Console.ReadLine();  
                    publishRecords = (answer.StartsWith("y") || answer.StartsWith("Y"));  
  
                    if (publishRecords)  
                    {  
                        PublishProductHierarchyRequest publishReq = new PublishProductHierarchyRequest  
                        {  
                            Target = new EntityReference(Product.EntityLogicalName, _productFamilyId)  
                        };  
                        PublishProductHierarchyResponse published = (PublishProductHierarchyResponse)_serviceProxy.Execute(publishReq);  
                        if (published.Results != null)  
                        {  
                            Console.WriteLine("Published the product records");  
                        }  
  
                        // Overwrite a product property  
                        Console.WriteLine("\nRevising 'Example Product 1' to demonstrate product property overwrite.");  
  
                        // Retrieve the StateCode of Product that you want to revise                       
                        ColumnSet cols = new ColumnSet();  
                        cols.AddColumns("name", "statecode");  
                        Product retrievedPublishedProduct = (Product)_serviceProxy.Retrieve(  
                                                   Product.EntityLogicalName, _product1Id,  
                                                   cols);  
  
                        // Update the state of the Product to "Under Revision"  
                        retrievedPublishedProduct.StateCode = ProductState.UnderRevision;  
                        UpdateRequest updatePropertyState = new UpdateRequest  
                        {  
                            Target = retrievedPublishedProduct  
                        };  
                        _serviceProxy.Execute(updatePropertyState);  
                        Console.WriteLine("\nChanged '{0}' to 'Under Revision' state.", retrievedPublishedProduct.Name);  
  
                        DynamicProperty newOverwriteProperty = new DynamicProperty();  
                        newOverwriteProperty.BaseDynamicPropertyId = new EntityReference(DynamicProperty.EntityLogicalName,  
                                                   _productOverridenPropertyId);  
                        newOverwriteProperty.RegardingObjectId = new EntityReference(Product.EntityLogicalName,   
                            _product1Id);  
                        _productOverwrittenPropertyId = _serviceProxy.Create(newOverwriteProperty);  
  
                        // Retrieve the attributes of the cloned property you want to update  
                        ColumnSet myCols = new ColumnSet();  
                        myCols.AddColumns("name", "isreadonly", "isrequired");  
                        DynamicProperty retrievedOverwrittenProperty = (DynamicProperty)_serviceProxy.Retrieve(  
                                                   DynamicProperty.EntityLogicalName, _productOverwrittenPropertyId,  
                                                   myCols);  
  
                        // Update the attributes of the cloned property to complete the overwrite   
                        retrievedOverwrittenProperty.Name = "Overwritten Example Property";  
                        retrievedOverwrittenProperty.IsReadOnly = true;  
                        retrievedOverridenProperty.IsRequired = false;  
                        _serviceProxy.Update(retrievedOverwrittenProperty);  
                        Console.WriteLine("\nOverwritten the product property for 'Example Product 1'.");  
  
                        // Retrieve the StateCode of Product that you want to publish                       
                        ColumnSet prodCols = new ColumnSet();  
                        prodCols.AddColumns("name", "statecode");  
                        Product retrievedRevisedProduct = (Product)_serviceProxy.Retrieve(  
                                                   Product.EntityLogicalName, _product1Id,  
                                                   prodCols);  
  
                        // Update the state of the Product to "Active"  
                        retrievedRevisedProduct.StateCode = ProductState.Active;  
                        UpdateRequest publishProduct1 = new UpdateRequest  
                        {  
                            Target = retrievedRevisedProduct  
                        };  
                        _serviceProxy.Execute(publishProduct1);  
                        Console.WriteLine("\nPublished '{0}'.", retrievedRevisedProduct.Name);  
                    }  
  
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
            Console.WriteLine("Creating required records for the sample");  
            Console.WriteLine("*****************************************");  
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
            _unit = (UoM)_serviceProxy.RetrieveMultiple(unitQuery).Entities[0];  
  
            Console.WriteLine("Retrieved {0}", _unit.Name);  
  
            // Create a price list  
            PriceLevel newPriceList = new PriceLevel  
            {  
                Name = "Example Price List"  
            };  
            _priceListId = _serviceProxy.Create(newPriceList);  
  
            Console.WriteLine("Created {0}", newPriceList.Name);  
            Console.WriteLine("*****************************************");  
  
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
  
                _serviceProxy.Delete(ProductSubstitute.EntityLogicalName, _productRelationId);  
                _serviceProxy.Delete(ProductPriceLevel.EntityLogicalName, _priceListItem1Id);  
                _serviceProxy.Delete(ProductPriceLevel.EntityLogicalName, _priceListItem2Id);                  
                _serviceProxy.Delete(Product.EntityLogicalName, _productFamilyId);  
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
  
                CreateAndPublishProducts app = new CreateAndPublishProducts();  
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
```  
  
### See also  
 [Create and manage product families, products and bundles](create-manage-product-families-products-bundles-product-properties.md)   
 [Publish, revise, revert, retire, and activate products (product lifecycle)](publish-revise-revert-retire-activate-products.md)   
 [Product catalog entities](product-catalog-entities.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
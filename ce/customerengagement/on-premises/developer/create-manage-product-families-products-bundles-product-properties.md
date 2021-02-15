---
title: "Create and manage product families, products, bundles, and product properties (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Supports hierarchical organization of the product catalog through the creation and management products and bundles under a product family, defining related products, and adding properties (attributes) to the parent product family."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 0f6c4255-094e-455e-bf7b-b832b981f58b
author: KumarVivek
ms.author: kvivek
manager: amyla
search.audienceType: 
  - developer

---
# Create and manage product families, products, bundles, and product properties

Define your product catalog by organizing your products in a hierarchical structure by creating products and bundles under a product family, defining related products, and adding properties (attributes) to the parent product family so that all the child products and bundles under a product family automatically inherit the properties.  
  
 By default, when you create a product family, product, or bundle record, they are in the **Draft** state. After you have created a product, defined related products, and configured attributes for the parent product family record, you must publish the product family, product, or bundle record for them to become available in the system to your sales agents for selling. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Publish a product family, product, or bundle](publish-revise-revert-retire-activate-products.md#Publish)  
  
> [!NOTE]
>  For products not associated with a product family, that is, products that don’t have a parent product family record assigned to them, you can create them directly in an **Active** state by setting the **Organization.CreateProductsWithoutParentInActiveState** attribute to `1` (true). By default, this attribute is set to `0` (false) for a fresh installation of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] and to `1` (true) if you’re upgrading from a previous version of [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] to ensure compatibility for your applications working with the previous version of [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] where the product records were created in an **Active** state.  
> 
>  You can also use the **Sales** tab in the system settings area in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] or [!INCLUDE[pn_microsoft_dynamics_crm_for_outlook](../includes/pn-microsoft-dynamics-crm-for-outlook.md)] to specify whether products are created in an **Active** state. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage product catalog configuration](https://technet.microsoft.com/library/dn832125.aspx)  
  
<a name="Define"></a>   
## Define products, product families, and bundles  
 Use the `Product.ProductStructure` attribute to define whether an item is a product family, product, or bundle. Set the value of this attribute to:  
  
- **1** to create a product  
  
- **2** to create a product family  
  
- **3** to create a bundle  
  
  Here are some important points to consider while defining product families, products, and bundles:  
  
- A product family record can contain multiple child product family, product, and bundle instances in a hierarchical structure. For a child product family, child product, or child bundle instance, you define the parent product family instance using the `Product.ParentProductId` attribute. You can’t change the parent record once you’ve set it.  
  
- A product or bundle can’t be set as a parent, which implies that a product or bundle record can’t have child records.  
  
- A product family, product, or bundle instance can be part of only one product family instance.  
  
- There is no limit on the nesting level for a product family.  
  
- The `Product.ValidFromDate` and `Product.ValidToDate` attributes don’t have any out-of-box business logic associated with them, except that there is a check to ensure that the date in `Product.ValidToDate` should be later than or equal to the date in `Product.ValidFromDate`. If required, you can implement your own business logic based on these attributes. For example, you could run a scheduled job to automatically retire last season’s products by using the date value in the `Product.ValidToDate` attribute.  
  
  The following code sample demonstrates how you can create a product family and a child product record.  
  
```csharp  
// Create a product family  
Product newProductFamily = new Product  
{  
   Name = "Example Product Family",  
   ProductNumber = "PF001",  
   ProductStructure = new OptionSetValue(2)  
};  
_productFamilyId = _serviceProxy.Create(newProductFamily);  
Console.WriteLine("\nCreated {0}", newProductFamily.Name);  
  
// Create a product record under the product family  
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
Console.WriteLine("Created {0} under the product family", newProduct1.Name);  
```  
  
<a name="Properties"></a>   
## Define product properties  
 Product properties help you define the characteristics of  product such as its size, color, or component. A product property is defined using the `DynamicProperty` entity. While defining a product property, you can only associate it to a product family record in a `Draft` state, and not to a product or bundle record. The maximum number of product properties that can be associated to a draft product family record is determined by the following organization setting: **Organization.MaximumDynamicPropertiesAllowed**. The number comes into effect when you publish a child product record or bundle under a product family that the properties are attached to, and not at the time when you attach the properties to a *draft* product family record.  
  
> [!TIP]
>  You can also use the **Sales** tab in the system settings area in Dynamics 365 Customer Engagement (on-premises) or [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] to configure the maximum number of product properties. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage product catalog configuration](https://technet.microsoft.com/library/dn832125.aspx).  
  
 While creating a product property, you specify its name, the product family record in `Draft` state with which it is associated, attributes of the property such as whether its hidden, required, or read-only, and the data type of the property. A product property can be of one of the following data types:  
  
|Value|Data Type|  
|-----------|---------------|  
|0|Option Set|  
|1|Decimal|  
|2|Floating Point Number|  
|3|Single Line of Text|  
|4|Whole Number|  
  
 You cannot change the data type of a product property after its created. When you create a product property, its created in the `Draft` state.  
  
 The following sample code demonstrates how you  can create a product property:  
  
```csharp  
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
```  
  
 For the complete sample, see [Sample: Create and publish products](sample-create-publish-products.md)  
  
> [!NOTE]
>  When you create a product property of `Option Set` data type, you must define individual options for the product property by creating  `DynamicPropertyOptionSetItem` entity records. Each entity record stores information about the individual option where the  `DynamicPropertyOptionSetItem.DynamicPropertyOptionName` and `DynamicPropertyOptionSetItem.DynamicPropertyOptionValue` attributes define the option name and value respectively, and you can associate individual option records to the parent product property instance using the `DynamicPropertyOptionSetItem.DynamicPropertyId` attribute.  
  
 For information about creating and managing product properties using the web client, see [Use properties to describe a product](https://go.microsoft.com/fwlink/p/?LinkId=512709)  
  
> [!NOTE]
>  The way you define a product property determines how it can be used by the sales agent at run time, that is, while adding an associated product to an opportunity, quote, order, or invoice. An *updatable* product property’s value can be changed at run time, whereas the value of a *read-only* product property can’t be. For a product property set as *required*, a value for the property must be specified at the run time. Otherwise, the property is displayed as unresolved. A *hidden* property won’t be displayed to sales agents at the run time.  
> 
>  Also, product properties don’t affect the pricing of a product. This implies that the Dynamics 365 Customer Engagement (on-premises) pricing engine doesn’t support changing the price of a product based on a change in the product property values.  
  
<a name="ChangeProductProperties"></a>   
### Change product properties  
 It's important to know the various states  of the product property in order to understand how and when it can be changed. A product property can be in **Draft**, **Active**, or **Retired** state. When a product is created, its in the **Draft** state, and changes to the **Active** state once the product family record with which it is associated is published. When the associated product family record is retired, the state of the product property also changes to `Retired`.  
  
 A product property can be changes at two levels: *first* at the product family level to which the product property is associated with; *second* at the child product family, product, or bundle level where the product property is inherited.  
  
 **Changing product property for the product family that its associate with**  
  
 For a `Draft`  product family record, you can change a product property associated to it. Once you publish the product family record (changes to `Active` state), you cannot change the product property until you revise the product family record. After revising the product family record (changes to `Under Revision` state), and then *overwrite* the published (active) version of the property to make changes. For information about product life cycle, see [Publish, revise, revert, retire, and activate products (product lifecycle)](publish-revise-revert-retire-activate-products.md)  
  
 **Changing inherited product property for the child product family, product, or bundle**  
  
 For a product property in the `Draft` state, the child product family, product, and bundle records can *override* the inherited property to define their own version of the property. For example, override the inherited property to change its name or change attributes from hidden to visible, required to optional, or read-only to updatable. You cannot override or change the data type of the inherited property.  
  
 **To override a product property**, you create an instance of the product property  and set the `BaseDynamicPropertyId` property to the GUID of the property you are overriding. Additionally, you also associate the new property instance to the child product family, product, or bundle record where its being overridden.  
  
 The following sample code demonstrates how you can override an existing product property record, say with GUID `_productPropertyId`, and associate the overridden property to the product record, say with GUID `_product1Id`. After this, you can update the attributes of the new property to specify your own values to complete the override.  
  
```csharp  
// Override a product property  
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
```  
  
 For the complete sample, see [Sample: Create and publish products](sample-create-publish-products.md)  
  
 For a product property in the `Active` state, you can *overwrite* the inherited property for the child product family, product, or bundle record provided both the following clauses are true:  
  
- The child product family, product, or bundle record is in the **Under Revision** state.  
  
- The inherited active product property is already overridden.  
  
  **To overwrite a product property**, you create an instance of the product property  and set the `BaseDynamicPropertyId` property to the GUID of the already overridden property. Additionally, you also associate the new property instance with the product family, product, or bundle record that is in the `Under Revision` stage.  
  
  The following sample code demonstrates how you can overwrite a product property record in the active state that is already overridden, say with GUID `_productOverridenPropertyId`, and associate the new property to the product record in the `Under Revision` state, say with GUID `_product1Id`. After this, you can update the attributes of the new property to specify your own values, and complete the overwrite.  
  
```csharp  
// Overwrite a product property  
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
```  
  
 For the complete sample, see [Sample: Create and publish products](sample-create-publish-products.md)  
  
<a name="BundlesKits"></a>   
## Bundles and kits  
 A *bundle* is a feature introduced in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] to replace the older kit functionality. Similar to a kit, a bundle is a collection of products that is sold as single unit. Product bundling is useful in grouping products in a way that customers get more benefit from the full line of products or to offer discounts on bundled products that enables you to group products and sell as a single unit.  
  
 Only products can be added to a bundle; you can’t add a product family, a bundle, or a kit record to a bundle. You can add products to a bundle or a kit by creating a product association record using the `ProductAssociation` entity. The `ProductAssociation.ProductId` record specifies the bundle or kit that you want to add a product to and the `ProductAssociation.AssociatedProduct` specifies the product to be added. The maximum number of products that can be added to a bundle is determined by the following organization setting:  `Organization.MaxProductsinBundle`.  
  
 You can also use the **Sales** tab in the system settings area in Dynamics 365 Customer Engagement (on-premises) or [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] to specify the maximum number of products that can be added to a bundle. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage product catalog configuration](https://technet.microsoft.com/library/dn832125.aspx)  
  
 The following code sample demonstrates how you can add products to a bundle.  
  
```csharp
// Add a product to a bundle  
ProductAssociation newAssociation1 = new ProductAssociation  
{  
   AssociatedProduct = new EntityReference(Product.EntityLogicalName, _product1Id),  
   ProductId = new EntityReference(Product.EntityLogicalName, _bundleId),  
   Quantity = new decimal(15),  
   ProductIsRequired = new OptionSetValue(0),  
   UoMId = new EntityReference(UoM.EntityLogicalName, unit.Id)  
};  
_product1AssociationId = _serviceProxy.Create(newAssociation1);                      
  
// Add another product to the bundle                      
ProductAssociation newAssociation2 = new ProductAssociation  
{  
   AssociatedProduct = new EntityReference(Product.EntityLogicalName, _product2Id),  
   ProductId = new EntityReference(Product.EntityLogicalName, _bundleId),  
   Quantity = new decimal(20),  
   ProductIsRequired = new OptionSetValue(1),  
   UoMId = new EntityReference(UoM.EntityLogicalName, unit.Id),                          
};  
_product2AssociationId = _serviceProxy.Create(newAssociation2);  
  
if ((_product1AssociationId != null) && (_product1AssociationId != null))  
Console.WriteLine("\nAdded both the products to the bundle");  
```  
  
 For the complete sample, see [Sample: Add products to a bundle](sample-add-products-bundle.md).  
  
### Differences between kits and bundles  
 Both kits and bundles enable you to group products into a single unit, but here are some differences between the two.  
  
|Kits|Bundles|  
|----------|-------------|  
|All the products in a kit are mandatory.|Some products in a bundle can be optional.|  
|Kits support nesting; you can add a kit to another kit.|You can’t add a bundle to another bundle. You can only add products to a bundle.|  
|While adding a kit to an opportunity, quote, order, or invoice, you can only see the kit level details; you can’t see individual products in the kit.|While adding a bundle to opportunity, quote, order, or invoice, you can see the bundle level details as well as individual products in the bundle.|  
  
> [!NOTE]
>  Kits are deprecated in Dynamics 365 Customer Engagement (on-premises); you should use bundles instead.  
  
<a name="ProductRelationships"></a>   
## Define product relationships for enhanced suggestions during product sale  
 You can define related products for a product that are displayed as suggestions to your sales agents during opportunity or order management. The product suggestions for a product enables your sales agents to recommend related products and bundles/kits to the customers, and increase product sales. You can define the following relationships for a product: **accessory**, **cross-sell**, **substitute**, and **up-sell**. For example, Surface Pro can be added as an up-sell product for Surface RT so that when your sales agent is adding Surface RT to any opportunity, quote, order, or invoice, Surface Pro will be suggested as the up-sell option.  
  
 Use the **ProductSubstitute.SalesRelationshipType** attribute to define product relationships. Set the value of this attribute to:  
  
- **0** for up-sell  
  
- **1** for cross-sell  
  
- **2** for accessory  
  
- **3** for substitute  
  
  While defining product relationships, it’s important to define the direction of the relationship to prevent duplication of data. The supported directions the product relationships are:  
  
|Product relationship|Direction|  
|--------------------------|---------------|  
|Accessory|Uni-directional|  
|Cross-sell|Uni-directional or Bi-directional|  
|Substitute|Uni-directional or Bi-directional|  
|Up-Sell|Uni-directional|  
  
 Use the **ProductSubstitute.Direction** attribute to specify direction for a product relationship. Set the value of this attribute to:  
  
- **0** for uni-directional  
  
- **1** for bi-directional  
  
  The following code sample demonstrates how you can define relationships for products.  
  
```csharp
// Set product relationship  
// Set product1 and product2 as substitute of each other (bi-directional)  
ProductSubstitute newProductRelation = new ProductSubstitute  
{  
   SalesRelationshipType = new OptionSetValue(3),  
   Direction = new OptionSetValue(1),  
   ProductId = new EntityReference(Product.EntityLogicalName, _product1Id),  
   SubstitutedProductId = new EntityReference(Product.EntityLogicalName, _product2Id)  
};  
_productRelationId = _serviceProxy.Create(newProductRelation);  
```  
  
<a name="Clone"></a>   
## Clone a product family, product, or bundle  
 Use the <xref:Microsoft.Crm.Sdk.Messages.CloneProductRequest> message to clone a product family, product, or bundle record, and create a copy of the record under the same parent node. You must provide the ID of the record to clone. Cloning a product record also copies the properties of the product. The cloned record is created with the date and time stamp appended to the original values in the **Product.Name** and **Product.ProductNumber** attributes; the date time stamp denotes the time when the record was cloned. The following code sample demonstrates how to clone a product.  
  
```csharp  
CloneProductRequest cloneReq = new CloneProductRequest  
{  
   Source = new EntityReference(Product.EntityLogicalName, _productId)  
};  
  
CloneProductResponse cloned = (CloneProductResponse)_serviceProxy.Execute(cloneReq);                                       
_productCloneId = cloned.ClonedProduct.Id;  
  
// Retrieve the cloned product record  
Product retrievedProduct = (Product)_serviceProxy.Retrieve(Product.EntityLogicalName, _productCloneId, new ColumnSet(true));  
Console.WriteLine("\nCreated clone product: {0}", retrievedProduct.Name);  
```  
  
## Next step  
 Publish your product records to make products available for selling by your sales agents. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Publish a product family, product, or bundle](publish-revise-revert-retire-activate-products.md#Publish)  
  
### See also  
 [Publish, revise, revert, retire, and activate products (product lifecycle)](publish-revise-revert-retire-activate-products.md)   
 [Sample: Create and publish products](sample-create-publish-products.md)   
 [Sample: Clone product records](sample-clone-product-records.md)   
 [Sample: Add products to a bundle](sample-add-products-bundle.md)   
 [Product catalog entities](product-catalog-entities.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
---
title: Publish, revise, revert, retire, and activate products (product lifecycle)
description: Control the product lifecycle programmatically by moving products between Draft, Active, Under Revision, and Retired states. Learn how.
ms.date: 07/07/2026
ms.topic: how-to
author: udaykirang
ms.author: udag
ms.reviewer: udag
search.audienceType: 
  - developer

---

# Publish, revise, revert, retire, and activate products (product lifecycle)

By default, when you create a product record, it's in the **Draft** state and isn't available to your sales agents. Your sales agents can access the record only when you publish it, which changes the record's state to **Active**. For products that aren't associated with a product family - products that don't have a parent product family record - you can create them directly in an **Active** state by setting the **Organization.CreateProductsWithoutParentInActiveState** column to `1` (true). By default, this column is set to `0` (false) for a fresh installation of Dynamics 365 Sales and to `1` (true) if you're upgrading from a previous version of Dynamics 365 Sales to ensure compatibility for your applications working with the previous version of Dynamics 365 where the product records were created in an **Active** state.  
  
 You can also use the **Sales** tab in the system settings area in Dynamics 365 Sales or [!INCLUDE[pn_microsoft_dynamics_crm_for_outlook](../../includes/pn-microsoft-dynamics-crm-for-outlook.md)] to specify whether products are created in an active state. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage product catalog configuration](/previous-versions/dynamicscrm-2016/administering-dynamics-365/dn832125(v=crm.8))  
  
 Furthermore, you can revise, revert, retire, and activate your product records to maintain your product catalog as per your business requirements. The following illustration shows the state transitions of a product when you perform various operations on a product record in Dynamics 365 Sales.  

:::image type="content" source="../media/crm-sdk-product-life-cycle.png" alt-text="Screenshot of product lifecycle and state transitions.":::
  
 ***Activate\\**** : The activate operation is applicable for certain type of product records only. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Activate a product or kit record](publish-revise-revert-retire-activate-products.md#Activate)  
  
<a name="Publish"></a>   
## Publish a product family, product, or bundle  

 Use the <xref:Microsoft.Crm.Sdk.Messages.SetStateRequest> message to publish an individual product family, product, or bundle record. This action changes the state of the target record from **Draft** to **Active**. You can publish a child product or bundle record under a product family record only if the parent product family record is published (in the **Active** state). You can't publish multiple product family, product, or bundle records at once.  
  
 Use the <xref:Microsoft.Crm.Sdk.Messages.PublishProductHierarchyRequest> message to publish a product family hierarchy, including the child products and bundles. You can use this message only with a product family record. The state of the target product family record and all the child product or bundle records changes from **Draft** to **Active**.  
  
 The following code sample demonstrates how to publish an individual product family, product, or bundle record.  
  
```csharp  
SetStateRequest publishRequest = new SetStateRequest  
{  
   EntityMoniker = new EntityReference(Product.EntityLogicalName, _productId),  
   State = new OptionSetValue((int)ProductState.Active),  
   Status = new OptionSetValue(1)  
};              
_serviceProxy.Execute(publishRequest);  
```  
  
 The following code sample demonstrates how to publish a product family, including its child records.  
  
```csharp  
PublishProductHierarchyRequest publishRequest = new PublishProductHierarchyRequest  
{  
   Target = new EntityReference(Product.EntityLogicalName, _productFamilyId)  
};  
_serviceProxy.Execute(publishRequest);  
  
```  
  
 For the complete sample code, see [Sample: Create and publish products](sample-create-publish-products.md).  
  
> [!IMPORTANT]
> For the product or bundle records that aren't associated with a product family, you must publish them individually after creating or editing them to make them available to your sales agents. For product or bundle records associated with a product family, use the <xref:Microsoft.Crm.Sdk.Messages.PublishProductHierarchyRequest> message on the parent product family record to publish multiple child product or bundle records, along with the parent product family record, at once.  
>
> Also, for products that aren't associated with a product family, you can create them directly in an **Active** state by setting the **Organization.CreateProductsWithoutParentInActiveState** column to `1` (true). Alternately, use the **Sales** tab in the system settings area in Dynamics 365 Sales or [!INCLUDE[pn_microsoft_dynamics_crm_for_outlook](../../includes/pn-microsoft-dynamics-crm-for-outlook.md)] to specify whether products not associated with product families are created in an active state. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Configure product catalog information](/previous-versions/dynamicscrm-2016/administering-dynamics-365/dn832125(v=crm.8))  
  
<a name="Revise"></a>   
## Revise a product family, product, or bundle  

 Use the <xref:Microsoft.Crm.Sdk.Messages.SetStateRequest> message to revise a product family, product, or bundle record.  
  
- When you use it for a product family record, it revises the product family and its child records.  
  
- When you use it for a product or a bundle record, it revises the individual record only.  
  
  The state of the target record changes from **Active** to **Under Revision**.  
  
  After you update the product properties (columns), you must publish the target record for the changes to take effect. On publishing, the state of the target record changes from **Under Revision** to **Active**.  
  
> [!NOTE]
> When you revise a product and change the properties, Dynamics 365 Sales internally creates a new version of the product and copies the product details from the existing product to the newer version. The new product version has all the details including price lists, product relationships, and properties. The opportunities created with the older version of the product can continue to refer to the older version of the product. The opportunities that are created after the product is revised or retired refer to the current (newer) product version.  
  
<a name="Revert"></a>   
## Revert a product family, product, or bundle  

 Use the <xref:Microsoft.Crm.Sdk.Messages.RevertProductRequest> message to revert a product family, product, or bundle record to its last **Active** state. All the product property (column) changes you made to the record since it was last published (**Active** state) are lost.  
  
- When you use it for a product family record, it reverts the product family and its child records to their last **Active** state, and all the changes to the product properties of the records since they were last published are lost.  
  
- When you use it for a product or a bundle record, it reverts the individual product or bundle record to its last **Active** state, and all the changes to the product properties of the record since it was last published are lost.  
  
  The state of the target record changes from **Under Revision** to **Active**.  
  
  The following code sample demonstrates how to revert a product record.  
  
```csharp  
RevertProductRequest revertReq = new RevertProductRequest  
{  
   Target = new EntityReference(Product.EntityLogicalName, _productId)  
};  
RevertProductResponse reverted = (RevertProductResponse)_serviceProxy.Execute(revertReq);  
```  
  
<a name="Retire"></a>   
## Retire a product family, product, or bundle  

 Use the <xref:Microsoft.Crm.Sdk.Messages.SetStateRequest> message to retire a product family, product, or bundle record.  
  
- When you use this message for a product family record, it retires the entire product family hierarchy.  
  
- When you use this message for a product or a bundle record, it retires the individual record only.  
  
  The state of the target record changes to **Retired**.  
  
> [!NOTE]
> You can't retire a product that is part of a published (**Active**) bundle. Also, you can't add a retired product to a bundle or add a product to a retired bundle.  
  
<a name="Activate"></a>   
## Activate a product or kit record 
 
 Use the <xref:Microsoft.Crm.Sdk.Messages.SetStateRequest> message to activate only the following types of record:  
  
- A retired product record that doesn't have a parent record.  
  
- A retired kit record.  
  
  The state of the target record changes from **Retired** to **Active**.  
  
> [!NOTE]
> You can't activate a retired product family or a retired bundle record.  
  
## Related information 
 
 [Manage Product Pricing](product-pricing-methods.md)   
 [Create and manage product families, products and bundles](create-manage-product-families-products-bundles-product-properties.md)   
 [Product catalog tables](product-catalog-entities.md)


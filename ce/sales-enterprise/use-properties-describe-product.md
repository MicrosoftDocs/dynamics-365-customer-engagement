---
title: "Use properties to describe a product (Dynamics 365 for Sales) | MicrosoftDocs"
description: "Simplify product management and classification by adding product properties in Dynamics 365 for Sales."
keywords: "Properties, product properties, classification"
ms.date: 04/01/2018
ms.service: crm-online
ms.custom: 
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 3fd1c7a7-2f4d-48d5-9ae8-dbb5689c6d67
author: shubhadaj
ms.author: shujoshi
manager: brycho
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 24
topic-status: Drafting
---

# Use properties to describe a product (Sales)

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Simplify product management and classification by adding properties that help distinguish products from one another. Adding well-defined properties to products cuts down on the time spent by your agents trying to find products with the right specifications or properties for your customers when they're building orders.  
  
 A property of a product could be its size, color, or component and so on. Properties are added at the family level. You can add properties only to a family, and only when it is in a draft or under revision state. The child products, bundles, and families inherit the properties from their parent family.  
  
> [!IMPORTANT]
>  You can't set different prices for the different properties you define for a product unless you're using a custom pricing engine.  
  
## Add properties to product families (Sales Hub app)

1. [!INCLUDE[proc_permissions_admin_cust_mgr_vp_sales_ceo](../includes/proc-permissions-admin-cust-mgr-vp-sales-ceo.md)]

2. Select the site map ![Site Map icon](media/site-map-icon.png "site map icon"), and then select **Products**.  

3. On the **Product Properties** tab, select **Add New Property**.

   ![Add new properties to a product family](media/add-new-properties.png "Add new properties to a product family")

4. In the **Property** form, on the **Summary** tab, enter the name of the property and set other fields as required.

   > [!NOTE]

   > You can hide a property by setting **Hidden** to **Yes**. When you hide a property, you block the child families or products from inheriting that property. 

5. On the **Properties** tab, select a data type for the property you’re adding.

     The following table shows a list of properties that you might want to add for a shirt product family:  
  
    |Property name|Data type|Values|  
    |-------------------|---------------|------------|  
    |Color|Option Set|red, blue, yellow, green|  
    |Size|Option Set|small, medium, large|  

6.	Select **Save**. 

Repeat the steps to add multiple properties. 

## Change properties of product family, products, or bundles (Sales Hub app)

 You can make changes to the inherited properties of an individual product or family by overriding its properties. For example, for a shirt family, the size can vary between small, medium, and large. A product inside this family will inherit the same property. You can override the property to define the actual size of an individual shirt to medium.  

1. Open the product you want to override the property of.  
  
2. On the **Product Properties** tab, open the property you want to override. 

   ![Override property of a product](media/override-property.png "Override property of a product")

3. In the **Product Properties** form, select **Override**.  
  
4.  Change the details as required, and save the properties record.  
  
    > [!NOTE]
    
    >  You can override properties only for products and families that have inherited properties from the parent family.  
  
    In the following cases, you'll see the **Overwrite** option instead of the **Override** option:  
  
     -   You're trying to change non-inherited properties of a product family that's in the **Under Revision** status.  
  
     -   You're trying to change the inherited and already overridden properties of a child product family or product. If the inherited properties of the child product or family weren't overridden, you'll see the Override option.  
  
> [!NOTE]

>  Child families can have their own properties in addition to inherited ones.  

## Add properties to product families  (Sales app)
  
1. [!INCLUDE[proc_settings_prod_catalog](../includes/proc-settings-prod-catalog.md)]  
  
2.  Select **Families & Products**.  
  
3.  Select the product family you want to add properties for.  
  
4.  In the product form, in the **Product Properties** section, select ![Add properties button](../sales-enterprise/media/add-properties-button.png "Add properties button").  
  
5. [!INCLUDE[proc_handy_infotips](../includes/proc-handy-infotips.md)]  
  
    > [!NOTE]
    >  You can hide a property by setting **Hidden** to **Yes**. When you hide a property, you block the child families or products from inheriting that property.  
  
     The following table shows a list of properties that you might want to add for a shirt product family:  
  
    |Property name|Data type|Values|  
    |-------------------|---------------|------------|  
    |Color|Option Set|red, blue, yellow, green|  
    |Size|Option Set|small, medium, large|  
  
6.  Select the **Save** button in the bottom right corner, and close the form.  
  
 Repeat the steps to add multiple properties.  
  

## Change properties of product family, products, or bundles  (Sales app)

 
1.  Open the product you want to override the property of.  
  
2.  Select the property you want to override.  
  
3.  In the **Product Properties** form, on the command bar, select **Override**.  
  
4.  Change the details as required, and save the properties record.  
  
> [!NOTE]
>  You can override properties only for products and families that have inherited properties from the parent family.  
  
 In the following cases, you'll see the **Overwrite** option instead of the **Override** option:  
  
-   You're trying to change non-inherited properties of a product family that's in the **Under Revision** status.  
  
-   You're trying to change the inherited and already overridden properties of a child product family or product. If the inherited properties of the child product or family weren't overridden, you'll see the Override option.  
  
> [!NOTE]
>  Child families can have their own properties in addition to inherited ones.  
  
 
## Product versioning  (Sales Hub and Sales app)
 At times, opportunities run for extended period. During this period, the associated product may change or retire. In such cases, the opportunity must still be taken through to completion.  
  
 When you revise a product and change the properties, [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] automatically creates a new version of the product and copies the product details from the existing product to the newer version. The new product version has all the details including price lists, product relationships, and properties. The already-created opportunities with the older version of product can continue to refer to the older version of the product. The opportunities that are created after the product is revised or retired will refer to the current (newer) version.  
  
### See also  
 [Set up a product catalog: Walkthrough](set-up-product-catalog-walkthrough.md)   
 [System Settings dialog box - Sales tab](../admin/system-settings-dialog-box-sales-tab.md)   
 [Create a product family](../sales-enterprise/create-product-family.md)

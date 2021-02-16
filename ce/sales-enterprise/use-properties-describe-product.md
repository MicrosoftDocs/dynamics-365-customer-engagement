---
title: "Use properties to describe a product (Dynamics 365 Sales) | MicrosoftDocs"
description: "Simplify product management and classification by adding product properties in Dynamics 365 Sales."
ms.date: 02/10/2021
ms.service: 
  - "dynamics-365-sales"
ms.custom: 
  - "dyn365-sales"
ms.topic: article
author: shubhadaj
ms.author: shujoshi
manager: annbe
---

# Use properties to describe a product (Sales Hub)

Simplify product management and classification by adding properties that help distinguish products from one another. Adding well-defined properties to products cuts down on the time spent by your agents trying to find products with the right specifications or properties for your customers when they're building orders.  

A property of a product could be its size, color, component, and so on. You can add properties to a family, bundle, or product when they're in **Draft** or **Under Revision** states. The child products, bundles, and families inherit the properties from their parent.  

> [!IMPORTANT]
> You can't set different prices for the different properties you define for a product unless you're using a custom pricing engine.  

## Add properties to a product, bundle, or family

1. [!INCLUDE[proc_permissions_admin_cust_mgr_vp_sales_ceo](../includes/proc-permissions-admin-cust-mgr-vp-sales-ceo.md)]

2. Select the site map ![Site Map icon](media/site-map-icon.png "Site map icon"), then select **App Settings**, and then select **Families and Products**.

3. Open the product, bundle, or family you want to add the properties for.

3. On the **Product Properties** tab, select **Add New Property**.

    > [!div class="mx-imgBorder"]
    > ![Add new properties to a product family](media/add-new-properties.png "Add new properties to a product family")

4. In the **Property** form, on the **Summary** tab, enter the name of the property, and set other fields, as required.

   > [!NOTE]
   > You can hide a property by setting **Hidden** to **Yes**. When you hide a property, you block the child families or products from inheriting that property. 

5. On the **Properties** tab, select a data type for the property you’re adding.

    As an example, the following table shows a list of properties that you might want to add for a shirt product family:  


   | Property name | Data type  |          Values          |
   |---------------|------------|--------------------------|
   |     Color     | Option Set | red, blue, yellow, green |
   |     Size      | Option Set |   small, medium, large   |


6. Select **Save**. 

Repeat the steps to add multiple properties. 

## Change properties of product family, products, or bundles

You can make changes to the inherited properties of an individual product or family by overriding its properties. For example, for a shirt family, the size can vary between small, medium, and large. A product inside this family will inherit the same property. You can override the property to define the actual size of an individual shirt to medium.  

1. Open the product you want to override the property of.  

2. On the **Product Properties** tab, open the property you want to override. 

   > [!div class="mx-imgBorder"]
   > ![Override property of a product](media/override-property.png "Override property of a product")

3. In the **Product Properties** form, select **Override**.  

4. Change the details as required, and save the properties record.  

   > [!NOTE]
   > You can override properties only for products and families that have inherited properties from the parent family.  

In the following cases, you'll see the **Overwrite** option instead of the **Override** option:  

-   You're trying to change non-inherited properties of a product family that's in the **Under Revision** status.  
    
-   You're trying to change the inherited and already overridden properties of a child product family or product. If the inherited properties of the child product or family weren't overridden, you'll see the **Override** option.  

> [!NOTE]
> Child families can have their own properties in addition to inherited ones.  


## Product versioning
At times, opportunities run for extended periods. During these periods, the associated product may change or retire. In such cases, the opportunity must still be taken through to completion.  

When you revise a product and change the properties, [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] automatically creates a new version of the product and copies the product details from the existing product to the newer version. The new product version has all the details including price lists, product relationships, and properties. The already-created opportunities with the older version of product can continue to refer to the older version of the product. The opportunities that are created after the product is revised or retired will refer to the current (newer) version.  

### See also  
 [Set up a product catalog](set-up-product-catalog-walkthrough.md)   
 [System Settings dialog box - Sales tab](../admin/system-settings-dialog-box-sales-tab.md)   
 [Create a product family](../sales-enterprise/create-product-family.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
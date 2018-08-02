---
title: "Set up product bundles to sell multiple items together (Dynamics 365 for Sales) | MicrosoftDocs"
description: "Combine products in a bundle in Dynamics 365 for Sales to sell multiple items together."
keywords: "Bundle, Product Bundle"
ms.date: 04/01/2018
ms.service: dynamics-365-sales
ms.custom:
  - dyn365-sales
ms.topic: get-started-article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 1b15ac3d-9cce-4ad8-8014-5e89e0a709f4
author: shubhadaj
ms.author: shujoshi
manager: sakudes
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 28
topic-status: Drafting
---

# Set up product bundles to sell multiple items together (Sales and Sales Hub)

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Encourage customers to buy more products instead of a single product by combining products in a bundle. Bundles replace the older kit functionality in [!INCLUDE[pn_microsoftcrm](../includes/pn-dynamics-crm.md)]. Kits have been deprecated, so we recommend that you start using bundles instead.  
  
 These are the differences between kits and bundles:  
  
- You can't sell the products in a kit individually or separately, but you can mark certain products in a bundle as optional, and sell them individually.  
  
- You can't see individual products added in a kit when you create an opportunity or order, but you can see the products in a bundle.  
  
- You can create nested kits (kits within a kit), but you can only add products to a bundle; you cannot add product families, kits, or other bundles to a bundle.  
  
  Similar to a kit, a bundle is a collection of products that is sold as single unit. Product bundling is useful in cases like:  
  
- Pairing a top-selling product with a less popular product  
  
- Grouping products in a way that customers get more benefit from the full line of products, for example Microsoft Office Suite or a digital camera with lenses  


## Create a product bundle (Sales Hub app)

1. [!INCLUDE[proc_permissions_admin_cust_mgr_vp_sales_ceo](../includes/proc-permissions-admin-cust-mgr-vp-sales-ceo.md)]  
  
2. Select the site map ![Site Map icon](media/site-map-icon.png "site map icon"), and then select **Products**.  
  
3. To add a standalone product bundle, select **Add Bundle**.  
  
    -OR-  
  
    To add product bundle to an existing family, select the family in the list, and then select **Add Bundle**.  

    ![Add Bundle button on the Products grid](media/add-bundle.png "Add Bundle button on the Products grid")
  
4. Fill in the information:

   - **Name**. 

   - **Product ID**.

   - **Parent**. Select a parent product family for the product bundle. If you're creating a child product bundle in a product family, the name of the parent product family is populated here. This can't be changed after the record is saved.

   - **Valid From**/**Valid To**. Define the period the product bundle is valid for by selecting a **Valid From** and **Valid To** date.
    
   - **Unit Group**. Select a unit group. A unit group is a collection of various units a product is sold in and defines how individual items are grouped into larger quantities. For example, if you're adding seeds as a product, you may have created a unit group called "Seeds," and defined its primary unit as "packet."  
  
   - **Default Unit**. Select the most common unit in which the product will be sold. Units are the quantities or measurements that you sell your products in. For example, if you're adding seeds as a product, you can sell it in packets, boxes or pallets. Each of these becomes a unit of the product. If seeds are mostly sold in packets, select that as the unit. 

     [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create a unit group and add units to that group](../sales-enterprise/create-unit-group-add-units-that-group.md)  

   - **Default Price List**. If this is a new product, this field is read-only. Before you can select a default price list, you must complete all the required fields, and then save the record. Although the default price list is not required, after you save the product record, it is a good idea to set a default price list for each product. Then, if a customer record does not contain a price list, [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] can use the default price list for generating quotes, orders, and invoices.

   - **Decimals Supported**. Enter a whole number between 0 and 5. If the product can't be divided into fractional quantities, enter 0. The precision of the Quantity field in the quote, order, or invoice product record is validated against the value in this field if the product does not have an associated price list.

   - **Subject**. Associate this product with a subject. You can use subjects to categorize your products and to filter reports. 
  
5. Select **Save**.  
  
6. On the **Bundle Products** tab, select **Add New Product Association**.  
  
    The **Product Association** page opens.  
  
7. Select products that you want to add to the bundle.  
  
    - **Bundle**. The bundle you're adding the products to is selected by default.  
  
    - **Product**. Select the **Lookup** button and select a product you want to add to the bundle. You can't add a family or a product bundle to a product bundle.
  
    - **Quantity**. Specify the quantity of product you want to add to the bundle.  
  
    - **Required**. Specify whether this product is required or optional. If you select a product as optional, you can sell the bundle without the product.  
  
    - **Unit**. Select the unit in which you want to sell the product.  
  
8. Select **Save & Close**.  
  
9. To change properties of an individual product in the bundle, select **Edit Properties** corresponding to the product, and change the values as required.  
  
10. If you've added this bundle to a family, the bundle will inherit the properties from its parent family. To change the bundle's property, open the property and select **Override**. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use properties to describe a product](../sales-enterprise/use-properties-describe-product.md)  
  
11. To add product relationships, select the **Related** tab, and then select **Relationships**. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Define related products to increase chances of sales](../sales-enterprise/define-related-products-increase-chances-sales.md)  


> [!NOTE]
> 
> Price lists and price list items are not supported in the apps built on Unified Interface framework. You can't create or add price list items in the Sales Hub app. To do this, use the Sales app instead. 

## Pricing of bundles  (Sales Hub app)
 Typically, the pricing of products in bundles is different than the individual products. You can set a total and potentially discounted price for the bundle or if the bundle has optional products, add those products to the price list as price list items. Then the total for a bundle in an opportunity is calculated by adding up the prices for each price list item, including optional bundle products that your customer selects. If you don't add an optional product in the price list, its price will be considered as zero.  
  
> [!TIP]
> 
> To create a new product bundle based on an existing one, on the command bar, select **Clone**. This opens a new product bundle record with the same information as the original product bundle record, except for the name and ID.  

   
## Create a product bundle  (Sales app)
  
1. [!INCLUDE[proc_permissions_mgr_vp_ceo_busmgr_sysadmin_syscust](../includes/proc-permissions-mgr-vp-ceo-busmgr-sysadmin-syscust.md)]  
  
    #### Check your security role  
  
   - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
   - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. [!INCLUDE[proc_settings_prod_catalog](../includes/proc-settings-prod-catalog.md)]  
  
3. Select **Families & Products**.  
  
4. To add a standalone product bundle, select **Add Bundle**.  
  
    -OR-  
  
    To add product to an existing family, select the family in the list, and then select **Add Bundle**.  
  
5. Enter information, noting any restrictions or requirements as needed.  
  
6. Select **Save**.  
  
7. In the **Bundle Products** section, select ![Add a record button](../sales-enterprise/media/add-recordbutton.gif "Add a record button"), and select products that you want to add to the bundle.  
  
    The **Product Association** page opens.  
  
8. [!INCLUDE[proc_handy_infotips](../includes/proc-handy-infotips.md)]  
  
   - **Bundle**. The bundle you're adding the products to is selected by default.  
  
   - **Product**. Select the **Lookup** button and select a product you want to add to the bundle.  
  
   - **Quantity**. Specify the quantity of product you want to add to the bundle.  
  
   - **Required**. Specify whether this product is required or optional. If you select a product as optional, you can sell the bundle without the product.  
  
   - **Unit**. Select the unit in which you want to sell the product.  
  
     > [!NOTE]
     >  The **Valid From** and **Valid To** fields define the duration for which a product is valid. There's no business logic associated with these fields except that the **Valid To** date must be later than the **Valid From** date. If required, you can implement your own business logic in these fields with a workflow, plug-in or [!INCLUDE[pn_sdk](../includes/pn-sdk.md)]. For example, run a scheduled job to automatically retire last season's products using the date selected in the **Valid To** field.  
  
9. Select **Save and Close**.  
  
10. To change properties of an individual product in the bundle, select **Customize** corresponding to the product, and change the values as required.  
  
11. If you've added this bundle to a family, the bundle will inherit the properties from its parent family. To change the bundle's property, open the property and select **Override**. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use properties to describe a product](../sales-enterprise/use-properties-describe-product.md)  
  
12. In the **Additional Details** section, select ![Add a record button](../sales-enterprise/media/add-recordbutton.gif "Add a record button"), and add a price list item. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create price lists and price list items to define pricing of products](../sales-enterprise/create-price-lists-price-list-items-define-pricing-products.md)  
  
13. In the **Product Relationships** section, select ![Add a record button](../sales-enterprise/media/add-recordbutton.gif "Add a record button"), and select a related product. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Define related products to increase chances of sales](../sales-enterprise/define-related-products-increase-chances-sales.md)  
  
## Pricing of bundles (Sales app)
 Typically, the pricing of products in bundles is different than the individual products. You can set a total and potentially discounted price for the bundle or if the bundle has optional products, add those products to the price list as price list items. Then the total for a bundle in an opportunity is calculated by adding up the prices for each price list item, including optional bundle products that your customer selects. If you don't add an optional product in the price list, its price will be considered as zero.  
  
> [!TIP]
>  -   After you're done adding all the details, select **Preview** on the command bar to look through the properties of the product bundle.  
>  -   To create a new product bundle based on an existing one, on the command bar, select **Clone**. This opens a new product bundle record with the same information as the original product bundle record, except for the name and ID.  
  
## Typical next steps  
 ![Right arrow button](../sales-enterprise/media/walkthrough-orange-right-arrow.png "Right arrow button") [Create price lists and price list items to define pricing of products](../sales-enterprise/create-price-lists-price-list-items-define-pricing-products.md)  
  
 ![Home button](../sales-enterprise/media/walkthrough-home.png "Home button") [Classify products and bundles into product families](../sales-enterprise/create-product-bundles-sell-multiple-items-together.md)  
  
### See also  
 [Set up a product catalog: Walkthrough](../sales-enterprise/set-up-product-catalog-walkthrough.md)   
 [System Settings dialog box - Sales tab](../admin/system-settings-dialog-box-sales-tab.md)

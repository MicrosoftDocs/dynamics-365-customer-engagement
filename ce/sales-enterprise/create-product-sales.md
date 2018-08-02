---
title: "Create a product (Dynamics 365 for Sales) | MicrosoftDocs"
description: "Use products in Dynamics 365 for Sales to define the products or services that your organization offers."
keywords: "product, service"
ms.date: 04/01/2018
ms.service: dynamics-365-sales
ms.custom:
  - dyn365-sales
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 8847977e-3768-4859-bce4-821c259aa79a
author: shubhadaj
ms.author: shujoshi
manager: sakudes
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 22
topic-status: Drafting
---

# Set up products (Sales and Sales Hub)

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Products are the backbone of your business. They can be physical products or services—whatever your organization sells. Your sales reps use the products you create in [!INCLUDE[pn-sales-enterprise-doc-name-shortest](../includes/pn-sales-enterprise-doc-name-shortest.md)] to generate sales quotes, marketing campaigns, orders, and invoices. Your customer service reps might also use them when they create customer service cases.  

## Create a product (Sales Hub app)

1. [!INCLUDE[proc_permissions_admin_cust_mgr_vp_sales_ceo](../includes/proc-permissions-admin-cust-mgr-vp-sales-ceo.md)]

2. Select the site map ![Site Map icon](media/site-map-icon.png "site map icon"), and then select **Products**.  
  
3.  To create a child product to an existing product family, select the family in the list, and then on the command bar, select **Add Product**. The selected family becomes the parent family of the new product you're creating. You can't change the parent of a product after the product is created. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create a product family](../sales-enterprise/create-product-family.md)  
  
    -OR-  
  
    If you want to create an independent product, simply select **Add Product**. 

    ![List of products](media/products-grid.png "Products grid") 
  
4.  Fill in your information:  
  
    - **Name**. 

    - **Product ID**.

    - **Parent**. Select a parent product family for the product. If you're creating a child product in a product family, the name of the parent product family is populated here. This can't be changed after the record is saved.

    - **Valid From**/**Valid To**. Define the period the product is valid for by selecting a **Valid From** and **Valid To** date.
    
    - **Unit Group**. Select a unit group. A unit group is a collection of various units a product is sold in and defines how individual items are grouped into larger quantities. For example, if you're adding seeds as a product, you may have created a unit group called "Seeds," and defined its primary unit as "packet."  
  
    - **Default Unit**. Select the most common unit in which the product will be sold. Units are the quantities or measurements that you sell your products in. For example, if you're adding seeds as a product, you can sell it in packets, boxes or pallets. Each of these becomes a unit of the product. If seeds are mostly sold in packets, select that as the unit. 

      [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create a unit group and add units to that group](../sales-enterprise/create-unit-group-add-units-that-group.md)  

    - **Default Price List**. If this is a new product, this field is read-only. Before you can select a default price list, you must complete all the required fields, and then save the record. Although the default price list is not required, after you save the product record, it is a good idea to set a default price list for each product. Then, if a customer record does not contain a price list, [!INCLUDE[pn-sales-enterprise-doc-name-shortest](../includes/pn-sales-enterprise-doc-name-shortest.md)] can use the default price list for generating quotes, orders, and invoices.

    - **Decimals Supported**. Enter a whole number between 0 and 5. If the product can't be divided into fractional quantities, enter 0. The precision of the Quantity field in the quote, order, or invoice product record is validated against the value in this field if the product does not have an associated price list.

    - **Subject**. Associate this product with a subject. You can use subjects to categorize your products and to filter reports.
  
5.  Select **Save**.  
  
6. If you're creating this product under a family, the product will inherit the properties from its parent family. To change a product's property, in the Product Properties section, open the property by selecting the name, and selecting **Override**. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use properties to describe a product](../sales-enterprise/use-properties-describe-product.md)  
  
    > [!NOTE]
    >  You can't add properties to an independent product.  
  
7. To add product relationships, select the **Related** tab, and then select **Relationships**. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Define related products to increase chances of sales](../sales-enterprise/define-related-products-increase-chances-sales.md)  

8. To see all the products that are associated with this product in a bundle, select the **Related** tab and select **Product Bundles**.  
  
9. Select **Save**.  
  
> [!NOTE]

> Previewing the properties of product is currently not supported in the Sales Hub app.


## Create a product (Sales app)

1. [!INCLUDE[proc_permissions_admin_cust_mgr_vp_sales_ceo](../includes/proc-permissions-admin-cust-mgr-vp-sales-ceo.md)]  
  
    #### Check your security role  
  
    - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
    - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. [!INCLUDE[proc_settings_prod_catalog](../includes/proc-settings-prod-catalog.md)]  
  
3.  In the **Product Catalog** area, select **Families & Products**.  
  
4.  If you want to create a child product to an existing product family, select the family in the list, and then select **Add Product**. The selected family becomes the parent family of the new product you're creating. You can't change the parent of a product after the product is created. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create a product family](../sales-enterprise/create-product-family.md)  
  
     -OR-  
  
     If you want to create an independent product, simply select **Add Product**.  
  
5.  Fill in your information:  
  
    - **Unit Group**. Select a unit group. A unit group is a collection of various units a product is sold in and defines how individual items are grouped into larger quantities. For example, if you're adding seeds as a product, you may have created a unit group called "Seeds," and defined its primary unit as "packet."  
  
    - **Unit**. Select the most common unit in which the product will be sold. Units are the quantities or measurements that you sell your products in. For example, if you're adding seeds as a product, you can sell it in packets, boxes or pallets. Each of these becomes a unit of the product. If seeds are mostly sold in packets, select that as the unit.  
  
    [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create a unit group and add units to that group](../sales-enterprise/create-unit-group-add-units-that-group.md)  
  
    > [!NOTE]
    >  The **Valid From** and **Valid To** fields define how long a product is valid for. There's no business logic associated with these fields except that the **Valid To** date must be later than the **Valid From** date. If required, you can implement your own business logic in these fields with a workflow, plug-in, or by using the [!INCLUDE[pn_sdk](../includes/pn-sdk.md)]. For example, run a scheduled job to automatically retire last season's products using the date selected in the **Valid To** field.  
  
6.  Select **Save**.  
  
7.  In the **Price List Items** section, select the **Add a Record** button ![Add a record button](../sales-enterprise/media/add-recordbutton.gif "Add a record button"), and create a price list item for each unit the product is available in. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create price lists and price list items to define pricing of products](../sales-enterprise/create-price-lists-price-list-items-define-pricing-products.md)  
  
8.  In the **Default price list** box, select a default price list. [!INCLUDE[pn_microsoftcrm](../includes/pn-dynamics-crm.md)] uses this price list for calculations when the associated price list in the opportunity or order for the product does not contain a price definition of the product.  
  
    > [!NOTE]
    >  A price list will be available for selection only when the product you're creating is added to it as a price list item (as described in **Step 7**).  
  
9. If you're creating this product under a family, the product will inherit the properties from its parent family. To change a product's property, in the Product Properties section, open the property by selecting the name, and selecting **Override**. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use properties to describe a product](../sales-enterprise/use-properties-describe-product.md)  
  
    > [!NOTE]
    >  You can't add properties to an independent product.  
  
10. In the **Product Relationships** section, select the **Add a Record** button ![Add properties button](../sales-enterprise/media/add-properties-button.png "Add properties button"), and select a related product. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Define related products to increase chances of sales](../sales-enterprise/define-related-products-increase-chances-sales.md)  
  
11. Select the **Save** button in the bottom-right corner.  
  
12. After you're done adding all the details, make sure to review everything and ensure it's correct. On the command bar, select **Preview**. The **Properties Preview** dialog box lets you verify how the product properties will appear to sales agents when they're selling the product or bundle.  
  
     After you're done verifying, select **Done**.  
  
## Typical next steps  
 ![Right arrow button](../sales-enterprise/media/walkthrough-orange-right-arrow.png "Right arrow button") [Create price lists and price list items to define pricing of products](../sales-enterprise/create-price-lists-price-list-items-define-pricing-products.md)  
  
 ![Home button](../sales-enterprise/media/walkthrough-home.png "Home button") [Classify products and bundles into product families](../sales-enterprise/create-product-bundles-sell-multiple-items-together.md)  
  
### See also  
 [Set up a product catalog: Walkthrough](../sales-enterprise/set-up-product-catalog-walkthrough.md)  
 [Manage sales literature](create-sales-literature.md)

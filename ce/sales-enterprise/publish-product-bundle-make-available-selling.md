---
title: "Publish a product or bundle to make it available for selling (Dynamics 365 for Sales) | MicrosoftDocs"
description: "Publish a product or bundle in Dynamics 365 for Sales to make it available to the sales agents so they can build orders or create opportunities for customers."
keywords: "Publish, product, make available"
ms.date: 04/01/2018
ms.service: dynamics-365-sales
ms.custom:
  - dyn365-sales
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: "shubhadaj"
ms.assetid: 9d60813a-0bc8-4dd2-be3f-084812c6ba5c
author: shubhadaj
ms.author: shujoshi
manager: sakudes
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 19
topic-status: Drafting
---

# Publish a product, family, or bundle to make it available for selling (Sales)

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

When you're ready to sell a product or bundle, publish it to make it available to the sales agents so they can build orders or create opportunities for customers. By default, product records are created in a draft state, and are available to your sales agents only after you publish it. For products that don't have a parent product family, you can create them directly in an active state using a system setting, so that you don't have to publish them after creation. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [System Settings dialog box - Sales tab](../admin/system-settings-dialog-box-sales-tab.md)  

> [!NOTE]
>  You can only publish a product or bundle with a parent family if the parent product family is active.  
     
## Publish a product, family, or bundle (Sales Hub app)

1. [!INCLUDE[proc_permissions_admin_cust_mgr_vp_sales_ceo](../includes/proc-permissions-admin-cust-mgr-vp-sales-ceo.md)]  
  
2. Select the site map ![Site Map icon](media/site-map-icon.png "site map icon"), and then select **Products**. 

3. Open the product, bundle, or family you want to publish, and on the command bar, select **Publish**. 

   ![Product form with the Publish button](media/publish-product.png "Product form with the Publish button")

   This will change the product status to **Active** and make it available for selling.

> [!TIP]

> You can't publish multiple product records at the same time. To publish all child products and families of a parent family at once, open the family, and choose **Publish** > **Publish Hierarchy**. For product records that don't belong to a product family, publish them individually after creating or editing them to make them available to your sales agents.

## Publish a product or bundle (Sales app)

1. [!INCLUDE[proc_permissions_admin_cust_mgr_vp_sales_ceo](../includes/proc-permissions-admin-cust-mgr-vp-sales-ceo.md)]  
  
    #### Check your security role  
  
    - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
    - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. [!INCLUDE[proc_settings_prod_catalog](../includes/proc-settings-prod-catalog.md)]  
  
3.  In the Product Catalog area, select **Families & Products**.  
  
4.  Open the product, bundle, or family you want to publish, and on the command bar, select **Publish**.  
  
     This will change the product status to **Active** and make it available for selling.  
  
> [!TIP]
>  You can't publish multiple product records at the same time. To publish all child products and families of a parent family at once, open the family, and choose **Publish** > **Publish Hierarchy**. For product records that don't belong to a product family, publish them individually after creating or editing them to make them available to your sales agents.  
  
 
## Typical next steps  
 ![Right arrow button](../sales-enterprise/media/walkthrough-orange-right-arrow.png "Right arrow button") [Revise a product](revise-product.md)  
  
 ![Right arrow button](../sales-enterprise/media/walkthrough-orange-right-arrow.png "Right arrow button") [Retire a product](retire-product.md)  
  
 ![Home button](../sales-enterprise/media/walkthrough-home.png "Home button") [Set up a product catalog: Walkthrough](../sales-enterprise/set-up-product-catalog-walkthrough.md) 
  
### See also  
 [Set up a product catalog: Walkthrough](../sales-enterprise/set-up-product-catalog-walkthrough.md)

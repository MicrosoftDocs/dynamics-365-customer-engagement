---
title: "Set up a discount list (Dynamics 365 for Sales) | MicrosoftDocs"
description: "Set up discounts on products in Dynamics 365 for Sales to offer products to your customers on marked down rates."
keywords: "Discount, Discounted, Discount list"
ms.date: 04/01/2018
ms.service: dynamics-365-sales
ms.custom:
  - dyn365-sales
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: "shubhadaj"
ms.assetid: afdf269e-613e-4949-ab6a-d1e9c02d8370
author: shubhadaj
ms.author: shujoshi
manager: sakudes
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 33
topic-status: Drafting
---

# Set up a discount list (Sales and Sales Hub)

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Motivate customers to buy more by offering them discounts on bulk purchases. To offer discounts, you need to set up a discount list.  

## Set up a discount list (Sales Hub app)

Currently, creating a discount list isn't supported in the Sales Hub app. To create or edit a discount list, use the Sales app.

## Set up a discount list (Sales app)
  
1. [!INCLUDE[proc_permissions_mgr_vp_ceo_busmgr_sysadmin_syscust](../includes/proc-permissions-mgr-vp-ceo-busmgr-sysadmin-syscust.md)]  
  
    #### Check your security role  
  
    - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
    - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. [!INCLUDE[proc_settings_prod_catalog](../includes/proc-settings-prod-catalog.md)]  
  
3.  Select **Discount Lists**.  
  
4.  To create a new discount list, select **New**.  
  
     -OR-  
  
     To edit a discount list, open it.  
  
5.  Fill in the information:  
  
    - **Name**. Type a name that provides a good description of the kind of discount this list will include.  
  
    - **Type**. To calculate the discount as a percentage of the price of the item, select **Percentage** or to give discount as a fixed amount, select **Amount**.  
  
    - **Currency**. If you chose to give discount as a fixed amount, select the currency.  
  
 ![Create a discount list in Dynamics 365](../sales-enterprise/media/v7-discount-lit.png "Create a discount list in Dynamics 365")  
  
6.  Select **OK**.  
  
7.  To set volume discounts, in the left pane, under **Common**, select **Discounts**, and then on the **Discounts** tab, in the **Records** group, select **Add New Discount**.  
  
8.  Fill in the information:  
  
     Here's how:  
  
 ![Create volume discounts in Dynamics 365](../sales-enterprise/media/v7-discounts.png "Create volume discounts in Dynamics 365")  
  
     This discount list will offer a discount of 5% whenever the customer purchases between 3 – 5 boxes.  
  
9. Select **Save** or **Save and Close**.  
  
## Typical next steps  
 ![Right arrow button](../sales-enterprise/media/walkthrough-orange-right-arrow.png "Right arrow button") [Create a unit group and add units to that group](create-unit-group-add-units-that-group.md)  
  
 ![Home button](../sales-enterprise/media/walkthrough-home.png "Home button") [Set up a product catalog: Walkthrough](set-up-product-catalog-walkthrough.md)  
  
### See also  
 [System Settings dialog box - Sales tab](../admin/system-settings-dialog-box-sales-tab.md)

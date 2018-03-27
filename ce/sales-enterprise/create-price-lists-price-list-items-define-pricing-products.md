---
title: "Create price lists and price list items to define pricing of products (Dynamics 365 for Sales) | MicrosoftDocs"
description: "Define what to charge for your products or services in Dynamics 365 for Sales."
keywords: "Price list, price list items"
ms.date: 04/01/2018
ms.service: crm-online
ms.custom: 
ms.topic: get-started-article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: dd53d178-2cd2-4aeb-beb5-be538585d297
author: shubhadaj
ms.author: shujoshi
manager: brycho
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 44
topic-status: Drafting
---

# Create price lists and price list items to define pricing of products (Sales and Sales Hub)

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Price lists tell your sales agents what to charge for your products or services. You can create multiple price lists so that you can maintain separate price structures for different regions you sell your products in or for different sales channels.  
  
Price lists tie the unit, product, and pricing details together, so before you create a price list, make sure the units and products are in place.  
 

## Create a price list and add price list items (Sales Hub app)

In [!INCLUDE[pn-crm-9-0-2-online](../includes/pn-crm-9-0-2-online.md)], creating a price list and adding price list items isn't supported in the Sales Hub app. To create or edit a price list and price list item, use the Sales app.

## Step 1: Create a price list  (Sales app)
  
1. [!INCLUDE[proc_permissions_mgr_vp_ceo_busmgr_sysadmin_syscust](../includes/proc-permissions-mgr-vp-ceo-busmgr-sysadmin-syscust.md)]  
  
    #### Check your security role  
  
    - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
    - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. [!INCLUDE[proc_settings_prod_catalog](../includes/proc-settings-prod-catalog.md)]  
  
3.  In the **Product Catalog** area, select **Price Lists**.  
  
4.  To create a new price list, select **New**.  
  
     -OR-  
  
     To edit a price list, open a price list from the list.  
  
5. [!INCLUDE[proc_handy_infotips](../includes/proc-handy-infotips.md)]  
  
6.  Select **Save**.  
  
> [!NOTE]
>  You must create at least one price list for each of the currencies that your organization does business in.  
  
## Step 2: Add items to the price list (Sales app)

Create a price list item for each unit in which the product is available. For example, if the product is available as a single item (each), in a dozen, and in a gross, create three list items. This lets you order the product in any quantity you want, using the same price list. You can add price list items from the product form also.  
  
1.  In the price list record, in the **Price List Items** section, select the **Add Record** button ![Add a record button](../sales-enterprise/media/add-recordbutton.gif "Add a record button").  
  
2. [!INCLUDE[proc_handy_infotips](../includes/proc-handy-infotips.md)]  
  
    -   In the Product and Unit box, select the product and unit for which you're creating this price list item.  
  
    -   To offer a discount on the combination of the product and unit, select a discount list.  
  
    -   In the **Quantity Selling Option** drop-down box, select whether the product or service can be ordered in whole, partial, or both types of quantities. This information is used in the **Quantity** field of **Quote Product**, **Order Product**, and **Invoice Product** records:  
  
        - **No Control**. [!INCLUDE[pn_microsoftcrm](../includes/pn-dynamics-crm.md)] doesn't enforce a quantity selling option.  
  
        - **Whole**. Selling a partial product isn't allowed. For example, digital cameras cannot be sold in fractions.  
  
        - **Whole and Fractional**. The product can be sold both in whole and fractional units. For example, wood chips can be sold in cubic yards, or in fractions of a cubic yard.  
  
    -   In the **Pricing Method** drop-down box, select an option that determines how the pricing will be calculated. It could be a certain amount, or a percentage of the current or standard cost.  
  
    -   If you selected **Currency Amount** as the pricing method, in the **Amount** box, type the amount at which the product will be sold.  
  
         -OR-  
  
         If you selected any value other than **Currency Amount** as the pricing method, type the percentage for the pricing method that you want.  
  
    -   If you selected a pricing method other than **Currency Amount**, you can set up a rounding policy. For example, if you want per unit prices to be in the form of $0.99, you can select a rounding policy where all prices per unit automatically have a price that ends in 99 cents. To do this, you select the rounding policy to round the price up, and then set the price to end in a certain amount, such as 99 cents.  
  
        - **None**. Prices are not rounded.  
  
        - **Up**. Prices are rounded up to the nearest rounding amount.  
  
        - **Down**. Prices are rounded down to the nearest rounding amount.  
  
        - **To Nearest**. Prices are rounded to the nearest rounding amount.  
  
    -   In the **Rounding Option** drop-down box, select **Ends in** or **Multiple of** if you want the price to end in a certain amount or multiples of a certain amount.  
  
    -   In the **Rounding Amount** box, enter the amount.  
  
3.  Select **Save**.  
  
## Step 3: Define default price list for territories  (Sales app)

Make sales agents' job easier by adding default pricelists for territories or customer segments the agents are managing. When sales agents are working on opportunities, they see the default price list. Sales agents can later select other price list that they've permission on. You can have one price list as the default for multiple territories.  
   
1.  In the price list record, in the **Territory Relationships** section, select the **Add Record** button ![Add a record button](../sales-enterprise/media/add-recordbutton.gif "Add a record button").  
  
2.  In the **Connection** form, in **Name**, select the **Lookup** button, and select a territory.  
  
3.  Select **Save & Close**.  
  
4.  In the price list form, select the **Auto Save** button ![Auto save button](../sales-enterprise/media/auto-save-button.png "Auto save button").  
  
     When the sales agents set or change the customer for an opportunity, if a default price list is added to their territory (customer segment), it is shown.  
  
## Typical next steps  
 ![Right arrow button](../sales-enterprise/media/walkthrough-orange-right-arrow.png "Right arrow button") [Publish a product or bundle to make it available for selling](publish-product-bundle-make-available-selling.md)  
  
 ![Home button](../sales-enterprise/media/walkthrough-home.png "Home button") [Set up a product catalog: Walkthrough](../sales-enterprise/set-up-product-catalog-walkthrough.md)  
  
### See also  
 [System Settings dialog box - Sales tab](../admin/system-settings-dialog-box-sales-tab.md)   
 [Classify products and bundles into product families](../sales-enterprise/create-product-bundles-sell-multiple-items-together.md)

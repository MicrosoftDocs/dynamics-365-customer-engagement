---
title: "Set up discount lists (Dynamics 365 Sales) | MicrosoftDocs"
description: "Set up discounts on products in Dynamics 365 Sales to offer products to your customers on marked down rates."
ms.date: 10/26/2021
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
ms.custom: 
  - "dyn365-sales"
searchScope: 
  - D365-App-msdynce_saleshub
  - D365-Entity-discount
  - D365-Entity-discounttype
  - D365-UI-*
  - Dynamics 365
  - Sales
  - Customer Engagement
---
# Set up discount lists (Sales Hub) 

Set up discounts on products in Dynamics 365 Sales to offer products to your customers on marked down rates.

## License and role requirements
| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise  <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br> More information: [Predefined security roles for Sales](security-roles-for-sales.md)|


## Create a discount list

Motivate customers to buy more by offering them discounts on bulk purchases. To offer discounts, you need to set up a discount list.  

1. [!INCLUDE[proc_permissions_mgr_vp_ceo_busmgr_sysadmin_syscust](../includes/proc-permissions-mgr-vp-ceo-busmgr-sysadmin-syscust.md)]  
  
2. In the Sales Hub app, select the **Change area** icon
    ![Icon to change the work area.](media/change-area-icon.png "Icon to change the work area") in the lower-left corner and then select **App Settings**.

2. Under **Product Catalog**, select **Discount Lists**. 

    > [!div class="mx-imgBorder"]
    > ![Unit groups in site map.](media/site-map-unit-group.png "Unit groups in site map")


4.	To create a new discount list, on the command bar, select **New**.

    -OR-
  
    To edit a discount list, open a discount list from the list.

5.	Fill in the information, and select **Save**:

    a.	**Name**. Type a name that provides a good description of the kind of discount this list will include.

    b.	**Type**. To calculate the discount as a percentage of the price of the item, select Percentage or to give discount as a fixed amount, select Amount.

    c.	**Currency**. If you chose to give discount as a fixed amount, select the currency.

    > [!div class="mx-imgBorder"]
    > ![Discount list form.](media/discount-list-form.png "Discount list form")
 
6.	To add discount details to the list, select the **Related** tab, and then select **Discounts**.

    > [!div class="mx-imgBorder"]
    > ![Discount tab on the Discount List form.](media/discount-list-form-related-tab-discounts-option.png "Discount tab on the Discount List form")
 
7.	On the **Discounts** tab, select **New Discount**.

8.	In the **New Discount** form, fill in the following information, and select **Save & Close**:

    a.	**Begin quantity**. Enter the minimum quantity a customer should purchase to be eligible for the discount.  

    b.	**End quantity**. Enter the maximum quantity for which the discount is applicable.  

    c.	**Percentage** or **Amount**. Enter the percentage or the amount of discount the customer will receive.

    For example, this discount list will offer a discount of $5 whenever the customer purchases between 2 – 5 pieces of televisions.

    > [!div class="mx-imgBorder"]
    > ![Discount form.](media/discount-form.png "Discount form")
 

## Typical next steps  
 ![Right arrow button](media/walkthrough-orange-right-arrow.png "Right arrow button") [Create a unit group and add units to that group](create-unit-group-add-units-that-group.md)  
  
 ![Home button](media/walkthrough-home.png "Home button") [Set up a product catalog: Walkthrough](set-up-product-catalog-walkthrough.md)  
 
[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]
 
### See also  
 [System Settings dialog box - Sales tab](/power-platform/admin/system-settings-dialog-box-sales-tab)


[!INCLUDE[footer-include](../includes/footer-banner.md)]

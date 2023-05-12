---
title: "Make price list optional | MicrosoftDocs"
description: "Allow your salespeople to add products without associating a price list first."
ms.date: 02/28/2023
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
ms.custom: 
  - "dyn365-sales"
searchScope: 
  - D365-App-msdynce_saleshub
  - D365-App-msdynce_salespro
  - D365-Entity-pricelevel
  - D365-UI-*
  - Customer Engagement
  - Dynamics 365
  - Sales
---
# Allow adding products without associated price list 

When adding products to opportunities, quotes, orders, or invoices, at times, salespeople need to specify the product prices ad hoc. You can allow salespeople to add products without associating a price list first.

## License and role requirements

| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or Dynamics 365 Sales Professional <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br> More information: [Predefined security roles for Sales](security-roles-for-sales.md)|



## Make price list optional

Depending on the Dynamics 365 Sales license you have, select one of the following tabs for specific information: 

# [Sales Premium and Sales Enterprise](#tab/SE)

If you have the Sales Hub app, follow the instructions in this tab. Otherwise, follow the instructions in the **Sales Professional** tab to configure the option in Power Platform.

1.	In the lower-left corner of the screen, select **Change area** ![Icon to change the work area.](media/change-area-icon.png "Icon to change the work area"), and select **App Settings**.

2.	Under **Product Catalog**, select **Product Catalog Settings**.

3.  Turn on **Make price lists optional** and save the changes.

    ![Option to make selection of price list optional in Product Catalog Settings.](media/sales-hub-make-price-list-optional.png "Option to make selection of price list optional in Product Catalog Settings")


# [Sales Professional](#tab/SP)

1.  In your app, on the nav bar, select the **Settings** icon, and then select **Advanced Settings**.

    The Business Management settings page opens in a new browser tab.

2.  On the nav bar, select **Settings**, and then select **Administration**.

3.  Select **System Settings**.

4.  In the **System Settings dialog** box, on the **Sales** tab, set the **Make
    price lists optional** field to **Yes**.

    ![Option to make selection of price list optional in System Settings.](media/make-price-list-optional.png "Option to make selection of price list optional in System Settings")

---

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also
[Add products to an opportunity](add-products-opportunity.md)  
[Add products to a quote, order, or invoice](add-product-quote-order-invoice.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]

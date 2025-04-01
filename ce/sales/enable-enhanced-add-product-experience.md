---
title: Enable or disable the enhanced add products experience
description: "Enable your salespeople to quickly find and add multiple products to an opportunity, quote, order, or invoice by enabling the enhanced add product experience."
ms.date: 11/21/2024
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
searchScope: 
  - D365-App-msdynce_saleshub
  - D365-App-msdynce_salespro
  - D365-Entity-opportunityproduct
  - D365-Entity-salesorderdetail
  - D365-Entity-quotedetail
  - D365-UI-*
  - Customer Engagement
  - Dynamics 365
  - Sales
---
# Enable or disable the enhanced experience for adding products

Enable your salespeople to quickly find and add multiple products to an opportunity, quote, order, or invoice by enabling the enhanced add product experience.

## What's in the enhanced experience?

 By using the enhanced experience, salespeople can do the following:

- Quickly search for products and add them to opportunity, quote, order, or invoice.  
- Filter by product families if you have the Sales Enterprise or Sales Premium license.
- View product details inline.
- Compare products before selecting them.
- Add multiple products in one go.

[!INCLUDE [add-products-experience-on-mobile](../includes/add-products-experience-on-mobile.md)]



## Enable or disable the enhanced experience

Depending on the Dynamics 365 Sales license you have, select one of the following tabs for specific information: 

# [Sales Premium and Sales Enterprise](#tab/SE)

If you have the Sales Hub app, follow the instructions in this tab. Otherwise, follow the instructions in the **Sales Professional** tab to configure the option in Power Platform.

1. In lower-left corner of the screen, select **Change area** ![Icon to change the work area.](media/change-area-icon.png "Icon to change the work area"), and then select **App Settings**.

2. Under **Product Catalog**, select **Product Catalog Settings**.

3. On the **Product catalog settings** page, turn on **Enhanced experience for adding products** to enable the enhanced experience. 
    When you enable the enhanced experience, you'll see additional options for customizing the **Add products** dialog box.

    ![Product catalog settings page with the **Enhanced experience for adding products** enabled.](media/EnableAddProductPreview.png)

     You can either add more columns to the grid or add more attributes to the **Product** column in the dialog box. For more information, see [Customize the Add Products dialog box](customize-add-products-dialog-box.md).
    
    If you turn off the enhanced experience, the **Add products** option in the opportunity, quote, order, and invoice will switch back to **Quick create** form.

# [Sales Professional](#tab/SP)

If you're using a custom app or Sales Professional app, you can enable or disable the enhanced experience from **System Settings** in Power Platform.

1. In your app, select **Settings** ![Settings.](media/settings-icon.png "Settings"), and then select **Advanced Settings**.

   ![Advanced Settings link in the site map.](media/advanced-settings-option.png)

   The **Business Management settings** page opens in a new browser tab.
   > [!NOTE]
   > The **Advanced Settings** page is moving from the web client to an Unified Interface app. If your organization has enabled the public preview of the **Advanced settings redirection** feature, you’ll see the settings open in the Power Platform Environment Settings app. Find more information about the app and navigation path in [Advanced settings in the new experience](advanced-settings-new-experience.md).

2. On the navigation bar, select **Settings**, and then select **Administration**.

3. Select **System Settings**.

4. In the **System Settings** dialog box, go to the **Sales** tab and set **Adding products** to **Yes** to enable the enhanced experience. Set it to **No** to disable. 

5. Select **OK**.

---

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

## Related information

[Add products to an opportunity by using the enhanced experience](add-products-enhanced-experience.md)  
[Add products to a quote, order, or invoice by using the enhanced experience](add-products-qoi-enhanced.md)


---
title: "Enable the enhanced adding products experience | MicrosoftDocs"
description: "Enable your salespeople to quickly find and add multiple products to opportunities in Dynamics 365 Sales Enterprise by enabling the enhanced add product experience."
ms.date: 03/17/2021
ms.service: dynamics-365-sales
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---
# Preview: Enable the enhanced experience for adding products

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

The enhanced experience helps your salespeople to quickly find products that they need for an opportunity, quote, order, or invoice. By using the enhanced experience, salespeople can do the following:

- Quickly search for products and filter by product families.
- View product details inline.
- Compare products before selecting them.
- Add multiple products in one go.

> [!IMPORTANT]
>
> - The enhanced experience for adding products is a preview feature. [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
> - [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
> - [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]

You can enable the enhanced experience through the **App Settings** page or through **System Settings**.

**To enable the enhanced experience from the App settings page in Sales Hub**

1. In the Sales Hub app, select the **Change area** icon
    ![Icon to change the work area](media/change-area-icon.png "Icon to change the work area")
    in the lower-left corner and then select **App Settings**.

2. Under **Product Catalog**, select **Product Catalog Settings**.

3. On the **Product Catalog Settings** page, turn on **Adding products (preview)**.  
    ![Product catalog settings page with the Adding products preview enabled](media/EnableAddProductPreview.png)

   You'll see additional options for customizing the Add products dialog box. Sellers use this dialog box for adding products to an opportunity, quote, order,or invoice. You can either add more columns to the grid or add more attributes to the Product column in the dialog box. For more information, see [Preview: Customize the Add Products dialog box](customize-add-products-dialog-box.md).

**To enable the enhanced experience from System Settings**

If you're using a custom app, you can enable the enhanced experience from **System Settings** in the legacy web client.

1. In your app, select **Settings** ![Settings](media/settings-icon.png "Settings"), and then select **Advanced Settings**.

   ![Advanced Settings link in the site map](media/advanced-settings-option.png)

   The **Business Management settings** page opens in a new browser tab.

2. On the navigation bar, select **Settings**, and then select **Administration**.

3. Select **System Settings**.

4. In the **System Settings** dialog box on the **Sales** tab, set **Enhanced add product experience** to **Yes**.

5. Select **OK**.

### See also

[Add products to an opportunity by using the enhanced experience](add-products-enhanced-experience.md)  
[Add products to a quote, order, or invoice by using the enhanced experience](add-products-qoi-enhanced.md)

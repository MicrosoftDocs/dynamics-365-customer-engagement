---
title: "Preview: Customize the Add Products dialog box (Dynamics 365 Sales) | MicrosoftDocs"
description: "Customize the Add Products dialog box so that salespeople can see important product details while adding products to opportunity, quote, order, or invoice records in Dynamics 365 Sales."
ms.date: 03/17/2021
ms.service: dynamics-365-sales
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
searchScope:
  - D365-App-msdynce_saleshub
  - D365-Entity-opportunity
  - D365-UI-*
  - Customer Engagement
  - Dynamics 365
  - Sales
---

# Preview: Customize the Add products dialog box (Dynamics 365 Sales)

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

As a system administrator, you can customize the **Add products** dialog box by adding information that will help your salespeople to
identify and select products quickly. You can either add more columns to
the grid or add more details to the **Product** column. Attributes in the
**Product** column help sellers get more information *before* choosing a product. So, if you want to add a category or
product ID to help distinguish products from each other, add it to the
**Product** column. On the other hand, if sellers need to perform an action *after* selecting a product&mdash;for example, choosing delivery priority (a custom attribute)&mdash;add that attribute to the grid.<!--note from editor: Most edits suggested, but note that the style guide prefers italic for emphasis.-->

>[!IMPORTANT]
>- The enhanced experience for adding products is a preview feature. [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>- [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>- [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]

## Add or remove columns in the grid

By default, the **Add products** dialog box displays the following columns in the grid:

- Product name
- Unit
- Price per unit
- Quantity

>[!NOTE] 
>The procedures in this topic refer to the customization option available in **Product catalog** > **Settings**. If you're using a custom app, access the following views from Power Apps:
>
>- Opportunity products - Add products
>- Quote products - Add products
>- Order products - Add products
>- Invoice products - Add products

For information about editing views, go to [Choose and configure columns in model-driven app views](https://docs.microsoft.com/powerapps/maker/model-driven-apps/choose-and-configure-columns).

**To add or remove columns in the grid**

1. In the Sales Hub app, select **Change area** ![Icon to change the work area](media/change-area-icon.png "Icon to change the work area") in the lower-left corner, and then select **App Settings**.

2. Under **Product catalog**, select **Product catalog settings**.

3. Turn on **Adding products (preview)**, if you haven't already.
    You'll see additional options for customizing the **Add products** dialog box for opportunity, quote, invoice, and order.

4. Select the **Add products view** of the entity that you want to customize. For example, select the **Quote 'add products'** view to customize the **Add products** dialog box for quotes. You'll be redirected to the corresponding view in Power Apps.

5. Do one of the following:

   - To add a column, select **Add columns**, and then select the columns you want.
   - To remove a column, select the column in the view, and then on the **Common tasks** pane, select **Remove**.

## Add or edit product attributes in the Product column

By default, the **Product** column in the **Add product** dialog box includes the product name and ID. You can add more information to help you better distinguish the products. For example, you can add the product category to help differentiate products, as shown in the following image. Note that the **Product** column can display up to three attributes.

![Screenshot showing additional details in the Product column of the Add products dialog box](media/ProductColumn.png)

<!--note from editor: I believe the edit to line 45 means that this can be deleted:
> [!NOTE]
> The procedure below refers to the customization option available
> in product catalog settings. If you're using a custom app, access
> the **Product Lookup View** from Power Apps:

For information about editing views, see [Choose and configure columns in model-driven app views](https://docs.microsoft.com/powerapps/maker/model-driven-apps/choose-and-configure-columns).
-->
**To add or edit product attributes**

1. In the Sales Hub app, select ![Icon to change the work area](media/change-area-icon.png  "Icon to change the work area") in the lower-left corner, and then select **App Settings**.

2. Under **Product catalog**, select **Product catalog settings**.

3. Turn on **Adding products (preview)**, if you haven't already.
    You'll see additional options for customizing the **Add products** dialog box.

4. Select **Customize Product lookup view**.
    You'll be redirected to the **Product lookup view** in Power Apps.

5. Do one of the following:

   - To add attributes, select **Add columns**, and then select the attributes.
   - To remove an attribute, select the column in the view, and then on the **Common tasks** pane, select **Remove**.

6. To verify the changes, open an opportunity and then select **Add products**.
   You'll see the updated attributes in the **Product** column. 

The changes will be applied to the **Add products** dialog box for opportunity,
quote, order, and invoice records.

### See also

[Choose and configure columns in model-driven app views](/powerapps/maker/model-driven-apps/choose-and-configure-columns)  
[Add products to an opportunity](add-products-opportunity.md)  
[Add products to quotes, orders, or invoices](add-product-quote-order-invoice.md)

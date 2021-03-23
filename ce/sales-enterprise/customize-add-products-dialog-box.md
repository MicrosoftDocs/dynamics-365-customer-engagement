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
## Customize the Add Products dialog box

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

As a system administrator, you can customize the **Add products** dialog box by adding information that will help your salespeople to identify and select products quickly. You can either add more columns to
the grid or add more details to the **Product** column. Attributes in the **Product** column help sellers get more information *before* choosing a product. So, if you want to add a category or
product ID to help distinguish products from each other, add it to the **Product** column. On the other hand, if sellers need to perform an action *after* selecting a product&mdash;for example, choosing delivery priority (a custom attribute)&mdash;add that attribute to the grid.

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

 > [!NOTE]
 > The procedure below refers to the customization option available in the Sales Hub app. If you are using a custom app, access the following views from Power Apps:
> Opportunity products Add products
> Quote products Add products
> Order products Add products
> Invoice products Add products

For information about editing views, go to [Choose and configure
columns in model-driven app
views](https://docs.microsoft.com/powerapps/maker/model-driven-apps/choose-and-configure-columns).

**To add or remove columns in the grid**

1. In the Sales Hub app, select the **Change area** icon ![Icon to change the work area](media/change-area-icon.png "Icon to change the work area") in the lower-left corner of the page and then select **App Settings**.  

2. Under **Product Catalog**, select **Product Catalog Settings**.  

3. Turn on the **Adding Products (preview)** option, if you haven't already.  
    You'll see additional options to customize the Add products dialog box for
    opportunity, quote, invoice, and order.  

4. Select the add products view of the entity that you want to customize. For example, select **Quote 'add products'** view to customize the Add products dialog for quotes.  
    You will be redirected to the corresponding view in Power Apps.

5. Select **+ View Column** and then select the columns you want to add to the grid. Or, simply drag-and-drop the columns into the grid.

6. To remove a column, select the column in the grid and select **Remove**.

7. Select **Publish** to save and publish the customizations.
    The changes are applicable to the Add products dialog of the selected entity.

8. Open the entity that you've customized. If you customized the add products view for quotes, open a quote and then click **Add products**. Verify whether the customizations to the grid are reflected in the dialog box.
    

## Add or edit attributes in the Product column

By default, the **Product** column in the Add product dialog includes the product name and ID. You can customize this column to add other attributes to help you better distinguish the products. For example, you can add the product category to differentiate products as shown in the following image:

![Screenshot showing additional details in the Product column of the Add products dialog](media/ProductColumn.png)

**Note**: The **Product** column can display up to three attributes, apart from the product name.  

> [!NOTE]
> The procedure below refers to the customization option available in **Product catalog settings**. If you are using a custom app, access the **Product Lookup View** from Power Apps. For information on editing views in Power Apps, see [Choose and configure columns in model-driven app views](https://docs.microsoft.com/powerapps/maker/model-driven-apps/choose-and-configure-columns).

**To add or edit product attributes:**

1. In the Sales Hub app, select the **Change area** icon ![Icon to change the work area](media/change-area-icon.png  "Icon to change the work area") in the lower-left corner of the page and then select **App Settings**.

2. Under **Product Catalog**, select **Product Catalog Settings**.

3. Turn on **Adding products (preview)**, if you haven't already.
    You'll see additional options for customizing the Add products dialog box.

4. Select **Customize Product lookup view.**
    You'll be redirected to the **Product Lookup View** in Power Apps.

5. Click **+ View Column** and then select the attributes you want to add. Or, simply drag-and-drop the attributes into the grid.

6. To remove an attribute, select the attribute in the grid and select **Remove**.

7. Click **Publish** to save and publish the customizations.
    The changes are applicable to the Add products dialog of opportunity, quote, order, and invoice.

7. To verify the changes, open an opportunity and click **Add products**.  
   You will see the updated attributes in the **Product** column.

## Customize the fields to search  

By default, the search field in the Add products dialog searches the product name, ID, and description. You can expand the search to include other text-based fields too. For example, you can add the hierarchy path field to the search scope.

**To customize the fields to search:**

1. Open Power Apps and navigate to **Tables** in the left pane.

2. Search for the **Product** entity and open it.

3. Select the **Views** tab and open the **Quick Find All Products** view. 

4. In the right pane, go to the **Find by** section and click **Edit find table columns**. Select the fields you want to include in search.
    > [!NOTE] 
    > Select only the text-based fields.

5. Click **Publish** to save and publish changes to the view.
    The changes are applicable to the product search in the Add products dialog of opportunity, quote, order, and invoice.

6. To verify the changes, open an opportunity and select **Add products**.

7. Search for a keyword and verify whether the search is returning matches from the newly added fields.

### See also

[Choose and configure columns in model-driven app views](/powerapps/maker/model-driven-apps/choose-and-configure-columns)  
[Add products to an opportunity](add-products-opportunity.md)  
[Add products to quotes, orders, or invoices](add-product-quote-order-invoice.md)

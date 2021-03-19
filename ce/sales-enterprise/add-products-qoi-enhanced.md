---
title: "Preview: Add products to quotes, orders, or invoices using the enhanced experience (Dynamics 365 Sales) | MicrosoftDocs"
description: "Use the enhanced experience to quickly find and add multiple products that your customer is interested in purchasing to your quote, order, or invoice in Dynamics 365 Sales Enterprise."
ms.date: 03/17/2021
ms.service: dynamics-365-sales
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
searchScope:
  - D365-App-msdynce_saleshub
  - D365-Entity-quote
  - D365-Entity-salesorder
  - D365-Entity-invoice
  - D365-Entity-quotedetail
  - D365-Entity-salesorderdetail
  - D365-Entity-invoicedetail
  - D365-UI-*
  - Customer Engagement
  - Dynamics 365
  - Sales
---

# Preview: Add products to quotes, orders, or invoices (Sales Hub)

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

As a salesperson, you want to be able to easily identify and add
products from the catalog to quotes, orders, or invoices. With the
enhanced experience of adding products, you can:

- Quickly find products from the catalog based on free-text search

- See matching products as you type in the search field.

- Pick products from the categorized list of product families.

- See the most-recently-used list of products while adding multiple products.

- View product details inline and compare products before selecting any, which helps them find the right product.

- Select and add multiple products at one go.

- Add write-in products by using as few clicks as possible.

- Specify price, quantity, and any other required information as configured by your system administrator.

> [!IMPORTANT]
>
> - The enhanced experience for adding products is a preview feature. [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
> - [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
> - [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]

If you've created a quote from an opportunity, the products added to the opportunity are automatically added to the quote. You can add more products or remove the existing ones.

> [!NOTE]
> The process of adding a product to a quote record is the same as adding a product to an order or an invoice. This topic explains how to add products to a quote record.

1. Open the quote to which you want to add products.
2. On the **Summary** tab, select a **Price List**. 
    The price list determines the cost of the product and the products you can select.
    > [!NOTE]
    > By default, you must select a price list to be able to add products to
    > the quote; however, your administrator can change the product
    > catalog settings to make the **Price List** field optional. 
3. In the **Products** grid, click **Add products**.
   The **Add products** pop-out dialog opens.
    ![Screenshot showing the enhanced Add Products Dialog](media/enhancedAddProductsDialog.png)

    > [!NOTE]
    > The enhanced experience for adding products is only available if your system administrator has enabled the preview. If you see the form interface instead of a pop-out dialog, contact your system administrator to enable the preview. The above screenshot shows the default columns in the dialog. The information displayed in the Product column and the columns displayed in the grid are customizable. So, if you need additional columns to populate data or need more information to identify the product better, contact your system administrator. 

4. Use one of the following options to quickly identify products that best suits the opportunity:

    - If you know the product names, simply search for them and add.
    - If you want to choose products from a specific product family, use the left pane or the drop-down before the search box to filter products by family.  
        > [!NOTE]
        > The left pane disappears once you start typing in the search box.If you want to filter the search results by product family, use the drop-down. Also, the count of products in the left pane is available only when the number of products and families are less than 50000 and 5000 respectively.

    - If you want to add products that you have recently chosen for another opportunity, open the **Recently used** tab.  
    - If you want to add a product or service that is not in the standard product catalog and is specific to the opportunity, open the **write in** tab and create a product on-the-fly.

    > [!IMPORTANT]
    > Do not use the write in option for standard products and services that your organization offers.

5. Specify the Price per unit if the product does not have an associated price list. If the product has a default price list associated with it, the Price per unit is populated in accordance with the associated price list. 

    > [!TIP] 
    > If you want to override the default price of a product, request the
    > administrator to add the Price Overridden column to the grid. After
    > the Price Overridden column has been added, select Override Price.

6. Enter the quantity and click **Add**.
    As you select products, you will see the count of selected products in the **Selected** tab.

7. Repeat the process for all products you want to add. When you are done, click **Save to quote**.

## Delete or remove products from a quote, invoice or order

> [!NOTE]
> The process for removing a product from a quote record is the same as removing a product from an order or an invoice. This topic explains how to remove products from a quote record.

Remove products if you have selected them inadvertently or if they are
no longer relevant for the quote. You can remove products at two
instances:

- While adding products to the quote - in the Add products dialog
- After adding products to the quote - in the Products section of the quote

**To remove a product from the Add products dialog:**

1. Click the Selected button in the Add products dialog.
    You see the list of products that you have selected.

2. Click **Remove** to remove a selected product. Click the back arrow to continue with the selection or click **Save to quote** to add the selected products to the quote.

**To remove a product from the Products section**

1. Navigate to the **Products** section of the quote.
    You will see the list of products that you have added to the
    quote.

2. Select the products that you want to remove and click **Delete Quote Product**.
    The selected products are removed from the quote after you confirm the deletion.

### See also

[Enable the enhanced experience of adding products](enable-enhanced-add-product-experience.md)  
[Customize the Add Products dialog box](customize-add-products-dialog-box.md)

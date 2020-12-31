---
title: "Preview: Add products to quotes, orders, or invoices (Dynamics 365 Sales) | MicrosoftDocs"
description: "Use the enhanced experience to quickly find and add multiple products that your customer is interested in purchasing to your quote, order, or invoice in Dynamics 365 Sales."
ms.date: 12/30/2020
ms.service:
  - "dynamics-365-sales"
ms.topic: article
author: shubhadaj
ms.author: shujoshi
manager: annbe
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

You can add products or product bundles to a quote, order, or invoice record. The product can be an existing product in the [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] product catalog or an ad hoc product that you add as a write-in product. 

With the enhanced experience of adding products, salespeople can:

-  Quickly find products from the catalog based on free-text search, or filter products based on the product family or views.

-  See the most-recently-used list of products while adding multiple products.

-  View product details inline and compare products before selecting any, which helps them find the right product.

-  Select and add multiple products in one go.

-  Add write-in products in just a few clicks.

-  Quickly specify the price and quantity of the products.

> [!IMPORTANT]
> - The enhanced "add product" experience is a preview feature. [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
> - [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
> - [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]

If you’ve created a quote from an opportunity, the products added to the opportunity are automatically added to the quote. You can add more products or remove the existing ones.

The process for adding a product to a quote record is the same as adding a product to an order or an invoice. This topic explains how to add products to a quote record.

1. From the list of quotes, open the record you want to add the product to. 

2. On the **Summary** tab, in the **Products** section, select the **More Commands** icon ![More Commands button](media/more-commands-icon.png "More Commands button"), and then select **Add products**.

    The **Add Products** dialog box opens.

    > [!div class="mx-imgBorder"]  
    > ![Add Product dialog box](media/add-products-qoi-dialog-box.png "Add Product dialog box")

    The dialog box lets you edit line item details (product details) inline and also select multiple products at once. It has four tabs:

    -   **Products**. This tab lists all the products and product bundles that are in the **Active** or **Revised** state. Along with entering the product name, it's also possible for you to enter the price per unit and quantity. By default, 25 products are shown. Select **Load more** to see more products. On this tab, you can search and filter the list of products and select the one you want to add.

        If you've selected a price list for the quote, the product list is filtered to show only those product records that have the same price list associated.

        > [!IMPORTANT]
        > The columns that you see in the dialog box are based on the columns defined in the 'Opportunity products - Enhanced Experience' view. You system administrator can customize this view to add the columns that are most useful for your business. 
    
    -   **Recently Used**. This tab lists the last 15 products that the currently logged-in user has recently added to the quote.
    
    -   **Write-In**. This tab lets you create and add a write-in product.
    
    -   **Selected**. This tab shows the count of the products selected to be added to the quote. Use this tab to verify or modify the final list of the items you've selected.

3.  Search for and select the products you want to add, and then select **Add to Quote**.
    
    More information:
    
    -  [Search for products](#search-for-products)
    -  [Filter products](#filter-products)
    -  [See product details](#see-product-details-applies-both-to-products-and-recently-used-tabs)
    -  [Select products to add](#select-products-to-add)
    -  [Review selected products](#review-selected-products)
    -  [Remove selected products](#remove-selected-products)

## Search for products

To search for a specific product from the list, on the **Products** tab, enter the keyword in the **Search** field, and then select the **Search** icon or select the Enter key. The products matching the search criteria are shown.

The Search capability searches for the keyword in the product names or the fields of Single Line of Text or Multiple Line of Text in the Quick Find View of the Product entity. The search is performed by using the 'Contain' search operator. This means that search results show all the products that contain the keyword in one of the supported fields.

Here's how the search results are ranked/ordered:

-  The records that have values that exactly match the keywords are shown first.

-   The records that broadly match the keywords are shown next. For example, if you enter **Windows 8.1** as the search keyword, it will search for product records that contain either Windows or 8.1 in the name or other supported fields.

## Filter products

Filters are available to enable you to further narrow down your search. 

The following filters are available:

-  Product family. Use this filter to see products in a specific product family
-  Views. Use this filter to see products in a specific saved view or user view. 

> [!div class="mx-imgBorder"]  
> ![Use product filters](media/filter-products-qoi-enhanced.png "Use product filters")


> [!NOTE]
> Search and filters work in conjunction. For example, if you've searched for a keyword and 50 results are showing, you can use a filter on top of this to further narrow down this search.

## See product details (applies both to Products and Recently used tabs)

The additional details of the product like the product name and ID are shown inline below the product name. These additional details help salespeople in identifying the correct product. The data shown here is based on the fields/column added in the **Product Lookup view** of the product entity/table. Your system administrator or system customizer can customize this view to add other fields that are relevant for your business. 

   > [!div class="mx-imgBorder"]  
   > ![Product details](media/add-products-product-details.png "Product details")

## Select products to add

-  To select an existing product to add, go to the **Products** tab or the **Recently used** tab. Select the check box next to the product that you want to add, and then enter the quantity of product. 

    > [!div class="mx-imgBorder"]  
    > ![Select the product to add](media/select-products-to-add-qoi-enh.png "Select the product to add")

    -   If a product has a default price list associated with it, the **Price per unit** is populated in accordance with the associated price list. Enter the quantity. By default, the quantity is set to 1.

        > [!NOTE]
        > If you want to override the default price of a product, in the **Price Overridden** column, select **Override Price**.

    -   If the product doesn't have an associated price list, enter the price per unit and quantity.

-  To add a write-in product, on the **Write-in** tab, select **Write-in product**, and then fill in the details in the **Product Name**, **Price Per Unit**, and **Quantity** columns.

    > [!div class="mx-imgBorder"]  
    > ![Add write-in product](media/add-write-in-product-qoi-enh.png "Add a write-in product")
    
## Review selected products

When you select a product to add, a count is added to the **Selected** tab at the top of the screen. The count represents the number of products selected. In the **Products** tab or the **Recently used** tab, a check mark is shown for all the products that you've selected.

> [!div class="mx-imgBorder"]  
> ![Review selected products](media/review-selected-products-qoi-enh.png "Review selected products")

## Remove selected products

You can easily remove products that you selected earlier but don't need anymore.

To remove a product from the selection, go to the **Selected** tab. For the product that you want to remove, select the **Delete product** icon.

> [!div class="mx-imgBorder"]  
> ![Remove selected products](media/remove-selected-products-qoi-enh.png "Remove selected products")

### See also

[Add products to quotes, orders, or invoices](add-product-quote-order-invoice.md)  
[Enable the enhanced experience of adding products](enable-enhanced-add-product-experience.md)  
[Customize the Add Products dialog box](customize-add-products-dialog-box.md)

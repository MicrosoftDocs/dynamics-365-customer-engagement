---
title: "Add products to an opportunity using the enhanced experience | MicrosoftDocs"
description: "Use the enhanced experience to quickly find and add multiple products to opportunities in Dynamics 365 Sales."
ms.date: 02/03/2020
ms.service:
  - "dynamics-365-sales"
ms.topic: article
author: shubhadaj
ms.author: shujoshi
manager: annbe
---

# Add products to an opportunity using the enhanced experience

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

For salespeople, it's important to be able to quickly add products that their customers are interested in, to the opportunities.

With the simplified experience of adding products, salespeople can,

-  Quickly find products from the catalog based on free-text search, or filter products based on the product family or views

-  See the most-recently-used list of products while adding multiple products

-  View product details inline and compare products before selection helping them in identifying the right product

-  Select and add multiple products in one go

-  Add write-in products with minimal clicks

-  Quickly specify the price and quantity of the products


> [!IMPORTANT]
> - > The enhanced Add Product experience is currently in preview (early access). 
> - For salespeople to use the enhanced experience, system administrator must enable it. If you don’t see the enhanced experience, please talk to your system administrator. 

To add a product using the enhanced experience:

1.  From the list of opportunities, open the opportunity to which you want to add products.

2.  Go to the **Product Line Items** tab.

3.  Select a **Price List**. The price list determines the cost of the product.

    > [!NOTE]
    > By default, selecting a price list is required to be able to add products to an opportunity; however, your administrator can change your organization settings to make the **Price List** field optional.

4.  If you want the estimated revenue of the opportunity to be calculated based on the total amount of products, set **Revenue** to **System Calculated**. If you want to use a custom estimated revenue, set it to **User Provided**.

5.  In the **Product Line Items** grid, select **Add products**.

    The Quick Create: Opportunity Product pane opens.

    > [!div class="mx-imgBorder"]  
    > ![Add Opportunity Product pane](media/add-opportunity-product-pane.png "Add Opportunity Product pane")

    The form shows three tabs

    -   **Products**. This tab lists all the products and product bundles that are in the **Active** or **Revised** state. Along with the product name, it’s also possible for you to enter the price per unit and quantity. By default, 25 products are shown. Select **Load more** to see more products. On this tab, you can search and filter the list of products and select the one you want to add.

        If you've selected a price list for the opportunity, only the product list is filtered to show only those product records that have the same price list associated.
    
    -   **Recently Used**. This tab lists the last 15 products that the currently logged in user has recently added to any opportunity.
    
    -   **Write-In**. This tab lets you add a write-in product.
    
    -   **Selected**. This tab shows the count of the products selected to be added to the opportunity. Use this tab to look at the final list of items you’ve selected to add or remove them.

6.  Search for and select the products you want to add and select **Add to Opportunity**. 
    
    For more information, see:
    
    -  [Search for products](#search-for-products)
    -  [Filter products](#filter-products)
    -  [See product details](#see-product-details-applies-to-both-products-and-recently-used-tabs)
    -  [Select products to add](#select-products-to-add)
    -  [Review selected products](#review-selected-products)
    -  [Remove the selected products](#remove-the-selected-products)

## Search for products

To search for a specific product from the list, on the **Products** tab, enter the keyword in the **Search** field, and select the **Search** icon or hit Enter. The products matching the search criteria are shown.

The Search capability searches for the keyword in the product names or the fields of Single Line of Text or Multiple Line of Text in the Quick Find View of the Product entity. The search is performed using the 'Contain' search operator. This means that search results show all the products that contain the keyword in one of the supported fields.

Here’s how the search results are ranked/ordered:

-  The records that have values that exactly exact match the keywords are shown first.

-   The records that broadly match the keywords are shown the next. For example, if you enter Windows 8.1 as the search keyword, it will search for product records that contain either Windows or 8.1 in the name or other supported fields.

## Filter products

Filters are available to enable you to further narrow down your search. 

The following filters are available:

-  Product family. Use this filter to see products in a specific product family
-  Views. Use this filter to see products in a specific saved view or user view. 

> [!div class="mx-imgBorder"]  
> ![Use product filters](media/filter-products.png "Use product filters")


> [!NOTE]
> Search and filter work in conjunction. For example, if you have searched for a keyword and 50 results are showing, you can use a filter on top of this to further narrow down this search.

## See product details (applies to both Products and Recently used tabs)

There are two ways you can see more details about the product:

-  Select the product name. The product line item expands to show more details such as the product ID, description, and so on.

   You can expand multiple products at once. When you want to compare multiple products before you add them, this method works best.

-  Select the information icon. The following additional details are shown: validity period, price list, unit, unit group.

    > [!div class="mx-imgBorder"]  
    > ![Information icon to see product details](media/list-of-products-information-icon.png "Information icon to see product details")

    A new pop-up window with the additional details opens.

    > [!div class="mx-imgBorder"]  
    > ![Product details pop-up window](media/product-details-pop-up.png "Product details pop-up window")

## Select products to add

-  To select an existing product to add, go to the **Products** tab or the **Recently used** tab. Select the **Plus** icon next to the product name you want to add and enter the quantity of product. 

    > [!div class="mx-imgBorder"]  
    > ![Select the product to add](media/select-products-to-add.png "Select the product to add")

    -   If a product has a default price list associated, the **Price per unit** is populated as per the associated price list. Enter the quantity. By default, the quantity is set to 1.

    > [!div class="mx-imgBorder"]  
    > ![Enter product quantity](media/enter-product-quantity.png "Enter product quantity")

    > [!NOTE]
    > If you want to override the price, select the product name to expand the product line item, and then flip the **Default Price** switch to override the default price.

    > [!div class="mx-imgBorder"]  
    > ![Flip the switch to override price](media/switch-to-override-price.png "Flip the switch to override price")

    -   If the product doesn’t have an associated price list, enter the price per unit and quantity.

-  To add a write-in product, on the **Write-in** tab, select **Write-in product**, and then fill in the details in the **Product Name**, **Price Per Unit**, and **Quantity** columns.

    > [!div class="mx-imgBorder"]  
    > ![Add write-in product](media/add-write-in-product.png "Add write-in product")
    
## Review selected products

When you select a product to add, a count is added to the **Selected** tab at the top of the screen. The count represents the number of products selected. In the **Products** tab or the **Recently used** tab, a check mark is shown for all the products that are selected.

> [!div class="mx-imgBorder"]  
> ![Review selected products](media/review-selected-products.png "Review selected products")

## Remove the selected products

You can easily remove products that you'd selected earlier, but don't need anymore.

To remove a product from the selection, go to the **Selected** tab. For the product that you want to remove, select the **Delete product** icon.

> [!div class="mx-imgBorder"]  
> ![Remove selected products](media/remove-selected-products.png "Remove selected products")


### See also

[Add products to an opportunity](add-products-opportunity.md)  
[Enable the enhanced experience of adding products](enable-enhanced-add-product-experience.md)

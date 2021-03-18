---
title: "Create price lists in Dynamics 365 Sales Professional | MicrosoftDocs"
description: "Define what to charge for your products or services by creating a price list and price list items in Dynamics 365 Sales Professional."
ms.date: 10/01/2019
ms.service: 
  - "dynamics-365-sales"
ms.custom: 
  - "dyn365-sales"
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: annbe
searchScope:
  - D365-App-msdyn_salespro
  - D365-Entity-product
  - D365-Entity-pricelevel
  - D365-Entity-productpricelevel
  - D365-UI-*
  - Dynamics 365
  - Sales
---

# Create price lists

Price lists tell your sales agents what to charge for your products or services. You can create multiple price lists so that you can maintain separate price
structures for different regions you sell your products in or for different sales channels.

Price lists tie the unit, product, and pricing details together, so before you create a price list, make sure the units and products are in place.

1.  Make sure that you have the System Administrator or Sales Professional Manager role or equivalent permissions.

2.  In the site map, select **Price List**.

3.  Select **New**.

    The Price List form opens.

    > [!div class="mx-imgBorder"]
    > ![Empty Price list form](media/empty-price-list-form.png "Empty Price list form")

4.  Fill in your information, and then select **Save**.

    - **Name**. Type a descriptive name for the price list. For example, if you are creating a price list for retail, mention that.

    - **Start Date**/**End Date**. Select the start date and end date for the price list. For example, if this is a promotional price list that’s effective only for the promotional period, select that period.

    - **Currency**. Select the currency you’re creating the price list for. You can have different price lists for different currencies.

5.  To add price per unit for a product, create and add price list items.

    1.  In the **Price List** form, select the **Price List Items** tab, and then select **Add New Price List Item**.

    > [!div class="mx-imgBorder"]
    > ![Add New Price List Item button on the Price List Items tab](media/price-list-items-tab.png "Add New Price List Item button on the Price List Items tab")

    2. In the **Price List Item** form, fill in the information, and select **Save and Close**:

        - **Price List**. The price list for which you are creating a price list item is automatically populated here.

        - **Product**. Select the product from which you are creating the price list item.

        - **Unit**. Select the unit for the product you’re creating this price list item for.

        -  **Currency**. The currency defined for the price list is automatically
        populated.

        -  **Discount List**. If you want to offer a discount on a product,
        select a discount list for the price list item.

        -  **Quantity Selling Option**. Select whether the product or service can be ordered in whole, partial, or both types of quantities. This information is used in the Quantity field of Quote Product, Order Product, and Invoice Product records.

        > [!div class="mx-imgBorder"]
        > ![New Price List Item form](media/empty-price-list-item-form.png "New Price List Item form")


### See also

[Create unit groups and add units](create-unit-group-add-units.md)
[Create a product](create-products.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
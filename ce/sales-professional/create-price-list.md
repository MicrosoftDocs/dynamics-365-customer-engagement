---
title: "Create a price list in Dynamics 365 for Sales Professional | MicrosoftDocs"
description: ""
keywords: ""
author: shubhadaj
ms.author: shujoshi
manager: annbe
applies_to: 
  - Dynamics 365 for Customer Engagement
  - Dynamics 365 for Customer Engagement apps version 9.x
ms.date: 03/26/2019
ms.service: dynamics-365-sales
ms.topic: article
ms.assetid: 7a65d93b-4794-4a9b-b57a-9ef82cefc326
ms.custom: dyn365-sales
---
# Create a price list

Price lists tell your sales agents what to charge for your products or services. You can create multiple price lists so that you can maintain separate price
structures for different regions you sell your products in or for different sales channels.

Price lists tie the unit, product, and pricing details together, so before you create a price list, make sure the units and products are in place.

1.  Make sure that you have the System Administrator or Sales Professional Manager role of equivalent permissions.

2.  In the site map, select **Price List**.

3.  Select **+New**.

    The Price List form opens.

    ![Empty Price list form](media/7f6ba57e266ad83dedb874701d6ab1a1.png "Empty Price list form")

4.  Fill in your information, and then select **Save**.

    a. **Name**. Type a descriptive name for the price list. For example, if you are creating a price list for retail, mention that.

    b. **Start Date**/**End Date**. Select the start date and end date for the price list. For example, if this is a promotional price list that’s effective only for the promotional period, select that period.

    c. **Currency**. Select the currency you’re creating the price list for. You can have different price list for different currencies.

5.  To add price per unit for a product, create and add price list items.

    1.  In the **Price List** form, select the **Price List Items** tab, and then select **Add New Price List Item**.

    ![Add New Price List Item button on the Price List Items tab](media/c358464e9b8e2f07cf67850cb9a33f27.png "Add New Price List Item button on the Price List Items tab")

    2. In the **Price List Item** form, fill in the information, and select **Save and Close**:

        - **Price List**. The price list for which you are creating price list item is automatically populated here.

        - **Product**. Select the product from which you are creating the price list item.

        - **Unit**. Select the unit for the product you’re creating this price list item for.

        -  **Currency**. The currency defined for the price list is automatically
        populated.

        -  **Discount List**. If you want to offer a discount on the products,
        select a discount list to the price list item.

        -  **Quantity Selling Option**. select whether the product or service can be ordered in whole, partial, or both types of quantities. This information is used in the Quantity field of Quote Product, Order Product, and Invoice Product records.

        ![New Price List Item form](media/100172ed0bb1edf426dd5c3363c3af4f.png "New Price List Item form")

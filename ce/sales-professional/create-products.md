---
title: "Create a product in Dynamics 365 for Sales Professional | MicrosoftDocs"
description: "Create an inventory of all the products that your company sells by creating product records in Dynamics 365 for Sales."
keywords: ""
ms.date: 04/05/2019
ms.service:
  - "dynamics-365-sales"
ms.custom:
  - "dyn365-sales"
ms.topic: article
applies_to:
  - "Dynamics 365 for Customer Engagement"
  - "Dynamics 365 for Customer Engagement apps version 9.x"
ms.assetid: 3f1aa557-fcae-4b95-a4d9-0cd9e45855bf
author: shubhadaj
ms.author: shujoshi
manager: annbe
---

# Create a product in Dynamics 365 for Sales Professional

Products are the backbone of your business. The product catalog in Dynamics 365 for Sales Professional is a collection of products and their pricing information. Make it easier for your sales reps to increase their sales by creating a product catalog quickly.

1.  Make sure you have the Sales Manager Professional or a System Administrator role to be able to add products in Dynamics 365 for Sales Professional.

2.  In the site map, under **Setup**, select **Products**.

3.  Select **Add Product**.

4.  Fill in your information:

    1.  **Name**.

    2.  **Product ID**.

    3.  **Parent**. Select a parent product family for the product. If you're creating a child product in a product family, the name of the parent product family is populated here. This can't be changed after the record is saved.

    4.  **Valid From**/**Valid To**. Define the period the product is valid for by selecting a **Valid From** and **Valid To** date.

    5.  **Unit Group**. Select a unit group. A unit group is a collection of various units a product is sold in and defines how individual items are grouped into larger quantities. For example, if you're adding seeds as a product, you may have created a unit group called "Seeds," and defined its primary unit as "packet."

    6.  **Default Unit**. Select the most common unit in which the product will be sold. Units are the quantities or measurements that you sell your products in. For example, if you're adding seeds as a product, you can sell it in packets, boxes or pallets. Each of these becomes a unit of the product. If seeds are mostly sold in packets, select that as the unit.

    7.  **Default Price List**. If this is a new product, this field is read-only. Before you can select a default price list, you must complete all the required fields, and then save the record. Although the default price list is not required, after you save the product record, it is a good idea to set a default price list for each product. Then, if a customer record does not contain a price list, Sales can use the default price list for generating quotes, orders, and invoices.

    8.  **Decimals Supported**. Enter a whole number between 0 and 5. If the product can't be divided into fractional quantities, enter 0. The precision of the **Quantity** field in the quote, order, or invoice product record is validated against the value in this field if the product does not have an associated price list.

    9.  **Subject**. Associate this product with a subject. You can use subjects to categorize your products and to filter reports.

        ![Product form with data](media/product-form.png "Product form with data")


5.  Select **Save**.

6.  To add price list items, go to the **Additional Details** tab, and in the **Price List Items** section, select the **More commands** icon, and then select **Add New Price List Item**.

    ![Add New Price List Item menu option](media/add-new-price-list-item-menu-option.png "Add New Price List Item menu option")

7.  To add product relationships, on the **Additional Details** tab of the product form, in the Product Relationship section, select the **More commands** icon, and then select **Add New Product Relationship.**

8.  In the **New Product Relationship** form, enter the following details, and on the command bar, select **Save and Close**:

    -   **Related Product**. Select a product that you want to add as a related product to the existing product record you're working on.

    -   **Sales Relation Type**. Select whether you want to add the product as an up-sell, cross-sell, accessory, or substitute product.

    -   **Direction**. Select whether the relationship between the products will be uni-directional or bi-directional. When you select Uni-Directional, the product that you select in **Related Product** will be shown as a recommendation for the existing product but not vice-versa.

3.  On the product form, select **Save**.

## Import products

You may also use the import templates to bring in bulk data of products in to Dynamics 365 for Sales. More information: [Import data into Dynamics 365 for Sales](#import-contacts-accounts-or-leads-into-d)

## Revise a product
================

Keep the product inventory updated by quickly revising properties for the
products as required, and republishing the information so that your sales agents can see the latest changes to the inventory.

1.  Make sure that you have one of the following security roles or equivalent permissions: System Administrator, System Customizer, Sales Manager, Vice President of Sales, Vice President of Marketing, or CEO-Business Manager.

2.  In the site map, select **Products**.

3.  Open an active product you want to change, and on the command bar, select **Revise**.

    ![Revise button on the command bar](media/revise-button-product-form.png "Revise button on the command bar")

4.  In the **Confirm Revise** dialog box, select **Confirm**.

    ![Confirm Revise dialog box](media/confirm-revise-dialog-box.png "Confirm Revise dialog box")

    This will change the product status to **Under Revision**.

5.  After you're done making the changes, on the command bar, select
    **Publish**.

    > [!TIP]
    
    > To revert the changes and continue with the last active version of the product, select **Revert**. This changes the status of the product back to **Active**.

Revising a family sets all the products to the **Under Revision** state.

## Clone a product 

When you're creating a new product, save time by cloning an existing one. This creates a copy of the original record with all the details except for the name and ID.

1.  Make sure that you have one of the following security roles or equivalent permissions: System Administrator, System Customizer, Sales Manager, Vice President of Sales, Vice President of Marketing, or CEO-Business Manager.

2.  In the site map, select **Products**.

3.  Select a product record that you want to clone, and on the command bar, select **Clone**.

    ![Clone button on the command bar](media/clone-button-product-form.png "Clone button on the command bar")

    A confirmation dialog box appears.

    ![Confirmation dialog box for cloning product](media/confirm-clone-dialog-box.png "Confirmation dialog box for cloning product")

4.  Select **Confirm**.

A new product record will open with the same details as the original one except for the name and ID.

## Retire a product 

If your organization doesn't sell a product anymore, retire it so that the product is no longer available to your sales agents.

1.  Make sure that you have the System Administrator or Sales Professional Manager role of equivalent permissions.

2.  In the site map, select **Products**.

3.  Open an active product that you want to retire, and on the command bar, select **Retire**.

    ![Retire button on the command bar](media/retire-button-product-form.png "Retire button on the command bar")

4.  In the **Confirm Retire** dialog box, select **Confirm**.

    ![Confirm Retire dialog box](media/confirm-retire-dialog-box.png "Confirm Retire dialog box")

## Delete a product

To stop selling a product, delete it.


> [!IMPORTANT]

> You can't recover a deleted record.

1.  Make sure that you have the System Administrator or Sales Professional Manager role of equivalent permissions.

2.  In the site map, select **Products**.

3.  Select a product record you want to delete, and on the command bar, select **Delete**.

    ![Delete button on the command bar](media/delete-button-product-form.png "Delete button on the command bar")

4.  In the **Confirm Deletion** dialog box, select **Delete**.

    ![Confirm Deletion dialog box](media/confirm-deletion-dialog-box.png "Confirm Deletion dialog box")

### See Also

[Develop sales from lead to cash in Dynamics 365 for Sales Professional](develop-lead-to-cash-sales-professional.md)  
[Quick Setup & Advanced Settings overview](standard-advanced-settings-overview.md)

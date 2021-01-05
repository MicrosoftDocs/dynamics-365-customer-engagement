---
title: "Preview: Customize the Add Products dialog box (Dynamics 365 Sales) | MicrosoftDocs"
description: "Customize the Add Products dialog box so salespeople can see important product details while adding products to opportunity, quote, order, or invoice records in Dynamics 365 Sales."
ms.date: 01/08/2021
ms.service:
  - "dynamics-365-sales"
ms.topic: article
author: shubhadaj
ms.author: shujoshi
manager: annbe
searchScope:
  - D365-App-msdynce_saleshub
  - D365-Entity-opportunity
  - D365-UI-*
  - Customer Engagement
  - Dynamics 365
  - Sales
---

# Preview: Customize the Add Products dialog box (Dynamics 365 Sales)

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

A system customizer or system administrator can customize the **Add Products** dialog box to add or edit columns or to add or edit fields that show additional details of the products in the grid. These additional details help salespeople in correctly identifying the product that they want to add.  

> [!IMPORTANT]
> - The enhanced "add product" experience is a preview feature. [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
> - [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
> - [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]


## Add or remove columns of the grid

The **Add Products** dialog box uses the following views that define the columns that appear in the grid. 


| Table (entity)         | View name         |
|------------------------|-------------------|
| Opportunity product    | Opportunity products Add Products   |
| Quote product          | Quote products Add Products         |
| Order product          | Order products Add Products         |
| Invoice product        | Opportunity products Add Products   |
|                        |                   |


By default, the following columns are added to the view:

- Product name
- Unit
- Price per unit
- Quantity 

> [!div class="mx-imgBorder"]  
> ![Default columns in the Products grid of the Add Products dialog box](media/default-columns-add-products-dialog.png "Default columns in the Products grid of the Add Products dialog box")

You can edit the respective views to add or edit columns of the grid in the **Add Products** dialog box. For more information on configuring columns, see [Choose and configure columns in model-driven app views](/powerapps/maker/model-driven-apps/choose-and-configure-columns).

## Add or edit product attributes in the Product column

In the products grid of the **Add Products** dialog box, the **Products** column shows additional details of the product that helps salespeople in identifying the correct product. 

> [!div class="mx-imgBorder"]  
> ![Additional product details](media/add-products-product-details.png "Additional product details")

For opportunity products as well as the quote, order or invoice products, these details are captured from the columns (fields) that are added in the **Product Lookup View** of the **Product** table (entity). 

By default, the views show data from two columns (fields): Product name, Product ID

You can customize this views to add or edit columns, as required. You can add up to three columns to these views. 

For more information on configuring columns, see [Choose and configure columns in model-driven app views](/powerapps/maker/model-driven-apps/choose-and-configure-columns).


### See also

[Preview: Enable the enhanced experience of adding products](enable-enhanced-add-product-experience.md)  
[Customize the Add Products dialog box](customize-add-products-dialog-box.md)  
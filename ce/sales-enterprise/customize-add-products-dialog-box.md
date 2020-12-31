---
title: "Customize the Add Products dialog box (Dynamics 365 Sales) | MicrosoftDocs"
description: "Customize the Add Products dialog box so salespeople can see important product details while adding products to opportunity, quote, order, or invoice records in Dynamics 365 Sales."
ms.date: 12/31/2020
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

# Customize the Add Products dialog box (Dynamics 365 Sales)

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

A system customizer or system administrator can customize the **Add Products** dialog box to add or edit columns or to add or edit fields that show additional details of the products inline. 

> [!IMPORTANT]
> - The enhanced "add product" experience is a preview feature. [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
> - [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
> - [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]


## Add or remove columns of the grid

The **Add Products** dialog box uses the **Opportunity Products - Enhanced Experience** view, which defines the columns that appear in the grid. By default, the following columns are added to the view:

- Product name
- Price per unit
- Quantity 
- Discount

> [!div class="mx-imgBorder"]  
> ![Default columns in the Products grid of the Add Products dialog box](media/default-columns-add-products-dialog.png "Default columns in the Products grid of the Add Products dialog box")

You can edit the **Opportunity Products - Enhanced Experience** to add or edit columns of the grid. For more information on configuring columns, see [Choose and configure columns in model-driven app views](/powerapps/maker/model-driven-apps/choose-and-configure-columns).

## Add or edit product attributes in the Product column

In the products grid of the **Add Products** dialog box, the **Products** column shows additional details of the product that helps salespeople in identifying the correct product. 

> [!div class="mx-imgBorder"]  
> ![Additional product details](media/add-products-product-details.png "Additional product details")

For Opportunity Products, these details are shown from the columns (fields) that are added in the **Product Lookup View** of the Product table (entity). 
For Quote, Order, and Invoice products, the details are shown from the columns added to the **All Product Price Lists** view.
By default, the views show data from two columns (fields): 


|  View        | Columns (Fields)         |
|--------------|--------------------------|
| Product Lookup View         |  Product name, Product ID        |
| All Product Price Lists view  |  Product name, Unit         |
|              |                          |

You can customize these views to add or edit columns, as required. You can add up to three columns to these views. 

For more information on configuring columns, see [Choose and configure columns in model-driven app views](/powerapps/maker/model-driven-apps/choose-and-configure-columns).


### See also
[Preview: Enable the enhanced experience of adding products](enable-enhanced-add-product-experience.md)  
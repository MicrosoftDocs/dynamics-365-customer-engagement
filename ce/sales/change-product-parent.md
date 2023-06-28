---
title: "Change the parent of a product (reparenting) (Dynamics 365 Sales) | MicrosoftDocs"
description: "Create a product hierarchy by associating products and product families in a parent-child relationship in Dynamics 365 Sales."
ms.date: 05/10/2022
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
ms.custom: 
  - "dyn365-sales"
searchScope: 
  - D365-App-msdynce_saleshub
  - D365-Entity-product
  - D365-UI-*
  - Dynamics 365
  - Sales
  - Customer Engagement
---
# Change the parent of a product (reparenting) 

Create a product hierarchy by associating product families and products in a parent-child relationship in Dynamics 365 Sales.

## License and role requirements
| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise  <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br> More information: [Predefined security roles for Sales](security-roles-for-sales.md)|


## Change or remove the parent of a product

When you change the parent of a product, inherited properties from the previous parent are removed from the record and its child records. For example, think of a TV that was previously classified as "Plasma." The organization decides to organize TVs as Smart and Non-Smart TVs. They decide to move it from the "Plasma" family to the "Smart TV" family. A new set of properties relating to Smart TV are added and Plasma properties are removed from the parent. 

**To change or remove the parent of a product**

1. Open the record for which you want to change parent.
1. In the **Parent** field, select an appropriate product family. 

    :::image type="content" source="media/parent-product.png" alt-text="Screenshot of a product page with the Parent field highlighted.":::
    
2. To remove the parent from the record, just remove the parent record from the **Parent** field.

**Things to consider when reparenting a record:**

-	Products which are re-parented can't be reverted. When a product is reparented, the properties inherited from the previous parent are lost. Thus, you can't revert the properties of the reparented product to the last active version of the product. 

- You can only select a product family as a parent.
- You can only set product families that are in the Under Revision, Draft, or Active state as a parent.
-	You can only change or remove the parent from records that are in the **Under Revision** or **Draft** status.
-	For an **Under Revision** record, only an **Under Revision** or **Active** record can be selected as its parent.
-	For a **Draft** record, only an **Under Revision**, **Draft**, or **Active** record can be selected as its parent.  


[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

[Set up products (Sales and Sales Hub)](create-product-sales.md)  
[Set up a product family (Sales and Sales Hub)](create-product-family.md)   
[Troubleshoot issues with products](/troubleshoot/dynamics-365/sales/troubleshoot-products-issues)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]

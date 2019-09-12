---
title: "Change the parent of a product (reparenting) (Dynamics 365 Sales) | MicrosoftDocs"
description: "Create a product hierarchy by associating products and product families in a parent-child relationship in Dynamics 365 Sales."
keywords: "product, parent, reparent"
ms.date: 10/01/2019
ms.service:
  - "dynamics-365-sales"
ms.custom:
  - "dyn365-sales"
ms.topic: article
ms.assetid: af0848d3-6b44-4669-91ee-115e122853f2
author: shubhadaj
ms.author: shujoshi
manager: annbe
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
---

# Change the parent of a product (reparenting)

[!INCLUDE[cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

To organize your company's product catalog better, you may want to change the parent of an existing product record so the child products inherit the appropriate product properties. You can change the parent of an existing product, bundle, or family to a new parent or delete an existing parent.

> [!IMPORTANT]
> - [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
> - [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]
> - To learn about enabling preview features in the 2019 release wave 2, see [How do I enable the 2019 release wave 2 updates](/power-platform/admin/preview-october-2019-updates#when-will-the-2019-release-wave-2-features-be-enabled)


To change the parent of a product, bundle, or family, open the respective record, and in the **Parent** field, select the new parent record. To delete the parent, just remove the parent record from the **Parent** field.

Things to consider when changing reparenting:

-	Products which are re-parented cannot be reverted.
-	You can only change or remove the parent from records that are in the **Under Revision** or **Draft** status.
-	For an **Under Revision** record, only an **Under Revision** or **Active** record can be selected as its parent.
-	For a **Draft** record, only an **Under Revision**, **Draft**, or **Active** record can be selected as its parent.  

When you reparent an existing record, all the existing inherited properties of the record and its child records are removed, and the new properties of the new parent (if any) are added. 

For example, think of a TV that was previously classified as "Plasma." The organization decides it’s better to organize TVs as Smart vs Non-Smart TVs. They decide to move it from the "Plasma" family to the "Smart TV" family. A new set of properties relating to Smart TV are added and Plasma properties are removed from the parent. 

### See also

[Set up products (Sales and Sales Hub)](create-product-sales.md)  
[Set up a product family (Sales and Sales Hub)](create-product-family.md) 

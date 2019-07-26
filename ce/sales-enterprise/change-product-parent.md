---
title: "Change the parent of a product (reparenting) (Dynamics 365 for Sales) | MicrosoftDocs"
description: "Create a product hierarchy by associating products and product families in a parent-child relationship in Dynamics 365 for Sales."
keywords: "product, parent, reparent"
ms.date: 08/01/2019
ms.service:
  - "dynamics-365-sales"
ms.custom:
  - "dyn365-sales"
ms.topic: article
applies_to:
  - "Dynamics 365 for Customer Engagement"
  - "Dynamics 365 for Customer Engagement apps version 9.x"
ms.assetid: af0848d3-6b44-4669-91ee-115e122853f2
author: shubhadaj
ms.author: shujoshi
manager: annbe
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
---

# Change the parent of a product (Reparenting)

[!INCLUDE[cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

To organize your company's product catalog better, you may want to change the parent of an existing product record, so the child products inherit the appropriate product properties. You can change the parent of an existing product, bundle, or family to a new parent or delete an existing parent.

> [!IMPORTANT]
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]

To change the parent of a product, bundle, or family, open the respective record, and in the Parent field, select the new parent record. To delete the parent, just remove the parent record from the Parent field.

Things to consider when changing the parent (reparenting):

-	Products which are re-parented cannot be reverted.
-	You can change or remove the parent of only the records that are in the **Under Revision** or **Draft** status.
-	For an **Under Revision** record, only an Under Revision or Active record can be selected as its parent.
-	For a Draft record, only an Under Revision, Draft, or Active record can be selected as its parent.  

When you change the parent of an existing record, all the existing inherited properties of the record and its child records are removed, and new properties of the new parent (if any) are added. 

For example, think of a TV that was previously classified as Plasma. The organization decides it’s better to organize TVs as Smart vs Non-Smart TVs. They decide to move it from ‘Plasma’ family to ‘Smart TV’ family. New set of properties relating to Smart TV are added and Plasma properties are removed from the parent. 

### See also

[Set up products](create-product-sales.md)  
[Set up a product family](create-product-family.md) 

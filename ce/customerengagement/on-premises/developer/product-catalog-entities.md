---
title: "Product catalog entities (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Enables the creation of rich product classification systems that support the definition of: hierarchical structures, product bundles, or related products, multiple pricing or discounting models, automatic price lists, and localized names and descriptions."
ms.custom: 
ms.date: 02/28/2023
ms.reviewer: pehecke
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - product catalog entities, deactivating obsolete products
  - product catalog entities, associating products with accounts and sales literature
  - deactivating obsolete products, product catalog entities
  - product catalog entities, terms defined for products and pricing
  - product catalog entities, introduction
  - associating products with accounts and sales literature, product catalog entities
ms.assetid: 1915ba81-7d8f-46a7-88de-4c7a1aa24b04
author: KumarVivek
ms.author: kvivek
manager: amyla
search.audienceType: 
  - developer

---
# Product catalog entities

A product catalog is a collection of products with their pricing information. 

> [!IMPORTANT]
> The developer concepts and operations related to product catalog entities in Dynamics 365 Customer Engagement (on-premises) are similar to Dynamics 365 Sales. For extensibility information about these entities, see [Developer Guide for Dynamics 365 Sales](/dynamics365/sales/developer/product-catalog-entities).

The *product catalog* entities let you create a rich product classification system in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] that provides support for:  
  
- Defining hierarchical structure of product families and products with configurable properties (attributes) that help you reduce the number of product stock keeping units (SKUs) needed to maintain your product catalog.  
  
- Selling individual products or grouping them into bundles and kits. A bundle or a kit is a collection of products that is sold as single unit. Product bundling is useful in grouping products in a way that customers get more benefit from the full line of products or to offer discounts on bundled products.  
  
  > [!NOTE]
  >  Kits are deprecated in the current release of [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. You should use bundles instead.  
  
- Defining related products in the system (substitute, cross-sell, up-sell, or accessory). The related products for a product are displayed as suggestions to the sales agents when they add the product to an opportunity, quote, order, or invoice.  
  
- Defining multiple pricing and discounting models. You can also use custom pricing instead of the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] system pricing to calculate prices when you associate a product or bundle to an opportunity, quote, order, or invoice. Further, you can select whether to apply discounts for products at the per-unit or line level.  
  
- Specify whether you want the price level (price list) to be automatically set for an opportunity, quote, order, or invoice based on the sales territory relationship of the user.  
  
- Specifying localized values for certain product properties (attributes) to make the product names and descriptions available in the user-preferred languages. 

These videos describe how products are administered and used in [!INCLUDE[pn_crm_2015_and_online_full](../includes/pn-crm-2015-and-online-full.md)]:  
  
-   [Video: Product Taxonomy Administration in Microsoft Dynamic CRM 2015](https://youtu.be/OnjdSUjulVw)  
  
-   [Video: Salesperson Experience with Product Taxonomy in Microsoft Dynamics CRM 2015](https://youtu.be/MptViq7tf_s)  
  

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]

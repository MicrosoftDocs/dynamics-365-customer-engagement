---
title: Product catalog tables (Dynamics 365 Sales)
description: "Enables the creation of rich product classification systems that support the definition of: hierarchical structures, product bundles, or related products, multiple pricing or discounting models, automatic price lists, and localized names and descriptions."
ms.date: 03/01/2023
ms.reviewer: lavanyakr
ms.topic: article
applies_to: 
  - Dynamics 365 Sales
author: udaykirang
ms.author: udag
manager: shujoshi
search.audienceType: 
  - developer

---
# Product catalog tables

A product catalog is a collection of products with their pricing information. The *product catalog* tables let you create a rich product classification system in Dynamics 365 Sales that provides support for:  
  
- Defining hierarchical structure of product families and products with configurable properties (attributes) that help you reduce the number of product stock keeping units (SKUs) needed to maintain your product catalog.  
  
- Selling individual products or grouping them into bundles and kits. A bundle or a kit is a collection of products that is sold as single unit. Product bundling is useful in grouping products in a way that customers get more benefit from the full line of products or to offer discounts on bundled products.  
  
  > [!NOTE]
  >  Kits are deprecated in the current release of Dynamics 365 Sales. You should use bundles instead.  
  
- Defining related products in the system (substitute, cross-sell, up-sell, or accessory). The related products for a product are displayed as suggestions to the sales agents when they add the product to an opportunity, quote, order, or invoice.  
  
- Defining multiple pricing and discounting models. You can also use custom pricing instead of the Dynamics 365 Sales system pricing to calculate prices when you associate a product or bundle to an opportunity, quote, order, or invoice. Further, you can select whether to apply discounts for products at the per-unit or line level.  
  
- Specify whether you want the price level (price list) to be automatically set for an opportunity, quote, order, or invoice based on the sales territory relationship of the user.  
  
- Specifying localized values for certain product properties (attributes) to make the product names and descriptions available in the user-preferred languages.  
  
  Use the following tables in Dynamics 365 Sales to manage your product catalog.  
  
| Table |Description |
|-------|------------|
| `Product` | A *product* is either a physical inventory item (such as lumber or a nail), or a service (such as a haircut or tree pruning) that a company sells. Products from the product catalog can be used to build quotes and orders, and can be associated with opportunities or service cases. In addition, each product can contain links to sales literature and links to information about competitors and their products. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Product Table](entities/product.md) |
| `ProductSubstitute (Product Relationship)` | A *product relationship* contains information about the selling relationship between two products, including the relationship type, such as up-sell, cross-sell, substitute, or accessory. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [ProductSubstitute Table](entities/productsubstitute.md) |
| `DynamicProperty (Property)` |   A *property* stores information about a product property such as its name, the product family record that its associated with, attributes such as data type, whether its read only, hidden, or required. |
| `DynamicPropertyOptionSetItem (Property Option Set Item)` | A *property option set item* stores information about individual options for a product property of option set data type. |
| `DynamicPropertyInstance (Property Instance)` | A *property instance* stores the instance of a product property along with its values. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [DynamicPropertyInstance Table](entities/dynamicpropertyinstance.md) |
| `PriceLevel (Price List)` | A *price list* contains one to many individual product and bundle prices, aggregated together into a list for categorization purposes. This enables easier maintenance and usability of the list. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [PriceLevel Table](entities/pricelevel.md) |
| `ProductPriceLevel (Price List Item)` | A *price list item* represents configurations that enable a business unit to control how prices are calculated in Dynamics 365 Sales such as quantity selling options, pricing method, rounding policy, and the rounding option. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [ProductPriceLevel Table](entities/productpricelevel.md) |
| `Discount` | *Discounts* enable a product to have different sales prices, depending on the quantity purchased. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Discount Table](entities/discount.md) |
| `DiscountType (Discount List)` | A *discount list* is an aggregation of different discounts, specifying how much of a discount the user can receive when the purchasing amount falls between certain ranges. Discount lists can exist at each quantity level, together with detail lines that contain the quantity breakpoints, and the reduction in the price. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [DiscountType Table](entities/discounttype.md) |
| `UoM (Unit)` | A *unit* is a measurement that specifies in what quantity a product will be sold. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [UoM Table](entities/uom.md) |
| `UoMSchedule (Unit Group)` | A *unit group* contains one to many types of unit of measurement, as calculated from a base unit. A product is tied to a unit group in which it is sold. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [UoMSchedule Table](entities/uomschedule.md) |
  
 These videos describe how products are administered and used in [!INCLUDE[pn_crm_2015_and_online_full](../../includes/pn-crm-2015-and-online-full.md)]:  
  
-   [Video: Product Taxonomy Administration in Microsoft Dynamic CRM 2015](https://youtu.be/OnjdSUjulVw)  
  
-   [Video: Salesperson Experience with Product Taxonomy in Microsoft Dynamics CRM 2015](https://youtu.be/MptViq7tf_s)  
  
## In This Section  
 [Manage product families, products and bundles](create-manage-product-families-products-bundles-product-properties.md)  
  
 [Publish, revise, revert, retire, and activate products (product lifecycle)](publish-revise-revert-retire-activate-products.md)  
  
 [Manage Product Pricing](product-pricing-methods.md)  
  
 [Use custom pricing for products](use-custom-pricing-products.md)  
  
 [Set default price level for opportunity, quote, order, invoice](set-default-price-level-for-opportunity-quote-order-invoice.md)  
  
 [Product discounting methods](product-discounting-methods.md)  
  
 [Localize product property values](localize-product-property-values.md)  
  
 [Product Table](entities/product.md)  
  
 [ProductSubstitute Table](entities/productsubstitute.md)  
  
 [ProductAssociation Table](entities/productassociation.md)  
  
 [DynamicPropertyInstance Table](entities/dynamicpropertyinstance.md)  
  
 [PriceLevel Table](entities/pricelevel.md)  
  
 [ProductPriceLevel Table](entities/productpricelevel.md)  
  
 [Discount Table](entities/discount.md)  
  
 [DiscountType Table](entities/discounttype.md)  
  
 [UoM Table](entities/uom.md)  
  
 [UoMSchedule Table](entities/uomschedule.md)  
  
 [Sample: Create and publish products](sample-create-publish-products.md)  
  
 [Sample: Clone product records](sample-clone-product-records.md)  
  
 [Sample: Add products to a bundle](sample-add-products-bundle.md)  
  
 [Sample: Calculate Price plug-in](sample-calculate-price-plugin.md)  
  
## Related Sections  

 [Opportunity Tables](opportunity-entities.md)  
  
 [Quote, order, and invoice tables](quote-order-invoice-entities.md)  
  
### See also

 [Video: Product Taxonomy Administration in Microsoft Dynamic CRM 2015](https://youtu.be/OnjdSUjulVw)   
 [Video: Salesperson Experience with Product Taxonomy in Microsoft Dynamics CRM 2015](https://youtu.be/MptViq7tf_s)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]

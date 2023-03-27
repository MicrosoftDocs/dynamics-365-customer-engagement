---
title: Use price lists
description: Learn about using price lists in Dynamics 365 Field Service.
ms.date: 01/12/2023
ms.topic: how-to
ms.author: jacoh
author: jasonccohen
search.app: 
  - D365CE
  - D365FS
ms.custom: bap-template
---
# Use price lists

Dynamics 365 Field Service builds on [Dynamics 365 Sales price lists](../sales/create-price-lists-price-list-items-define-pricing-products.md) and [product catalogs](../sales/set-up-product-catalog-walkthrough.md). Use price lists to add products and services to work orders with appropriate pricing.  

For work order [products and services](create-product-or-service.md) that represent parts or labor billed to your customers, use price lists and price list items. You can also use price lists with **Field Service Price List Items** for more pricing options.

## Create a price list

Define basic properties of the *Price List* record.
  
1. In Field Service, change to the **Settings** area.

1. In the **General** section, select **Price Lists**.

1. Select **New**.

1. Enter information in the **General** tab.

   - **Name** to distinguish the price list.
   - Optional **Start/End Date** to define when the price list is effective.
   - **Currency** used on the price list.

   :::image type="content" source="media/price-list-general-tab.png" alt-text="Screenshot of a price list record. ":::

1. Select **Save** to create the *Price List* record.

> [!NOTE]
> Organizations that use Field Service in combination with Dynamics 365 Project Operations find additional fields and related tabs on a price list record, some of them showing by default. *Context*, *Role price*, *Role price markups*, *Time Unit*, and *Category prices* are concepts which Project Operations introduces and are currently not supported by the Field Service pricing and costing functionality.

## Add price list items  

Add products and services as price list items to the price list.

1. Open a *Price List* record.

1. On the **Price List Items** tab, select **New Price List Item**.

1. Choose a product or service in the **Product** field.

1. On the **Pricing information** tab:

   - **Pricing Method**: Choose **Currency Amount**.
   - **Amount**: Enter the price of the product or service. Enter the hourly rate for services.
   - **Discount List**: Don't use this setting. Field Service currently doesn't support discount lists price list items. You can configure discounts directly on work order products and services.

For more information about options for price list items, go to [Define product pricing with price lists and price list items](../sales/create-price-lists-price-list-items-define-pricing-products.md).

## Add Field Service price list items

You can add more pricing options for products and services by creating *Field Service Price List Items*. You can add a product or service that isn't a price list item. In this case, the list price on the product record will be used.

1. Open a *Price List* record.

1. Select **Related** > **Field Service Price List Item**.

1. Select **Add Field Service Price List Item**.

1. On the **General** tab:

   - Provide a **Name**.
   - Choose the **Duration Rounding Policy**.
   - Set the **Flat Fee** option. Flat fee applies a fixed price to a service, regardless of duration. The fixed price is derived first from the price list item amount, and then the list price on the product record.
   - **Minimum Charge Duration** specifies the time *not billed* before charging the customer.
   - Choose a **Product/Service**. By not adding a product or service, the options apply to all services added to a work order when selecting the parent price list. Not adding a product is helpful if, for example, you want to add a minimum charge amount to all services in the price list. It saves time because you don't need to add all services as Field Service Price List Items.
   - Set **Duration Round To** for your preferred rounding option.
   - **Minimum Charge Amount** defines a base fee for a service. The amount will be added on to final price regardless of amount charged.
  
   :::image type="content" source="media/price-list-field-service-price-list-item.png" alt-text="Screenshot of a Field Service price list item.":::

1. Select **Save & Close**.  

## Add a price list to work orders

When [creating a work order](create-work-order.md), choose a price list. The price list can be entered manually or filled in automatically based on the billing account or the work order.

:::image type="content" source="media/price-list-work-order.png" alt-text="Screenshot of a work order with a highlight on the price list.":::

The selected price list automatically applies to all work order products and services. However, you can change it on the individual work order product or service.

> [!TIP]
> Use [Entitlements](./work-order-entitlements.md) to dynamically adjust the price of work order products and services.

## Add territory relationships

Add default price lists for [territories](set-up-territories.md) or customer segments. It helps your field service team to see the default price list for the area they're working in.

1. Open a *Price List* record.

1. In the **Territory Relationships** section, select **Add Connection**.  
  
1. Select one or more territories.  
  
1. Select **Save & Close**.

[!INCLUDE[footer-include](../includes/footer-banner.md)]

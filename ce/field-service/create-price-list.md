---
title: Use price lists
description: Learn about using price lists in Dynamics 365 Field Service.
ms.date: 05/08/2024
ms.topic: how-to
ms.author: jacoh
author: jasonccohen
ms.custom: bap-template
---
# Use price lists

Dynamics 365 Field Service builds on [Dynamics 365 Sales price lists](../sales/create-price-lists-price-list-items-define-pricing-products.md) and [product catalogs](../sales/set-up-product-catalog-walkthrough.md). Use price lists to add products and services to work orders with appropriate pricing.  

For work order [products and services](create-product-or-service.md) that represent parts or labor billed to your customers, use price lists and price list items. You can also use price lists with **Field Service Price List Items** for more pricing options.

## Create a price list

Define basic properties of the price list.
  
1. In Field Service, change to the **Settings** area.

1. In the **General** section, select **Price Lists**.

1. Select **New**.

1. On the **General** tab, enter the following information:

   - **Name**: A unique name to distinguish the price list.
   - **Start/End Date** (optional): When the price list is effective.
   - **Currency**: The currency to use on the price list.

   :::image type="content" source="media/price-list-general-tab.svg" alt-text="Screenshot of a price list record. ":::

1. Select **Save**.

> [!NOTE]
> Organizations that use Field Service in combination with Dynamics 365 Project Operations find additional fields and related tabs on a price list record, some of them showing by default. *Context*, *Role price*, *Role price markups*, *Time Unit*, and *Category prices* are concepts which Project Operations introduces and aren't supported by the Field Service pricing and costing functionality.

## Add price list items  

Add products and services as price list items to the price list. For more information about options for price list items, go to [Define product pricing with price lists and price list items](../sales/create-price-lists-price-list-items-define-pricing-products.md).

1. Open a price list.

1. On the **Price List Items** tab, select **New Price List Item**.

1. Choose a product or service in the **Product** field.

1. On the **Pricing information** tab, enter the following information:

   - **Pricing Method**: Select **Currency Amount**.
   - **Amount**: The price of the product or service or the hourly rate for services.

1. Select **Save**.

## Add Field Service price list items

You can add more pricing options for products and services by creating **Field Service Price List Items**. You can add a product or service that isn't a price list item. In this case, the list price on the product record is used.

1. Open a price list.

1. Select **Related** > **Field Service Price List Item**.

1. Select **New Field Service Price List Item**.

1. On the **General** tab, enter the following information:

   - **Name**: Name for the item.
   - **Duration Rounding Policy**: How the system should round the Duration To Bill.
   - **Flat Fee**: **Yes** applies a fixed price to a service, regardless of duration. The fixed price is derived first from the price list item amount, and then the list price on the product record.
   - **Minimum Charge Duration**: The time *not billed* before charging the customer.
   - **Product/Service**: If you don't add a product or service, the options apply to all services added to a work order when selecting the parent price list. For example, if you want to add a minimum charge amount to all services in the price list, don't add a product or service. It saves time because you don't need to add all services as Field Service Price List Items.
   - **Duration Round To**: The rounding duration.
   - **Minimum Charge Amount**: A base fee for a service. The amount is added on to the final price regardless of the amount charged.
  
   :::image type="content" source="media/price-list-field-service-price-list-item.png" alt-text="Screenshot of a Field Service price list item.":::

1. Select **Save & Close**.  

## Add a price list to work orders

When [creating a work order](create-work-order.md), choose a price list. The price list can be entered manually or filled in automatically based on the billing account or the work order.

:::image type="content" source="media/price-list-work-order.svg" alt-text="Screenshot of a work order with a highlight on the price list.":::

The selected price list automatically applies to all work order products and services. However, you can change it on the individual work order product or service.

> [!TIP]
> Use [Entitlements](./work-order-entitlements.md) to dynamically adjust the price of work order products and services.

## Add territory relationships

Add default price lists for [territories](set-up-territories.md) or customer segments. It helps your field service team to see the default price list for the area they're working in.

1. Open a price list.

1. In the **Territory Relationships** section, select **New Connection**.  
  
1. Select one or more territories.  
  
1. Select **Save & Close**.

[!INCLUDE[footer-include](../includes/footer-banner.md)]

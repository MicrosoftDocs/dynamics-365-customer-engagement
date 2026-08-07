---
title: Create entitlements for work orders
description: Create entitlements for work orders in Dynamics 365 Field Service to apply price lists, percentage discounts, or free products and services.
ms.date: 08/07/2026
ms.topic: how-to
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: lmasieri
ms.author: lmasieri
ms.reviewer: v-wendysmith
ms.custom:
 - ai-gen-docs-bap
 - ai-seo-date: 08/07/2026
ai-usage: ai-assisted
---

# Create entitlements for work orders

By using entitlements for work orders, field service organizations can dynamically apply price lists and discounts to work order products and services based on work order attributes and date range factors. Learn more in [Entitlements for work orders overview](work-order-entitlements-overview.md).

Apply entitlements to work orders based on:

- Billing account
- Service account
- Specific products and services
- Specific customer assets
- Customer asset categories
- Incident types

This article provides two scenarios for entitlements for work orders:

- **Scenario 1:** An organization wants to offer a customer a 10% discount for two years on all work order products and services based on a preset price list.

- **Scenario 2:** An organization wants to offer a customer free work order products and services for two years for work orders that relate to customer assets of a specified category.

## Prerequisites

- Dynamics 365 Customer Service  
- Recommended: Knowledge of Dynamics 365 [price lists](/dynamics365/customer-engagement/sales-enterprise/create-price-lists-price-list-items-define-pricing-products)

## Scenario 1: Entitlement for price list and discount

In this scenario, an organization wants to offer a customer a 10% discount for two years on all work order products and services based on a preset price list.

> [!NOTE]
> For a different scenario where you want to apply a 10% discount on products and a 20% discount on services, create two entitlements.

### Create a price list and add a product

For this scenario, you must have a price list with associated products.

1. [Create a price list](create-price-list.md#create-a-price-list).

1. Add the products and services as [price list items](create-price-list.md#add-price-list-items) with the related prices.

   > [!TIP]
   > The **Field Service Product Type** on the product or service record indicates whether the product is inventory or a non-inventory product or if it's a service.

### Create an entitlement

1. In Field Service, change to the **Settings** area. Under **Service Delivery**, select **Entitlements**.

1. Select **New**.

1. Enter the following information:

   - **Name**: Enter a unique name.

   - **Primary Customer:** Select the [account](accounts.md) for this entitlement. If you choose an account that's later listed as the billing account of a work order, the work order can be eligible for this entitlement. An entitlement can only apply to one customer. However, a billing account can be related to multiple service accounts. So work orders for multiple locations can have entitlements applied to all of them as long as the billing account is the same.

   - **Start Date and End Date:** Select the date range during which this entitlement is valid. If you create a valid work order within this range, the entitlement is applied.

   - **Entity Type:** Select **Work Order**.

   - **Allocation Type:** Select **Discount % and Price List**.

   - **Applies to:** Select **Both Work Order Products & Services** for this scenario. You can also apply entitlements to only products or only services.

   - **Price List to Apply:** Select the price list that you want applied to the work order product and service when the entitlement is applied. This price list overrides the price list on a work order.

   - **% Discount:** Enter the percentage to discount off the price of the work order product or service. If you apply a price list, and the product or service is part of the price list, this value discounts the price list price. If it isn't part of the price list, this value discounts the list price on the product record.

   - **Entitlement Prioritization:** For instances when multiple entitlements apply to a single work order product or service, enter a number that represents the priority of this entitlement. Entering "1" represents the highest priority.

   > [!NOTE]
   > If you add products or services to the entitlement on the **Products** subgrid, the entitlement applies when the product or service matches the work order product or service.

1. Select **Save** and then **Activate** the entitlement.

   :::image type="content" source="media/entitlement-scenario1.png" alt-text="Screenshot of an entitlement.":::

### Create a work order and add work order products and services

To use the entitlement, create a work order.

1. [Create a work order](create-work-order.md). To trigger the entitlement, make sure the billing account is the same as the primary customer of the entitlement. Select **Save**.

1. Select the **Products and services** tab and create a product or service record.

1. On the product or service record, scroll to the **Other** section. Make sure the correct entitlement is applied. The price list on the entitlement overrides the price list on the work order. If there are [multiple entitlements](work-order-entitlements-overview.md#multiple-entitlements), the default entitlement is chosen.

   :::image type="content" source="media/entitlement-work-order-product.png" alt-text="Screenshot of entitlement applied to work order product.":::

1. Save and close the work order.

When the work order product **Line Status** is changed from **Estimated** to **Used**, the discount percentage is applied and changes the **Estimate Total Amount**.

:::image type="content" source="media/entitlement-work-order-product-discount1.png" alt-text="Screenshot of discount applied to work order product from the entitlement.":::

## Scenario 2: Entitlement for free products and services for an asset category

In our second scenario, an organization wants to offer a customer free work order products and services for two years for work orders that relate to customer assets with a specified category. This scenario uses an entitlement application. Entitlement applications work in addition to the primary customer value, not in replacement of. For example, if the service account of an entitlement application matches a work order service account, but the billing account doesn't match the primary customer, then the entitlement isn't applied.

### Create a customer asset

[Create a customer asset](assets.md) with the category "Heating, Venting, and Air Conditioning". This category must match the one on the entitlement application that you create next.

### Create an entitlement for scenario 2

1. [Create an entitlement](#create-an-entitlement) with the **% Discount** set to 100% to make the work order products and services free when the entitlement is applied. Select **Save**.

   :::image type="content" source="media/entitlement-scenario2.png" alt-text="Screenshot of an entitlement with the Entitlement Applications section highlighted.":::

1. In the **Entitlement Applications** section, select the vertical ellipsis &vellip; and then **New Entitlement Application**.

1. Enter the name of the application and select *Heating, Venting, and Air Conditioning* for the **Asset Category**.

   :::image type="content" source="media/entitlement-scenario2-entitlement-application.png" alt-text="Screenshot of an entitlement application highlighting an asset category.":::

1. **Save & Close** and then **Activate** the entitlement.

   If a work order product or service is related to a customer asset, *and* the customer asset belongs to the "Heating, Venting, and Air Conditioning" **Asset Category**, then the entitlement is applicable.

### Create a work order to service the customer asset

1. [Create a work order](create-work-order.md) that matches the entitlement for the second scenario. On the **General** tab, the billing account on the work order matches the primary customer on the entitlement. The selected incident type lists an asset that belongs to the "Heating, Venting, and Air Conditioning" category.

   :::image type="content" source="media/entitlement-work-order-scenario2.png" alt-text="Screenshot of a work order for the billing account and a customer asset the same as the entitlement." lightbox="media/entitlement-work-order-scenario2.png":::

1. Open the product on the work order and scroll to the **Other** section. Make sure the correct entitlement is applied to the work order products.

1. Select the **Estimate Information** tab. The 100% discount is applied, rendering the work order products as free. If services are included in the entitlement, the same discount applies to them.

   :::image type="content" source="media/entitlement-work-order-product-discount2.png" alt-text="Screenshot of discount making the work order product free.":::

1. Save and close the work order.

[!INCLUDE[footer-include](../includes/footer-banner.md)]

---
title: Create entitlements for work orders
description: Learn how to use entitlements for work orders in Dynamics 365 Field Service.
ms.date: 07/10/2024
ms.topic: how-to
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: lmasieri
ms.author: lmasieri
---

# Create entitlements for work orders

Entitlements for work orders allow field service organizations to dynamically apply price lists and discounts to work order products and services based on work order attributes and date range factors. Learn more: [Entitlements for work orders overview](work-order-entitlements-overview.md).

Entitlements can be applied to work orders based on:

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

- Field Service v8.4+
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

   - **Primary Customer:** Select the [account](accounts.md) for this entitlement. If the account chosen is later listed as the billing account of a work order, then this entitlement can be eligible. An entitlement can only apply to one customer. However, a billing account can be related to multiple service accounts. So work orders for multiple locations can have entitlements applied to all of them as long as the billing account is the same.

   - **Start/End Date:** Select the date range during which this entitlement is valid. If a valid work order is created within this range, the entitlement is applied.

   - **Entity Type:** Select **Work Order**.

   - **Allocation Type:** Select **Discount % and Price List**.

   - **Applies to:** Select **Both Work Order Products & Services** for this scenario. Entitlements can also be applied to only products or only services.

   - **Price List to Apply:** Select the price list that you want applied to the work order product and service when the entitlement is applied.

   - **% Discount:** Enter the percentage to discount off the price of the work order product or service. If a Price List is applied, and the product or service is part of the price list, this value discounts the price list price. If it isn't part of the price list, this value discounts the list price on the product record.

   - **Entitlement Prioritization:** For instances when multiple entitlements apply to a single work order product or service, enter a number that represents the priority of this entitlement. Entering "1" represents the highest priority.

   > [!NOTE]
   > If you add products or services to the entitlement on the **Products** subgrid, the entitlement applies when the product or service matches the work order product or service.  

1. Select **Save** and then **Activate** the entitlement.

   :::image type="content" source="media/entitlement-scenario1.svg" alt-text="Screenshot of an entitlement.":::

### Create a work order and add work order products and services

To use the entitlement, create a work order.

1. [Create a work order](create-work-order.md). To trigger the entitlement, make sure the billing account is the same as the primary customer of the entitlement. Select **Save**.

1. Select the **Products and services** tab and create a product or service record. Open the product or service record.

1. Select the **Other** tab. The entitlement is automatically chosen which overrides the price list on the work order with the price list on the entitlement. In the case of [multiple entitlements](work-order-entitlements-overview.md#multiple-entitlements), the default entitlement is chosen.

   :::image type="content" source="media/entitlement-work-order-product1.svg" alt-text="Screenshot of entitlement applied to work order product.":::

When the work order product **Line Status** is changed from **Estimated** to **Used**, the discount percentage is applied and changes the **Estimate Total Amount**.

:::image type="content" source="media/entitlement-work-order-product-discount.svg" alt-text="Screenshot of discount applied to work order product from the entitlement.":::

## Scenario 2: Entitlement for free products and services for an asset category

In our second scenario, an organization wants to offer a customer free work order products and services for two years for work orders that relate to customer assets with a specified category. This scenario uses an entitlement application.

### Create an entitlement for scenario 2

1. [Create an entitlement](#create-an-entitlement) with the **% Discount** set to 100% to make the work order products and services free when the entitlement is applied.

   :::image type="content" source="media/entitlement-scenario2.svg" alt-text="Screenshot of an entitlement with the Entitlement Applications section highlighted.":::

1. In the **Entitlement Applications** section, select the vertical ellipsis &vellip; and then **New Entitlement Application**.

   > [!Note]
   > Entitlement applications work in addition to the primary customer value, not in replacement of. For example, if the service account of an entitlement application matches a work order service account, but the billing account doesn't match the primary customer, then the entitlement isn't applied.

   In the following example, if a work order product or service is related to a customer asset, *and* the customer asset belongs to the "Heating, Venting, and Air Conditioning" **Asset Category**, then the entitlement is applicable.

   :::image type="content" source="media/entitlement-scenario2-entitlement-application.svg" alt-text="Screenshot of an entitlement application highlighting an asset category.":::

1. **Save** and **Activate** the entitlement.

### Create a customer asset

[Create a customer asset](assets.md) with the category "Heating, Venting, and Air Conditioning" to match the category on the entitlement application.

### Create a work order to service the customer asset

1. [Create a work order](create-work-order.md) that matches the entitlement for the second scenario. On the **General** tab, the billing account on the work order matches the primary customer on the entitlement. The selected incident type lists an asset that belongs to the "Heating, Venting, and Air Conditioning" category.

   :::image type="content" source="media/entitlement-work-order2.svg" alt-text="Screenshot of a work order for the billing account and a customer asset the same as the entitlement.":::

1. Open the product on the work order and select the **Other** tab. The correct entitlement is applied to the work order products.

   :::image type="content" source="media/entitlement-work-order-product2.svg" alt-text="Screenshot of entitlement applied to the work order product.":::

1. Select the **Estimate Information** tab. The 100% discount is applied, rendering the work order products as free. If services are included in the entitlement, the same discount applies to them.

   :::image type="content" source="media/entitlement-work-order-product2-discount.svg" alt-text="Screenshot of discount making the work order product free.":::

[!INCLUDE[footer-include](../includes/footer-banner.md)]

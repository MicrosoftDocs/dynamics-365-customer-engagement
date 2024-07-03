---
title: Create entitlements for work orders
description: Learn about how to use entitlements for work orders in Dynamics 365 Field Service.
ms.date: 07/03/2024
ms.topic: how-to
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: lmasieri
ms.author: lmasieri
---

# Create entitlements for work orders

Entitlements for work orders allow field service organizations to dynamically apply price lists and discounts to work order products and services based on work order attributes and date range factors. This parallels how organizations might offer case entitlements in Dynamics 365 Customer Service.

Entitlements can be applied to work orders based on:

- Billing account
- Service account
- Specific products and services
- Specific customer assets
- Customer asset categories
- Incident types

This article provides two scenarios for entitlements for work orders:

> **Scenario 1:** An organization wants to offer a customer a 10% discount for 2 years on all work order products and services based on a preset price list. 

> **Scenario 2:** An organization wants to offer a customer free work order products and services for two years for work orders that relate to customer assets of a specified category.

## Prerequisites

- Field Service v8.4+

- Dynamics 365 Customer Service  

- Recommended: Knowledge of Dynamics 365 [price lists](/dynamics365/customer-engagement/sales-enterprise/create-price-lists-price-list-items-define-pricing-products)

## Scenario 1: Entitlement for price list and discount

In our first scenario, an organization wants to offer a customer a 10% discount for two years on all work order products and services based on a preset price list.

### Create a price list and add a product

To create an entitlement that adds a price list and a discount to work order products and services, you must first have a price list with associated products.

1. [Create a price list](create-price-list.md#create-a-price-list).

1. Add the products and services as [price list items](create-price-list.md#add-price-list-items) with the related prices.

   > [!TIP]
   > The **Field Service Product Type** on the product or service record indicates whether the product is inventory or a non-inventory product or if it's a service.

### Create an entitlement

1. In Field Service, change to the **Settings** area. Under **Service Delivery**, select **Entitlements**.

1. Select **New**.

1. Enter the following information:

   - **Name**: A unique name.

   - **Primary Customer:** The [account](accounts.md) for this entitlement. If the account chosen is later listed as the billing account of a work order, then this entitlement can be eligible. An entitlement can only apply to one customer; however, a billing account can be related to multiple service accounts, so work orders for multiple locations can have entitlements applied to all of them as long as the billing account is the same.

   - **Start/End Date:** The date range during which this entitlement is valid. If a valid work order is created within this range, the entitlement is applied.

   - **Entity Type:** Select **Work Order**.

   - **Allocation Type:** Select **Discount % and Price List**.

   - **Applies to:** Select **Both Work Order Products & Services** for this scenario. Entitlements can also be applied to only products or only services.

   - **Price List to Apply:** Select the price list that you want applied to the work order product and service when the entitlement is applied.

   - **% Discount:** Enter a number that represents the percent the price of the work order product or service should be discounted. If a Price List is applied, and the product or service is part of the price list, this value will discount the price list price. If it is not part of the price list, this value will discount the list price on the product record.

   - **Entitlement Prioritization:** If applicable, enter a number to represent the priority of this entitlement for instances when multiple entitlements apply to a single work order product or service. Entering "1" represents the highest priority. See more details in the **Entitlement conflicts** section of this article.

1. Select **Save** and **Activate** the entitlement.

   :::image type="content" source="media/entitlement-scenario1.svg" alt-text="Screenshot of an entitlement.":::

### Create a work order and add work order products and services

To use the entitlement, create a work order. 

1. [Create a work order](create-work-order.md). To trigger the entitlement, make sure the billing account is the same as the primary customer of the entitlement.

1. Select the **Products and services** tab and open a product or service record.

1. Select the **Other** tab. The entitlement is automatically chosen which overrides the price list on the work order with the price list on the entitlement.

   :::image type="content" source="media/entitlement-work-order-product1.svg" alt-text="Screenshot of entitlement applied to work order product.":::

   When the work order product **Line Status** is changed from **Estimated** to **Used**, the discount percentage is applied and changes the **Estimate Total Amount**.

   :::image type="content" source="media/entitlement-work-order-product-discount.svg" alt-text="Screenshot of discount applied to work order product from the entitlement.":::

## Scenario 2: Entitlement for free products and services for an asset category

In our second scenario, an organization wants to offer a customer free work order products and services for two years for work orders that relate to customer assets with a specified category.

This scenario uses an entitlement application to add more constraints on when an entitlement should apply to work order products and services.

### Create an entitlement for scenario 2

1. [Create an entitlement](#create-an-entitlement) with the **% Discount** set to 100% to make the work order products and services free when the entitlement is applied.

> [!div class="mx-imgBorder"]
> ![Screenshot of entitlement applications.](./media/entitlement-scenario2.png)

1. In the **Entitlement Applications** section, select the vertical ellipsis &vellip; and then **New Entitlement Application**.

> [!Note]
> Entitlement applications work in addition to the primary customer value, not in replacement of. For example, if the service account of an entitlement application matches a work order service account, but the billing account doesn't match the primary customer, then the entitlement isn't applied.

In the following example, if a work order product or service is related to a customer asset, *and* the customer asset belongs to the "Fabricam," then the entitlement is applicable.


> [!div class="mx-imgBorder"]
> ![Screenshot of an entitlement application calling for an asset category.](./media/entitlement-scenario2-entitlement-application.png)

Other applications are:

- **Service Account:** If the service account here matches the work order service account, then the entitlement will be applied to all work order products and services.

- **Customer Asset:** If the customer asset value here matches the customer asset on the work order product or service, then the entitlement will be applied to that work order product or service.

- **Incident Type:** If the incident type here matches the work order incident type on the work order product or service, then the entitlement will be applied to that work order product or service. 

> [!Note]
> Entitlement applications use AND logic. This means that if you specify a service account and an incident type then both need to be present on the work order to apply.


### Step 2: Create a customer asset 

Next, create a customer asset. In the following screenshot, you'll find a customer asset that has a category equal to "Wine Press" that we noted on the entitlement application. 

> [!div class="mx-imgBorder"]
> ![Screenshot of a customer asset with an asset category.](./media/entitlement-customer-asset.png)

### Step 3: Create a work order to service the customer asset

Now we will create a work order that matches the entitlement for the second scenario. In the following example, the billing account matches the primary customer. The primary incident customer asset lists an asset that belongs to the "Wine Press" category. 

> [!div class="mx-imgBorder"]
> ![Screenshot of a work order for the billing account and a customer asset the same as the entitlement.](./media/entitlement-work-order2.png)

The correct entitlement is applied to the work order products.

> [!div class="mx-imgBorder"]
> ![Screenshot of entitlement applied to the work order product.](./media/entitlement-work-order-product2.png)

Products and services added from the **Standard Inspection** incident type are related to the **Press Filter** customer asset.

> [!div class="mx-imgBorder"]
> ![Screenshot of customer asset related to the work order product.](./media/entitlement-work-order-product2-customer-asset.png)

Finally, the 100% discount is applied, rendering the work order products as free.
> [!div class="mx-imgBorder"]
> ![Screenshot of discount making the work order product free.](./media/entitlement-work-order-product2-discount.png)

The same entitlement effects apply to work order services as well.
> [!div class="mx-imgBorder"]
> ![Screenshot of entitlement applied to the work order service.](./media/entitlement-work-order-service2.png)


## Entitlement conflicts 

You can apply multiple entitlements to a single work order product or service. This is because entitlements can be applied based on different work order and work order product and service attributes that may all be present. For example, in the first scenario, the entitlement was applied based on the work order billing account; in the second scenario, the entitlement was applied based on the customer asset category. 

In such cases, all applicable entitlements will show as options in the entitlement lookup field.

> [!div class="mx-imgBorder"]
> ![Screenshot of 2 entitlements to choose from for a single work order product.](./media/entitlement-conflict-2-options.png)

However, one entitlement will be selected by default, first by the **Entitlement Prioritization** value, and second by the specificity.

The system will look at the entitlement prioritization values of all applicable entitlements and select the one with the highest priority (1 being the highest priority). Any priority value is greater than a blank priority value.

If no priority values exist or priority values are equal, the system will select the most specific entitlement. 

Using our previous examples, the second scenario entitlement is applicable based on the billing account and the customer asset category, whereas the first scenario entitlement is applicable based only on the billing account. In this case, the second scenario entitlement is more specific, since it's based on two factors and was chosen.

Even if multiple entitlements apply and 1 is chosen by default, the user can manually override or disable an entitlement.


## Configuration considerations

- **Applying different discounts**: In the event you want to apply a 10% discount on products and a 20% discount on services, this would require two entitlements.
  
- If the work order service account matches the primary customer of the entitlement and the billing account does not, the entitlement will not be applied. 

- **Applying entitlements to specific products or services**: Adding products and services to the products subgrid in an entitlement will apply the entitlement when the product or service matches the work order product or service.

> [!div class="mx-imgBorder"]
> ![Screenshot of product subgrid for an entitlement.](./media/entitlement-add-product.png)

## Additional notes
- Entitlements can't change the cost of a product or service, only the price. 

- For simpler scenarios, administrators should consider using the relationship between work order types, incident types, and price lists. Selecting an incident type can populate a work order type, and populating a work order type can populate a price list on the work order. This is configured during the incident type and work order type setup. Additionally, adding a price list to a work order will populate the price lists on work order products and services by default, but can be manually edited as needed. 

- Entitlements for work orders currently don't support quantity-based and limit-based entitlements (for example: a customer is entitled to 10 work orders or the first hour of a service is free).

- Entitlement application and price adjustment only happen online. If a work order product or work order service is created or edited when offline, the entitlement logic will only apply once that record syncs to the server.



[!INCLUDE[footer-include](../includes/footer-banner.md)]

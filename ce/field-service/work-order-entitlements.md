---
title: "Entitlements for work orders - Dynamics 365 Field Service | MicrosoftDocs"
description: Learn about how to use entitlements for work orders in Dynamics 365 Field Service
ms.custom: 
  - dyn365-fieldservice
ms.date: 03/17/2020
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.topic: article
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: FieldServiceDave
ms.author: daclar
manager: shellyha
search.app: 
  - D365CE
  - D365FS
---

# Entitlements for work orders in Dynamics 365 Field Service

Entitlements for work orders allow field service organizations to dynamically apply price lists and discounts to work order products and services based on work order attributes and date range factors. This parallels how organizations might offer case entitlements in Dynamics 365 Customer Service.

Entitlements can be applied to work orders based on:

- Billing account
- Service account
- Specific products and services
- Specific customer assets
- Customer asset categories
- Incident types

In this article, we will explore entitlements for work orders with two scenarios: 

> **Scenario 1:** An organization wants to offer a customer a 10% discount for 2 years on all work order products and services based on a preset price list. 

> **Scenario 2:** An organization wants to offer a customer free work order products and services for two years for work orders that relate to customer assets of a specified category.

## Prerequisites

- Field Service v8.4+

- Dynamics 365 Customer Service  

- Recommended: Knowledge of Dynamics 365 [price lists](/dynamics365/customer-engagement/sales-enterprise/create-price-lists-price-list-items-define-pricing-products)


## Scenario 1: Entitlement for price list and discount

In our first scenario, an organization wants to offer a customer a 10% discount for two years on all work order products and services based on a preset price list. 

### Step 1: Create a price list and add a product 

To create an entitlement that adds a price list and a discount to work order products and services, you must first have a price list with associated products.

Go to **Field Service > Settings > Price Lists** and create a new price list.

Then add the products and services as price list items with the related prices.

> [!div class="mx-imgBorder"]
> ![Screenshot of list of price lists](./media/entitlement-pricelist.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of price lsit items](./media/entitlement-pricelist-item.png)

**Bonus tip #1:** Products and services are both added in the product entity. Use the **Field Service Product Type** to distinguish them, and use **Inventory** and **Non-inventory** options for products, and the **Service** option for services. 

**Bonus tip #2:** Enter a list price for the product record if the product doesn't belong to a price list or if it doesn't belong to the price entered on the work order.

> [!div class="mx-imgBorder"]
> ![Screenshot of product details](./media/entitlement-product.png)

### Step 2: Create an entitlement

Go to **Field Service > Settings > Entitlement** and create a new entitlement.

> [!div class="mx-imgBorder"]
> ![Screenshot of list of entitlements](./media/entitlement-navigation.png)

You'll see the following fields:

- **Primary Customer:** Choose the account this entitlement will apply to. If the account chosen here is later listed as the billing account of a work order, then this entitlement can be eligible. An entitlement can only apply to one customer; however, a billing account can be related to multiple service accounts, so work orders for multiple locations can have entitlements applied to all of them as long as the billing account is the same.

- **Start/End Date:** Choose the date range during which this entitlement is valid. If a valid work order is created within this range, the entitlement will be applied.

- **Entity Type:** Select **Work Order**.

- **Allocation Type:** Select **Discount %** and **Price List**. 

- **Applies to:** Select **Both Work Order Products & Services** for this scenario. Entitlements can also be applied to only products or only services.

- **Price List to Apply:** Select the price list that you want applied to the work order product and service when the entitlement is applied.

- **% Discount:** Enter a number that represents the percent the price of the work order product or service should be discounted. If a Price List is applied, and the product or service is part of the price list, this value will discount the price list price. If it is not part of the price list, this value will discount the list price on the product record.

- **Entitlement Prioritization:** If applicable, enter a number to represent the priority of this entitlement for instances when multiple entitlements apply to a single work order product or service. Entering "1" represents the highest priority. See more details in the **Entitlement conflicts** section of this article.

**Save** and **Activate** the entitlement.


> [!div class="mx-imgBorder"]
> ![Screenshot of entitlement](./media/entitlement-scenario1.png)

### Step 3: Create a work order and add work order products and services

Next, create a work order your entitlement will apply to.

In the following screenshot, you'll see a work order with a billing account that is the same as the primary customer of the entitlement. This triggers the entitlement to apply to this work order.

> [!div class="mx-imgBorder"]
> ![Screenshot of new work order where the billing account matches the entitlement primary customer](./media/entitlement-work-order1.png)


Select the products tab to view work order products. Products are typically added to work orders either manually or automatically from work order incidents. 

> [!div class="mx-imgBorder"]
> ![Screenshot of work order product list](./media/entitlement-work-order-product-list.png)

In the **Other** tab of the work order product, the entitlement is automatically chosen. This means the price list chosen on the entitlement is added to the work order product as well, even if this differs from the price list on the work order. 

> [!div class="mx-imgBorder"]
> ![Screenshot of entitlement applied to work order product](./media/entitlement-work-order-product1.png)

> [!Note]
> The work order price list applies to work order products and services by default but an entitlement will override this and apply directly to the work order products and services. 

The discount percentage is also applied because of the entitlement, and this edits the estimate total amount. If the work order line status is changed from **Estimated** to **Used**, this is the price that will be billed to the customer.

> [!div class="mx-imgBorder"]
> ![Screenshot of discount applied to work order product from the entitlement](./media/entitlement-work-order-product-discount.png)


## Scenario 2: Entitlement for free products and services for an asset category

In our second scenario, an organization wants to offer a customer free work order products and services for two years for work orders that relate to customer assets with a specified category.

### Step 1: Create an entitlement

Go to **Entitlements** and create a new one.

This entitlement is similar to the previous one; however, **% Discount** is now set to 100% to make the work order products and services free when the entitlement is applied.


> [!div class="mx-imgBorder"]
> ![Screenshot of entitlement applications](./media/entitlement-scenario2.png)

From the entitlement, create a new entitlement application to add more details to when the entitlement should be applied.

Given the primary customer of the entitlement matches the billing account on the work order, entitlement applications allow you to add more constraints to when an entitlement should apply to work order products and services.

> [!Note]
> Entitlement applications work in addition to the primary customer value, not in replacement of. For example, if the service account of an entitlement application matches a work order service account, but the billing account doesn't match the primary customer, then the entitlement will not be applied. 

In the following example, if a work order product or service is related to a customer asset, *and* the customer asset belongs to the "Wine Press Asset Category," then the entitlement is applicable. 


> [!div class="mx-imgBorder"]
> ![Screenshot of an entitlement application calling for an asset category](./media/entitlement-scenario2-entitlement-application.png)

Other applications are:

- **Service Account:** If the service account here matches the work order service account, then the entitlement will be applied to all work order products and services.

- **Customer Asset:** If the customer asset value here matches the customer asset on the work order product or service, then the entitlement will be applied to that work order product or service.

- **Incident Type:** If the incident type here matches the work order incident type on the work order product or service, then the entitlement will be applied to that work order product or service. 

> [!Note]
> Entitlement applications use AND logic. This means that if you specify a service account and an incident type then both need to be present on the work order to apply.


### Step 2: Create a customer asset 

Next, create a customer asset. In the following screenshot, you'll find a customer asset that has a category equal to "Wine Press" that we noted on the entitlement application. 

> [!div class="mx-imgBorder"]
> ![Screenshot of a customer asset with an asset category](./media/entitlement-customer-asset.png)

### Step 3: Create a work order to service the customer asset

Now we will create a work order that matches the entitlement for the second scenario. In the following example, the billing account matches the primary customer. The primary incident customer asset lists an asset that belongs to the "Wine Press" category. 

> [!div class="mx-imgBorder"]
> ![Screenshot of a work order for the billing account and a customer asset the same as the entitlement](./media/entitlement-work-order2.png)

The correct entitlement is applied to the work order products.

> [!div class="mx-imgBorder"]
> ![Screenshot of entitlement applied to the work order product](./media/entitlement-work-order-product2.png)

Products and services added from the **Standard Inspection** incident type are related to the **Press Filter** customer asset.

> [!div class="mx-imgBorder"]
> ![Screenshot of customer asset related to the work order product](./media/entitlement-work-order-product2-customer-asset.png)

Finally, the 100% discount is applied, rendering the work order products as free.
> [!div class="mx-imgBorder"]
> ![Screenshot of discount making the work order product free](./media/entitlement-work-order-product2-discount.png)

The same entitlement effects apply to work order services as well.
> [!div class="mx-imgBorder"]
> ![Screenshot of entitlement applied to the work order service](./media/entitlement-work-order-service2.png)


## Entitlement conflicts 

You can apply multiple entitlements to a single work order product or service. This is because entitlements can be applied based on different work order and work order product and service attributes that may all be present. For example, in the first scenario, the entitlement was applied based on the work order billing account; in the second scenario, the entitlement was applied based on the customer asset category. 

In such cases, all applicable entitlements will show as options in the entitlement lookup field.

> [!div class="mx-imgBorder"]
> ![Screenshot of 2 entitlements to choose from for a single work order product](./media/entitlement-conflict-2-options.png)

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
> ![Screenshot of product subgrid for an entitlement](./media/entitlement-add-product.png)

## Additional notes
- Entitlements can't change the cost of a product or service, only the price. 

- For simpler scenarios, administrators should consider using the relationship between work order types, incident types, and price lists. Selecting an incident type can populate a work order type, and populating a work order type can populate a price list on the work order. This is configured during the incident type and work order type setup. Additionally, adding a price list to a work order will populate the price lists on work order products and services by default, but can be manually edited as needed. 

- Entitlements for work orders currently don't support quantity-based and limit-based entitlements (for example: a customer is entitled to 10 work orders or the first hour of a service is free).

- Entitlement application and price adjustment only happen online. If a work order product or work order service is created or edited when offline, the entitlement logic will only apply once that record syncs to the server.



[!INCLUDE[footer-include](../includes/footer-banner.md)]
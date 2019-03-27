---
title: "Entitlements for Work Orders | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 03/25/2019
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: krbjoran
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: FieldServiceDave
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---

# Entitlements for Work Orders

Entitlements for work orders allow a field service organization to dynamically apply price lists and discounts to work order products and services based on work order attributes and date range factors. This is achieved through the same process and entities an organization would offer case entitlements in Dynamics 365 for Customer Service.

Entitlements can be applied to work orders based on:

- Billing account
- Service account
- Specific products and services
- Specific customer assets
- Customer asset categories
- Incident types

Let's explore entitlements for work orders with two scenarios: 

> **Scenario 1:** An organization would like to offer a customer a 10% discount for two years on all work order products and services based on a preset price list. 

> **Scenario 2:** An organization would like to offer a customer free work order products and services for two years for work orders that relate to customer assets of a specified category.

## Prerequisites
Field Service v8.4+

Dynamics 365 for Customer Service  

Knowledge of Dynamics 365 [price lists](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/sales-enterprise/create-price-lists-price-list-items-define-pricing-products) is recommended


## Scenario 1: Entitlement for price list and discount

An organization would like to offer a customer a 10% discount for two years on all work order products and services based on a preset price list. 

### Step 1: Create a price list and add a product 

To create an entitlement that adds a price list and a discount to work order products and services, you must first have a price list with associated products.

Go to **Field Service > Settings > Price Lists** and create a new price list.


Then add the products and services as price list items with the related prices.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/entitlement-pricelist.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/entitlement-pricelist-item.png)

**Pro Tip #1:** Products and services are both added in the product entity, simply use the **Field Service Product Type** to distinguish them, using **Inventory** and **Non-inventory** options for products, and the **Service** option for Services. 

**Pro Tip #2:** Enter a list price for the product record that is used if the product does not belong to a price list or if it does not belong to the price entered on the work order.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/entitlement-product.png)

### Step 2: Create an entitlement

Go to **Field Service > Settings > Entitlement** and create a new entitlement.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/entitlement-navigation.png)


**Primary Customer:** Choose the account this entitlement will apply to. If the account chosen here is later listed as the billing account of a work order then this entitlement can be eligible. An entitlement can only apply to one customer, however a billing account can be related to multiple service accounts, so work orders for multiple locations can have entitlements applied to all of them as long as the billing account is the same.

**Start/End Date:** choose the date range this entitlement is valid for, if a valid work order is created within this range the entitlement will be applied.

**Entity Type:** Select Work Order.

**Allocation Type:** Select Discount % and Price List. This is currently the only option available and more will appear as the feature develops.

**Applies to:** Select Both Work Order Products & Services for this scenario. It is possible to have an entitlement only apply to either products or services.

**Price List to Apply:** Select the price list that you want applied to the work order product and service when the entitlement is applied.

**% Discount:** Enter a number that represents the percent the price of the work order product or service should be discounted. If a Price List is applied, and the product or service is part of the price list, this value will discount the price list price. If it is not part of the price list, this value will discount the list price on the product record.

**Entitlement Prioritization:** If applicable enter a number to represent the priority of this entitlement for instances when multiple entitlements apply to a single work order product or service. Entering "1" represents the highest priority. See more details in the **Entitlement conflicts** section of this article.

**Save** and **Activate** the entitlement.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/entitlement-scenario1.png)

### Step 3: Create a work order and add work order products and services

Next create a work order the entitlement you just created will apply to.

In the image below is a work order with a billing account that is the same as the primary customer of the entitlement. This triggers the entitlement to apply to this work order.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/entitlement-work-order1.png)


Select the products tab to view work order products. Products are typically added to work orders automatically by from work order incidents or manually. However the work order products are added, the entitlement will apply.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/entitlement-work-order-product-list.png)

In the Other tab of the work order product, the entitlement is automatically chosen. This means the price list chosen on the entitlement is added to the work order product as well, even if this differs from the price list on the work order. 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/entitlement-work-order-product1.png)

> [!Note]
> The work order price list applies to work order products and services by default but an entitlement will override this and apply directly to the work order products and services. 

The discount percentage is also applied because of the entitlement and this edits the estimate total amount. If the work order line status is changed from Estimated to Used, this is the price that will be billed to the customer.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/entitlement-work-order-product-discount.png)


## Scenario 2: Entitlement for free products and services for an asset category

An organization would like to offer a customer free work order products and services for two years for work orders that relate to customer assets of a specified category.

### Step 1: Create an entitlement

Go to entitlements and create a new one.

This entitlement is similar to the previous one however the **% Discount** is set to 100% to make the work order products and services free when the entitlement is applied.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/entitlement-scenario2.png)

Create a new Entitlement Application to add more details to when the entitlement should be applied.

Given the primary customer of the entitlement matches the billing account on the work order, entitlement applications allow you to add more constraints to when an entitlement should apply to work order products. t

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/entitlement-scenario2-entitlement-application.png)


> [!Note]
> Entitlement Application work in addition to primary customer, not in replacement of. As an example.. 

### Step 2: Create a customer asset 

First create a customer asset.
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/entitlement-customer-asset.png)

### Step 3: Create a work order to service the customer asset


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/entitlement-work-order2.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/entitlement-work-order-product2.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/entitlement-work-order-product2-customer-asset.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/entitlement-work-order-product2-discount.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/entitlement-work-order-service2.png)


## Entitlement conflicts 

- handling conflicts?
  - prioritization 1 is highest
  - a product/service can be eligible for multiple entitlements 
  - tie break goes to specificity 
  -  
  - can override entitlement if other entitlements are applicable
  - - adding a new entitlement 
see products and services, entitlement applied 


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/entitlement-conflict-2-options.png)


## Configuration considerations
- example: if you wanted to give 10% on products and 20% on services you would need 2 entitlements
- what if primary customer on entitlement is service account and not billing account? what if the billing account isnt present but the service account is?
- adding a product means the entitlement will apply when the product or service on the work order product or service is there? - yes


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/entitlement-add-product.png)

## Additional Notes
cost doesnt change
  - - how does this work with incident types?
    - incident types can apply work order types and WOT can apply price lists!
  - - what if entitlement is edited?
  - why is this needed, why cant i just add special price lists?
  - currently unsupported scenarios
    -  examples warranty (currently not supported)
    - quantity based and limit based - limited number of work orders (currently not supported)
    - what if product is not part of price list?

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

Entitlements for work orders allow a field service organization to dynamically apply price lists and discounts to work order products and services based on multiple factors. This is achieved through the same processes an organization would use Dynamics 365 for Customer Service to apply entitlements for cases.


Entitlements in Dynamics 365 are privileges an organization offers to their customers. Entitlements have historically been a 
extending entitlement functionality for customer service to field service





multiple different entitlements that impact the same work order

**Scenario 1:** Offer a specific customer an entitlement for a special price list and a 10% discount applied to all work order products and services.

**Scenario 2:** Offer a specific customer an entitlement for free work order products and services for two years for managed asset within a specified category.

## Prerequisites
Field Service v8.4+

Dynamics 365 for Customer Service  

Knowledge of Dynamics 365 [price lists](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/sales-enterprise/create-price-lists-price-list-items-define-pricing-products) is recommended

> [!Note]
> 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

## Scenario 1: entitlement for price list and discount

### Step 1: Create a price list and add a product 
- products have a list price as well
- field service product type


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/entitlement-pricelist.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/entitlement-pricelist-item.png)

**Pro Tip:**

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/entitlement-product.png)

### Step 2: Create an entitlement
- select work order
- must be billing acount
- allocation type 
- manipulate discount, price list or both


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/entitlement-navigation.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/entitlement-scenario1.png)

### Step 3: Create a work order and add work order products and services


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/entitlement-work-order1.png)

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/entitlement-work-order-product-list.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/entitlement-work-order-product1.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/entitlement-work-order-product-discount.png)


## Scenario 2: entitlement for free products and services for an asset category

### Step 1: Create a customer asset 


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/entitlement-customer-asset.png)

### Step 2: Create an entitlement


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/entitlement-scenario2.png)



> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/entitlement-scenario2-entitlement-application.png)

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
- -what if primary customer on entitlement is service account and not billing account? what if the billing account isnt present but the service account is?
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

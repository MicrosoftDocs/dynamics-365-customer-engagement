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


extending entitlement functionality for customer service to field service

- privileges that your customers are entitled to
- currently focused on pricing and discounts based on factors
- examples warranty (currently not supported)
- quantity based and limit based - limited number of work orders (currently not supported)

multiple different entitlements that impact the same work order

**Scenario 1:** Offer a specific customer an entitlement for a special price list and a 10% discount applied to all work order products and services.
**Scenario 2:** Offer a specific customer an entitlement for free work order products and services for two years for managed asset within a specified category.

## Prerequisites
Field Service v8.4+
Customer Service
Knowledge of Dynamics 365 price lists is recommended

> [!Note]
>

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

## Scenario 1: entitlement for price list and discount

Step 1: Create a price list and add a product 

Step 2: Create an entitlement
- select work order
- must be billing acount
- allocation type 
- manipulate discount, price list or both


Step 3: Create a work order and add work order products and services


## Scenario 2: entitlement for free products and services for an asset category

Step 1: create a customer asset with an asset category

Step 2: create an entitlement

Step 3: create a work order for the customer asset

## Entitlement conflicts 

- handling conflicts?
  - prioritization 1 is highest
  - a product/service can be eligible for multiple entitlements 
  - tie break goes to specificity 
  -  
  - can override entitlement if other entitlements are applicable
  - - adding a new entitlement 
see products and services, entitlement applied 

## Configuration considerations
- example: if you wanted to give 10% on products and 20% on services you would need 2 entitlements

## Additional Notes
cost doesnt change
  - - how does this work with incident types?
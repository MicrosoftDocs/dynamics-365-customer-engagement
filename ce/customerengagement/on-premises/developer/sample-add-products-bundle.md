---
title: "Sample: Add products to a bundle (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Sample demonstrates how to add products to a product bundle."
ms.custom: 
ms.date: 01/02/2020
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
ms.assetid: 58197c02-43e2-4856-bf81-a37b32953b90
author: KumarVivek
ms.author: kvivek
manager: annbe
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Add products to a bundle

This sample shows how to add products to a bundle. You can download the sample from [here](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/sales/AddProductsBundle).

[!include[cc-sample-note.md](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-samples.md)]
## What this sample does

This sample shows how to add products to a bundle..

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

1. Checks for the current version of the org. 

### Demonstrate

- Create a bundle record.
- Create a unit group.
- Retrieve the unit id.
- Create a price list
- Create couple of product records.
- Create price list items for the products.
- Create price list item for the bundle
- Add products to a bundle. 

### Clean up

Displays an option to delete all the data created in the sample. The deletion is optional in case you want to examine the data created by the sample. You can manually delete the data to achieve same results.  
  
### See also  
 [Create and manage product families, products and bundles](create-manage-product-families-products-bundles-product-properties.md)</br/>   
 [Product catalog entities](product-catalog-entities.md)

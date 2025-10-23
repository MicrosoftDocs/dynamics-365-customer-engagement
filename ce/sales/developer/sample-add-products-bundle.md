---
title: "Sample: Add products to a bundle (Dynamics 365 Sales)"
description: Sample demonstrates how to add products to a product bundle.
ms.date: 03/01/2023
ms.topic: sample
author: udaykirang
ms.author: udag
ms.reviewer: udag
search.audienceType: 
  - developer
---
# Sample: Add products to a bundle

This sample shows how to add products to a bundle. You can download the sample from [here](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/sales/AddProductsBundle).

> [!NOTE]
> You can add or delete products only when the bundle is in draft or retired state. To add or delete products in a bundle that is in active or under revision state, clone the product bundle. This creates a new bundle with a new ID in draft state. You can then add or delete products in the new bundle.

## How to run this sample

[!include[cc-how-to-run-samples](../../includes/cc-how-to-run-samples.md)]
## What this sample does

This sample shows how to add products to a bundle.

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
  
## Related information

 [Create and manage product families, products and bundles](create-manage-product-families-products-bundles-product-properties.md)  
 [Product catalog tables](product-catalog-entities.md)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]

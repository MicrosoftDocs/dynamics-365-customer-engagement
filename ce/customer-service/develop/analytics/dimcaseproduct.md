---
title: DimCaseProduct table reference
description: Learn more about product identity, source fields, availability, and reporting relationships in DimCaseProduct.
ms.date: 10/30/2026
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ai-usage: ai-assisted
---

# DimCaseProduct table reference

Use `DimCaseProduct` to compare support demand by the product associated with each case.

## Business value

Use the **Product** filter on the Summary page, the product volume chart, and the top product/type card to analyze cases by product. Product reporting requires available product information and cases linked to those products.

## Grain and source tables

The optional `product` source supplies one row per `ProductId`. Rows with null source IDs are excluded. For multiple versions, the latest `modifiedon` is retained when available.

Product analysis can be empty when product data or the case product mapping is unavailable. An empty product view doesn't mean that no cases exist.

## Columns

| Column | Type | Source field | Description |
|---|---|---|---|
| `ProductId` | STRING | `product.productid` | Product identifier and primary key. |
| `ProductName` | STRING | `product.name` | Product display name. |
| `ProductNumber` | STRING | `product.productnumber` | Business product number. |
| `_LastRefreshedDateTimeUtc` | TIMESTAMP | System | Date and time of the pipeline refresh. |

Optional attributes remain null when unavailable. 

## Dashboard relationships

Create single-direction, one-to-many relationships from `ProductId` to the matching column on `AggCaseAnalytics`, `AggCaseSLA`, and `AggCaseSnapshot`. The case key comes from `incident.productid`.

Use products to group and compare cases, not as values to add together. The top product/type card shows which combination of product and case type has the most cases.

## Related information

[DimCaseType](dimcasetype.md)          
[Case analytics data model](case-data-model.md)      

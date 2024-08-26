---
title: "Price List Item (ProductPriceLevel) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Price List Item (ProductPriceLevel) table/entity with Microsoft Dynamics 365 Customer Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Price List Item (ProductPriceLevel) table/entity reference (Microsoft Dynamics 365 Customer Service)

Information about how to price a product in the specified price level, including pricing method, rounding option, and discount type based on a specified product unit.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Price List Item (ProductPriceLevel) table extends the [Microsoft Dynamics 365 Price List Item (ProductPriceLevel) table](/dynamics365/developer/entities/productpricelevel).




## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_transactioncurrency_productpricelevel"></a> transactioncurrency_productpricelevel

One-To-Many Relationship: [transactioncurrency transactioncurrency_productpricelevel](transactioncurrency.md#BKMK_transactioncurrency_productpricelevel)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   


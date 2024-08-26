---
title: "Discount List (DiscountType) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Discount List (DiscountType) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Discount List (DiscountType) table/entity reference (Microsoft Dynamics 365 Field Service)

Type of discount specified as either a percentage or an amount.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Discount List (DiscountType) table extends the [Microsoft Dynamics 365 Discount List (DiscountType) table](/dynamics365/developer/entities/discounttype).




## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_transactioncurrency_discounttype"></a> transactioncurrency_discounttype

One-To-Many Relationship: [transactioncurrency transactioncurrency_discounttype](transactioncurrency.md#BKMK_transactioncurrency_discounttype)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   


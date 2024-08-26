---
title: "Discount table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Discount table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Discount table/entity reference (Microsoft Dynamics 365 Field Service)

Price reduction made from the list price of a product or service based on the quantity purchased.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Discount table extends the [Microsoft Dynamics 365 Discount table](/dynamics365/developer/entities/discount).




## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_transactioncurrency_discount"></a> transactioncurrency_discount

One-To-Many Relationship: [transactioncurrency transactioncurrency_discount](transactioncurrency.md#BKMK_transactioncurrency_discount)

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


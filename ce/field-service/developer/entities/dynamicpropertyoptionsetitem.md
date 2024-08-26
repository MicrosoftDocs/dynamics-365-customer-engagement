---
title: "Property Option Set Item (DynamicPropertyOptionSetItem) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Property Option Set Item (DynamicPropertyOptionSetItem) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Property Option Set Item (DynamicPropertyOptionSetItem) table/entity reference (Microsoft Dynamics 365 Field Service)

Item with a name and value in a property option set type.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Property Option Set Item (DynamicPropertyOptionSetItem) table extends the [Microsoft Dynamics 365 Property Option Set Item (DynamicPropertyOptionSetItem) table](/dynamics365/developer/entities/dynamicpropertyoptionsetitem).




## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_DynamicPropertyOptionSetItem_TransactionCurrency"></a> DynamicPropertyOptionSetItem_TransactionCurrency

One-To-Many Relationship: [transactioncurrency DynamicPropertyOptionSetItem_TransactionCurrency](transactioncurrency.md#BKMK_DynamicPropertyOptionSetItem_TransactionCurrency)

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


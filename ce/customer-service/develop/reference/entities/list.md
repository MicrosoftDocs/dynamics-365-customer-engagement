---
title: "Marketing List (List) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Marketing List (List) table/entity with Microsoft Dynamics 365 Customer Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Marketing List (List) table/entity reference (Microsoft Dynamics 365 Customer Service)

Group of existing or potential customers created for a marketing campaign or other sales purposes.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Marketing List (List) table extends the [Microsoft Dynamics 365 Marketing List (List) table](/dynamics365/developer/entities/list).




## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_transactioncurrency_list"></a> transactioncurrency_list

One-To-Many Relationship: [transactioncurrency transactioncurrency_list](transactioncurrency.md#BKMK_transactioncurrency_list)

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


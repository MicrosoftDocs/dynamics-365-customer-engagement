---
title: "Opportunity Sales Process (OpportunitySalesProcess) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Opportunity Sales Process (OpportunitySalesProcess) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Opportunity Sales Process (OpportunitySalesProcess) table/entity reference (Microsoft Dynamics 365 Field Service)

Opportunity Sales Process Business Process Flow

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Opportunity Sales Process (OpportunitySalesProcess) table extends the [Microsoft Dynamics 365 Opportunity Sales Process (OpportunitySalesProcess) table](/dynamics365/developer/entities/opportunitysalesprocess).




## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_transactioncurrency_opportunitysalesprocess"></a> transactioncurrency_opportunitysalesprocess

One-To-Many Relationship: [transactioncurrency transactioncurrency_opportunitysalesprocess](transactioncurrency.md#BKMK_transactioncurrency_opportunitysalesprocess)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   


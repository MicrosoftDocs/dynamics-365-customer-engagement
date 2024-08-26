---
title: "Opportunity Close (OpportunityClose) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Opportunity Close (OpportunityClose) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Opportunity Close (OpportunityClose) table/entity reference (Microsoft Dynamics 365 Field Service)

Activity that is created automatically when an opportunity is closed, containing information such as the description of the closing and actual revenue.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Opportunity Close (OpportunityClose) table extends the [Microsoft Dynamics 365 Opportunity Close (OpportunityClose) table](/dynamics365/developer/entities/opportunityclose).




## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_transactioncurrency_opportunityclose"></a> transactioncurrency_opportunityclose

One-To-Many Relationship: [transactioncurrency transactioncurrency_opportunityclose](transactioncurrency.md#BKMK_transactioncurrency_opportunityclose)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid_opportunityclose`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   


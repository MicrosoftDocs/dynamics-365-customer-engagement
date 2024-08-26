---
title: "Opportunity Product (OpportunityProduct) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Opportunity Product (OpportunityProduct) table/entity with Microsoft Dynamics 365 Customer Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Opportunity Product (OpportunityProduct) table/entity reference (Microsoft Dynamics 365 Customer Service)

Association between an opportunity and a product.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Opportunity Product (OpportunityProduct) table extends the [Microsoft Dynamics 365 Opportunity Product (OpportunityProduct) table](/dynamics365/developer/entities/opportunityproduct).




## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_transactioncurrency_opportunityproduct"></a> transactioncurrency_opportunityproduct

One-To-Many Relationship: [transactioncurrency transactioncurrency_opportunityproduct](transactioncurrency.md#BKMK_transactioncurrency_opportunityproduct)

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


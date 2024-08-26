---
title: "Lead To Opportunity Sales Process (LeadToOpportunitySalesProcess) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Lead To Opportunity Sales Process (LeadToOpportunitySalesProcess) table/entity with Microsoft Dynamics 365 Customer Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Lead To Opportunity Sales Process (LeadToOpportunitySalesProcess) table/entity reference

Lead To Opportunity Sales Process Business Process Flow

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Lead To Opportunity Sales Process (LeadToOpportunitySalesProcess) table extends the [Microsoft Dynamics 365 Lead To Opportunity Sales Process (LeadToOpportunitySalesProcess) table](/dynamics365/developer/entities/leadtoopportunitysalesprocess).




## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_transactioncurrency_leadtoopportunitysalesprocess"></a> transactioncurrency_leadtoopportunitysalesprocess

One-To-Many Relationship: [transactioncurrency transactioncurrency_leadtoopportunitysalesprocess](transactioncurrency.md#BKMK_transactioncurrency_leadtoopportunitysalesprocess)

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


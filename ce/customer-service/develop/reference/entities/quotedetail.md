---
title: "Quote Product (QuoteDetail) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Quote Product (QuoteDetail) table/entity with Microsoft Dynamics 365 Customer Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Quote Product (QuoteDetail) table/entity reference (Microsoft Dynamics 365 Customer Service)

Product line item in a quote. The details include such information as product ID, description, quantity, and cost.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Quote Product (QuoteDetail) table extends the [Microsoft Dynamics 365 Quote Product (QuoteDetail) table](/dynamics365/developer/entities/quotedetail).




## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_transactioncurrency_quotedetail"></a> transactioncurrency_quotedetail

One-To-Many Relationship: [transactioncurrency transactioncurrency_quotedetail](transactioncurrency.md#BKMK_transactioncurrency_quotedetail)

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


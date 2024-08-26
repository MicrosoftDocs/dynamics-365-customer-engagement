---
title: "Quote Close (QuoteClose) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Quote Close (QuoteClose) table/entity with Microsoft Dynamics 365 Customer Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Quote Close (QuoteClose) table/entity reference

Activity generated when a quote is closed.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Quote Close (QuoteClose) table extends the [Microsoft Dynamics 365 Quote Close (QuoteClose) table](/dynamics365/developer/entities/quoteclose).




## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_quoteclose_transactioncurrency_transactioncurrencyid"></a> quoteclose_transactioncurrency_transactioncurrencyid

One-To-Many Relationship: [transactioncurrency quoteclose_transactioncurrency_transactioncurrencyid](transactioncurrency.md#BKMK_quoteclose_transactioncurrency_transactioncurrencyid)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid_quoteclose`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

